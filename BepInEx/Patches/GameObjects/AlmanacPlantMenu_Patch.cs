using HarmonyLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;
using UnityEngine.UI;
using static PvZ_Fusion_Translator__BepInEx_.FileLoader;
using static PvZ_Fusion_Translator__BepInEx_.Utils;
using static PvZ_Fusion_Translator__BepInEx_.Log;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(AlmanacPlantMenu))]
    public static class AlmanacPlantMenu_Patch
    {
        public static string almanacJson = "";

        [HarmonyPatch(nameof(AlmanacPlantMenu.Awake))]
        [HarmonyPostfix]
        private static void Awake(AlmanacPlantMenu __instance)
        {
            try
            {
                TMP_FontAsset font = FontStore.LoadTMPFont(Utils.Language.ToString());
                foreach (TextMeshProUGUI text in __instance.GetComponentsInChildren<TextMeshProUGUI>(true))
                {
                    bool isPlantName = text.gameObject.name.Contains("Name") && text.transform.parent.name != "Background";
                    if (text.gameObject.name != "Description" && !isPlantName)
                    {
                        text.text = StringStore.TranslateText(text.text);
                        text.font = font;
                        text.autoSizeTextContainer = true;
                    }
                }

                // skin button resize
                if (__instance.window?.skinButton != null)
                {
                    AlmanacPlantWindow window = __instance.window;
                    GameObject skinButton = window.skinButton;
                    GameObject skinTextObj = skinButton.transform.GetChild(0).gameObject;
                    GameObject skinShadowTextObj = skinTextObj.transform.GetChild(0).gameObject;
                    TextMeshProUGUI skinShadowText = skinShadowTextObj.GetComponent<TextMeshProUGUI>();
                    if (skinShadowText != null)
                    {
                        skinShadowText.text = StringStore.TranslateText("换肤_S");
                    }
                    skinButton.transform.localScale /= 1.75f;
                    skinButton.transform.localPosition = new Vector3(0.0f, 111.345f, 0.0f);
                    skinButton.transform.GetChild(1).Translate(new Vector3(-0.35f, 0));
                    skinButton.transform.GetChild(2).Translate(new Vector3(0.35f, 0));
                }
            }
            catch (Exception ex)
            {
                Log.LogError($"[AlmanacPlantMenu_Patch.Awake] Error: {ex.Message}");
            }
        }

        // [3.6 NOTE] SearchChanged in 3.6 uses coroutine debounce via PerformSearchDelayed
        // The original SearchChanged should NOT be skipped anymore as it manages the coroutine
        // Instead, we patch PerformSearch (the actual search execution) to add our logic
#if false
        [HarmonyPatch(nameof(AlmanacPlantMenu.SearchChanged))]
        [HarmonyPrefix]
        public static bool SearchChanged(AlmanacPlantMenu __instance, ref TMP_InputField inputField)
        {
            string search = inputField.text;
            if (search != StringStore.TranslateText("搜索") && search != "")
            {
                string currentLanguage = Utils.Language.ToString();
                string almanacDir = GetAssetDir(AssetType.Almanac, Utils.Language);
                string path = Path.Combine(almanacDir, "LawnStringsTranslate.json");

                string json = AlmanacPlantMenu_Patch.almanacJson;

                TMP_FontAsset fontAsset = FontStore.LoadTMPFont(currentLanguage);

                var jsonOptions = new System.Text.Json.JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                PlantData plantData = System.Text.Json.JsonSerializer.Deserialize<PlantData>(json, jsonOptions);

                Il2CppSystem.Collections.Generic.List<PlantType> searchedPlants = new();

                foreach (PlantInfo plantInfo in plantData.plants)
                {
                    if (plantInfo.name.ToLower().Contains(search.ToLower()))
                    {
                        searchedPlants.Add((PlantType)plantInfo.seedType);
                    }
                }

                __instance.ShowPlants(searchedPlants);

                return false;
            }

            return true;
        }
#endif

        // [3.6 NEW] Patch PerformSearch to intercept search results
        // This is called by the coroutine SearchChanged mechanism in 3.6
        [HarmonyPatch("PerformSearch")]
        [HarmonyPostfix]
        private static void PerformSearch_Postfix(AlmanacPlantMenu __instance, string searchText)
        {
            try
            {
                Log.LogInfo($"[AlmanacPlantMenu_Patch.PerformSearch] searchText=\"{searchText}\"");
                Log.LogInfo($"[AlmanacPlantMenu_Patch.PerformSearch] plantStack depth={__instance?.plantStack?.Count ?? -1}");

                if (string.IsNullOrEmpty(searchText) || searchText == StringStore.TranslateText("搜索"))
                {
                    Log.LogInfo($"[AlmanacPlantMenu_Patch.PerformSearch] Empty search, skipping custom logic");
                    return;
                }

                if (string.IsNullOrEmpty(almanacJson))
                {
                    Log.LogWarning($"[AlmanacPlantMenu_Patch.PerformSearch] almanacJson is empty, cannot search");
                    return;
                }

                Log.LogInfo($"[AlmanacPlantMenu_Patch.PerformSearch] Processing search with custom logic");

                string currentLanguage = Utils.Language.ToString();
                string almanacDir = GetAssetDir(AssetType.Almanac, Utils.Language);
                string moddedPath = Path.Combine(almanacDir, "ModdedPlantsTranslate.json");

                PlantData plantData = null;
                try
                {
                    string cleanedJson = Utils.ExtractFirstJsonObject(almanacJson);
                    var performSearchJsonOptions = new System.Text.Json.JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    plantData = System.Text.Json.JsonSerializer.Deserialize<PlantData>(cleanedJson, performSearchJsonOptions);
                    Log.LogInfo($"[AlmanacPlantMenu_Patch.PerformSearch] Parsed {plantData?.plants?.Count ?? 0} plants from almanacJson");
                }
                catch (Exception ex)
                {
                    Log.LogError($"[AlmanacPlantMenu_Patch.PerformSearch] Failed to parse almanacJson: {ex.Message}");
                    return;
                }

                if (plantData?.plants == null)
                {
                    Log.LogWarning($"[AlmanacPlantMenu_Patch.PerformSearch] plantData.plants is null");
                    return;
                }

                Il2CppSystem.Collections.Generic.List<PlantType> searchedPlants = new();
                int matchCount = 0;

                foreach (PlantInfo plantInfo in plantData.plants)
                {
                    if (plantInfo == null || string.IsNullOrEmpty(plantInfo.name)) continue;

                    if (plantInfo.name.ToLower().Contains(searchText.ToLower()))
                    {
                        searchedPlants.Add((PlantType)plantInfo.seedType);
                        matchCount++;
                    }
                }

                // Also search modded plants
                if (File.Exists(moddedPath))
                {
                    try
                    {
                        string moddedJson = File.ReadAllText(moddedPath);
                        if (!string.IsNullOrEmpty(moddedJson))
                        {
                            var moddedJsonOptions = new System.Text.Json.JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                            PlantData moddedPlantData = System.Text.Json.JsonSerializer.Deserialize<PlantData>(moddedJson, moddedJsonOptions);
                            if (moddedPlantData?.plants != null)
                            {
                                foreach (PlantInfo plantInfo in moddedPlantData.plants)
                                {
                                    if (plantInfo == null || string.IsNullOrEmpty(plantInfo.name)) continue;
                                    if (plantInfo.name.ToLower().Contains(searchText.ToLower()))
                                    {
                                        PlantType pt = (PlantType)plantInfo.seedType;
                                        if (!searchedPlants.Contains(pt))
                                        {
                                            searchedPlants.Add(pt);
                                            matchCount++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Log.LogWarning($"[AlmanacPlantMenu_Patch.PerformSearch] Error reading modded: {ex.Message}");
                    }
                }

                Log.LogInfo($"[AlmanacPlantMenu_Patch.PerformSearch] Found {matchCount} matching plants, calling ShowPlants");

                if (searchedPlants.Count > 0)
                {
                    __instance.ShowPlants(searchedPlants);
                }
                else
                {
                    Log.LogInfo($"[AlmanacPlantMenu_Patch.PerformSearch] No matches found for \"{searchText}\"");
                }
            }
            catch (Exception ex)
            {
                Log.LogError($"[AlmanacPlantMenu_Patch.PerformSearch] Unexpected error: {ex.Message}");
                Log.LogError($"[AlmanacPlantMenu_Patch.PerformSearch] Stack trace: {ex.StackTrace}");
            }
        }
    }
}