using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using MelonLoader;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;
using static MelonLoader.MelonLogger;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{

    [HarmonyPatch(typeof(AbyssMenu2))]
    public static class AbyssMenu2_Patch
    {
        private static void UpdateAbyss2Text(AbyssMenu2 __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            __instance.buffCountText.text = StringStore.TranslateText(__instance.buffCountText.text);
            __instance.buffCountText.font = fontAsset;

            __instance.money.text = StringStore.TranslateText(__instance.money.text);
            __instance.money.font = fontAsset;

            __instance.refreshText.text = StringStore.TranslateText(__instance.refreshText.text);
            __instance.refreshText.font = fontAsset;

            __instance.statistics.text = StringStore.TranslateText(__instance.statistics.text);
            __instance.statistics.font = fontAsset;

            Transform buffTextTransform = __instance.transform.FindChild("BuffText").transform;
            if (buffTextTransform != null) StringStore.TranslateTextTransform(buffTextTransform);

            Transform moneyTransform = __instance.transform.FindChild("Money").transform;
            if (moneyTransform != null) StringStore.TranslateTextTransform(moneyTransform);

            Transform buffCountTextTransform = __instance.transform.FindChild("BuffCountText").transform;
            if (buffCountTextTransform != null) StringStore.TranslateTextTransform(buffCountTextTransform);

            Transform refreshTextTransform = __instance.transform.FindChild("RefreshText").transform;
            if (refreshTextTransform != null) StringStore.TranslateTextTransform(refreshTextTransform);

            Transform optionsTransform = __instance.transform.FindChild("Options").transform;
            foreach (AbyssBuffButton abyssBuffButton in optionsTransform.GetComponentsInChildren<AbyssBuffButton>())
            {
                foreach (TextMeshProUGUI textMesh in abyssBuffButton.GetComponentsInChildren<TextMeshProUGUI>())
                {
                    textMesh.text = StringStore.TranslateText(textMesh.text);
                }
            }
        }

        public static GameObject ConvertToTextMeshProUGUI(GameObject originalText, Transform parent, string name)
        {
            GameObject newObj = new GameObject(name);
            newObj.transform.position = originalText.transform.position;
            newObj.AddComponent<CanvasRenderer>();
            newObj.AddComponent<RectTransform>();
            newObj.AddComponent<TextMeshProUGUI>();
            newObj.transform.SetParent(parent);
            newObj.transform.localScale = Vector3.one;

            UnityEngine.Object.Destroy(originalText);
            return newObj;
        }

        private static void ConvertButtonText(Transform original, string name)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            Transform transform = original.FindChild(name);
            Transform textTransform = transform.FindChild("text");
            string text = textTransform.GetComponent<Text>().text;
            Color color = textTransform.GetComponent<Text>().color;

            TextMeshProUGUI newGoBackText = ConvertToTextMeshProUGUI(textTransform.gameObject, transform, "text2").GetComponent<TextMeshProUGUI>();
            newGoBackText.autoSizeTextContainer = true;
            newGoBackText.text = StringStore.TranslateText(text, false);
            newGoBackText.font = fontAsset;
            newGoBackText.color = color;
        }

        [HarmonyPatch(nameof(AbyssMenu2.Start))]
        [HarmonyPostfix]
        private static void Start(AbyssMenu2 __instance)
        {
            UpdateAbyss2Text(__instance);

            ConvertButtonText(__instance.transform, "Goback");
            ConvertButtonText(__instance.transform, "Help");
            ConvertButtonText(__instance.transform, "Bag");
        }

        [HarmonyPatch(nameof(AbyssMenu2.UpdateIcons))]
        [HarmonyPostfix]
        private static void UpdateIcons(AbyssMenu2 __instance)
        {
            UpdateAbyss2Text(__instance);
        }

        [HarmonyPatch(nameof(AbyssMenu2.UpdateBuff))]
        [HarmonyPostfix]
        private static void UpdateBuff(AbyssMenu2 __instance)
        {
            UpdateAbyss2Text(__instance);
        }

        [HarmonyPatch(nameof(AbyssMenu2.BuyBuff))]
        [HarmonyPostfix]
        private static void BuyBuff(AbyssMenu2 __instance)
        {
            UpdateAbyss2Text(__instance);
        }

        [HarmonyPatch(nameof(AbyssMenu2.ShowBag))]
        [HarmonyPostfix]
        private static void ShowBag(AbyssMenu2 __instance)
        {
            UpdateAbyss2Text(__instance);
        }
    }
}
