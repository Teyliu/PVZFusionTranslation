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
    [HarmonyPatch(typeof(AlmanacZombieWindow))]
    public static class AlmanacZombieWindow_Patch
    {
        [HarmonyPatch(nameof(AlmanacZombieWindow.UpdateText))]
        [HarmonyPostfix]
        private static void UpdateText(AlmanacZombieWindow __instance)
        {
            string currentLanguage = Utils.Language.ToString();
            string almanacDir = GetAssetDir(AssetType.Almanac, Utils.Language);
            string path = Path.Combine(almanacDir, "ZombieStringsTranslate.json");
            string moddedPath = Path.Combine(almanacDir, "ModdedZombiesTranslate.json");

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

            ZombieAlmanacData zombieData = JsonUtility.FromJson<ZombieAlmanacData>(json);

            foreach (ZombieInfo zombieInfo in zombieData.zombies)
            {
                if (zombieInfo.theZombieType == __instance.currentZombieType)
                {
                    foreach (TextMeshProUGUI text in __instance.showedZombieName)
                    {
                        text.autoSizeTextContainer = false;
                        text.text = $"{Utils.RemoveSizeTags(zombieInfo.name)} ({(int)zombieInfo.theZombieType})";
                        text.font = fontAsset;
                        text.fontSizeMax = 21;
                    }

                    __instance.showedZombieIntroduce.text = Utils.RemoveSizeTags(zombieInfo.info) + "\n\n" + Utils.RemoveSizeTags(zombieInfo.introduce) + "\n\n";
                    __instance.showedZombieIntroduce.font = fontAsset;
                    __instance.showedZombieIntroduce.fontSizeMax = 21;
                    __instance.showedZombieIntroduce.margin = new Vector4(3, 2, 12, 0);

                    __instance.showedZombieIntroduce.enableWordWrapping = true;
                    __instance.showedZombieIntroduce.overflowMode = TextOverflowModes.ScrollRect;

                    Canvas.ForceUpdateCanvases();
                    __instance.showedZombieIntroduce.ForceMeshUpdate();

                    float textHeight = __instance.showedZombieIntroduce.preferredHeight;
                    __instance.zombieTextContent.sizeDelta = new Vector2(__instance.zombieTextContent.sizeDelta.x, textHeight);
                }
            }
        }
    }
}
