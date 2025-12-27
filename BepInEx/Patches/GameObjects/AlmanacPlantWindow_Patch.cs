using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using System;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using static PvZ_Fusion_Translator__BepInEx_.FileLoader;
using static PvZ_Fusion_Translator__BepInEx_.Log;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(AlmanacPlantWindow))]
    public static class AlmanacPlantWindow_Patch
    {
        [HarmonyPatch(nameof(AlmanacPlantWindow.UpdateText))]
        [HarmonyPostfix]
        private static void UpdateText(AlmanacPlantWindow __instance)
        {
            try
            {
                if (__instance == null)
                {
                    Log.LogWarning("[AlmanacPlantWindow_Patch] __instance is null");
                    return;
                }

                if (__instance.showedPlantName == null || __instance.showedPlantIntroduce == null || __instance.plantTextContent == null)
                {
                    Log.LogWarning("[AlmanacPlantWindow_Patch] Required UI components are null");
                    return;
                }

                string currentLanguage = Utils.Language.ToString();
                string almanacDir = GetAssetDir(AssetType.Almanac, Utils.Language);
                string path = Path.Combine(almanacDir, "LawnStringsTranslate.json");
                string moddedPath = Path.Combine(almanacDir, "ModdedPlantsTranslate.json");

                if (!File.Exists(path))
                {
                    Log.LogWarning($"[AlmanacPlantWindow_Patch] LawnStringsTranslate.json not found at: {path}");
                    return;
                }

                string json;
                json = File.ReadAllText(path);

                bool hasAlmanacFont = false;
                TMP_FontAsset almanacFontAsset = null;
                if (FontStore.fontAssetDictSecondary != null && 
                    (FontStore.fontAssetDictSecondary.ContainsKey(currentLanguage + "_Almanac") || 
                     FontStore.fontAssetDictSecondary.ContainsKey(currentLanguage)))
                almanacFontAsset = FontStore.LoadTMPFontAlmanac(currentLanguage);
                hasAlmanacFont = almanacFontAsset != null;

                TMP_FontAsset fontAsset = null;
                fontAsset = (hasAlmanacFont) ? FontStore.LoadTMPFontAlmanac(Utils.Language.ToString()) : FontStore.LoadTMPFont(Utils.Language.ToString());

                AlmanacPlantBank.PlantData plantData = null;
                
                plantData = JsonUtility.FromJson<AlmanacPlantBank.PlantData>(json);
                

                bool foundMatch = false;
                foreach (AlmanacPlantBank.PlantInfo plantInfo in plantData.plants)
                {
                    if (plantInfo == null) continue;
                    if (plantInfo.seedType == (int)__instance.currentPlantType)
                    {
                        foundMatch = true;
                        try
                        {
                            if (__instance.showedPlantName != null)
                            {
                                foreach (TextMeshProUGUI text in __instance.showedPlantName)
                                {
                                    if (text == null) continue;
                                    text.autoSizeTextContainer = false;
                                    string plantName = plantInfo.name ?? "";
                                    text.text = $"{Utils.RemoveSizeTags(plantName)} ({plantInfo.seedType})";
                                    text.font = fontAsset;
                                    text.fontSizeMax = 21;
                                }
                            }

                            if (__instance.showedPlantIntroduce != null)
                            {
                                string info = plantInfo.info ?? "";
                                string introduce = plantInfo.introduce ?? "";
                                __instance.showedPlantIntroduce.text = Utils.RemoveSizeTags(info) + "\n\n" + Utils.RemoveSizeTags(introduce) + "\n\n";
                                __instance.showedPlantIntroduce.font = fontAsset;
                                __instance.showedPlantIntroduce.margin = new Vector4(6, 2, 12, 0);
                                __instance.showedPlantIntroduce.enableWordWrapping = true;
                                __instance.showedPlantIntroduce.overflowMode = TextOverflowModes.ScrollRect;

                                Canvas.ForceUpdateCanvases();
                                __instance.showedPlantIntroduce.ForceMeshUpdate();

                                if (__instance.plantTextContent != null)
                                {
                                    float textHeight = __instance.showedPlantIntroduce.preferredHeight;
                                    __instance.plantTextContent.sizeDelta = new Vector2(__instance.plantTextContent.sizeDelta.x, textHeight);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Log.LogError($"[AlmanacPlantWindow_Patch] Error updating plant info: {ex.Message}");
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
                            AlmanacPlantBank.PlantData moddedPlantData = JsonUtility.FromJson<AlmanacPlantBank.PlantData>(moddedJson);
                            if (moddedPlantData != null && moddedPlantData.plants != null)
                            {
                                foreach (AlmanacPlantBank.PlantInfo plantInfo in moddedPlantData.plants)
                                {
                                    if (plantInfo == null) continue;
                                    if (plantInfo.seedType == (int)__instance.currentPlantType)
                                    {
                                        try
                                        {
                                            if (__instance.showedPlantName != null)
                                            {
                                                foreach (TextMeshProUGUI text in __instance.showedPlantName)
                                                {
                                                    if (text == null) continue;
                                                    text.autoSizeTextContainer = false;
                                                    string plantName = plantInfo.name ?? "";
                                                    text.text = $"{Utils.RemoveSizeTags(plantName)} ({plantInfo.seedType})";
                                                    text.font = fontAsset;
                                                    text.fontSizeMax = 21;
                                                }
                                            }

                                            if (__instance.showedPlantIntroduce != null)
                                            {
                                                string info = plantInfo.info ?? "";
                                                string introduce = plantInfo.introduce ?? "";
                                                __instance.showedPlantIntroduce.text = Utils.RemoveSizeTags(info) + "\n\n" + Utils.RemoveSizeTags(introduce) + "\n\n";
                                                __instance.showedPlantIntroduce.font = fontAsset;
                                                __instance.showedPlantIntroduce.margin = new Vector4(6, 2, 12, 0);
                                                __instance.showedPlantIntroduce.enableWordWrapping = true;
                                                __instance.showedPlantIntroduce.overflowMode = TextOverflowModes.ScrollRect;

                                                Canvas.ForceUpdateCanvases();
                                                __instance.showedPlantIntroduce.ForceMeshUpdate();

                                                if (__instance.plantTextContent != null)
                                                {
                                                    float textHeight = __instance.showedPlantIntroduce.preferredHeight;
                                                    __instance.plantTextContent.sizeDelta = new Vector2(__instance.plantTextContent.sizeDelta.x, textHeight);
                                                }
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            Log.LogError($"[AlmanacPlantWindow_Patch] Error updating modded plant info: {ex.Message}");
                                        }
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Log.LogWarning($"[AlmanacPlantWindow_Patch] Error reading ModdedPlantsTranslate.json: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                Log.LogError($"[AlmanacPlantWindow_Patch] Unexpected error in UpdateText: {ex.Message}\n{ex.StackTrace}");
            }
        }
    }
}

