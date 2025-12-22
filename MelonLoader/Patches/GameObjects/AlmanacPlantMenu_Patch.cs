using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using System.Text.RegularExpressions;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static PvZ_Fusion_Translator.FileLoader;
using static PvZ_Fusion_Translator.Utils;

namespace PvZ_Fusion_Translator.Patches.GameObjects
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
        }

        [HarmonyPatch(nameof(AlmanacPlantMenu.SearchChanged))]
        [HarmonyPrefix]
        public static bool SearchChanged(AlmanacPlantMenu __instance, ref TMP_InputField inputField)
        {
            string search = inputField.text;
            if (search != StringStore.TranslateText("搜索"))
            {
                string currentLanguage = Utils.Language.ToString();
                string almanacDir = GetAssetDir(AssetType.Almanac, Utils.Language);
                string path = Path.Combine(almanacDir, "LawnStringsTranslate.json");
                string moddedPath = Path.Combine(almanacDir, "ModdedPlantsTranslate.json");

                string json;
                json = File.ReadAllText(path);

                TMP_FontAsset fontAsset = FontStore.LoadTMPFont(currentLanguage);

                AlmanacPlantBank.PlantData plantData = JsonUtility.FromJson<AlmanacPlantBank.PlantData>(json);

                Il2CppSystem.Collections.Generic.List<PlantType> searchedPlants = new();

                foreach (AlmanacPlantBank.PlantInfo plantInfo in plantData.plants)
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
