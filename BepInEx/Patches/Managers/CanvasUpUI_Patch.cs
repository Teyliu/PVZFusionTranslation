﻿using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using PvZ_Fusion_Translator__BepInEx_;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.Managers
{
    [HarmonyPatch(typeof(CanvasUpUI))]
	public static class CanvasUpUI_Patch
    {
		[HarmonyPatch(nameof(CanvasUpUI.Start))]
		[HarmonyPostfix]
		public static void Start(IZBottomMenu __instance)
		{
			TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

			foreach(TextMeshProUGUI text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
			{
				string originalKey = StringStore.translationString.FirstOrDefault(x => x.Value.Replace("\n", " ") == text.text).Key;
                text.text = (StringStore.translationString.ContainsKey(originalKey + "_MG")) ? StringStore.TranslateText(originalKey + "_MG") : StringStore.TranslateText(text.text);
                if(text.gameObject.name.Contains("LevelName"))
				{
                    text.text = text.text.Replace("\n", " ");
                }
                text.font = fontAsset;
            }
		}
    }
}