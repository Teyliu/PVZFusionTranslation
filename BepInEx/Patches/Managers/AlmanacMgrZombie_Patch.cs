using HarmonyLib;
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;
using static PvZ_Fusion_Translator__BepInEx_.FileLoader;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.Managers
{
	[HarmonyPatch(typeof(AlmanacMgrZombie))]
	public static partial class AlmanacMgrZombie_Patch
	{
		[HarmonyPatch(nameof(AlmanacMgrZombie.InitNameAndInfoFromJson))]
		[HarmonyPostfix]
		private static void InitNameAndInfoFromJson(AlmanacMgrZombie __instance)
		{
			#if MULTI_LANGUAGE
			string currentLanguage = Utils.Language.ToString();
			string almanacDir = GetAssetDir(AssetType.Almanac, Utils.Language);
			#else
			string almanacDir = almanacDir = GetAssetDir(AssetType.Almanac);
			string currentLanguage = "English";
			#endif
			string path = Path.Combine(almanacDir, "ZombieStringsTranslate.json");
			string moddedPath = Path.Combine(almanacDir, "ModdedZombiesTranslate.json");

			if (!File.Exists(path))
			{
				Log.LogError($"ZombieStringsTranslate.json file not found at path: {path}");
				return;
			}

			#if OBFUSCATE
			if (CheckSumStore.IsModified(path))
			{
				Log.LogError("File {0} was modified!", path);
				return;
			}
			#endif

			string json;
			json = File.ReadAllText(path);

			bool hasAlmanacFont = false;
			TMP_FontAsset almanacFontAsset = null;
			if (FontStore.fontAssetDictSecondary.ContainsKey(currentLanguage + "_Almanac") || FontStore.fontAssetDictSecondary.ContainsKey(currentLanguage))
			{
				almanacFontAsset = FontStore.LoadTMPFontAlmanac(currentLanguage);
				hasAlmanacFont = true;
			}

			#if MULTI_LANGUAGE
			TMP_FontAsset fontAsset = FontStore.LoadTMPFont(currentLanguage);
			#else
			TMP_FontAsset fontAsset = FontStore.LoadTMPFont();
			#endif

			TextMeshPro component = __instance.info.GetComponent<TextMeshPro>();
			TextMeshPro component2 = __instance.zombieName.GetComponent<TextMeshPro>();
			TextMeshPro component3 = __instance.zombieName.transform.GetChild(0).GetComponent<TextMeshPro>();

			AlmanacMgrZombie.ZombieAlmanacData zombieData = JsonUtility.FromJson<AlmanacMgrZombie.ZombieAlmanacData>(json);

			foreach (AlmanacMgrZombie.ZombieInfo zombieInfo in zombieData.zombies)
			{
				if (zombieInfo.theZombieType == __instance.theZombieType)
				{
					component.text = zombieInfo.info + "\n\n" + zombieInfo.introduce;
					component.overflowMode = TextOverflowModes.Page;
					component2.text = zombieInfo.name;
					component2.autoSizeTextContainer = true;
					component3.text = Utils.RemoveColorTags(zombieInfo.name);
					component3.autoSizeTextContainer = true;

					if (hasAlmanacFont)
						component.font = almanacFontAsset;
					else
						component.font = fontAsset;
					component2.font = fontAsset;
					component3.font = fontAsset;
				}
			}

			if (File.Exists(moddedPath))
			{
				string moddedJson;
				moddedJson = File.ReadAllText(moddedPath);

				AlmanacMgrZombie.ZombieAlmanacData moddedZombieData = JsonUtility.FromJson<AlmanacMgrZombie.ZombieAlmanacData>(moddedJson);

				foreach (AlmanacMgrZombie.ZombieInfo zombieInfo in moddedZombieData.zombies)
				{
					if (zombieInfo.theZombieType == __instance.theZombieType)
					{
						component.text = zombieInfo.info + "\n\n" + zombieInfo.introduce;
						component.overflowMode = TextOverflowModes.Page;
						component2.text = zombieInfo.name;
						component2.autoSizeTextContainer = true;
						component3.text = Utils.RemoveColorTags(zombieInfo.name);
						component3.autoSizeTextContainer = true;

						if (hasAlmanacFont)
							component.font = almanacFontAsset;
						else
							component.font = fontAsset;
						component2.font = fontAsset;
						component3.font = fontAsset;
					}
				}
			}
			DumpAlmanacModdedZombies(__instance);
            return;
		}

		[HarmonyPatch(nameof(AlmanacMgrZombie.OnMouseDown))]
		[HarmonyPrefix]
		private static bool OnMouseDown(AlmanacMgrZombie __instance)
		{
            TextMeshPro component = __instance.info.GetComponent<TextMeshPro>();
			if (component != null)
			{
				component.pageToDisplay = component.pageToDisplay > component.m_pageNumber ? 1 : component.pageToDisplay + 1;
				return false;
			}
			return true;
		}
	}


	[HarmonyPatch(typeof(AlmanacMgrZombie))]
	public static partial class AlmanacMgrZombie_Patch
	{
		[HarmonyPatch(nameof(AlmanacMgrZombie.OnMouseDown))]
		[HarmonyPostfix]
		public static void DumpAlmanacModdedZombies(AlmanacMgrZombie __instance)
		{
			// Dump the texts if needed using Ctrl key
			if (Input.GetKey(KeyCode.LeftControl))
			{
				FileLoader.DumpUntranslatedStrings(__instance.info.GetComponent<TextMeshPro>().text);
				Log.LogInfo($"Info: {__instance.info.GetComponent<TextMeshPro>().text}");
				FileLoader.DumpUntranslatedStrings(__instance.zombieName.GetComponent<TextMeshPro>().text);
				Log.LogInfo($"Zombie Name: {__instance.zombieName.GetComponent<TextMeshPro>().text}");
			}
		}
	}

    // Patch to translate the modded almanac zombie names and info
    [HarmonyPatch(typeof(AlmanacMgrZombie))]
    public static partial class AlmanacMgrZombie_Patch
    {
        [HarmonyPatch(nameof(AlmanacMgrZombie.Start))]
        [HarmonyPostfix]
        public static void TranslateTextAlmanac(AlmanacMgrZombie __instance)
        {
            string currentLanguage = Utils.Language.ToString();
            __instance.introduce.text = StringStore.TranslateText(__instance.introduce.text);
			__instance.introduce.font = FontStore.LoadTMPFont(currentLanguage);

			DumpAlmanacModdedZombies(__instance);
            // translate all TMP components in info
            foreach (TextMeshPro text in __instance.info.GetComponentsInChildren<TextMeshPro>())
            {
                if (text != null)
                {
                    text.text = StringStore.TranslateText(text.text);
					text.name = StringStore.TranslateText(text.name);
                    text.font = FontStore.LoadTMPFont(currentLanguage);
                }
            }
			foreach (TextMeshPro text in __instance.zombieName.GetComponentsInChildren<TextMeshPro>())
			{
				if (text != null)
				{
					text.text = StringStore.TranslateText(text.text);
					text.name = StringStore.TranslateText(text.name);
					text.font = FontStore.LoadTMPFont(currentLanguage);
                }
			}

            // Translate zombieName and its child
            __instance.zombieName.name = StringStore.TranslateText(__instance.zombieName.name);
            __instance.zombieName.GetComponent<TextMeshPro>().font = FontStore.LoadTMPFont(currentLanguage);
			__instance.zombieName.transform.GetChild(0).name = StringStore.TranslateText(__instance.zombieName.transform.GetChild(0).name);
            // Get both for less testing
            __instance.zombieName.GetComponent<TextMeshPro>().text = StringStore.TranslateText(__instance.zombieName.GetComponent<TextMeshPro>().text);
            __instance.zombieName.transform.GetChild(0).GetComponent<TextMeshPro>().text = StringStore.TranslateText(__instance.zombieName.transform.GetChild(0).GetComponent<TextMeshPro>().text);
            __instance.zombieName.transform.GetChild(0).GetComponent<TextMeshPro>().font = FontStore.LoadTMPFont(currentLanguage);
        }
    }
}
