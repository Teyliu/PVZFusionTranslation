using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;
using Object = UnityEngine.Object;

namespace PvZ_Fusion_Translator.Patches.GameObjects.ButtonObjects;

public sealed class OptionButtonData
{
    public OptionBtn Button { get; init; }

    public Vector3 Position { get; init; }

    ///<remarks><see langword="null"/> if it is the "Next" button.</remarks>
    public Utils.LanguageEnum? Language { get; set; }

    ///<remarks><see langword="null"/> if it is the "Next" button.</remarks>
    public Utils.ToggleEnum? Toggle { get; set; }

    public bool IsNextButton { get; set; }

    public bool Shifted;
}

internal static class OptLanguageBtn_Patch
{
    public static readonly Dictionary<int, OptionButtonData> LanguageBtnDict = new(), ToggleBtnDict = new();

    private static bool s_buttonsCreated, s_togglesCreated;

    // ReSharper disable once NotAccessedField.Local
    private static OptionBtn s_cachedTemplateButton, s_cachedTemplateToggleButton;

    private const float
        StartX = 4.3241f + 2.56f,
        StartY = 2.7769f,
        YSpacing = 1.2505f,
        ToggleStartX = 4.3241f,
        ToggleStartY = -0.9746f;

    private static List<Utils.LanguageEnum> s_availableLanguages;

    private static List<Utils.ToggleEnum> s_availableToggles;

    private const int LanguagesPerPage = 5;

    private static int s_currentPage;

    // 5 language buttons + 1 next button
    public static readonly OptionBtn[] ButtonSlots = new OptionBtn[6], ToggleSlots = new OptionBtn[3];

    public static void CreateLanguageButtons(OptionBtn templateButton)
    {
        if (s_buttonsCreated)
            return;

        s_buttonsCreated = true;
        s_cachedTemplateButton = templateButton;

        s_availableLanguages = Enum.GetValues(typeof(Utils.LanguageEnum))
           .Cast<Utils.LanguageEnum>()
           .Where(lang => lang != Utils.LanguageEnum.LangEnd)
           .ToList();

        for (var i = 0; i < 6; i++)
        {
            var newButton = Object.Instantiate(templateButton, templateButton.transform.parent);
            newButton.tag = "LangOpt";

            foreach (var child in newButton.GetComponentsInChildren<Transform>())
                child.tag = "LangOpt";

            newButton.optionType = 80 + i;

            var yPos = StartY - i * YSpacing;
            Vector3 pos = new(StartX, yPos);
            newButton.transform.position = pos;

            ButtonSlots[i] = newButton;

            LanguageBtnDict[newButton.GetInstanceID()] = new()
            {
                Button = newButton,
                Position = pos,
            };
        }

        UpdatePage();
    }

    public static void CreateToggleButtons(OptionBtn templateButton)
    {
        if (s_togglesCreated)
            return;

        s_togglesCreated = true;
        s_cachedTemplateToggleButton = templateButton;

        s_availableToggles = Enum.GetValues<Utils.ToggleEnum>()
           .Where(lang => lang != Utils.ToggleEnum.ToggleEnd)
           .ToList();

        for (var i = 0; i < 3; i++)
        {
            var newButton = Object.Instantiate(templateButton, templateButton.transform.parent);
            newButton.tag = "LangOpt";

            foreach (var child in newButton.GetComponentsInChildren<Transform>())
                child.tag = "LangOpt";

            newButton.optionType = 100 + i;

            var yPos = ToggleStartY - i * YSpacing;
            Vector3 pos = new(ToggleStartX, yPos);
            newButton.transform.position = pos;

            ToggleSlots[i] = newButton;

            ToggleBtnDict[newButton.GetInstanceID()] = new()
            {
                Button = newButton,
                Position = pos,
            };
        }

        UpdatePage();
    }

