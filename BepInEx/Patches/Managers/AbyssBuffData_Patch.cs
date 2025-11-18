//using HarmonyLib;
//using BepInEx;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.IO;
//using System.Text;
//using System.Text.Json;
//using System.Threading.Tasks;
//using Unity.VisualScripting;
//using UnityEngine;

//namespace PvZ_Fusion_Translator__BepInEx_.Patches.Managers
//{
//    [HarmonyPatch(typeof(AbyssBuffData))]
//    public static class AbyssBuffData_Patch
//    {
//        [HarmonyPatch(nameof(AbyssBuffData.LoadData))]
//        [HarmonyPostfix]
//        public static void Pre_LoadData(AbyssBuffData __instance)
//        {
//            string originalAbyssBuffStr = Resources.Load<TextAsset>("AbyssBuffData").text;
//            Dictionary<string, List<AbyssBuffInfo>> originalAbyssBuffData = JsonSerializer.Deserialize<Dictionary<string, List<AbyssBuffInfo>>>(originalAbyssBuffStr);
//            List<AbyssBuffInfo> infos = originalAbyssBuffData["infos"];
//            Il2CppSystem.Collections.Generic.Dictionary<AbyssBuff, Il2CppSystem.ValueTuple<string, string, float>> result = new();

//            string abyssBuffDataDir = Path.Combine(FileLoader.GetAssetDir(FileLoader.AssetType.Strings, Utils.Language), "abyss_buffs.json");
//            if (!File.Exists(abyssBuffDataDir))
//            {
//                File.WriteAllText(abyssBuffDataDir, originalAbyssBuffStr);
//            }

//            Dictionary<string, string> abyssBuffData = JsonSerializer.Deserialize<Dictionary<string, string>>(File.ReadAllText(abyssBuffDataDir));

//            for (int i = 0; i < infos.Count; i++)
//            {
//                AbyssBuffInfo originalTuple = infos[i];
//                Il2CppSystem.ValueTuple<string, string, float> translatedTuple = new();

//                translatedTuple.Item1 = abyssBuffData.ContainsKey(originalTuple.name) ? abyssBuffData[originalTuple.name] : originalTuple.name;
//                translatedTuple.Item2 = abyssBuffData.ContainsKey(originalTuple.introduce) ? abyssBuffData[originalTuple.introduce] : originalTuple.introduce;
//                translatedTuple.Item3 = originalTuple.value;

//                foreach (var x in AbyssBuffData.buffDatas)
//                {
//                    if (x.Value.Item1 == originalTuple.name)
//                    {
//                        AbyssBuffData.buffDatas[x.Key] = translatedTuple;
//                        break;
//                    }
//                }
//            }
//        }
//    }

//    public enum AbyssBuffClone
//    {
//        生存_聚塑,
//        生存_启命,
//        生存_坚定,
//        生存_弥合,
//        生存_警戒,
//        生存_霸体,
//        生存_共存,
//        生存_护盾,
//        生存_治疗,
//        生存_主宰,
//        寒冰_聚塑,
//        寒冰_刺骨,
//        寒冰_凛风,
//        寒冰_冻结,
//        寒冰_保护,
//        寒冰_折磨,
//        寒冰_扩散,
//        寒冰_凝神,
//        寒冰_破冰,
//        寒冰_永冻,
//        魅惑_聚塑,
//        魅惑_感应,
//        魅惑_催眠,
//        魅惑_无畏,
//        魅惑_脆弱,
//        魅惑_黑曜,
//        魅惑_转世,
//        魅惑_支援,
//        魅惑_沉重,
//        魅惑_共鸣,
//        烈焰_聚塑,
//        烈焰_爆破,
//        烈焰_怒火,
//        烈焰_红唇,
//        烈焰_融化,
//        烈焰_燃烧,
//        烈焰_浴火,
//        烈焰_鬼火,
//        烈焰_诅咒,
//        烈焰_太阳,
//        通用_断水,
//        通用_千斤,
//        通用_急迫,
//        通用_折扣,
//        通用_密植,
//        通用_超级,
//        通用_究极,
//        通用_极速,
//        通用_强力,
//        通用_专注,
//        通用_迸发,
//        通用_投资,
//        通用_机遇,
//        通用_命运,
//        通用_时停,
//        通用_升级,
//        蒜毒_聚塑,
//        蒜毒_腐蚀,
//        蒜毒_侵蚀,
//        蒜毒_血清,
//        蒜毒_混乱,
//        蒜毒_虚弱,
//        蒜毒_反胃,
//        蒜毒_虫噬,
//        蒜毒_百毒,
//        蒜毒_爆裂
//    }
//}