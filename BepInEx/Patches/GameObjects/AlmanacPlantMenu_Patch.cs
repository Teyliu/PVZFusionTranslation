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
using static AlmanacPlantBank;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(AlmanacPlantMenu))]
    public static class AlmanacPlantMenu_Patch
    {
        [HarmonyPatch(nameof(AlmanacPlantMenu.Awake))]
        [HarmonyPostfix]
        private static void Awake(AlmanacPlantMenu __instance)
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

            AlmanacPlantWindow window = __instance.window;
            GameObject skinButton = window.skinButton;
            GameObject skinTextObj = skinButton.transform.GetChild(0).gameObject;
            GameObject skinShadowTextObj = skinTextObj.transform.GetChild(0).gameObject;
            TextMeshProUGUI skinShadowText = skinShadowTextObj.GetComponent<TextMeshProUGUI>();
            skinShadowText.text = StringStore.TranslateText("换肤_S");
            skinButton.transform.localScale /= 1.75f;
            skinButton.transform.localPosition = new Vector3(0.0f, 111.345f, 0.0f);
            skinButton.transform.GetChild(1).Translate(new Vector3(-0.35f, 0));
            skinButton.transform.GetChild(2).Translate(new Vector3(0.35f, 0));
        }

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
                string moddedPath = Path.Combine(almanacDir, "ModdedPlantsTranslate.json");

                string json;
                json = File.ReadAllText(path);

                TMP_FontAsset fontAsset = FontStore.LoadTMPFont(currentLanguage);

                PlantData plantData = JsonUtility.FromJson<PlantData>(json);

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
    }
}