    private static void UpdatePage()
    {
        var startIndex = s_currentPage * LanguagesPerPage;
        var langCount = s_availableLanguages.Count;
        var toggleCount = s_togglesCreated ? s_availableToggles.Count : 0;

        for (var i = 0; i < 5; i++)
        {
            var btn = ButtonSlots[i];
            var data = LanguageBtnDict[btn.GetInstanceID()];

            if (startIndex + i < langCount)
            {
                var lang = s_availableLanguages[startIndex + i];
                data.Language = lang;
                data.IsNextButton = false;
                btn.gameObject.SetActive(true);

                var languageName = Utils.LanguageNames.TryGetValue(lang, out var name) ? name : lang.ToString();
                UpdateButtonText(btn, languageName, FontStore.LoadTMPFont(lang.ToString()));
            }
            else
            {
                data.Language = null;
                data.IsNextButton = false;
                btn.gameObject.SetActive(false);
            }
        }

        if (s_togglesCreated)
            for (var i = 0; i < 3; i++)
            {
                var btn = ToggleSlots[i];
                var data = ToggleBtnDict[btn.GetInstanceID()];

                if (i < toggleCount)
                {
                    var toggle = s_availableToggles[i];
                    data.Toggle = toggle;
                    data.IsNextButton = false;
                    btn.gameObject.SetActive(true);

                    var buttonText = Utils.ToggleNames.TryGetValue(toggle, out var name)
                        ? name
                        : toggle.ToString();

                    UpdateButtonText(
                        btn,
                        StringStore.TranslateText(buttonText),
                        FontStore.LoadTMPFont(Utils.Language.ToString())
                    );

                    string sourceMsg;

                    switch (i)
                    {
                        case 0:
                            sourceMsg =
                                $"<size=10>Texture Source:\n{(Core.Instance.ConfigDefaultTextures.Value ? "Default" : "Custom")}";

                            FlashMessage(btn, sourceMsg, 0.1f, false);
                            break;
                        case 1:
                            sourceMsg =
                                $"<size=10>Audio Source:\n{(Core.Instance.ConfigDefaultAudio.Value ? "Default" : "Custom")}";

                            FlashMessage(btn, sourceMsg, 0.1f, false);
                            break;
                        case 2:
                            sourceMsg =
                                $"<size=10>Translation Source:\n{(Core.Instance.ConfigUseLocal.Value ? "Local" : "Online")}";

                            FlashMessage(btn, sourceMsg, 0.1f, false);
                            break;
                    }
                }
                else
                {
                    data.Language = null;
                    data.IsNextButton = false;
                    btn.gameObject.SetActive(false);
                }
            }

        // "Next" button always visible at index 5
        var nextBtn = ButtonSlots[5];
        var nextData = LanguageBtnDict[nextBtn.GetInstanceID()];
        nextData.Language = null;
        nextData.IsNextButton = true;
        nextBtn.gameObject.SetActive(true);
        UpdateButtonText(nextBtn, "Next");
    }

    public static void UpdateButtonText(OptionBtn button, string languageName, TMP_FontAsset fontAsset = null)
    {
        var defaultAsset = FontStore.LoadTMPFont("English");

        for (var i = 0; i < 3; i++)
        {
            var textTransform = button.transform.GetChild(i);

            if (textTransform == null)
                continue;

            if (i == 0)
                textTransform.gameObject.SetActive(false);

            var text = textTransform.GetComponent<TextMeshProUGUI>();

            if (text == null)
                continue;

            if (i == 0)
            {
                text.text = "";
                text.color = Color.red;
            }
            else
                text.text = languageName;

            text.fontSize = 16;
            text.font = fontAsset != null ? fontAsset : defaultAsset;
            text.autoSizeTextContainer = false;
        }
    }

