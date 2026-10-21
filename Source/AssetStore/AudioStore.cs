// ReSharper disable once RedundantUsingDirective
using System.Reflection;
// ReSharper disable once RedundantUsingDirective
using HarmonyLib;

namespace PvZ_Fusion_Translator.AssetStore;

internal static class AudioStore
{
    public static readonly Dictionary<string, AudioClip> AudioClips = [];

    public static Dictionary<string, (string, string)> AudioClipNames = [];

    private static bool s_overrideEnabled;

    private static readonly string s_customAudioPath = Path.Combine(Core.ModDirectory, "[Custom Audios]");

    private static readonly string[] s_allowedExts = [".wav", ".mp3", ".ogg"];

    public static Canvas Canvas { get; set; }

    public static RectTransform SongRectTransform { get; private set; }

    public static void Init() => LoadAudios();

    public static void LoadAudios()
    {
        if (!Directory.Exists(s_customAudioPath))
            Directory.CreateDirectory(s_customAudioPath);

        var audioFiles = Directory.GetFiles(s_customAudioPath, "*", SearchOption.AllDirectories);
        var ovrClip = audioFiles.SingleOrDefault(f => Path.GetFileNameWithoutExtension(f) == "REPLACE_ALL");

        if (ovrClip == null)
            foreach (var clip in audioFiles
               .Where(file => s_allowedExts.Contains(Path.GetExtension(file)))
               .Select(file => AudioImportLibAPI.LoadAudioClip(file)))
            {
                AudioClips.Add(clip.name, clip);
                Log.LogInfo("Added Override: " + clip.name);
            }
        else
        {
            var clip = AudioImportLibAPI.LoadAudioClip(ovrClip);
            AudioClips.Add(clip.name, clip);
            s_overrideEnabled = true;
            Log.LogInfo("Added Override: " + clip.name);
        }
#if MELONLOADER
        var audioSourceType = typeof(AudioSource);
        const string SourceMethodName = "Play";
        var prefixMethod = typeof(AudioStore).GetMethod(nameof(AudioPlayPatch), BindingFlags.Static | BindingFlags.Public);

        if (prefixMethod == null)
        {
            Log.LogError($"Couldn't find method named \"AudioPlayPatch\" in type <{typeof(AudioStore)}>.");
            return;
        }

        _ = Core.Instance.HarmonyInstance.Patch(
            AccessTools.Method(audioSourceType, SourceMethodName),
            new(prefixMethod)
        );

        Core.Instance.HarmonyInstance.Patch(
            AccessTools.Method(audioSourceType, SourceMethodName, [typeof(ulong)]),
            new(prefixMethod)
        );
#endif
    }

    public static void InitializeCanvas()
    {
        Debug.Assert(ModFeatures.IsAudioTesting, nameof(ModFeatures.IsAudioTesting));

        if (Canvas != null)
            return; // Prevent duplicate canvas creation

        Canvas = new GameObject("AudioSourceCanvas").AddComponent<Canvas>();
        Canvas.renderMode = RenderMode.ScreenSpaceOverlay;

        var scaler = Canvas.gameObject.AddComponent<UnityEngine.UI.CanvasScaler>();
        scaler.uiScaleMode = UnityEngine.UI.CanvasScaler.ScaleMode.ScaleWithScreenSize;
        scaler.referenceResolution = new(1920, 1080);

        Canvas.gameObject.AddComponent<UnityEngine.UI.GraphicRaycaster>();

        // Add a RectTransform for positioning text
        var songTextObject = new GameObject("SongText");
        songTextObject.transform.SetParent(Canvas.transform);

        SongRectTransform = songTextObject.AddComponent<RectTransform>();
        SongRectTransform.anchorMin = new(1, 1); // Top-right corner
        SongRectTransform.anchorMax = new(1, 1);
        SongRectTransform.pivot = new(1, 1);
        SongRectTransform.anchoredPosition = new(-20, -20); // Adjust margin

        // Add a TextMeshPro component for the text
        var textComponent = songTextObject.AddComponent<TextMeshProUGUI>();
        textComponent.alignment = TextAlignmentOptions.Right;
        textComponent.fontSize = 24;
        textComponent.color = Color.white;
        textComponent.text = "Current Song: None"; // Placeholder
    }

    public static void AudioSources()
    {
        if (!Directory.Exists(s_customAudioPath))
            Directory.CreateDirectory(s_customAudioPath);

        var path = Path.Combine(s_customAudioPath, "audio_source.json");

        if (!File.Exists(path))
        {
            Log.LogError($"LawnStringsTranslate.json file not found at path: {path}");
            return;
        }

        var json = File.ReadAllText(path);
        AudioClipNames = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, (string, string)>>(json);
    }

    public static (string, string) GetAudioSource(string clipName) =>
        AudioClipNames.TryGetValue(clipName, out var audioSource) ? audioSource : ("Music", "Source Unknown");

    public static void UpdateAudioSourceText(string clipName, string sourceName)
    {
        if (SongRectTransform == null)
            InitializeCanvas();

        var textComponent = SongRectTransform.GetComponent<TextMeshProUGUI>();

        if (textComponent != null)
            textComponent.text = $"Current Song: {clipName}\nSource: {sourceName}";
    }

    public static void AudioPlayPatch(AudioSource __instance)
    {
        if (Core.Instance.ConfigDefaultAudio.Value)
            return;

        if (__instance.clip == null)
            return;

        if (RhythmGameManager.Instance != null && __instance.clip.name == "loon")
            return;

        if (ModFeatures.IsAudioTesting)
            Log.LogInfo($"Playing \"{__instance.clip.name}\" from object \"{__instance.gameObject.name}\"");

        var audioClipName = s_overrideEnabled ? "REPLACE_ALL" : __instance.clip.name;

        if (AudioClips.TryGetValue(audioClipName, out var replaceClip))
        {
            __instance.pitch = 1;
            __instance.clip = replaceClip;
        }

        if (!ModFeatures.IsAudioTesting)
            return;

        // Update the displayed audio source
        var (name, source) = GetAudioSource(__instance.clip.name);
        UpdateAudioSourceText(name, source);
    }
}
