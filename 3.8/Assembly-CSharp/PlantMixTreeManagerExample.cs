using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004A5 RID: 1189
[Token(Token = "0x20004A5")]
public class PlantMixTreeManagerExample : MonoBehaviour
{
	// Token: 0x06001667 RID: 5735 RVA: 0x0007BD6C File Offset: 0x00079F6C
	[Token(Token = "0x6001667")]
	[Address(RVA = "0x4A5160", Offset = "0x4A3760", VA = "0x1804A5160")]
	public static void InitExample()
	{
		PlantMixTreeManager.PrintAllStatistics();
	}

	// Token: 0x06001668 RID: 5736 RVA: 0x0007BD80 File Offset: 0x00079F80
	[Token(Token = "0x6001668")]
	[Address(RVA = "0x4A56D0", Offset = "0x4A3CD0", VA = "0x1804A56D0")]
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

	// Token: 0x06001669 RID: 5737 RVA: 0x0007BEAC File Offset: 0x0007A0AC
	[Token(Token = "0x6001669")]
	[Address(RVA = "0x4A5B50", Offset = "0x4A4150", VA = "0x1804A5B50")]
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

	// Token: 0x0600166A RID: 5738 RVA: 0x0007BF20 File Offset: 0x0007A120
	[Token(Token = "0x600166A")]
	[Address(RVA = "0x4A5380", Offset = "0x4A3980", VA = "0x1804A5380")]
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

	// Token: 0x0600166B RID: 5739 RVA: 0x0007BF90 File Offset: 0x0007A190
	[Token(Token = "0x600166B")]
	[Address(RVA = "0x4A5E90", Offset = "0x4A4490", VA = "0x1804A5E90")]
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

	// Token: 0x0600166C RID: 5740 RVA: 0x0007C004 File Offset: 0x0007A204
	[Token(Token = "0x600166C")]
	[Address(RVA = "0x4A5170", Offset = "0x4A3770", VA = "0x1804A5170")]
	public static void PrintTreeExample()
	{
		Debug.Log("\n=== 示例5：打印融合树 ===");
		PlantMixTreeManager.PrintTree(PlantType.Peashooter);
	}

	// Token: 0x0600166D RID: 5741 RVA: 0x0007C024 File Offset: 0x0007A224
	[Token(Token = "0x600166D")]
	[Address(RVA = "0x4A51D0", Offset = "0x4A37D0", VA = "0x1804A51D0")]
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

	// Token: 0x0600166E RID: 5742 RVA: 0x0007C094 File Offset: 0x0007A294
	[Token(Token = "0x600166E")]
	[Address(RVA = "0x4A4930", Offset = "0x4A2F30", VA = "0x1804A4930")]
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

	// Token: 0x0600166F RID: 5743 RVA: 0x0007C194 File Offset: 0x0007A394
	[Token(Token = "0x600166F")]
	[Address(RVA = "0x4A43E0", Offset = "0x4A29E0", VA = "0x1804A43E0")]
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

	// Token: 0x06001670 RID: 5744 RVA: 0x0007C1F4 File Offset: 0x0007A3F4
	[Token(Token = "0x6001670")]
	[Address(RVA = "0x4A4CB0", Offset = "0x4A32B0", VA = "0x1804A4CB0")]
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

	// Token: 0x06001671 RID: 5745 RVA: 0x0007C304 File Offset: 0x0007A504
	[Token(Token = "0x6001671")]
	[Address(RVA = "0x4A4590", Offset = "0x4A2B90", VA = "0x1804A4590")]
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

	// Token: 0x06001672 RID: 5746 RVA: 0x0007C3FC File Offset: 0x0007A5FC
	[Token(Token = "0x6001672")]
	[Address(RVA = "0x4A5E70", Offset = "0x4A4470", VA = "0x1804A5E70")]
	[ProButton]
	public void RunAllExamples()
	{
		PlantMixTreeManager.PrintAllStatistics();
		PlantMixTreeManagerExample.QueryParents();
	}

	// Token: 0x06001673 RID: 5747 RVA: 0x0007C418 File Offset: 0x0007A618
	[Token(Token = "0x6001673")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public PlantMixTreeManagerExample()
	{
	}
}
