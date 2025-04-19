using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using Newtonsoft.Json;
using PvZ_Fusion_Translator.AssetStore;
using static PvZ_Fusion_Translator.FileLoader;
using static PvZ_Fusion_Translator.Patches.Managers.AlmanacPlantBank_Patch;

namespace PvZ_Fusion_Translator.Patches.OtherManagers
{
	[HarmonyPatch(typeof(AchievementClip))]
	public static class AchievementClip_Patch
	{
		[HarmonyPatch(nameof(AchievementClip.Start))]
		[HarmonyPostfix]
		private static void Start(AchievementClip __instance)
		{
			#if MULTI_LANGUAGE
			string currentLanguage = Utils.Language.ToString();
			string achievementDir = GetAssetDir(AssetType.Almanac, Utils.Language);
			TMP_FontAsset fontAsset = FontStore.LoadTMPFont(currentLanguage);
			#else
			string achievementDir = GetAssetDir(AssetType.Almanac);
			TMP_FontAsset fontAsset = FontStore.LoadTMPFont();
			#endif
			string path = Path.Combine(achievementDir, "AchievementsTextTranslate.json");

			#if OBFUSCATE
			if (CheckSumStore.IsModified(path))
			{
				Log.LogError("File {0} was modified!", path);
				return;
			}
			#endif

			if (!File.Exists(path)) return;

			string json;
			json = File.ReadAllText(path);
			Dictionary<Achievement, AchievementObject> achievementsTexts = new Dictionary<Achievement, AchievementObject>();
			achievementsTexts = JsonConvert.DeserializeObject<Dictionary<Achievement, AchievementObject>>(json);

			TextMeshProUGUI text1 = __instance.introduce.transform.GetChild(1).GetComponent<TextMeshProUGUI>();
			TextMeshProUGUI text2 = __instance.introduce.transform.GetChild(2).GetComponent<TextMeshProUGUI>();
			TextMeshProUGUI name1 = __instance.image.transform.GetChild(0).GetComponent<TextMeshProUGUI>();


			text1.text = achievementsTexts[__instance._index].Name;
			text1.font = fontAsset;
			text2.text = achievementsTexts[__instance._index].Name;
			text2.font = fontAsset;
			name1.text = achievementsTexts[__instance._index].Text;
			name1.font = fontAsset;
		}
	}

	public class AchievementObject
	{
		public Achievement achievement { get; set; }
		public string Name { get; set; }
		public string Text { get; set; }

		public AchievementObject(Achievement achievement = Achievement.Welcome, string name = "", string text = "")
		{
			this.achievement = achievement;
			Name = name;
			Text = text;
		}
	}
}
