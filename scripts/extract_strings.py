#!/usr/bin/env python3
"""
PvZ Fusion - Complete Offline Localization Extractor & Diffing Pipeline
Extracts 100% of text strings from Unity data (global-metadata.dat, data.unity3d, TextAssets)
and source decompilations without relying on runtime screen dumps.

Usage:
    python scripts/extract_strings.py
    python scripts/extract_strings.py --game-path "D:/PvZ Fusion/BepInEx Game Files" --out-path "Localization_Delta"
"""

import os
import sys
import re
import json
import struct
import argparse
from collections import defaultdict

if sys.stdout.encoding != 'utf-8':
    try:
        sys.stdout.reconfigure(encoding='utf-8')
    except Exception:
        pass

DEFAULT_GAME_PATH = r"D:\PvZ Fusion\BepInEx Game Files"
DEFAULT_LOC_PATH = r"D:\VSCode\PVZF-Translation\PvZ_Fusion_Translator\Localization\Vietnamese"
DEFAULT_OUT_PATH = r"D:\VSCode\PvZ-Fusion-Translator 2\Localization_Delta"

CJK_REGEX = re.compile(r'[\u4e00-\u9fff]')
NUMBER_REGEX = re.compile(r'(?<![A-Za-z0-9_])\d+(?:\.\d+)?(?![A-Za-z0-9_])')
FORMAT_PLACEHOLDER_REGEX = re.compile(r'\{(\d+)(?::[^}]+)?\}')
SURROGATE_REGEX = re.compile(r'[\ud800-\udfff]')

def sanitize_str(s: str) -> str:
    """Strip surrogates and trailing/leading whitespace."""
    if not isinstance(s, str):
        return ""
    return SURROGATE_REGEX.sub('', s).strip()

def is_valid_chinese(s: str) -> bool:
    """Filter out non-CJK and corrupted latin1/mojibake bytes."""
    if not isinstance(s, str) or len(s) < 1:
        return False
    if not CJK_REGEX.search(s):
        return False
    weird_count = sum(1 for c in s if '\x80' <= c <= '\xff')
    if weird_count > 0:
        return False
    return True

def read_json_multi_enc(path: str):
    """Read JSON file trying multiple encodings (UTF-16, UTF-16LE, UTF-8-SIG, UTF-8)."""
    if not os.path.exists(path):
        return None
    raw = open(path, "rb").read()
    for enc in ("utf-16", "utf-16-le", "utf-8-sig", "utf-8"):
        try:
            return json.loads(raw.decode(enc))
        except Exception:
            pass
    return None

def extract_metadata_strings(meta_path: str) -> set:
    """Extract string literals directly from IL2CPP global-metadata.dat."""
    strings = set()
    if not os.path.exists(meta_path):
        print(f"[!] global-metadata.dat not found at {meta_path}")
        return strings

    try:
        with open(meta_path, 'rb') as f:
            f.seek(8)
            str_lit_offset, str_lit_count, str_lit_data_offset, str_lit_data_count = struct.unpack('<IIII', f.read(16))

            f.seek(str_lit_data_offset)
            raw_data = f.read(str_lit_data_count)

            f.seek(str_lit_offset)
            entry_count = str_lit_count // 8
            for _ in range(entry_count):
                length, offset = struct.unpack('<II', f.read(8))
                if offset + length <= len(raw_data):
                    chunk = raw_data[offset:offset+length]
                    try:
                        decoded = chunk.decode('utf-8')
                        if is_valid_chinese(decoded):
                            s = sanitize_str(decoded)
                            if not s.startswith(('{', '}', '[', ']', '"name":', '"info":', '"introduce":', 'http://', 'https://')):
                                strings.add(s)
                    except Exception:
                        pass
        print(f"[*] Extracted {len(strings):,} clean string literals from global-metadata.dat")
    except Exception as ex:
        print(f"[!] Error reading global-metadata.dat: {ex}")

    return strings

