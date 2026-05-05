using Harmony;
using Il2Cpp;
using Il2CppTMPro;
using MelonLoader;
using MelonLoader.TinyJSON;
using Newtonsoft.Json;
using PvZ_Fusion_Translator.AssetStore;
using PvZ_Fusion_Translator.Patches.GameObjects;
using PvZ_Fusion_Translator.Patches.GameObjects.ButtonObjects;
using PvZ_Fusion_Translator.Patches.GameObjects.MinorObjects;
using PvZ_Fusion_Translator.Patches.Modes.Super_Editor;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Unity.Burst.Intrinsics;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.Rendering;
using UnityEngine.UI;
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
				if (TextureStore.textureDict.TryGetValue(ogTexture.name, out byte[] textureData))
				{
					try
					{
						ImageConversion.LoadImage(ogTexture, textureData);

                        Log.LogDebug("OK! Replaced Texture " + ogTexture.name);

						ogTexture.name = "replaced_" + ogTexture.name;
						return true;
					}
					catch (Exception ex)
					{
						Log.LogError("Failed to replace texture: " + ogTexture.name);
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

		internal static Texture2D LoadImage(byte[] bytes)
		{
			if (bytes == null)
			{
				throw new FileNotFoundException($"Byte array was null.");
			}

			byte[] array = bytes;
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

		public static void OpenOnlineAlmanac()
		{
			string website = "https://carroti4ch.itch.io/almanac";
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

        public static string RemoveSizeTags(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text ?? string.Empty;

            // Remove opening color tags like <color=#FF0000>
            string withoutOpenTags = Regex.Replace(text, @"<size=[^>]+>", string.Empty, RegexOptions.IgnoreCase);
            // Remove closing color tags like </color>
            string withoutCloseTags = Regex.Replace(withoutOpenTags, @"</size>", string.Empty, RegexOptions.IgnoreCase);
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

		public static string GetPlantNameFromAlmanac(PlantType thePlantType, bool log = false)
		{
            bool foundPlantName = false;
			string thePlantName = "";

			if(plantIndices.ContainsKey((int)thePlantType))
			{
				foundPlantName = true;
				thePlantName = plantIndices[(int)thePlantType].Value;
			}

            if (!foundPlantName)
            {
				if(log)
				{
					Log.LogInfo("Couldn't find plant name!");
				}
                thePlantName = "";
            }

            return thePlantName;
        }

        public static string GetPlantNameFromAlmanac(string theOriginalPlantName, bool log = false)
		{
			bool foundPlantName = false;
			string thePlantName = "";

			if(plantIndiceStrings.ContainsKey(theOriginalPlantName))
			{
				foundPlantName = true;
				thePlantName = plantIndiceStrings[theOriginalPlantName];
			}

            if (!foundPlantName)
            {
				if(log)
				{
					Log.LogInfo("Couldn't find plant name!");
				}
                thePlantName = "";
            }

            return thePlantName;
        }

		public static string GetZombieNameFromAlmanac(ZombieType theZombieType)
		{
			string json;
			string theZombieName = "";

			string currentLanguage = Utils.Language.ToString();

			json = AlmanacZombieMenu_Patch.almanacJson;
            Il2CppAlmanacData.AlmanacData zombieData = JsonUtility.FromJson<Il2CppAlmanacData.AlmanacData>(json);

			foreach (Il2CppAlmanacData.ZombieInfo zombieInfo in zombieData.zombies)
			{
				if ((int)zombieInfo.theZombieType == (int)theZombieType)
				{
					theZombieName = zombieInfo.name;
				}
			}

			return theZombieName;
		}

		public static Dictionary<int, KeyValuePair<int, string>> plantIndices = new Dictionary<int, KeyValuePair<int, string>>();
		public static Dictionary<string, string> plantIndiceStrings = new Dictionary<string, string>();

		public static void RegisterPlantIndices()
		{
			plantIndices = new Dictionary<int, KeyValuePair<int, string>>();
			plantIndiceStrings = new Dictionary<string, string>();
            string originalJson;
            string translatedJson;

            string currentLanguage = Utils.Language.ToString();
            string almanacDir = GetAssetDir(AssetType.Almanac, Utils.Language);
            string dumpDir = GetAssetDir(AssetType.Dumps);
            string originalPath = Path.Combine(dumpDir, "LawnStrings.json");
            string path = Path.Combine(almanacDir, "LawnStringsTranslate.json");

            if ((!File.Exists(originalPath)))
			{
                Log.LogError($"LawnStrings.json file not found at path: {originalPath}");
            }
            else
			{
				originalJson = File.ReadAllText(originalPath);
				translatedJson = AlmanacPlantMenu_Patch.almanacJson;
				Il2CppAlmanacData.AlmanacData originalPlantData = JsonUtility.FromJson<Il2CppAlmanacData.AlmanacData>(originalJson);
				Il2CppAlmanacData.AlmanacData translatedPlantData = JsonUtility.FromJson<Il2CppAlmanacData.AlmanacData>(translatedJson);

				for (int i = 0; i < originalPlantData.plants.Count; i++)
				{
					Il2CppAlmanacData.PlantInfo originalPlantInfo = originalPlantData.plants[i];
					if(!plantIndiceStrings.ContainsKey(originalPlantInfo.name))
					{
						plantIndiceStrings.Add(originalPlantInfo.name, originalPlantInfo.name);
					}
					Il2CppAlmanacData.PlantInfo translatedPlantInfo = null;

					foreach (Il2CppAlmanacData.PlantInfo info in translatedPlantData.plants)
					{
						if (info.seedType == originalPlantInfo.seedType)
						{
							translatedPlantInfo = info;
						}
					}

					if (translatedPlantInfo != null)
					{
						KeyValuePair<int, string> temp = new KeyValuePair<int, string>(translatedPlantInfo.seedType, translatedPlantInfo.name);
						plantIndices.Add(originalPlantInfo.seedType, temp);
						plantIndiceStrings[originalPlantInfo.name] = translatedPlantInfo.name;
					}
				}
			}
		}

		/*public static Dictionary<int, List<int>> recipeLinks = new Dictionary<int, List<int>>();

		public static void RegisterRecipeLinks()
		{
			recipeLinks.Clear();

			Il2CppSystem.Array mixData = MixData.data.Cast<Il2CppSystem.Array>();
			int rows = mixData.GetLength(0);
			int columns = mixData.GetLength(1);

			foreach (PlantType plantType in Enum.GetValues(typeof(PlantType)))
			{
				int seedType = (int)plantType;

				recipeLinks.Add(seedType, new());

				if (seedType > 0)
				{
					foreach (PlantType checkType in Enum.GetValues(typeof(PlantType)))
					{
						if (checkType > 0)
						{
							int[] checks = [mixData.GetValue(seedType, (int)checkType).Unbox<int>(), mixData.GetValue((int)checkType, seedType).Unbox<int>()];

							if (checks[0] != 0)
							{
								recipeLinks[seedType].Add(checks[0]);
							}

							if (checks[1] != 0)
							{
								recipeLinks[seedType].Add(checks[1]);
							}
						}
					}
				}
				if (recipeLinks[seedType].Count > 0)
				{
					Log.LogDebug($"Found {recipeLinks[seedType].Count} fusions for {seedType}!");
				}
			}
		}*/

		public static bool CheckForUntranslatedText(string text)
		{
            Regex regex = new("\\p{IsCJKUnifiedIdeographs}+");
			try 
			{
				Match match = regex.Match(text);
				return match.Success;
			} 
			catch(Exception e) 
			{
				Log.LogError(e);
			}
			return false;
        }
		
		public static bool useLocal = MelonPreferences.GetEntryValue<bool>("PvZ_Fusion_Translator", "UseLocal");
		
		public static void WarnLocalData()
		{
			BaseMenu newMenu = GameAPP.UIManager.Push(UIType.ConfirmMenu, GameAPP.canvasUp);
			ConfirmMenu confirmMenu = newMenu.gameObject.GetComponent<ConfirmMenu>();

			string modeTo = (Utils.useLocal) ? "online mode" : "local mode";
			confirmMenu.SetTitle($"<size=40%>WARNING: This button is meant for translator testing and can overwrite/interfere with the translation files saved in your installation. Proceed with caution. <color=red>You are switching to {modeTo}.</color>\nOnline Mode: Default, strings will auto-sync with the latest version when opening the game\nLocal Mode: Strings are only loaded from your installaion and do not update (meant for translators)");
			confirmMenu.transform.Find("window/text").GetComponent<TextMeshProUGUI>().text = Utils.RemoveColorTags(confirmMenu.transform.Find("window/text").GetComponent<TextMeshProUGUI>().text);
			UIButton confirmButton = confirmMenu.transform.Find("Image").GetComponent<UIButton>();
			UIButton cancelButton = confirmMenu.transform.Find("Image2").GetComponent<UIButton>();

			confirmButton.clickEvent = new UnityEvent();
			confirmButton.clickEvent.AddListener(new Action(() => SwapLocalData()));
			confirmButton.clickEvent.AddListener(new Action(() => GameAPP.UIManager.Pop()));
		}

		public static void SwapLocalData()
        {
            Utils.useLocal = (Utils.useLocal) ? false : true;
            MelonPreferences.SetEntryValue<bool>("PvZ_Fusion_Translator", "UseLocal", Utils.useLocal);
			ChangeLanguage(Utils.Language.ToString());
			string sourceMsg = "<size=10>" + (!(Utils.useLocal) ? "Translation Source:\nOnline" : "Translation Source:\nLocal");
			OptLanguageBtn_Patch.FlashMessage(OptLanguageBtn_Patch.toggleSlots[2], sourceMsg, 0.1f, false);
        }

		public static async Task<string> GetDataFromWeb(string url, bool isLog = true)
		{
			if (isLog)
			{
				Log.LogInfo($"Attempting to read {url}");
			}
			HttpClient client = new HttpClient();
			try
			{
				var dataRequest = await client.GetAsync(url);
				if(dataRequest.StatusCode == System.Net.HttpStatusCode.OK)
				{
					if (isLog)
					{
						Log.LogInfo($"Successfully loaded data from {url}!");
					}
				
					string content = await dataRequest.Content.ReadAsStringAsync();
					return content;
				}
				else
				{
					if (isLog)
					{
						Log.LogError($"Failed to load data from {url}! Falling back...");
						Log.LogError($"Status code: {dataRequest.StatusCode}");
					}
					new CancellationTokenSource().Cancel();
					return null;
				}
			}
			catch(Exception ex)
			{
				Log.LogError($"Failed to load data from {url}! Falling back...");
				Log.LogError(ex);
				new CancellationTokenSource().Cancel();
				return null;
			}
		}

		public static async Task<byte[]> GetByteDataFromWeb(string url, bool isLog = true)
		{
			if (isLog)
			{
				Log.LogInfo($"Attempting to read {url}");
			}
			HttpClient client = new HttpClient();
			try
			{
				var dataRequest = await client.GetAsync(url);
				if (dataRequest.StatusCode == System.Net.HttpStatusCode.OK)
				{
					if (isLog)
					{
						Log.LogInfo($"Successfully loaded data from {url}!");
					}

					byte[] content = await dataRequest.Content.ReadAsByteArrayAsync();
					return content;
				}
				else
				{
					if (isLog)
					{
						Log.LogError($"Failed to load data from {url}! Falling back...");
						Log.LogError($"Status code: {dataRequest.StatusCode}");
					}
					new CancellationTokenSource().Cancel();
					return null;
				} 
			}
			catch(Exception ex)
			{
				Log.LogError($"Failed to load data from {url}! Falling back...");
				Log.LogError(ex);
				new CancellationTokenSource().Cancel();
				return null;
			}
		}

		public static async Task<string> GetDataFromWebWithInput(string url, bool isLog = true)
		{
			if (isLog)
			{
				Log.LogInfo($"Attempting to read {url}");
			}
			HttpClient client = new HttpClient();

			using var request = new HttpRequestMessage()
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri(url)
			};
			request.Headers.Add("Accept", "*/*");
			request.Headers.Add("Accept-Encoding", "gzip, deflate, br");
			request.Headers.Add("User-Agent", "TranslatorMod");


			var dataRequest = await client.SendAsync(request);
            if(dataRequest.StatusCode == System.Net.HttpStatusCode.OK)
            {
				if (isLog)
				{
					Log.LogInfo($"Successfully loaded data from {url}!");
				}
				
                string content = await dataRequest.Content.ReadAsStringAsync();
                return content;
            }
            else
            {
				if (isLog)
				{
					Log.LogError($"Failed to load data from {url}! Falling back...");
					Log.LogError($"Status code: {dataRequest.StatusCode}");
				}
                new CancellationTokenSource().Cancel();
                return null;
            }
		}

		public static int CalculateGameVersion(string gameVersion)
		{
			int res = 0;
			string[] gameVersionParts = gameVersion.Split('.');

			int startingPower = (int)Math.Max(gameVersionParts.Length, 3);
			for (int i = 0; i < startingPower; i++)
			{
				int factor = 0;
				if (i < gameVersionParts.Length)
				{
					factor = int.Parse(gameVersionParts[i]);
				}
				int power = startingPower - i;
				res += factor * (int)Math.Pow(10, power - 1);
			}

			return res;
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
			
			//WarningStore.isWarningMessageLoaded = false;
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
			Chinese_cn,
			French,
			//Italian,
			German,
			Spanish,
			

			// second column
			//Portuguese,
			//Javanese, 
			//Filipino,
			Vietnamese,
			//Indonesian,
			//Russian, //NOTE: legacy language
			Japanese,
			

			// third column
			Korean,
			Ukrainian,
			// Slovak,
			//Polish,
			//Turkish,
            //Arabic,
            Romanian,

            LANG_END
		}

		public static Dictionary<LanguageEnum, string> LanguageNames = new Dictionary<LanguageEnum, string>()
		{
			{ LanguageEnum.English, "English"},
			{ LanguageEnum.Chinese_cn, "简体中文"},
			{ LanguageEnum.French, "Français"},
			{ LanguageEnum.German, "Deutsch"},
			{ LanguageEnum.Spanish, "Español"},
			{ LanguageEnum.Vietnamese, "Tiếng Việt"},
			{ LanguageEnum.Japanese, "日本語"},
			{ LanguageEnum.Korean, "한국어"},
			{ LanguageEnum.Ukrainian, "українська"},
			{ LanguageEnum.Romanian, "Română"}
		};

		public static Dictionary<ToggleEnum, string> ToggleNames = new Dictionary<ToggleEnum, string>()
		{
			{ ToggleEnum.Textures, "<size=85%>Change Texture\nSource"},
			{ ToggleEnum.Audio, "<size=85%>Change Audio\nSource"},
			{ ToggleEnum.SwapLocal, "<size=85%>Change Translation\nSource"}
		};

		public enum ToggleEnum
		{
			Textures,
			Audio,
			SwapLocal,
			TOGGLE_END
		}
	}
}