using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using System.Text.RegularExpressions;
using Unity.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static PvZ_Fusion_Translator.FileLoader;
using static PvZ_Fusion_Translator.Utils;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(AlmanacPlantMenu))]
    public static class AlmanacPlantMenu_Patch
    {
        [HarmonyPatch(nameof(AlmanacPlantMenu.Awake))]
        [HarmonyPostfix]
        private static void Awake(AlmanacPlantMenu __instance)
        {
            TMP_FontAsset font = FontStore.LoadTMPFont(Utils.Language.ToString());
            foreach (TextMeshProUGUI text in __instance.GetComponentsInChildren<TextMeshProUGUI>(true))
            {
                bool isPlantName = text.gameObject.name.Contains("Name") && text.transform.parent.name != "Background";
                if (text.gameObject.name != "Description" && !isPlantName)
                {
                    text.text = StringStore.TranslateText(text.text);
                    text.font = font;
                    text.autoSizeTextContainer = true;
                }
            }

            // skin button resize

            AlmanacPlantWindow window = __instance.window;
            GameObject skinButton = window.skinButton;
            GameObject skinTextObj = skinButton.transform.GetChild(0).gameObject;
            GameObject skinShadowTextObj = skinTextObj.transform.GetChild(0).gameObject;
            TextMeshProUGUI skinShadowText = skinShadowTextObj.GetComponent<TextMeshProUGUI>();
            skinShadowText.text = StringStore.TranslateText("换肤_S");
            skinButton.transform.localScale /= 1.75f;
            skinButton.transform.localPosition = new Vector3(0.0f, 111.345f, 0.0f);
            skinButton.transform.GetChild(1).Translate(new Vector3(-0.35f, 0));
            skinButton.transform.GetChild(2).Translate(new Vector3(0.35f, 0));
        }

        [HarmonyPatch(nameof(AlmanacPlantMenu.SearchChanged))]
        [HarmonyPrefix]
        public static bool SearchChanged(AlmanacPlantMenu __instance, ref TMP_InputField inputField)
        {
            string search = inputField.text;
            if (search != StringStore.TranslateText("搜索"))
            {
                string currentLanguage = Utils.Language.ToString();
                string almanacDir = GetAssetDir(AssetType.Almanac, Utils.Language);
                string path = Path.Combine(almanacDir, "LawnStringsTranslate.json");
                string moddedPath = Path.Combine(almanacDir, "ModdedPlantsTranslate.json");

                string json;
                json = File.ReadAllText(path);

                TMP_FontAsset fontAsset = FontStore.LoadTMPFont(currentLanguage);

                AlmanacPlantBank.PlantData plantData = JsonUtility.FromJson<AlmanacPlantBank.PlantData>(json);

                Il2CppSystem.Collections.Generic.List<PlantType> searchedPlants = new();

                foreach (AlmanacPlantBank.PlantInfo plantInfo in plantData.plants)
                {
                    //List<int> uniqueIngredients = GetIngredients(plantInfo.seedType);

                    //// ingredient-based search

                    //foreach(int i in uniqueIngredients)
                    //{
                    //    string name = Utils.GetPlantNameFromAlmanac((PlantType)i);

                    //    if(name.ToLower().Contains(search.ToLower()))
                    //    {
                    //        searchedPlants.Add((PlantType)i);
                    //    }
                    //}

                    // keyword-based search

                    // name-based search

                    if (plantInfo.name.ToLower().Contains(search.ToLower()))
                    {
                        searchedPlants.Add((PlantType)plantInfo.seedType);
                    }
                }

                __instance.ShowPlants(searchedPlants);

                return false;
            }

            return true;
        }

        private static List<int> GetIngredients(int theSeedType)
        {
            List<int> ingredientPairs = new();
            Il2CppSystem.Array mixData = MixData.data.Cast<Il2CppSystem.Array>();
            int rows = mixData.GetLength(0);
            int columns = mixData.GetLength(1);

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    if(ContainsFormula(theSeedType))
                    {
                        if (mixData.GetValue(i, j).Unbox<int>() == theSeedType)
                        {
                            if (!ingredientPairs.Contains(i))
                            {
                                ingredientPairs.Add(i);
                            }

                            if (!ingredientPairs.Contains(j))
                            {
                                ingredientPairs.Add(j);
                            }
                        }
                    }
                    else
                    {
                        return ingredientPairs;
                    }
                    
                }
            }

            return ingredientPairs;
        }

        private static bool ContainsFormula(int theSeedType)
        {
            bool contains = false;

            Il2CppSystem.Array mixData = MixData.data.Cast<Il2CppSystem.Array>();
            int rows = mixData.GetLength(0);
            int columns = mixData.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (mixData.GetValue(i, j).Unbox<int>() == theSeedType)
                    {
                        contains = true;
                        return contains;
                    }
                }
            }

            return contains;
        }
    }
}
