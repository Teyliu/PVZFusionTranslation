using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;
using UnityEngine.UI;

namespace PvZ_Fusion_Translator.Patches.GameObjects.ButtonObjects
{
	[HarmonyPatch(typeof(UIButton))]
	public static class UIButton_Patch
    {
		[HarmonyPatch(nameof(UIButton.Start))]
		[HarmonyPostfix]
		private static void Start(UIButton __instance)
		{
			Transform txtTransform = __instance.transform.FindChild("text");
            string fontPath = "";
            TMP_FontAsset fontAsset = null;

			if(txtTransform != null)
			{
                string fontsDir = Path.Combine(Core.Instance.modsDirectory, "[Custom Fonts]");

                foreach (string file in Directory.GetFiles(fontsDir))
                {
                    string fileName = Path.GetFileNameWithoutExtension(file);
                    string fileExtension = Path.GetExtension(file);

                    if (fileExtension == ".ttf" || fileExtension == ".otf")
                    {
                        if (!fileName.EndsWith("_Almanac") && !fileName.EndsWith("_Fallback"))
                        {
                            fontPath = Path.Combine("PvZ_Fusion_Translator", "[Custom Fonts]", fileName + fileExtension);

                            fontAsset = FontHandler.LoadTMPFont(fontPath, true);
                            fontAsset.name = fileName;
                            fontAssetDict.Add(fileName, fontAsset);

                            Log.LogInfo($"Font for language '{fileName}' loaded");
                        }
                    }
                }

                string fontPath = Path.Combine("PvZ_Fusion_Translator", "[Custom Fonts]", fileName + fileExtension);
                Font fontAsset = FontHandler.LoadFont(fontPath, false);

                txtTransform.GetComponent<Text>().text = StringStore.TranslateText(txtTransform.GetComponent<Text>().text);
				txtTransform.GetComponent<Text>().font = fontAsset;
            }
        }
	}
}
