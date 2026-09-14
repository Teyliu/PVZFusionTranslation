using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004C7 RID: 1223
[Token(Token = "0x20004C7")]
public class PlantMixTreeManagerExample : MonoBehaviour
{
	// Token: 0x06001708 RID: 5896 RVA: 0x0007E834 File Offset: 0x0007CA34
	[Token(Token = "0x6001708")]
	[Address(RVA = "0x510C00", Offset = "0x50F200", VA = "0x180510C00")]
	public static void InitExample()
	{
		PlantMixTreeManager.PrintAllStatistics();
	}

	// Token: 0x06001709 RID: 5897 RVA: 0x0007E848 File Offset: 0x0007CA48
	[Token(Token = "0x6001709")]
	[Address(RVA = "0x511170", Offset = "0x50F770", VA = "0x180511170")]
	public static void QueryPeashooterMixablePlants()
	{
		Debug.Log("=== 示例1：查询豌豆射手可融合植物 ===");
		PlantMixTreeNode tree = PlantMixTreeManager.GetTree(PlantType.Peashooter);
		int num = 0;
		if (tree != 0)
		{
			List<PlantType> list = new List(tree.<DirectChildren>k__BackingField._size);
			PlantType <PlantType>k__BackingField = tree.<DirectChildren>k__BackingField[num].<PlantType>k__BackingField;
			int size = list._size;
			num++;
			list._size = 1;
			num++;
		}
		List<PlantType> list2 = new List();
		int size2 = list2._size;
		Debug.Log(string.Format("豌豆射手可直接融合出 {0} 种植物:", size2));
		int size3 = list2._size;
		if (Math.Min(10, size3) > 0)
		{
			PlantType plantType = list2[num];
			Debug.Log(string.Format("  - {0}", plantType));
			num++;
		}
		int size4 = PlantMixTreeManager.GetAllMixablePlants(PlantType.Peashooter)._size;
		Debug.Log(string.Format("\n豌豆射手总共可融合出 {0} 种植物（包括间接融合）", size4));
		PlantMixTreeNode tree2 = PlantMixTreeManager.GetTree(PlantType.Peashooter);
		if (tree2 != 0)
		{
			List<PlantMixTreeNode> <AllDescendants>k__BackingField = tree2.<AllDescendants>k__BackingField;
			if (tree2.<AllDescendants>k__BackingField[num].<PlantType>k__BackingField != PlantType.GatlingPea)
			{
				List<PlantMixTreeNode> <AllDescendants>k__BackingField2 = tree2.<AllDescendants>k__BackingField;
				num++;
			}
			if (0 == 0)
			{
			}
		}
		Debug.Log("\n豌豆射手可以融合出机枪射手吗？ " + "否");
	}

	// Token: 0x0600170A RID: 5898 RVA: 0x0007E974 File Offset: 0x0007CB74
	[Token(Token = "0x600170A")]
	[Address(RVA = "0x5115F0", Offset = "0x50FBF0", VA = "0x1805115F0")]
	public static void QueryRecipes()
	{
		int num2;
		do
		{
			Debug.Log("\n=== 示例2：查询融合配方 ===");
			if (PlantMixTreeManager.GetTree(PlantType.Peashooter) != 0)
			{
			}
			Dictionary<PlantType, PlantType> dictionary = new Dictionary();
			int count = dictionary.Count;
			Debug.Log(string.Format("豌豆射手有 {0} 个融合配方:", count));
			int count2 = dictionary.Count;
			int num = Math.Min(15, count2);
			num2 = 0;
			bool flag;
			if (flag && num2 < num)
			{
				string text;
				Debug.Log(text);
				num2++;
			}
		}
		while (num2 != 0);
	}

	// Token: 0x0600170B RID: 5899 RVA: 0x0007E9E8 File Offset: 0x0007CBE8
	[Token(Token = "0x600170B")]
	[Address(RVA = "0x510E20", Offset = "0x50F420", VA = "0x180510E20")]
	public static void QueryParents()
	{
		int num;
		do
		{
			Debug.Log("\n=== 示例3：查询父节点 ===");
			num = 0;
			if (PlantMixTreeManager.<ChildToParents>k__BackingField.TryGetValue((uint)925, num))
			{
				Debug.LogWarning("[PlantMixTreeManager] 未初始化，请先调用 Init()");
			}
			List<PlantMixTreeManager.MixParentInfo> list = new List();
			Debug.Log("以下植物组合可以融合成究极樱桃战神:");
			bool flag;
			if (flag)
			{
				PlantType plantType;
				Debug.Log(string.Format("  {0} + {1} = {2}", plantType, plantType, plantType));
			}
		}
		while (num != 0);
	}

