using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using System.IO;
using UnityEngine;
using static PvZ_Fusion_Translator__BepInEx_.FileLoader;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.Managers
{
    [HarmonyPatch(typeof(AlmanacPlantBank))]
    public static partial class AlmanacPlantBank_Patch
    {
        [HarmonyPatch(nameof(AlmanacPlantBank.InitNameAndInfoFromJson))]
        [HarmonyPostfix]
        private static void InitNameAndInfoFromJson(AlmanacPlantBank __instance)
        {
#if MULTI_LANGUAGE
            string currentLanguage = Utils.Language.ToString();
            string almanacDir = GetAssetDir(AssetType.Almanac, Utils.Language);
#else
			string almanacDir = GetAssetDir(AssetType.Almanac);
			string currentLanguage = "English";
#endif
            string path = Path.Combine(almanacDir, "LawnStringsTranslate.json");
            string moddedPath = Path.Combine(almanacDir, "ModdedPlantsTranslate.json");

            if (!File.Exists(path))
            {
                Log.LogError($"LawnStringsTranslate.json file not found at path: {path}");
                return;
            }

#if OBFUSCATE
			if (CheckSumStore.IsModified(path))
			{
				Log.LogError("File {0} was modified!", path);
				return;
			}
#endif

            string json;
            json = File.ReadAllText(path);

            bool hasAlmanacFont = false;
            TMP_FontAsset almanacFontAsset = null;
            if (FontStore.fontAssetDictSecondary != null && 
                (FontStore.fontAssetDictSecondary.ContainsKey(currentLanguage + "_Almanac") || FontStore.fontAssetDictSecondary.ContainsKey(currentLanguage)))
            {
                almanacFontAsset = FontStore.LoadTMPFontAlmanac(currentLanguage);
                hasAlmanacFont = true;
            }

#if MULTI_LANGUAGE
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(currentLanguage);
#else
			TMP_FontAsset fontAsset = FontStore.LoadTMPFont();
#endif

            if (__instance.introduce == null || __instance.plantName == null || __instance.cost == null)
            {
                Log.LogError("[AlmanacPlantBank_Patch] Required components are null");
                return;
            }

            TextMeshPro component = __instance.introduce.GetComponent<TextMeshPro>();
            TextMeshPro component2 = __instance.plantName.GetComponent<TextMeshPro>();
            TextMeshPro component3 = null;
            Transform plantNameChild = __instance.plantName.transform.GetChild(0);
            if (plantNameChild != null)
            {
                component3 = plantNameChild.GetComponent<TextMeshPro>();
            }
            TextMeshPro component4 = __instance.cost.GetComponent<TextMeshPro>();

            if (component == null || component2 == null || component4 == null)
            {
                Log.LogError("[AlmanacPlantBank_Patch] TextMeshPro components are null");
                return;
            }

            AlmanacPlantBank.PlantData plantData = JsonUtility.FromJson<AlmanacPlantBank.PlantData>(json);

            if (plantData?.plants == null)
            {
                Log.LogError("[AlmanacPlantBank_Patch] Plant data is null");
                return;
            }

            foreach (AlmanacPlantBank.PlantInfo plantInfo in plantData.plants)
            {
                if (plantInfo.seedType == __instance.theSeedType && !string.IsNullOrEmpty(plantInfo.name))
                {
                    component.autoSizeTextContainer = false;
                    component.text = plantInfo.info + "\n\n" + plantInfo.introduce;
                    component.overflowMode = TextOverflowModes.Page;

                    // fix dimensions for cost text
                    component.rectTransform.offsetMax = new Vector2(component.rectTransform.offsetMax.x, 27.3839f);
                    component.rectTransform.offsetMin = new Vector2(component.rectTransform.offsetMin.x, -29.3079f);
                    component.rectTransform.sizeDelta = new Vector2(component.rectTransform.sizeDelta.x, 50.917f);
                    component.transform.localPosition = new Vector3(component.transform.localPosition.x, component.transform.localPosition.y + 0.15f, component.transform.localPosition.z);


                    component2.text = plantInfo.name;
                    component2.autoSizeTextContainer = true;

                    if (component3 != null)
                    {
                        component3.text = Utils.RemoveColorTags(plantInfo.name ?? string.Empty);
                        component3.autoSizeTextContainer = true;
                    }

                    component4.text = plantInfo.cost;

                    if (hasAlmanacFont)
                    {
                        component.font = almanacFontAsset;
                        component4.font = almanacFontAsset;
                    }
                    else
                    {
                        component.font = fontAsset;
                        component4.font = fontAsset;
                    }
                    component2.font = fontAsset;
                    if (component3 != null)
                    {
                        component3.font = fontAsset;
                    }
                }
            }

            if (File.Exists(moddedPath))
            {
                string moddedJson;
                moddedJson = File.ReadAllText(moddedPath);

                AlmanacPlantBank.PlantData moddedPlantData = JsonUtility.FromJson<AlmanacPlantBank.PlantData>(moddedJson);

                if (moddedPlantData?.plants != null)
                {
                    foreach (AlmanacPlantBank.PlantInfo plantInfo in moddedPlantData.plants)
                    {
                        if (plantInfo.seedType == __instance.theSeedType && !string.IsNullOrEmpty(plantInfo.name))
                        {
                            component.autoSizeTextContainer = false;
                            component.text = plantInfo.info + "\n\n" + plantInfo.introduce;
                            component.overflowMode = TextOverflowModes.Page;

                            // fix dimensions for cost text
                            component.rectTransform.offsetMax = new Vector2(component.rectTransform.offsetMax.x, 27.3839f);
                            component.rectTransform.offsetMin = new Vector2(component.rectTransform.offsetMin.x, -29.3079f);
                            component.rectTransform.sizeDelta = new Vector2(component.rectTransform.sizeDelta.x, 50.917f);
                            component.transform.localPosition = new Vector3(component.transform.localPosition.x, component.transform.localPosition.y + 0.15f, component.transform.localPosition.z);


                            component2.text = plantInfo.name;
                            component2.autoSizeTextContainer = true;

                            if (component3 != null)
                            {
                                component3.text = Utils.RemoveColorTags(plantInfo.name ?? string.Empty);
                                component3.autoSizeTextContainer = true;
                            }

                            component4.text = plantInfo.cost;

                            if (hasAlmanacFont)
                            {
                                component.font = almanacFontAsset;
                                component4.font = almanacFontAsset;
                            }
                            else
                            {
                                component.font = fontAsset;
                                component4.font = fontAsset;
                            }
                            component2.font = fontAsset;
                            if (component3 != null)
                            {
                                component3.font = fontAsset;
                            }
                        }
                    }
                }
            }

            return;
        }

        [HarmonyPatch(nameof(AlmanacPlantBank.OnMouseDown))]
        [HarmonyPrefix]
        private static bool OnMouseDown(AlmanacPlantBank __instance)
        {
            TextMeshPro component = __instance.introduce.GetComponent<TextMeshPro>();
            if (component != null)
            {
                component.pageToDisplay = component.pageToDisplay > component.m_pageNumber ? 1 : component.pageToDisplay + 1;
                return false;
            }
            return true;
        }

        [HarmonyPatch(nameof(AlmanacPlantBank.PVPInit))]
        [HarmonyPostfix]
        private static void PVPInit(AlmanacPlantBank __instance)
        {
            if (__instance.introduce != null)
            {
                TextMeshPro component = __instance.introduce.GetComponent<TextMeshPro>();
                if (component != null)
                {
                    component.autoSizeTextContainer = false;
                }
            }

            Transform banTransform = __instance.transform.Find("Ban");
            if (banTransform != null && banTransform.childCount > 0)
            {
                Transform banChild = banTransform.GetChild(0);
                if (banChild != null)
                {
                    TextMeshPro banText = banChild.GetComponent<TextMeshPro>();
                    if (banText != null)
                    {
                        banText.text = StringStore.TranslateText(banText.text);
                    }
                }
            }
        }

        [HarmonyPatch(nameof(AlmanacPlantBank.Start))]
        [HarmonyPostfix]
        public static void Post_Start(AlmanacPlantBank __instance)
        {
            if (__instance.skinButton == null || __instance.skinButton.transform == null)
            {
                Log.LogWarning("[AlmanacPlantBank_Patch] Skin button is null");
                return;
            }

            if (__instance.skinButton.transform.childCount == 0)
            {
                Log.LogWarning("[AlmanacPlantBank_Patch] Skin button has no children");
                return;
            }

            GameObject skinTextObj = __instance.skinButton.transform.GetChild(0).gameObject;
            if (skinTextObj == null)
            {
                Log.LogWarning("[AlmanacPlantBank_Patch] Skin text object is null");
                return;
            }

            GameObject skinShadowTextObj = UnityEngine.Object.Instantiate(skinTextObj, parent: __instance.skinButton.transform);
            if (skinShadowTextObj == null)
            {
                Log.LogWarning("[AlmanacPlantBank_Patch] Failed to instantiate skin shadow text");
                return;
            }

            TextMeshPro skinShadowText = skinShadowTextObj.GetComponent<TextMeshPro>();
            if (skinShadowText != null)
            {
                skinShadowText.text = StringStore.TranslateText("换肤_S");
                skinShadowText.sortingOrder -= 2;
            }

            skinShadowTextObj.transform.Translate(new Vector3(0.015f, -0.015f, 0));
            skinTextObj.transform.Translate(new Vector3(-0.022f, 0));
            skinShadowTextObj.transform.Translate(new Vector3(-0.022f, 0));
            __instance.skinButton.transform.localScale /= 1.75f;
            __instance.skinButton.transform.Translate(new Vector3(-0.075f, -0.15f, 0));
            
            if (__instance.skinButton.transform.childCount > 2)
            {
                __instance.skinButton.transform.GetChild(1).Translate(new Vector3(0.35f, 0));
                __instance.skinButton.transform.GetChild(2).Translate(new Vector3(-0.35f, 0));
            }
        }
    }
}