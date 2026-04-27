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
        private static void UpdateText(AlmanacZombieWindow __instance, ZombieType theZombieType)
        {
            try
            {
                if (__instance == null)
                {
                    Log.LogWarning("[AlmanacZombieWindow_Patch] __instance is null");
                    return;
                }

                if (__instance.showedZombieName == null || __instance.showedZombieIntroduce == null)
                {
                    Log.LogWarning("[AlmanacZombieWindow_Patch] Required UI components are null");
                    return;
                }

                Log.LogInfo($"[AlmanacZombieWindow_Patch] UpdateText called for zombie type: {__instance.currentZombieType}");

                string currentLanguage = Utils.Language.ToString();
                string almanacDir = GetAssetDir(AssetType.Almanac, Utils.Language);

                // Step 1: Get original values from AlmanacDataLoader.GetZombieData (3.6 native)
                string originalName = "";
                string originalIntroduce = "";
                string originalInfo = "";

                try
                {
                    var getZombieDataMethod = Type.GetType("AlmanacData.AlmanacDataLoader, Assembly-CSharp")
                        ?.GetMethod("GetZombieData", new[] { typeof(ZombieType) });

                    if (getZombieDataMethod != null)
                    {
                        var zombieInfoObj = getZombieDataMethod.Invoke(null, new object[] { __instance.currentZombieType });
                        if (zombieInfoObj != null)
                        {
                            Type zType = zombieInfoObj.GetType();
                            originalName = (string)zType.GetField("name")?.GetValue(zombieInfoObj) ?? "";
                            originalIntroduce = (string)zType.GetField("introduce")?.GetValue(zombieInfoObj) ?? "";
                            originalInfo = (string)zType.GetField("info")?.GetValue(zombieInfoObj) ?? "";
                            Log.LogInfo($"[AlmanacZombieWindow_Patch] Got original from GetZombieData: name='{originalName}'");
                        }
                        else
                        {
                            Log.LogInfo("[AlmanacZombieWindow_Patch] GetZombieData returned null");
                        }
                    }
                    else
                    {
                        Log.LogWarning("[AlmanacZombieWindow_Patch] Could not find AlmanacDataLoader.GetZombieData method");
                    }
                }
                catch (Exception ex)
                {
                    Log.LogWarning($"[AlmanacZombieWindow_Patch] GetZombieData failed: {ex.Message}");
                }

                // Step 2: Read JSON file and find zombie by theZombieType
                string finalName = originalName;
                string finalIntroduce = originalIntroduce;
                string finalInfo = originalInfo;

                string jsonPath = Path.Combine(almanacDir, "ZombieStringsTranslate.json");
                Log.LogInfo($"[AlmanacZombieWindow_Patch] Looking for JSON at: {jsonPath}");

                if (File.Exists(jsonPath))
                {
                    try
                    {
                        string jsonContent = File.ReadAllText(jsonPath);
                        string cleanedJson = Utils.ExtractFirstJsonObject(jsonContent);
                        Log.LogInfo($"[AlmanacZombieWindow_Patch] JSON length: {jsonContent.Length}, cleaned length: {cleanedJson.Length}, first 200: {cleanedJson.Substring(0, Math.Min(200, cleanedJson.Length))}");

                        var jsonOptions = new System.Text.Json.JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                        var zombieData = System.Text.Json.JsonSerializer.Deserialize<ZombieAlmanacData>(cleanedJson, jsonOptions);

                        if (zombieData?.zombies != null)
                        {
                            Log.LogInfo($"[AlmanacZombieWindow_Patch] Parsed {zombieData.zombies.Count} zombies, looking for type {__instance.currentZombieType}");

                            foreach (var zombie in zombieData.zombies)
                            {
                                if (zombie != null && zombie.theZombieType == __instance.currentZombieType)
                                {
                                    finalName = zombie.name ?? originalName;
                                    finalIntroduce = zombie.introduce ?? originalIntroduce;
                                    finalInfo = zombie.info ?? originalInfo;
                                    Log.LogInfo($"[AlmanacZombieWindow_Patch] Found translated zombie: theZombieType={zombie.theZombieType}, name='{zombie.name}', introduce='{zombie.introduce?.Substring(0, Math.Min(50, zombie.introduce?.Length ?? 0))}', info='{zombie.info?.Substring(0, Math.Min(50, zombie.info?.Length ?? 0))}'");
                                    break;
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Log.LogWarning($"[AlmanacZombieWindow_Patch] Failed to parse JSON: {ex.Message}");
                    }
                }
                else
                {
                    Log.LogWarning($"[AlmanacZombieWindow_Patch] JSON file not found: {jsonPath}");
                }

                // Step 3: Check modded zombies override
                string moddedPath = Path.Combine(almanacDir, "ModdedZombiesTranslate.json");
                if (File.Exists(moddedPath))
                {
                    try
                    {
                        string moddedJson = File.ReadAllText(moddedPath);
                        if (!string.IsNullOrEmpty(moddedJson))
                        {
                            string cleanedModded = Utils.ExtractFirstJsonObject(moddedJson);
                            var moddedData = System.Text.Json.JsonSerializer.Deserialize<ZombieAlmanacData>(cleanedModded, new System.Text.Json.JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                            if (moddedData?.zombies != null)
                            {
                                foreach (var moddedInfo in moddedData.zombies)
                                {
                                    if (moddedInfo != null && moddedInfo.theZombieType == __instance.currentZombieType)
                                    {
                                        finalName = moddedInfo.name ?? finalName;
                                        finalIntroduce = moddedInfo.introduce ?? finalIntroduce;
                                        finalInfo = moddedInfo.info ?? finalInfo;
                                        Log.LogInfo($"[AlmanacZombieWindow_Patch] Modded override: name='{moddedInfo.name}'");
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Log.LogWarning($"[AlmanacZombieWindow_Patch] Modded parse failed: {ex.Message}");
                    }
                }

                Log.LogInfo($"[AlmanacZombieWindow_Patch] Final values - name='{finalName}', introduce='{finalIntroduce?.Substring(0, Math.Min(50, finalIntroduce?.Length ?? 0))}', info='{finalInfo?.Substring(0, Math.Min(50, finalInfo?.Length ?? 0))}'");

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

                // Step 5: Update showedZombieName (List<TextMeshProUGUI>)
                if (__instance.showedZombieName != null)
                {
                    foreach (TextMeshProUGUI text in __instance.showedZombieName)
                    {
                        if (text == null) continue;
                        text.autoSizeTextContainer = false;
                        text.text = $"{Utils.RemoveSizeTags(finalName)} ({(int)__instance.currentZombieType})";
                        text.font = fontAsset;
                        text.fontSizeMax = 21;
                        Log.LogInfo($"[AlmanacZombieWindow_Patch] Set showedZombieName[{text.name}] text: {text.text}");
                    }
                }

                // Step 6: Update showedZombieIntroduce
                if (__instance.showedZombieIntroduce != null)
                {
                    string spawnInfo = "";
                    var zombieDataDic = ZombieDataManager.zombieDataDic;
                    if (zombieDataDic != null && zombieDataDic.ContainsKey(__instance.currentZombieType))
                    {
                        try
                        {
                            ZombieDataManager.ZombieData zombieData = zombieDataDic[__instance.currentZombieType];
                            string spawnInfoFormat = null;
                            if (StringStore.translationStringRegex != null &&
                                StringStore.translationStringRegex.ContainsKey("出怪等级: (\\d+)\\n出怪权重: (\\d+)"))
                            {
                                spawnInfoFormat = StringStore.translationStringRegex["出怪等级: (\\d+)\\n出怪权重: (\\d+)"];
                            }

                            if (spawnInfoFormat != null)
                            {
                                spawnInfo = string.Format(spawnInfoFormat, new object[] { zombieData.summonLevel, zombieData.summonWeight }) + "\n\n";
                            }
                        }
                        catch (Exception ex)
                        {
                            Log.LogWarning($"[AlmanacZombieWindow_Patch] Error accessing zombie data: {ex.Message}");
                        }
                    }

                    string finalText = Utils.RemoveSizeTags(finalInfo) + "\n\n" + spawnInfo + Utils.RemoveSizeTags(finalIntroduce) + "\n\n";
                    __instance.showedZombieIntroduce.text = finalText;
                    __instance.showedZombieIntroduce.font = fontAsset;
                    __instance.showedZombieIntroduce.margin = new Vector4(3, 2, 12, 0);
                    __instance.showedZombieIntroduce.enableWordWrapping = true;
                    __instance.showedZombieIntroduce.overflowMode = TextOverflowModes.ScrollRect;

                    __instance.showedZombieIntroduce.ForceMeshUpdate();

                    Log.LogInfo($"[AlmanacZombieWindow_Patch] Set showedZombieIntroduce text length: {finalText.Length}, first 100: {finalText.Substring(0, Math.Min(100, finalText.Length))}");

                    if (__instance.zombieTextContent != null)
                    {
                        float textHeight = __instance.showedZombieIntroduce.preferredHeight;
                        __instance.zombieTextContent.sizeDelta = new Vector2(__instance.zombieTextContent.sizeDelta.x, textHeight);
                    }
                }

                Log.LogInfo($"[AlmanacZombieWindow_Patch] Successfully updated UI for zombie {__instance.currentZombieType}");
            }
            catch (Exception ex)
            {
                Log.LogError($"[AlmanacZombieWindow_Patch] Unexpected error in UpdateText: {ex.Message}");
                Log.LogError($"[AlmanacZombieWindow_Patch] Stack trace: {ex.StackTrace}");
            }
        }
    }
}
