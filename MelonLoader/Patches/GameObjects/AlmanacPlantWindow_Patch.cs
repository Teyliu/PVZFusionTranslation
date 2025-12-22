using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using System.Text.RegularExpressions;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static PvZ_Fusion_Translator.FileLoader;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(AlmanacPlantWindow))]
    public static class AlmanacPlantWindow_Patch
    {
        [HarmonyPatch(nameof(AlmanacPlantWindow.UpdateText))]
        [HarmonyPostfix]
        private static void UpdateText(AlmanacPlantWindow __instance)
        {
            string currentLanguage = Utils.Language.ToString();
            string almanacDir = GetAssetDir(AssetType.Almanac, Utils.Language);
            string path = Path.Combine(almanacDir, "LawnStringsTranslate.json");
            string moddedPath = Path.Combine(almanacDir, "ModdedPlantsTranslate.json");

            string json;
            json = File.ReadAllText(path);

            bool hasAlmanacFont = false;
            TMP_FontAsset almanacFontAsset = null;
            if (FontStore.fontAssetDictSecondary.ContainsKey(currentLanguage + "_Almanac") || FontStore.fontAssetDictSecondary.ContainsKey(currentLanguage))
            {
                almanacFontAsset = FontStore.LoadTMPFontAlmanac(currentLanguage);
                hasAlmanacFont = true;
            }

            TMP_FontAsset fontAsset = (hasAlmanacFont) ? FontStore.LoadTMPFontAlmanac(Utils.Language.ToString()) : FontStore.LoadTMPFont(Utils.Language.ToString());

            AlmanacPlantBank.PlantData plantData = JsonUtility.FromJson<AlmanacPlantBank.PlantData>(json);

            foreach (AlmanacPlantBank.PlantInfo plantInfo in plantData.plants)
            {
                if (plantInfo.seedType == (int)__instance.currentPlantType)
                {
                    foreach (TextMeshProUGUI text in __instance.showedPlantName)
                    {
                        text.text = $"{Utils.RemoveSizeTags(plantInfo.name)} ({plantInfo.seedType})";
                        text.font = fontAsset;
                    }

                    __instance.showedPlantIntroduce.text = Utils.RemoveSizeTags(plantInfo.info) + "\n\n" + Utils.RemoveSizeTags(plantInfo.introduce) + "\n\n";
                    __instance.showedPlantIntroduce.font = fontAsset;
                    __instance.showedPlantIntroduce.margin = new Vector4(6, 2, 12, 0);

                    __instance.showedPlantIntroduce.enableWordWrapping = true;
                    __instance.showedPlantIntroduce.overflowMode = TextOverflowModes.ScrollRect;

                    Canvas.ForceUpdateCanvases();
                    __instance.showedPlantIntroduce.ForceMeshUpdate();

                    float textHeight = __instance.showedPlantIntroduce.preferredHeight;
                    __instance.plantTextContent.sizeDelta = new Vector2(__instance.plantTextContent.sizeDelta.x, textHeight);
                }
            }
        }
    }
}
