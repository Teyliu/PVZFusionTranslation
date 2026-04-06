using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using PvZ_Fusion_Translator.Patches.GameObjects.ButtonObjects;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

namespace PvZ_Fusion_Translator.Patches.GameObjects
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
                if(!toKeep.Contains(child.name) && !toKeep.Contains(child.parent.name) && child.name != "LanguageMenu")
                {
                    child.gameObject.SetActive(false);
                }
            }

            OptionBtn templateButton = newOptionsMenu.transform.Find("F").GetComponent<OptionBtn>();
            OptLanguageBtn_Patch.OptLangBtn_Patch.Awake(templateButton);

            UIButton goBackButton = newOptionsMenu.transform.Find("Goback").GetComponent<UIButton>();

            newOptionsMenu.transform.Find("F").gameObject.SetActive(false);

            foreach (TextMeshProUGUI text in newOptionsMenu.transform.Find("Background").GetComponentsInChildren<TextMeshProUGUI>())
            {
                text.text = StringStore.TranslateText("Language Settings");
            }

            /*GameObject optionMenuAnchor = UnityEngine.Object.Instantiate(assetBundle.LoadAsset("OptionMenu").TryCast<GameObject>(), GameAPP.canvasUp);
            optionMenuAnchor.transform.SetParent(newOptionsMenu.transform, false);
            Transform messageAnchor = optionMenuAnchor.transform.Find("MessageAnchor");
            Transform plantAnchor = optionMenuAnchor.transform.Find("PlantAnchor");

            System.Random random = new System.Random();
            var plantTypes = Enum.GetValues(typeof(PlantType));
            PlantType randomPlantChoice = (PlantType)plantTypes.GetValue(random.Next(plantTypes.Length));

            if(!GameAPP.resourcesManager.plantPrefabs.ContainsKey(randomPlantChoice) || GameAPP.resourcesManager.plantPrefabs[randomPlantChoice] == null)
            {
                randomPlantChoice = (PlantType)plantTypes.GetValue(random.Next(plantTypes.Length));
            }

            if (GameAPP.resourcesManager.plantPrefabs[randomPlantChoice] != null)
            {
                GameObject plant = CreatePlant.SetPlantInAlmamac(plantAnchor.position, (int)randomPlantChoice);
                plant.transform.SetParent(newOptionsMenu.transform);
                SortingGroup sortingGroup = plant.AddComponent<SortingGroup>();
                sortingGroup.sortingLayerName = "UI";
                sortingGroup.sortingOrder = 20001;
                //plant.transform.position = new Vector3(-7.21f, -3.66f);
                UnityEngine.Object.Destroy(plant.GetComponent<Plant>());
            }*/

            /*GameObject messageObj = new GameObject();
            messageObj.name = "MultilangMessage";
            messageObj.transform.SetParent(newOptionsMenu.transform);
            TextMeshProUGUI messageText = messageObj.AddComponent<TextMeshProUGUI>();
            messageObj.transform.localScale = Vector3.one;
            messageText.autoSizeTextContainer = false;
            messageText.font = FontStore.LoadTMPFont(Utils.LanguageEnum.English.ToString());
            messageText.text = "Hello this is multilanguage choose language over there ------>";*/
        }

        public static void HideLangButton(GameObject btn)
        {
            btn.GetComponent<BoxCollider2D>().enabled = false;
        }

        public static void ShowLangButton(GameObject btn)
        {
            btn.GetComponent<BoxCollider2D>().enabled = true;
        }
    }
}