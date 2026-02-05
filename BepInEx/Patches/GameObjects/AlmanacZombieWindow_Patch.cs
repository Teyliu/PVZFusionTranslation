using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using System;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using static PvZ_Fusion_Translator__BepInEx_.FileLoader;
using static PvZ_Fusion_Translator__BepInEx_.Log;
using PvZ_Fusion_Translator__BepInEx_.Patches.Managers;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(AlmanacZombieWindow))]
    public static class AlmanacZombieWindow_Patch
    {
        [HarmonyPatch(nameof(AlmanacZombieWindow.UpdateText))]
        [HarmonyPostfix]
        private static void UpdateText(AlmanacZombieWindow __instance)
        {
            try
            {
                string currentLanguage = Utils.Language.ToString();
                string almanacDir = GetAssetDir(AssetType.Almanac, Utils.Language);
                string path = Path.Combine(almanacDir, "ZombieStringsTranslate.json");
                string moddedPath = Path.Combine(almanacDir, "ModdedZombiesTranslate.json");

                if (!File.Exists(path))
                {
                    Log.LogWarning($"[AlmanacZombieWindow_Patch] ZombieStringsTranslate.json not found at: {path}");
                    return;
                }

                string json;
                json = File.ReadAllText(path);

                bool hasAlmanacFont = false;
                TMP_FontAsset almanacFontAsset = null;
                if (FontStore.fontAssetDictSecondary != null && 
                    (FontStore.fontAssetDictSecondary.ContainsKey(currentLanguage + "_Almanac") || 
                     FontStore.fontAssetDictSecondary.ContainsKey(currentLanguage)))
                {
                    almanacFontAsset = FontStore.LoadTMPFontAlmanac(currentLanguage);
                    hasAlmanacFont = almanacFontAsset != null;
                }

                TMP_FontAsset fontAsset = null;
                fontAsset = (hasAlmanacFont) ? FontStore.LoadTMPFontAlmanac(Utils.Language.ToString()) : FontStore.LoadTMPFont(Utils.Language.ToString());

                ZombieAlmanacData zombieAlmanacData = null;
                zombieAlmanacData = JsonUtility.FromJson<ZombieAlmanacData>(json);
                var zombieDataDic = ZombieDataManager.zombieDataDic;

                bool foundMatch = false;
                foreach (ZombieInfo zombieInfo in zombieAlmanacData.zombies)
                {
                    if (zombieInfo == null) continue;
                    if (zombieInfo.theZombieType == __instance.currentZombieType)
                    {
                        foundMatch = true;
                        try
                        {
                            if (__instance.showedZombieName != null)
                            {
                                foreach (TextMeshProUGUI text in __instance.showedZombieName)
                                {
                                    if (text == null) continue;
                                    text.autoSizeTextContainer = false;
                                    string zombieName = zombieInfo.name ?? "";
                                    text.text = $"{Utils.RemoveSizeTags(zombieName)} ({(int)zombieInfo.theZombieType})";
                                    text.font = fontAsset;
                                    text.fontSizeMax = 21;
                                }
                            }

                            if (__instance.showedZombieIntroduce != null)
                            {
                                string info = zombieInfo.info ?? "";
                                string introduce = zombieInfo.introduce ?? "";

                                ZombieDataManager.ZombieData zombieData = zombieDataDic[__instance.currentZombieType];

                                string spawnInfo = "";
                                string spawnInfoFormat = StringStore.translationStringRegex["出怪等级: (\\d+)\\n出怪权重: (\\d+)"];
                                if(spawnInfoFormat != null)
                                {
                                    spawnInfo = string.Format(spawnInfoFormat, new object[] { zombieData.summonLevel, zombieData.summonWeight }) + "\n\n";
                                }

                                __instance.showedZombieIntroduce.text = Utils.RemoveSizeTags(info) + "\n\n" + spawnInfo + Utils.RemoveSizeTags(introduce) + "\n\n";
                                __instance.showedZombieIntroduce.font = fontAsset;
                                __instance.showedZombieIntroduce.margin = new Vector4(3, 2, 12, 0);
                                __instance.showedZombieIntroduce.enableWordWrapping = true;
                                __instance.showedZombieIntroduce.overflowMode = TextOverflowModes.ScrollRect;

                                Canvas.ForceUpdateCanvases();
                                __instance.showedZombieIntroduce.ForceMeshUpdate();

                                if (__instance.zombieTextContent != null)
                                {
                                    float textHeight = __instance.showedZombieIntroduce.preferredHeight;
                                    __instance.zombieTextContent.sizeDelta = new Vector2(__instance.zombieTextContent.sizeDelta.x, textHeight);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Log.LogError($"[AlmanacZombieWindow_Patch] Error updating zombie info: {ex.Message}");
                        }
                        break;
                    }
                }

                if (!foundMatch && File.Exists(moddedPath))
                {
                    try
                    {
                        string moddedJson = File.ReadAllText(moddedPath);
                        if (!string.IsNullOrEmpty(moddedJson))
                        {
                            ZombieAlmanacData moddedZombieData = JsonUtility.FromJson<ZombieAlmanacData>(moddedJson);
                            if (moddedZombieData != null && moddedZombieData.zombies != null)
                            {
                                foreach (ZombieInfo zombieInfo in moddedZombieData.zombies)
                                {
                                    if (zombieInfo == null) continue;
                                    if (zombieInfo.theZombieType == __instance.currentZombieType)
                                    {
                                        try
                                        {
                                            if (__instance.showedZombieName != null)
                                            {
                                                foreach (TextMeshProUGUI text in __instance.showedZombieName)
                                                {
                                                    if (text == null) continue;
                                                    text.autoSizeTextContainer = false;
                                                    string zombieName = zombieInfo.name ?? "";
                                                    text.text = $"{Utils.RemoveSizeTags(zombieName)} ({(int)zombieInfo.theZombieType})";
                                                    text.font = fontAsset;
                                                    text.fontSizeMax = 21;
                                                }
                                            }

                                            if (__instance.showedZombieIntroduce != null)
                                            {
                                                string info = zombieInfo.info ?? "";
                                                string introduce = zombieInfo.introduce ?? "";
                                                __instance.showedZombieIntroduce.text = Utils.RemoveSizeTags(info) + "\n\n" + Utils.RemoveSizeTags(introduce) + "\n\n";
                                                __instance.showedZombieIntroduce.font = fontAsset;
                                                __instance.showedZombieIntroduce.margin = new Vector4(3, 2, 12, 0);
                                                __instance.showedZombieIntroduce.enableWordWrapping = true;
                                                __instance.showedZombieIntroduce.overflowMode = TextOverflowModes.ScrollRect;

                                                Canvas.ForceUpdateCanvases();
                                                __instance.showedZombieIntroduce.ForceMeshUpdate();

                                                if (__instance.zombieTextContent != null)
                                                {
                                                    float textHeight = __instance.showedZombieIntroduce.preferredHeight;
                                                    __instance.zombieTextContent.sizeDelta = new Vector2(__instance.zombieTextContent.sizeDelta.x, textHeight);
                                                }
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            Log.LogError($"[AlmanacZombieWindow_Patch] Error updating modded zombie info: {ex.Message}");
                                        }
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Log.LogWarning($"[AlmanacZombieWindow_Patch] Error reading ModdedZombiesTranslate.json: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                Log.LogError($"[AlmanacZombieWindow_Patch] Unexpected error in UpdateText: {ex.Message}\n{ex.StackTrace}");
            }
        }
    }
}

