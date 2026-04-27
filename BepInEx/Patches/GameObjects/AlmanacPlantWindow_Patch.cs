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
        private static void UpdateText(AlmanacPlantWindow __instance, PlantType thePlantType)
        {
            try
            {
                if (__instance == null)
                {
                    Log.LogWarning("[AlmanacPlantWindow_Patch] __instance is null");
                    return;
                }

                if (__instance.showedPlantName == null || __instance.showedPlantIntroduce == null)
                {
                    Log.LogWarning("[AlmanacPlantWindow_Patch] Required UI components are null");
                    return;
                }

                Log.LogInfo($"[AlmanacPlantWindow_Patch] UpdateText called for plant type: {(int)thePlantType}");

                string currentLanguage = Utils.Language.ToString();
                string almanacDir = GetAssetDir(AssetType.Almanac, Utils.Language);

                // Step 1: Get original values from AlmanacDataLoader.GetPlantData (3.6 native)
                string originalName = "";
                string originalIntroduce = "";
                string originalInfo = "";
                string originalCost = "";

                try
                {
                    var getPlantDataMethod = Type.GetType("AlmanacData.AlmanacDataLoader, Assembly-CSharp")
                        ?.GetMethod("GetPlantData", new[] { typeof(PlantType) });

                    if (getPlantDataMethod != null)
                    {
                        var plantInfoObj = getPlantDataMethod.Invoke(null, new object[] { thePlantType });
                        if (plantInfoObj != null)
                        {
                            Type pType = plantInfoObj.GetType();
                            originalName = (string)pType.GetField("name")?.GetValue(plantInfoObj) ?? "";
                            originalIntroduce = (string)pType.GetField("introduce")?.GetValue(plantInfoObj) ?? "";
                            originalInfo = (string)pType.GetField("info")?.GetValue(plantInfoObj) ?? "";
                            originalCost = (string)pType.GetField("cost")?.GetValue(plantInfoObj) ?? "";
                            Log.LogInfo($"[AlmanacPlantWindow_Patch] Got original from GetPlantData: name='{originalName}'");
                        }
                        else
                        {
                            Log.LogInfo("[AlmanacPlantWindow_Patch] GetPlantData returned null");
                        }
                    }
                    else
                    {
                        Log.LogWarning("[AlmanacPlantWindow_Patch] Could not find AlmanacDataLoader.GetPlantData method");
                    }
                }
                catch (Exception ex)
                {
                    Log.LogWarning($"[AlmanacPlantWindow_Patch] GetPlantData failed: {ex.Message}");
                }

                // Step 2: Read JSON file and find plant by seedType
                string finalName = originalName;
                string finalIntroduce = originalIntroduce;
                string finalInfo = originalInfo;
                string finalCost = originalCost;

                string jsonPath = Path.Combine(almanacDir, "LawnStringsTranslate.json");
                Log.LogInfo($"[AlmanacPlantWindow_Patch] Looking for JSON at: {jsonPath}");

                if (File.Exists(jsonPath))
                {
                    try
                    {
                        string jsonContent = File.ReadAllText(jsonPath);
                        string cleanedJson = Utils.ExtractFirstJsonObject(jsonContent);
                        Log.LogInfo($"[AlmanacPlantWindow_Patch] JSON length: {jsonContent.Length}, cleaned length: {cleanedJson.Length}, first 200: {cleanedJson.Substring(0, Math.Min(200, cleanedJson.Length))}");

                        var jsonOptions = new System.Text.Json.JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                        var plantData = System.Text.Json.JsonSerializer.Deserialize<PlantData>(cleanedJson, jsonOptions);

                        if (plantData?.plants != null)
                        {
                            Log.LogInfo($"[AlmanacPlantWindow_Patch] Parsed {plantData.plants.Count} plants, looking for seedType={(int)thePlantType}");

                            foreach (var plant in plantData.plants)
                            {
                                if (plant != null && plant.seedType == (int)thePlantType)
                                {
                                    finalName = plant.name ?? originalName;
                                    finalIntroduce = plant.introduce ?? originalIntroduce;
                                    finalInfo = plant.info ?? originalInfo;
                                    finalCost = plant.cost ?? originalCost;
                                    Log.LogInfo($"[AlmanacPlantWindow_Patch] Found translated plant: seedType={plant.seedType}, name='{plant.name}', introduce='{plant.introduce?.Substring(0, Math.Min(50, plant.introduce?.Length ?? 0))}', info='{plant.info?.Substring(0, Math.Min(50, plant.info?.Length ?? 0))}', cost='{plant.cost}'");
                                    break;
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Log.LogWarning($"[AlmanacPlantWindow_Patch] Failed to parse JSON: {ex.Message}");
                    }
                }
                else
                {
                    Log.LogWarning($"[AlmanacPlantWindow_Patch] JSON file not found: {jsonPath}");
                }

                // Step 3: Check modded plants override
                string moddedPath = Path.Combine(almanacDir, "ModdedPlantsTranslate.json");
                if (File.Exists(moddedPath))
                {
                    try
                    {
                        string moddedJson = File.ReadAllText(moddedPath);
                        if (!string.IsNullOrEmpty(moddedJson))
                        {
                            string cleanedModded = Utils.ExtractFirstJsonObject(moddedJson);
                            var moddedData = System.Text.Json.JsonSerializer.Deserialize<PlantData>(cleanedModded, new System.Text.Json.JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                            if (moddedData?.plants != null)
                            {
                                foreach (var moddedInfo in moddedData.plants)
                                {
                                    if (moddedInfo != null && moddedInfo.seedType == (int)thePlantType)
                                    {
                                        finalName = moddedInfo.name ?? finalName;
                                        finalIntroduce = moddedInfo.introduce ?? finalIntroduce;
                                        finalInfo = moddedInfo.info ?? finalInfo;
                                        finalCost = moddedInfo.cost ?? finalCost;
                                        Log.LogInfo($"[AlmanacPlantWindow_Patch] Modded override: name='{moddedInfo.name}'");
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Log.LogWarning($"[AlmanacPlantWindow_Patch] Modded parse failed: {ex.Message}");
                    }
                }

                Log.LogInfo($"[AlmanacPlantWindow_Patch] Final values - name='{finalName}', introduce='{finalIntroduce?.Substring(0, Math.Min(50, finalIntroduce?.Length ?? 0))}', info='{finalInfo?.Substring(0, Math.Min(50, finalInfo?.Length ?? 0))}', cost='{finalCost}'");

                // Step 4: Font setup
                TMP_FontAsset fontAsset = null;
                if (FontStore.fontAssetDictSecondary != null &&
                    (FontStore.fontAssetDictSecondary.ContainsKey(currentLanguage + "_Almanac") ||
                     FontStore.fontAssetDictSecondary.ContainsKey(currentLanguage)))
                {
                    fontAsset = FontStore.LoadTMPFontAlmanac(currentLanguage);
                }

                if (fontAsset == null)
                {
                    fontAsset = FontStore.LoadTMPFont(currentLanguage);
                }

                // Step 5: Update showedPlantName (List<TextMeshProUGUI> - Name + Name_shadow)
                if (__instance.showedPlantName != null)
                {
                    foreach (TextMeshProUGUI text in __instance.showedPlantName)
                    {
                        if (text == null) continue;
                        text.autoSizeTextContainer = false;
                        text.text = $"{Utils.RemoveSizeTags(finalName)} ({(int)thePlantType})";
                        text.font = fontAsset;
                        text.fontSizeMax = 21;
                        Log.LogInfo($"[AlmanacPlantWindow_Patch] Set showedPlantName[{text.name}] text: {text.text}");
                    }
                }

                // Step 6: Update showedPlantIntroduce (Description)
                if (__instance.showedPlantIntroduce != null)
                {
                    char[] toTrim = Environment.NewLine.ToCharArray();
                    string finalText = Utils.RemoveSizeTags(finalInfo) + "\n\n" +
                        Utils.RemoveSizeTags(finalIntroduce) + "\n\n" +
                        Utils.RemoveSizeTags(finalCost).TrimStart(toTrim) + "\n\n";
                    __instance.showedPlantIntroduce.text = finalText;
                    __instance.showedPlantIntroduce.font = fontAsset;
                    __instance.showedPlantIntroduce.margin = new Vector4(6, 2, 12, 0);
                    __instance.showedPlantIntroduce.enableWordWrapping = true;
                    __instance.showedPlantIntroduce.overflowMode = TextOverflowModes.ScrollRect;

                    Canvas.ForceUpdateCanvases();
                    __instance.showedPlantIntroduce.ForceMeshUpdate();

                    Log.LogInfo($"[AlmanacPlantWindow_Patch] Set showedPlantIntroduce text length: {finalText.Length}, first 100: {finalText.Substring(0, Math.Min(100, finalText.Length))}");

                    if (__instance.plantTextContent != null)
                    {
                        float textHeight = __instance.showedPlantIntroduce.preferredHeight;
                        __instance.plantTextContent.sizeDelta = new Vector2(__instance.plantTextContent.sizeDelta.x, textHeight);
                    }
                }

                Log.LogInfo($"[AlmanacPlantWindow_Patch] Successfully updated UI for plant {(int)thePlantType}");
            }
            catch (Exception ex)
            {
                Log.LogError($"[AlmanacPlantWindow_Patch] Unexpected error in UpdateText: {ex.Message}");
                Log.LogError($"[AlmanacPlantWindow_Patch] Stack trace: {ex.StackTrace}");
            }
        }
    }
}
