using HarmonyLib;
using System;
using System.Collections.Generic;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects.ButtonObjects;
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
            GameObject optionMenu = GameAPP.canvasUp.Find("OptionMenu(Clone)").gameObject;
            optionMenu.name = "LanguageMenu";

            List<string> toKeep = new List<string>() { "Background", "F", "Goback" };
            foreach(Transform child in optionMenu.GetComponentsInChildren<Transform>())
            {
                bool shouldKeep = toKeep.Contains(child.name) || toKeep.Contains(child.parent.name) || child.name == "LanguageMenu";
                if (!shouldKeep)
                {
                    child.gameObject.SetActive(false);
                }
            }

            Transform fBtn = optionMenu.transform.Find("F");
            if (fBtn != null)
            {
                OptionBtn optionBtn = fBtn.GetComponent<OptionBtn>();
                OptLanguageBtn_Patch.InitializeLanguageMenu(optionBtn);
            }

            Transform goBackBtn = optionMenu.transform.Find("Goback");
            if (goBackBtn != null)
            {
                UIButton backBtnComp = goBackBtn.GetComponent<UIButton>();
                backBtnComp.clickEvent = new UnityEvent();
                backBtnComp.clickEvent.AddListener(new Action(() => 
                {
                    OptLanguageBtn_Patch.buttonsCreated = false;
                    OptLanguageBtn_Patch.togglesCreated = false;
                    OptLanguageBtn_Patch.cachedTemplateButton = null;
                    OptLanguageBtn_Patch.cachedTemplateToggleButton = null;
                    OptLanguageBtn_Patch.LanguageBtnDict.Clear();
                    OptLanguageBtn_Patch.ToggleBtnDict.Clear();
                    GameAPP.UIManager.Pop();
                }));
            }

            fBtn?.gameObject.SetActive(false);

            foreach(TextMeshProUGUI text in optionMenu.transform.Find("Background").GetComponentsInChildren<TextMeshProUGUI>())
            {
                text.text = StringStore.TranslateText("Language Settings");
            }
        }
    }
}