def extract_almanac_and_textassets(data_path: str):
    """Extract raw Plant/Zombie Almanac data and custom level TextAssets from data.unity3d."""
    asset_strings = set()
    raw_plants = []
    raw_zombies = []

    try:
        import UnityPy
    except ImportError:
        print("[!] UnityPy not installed. Run `pip install UnityPy` to scan data.unity3d.")
        return asset_strings, raw_plants, raw_zombies

    if not os.path.exists(data_path):
        print(f"[!] data.unity3d not found at {data_path}")
        return asset_strings, raw_plants, raw_zombies

    try:
        print(f"[*] Scanning Unity data file: {data_path}...")
        env = UnityPy.load(data_path)
        for obj in env.objects:
            if obj.type.name == "TextAsset":
                try:
                    d = obj.read()
                    name = sanitize_str(getattr(d, 'm_Name', ''))
                    text = getattr(d, 'm_Script', '')
                    if isinstance(text, bytes):
                        text = text.decode('utf-8', errors='replace')
                    text = sanitize_str(text)

                    if name == "LawnStrings" or "Plant" in name:
                        try:
                            parsed = json.loads(text)
                            if isinstance(parsed, dict) and "plants" in parsed:
                                raw_plants.extend(parsed["plants"])
                        except Exception:
                            pass

                    if name == "ZombieStrings" or "Zombie" in name:
                        try:
                            parsed = json.loads(text)
                            if isinstance(parsed, dict) and "zombies" in parsed:
                                raw_zombies.extend(parsed["zombies"])
                        except Exception:
                            pass

                    if not text.startswith("{"):
                        for line in text.splitlines():
                            line = sanitize_str(line)
                            if is_valid_chinese(line):
                                asset_strings.add(line)
                except Exception:
                    pass
        print(f"[*] Extracted {len(raw_plants):,} Almanac plant profiles, {len(raw_zombies):,} zombie profiles, {len(asset_strings):,} level text lines.")
    except Exception as ex:
        print(f"[!] Error scanning Unity assets: {ex}")

    return asset_strings, raw_plants, raw_zombies

def load_existing_translations(loc_path: str):
    """Load all existing translation files to diff against."""
    existing_strings = set()
    existing_regexes = set()
    existing_plants = set()
    existing_zombies = set()

    if not os.path.exists(loc_path):
        print(f"[!] Localization folder not found at {loc_path}")
        return existing_strings, existing_regexes, existing_plants, existing_zombies

    for root, _, files in os.walk(loc_path):
        for fname in files:
            if not fname.endswith(".json"):
                continue
            fpath = os.path.join(root, fname)
            data = read_json_multi_enc(fpath)
            if not isinstance(data, dict):
                continue

            if "regex" in fname.lower():
                existing_regexes.update(data.keys())
            elif "plants" in data:
                for p in data["plants"]:
                    if isinstance(p, dict):
                        if "seedType" in p: existing_plants.add(p["seedType"])
                        if "name" in p and p["name"]: existing_strings.add(p["name"].strip())
            elif "zombies" in data:
                for z in data["zombies"]:
                    if isinstance(z, dict):
                        if "zombieType" in z: existing_zombies.add(z["zombieType"])
                        if "name" in z and z["name"]: existing_strings.add(z["name"].strip())
            else:
                for k, v in data.items():
                    if is_valid_chinese(k):
                        existing_strings.add(k.strip())
                    if isinstance(v, dict) and "name" in v and is_valid_chinese(v["name"]):
                        existing_strings.add(v["name"].strip())

    print(f"[*] Loaded existing translations: {len(existing_strings):,} unique strings, {len(existing_regexes):,} regexes, {len(existing_plants):,} plants.")
    return existing_strings, existing_regexes, existing_plants, existing_zombies

def cluster_and_classify_strings(all_cjk_strings, existing_strings, existing_regexes):
    """Categorize strings into static translations vs regex templates with fast keyword pre-filtering."""
    untranslated_static = {}
    untranslated_regex = {}

    cjk_word_re = re.compile(r'[\u4e00-\u9fff]{2,}')
    creg_list = []
    for p in existing_regexes:
        try:
            m = cjk_word_re.search(p)
            kw = m.group(0) if m else None
            creg_list.append((p, re.compile(p), '\n' in p, kw))
        except Exception:
            pass

    regex_candidates_map = defaultdict(list)

    for s in all_cjk_strings:
        if s in existing_strings:
            continue

        has_nl = '\n' in s
        matched = False
        for p_str, creg, p_has_nl, kw in creg_list:
            if p_has_nl and not has_nl:
                continue
            if kw and kw not in s:
                continue
            try:
                if creg.search(s):
                    matched = True
                    break
            except Exception:
                pass
        if matched:
            continue

        if "{" in s and "}" in s and FORMAT_PLACEHOLDER_REGEX.search(s):
            parts = FORMAT_PLACEHOLDER_REGEX.split(s)
            regex_parts = []
            for i, part in enumerate(parts):
                if i % 2 == 0:
                    regex_parts.append(re.escape(part))
                else:
                    regex_parts.append(r'([^\s]+|\d+)')
            pattern = "^" + "".join(regex_parts) + "$"
            if pattern not in existing_regexes:
                untranslated_regex[pattern] = s
        elif NUMBER_REGEX.search(s) and not (len(s) <= 4 and s.isdigit()):
            norm_pattern = "^" + NUMBER_REGEX.sub(r'(\\d+)', re.escape(s)).replace(r'\\d\+', r'(\d+)') + "$"
            template = s
            idx = 0
            for m in list(NUMBER_REGEX.finditer(s)):
                template = template[:m.start()] + f"{{{idx}}}" + template[m.end():]
                idx += 1
            regex_candidates_map[norm_pattern].append((s, template))
        else:
            untranslated_static[s] = ""

    for pattern, instances in regex_candidates_map.items():
        if pattern in existing_regexes or pattern in untranslated_regex:
            continue
        sample_orig, sample_template = instances[0]
        untranslated_regex[pattern] = sample_template

    return untranslated_static, untranslated_regex