	// Token: 0x0600170C RID: 5900 RVA: 0x0007EA58 File Offset: 0x0007CC58
	[Token(Token = "0x600170C")]
	[Address(RVA = "0x511930", Offset = "0x50FF30", VA = "0x180511930")]
	public static void TryMixExample()
	{
		Debug.Log("\n=== 示例4：尝试融合 ===");
		PlantMixTreeNode tree = PlantMixTreeManager.GetTree(PlantType.Peashooter);
		if (tree != 0)
		{
			Dictionary<PlantType, PlantType> <Recipes>k__BackingField = tree.<Recipes>k__BackingField;
			bool flag;
			if (flag)
			{
				PlantType plantType;
				Debug.Log(string.Format("豌豆射手 + 豌豆射手 = {0}", plantType));
			}
		}
		PlantMixTreeNode tree2 = PlantMixTreeManager.GetTree(PlantType.Peashooter);
		if (tree2 != 0)
		{
			Dictionary<PlantType, PlantType> <Recipes>k__BackingField2 = tree2.<Recipes>k__BackingField;
			bool flag2;
			if (flag2)
			{
				PlantType plantType2;
				Debug.Log(string.Format("豌豆射手 + 向日葵 = {0}", plantType2));
			}
		}
	}

	// Token: 0x0600170D RID: 5901 RVA: 0x0007EACC File Offset: 0x0007CCCC
	[Token(Token = "0x600170D")]
	[Address(RVA = "0x510C10", Offset = "0x50F210", VA = "0x180510C10")]
	public static void PrintTreeExample()
	{
		Debug.Log("\n=== 示例5：打印融合树 ===");
		PlantMixTreeManager.PrintTree(PlantType.Peashooter);
	}

	// Token: 0x0600170E RID: 5902 RVA: 0x0007EAEC File Offset: 0x0007CCEC
	[Token(Token = "0x600170E")]
	[Address(RVA = "0x510C70", Offset = "0x50F270", VA = "0x180510C70")]
	public static void QueryMixPaths()
	{
		Debug.Log("\n=== 示例6：查询融合路径 ===");
		List<List<PlantType>> mixPaths = PlantMixTreeManager.GetMixPaths(PlantType.Peashooter, (PlantType)((uint)1032));
		int size = mixPaths._size;
		Debug.Log(string.Format("从豌豆射手到机枪射手有 {0} 条融合路径:", mixPaths));
		int num = 0;
		List<PlantType> list = mixPaths[num];
		string text = string.Join<PlantType>(" -> ", list);
		int num2;
		Debug.Log(string.Format("  路径 {0}: {1}", num2, text));
		num++;
	}

	// Token: 0x0600170F RID: 5903 RVA: 0x0007EB5C File Offset: 0x0007CD5C
	[Token(Token = "0x600170F")]
	[Address(RVA = "0x5103D0", Offset = "0x50E9D0", VA = "0x1805103D0")]
	public static void FindBestMixPath(PlantType fromPlant, PlantType toPlant)
	{
		Debug.Log(string.Format("\n=== 示例7：查找从 {0} 到 {1} 的最佳路径 ===", "\n=== 示例7：查找从 {0} 到 {1} 的最佳路径 ===", "\n=== 示例7：查找从 {0} 到 {1} 的最佳路径 ==="));
		int num = 0;
		List<List<PlantType>> list2;
		List<PlantType> list = list2[num];
		int num2 = 0;
		List<PlantType> list3 = list2[num2];
		List<PlantType> list4 = list2[1];
		int size = list._size;
		List<PlantType> list5 = list2[1];
		List<PlantType> list6 = list2[1];
		int size2 = list3._size;
		List<PlantType> list7 = list2[1];
		int size3 = list._size;
		Debug.Log(string.Format("最短路径（{0}次融合）:", size3));
		string text = string.Join<PlantType>(" -> ", list);
		Debug.Log("  " + text);
		int size4 = list3._size;
		Debug.Log(string.Format("最长路径（{0}次融合）:", size4));
		string text2 = string.Join<PlantType>(" -> ", list3);
		Debug.Log("  " + text2);
	}

	// Token: 0x06001710 RID: 5904 RVA: 0x0007EC5C File Offset: 0x0007CE5C
	[Token(Token = "0x6001710")]
	[Address(RVA = "0x50FE80", Offset = "0x50E480", VA = "0x18050FE80")]
	public static void BatchQueryMixAbility()
	{
		Debug.Log("\n=== 示例8：批量查询融合能力 ===");
		PlantType[] array = new PlantType[]
		{
			PlantType.Peashooter,
			PlantType.SunFlower,
			PlantType.WallNut,
			PlantType.CherryBomb,
			PlantType.DoomShroom
		};
		int num = 0;
		if (num < array.Length)
		{
			List<PlantType> allMixablePlants = PlantMixTreeManager.GetAllMixablePlants(array);
			int size = allMixablePlants._size;
			Debug.Log(string.Format("{0}: 可融合出 {1} 种植物", allMixablePlants, allMixablePlants));
			num++;
		}
	}

