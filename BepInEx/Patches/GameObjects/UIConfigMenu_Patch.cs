using HarmonyLib;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using TMPro;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(UIConfigMenu))]
    public static class UIConfigMenu_Patch
    {
        [HarmonyPatch("Start")]
        [HarmonyPostfix]
        private static void Start(UIConfigMenu __instance)
        {
            TranslateContents(__instance);
        }

        [HarmonyPatch(nameof(UIConfigMenu.OnExit))]
        [HarmonyPostfix]
        private static void OnExit(UIConfigMenu __instance)
        {
            TranslateContents(__instance);
        }

        private static void TranslateContents(UIConfigMenu menu)
        {
            if (menu == null) return;

            TMP_InputField[] inputs = menu.GetComponentsInChildren<TMP_InputField>(true);
            foreach (TMP_InputField input in inputs)
            {
                if (input == null) continue;

                TMP_Text placeholder = input.placeholder as TMP_Text;
                TranslateText(placeholder, true);
            }

            foreach (TextMeshProUGUI text in menu.GetComponentsInChildren<TextMeshProUGUI>(true))
            {
                bool isInputValue = false;
                foreach (TMP_InputField input in inputs)
                {
                    if (input != null && input.textComponent == text)
                    {
                        isInputValue = true;
                        break;
                    }
                }

                TranslateText(text, !isInputValue);
            }
        }

        private static void TranslateText(TMP_Text text, bool translate)
        {
            if (text == null) return;

            if (translate && !string.IsNullOrEmpty(text.text))
            {
                text.text = StringStore.TranslateText(text.text);
            }

            text.font = FontStore.LoadTMPFont(Utils.Language.ToString());
        }
    }
}
