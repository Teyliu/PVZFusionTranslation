using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(PlantDataMenu))]
    public static class PlantDataMenu_Patch
    {
        [HarmonyPatch(nameof(PlantDataMenu.Start))]
        [HarmonyPostfix]
        public static void Post_Start(PlantDataMenu __instance)
        {
            TranslatePlantDataMenu(__instance);
        }

        [HarmonyPatch(nameof(PlantDataMenu.Update))]
        [HarmonyPostfix]
        public static void Post_Update(PlantDataMenu __instance)
        {
            TranslatePlantDataMenu(__instance);
        }

        public static void TranslatePlantDataMenu(PlantDataMenu __instance)
        {
            PlantType thePlantType = __instance.plant.thePlantType;
            string plantName = Utils.GetPlantNameFromAlmanac(thePlantType);

            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach(TextMeshProUGUI text in __instance.nameText)
            {
                text.text = plantName;
                text.font = fontAsset;
            }

            foreach(TextMeshProUGUI text in __instance.infoText)
            {
                string toTranslate = text.text;
                string startColorTag = "";

                string colorPattern = @"(<color=[^>]+>)(.*?)(</color>)";
                Match match = Regex.Match(toTranslate, colorPattern);
                if(match.Success)
                {
                    startColorTag = match.Groups[1].Value;
                    toTranslate = match.Groups[2].Value;
                    Log.LogDebug(toTranslate);
                }

                string[] parts = toTranslate.Split("\n");
                List<string> translatedParts = new List<string>();

                foreach(string part in parts)
                {
                    translatedParts.Add(StringStore.TranslateText(part));
                }

                string joinedTranslation = String.Join("\n", translatedParts);

                if(startColorTag != "")
                {
                    text.text = startColorTag + joinedTranslation + "</color>";
                }
                else
                {
                    text.text = joinedTranslation;
                }

                text.font = fontAsset;
            }
        }
    }
}
