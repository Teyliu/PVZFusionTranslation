using Harmony;
using Il2Cpp;
using Il2CppTMPro;
using MelonLoader;
using MelonLoader.TinyJSON;
using PvZ_Fusion_Translator.AssetStore;
using PvZ_Fusion_Translator.Patches.GameObjects.MinorObjects;
using System.Diagnostics;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.UI;
using static Il2Cpp.AlmanacPlantBank;
using static MelonLoader.MelonLogger;
using static PvZ_Fusion_Translator.FileLoader;

namespace PvZ_Fusion_Translator
{
	public class Utils
	{
		internal static bool TryReplaceTexture2D(Texture2D ogTexture)
		{
			if (ogTexture != null)
			{
				if (TextureStore.textureDict.TryGetValue(ogTexture.name, out string texturePath))
				{
					try
					{
						ImageConversion.LoadImage(ogTexture, File.ReadAllBytes(texturePath));

						Log.LogDebug("OK! Replaced Texture " + ogTexture.name);

						ogTexture.name = "replaced_" + ogTexture.name;
						return true;
					}
					catch (Exception ex)
					{
						Log.LogError("Failed to replace texture: " + ogTexture.name + " at path: " + texturePath);
						Log.LogError(ex.ToString());
					}
				}
			}
			return false;
		}

		internal static Texture2D LoadImage(string path)
		{
			if (!File.Exists(path))
			{
				throw new FileNotFoundException($"The image file at path '{path}' does not exist.");
			}

			byte[] array = File.ReadAllBytes(path);
			Texture2D texture2D = new(2, 2, GraphicsFormat.R8G8B8A8_UNorm, TextureCreationFlags.None, 1, IntPtr.Zero, null);
			ImageConversion.LoadImage(texture2D, array);
			return texture2D;
		}

