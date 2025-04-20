using HarmonyLib;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using TMPro;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
	[HarmonyPatch(typeof(CustomSun))]
	public static class CustomSun_Patch
	{
		[HarmonyPatch(nameof(CustomSun.Awake))]
		[HarmonyPostfix]
		private static void Awake(CustomSun __instance)
		{
			if (__instance.inputField.gameObject.activeSelf)
			{
				string oriTextSun = __instance.inputField.m_Text;
				__instance.inputField.gameObject.SetActive(false);
				__instance.inputField.m_Text = StringStore.TranslateText(oriTextSun);
				__instance.inputField.m_OriginalText = StringStore.TranslateText(oriTextSun);
				__instance.inputField.gameObject.SetActive(true);
			}

			if (__instance.setFlags.gameObject.activeSelf)
			{
				string oriTextFlags = __instance.setFlags.m_Text;
				__instance.setFlags.gameObject.SetActive(false);
				__instance.setFlags.m_Text = StringStore.TranslateText(oriTextFlags);
				__instance.setFlags.m_OriginalText = StringStore.TranslateText(oriTextFlags);
				__instance.setFlags.gameObject.SetActive(true);
			}

			Transform lookZombieTransform = __instance.lookZombie.transform.GetChild(0).transform;
			if (lookZombieTransform != null)
			{
				TextMeshProUGUI lookZombieTMP = lookZombieTransform.GetComponent<TextMeshProUGUI>();
				if (lookZombieTMP != null)
				{
					lookZombieTMP = StringStore.TranslateText(lookZombieTMP);
				}
			}
		}
	}
}
