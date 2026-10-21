using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;
using PvZ_Fusion_Translator.Patches.GameObjects.ButtonObjects;

namespace PvZ_Fusion_Translator.Patches.GameObjects;

[HarmonyPatch(typeof(MainMenu))]
public class MainMenu_Patch
{
    public static void AnimOver(BaseMenu __instance)
    {
        var changelogObj = __instance.transform.Find("Grave/UpdateInfoButton");

        var langObj = UnityEngine.Object.Instantiate(
            changelogObj,
            changelogObj.position + new Vector3(0.0f, 0.855f),
            changelogObj.rotation,
            __instance.transform.Find("Grave")
        );

        langObj.name = "LanguagesButton";
        __instance.collider2Ds.Add(langObj.GetComponent<Collider2D>());
        var langBtn = langObj.GetComponent<UIButton>();

        foreach (var text in langObj.GetComponentsInChildren<TextMeshProUGUI>())
            text.text = StringStore.TranslateText("Languages");

        langBtn.clickEvent = new();
        langBtn.clickEvent.AddListener(new Action(() => OpenLanguageMenu(langBtn.gameObject)));
    }

    public static void OpenLanguageMenu(GameObject langBtn)
    {
        UIMgr.EnterOptionMenu();
        var newOptionsMenu = GameAPP.canvasUp.Find("OptionMenu(Clone)").gameObject;
        newOptionsMenu.name = "LanguageMenu";

        var toKeep = new List<string> { "Background", "F", "Goback" };

        foreach (var child in newOptionsMenu.GetComponentsInChildren<Transform>()
           .Where(c => !toKeep.Contains(c.name) && !toKeep.Contains(c.parent.name) && c.name != "LanguageMenu"))
            child.gameObject.SetActive(false);

        var templateButton = newOptionsMenu.transform.Find("Buttons/F").GetComponent<OptionBtn>();
        OptLanguageBtn_Patch.OptLangBtn_Patch.Awake(templateButton);

        // var goBackButton = newOptionsMenu.transform.Find("Goback").GetComponent<UIButton>();

        newOptionsMenu.transform.Find("Buttons/F").gameObject.SetActive(false);
        newOptionsMenu.transform.Find("Buttons").gameObject.SetActive(true);

        foreach (var text in newOptionsMenu.transform.Find("Background").GetComponentsInChildren<TextMeshProUGUI>())
            text.text = StringStore.TranslateText("Language Settings");

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

    [HarmonyPatch(nameof(MainMenu.EnterUpdateUrl)), HarmonyPrefix]
    public static bool Pre_EnterUpdateUrl(MainMenu __instance)
    {
        System.Diagnostics.Process.Start(
            new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://github.com/Teyliu/PVZF-Translation",
                UseShellExecute = true,
            }
        );

        return false;
    }
}