    public static void FlashMessage(OptionBtn button, string message, float yShift = 0.0f, bool useTimer = true)
    {
        var child = button.transform.GetChild(0);

        if (child == null)
            return;

        var text = child.GetComponent<TextMeshProUGUI>();
        var originalMsg = "";

        if (text != null)
        {
            originalMsg = text.text;
            text.text = message;
            var isToggle = ToggleBtnDict.TryGetValue(button.GetInstanceID(), out _);

            if (isToggle)
            {
                text.transform.position = new(
                    text.transform.position.x,
                    text.transform.position.y + (ToggleBtnDict[button.GetInstanceID()].Shifted ? 0.0f : yShift),
                    text.transform.position.z
                );

                ToggleBtnDict[button.GetInstanceID()].Shifted = true;
            }
            else
            {
                text.transform.position = new(
                    text.transform.position.x,
                    text.transform.position.y + (LanguageBtnDict[button.GetInstanceID()].Shifted ? 0.0f : yShift),
                    text.transform.position.z
                );

                LanguageBtnDict[button.GetInstanceID()].Shifted = true;
            }
        }

        child.gameObject.SetActive(true);

        if (useTimer)
            Task.Delay(1000)
               .ContinueWith(
                    _ =>
                    {
                        if (button == null || child == null || !child.gameObject.activeSelf)
                            return;

                        var buttonData = ToggleBtnDict[button.GetInstanceID()];

                        if (buttonData.Toggle == null)
                            return;

                        var sourceMsg = buttonData.Toggle switch
                        {
                            Utils.ToggleEnum.Textures =>
                                $"<size=10>Texture Source:\n{(Core.Instance.ConfigDefaultAudio.Value ? "Default" : "Custom")}",
                            Utils.ToggleEnum.Audio =>
                                $"<size=10>Audio Source:\n{(Core.Instance.ConfigDefaultAudio.Value ? "Default" : "Custom")}",
                            _ => originalMsg,
                        };

                        text.text = sourceMsg;
                    }
                );
    }

    private static void ToggleCustomAssets(string type)
    {
        switch (type)
        {
            case "Textures":
                Core.Instance.ConfigDefaultTextures.Value = !Core.Instance.ConfigDefaultTextures.Value;
                TextureStore.Reload();
                Core.Coroutine(TextureStore.ReplaceTexturesCoroutine());
                break;
            case "Audio":
                Core.Instance.ConfigDefaultAudio.Value = !Core.Instance.ConfigDefaultAudio.Value;
                break;
            case "SwapLocal":
                Utils.WarnLocalData();
                break;
        }
    }

    [HarmonyPatch(typeof(OptionBtn))]
    public static class OptLangBtn_Patch
    {
        public static void Awake(OptionBtn __instance)
        {
            if (s_buttonsCreated && s_cachedTemplateButton != null)
                return;

            s_buttonsCreated = false;
            s_togglesCreated = false;
            CreateLanguageButtons(__instance);
            CreateToggleButtons(__instance);
        }

        [HarmonyPatch("OnMouseUpAsButton"), HarmonyPrefix]
        private static void OnMouseUpAsButton(OptionBtn __instance)
        {
            if (!ModFeatures.IsMultiLanguage)
                return;

            if (LanguageBtnDict.TryGetValue(__instance.GetInstanceID(), out var btnData))
            {
                if (btnData.IsNextButton)
                {
                    s_currentPage = (s_currentPage + 1) %
                        (int)Math.Ceiling((float)s_availableLanguages.Count / LanguagesPerPage);

                    UpdatePage();
                    return;
                }

                if (btnData.Language is { } selectedLang)
                {
                    var currentLang = Utils.Language.ToString();

                    if (currentLang == selectedLang.ToString())
                        FlashMessage(btnData.Button, "Already Selected!");
                    else
                    {
                        Utils.ChangeLanguage(selectedLang.ToString());
                        Debug.Log($"Language changed to: {selectedLang}");
                        FlashMessage(btnData.Button, "Language Changed!");
                    }
                }
            }

            if (!ToggleBtnDict.TryGetValue(__instance.GetInstanceID(), out var toggleData))
                return;

            var toggleType = toggleData.Toggle.ToString();
            ToggleCustomAssets(toggleType);

            switch (toggleType)
            {
                case "Textures":
                    FlashMessage(toggleData.Button, "<size=10>Toggled custom textures!\n(Restart Required)", 0.1f);
                    break;
                case "Audio":
                    FlashMessage(toggleData.Button, "<size=10>Toggled custom audio!", 0.1f);
                    break;
            }
        }

        [HarmonyPatch(nameof(OptionBtn.Update)), HarmonyPostfix]
        private static void Update(OptionBtn __instance)
        {
            if (!ModFeatures.IsMultiLanguage)
                return;

            if (LanguageBtnDict.TryGetValue(__instance.GetInstanceID(), out var btnData))
                btnData.Button.transform.position = btnData.Position;

            if (ToggleBtnDict.TryGetValue(__instance.GetInstanceID(), out var toggleData))
                toggleData.Button.transform.position = toggleData.Position;
        }
    }
}
