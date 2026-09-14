#!/usr/bin/env python3
"""
PvZ Fusion - Translation Quality Linter (v6)
Real translator-assist linter: compares VN vs EN field-by-field, catches:
- Fields that are still identical to EN (untranslated)
- Leaked English labels (Toughness:, Cost:, Recharge:, Traits:, etc.)
- Wrong HTML palette (align=left + color=black = copied EN style)
- Empty/missing fields
"""

import os, sys, json

if sys.stdout.encoding != 'utf-8':
    try:
        sys.stdout.reconfigure(encoding='utf-8')
    except Exception:
        pass

DEFAULT_VN = r"D:\VSCode\PVZF-Translation\PvZ_Fusion_Translator\Localization\Vietnamese"
DEFAULT_EN = r"D:\VSCode\PVZF-Translation\PvZ_Fusion_Translator\Localization\English"

EN_LABELS = ["Toughness:", "Cost:", "Recharge:", "Traits:", "Special:",
             "Movement Speed:", "Weakness:", "Fusion Recipe:", "Odyssey Modifiers:",
             "Cryo System:", "Lumos System:", "Magnetic System:", "Digestion Time:",
             "Unlock Conditions:", "Sun Output:", "Attack Range:", "Range:"]

def load_json(path):
    raw = open(path, "rb").read()
    enc = "utf-8"
    if raw[:2] == b'\xff\xfe':
        enc = "utf-16-le-bom"
        return json.loads(raw.decode('utf-16')), enc
    if raw[:3] == b'\xef\xbb\xbf':
        enc = "utf-8-bom"
        return json.loads(raw[3:].decode('utf-8')), enc
    return json.loads(raw.decode('utf-8')), enc

def is_untranslated(vn_val, en_val):
    return isinstance(vn_val, str) and isinstance(en_val, str) \
        and vn_val.strip() and vn_val == en_val

def has_en_palette(val):
    return isinstance(val, str) and 'align=left' in val and 'color=black' in val

def has_en_label(val):
    if not isinstance(val, str):
        return []
    return [l for l in EN_LABELS if l in val]

def lint_plant(vn_path, en_path):
    vn, enc_v = load_json(vn_path)
    en, enc_e = load_json(en_path)
    issues = []
    if enc_v != "utf-16-le-bom":
        issues.append(f"[Encoding] VN Plant file is {enc_v}, expected utf-16-le-bom")

    en_by = {p.get("seedType"): p for p in en.get("plants", [])}
    plants = vn.get("plants", [])
    stats = {"name": 0, "introduce": 0, "info": 0, "cost": 0}
    empty = 0

    for p in plants:
        st = p.get("seedType")
        e = en_by.get(st, {})
        for f in ("name", "introduce", "info", "cost"):
            vv, ee = p.get(f, ""), e.get(f, "")
            if not str(vv).strip():
                empty += 1
                issues.append(f"[Plant {st}] field '{f}' EMPTY")
                continue
            if is_untranslated(vv, ee):
                stats[f] += 1
                issues.append(f"[Plant {st}] field '{f}' UNTRANSLATED (== EN): {str(vv)[:50]}")
            if f == "introduce" and has_en_palette(vv):
                issues.append(f"[Plant {st}] 'introduce' uses EN palette (align=left/color=black)")
            if f in ("info", "cost"):
                for l in has_en_label(vv):
                    issues.append(f"[Plant {st}] '{f}' leaked EN label '{l}'")

    print(f"\n[Plant] {len(plants)} entries | untranslated: {stats} | empty: {empty}")
    return issues

def lint_zombie(vn_path, en_path):
    vn, enc_v = load_json(vn_path)
    en, enc_e = load_json(en_path)
    issues = []
    if enc_v != "utf-16-le-bom":
        issues.append(f"[Encoding] VN Zombie file is {enc_v}, expected utf-16-le-bom")

    en_by = {z.get("theZombieType") or z.get("zombieType"): z for z in en.get("zombies", [])}
    zombies = vn.get("zombies", [])
    stats = {"name": 0, "introduce": 0, "info": 0}
    empty = 0

    for z in zombies:
        zt = z.get("theZombieType") or z.get("zombieType")
        e = en_by.get(zt, {})
        for f in ("name", "introduce", "info"):
            vv, ee = z.get(f, ""), e.get(f, "")
            if not str(vv).strip():
                empty += 1
                issues.append(f"[Zombie {zt}] field '{f}' EMPTY")
                continue
            if is_untranslated(vv, ee):
                if f == "name":
                    stats[f] += 1
                    issues.append(f"[Zombie {zt}] 'name' == EN (may be coinage allowlist): {str(vv)[:40]}")
                else:
                    stats[f] += 1
                    issues.append(f"[Zombie {zt}] field '{f}' UNTRANSLATED (== EN): {str(vv)[:50]}")
            if f == "introduce" and has_en_palette(vv):
                issues.append(f"[Zombie {zt}] 'introduce' uses EN palette")
            if f == "info":
                for l in has_en_label(vv):
                    issues.append(f"[Zombie {zt}] 'info' leaked EN label '{l}'")

    print(f"\n[Zombie] {len(zombies)} entries | untranslated: {stats} | empty: {empty}")
    return issues

def lint_regex(vn_path, en_path):
    vn, _ = load_json(vn_path)
    en, _ = load_json(en_path)
    same = 0
    total = 0
    for k, v in vn.items():
        if k.startswith("---") or k.startswith("-------"):
            continue
        if not isinstance(v, str):
            continue
        total += 1
        if k in en and v == en[k] and v.strip() and len(v) >= 3:
            same += 1
    print(f"\n[Regex] {total} patterns | {same} identical-to-EN (review for format vs content)")
    return []

def main():
    print("=" * 72)
    print(" PvZ Fusion Translation Linter (v6)")
    print("=" * 72)

    vn_lawn = os.path.join(DEFAULT_VN, "Almanac", "LawnStringsTranslate.json")
    en_lawn = os.path.join(DEFAULT_EN, "Almanac", "LawnStringsTranslate.json")
    vn_zom = os.path.join(DEFAULT_VN, "Almanac", "ZombieStringsTranslate.json")
    en_zom = os.path.join(DEFAULT_EN, "Almanac", "ZombieStringsTranslate.json")
    vn_re = os.path.join(DEFAULT_VN, "Strings", "translation_regexs.json")
    en_re = os.path.join(DEFAULT_EN, "Strings", "translation_regexs.json")

    all_issues = []
    if os.path.exists(vn_lawn) and os.path.exists(en_lawn):
        all_issues += lint_plant(vn_lawn, en_lawn)
    if os.path.exists(vn_zom) and os.path.exists(en_zom):
        all_issues += lint_zombie(vn_zom, en_zom)
    if os.path.exists(vn_re) and os.path.exists(en_re):
        all_issues += lint_regex(vn_re, en_re)

    print("\n" + "=" * 72)
    print(f" TOTAL ISSUES: {len(all_issues)}")
    print("=" * 72)
    if all_issues:
        print("\nSample (up to 40):")
        for i, iss in enumerate(all_issues[:40]):
            print(f"  {i+1}. {iss}")

if __name__ == "__main__":
    main()
