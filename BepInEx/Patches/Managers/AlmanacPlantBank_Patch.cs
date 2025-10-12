using System.IO;
using HarmonyLib;
using Il2CppInterop.Runtime;
using PvZ_Fusion_Translator__BepInEx_;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using TMPro;
using UnityEngine;
using static PvZ_Fusion_Translator__BepInEx_.FileLoader;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.Managers
{
    [HarmonyPatch(typeof(AlmanacPlantBank))]
    public static partial class AlmanacPlantBank_Patch
    {
        [HarmonyPatch(nameof(AlmanacPlantBank.InitNameAndInfoFromJson))]
        [HarmonyPostfix]
        public static void InitNameAndInfoFromJson(AlmanacPlantBank __instance)
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
                return;
            }

#if OBFUSCATE
            if (CheckSumStore.IsModified(path))
            {
                return;
            }
#endif

            string json = File.ReadAllText(path);

            bool hasAlmanacFont = false;
            TMP_FontAsset almanacFontAsset = null;
            if (FontStore.fontAssetDictSecondary.ContainsKey(currentLanguage + "_Almanac") || FontStore.fontAssetDictSecondary.ContainsKey(currentLanguage))
            {
                almanacFontAsset = FontStore.LoadTMPFontAlmanac(currentLanguage);
                hasAlmanacFont = true;
            }

#if MULTI_LANGUAGE
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(currentLanguage);
#else
			TMP_FontAsset fontAsset = FontStore.LoadTMPFont();
#endif

            TextMeshPro component = __instance.introduce.GetComponent<TextMeshPro>();
            TextMeshPro component2 = __instance.plantName.GetComponent<TextMeshPro>();
            TextMeshPro component3 = __instance.plantName.transform.GetChild(0).GetComponent<TextMeshPro>();
            TextMeshPro component4 = __instance.cost.GetComponent<TextMeshPro>();
            TextMeshPro component5 = __instance.introduce.GetComponentInChildren<TextMeshPro>();
            #if DEBUG
            Log.LogWarning($"Introduce text: {component?.text}");
            Log.LogWarning($"Plant name: {component2?.text}");
            #endif
            //component.text = component.text ?? string.Empty;

            AlmanacPlantBank.PlantData plantData = JsonUtility.FromJson<AlmanacPlantBank.PlantData>(json);

            foreach (AlmanacPlantBank.PlantInfo plantInfo in plantData.plants)
            {
                if (plantInfo.seedType == __instance.theSeedType && !string.IsNullOrEmpty(plantInfo.name))
                {
                    #if DEBUG
                    Log.LogInfo($"Processing plant type: {plantInfo.seedType}");
                    Log.LogInfo($"Plant info: {plantInfo.info}, Name: {plantInfo.name}, Cost: {plantInfo.cost}, Introduce: {plantInfo.introduce}");
                    #endif
                    component.autoSizeTextContainer = false;
                    component.text = plantInfo.info + "\n\n" + plantInfo.introduce;
                    component.overflowMode = TextOverflowModes.Page;

                    component.rectTransform.offsetMax = new Vector2(component.rectTransform.offsetMax.x, 27.3839f);
                    component.rectTransform.offsetMin = new Vector2(component.rectTransform.offsetMin.x, -29.3079f);
                    component.rectTransform.sizeDelta = new Vector2(component.rectTransform.sizeDelta.x, 50.917f);
                    component.transform.localPosition = new Vector3(component.transform.localPosition.x, component.transform.localPosition.y + 0.15f, component.transform.localPosition.z);

                    component2.text = plantInfo.name;
                    component2.autoSizeTextContainer = true;

                    #if DEBUG
                    Log.LogInfo($"Processing plant name: '{plantInfo.name}' (null: {plantInfo.name == null})");
                    #endif
                    component3.text = Utils.RemoveColorTags(plantInfo.name ?? string.Empty);
                    component3.autoSizeTextContainer = true;

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
                    component3.font = fontAsset;
                }
            }

            if (File.Exists(moddedPath))
            {
                string moddedJson = File.ReadAllText(moddedPath);
                AlmanacPlantBank.PlantData moddedPlantData = JsonUtility.FromJson<AlmanacPlantBank.PlantData>(moddedJson);

                foreach (AlmanacPlantBank.PlantInfo plantInfo in moddedPlantData.plants)
                {
                    if (plantInfo.seedType == __instance.theSeedType && !string.IsNullOrEmpty(plantInfo.name))
                    {
                        component.autoSizeTextContainer = false;
                        component.text = plantInfo.info + "\n\n" + plantInfo.introduce;
                        component.overflowMode = TextOverflowModes.Page;

                        component.rectTransform.offsetMax = new Vector2(component.rectTransform.offsetMax.x, 27.3839f);
                        component.rectTransform.offsetMin = new Vector2(component.rectTransform.offsetMin.x, -29.3079f);
                        component.rectTransform.sizeDelta = new Vector2(component.rectTransform.sizeDelta.x, 50.917f);
                        component.transform.localPosition = new Vector3(component.transform.localPosition.x, component.transform.localPosition.y + 0.15f, component.transform.localPosition.z);

                        component2.text = plantInfo.name;
                        component2.autoSizeTextContainer = true;

                        #if DEBUG
                        Log.LogInfo($"Processing plant name: '{plantInfo.name}' (null: {plantInfo.name == null})");
                        #endif
                        component3.text = Utils.RemoveColorTags(plantInfo.name ?? string.Empty);
                        component3.autoSizeTextContainer = true;

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
                        component3.font = fontAsset;
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
            TextMeshPro component = __instance.introduce.GetComponent<TextMeshPro>();
            if (component != null)
            {
                string originalText = component.text;
                component.autoSizeTextContainer = false;
                component.text = StringStore.TranslateText(component.text);
                __instance.introduce.GetComponent<TextMeshPro>().text = component.text;
            }

            Transform banTransform = __instance.transform.FindChild("Ban").GetChild(0);
            if (banTransform != null)
            {
                TextMeshPro banText = banTransform.GetComponent<TextMeshPro>();
                string originalBanText = banText.text;
                banText.text = StringStore.TranslateText(banText.text);
            }
        }
    }
}