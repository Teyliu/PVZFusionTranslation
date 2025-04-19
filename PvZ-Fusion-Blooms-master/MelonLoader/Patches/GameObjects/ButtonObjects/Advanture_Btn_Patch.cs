using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.GameObjects.ButtonObjects
{
	[HarmonyPatch(typeof(Advanture_Btn))]
	public static class Advanture_Btn_Patch
	{
		[HarmonyPatch(nameof(Advanture_Btn.Start))]
		[HarmonyPostfix]
		private static void Start(Advanture_Btn __instance)
		{
			StringStore.TranslateTextTransform(__instance.transform, true);
			Transform parentTransform = __instance.transform.parent.transform;
			if (__instance.name == "Goback")
			{
				Transform backgroundTransform = parentTransform.Find("Background");
				backgroundTransform.Find("Name").GetComponent<TMP_Text>().autoSizeTextContainer = true;
				backgroundTransform.Find("Shadow").GetComponent<TMP_Text>().autoSizeTextContainer = true;
			}

			Transform levelTransform = parentTransform.Find("Levels");
			if (levelTransform != null)
			{

				StringStore.TranslateTextTransform(levelTransform.Find("Nextpage"));
				StringStore.TranslateTextTransform(levelTransform.Find("LastPage"));

				Transform pageMiniGamesTransform = levelTransform.transform.Find("PageMiniGames");
				if (pageMiniGamesTransform != null)
				{
					StringStore.TranslateTextTransform(pageMiniGamesTransform.Find("BackToIndex"));
					StringStore.TranslateTextTransform(pageMiniGamesTransform.Find("Nextpage"));
					StringStore.TranslateTextTransform(pageMiniGamesTransform.Find("LastPage"));
				}

				Transform pageUnlockChallengeTransform = levelTransform.transform.Find("PageUnlockChallenge");
				if (pageUnlockChallengeTransform != null)
				{
					StringStore.TranslateTextTransform(pageUnlockChallengeTransform.Find("BackToIndex"));
				}

				Transform pageFlagChallengeTransform = levelTransform.transform.Find("PageFlagChallenge");
				if (pageFlagChallengeTransform != null)
				{
					StringStore.TranslateTextTransform(pageFlagChallengeTransform.Find("BackToIndex"));
				}
					
				Transform pageTravelExperienceTransform = levelTransform.transform.Find("PageTravelExperience");
				if (pageTravelExperienceTransform != null)
				{
					StringStore.TranslateTextTransform(pageTravelExperienceTransform.Find("BackToIndex"));
				}

				Transform pageGardenProtectionTransform = levelTransform.transform.Find("PageGardenProtection");
				if (pageGardenProtectionTransform != null)
				{
					StringStore.TranslateTextTransform(pageGardenProtectionTransform.Find("BackToIndex"));
				}

				Transform pageNormalTravelTransform = levelTransform.transform.Find("PageNormalTravel");
				if (pageNormalTravelTransform != null)
				{
					StringStore.TranslateTextTransform(pageNormalTravelTransform.Find("BackToIndex"));
				}

				Transform pageRandomLevelTransform = levelTransform.transform.Find("PageRandomLevel");
				if (pageRandomLevelTransform != null)
				{
					StringStore.TranslateTextTransform(pageRandomLevelTransform.Find("BackToIndex"));
				}

				Transform pageUltimateExperienceTransform = levelTransform.transform.Find("PageUltimateExprience");
				if (pageUltimateExperienceTransform != null)
				{
					StringStore.TranslateTextTransform(pageUltimateExperienceTransform.Find("BackToIndex"));
				}

				Transform pageAdvantureLevelTransform = levelTransform.transform.Find("PageAdvantureLevel");
				if (pageAdvantureLevelTransform != null)
				{
					StringStore.TranslateTextTransform(pageAdvantureLevelTransform.Find("BackToIndex"));
					StringStore.TranslateTextTransform(pageAdvantureLevelTransform.Find("Nextpage"));
					StringStore.TranslateTextTransform(pageAdvantureLevelTransform.Find("LastPage"));
				}

				Transform pageScaryPotTransform = levelTransform.transform.Find("PageScaryPot");
				if (pageScaryPotTransform != null)
				{
					StringStore.TranslateTextTransform(pageScaryPotTransform.Find("BackToIndex"));
					StringStore.TranslateTextTransform(pageScaryPotTransform.Find("Nextpage"));
					StringStore.TranslateTextTransform(pageScaryPotTransform.Find("LastPage"));
				}
			}

			StringStore.TranslateTextTransform(parentTransform.Find("CameraSize"));
			StringStore.TranslateTextTransform(parentTransform.Find("CanvasSize"));
		}
	}
}
