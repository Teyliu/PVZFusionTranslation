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
            Transform grave = __instance.transform.Find("Grave");
            if (grave == null)
            {
                Core.Log.LogWarning("[MainMenu_Patch] Could not find 'Grave' in MainMenu, skipping language button creation");
                return;
            }
            Transform playerName = __instance.transform.Find("Playername");
            if (playerName == null)
            {
                return;
            }
            playerName.gameObject.SetActive(false);
            GameAPP.playerName = "";

            Transform changelogObj = grave.Find("UpdateInfo");
            if (changelogObj == null)
            {
                Transform templateButton = null;
                for (int i = 0; i < grave.childCount; i++)
                {
                    Transform child = grave.GetChild(i);
                    if (child.GetComponent<UIButton>() != null)
                    {
                        templateButton = child;
                        break;
                    }
                }

                if (templateButton == null)
                {
                    Core.Log.LogWarning("[MainMenu_Patch] Could not find 'UpdateInfo' or any UIButton template in Grave, skipping language button creation");
                    return;
                }

                changelogObj = templateButton;
            }

            Vector3 spawnPos = changelogObj.position + new Vector3(0.0f, 0.855f);
            Transform langObj = UnityEngine.Object.Instantiate(changelogObj, spawnPos, changelogObj.rotation, grave);
            langObj.name = "Languages";

            Collider2D langCollider = langObj.GetComponent<Collider2D>();
            if (langCollider != null)
            {
                __instance.collider2Ds.Add(langCollider);
            }

            UIButton langBtn = langObj.GetComponent<UIButton>();
            if (langBtn == null)
            {
                Core.Log.LogWarning("[MainMenu_Patch] Language button missing UIButton component");
                return;
            }

            foreach (TextMeshProUGUI text in langObj.GetComponentsInChildren<TextMeshProUGUI>())
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

            Transform background = optionMenu.transform.Find("Background");
            if (background != null)
            {
                foreach(TextMeshProUGUI text in background.GetComponentsInChildren<TextMeshProUGUI>())
                {
                    text.text = StringStore.TranslateText("Language Settings");
                }
            }
        }
    }
}