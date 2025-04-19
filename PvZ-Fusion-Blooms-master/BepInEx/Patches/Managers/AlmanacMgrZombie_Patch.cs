using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using static PvZ_Fusion_Translator__BepInEx_.FileLoader;
using UnityEngine;
using System.IO;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.Managers
{
	[HarmonyPatch(typeof(AlmanacMgrZombie))]
	public static partial class AlmanacMgrZombie_Patch
	{
		[HarmonyPatch(nameof(AlmanacMgrZombie.InitNameAndInfoFromJson))]
		[HarmonyPrefix]
		private static bool InitNameAndInfoFromJson(AlmanacMgrZombie __instance)
		{
			string currentLanguage = Utils.Language.ToString();
			string almanacDir = GetAssetDir(AssetType.Almanac, Utils.Language);
			string path = Path.Combine(almanacDir, "ZombieStringsTranslate.json");

			if (!File.Exists(path))
			{
				Log.LogError($"ZombieStringsTranslate.json file not found at path: {path}");
				return true;
			}

			#if OBFUSCATE
			if (CheckSumStore.IsModified(path))
			{
				Log.LogError("File {0} was modified!", path);
				return true;
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

			TMP_FontAsset fontAsset = FontStore.LoadTMPFont(currentLanguage);

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

					return false;
				}
			}

			return true;
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
}
