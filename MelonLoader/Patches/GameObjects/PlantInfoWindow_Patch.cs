using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using MelonLoader.TinyJSON;
using PvZ_Fusion_Translator.AssetStore;
using Unity.Collections;
using UnityEngine;
using UnityEngine.UIElements;
using static PvZ_Fusion_Translator.FileLoader;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(PlantInfoWindow))]
    public static class PlantInfoWindow_Patch
    {
        [HarmonyPatch(nameof(PlantInfoWindow.InitText))]
        [HarmonyPostfix]
        private static void InitText(PlantInfoWindow __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            PlantType thePlantType = __instance.plant.thePlantType;

            foreach (TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                if(txt.name.Contains("Introduce"))
                {
                    txt.text = StringStore.TranslateText(txt.text);

                    string text = txt.text;
                    string[] lines = text.Split("\n");

                    lines[0] = Utils.GetPlantNameFromAlmanac(thePlantType);
                    string updatedText = String.Join("\n", lines);

                    txt.text = updatedText;
                }
                else
                {
                    txt.text = StringStore.TranslateText(txt.text);
                }

                txt.font = fontAsset;
            }

            Transform parentWindowTransform = __instance.transform.parent;
            Transform returnPlantTransform = parentWindowTransform.FindChild("Close");
            
            foreach(TextMeshProUGUI txt in returnPlantTransform.GetComponentsInChildren<TextMeshProUGUI>())
            {
                txt.text = StringStore.TranslateText("合上");
            }
        }
    }
}