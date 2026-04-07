using HarmonyLib;
using System;
using System.Collections.Generic;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    public class MainMenu_Patch
    {
        public static void AnimOver(BaseMenu __instance)
        {
            Transform changelogObj = __instance.transform.Find("Grave/UpdateInfo");
            Transform langObj = UnityEngine.Object.Instantiate(changelogObj, changelogObj.position + new Vector3(0.0f, 0.855f), changelogObj.rotation, __instance.transform.Find("Grave"));
            langObj.name = "Languages";
            __instance.collider2Ds.Add(langObj.GetComponent<Collider2D>());
            UIButton langBtn = langObj.GetComponent<UIButton>();

            foreach(TextMeshProUGUI text in langObj.GetComponentsInChildren<TextMeshProUGUI>())
            {
                text.text = StringStore.TranslateText("Languages");
            }

            langBtn.clickEvent = new UnityEvent();
            langBtn.clickEvent.AddListener(new Action(() => OpenLanguageMenu(langBtn.gameObject)));
        }

        public static void OpenLanguageMenu(GameObject langBtn)
        {
            UIMgr.EnterOptionMenu();
            GameObject newOptionsMenu = GameAPP.canvasUp.Find("OptionMenu(Clone)").gameObject;
            newOptionsMenu.name = "LanguageMenu";

            List<string> toKeep = new List<string>() { "Background", "F", "Goback"};
            foreach(Transform child in newOptionsMenu.GetComponentsInChildren<Transform>())
            {
                if (!toKeep.Contains(child.name))
                {
                    UnityEngine.Object.Destroy(child.gameObject);
                }
            }
        }
    }
}