	// Token: 0x06001711 RID: 5905 RVA: 0x0007ECBC File Offset: 0x0007CEBC
	[Token(Token = "0x6001711")]
	[Address(RVA = "0x510750", Offset = "0x50ED50", VA = "0x180510750")]
	public static void FindValuableMixTargets(PlantType plantType, int topN = 10)
	{
		Debug.Log(string.Format("\n=== 示例9：查找 {0} 最有价值的融合目标 ===", "融合价值最高的 {0} 个目标:"));
		List<ValueTuple<PlantType, int>> list = new List();
		int num = 0;
		List<PlantType> list2;
		PlantType plantType2 = list2[num];
		PlantMixTreeNode plantMixTreeNode;
		if (plantMixTreeNode != 0)
		{
		}
		int num2 = 0;
		int num3 = 0;
		ValueTuple<PlantType, int> valueTuple = list[1];
		ValueTuple<PlantType, int> valueTuple2 = list[num3];
		ValueTuple<PlantType, int> valueTuple3 = list[1];
		if (num2 > valueTuple3)
		{
			num++;
		}
		num++;
		int num4 = 0;
		int num5 = 0;
		int size = list._size;
		ValueTuple<PlantType, int> valueTuple5;
		if (num5 < size)
		{
			ValueTuple<PlantType, int> valueTuple4 = list[1];
			valueTuple5 = list[num4];
			ValueTuple<PlantType, int> valueTuple6 = list[num4];
			ValueTuple<PlantType, int> valueTuple7 = list[1];
			list[num4] = valueTuple7;
			list[1] = valueTuple6;
			num4++;
		}
		Debug.Log(string.Format("融合价值最高的 {0} 个目标:", valueTuple5));
		int num6 = 0;
		ValueTuple<PlantType, int> valueTuple8 = list[num6];
		int num7;
		Debug.Log(string.Format("{0}. {1} (深度: {2})", num7, num7, num7));
		num6++;
	}

	// Token: 0x06001712 RID: 5906 RVA: 0x0007EDCC File Offset: 0x0007CFCC
	[Token(Token = "0x6001712")]
	[Address(RVA = "0x510030", Offset = "0x50E630", VA = "0x180510030")]
	public static void ExportVisualization(PlantType plantType)
	{
		Debug.Log(string.Format("\n=== 示例10：导出 {0} 融合树可视化 ===", "MixTree_{0}.dot"));
		PlantMixTreeNode plantMixTreeNode;
		if (plantMixTreeNode != 0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			StringBuilder stringBuilder2 = stringBuilder.AppendLine("digraph {");
			StringBuilder stringBuilder3 = stringBuilder.AppendLine("  rankdir=LR;");
			StringBuilder stringBuilder4 = stringBuilder.AppendLine("  node [shape=box];");
			string text = string.Format("  \"{0}\" [style=filled, fillcolor=lightblue];", stringBuilder4);
			StringBuilder stringBuilder5 = stringBuilder.AppendLine(text);
			PlantMixTreeManager.ExportNodethist(plantMixTreeNode, stringBuilder);
			StringBuilder stringBuilder6 = stringBuilder.AppendLine("}");
			string text2 = stringBuilder.ToString();
		}
		string text3 = string.Format("MixTree_{0}.dot", plantMixTreeNode);
		File.WriteAllText(text3, "");
		Debug.Log("融合树已导出到: " + text3);
		Debug.Log("可以使用 Graphviz 或在线工具（如 http://viz-js.com/）查看");
		Debug.Log("预览（前20行）:");
		string[] array;
		int length = array.Length;
		uint num2;
		int num = Math.Min((int)num2, length);
		int num3 = 0;
		if (num > 0)
		{
			num3++;
			num3++;
		}
	}

	// Token: 0x06001713 RID: 5907 RVA: 0x0007EEC4 File Offset: 0x0007D0C4
	[Token(Token = "0x6001713")]
	[Address(RVA = "0x511910", Offset = "0x50FF10", VA = "0x180511910")]
	[ProButton]
	public void RunAllExamples()
	{
		PlantMixTreeManager.PrintAllStatistics();
		PlantMixTreeManagerExample.QueryParents();
	}

	// Token: 0x06001714 RID: 5908 RVA: 0x0007EEE0 File Offset: 0x0007D0E0
	[Token(Token = "0x6001714")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public PlantMixTreeManagerExample()
	{
	}
}
