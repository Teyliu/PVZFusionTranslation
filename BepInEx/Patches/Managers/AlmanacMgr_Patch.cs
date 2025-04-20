using HarmonyLib;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using System.IO;
using TMPro;
using UnityEngine;
using static PvZ_Fusion_Translator__BepInEx_.FileLoader;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.Managers
{
	[HarmonyPatch(typeof(AlmanacMgr))]
	public static partial class AlmanacMgr_Patch
	{
		[HarmonyPatch(nameof(AlmanacMgr.InitNameAndInfoFromJson))]
		[HarmonyPrefix]
		private static bool InitNameAndInfoFromJson(AlmanacMgr __instance)
		{
			string currentLanguage = Utils.Language.ToString();
			string almanacDir = GetAssetDir(AssetType.Almanac, Utils.Language);
			string path = Path.Combine(almanacDir, "LawnStringsTranslate.json");

			if (!File.Exists(path))
			{
				Log.LogError($"LawnStringsTranslate.json file not found at path: {path}");
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
			TextMeshPro component2 = __instance.plantName.GetComponent<TextMeshPro>();
			TextMeshPro component3 = __instance.plantName.transform.GetChild(0).GetComponent<TextMeshPro>();
			TextMeshPro component4 = __instance.cost.GetComponent<TextMeshPro>();

			AlmanacMgr.PlantData plantData = JsonUtility.FromJson<AlmanacMgr.PlantData>(json);

			foreach (AlmanacMgr.PlantInfo plantInfo in plantData.plants)
			{
				if (plantInfo.seedType == __instance.theSeedType)
				{
					component.text = plantInfo.info + "\n\n" + plantInfo.introduce;
					component.overflowMode = TextOverflowModes.Page;
					component2.text = plantInfo.name;
					component2.autoSizeTextContainer = true;
					component3.text = Utils.RemoveColorTags(plantInfo.name);
					component3.autoSizeTextContainer = true;
					component4.text = plantInfo.cost;

					if (hasAlmanacFont)
					{
						component.font = almanacFontAsset;
						component4.font = almanacFontAsset;
					}
					else
					{
						component.font = fontAsset;
						component4.font = fontAsset;
					}
					component2.font = fontAsset;
					component3.font = fontAsset;
					return false;
				}
			}

			return true;
		}

		[HarmonyPatch(nameof(AlmanacMgr.OnMouseDown))]
		[HarmonyPrefix]
		private static bool OnMouseDown(AlmanacMgr __instance)
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
