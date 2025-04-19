using HarmonyLib;
using Il2Cpp;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.GameObjects.ButtonObjects
{
	[HarmonyPatch(typeof(BaseMenu))]
	public static class BaseMenu_Patch
	{
		[HarmonyPatch(nameof(BaseMenu.Awake))]
		[HarmonyPostfix]
		private static void Awake(BaseMenu __instance)
		{
			Transform mainTransform = __instance.transform;
			if (mainTransform != null)
			{
				StringStore.TranslateTextTransform(mainTransform.Find("Goback"));
				StringStore.TranslateTextTransform(mainTransform.Find("Switich"));

				Transform levelTransform = mainTransform.Find("Level");
				if (levelTransform != null)
				{
					StringStore.TranslateTextTransform(levelTransform.Find("Nextpage"));
					StringStore.TranslateTextTransform(levelTransform.Find("LastPage"));
				}

				Transform customLevelTransform = mainTransform.Find("CustomLevel");
				if (customLevelTransform != null)
				{
					StringStore.TranslateTextTransform(customLevelTransform.Find("Nextpage"));
					StringStore.TranslateTextTransform(customLevelTransform.Find("LastPage"));
				}

				Transform levelsTransform = mainTransform.Find("Levels");
				if (levelsTransform != null)
				{

					StringStore.TranslateTextTransform(levelsTransform.Find("Nextpage"));
					StringStore.TranslateTextTransform(levelsTransform.Find("LastPage"));

					Transform pageMiniGamesTransform = levelsTransform.transform.Find("PageMiniGames");
					if (pageMiniGamesTransform != null)
					{
						StringStore.TranslateTextTransform(pageMiniGamesTransform.Find("BackToIndex"));
						StringStore.TranslateTextTransform(pageMiniGamesTransform.Find("Nextpage"));
						StringStore.TranslateTextTransform(pageMiniGamesTransform.Find("LastPage"));
					}

					Transform pageUnlockChallengeTransform = levelsTransform.transform.Find("PageUnlockChallenge");
					if (pageUnlockChallengeTransform != null)
					{
						StringStore.TranslateTextTransform(pageUnlockChallengeTransform.Find("BackToIndex"));
					}

					Transform pageFlagChallengeTransform = levelsTransform.transform.Find("PageFlagChallenge");
					if (pageFlagChallengeTransform != null)
					{
						StringStore.TranslateTextTransform(pageFlagChallengeTransform.Find("BackToIndex"));
					}
					
					Transform pageTravelExperienceTransform = levelsTransform.transform.Find("PageTravelExperience");
					if (pageTravelExperienceTransform != null)
					{
						StringStore.TranslateTextTransform(pageTravelExperienceTransform.Find("BackToIndex"));
					}

					Transform pageGardenProtectionTransform = levelsTransform.transform.Find("PageGardenProtection");
					if (pageGardenProtectionTransform != null)
					{
						StringStore.TranslateTextTransform(pageGardenProtectionTransform.Find("BackToIndex"));
					}

					Transform pageNormalTravelTransform = levelsTransform.transform.Find("PageNormalTravel");
					if (pageNormalTravelTransform != null)
					{
						StringStore.TranslateTextTransform(pageNormalTravelTransform.Find("BackToIndex"));
					}

					Transform pageRandomLevelTransform = levelsTransform.transform.Find("PageRandomLevel");
					if (pageRandomLevelTransform != null)
					{
						StringStore.TranslateTextTransform(pageRandomLevelTransform.Find("BackToIndex"));
					}

					Transform pageUltimateExperienceTransform = levelsTransform.transform.Find("PageUltimateExprience");
					if (pageUltimateExperienceTransform != null)
					{
						StringStore.TranslateTextTransform(pageUltimateExperienceTransform.Find("BackToIndex"));
					}

					Transform pageAdvantureLevelTransform = levelsTransform.transform.Find("PageAdvantureLevel");
					if (pageAdvantureLevelTransform != null)
					{
						StringStore.TranslateTextTransform(pageAdvantureLevelTransform.Find("BackToIndex"));
						StringStore.TranslateTextTransform(pageAdvantureLevelTransform.Find("Nextpage"));
						StringStore.TranslateTextTransform(pageAdvantureLevelTransform.Find("LastPage"));
					}

					Transform pageScaryPotTransform = levelsTransform.transform.Find("PageScaryPot");
					if (pageScaryPotTransform != null)
					{
						StringStore.TranslateTextTransform(pageScaryPotTransform.Find("BackToIndex"));
						StringStore.TranslateTextTransform(pageScaryPotTransform.Find("Nextpage"));
						StringStore.TranslateTextTransform(pageScaryPotTransform.Find("LastPage"));
					}
				}
			}
		}
	}
}