def generate_almanac_stubs(raw_plants, raw_zombies, existing_plants, existing_zombies):
    """Generate structured stubs for new plants/zombies."""
    missing_plants = []
    missing_zombies = []

    seen_seed_types = set()
    for p in raw_plants:
        st = p.get("seedType")
        if st is not None and st not in existing_plants and st not in seen_seed_types:
            seen_seed_types.add(st)
            missing_plants.append({
                "seedType": st,
                "name": sanitize_str(p.get("name", "")),
                "introduce": sanitize_str(p.get("introduce", "")),
                "info": sanitize_str(p.get("info", "")),
                "cost": sanitize_str(p.get("cost", ""))
            })

    seen_zombie_types = set()
    for z in raw_zombies:
        zt = z.get("zombieType")
        if zt is not None and zt not in existing_zombies and zt not in seen_zombie_types:
            seen_zombie_types.add(zt)
            missing_zombies.append({
                "zombieType": zt,
                "name": sanitize_str(z.get("name", "")),
                "introduce": sanitize_str(z.get("introduce", ""))
            })

    return missing_plants, missing_zombies

def run_pipeline(game_path=DEFAULT_GAME_PATH, loc_path=DEFAULT_LOC_PATH, out_path=DEFAULT_OUT_PATH):
    print("==========================================================")
    print(" PvZ Fusion - Complete Offline Localization Extractor")
    print("==========================================================")
    print(f"[*] Game Path: {game_path}")
    print(f"[*] Localization Reference Path: {loc_path}")
    print(f"[*] Output Directory: {out_path}\n")

    os.makedirs(out_path, exist_ok=True)

    meta_file = os.path.join(game_path, "PlantsVsZombiesRH_Data", "il2cpp_data", "Metadata", "global-metadata.dat")
    data_file = os.path.join(game_path, "PlantsVsZombiesRH_Data", "data.unity3d")

    meta_strings = extract_metadata_strings(meta_file)
    asset_strings, raw_plants, raw_zombies = extract_almanac_and_textassets(data_file)

    all_cjk = meta_strings | asset_strings

    ex_strings, ex_regexes, ex_plants, ex_zombies = load_existing_translations(loc_path)

    untrans_static, untrans_regex = cluster_and_classify_strings(all_cjk, ex_strings, ex_regexes)

    missing_plants, missing_zombies = generate_almanac_stubs(raw_plants, raw_zombies, ex_plants, ex_zombies)

    out_static_file = os.path.join(out_path, "untranslated_strings.json")
    with open(out_static_file, "w", encoding="utf-8") as f:
        json.dump(untrans_static, f, ensure_ascii=False, indent=2)

    out_regex_file = os.path.join(out_path, "untranslated_regex.json")
    with open(out_regex_file, "w", encoding="utf-8") as f:
        json.dump(untrans_regex, f, ensure_ascii=False, indent=2)

    out_plants_file = os.path.join(out_path, "missing_almanac_plants.json")
    with open(out_plants_file, "w", encoding="utf-8") as f:
        json.dump({"plants": missing_plants}, f, ensure_ascii=False, indent=2)

    out_zombies_file = os.path.join(out_path, "missing_almanac_zombies.json")
    with open(out_zombies_file, "w", encoding="utf-8") as f:
        json.dump({"zombies": missing_zombies}, f, ensure_ascii=False, indent=2)

    print("\n==========================================================")
    print(" Extraction & Diffing Summary")
    print("==========================================================")
    print(f" Total In-Game CJK Strings Discovered: {len(all_cjk):,}")
    print(f" Existing Translated Strings Loaded:   {len(ex_strings):,}")
    print(f" Existing Regexes Loaded:              {len(ex_regexes):,}")
    print(f" New Static Strings to Translate:      {len(untrans_static):,}")
    print(f" New Regex Templates Generated:        {len(untrans_regex):,}")
    print(f" New Almanac Plants Discovered:        {len(missing_plants):,}")
    print(f" New Almanac Zombies Discovered:       {len(missing_zombies):,}")
    print(f"\n[+] Delta files successfully written to: {out_path}")
    print(f"    - {out_static_file}")
    print(f"    - {out_regex_file}")
    print(f"    - {out_plants_file}")
    print(f"    - {out_zombies_file}")
    print("==========================================================")

if __name__ == "__main__":
    parser = argparse.ArgumentParser(description="Extract and diff untranslated strings from PvZ Fusion data.")
    parser.add_argument("--game-path", default=DEFAULT_GAME_PATH, help="Path to game folder")
    parser.add_argument("--loc-path", default=DEFAULT_LOC_PATH, help="Path to reference Localization folder")
    parser.add_argument("--out-path", default=DEFAULT_OUT_PATH, help="Path to output delta folder")
    args = parser.parse_args()

    run_pipeline(args.game_path, args.loc_path, args.out_path)