		public static Color HexToColor(string hex)
		{

			hex = hex.Replace("#", "");

			float r = int.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber) / 255f;
			float g = int.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber) / 255f;
			float b = int.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber) / 255f;

			return new Color(r, g, b);
		}

		public static void OpenSaveDirectory()
		{
			string saveDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "AppData", "LocalLow", "LanPiaoPiao", "PlantsVsZombiesRH");
			Process.Start("explorer.exe", saveDirectory);
		}

		public static void OpenTrello()
		{
			string website = "https://trello.com/b/DcdT1kUp";
			Process.Start(new ProcessStartInfo(website) { UseShellExecute = true });
		}

		 public static string RemoveColorTags(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text ?? string.Empty;

            // Remove opening color tags like <color=#FF0000>
            string withoutOpenTags = Regex.Replace(text, @"<color=[^>]+>", string.Empty, RegexOptions.IgnoreCase);
            // Remove closing color tags like </color>
            string withoutCloseTags = Regex.Replace(withoutOpenTags, @"</color>", string.Empty, RegexOptions.IgnoreCase);
            return withoutCloseTags;
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

        public static void ConvertButtonText(Transform original, string name)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            Transform transform = original.FindChild(name);
            Transform textTransform = transform.FindChild("text");
            string text = textTransform.GetComponent<Text>().text;
            Color color = textTransform.GetComponent<Text>().color;

            TextMeshProUGUI newGoBackText = Utils.ConvertToTextMeshProUGUI(textTransform.gameObject, transform, "text2").GetComponent<TextMeshProUGUI>();
            newGoBackText.autoSizeTextContainer = true;
            newGoBackText.text = StringStore.TranslateText(text, false);
            newGoBackText.font = fontAsset;
            newGoBackText.color = color;
        }

		public static string GetPlantNameFromAlmanac(PlantType thePlantType)
		{
            string json;
            string thePlantName = "";

            string currentLanguage = Utils.Language.ToString();
            string almanacDir = GetAssetDir(AssetType.Almanac, Utils.Language);
            string path = Path.Combine(almanacDir, "LawnStringsTranslate.json");

            if (!File.Exists(path))
            {
                Log.LogError($"LawnStringsTranslate.json file not found at path: {path}");
                Log.LogError("Plant name could not be found!");
                thePlantName = "";
            }
            else
            {
                json = File.ReadAllText(path);
                AlmanacPlantBank.PlantData plantData = JsonUtility.FromJson<AlmanacPlantBank.PlantData>(json);

                foreach (AlmanacPlantBank.PlantInfo plantInfo in plantData.plants)
                {
                    if (plantInfo.seedType == (int)thePlantType)
                    {
                        thePlantName = plantInfo.name;
                    }
                }
            }

			return thePlantName;
        }

        public static string GetPlantNameFromAlmanac(string theOriginalPlantName)
		{
			string originalJson;
            string translatedJson;
            string thePlantName = "";

            string currentLanguage = Utils.Language.ToString();
            string almanacDir = GetAssetDir(AssetType.Almanac, Utils.Language);
			string dumpDir = GetAssetDir(AssetType.Dumps);
			string originalPath = Path.Combine(dumpDir, "LawnStrings.json");
            string path = Path.Combine(almanacDir, "LawnStringsTranslate.json");

            if ((!File.Exists(path)) || (!File.Exists(originalPath)))
            {
                Log.LogError($"LawnStringsTranslate.json file not found at path: {path}");
                Log.LogError("Plant name could not be found!");
                thePlantName = "";
            }
            else
            {
				bool foundPlantName = false;

				originalJson = File.ReadAllText(originalPath);
                translatedJson = File.ReadAllText(path);
                AlmanacPlantBank.PlantData originalPlantData = JsonUtility.FromJson<AlmanacPlantBank.PlantData>(originalJson);
                AlmanacPlantBank.PlantData translatedPlantData = JsonUtility.FromJson<AlmanacPlantBank.PlantData>(translatedJson);

				for(int i = 0; i < originalPlantData.plants.Count; i++)
				{
					AlmanacPlantBank.PlantInfo originalPlantInfo = originalPlantData.plants[i];
					KeyValuePair<int, string> translatedPlantInfo = plantIndices[originalPlantInfo.seedType];

                    if (originalPlantInfo.name == theOriginalPlantName)
                    {
                        thePlantName = translatedPlantInfo.Value;
						foundPlantName = true;
                    }
                }

                if (!foundPlantName)
                {
                    Log.LogInfo("Couldn't find plant name!");
                    thePlantName = "";
                }
            }

            return thePlantName;
        }

		public static Dictionary<int, KeyValuePair<int, string>> plantIndices = new Dictionary<int, KeyValuePair<int, string>>();

		public static void RegisterPlantIndices()
		{
			plantIndices = new Dictionary<int, KeyValuePair<int, string>>();
            string originalJson;
            string translatedJson;

            string currentLanguage = Utils.Language.ToString();
            string almanacDir = GetAssetDir(AssetType.Almanac, Utils.Language);
            string dumpDir = GetAssetDir(AssetType.Dumps);
            string originalPath = Path.Combine(dumpDir, "LawnStrings.json");
            string path = Path.Combine(almanacDir, "LawnStringsTranslate.json");

            if ((!File.Exists(path)) || (!File.Exists(originalPath)))
            {
                Log.LogError($"LawnStringsTranslate.json file not found at path: {path}");
            }
            else
            {
                originalJson = File.ReadAllText(originalPath);
                translatedJson = File.ReadAllText(path);
                AlmanacPlantBank.PlantData originalPlantData = JsonUtility.FromJson<AlmanacPlantBank.PlantData>(originalJson);
                AlmanacPlantBank.PlantData translatedPlantData = JsonUtility.FromJson<AlmanacPlantBank.PlantData>(translatedJson);

                for(int i = 0; i < originalPlantData.plants.Count; i++)
				{
					PlantInfo originalPlantInfo = originalPlantData.plants[i];
					PlantInfo translatedPlantInfo = null;

                    foreach (PlantInfo info in translatedPlantData.plants)
					{
						if(info.seedType == originalPlantInfo.seedType)
						{
							translatedPlantInfo = info;
						}
					}

					if(translatedPlantInfo != null)
					{
                        KeyValuePair<int, string> temp = new KeyValuePair<int, string>(translatedPlantInfo.seedType, translatedPlantInfo.name);
						plantIndices.Add(originalPlantInfo.seedType, temp);
                    }
                }
            }
		}

#if MULTI_LANGUAGE
        internal static void ChangeLanguage(string language)
		{
			OldLanguage = Language;

			if (Enum.TryParse(language, out Utils.LanguageEnum lang))
			{
				Utils.Language = lang;
			}
			else
			{
				// Handle invalid language string
				Log.LogError($"Invalid language string: {language}");
			}
			
			WarningStore.isWarningMessageLoaded = false;
			FontStore.Reload();
			StringStore.Reload();
			TextureStore.Reload();
			FileLoader.SaveLanguage();
			RegisterPlantIndices();
			Zombie_Patch.LoadHPStrings();
        }
		#endif

		#if MULTI_LANGUAGE
		public static Utils.LanguageEnum OldLanguage;
		#endif

		public static Utils.LanguageEnum Language;

		public static bool customTextures = !MelonPreferences.GetEntryValue<bool>("PvZ_Fusion_Translator", "DefaultTextures");
		public static bool customAudio = !MelonPreferences.GetEntryValue<bool>("PvZ_Fusion_Translator", "DefaultAudio");

        public enum LanguageEnum
		{
			// first column
			English,
			French,
			Italian,
			German,
			Spanish,
			Portuguese,

			// second column
			Javanese, //Filipino,
			Vietnamese,
			Indonesian,
			Russian,
			Japanese,
			Korean,

			// third column
			// Ukrainian,
			// Slovak,
			Polish,
			Hungarian,
			Arabic,

			LANG_END
		}

		public enum ToggleEnum
		{
			Textures,
			Audio,
			TOGGLE_END
		}
	}
}