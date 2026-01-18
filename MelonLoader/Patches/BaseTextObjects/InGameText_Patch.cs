using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using PvZ_Fusion_Translator.Patches.Managers;
using UnityEngine.TextCore.Text;

namespace PvZ_Fusion_Translator.Patches.BaseTextObjects
{
	[HarmonyPatch(typeof(InGameText))]
	public static class InGameText_Patch
	{
        [HarmonyPatch(nameof(InGameText.ShowText))]
        public static void ShowText(InGameText __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach (TextMeshProUGUI txt in __instance.textMeshes)
            {
                string travelMatch = TravelMgr_Patch.MatchTravelBuff(txt.text);

                if (travelMatch != "")
                {
                    txt.text = travelMatch;
                }
                else
                {
                    txt.text = StringStore.TranslateText(txt.text, true);
                }
                txt.font = fontAsset;
            }
        }
	}
}