using HarmonyLib;
using System;
using System.Collections.Generic;
using System.IO;
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
			if (FontStore.fontAssetDictSecondary != null && 
			    (FontStore.fontAssetDictSecondary.ContainsKey(currentLanguage + "_Almanac") || FontStore.fontAssetDictSecondary.ContainsKey(currentLanguage)))
			{
				almanacFontAsset = FontStore.LoadTMPFontAlmanac(currentLanguage);
				hasAlmanacFont = true;
			}

#if MULTI_LANGUAGE
			TMP_FontAsset fontAsset = FontStore.LoadTMPFont(currentLanguage);
#else
			TMP_FontAsset fontAsset = FontStore.LoadTMPFont();
#endif

			if (__instance.info == null || __instance.zombieName == null)
			{
				Log.LogError("[AlmanacMgrZombie_Patch] Required components are null");
				return;
			}

			TextMeshPro component = __instance.info.GetComponent<TextMeshPro>();
			TextMeshPro component2 = __instance.zombieName.GetComponent<TextMeshPro>();
			TextMeshPro component3 = null;
			Transform zombieNameChild = __instance.zombieName.transform.GetChild(0);
			if (zombieNameChild != null)
			{
				component3 = zombieNameChild.GetComponent<TextMeshPro>();
			}

			if (component == null || component2 == null)
			{
				Log.LogError("[AlmanacMgrZombie_Patch] TextMeshPro components are null");
				return;
			}

			ZombieAlmanacData zombieData = JsonUtility.FromJson<ZombieAlmanacData>(json);

			if (zombieData?.zombies == null)
			{
				Log.LogError("[AlmanacMgrZombie_Patch] Zombie data is null");
				return;
			}

			foreach (ZombieInfo zombieInfo in zombieData.zombies)
			{
				if (zombieInfo.theZombieType == __instance.theZombieType)
				{
					component.text = zombieInfo.info + "\n\n" + zombieInfo.introduce;
					component.overflowMode = TextOverflowModes.Page;
					component2.text = zombieInfo.name;
					component2.autoSizeTextContainer = true;
					
					if (component3 != null)
					{
						component3.text = Utils.RemoveColorTags(zombieInfo.name);
						component3.autoSizeTextContainer = true;
					}

					if (hasAlmanacFont)
						component.font = almanacFontAsset;
					else
						component.font = fontAsset;
					component2.font = fontAsset;
					if (component3 != null)
					{
						component3.font = fontAsset;
					}
				}
			}

		if (File.Exists(moddedPath))
			{
				string moddedJson;
				moddedJson = File.ReadAllText(moddedPath);

				ZombieAlmanacData moddedZombieData = JsonUtility.FromJson<ZombieAlmanacData>(moddedJson);

				if (moddedZombieData?.zombies != null)
				{
					foreach (ZombieInfo zombieInfo in moddedZombieData.zombies)
					{
						if (zombieInfo.theZombieType == __instance.theZombieType)
						{
							component.text = zombieInfo.info + "\n\n" + zombieInfo.introduce;
							component.overflowMode = TextOverflowModes.Page;
							component2.text = zombieInfo.name;
							component2.autoSizeTextContainer = true;
							
							if (component3 != null)
							{
								component3.text = Utils.RemoveColorTags(zombieInfo.name);
								component3.autoSizeTextContainer = true;
							}

							if (hasAlmanacFont)
								component.font = almanacFontAsset;
							else
								component.font = fontAsset;
							component2.font = fontAsset;
							if (component3 != null)
							{
								component3.font = fontAsset;
							}
						}
					}
				}
			}

			return;
		}

		[HarmonyPatch(nameof(AlmanacMgrZombie.OnMouseDown))]
		[HarmonyPrefix]
		private static bool OnMouseDown(AlmanacMgrZombie __instance)
		{
			if (__instance.info != null)
			{
				TextMeshPro component = __instance.info.GetComponent<TextMeshPro>();
				if (component != null)
				{
					component.pageToDisplay = component.pageToDisplay > component.m_pageNumber ?1 : component.pageToDisplay + 1;
					return false;
				}
			}
			return true;
		}
	}

    [Serializable]
    public class ZombieAlmanacData
    {
        public List<ZombieInfo> zombies;
    }

    [Serializable]
    public class ZombieInfo
    {
        public string name;
        public string info;
        public string introduce;
        public ZombieType theZombieType;
    }
}
