using System.Collections;
using System.Collections.Generic;
using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using PvZ_Fusion_Translator__BepInEx_.Patches.BaseTextObjects;
using UnityEngine;
using BepInEx.Unity.IL2CPP.Utils;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(OppsiteBuff))]
    public static class OppsiteBuff_Patch
    {
        [HarmonyPatch(nameof(OppsiteBuff.ShowConfig))]
        [HarmonyPostfix]
        public static void ShowConfig()
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            // Text is shown via InGameText.Instance.ShowText() - handled by InGameText_Patch
            // Apply font to any created UI elements
        }

        [HarmonyPatch(nameof(OppsiteBuff.ShowChoice))]
        [HarmonyPostfix]
        public static void ShowChoice()
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            // Text contains hardcoded "\n\n但" separator (3.7 OppsiteBuff.cs:107)
            // Replace with language-specific "but" word on all visible TextMeshProUGUI elements
            // Use a delayed coroutine since UI elements are created in the same frame
            MonoBehaviour coroutineHost = UnityCoroutineHelper.Instance;
            if (coroutineHost == null)
            {
                coroutineHost = PluginCore.MonoInstance;
            }
            if (coroutineHost != null)
            {
                System.Collections.IEnumerator routine = ReplaceButOnUIRoutine(fontAsset);
                coroutineHost.StartCoroutine(routine);
            }
        }

        private static System.Collections.IEnumerator ReplaceButOnUIRoutine(TMP_FontAsset fontAsset)
        {
            yield return null;
            yield return null;

            for (int frame = 0; frame < 5; frame++)
            {
                bool foundChinese = false;
                foreach (TextMeshProUGUI txt in UnityEngine.Object.FindObjectsOfType<TextMeshProUGUI>())
                {
                    if (txt != null && txt.gameObject.activeInHierarchy && !string.IsNullOrEmpty(txt.text) && txt.text.Contains("但"))
                    {
                        txt.text = StringStore.ReplaceOppositeBuffBut(txt.text);
                        txt.font = fontAsset;
                        foundChinese = true;
                    }
                }

                if (!foundChinese) break;
                yield return null;
            }
        }
    }
}
