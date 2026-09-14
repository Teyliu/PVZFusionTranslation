using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004A2 RID: 1186
[Token(Token = "0x20004A2")]
public class PlantMixTreeManager
{
	// Token: 0x1700011C RID: 284
	// (get) Token: 0x06001647 RID: 5703 RVA: 0x0007B234 File Offset: 0x00079434
	// (set) Token: 0x06001648 RID: 5704 RVA: 0x0007B248 File Offset: 0x00079448
	[Token(Token = "0x1700011C")]
	public static Dictionary<PlantType, PlantMixTreeNode> PlantMixTrees
	{
		[Token(Token = "0x6001647")]
		[Address(RVA = "0x4A9220", Offset = "0x4A7820", VA = "0x1804A9220")]
		get;
		[Token(Token = "0x6001648")]
		[Address(RVA = "0x4A9340", Offset = "0x4A7940", VA = "0x1804A9340")]
		private set;
	}

	// Token: 0x1700011D RID: 285
	// (get) Token: 0x06001649 RID: 5705 RVA: 0x0007B25C File Offset: 0x0007945C
	// (set) Token: 0x0600164A RID: 5706 RVA: 0x0007B270 File Offset: 0x00079470
	[Token(Token = "0x1700011D")]
	public static Dictionary<PlantType, List<PlantMixTreeManager.MixParentInfo>> ChildToParents
	{
		[Token(Token = "0x6001649")]
		[Address(RVA = "0x4A91A0", Offset = "0x4A77A0", VA = "0x1804A91A0")]
		get;
		[Token(Token = "0x600164A")]
		[Address(RVA = "0x4A92A0", Offset = "0x4A78A0", VA = "0x1804A92A0")]
		private set;
	}

	// Token: 0x1700011E RID: 286
	// (get) Token: 0x0600164B RID: 5707 RVA: 0x0007B284 File Offset: 0x00079484
	// (set) Token: 0x0600164C RID: 5708 RVA: 0x0007B298 File Offset: 0x00079498
	[Token(Token = "0x1700011E")]
	public static bool IsInitialized
	{
		[Token(Token = "0x600164B")]
		[Address(RVA = "0x4A91E0", Offset = "0x4A77E0", VA = "0x1804A91E0")]
		get;
		[Token(Token = "0x600164C")]
		[Address(RVA = "0x4A9300", Offset = "0x4A7900", VA = "0x1804A9300")]
		private set;
	}

	// Token: 0x1700011F RID: 287
	// (get) Token: 0x0600164D RID: 5709 RVA: 0x0007B2AC File Offset: 0x000794AC
	// (set) Token: 0x0600164E RID: 5710 RVA: 0x0007B2C0 File Offset: 0x000794C0
	[Token(Token = "0x1700011F")]
	public static PlantMixTreeManager.MixTreeStatistics Statistics
	{
		[Token(Token = "0x600164D")]
		[Address(RVA = "0x4A9260", Offset = "0x4A7860", VA = "0x1804A9260")]
		get;
		[Token(Token = "0x600164E")]
		[Address(RVA = "0x4A93A0", Offset = "0x4A79A0", VA = "0x1804A93A0")]
		private set;
	}

	// Token: 0x0600164F RID: 5711 RVA: 0x0007B2D4 File Offset: 0x000794D4
	[Token(Token = "0x600164F")]
	[Address(RVA = "0x4A85F0", Offset = "0x4A6BF0", VA = "0x1804A85F0")]
	public static void Init()
	{
		PlantMixTreeManager.<PlantMixTrees>k__BackingField = new Dictionary();
		PlantMixTreeManager.<ChildToParents>k__BackingField = new Dictionary();
		PlantMixTreeManager.<Statistics>k__BackingField = new PlantMixTreeManager.MixTreeStatistics();
		Debug.Log("[PlantMixTreeManager] 开始初始化融合树...");
		PlantMixTreeManager.BuildMixRelations();
		PlantMixTreeManager.BuildAllTrees();
		PlantMixTreeManager.CalculateStatistics();
		Debug.Log("[PlantMixTreeManager] 融合树初始化完成！");
		Debug.Log(PlantMixTreeManager.<Statistics>k__BackingField.ToString());
	}

	// Token: 0x06001650 RID: 5712 RVA: 0x0007B34C File Offset: 0x0007954C
	[Token(Token = "0x6001650")]
	[Address(RVA = "0x4A62E0", Offset = "0x4A48E0", VA = "0x1804A62E0")]
	private static void BuildMixRelations()
	{
		Dictionary<ValueTuple<PlantType, PlantType>, PlantType> recipes;
		ulong num;
		do
		{
			recipes = MixData._recipes;
			bool flag;
			if (flag)
			{
				Dictionary<PlantType, PlantMixTreeNode> dictionary = PlantMixTreeManager.<PlantMixTrees>k__BackingField;
				PlantMixTreeNode plantMixTreeNode;
				Dictionary<PlantType, PlantType> <Recipes>k__BackingField = plantMixTreeNode.<Recipes>k__BackingField;
				Dictionary<PlantType, PlantMixTreeNode> dictionary2 = PlantMixTreeManager.<PlantMixTrees>k__BackingField;
				PlantMixTreeNode plantMixTreeNode2;
				Dictionary<PlantType, PlantType> <Recipes>k__BackingField2 = plantMixTreeNode2.<Recipes>k__BackingField;
				Dictionary<PlantType, List<PlantMixTreeManager.MixParentInfo>> dictionary3 = PlantMixTreeManager.<ChildToParents>k__BackingField;
				bool flag2;
				if (!flag2)
				{
					List<PlantMixTreeManager.MixParentInfo> list = new List();
				}
			}
		}
		while (num != (ulong)0L);
		PlantMixTreeManager.MixTreeStatistics mixTreeStatistics = PlantMixTreeManager.<Statistics>k__BackingField;
		int count = recipes.Count;
		mixTreeStatistics.TotalMixRecipes = count;
	}

	// Token: 0x06001651 RID: 5713 RVA: 0x0007B3FC File Offset: 0x000795FC
	[Token(Token = "0x6001651")]
	[Address(RVA = "0x4A71A0", Offset = "0x4A57A0", VA = "0x1804A71A0")]
	private static void EnsureNodeExists(PlantType plantType)
	{
		Dictionary<PlantType, PlantMixTreeNode> dictionary = PlantMixTreeManager.<PlantMixTrees>k__BackingField;
		bool flag;
		if (!flag)
		{
			Dictionary<PlantType, PlantMixTreeNode> dictionary2 = PlantMixTreeManager.<PlantMixTrees>k__BackingField;
			PlantMixTreeNode plantMixTreeNode;
			plantMixTreeNode.<PlantType>k__BackingField = plantType;
			List<PlantMixTreeNode> list = new List();
			plantMixTreeNode.<DirectChildren>k__BackingField = list;
			List<PlantMixTreeNode> list2 = new List();
			plantMixTreeNode.<AllDescendants>k__BackingField = list2;
			Dictionary<PlantType, PlantType> dictionary3 = new Dictionary();
			plantMixTreeNode.<Recipes>k__BackingField = dictionary3;
			plantMixTreeNode.<Depth>k__BackingField = (int)((ulong)0L);
			bool flag2;
			plantMixTreeNode.<IsBasicPlant>k__BackingField = flag2;
		}
	}

	// Token: 0x06001652 RID: 5714 RVA: 0x0007B470 File Offset: 0x00079670
	[Token(Token = "0x6001652")]
	[Address(RVA = "0x4A6130", Offset = "0x4A4730", VA = "0x1804A6130")]
	private static void BuildAllTrees()
	{
		ulong num2;
		do
		{
			int num = 0;
			Dictionary<PlantType, PlantMixTreeNode>.KeyCollection keys = PlantMixTreeManager.<PlantMixTrees>k__BackingField.Keys;
			bool flag;
			if (flag)
			{
				PlantMixTreeManager.BuildTreeIterative(PlantMixTreeManager.<PlantMixTrees>k__BackingField[num]);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06001653 RID: 5715 RVA: 0x0007B4B0 File Offset: 0x000796B0
	[Token(Token = "0x6001653")]
	[Address(RVA = "0x4A6760", Offset = "0x4A4D60", VA = "0x1804A6760")]
	private static void BuildTreeIterative(PlantMixTreeNode rootNode)
	{
		int num;
		List<PlantMixTreeNode> list;
		do
		{
			num = 0;
			Queue<PlantMixTreeNode> queue = new Queue();
			HashSet<PlantType> hashSet = new HashSet();
			list = new List();
			queue.Enqueue(rootNode);
			PlantType <PlantType>k__BackingField = rootNode.<PlantType>k__BackingField;
			bool flag = hashSet.Add(<PlantType>k__BackingField);
			PlantMixTreeNode plantMixTreeNode = queue.Dequeue();
			int size = list._size;
			plantMixTreeNode.<AllDescendants>k__BackingField = plantMixTreeNode;
			Dictionary<PlantType, PlantType> <Recipes>k__BackingField = plantMixTreeNode.<Recipes>k__BackingField;
			bool flag2;
			if (flag2)
			{
				bool flag3;
				while (!flag3)
				{
				}
				PlantMixTreeNode plantMixTreeNode2 = plantMixTreeNode.<DirectChildren>k__BackingField[num];
				num++;
				PlantMixTreeNode plantMixTreeNode3 = plantMixTreeNode.<AllDescendants>k__BackingField[num];
				num++;
				bool flag4;
				while (flag4)
				{
				}
				queue.Enqueue(num);
			}
		}
		while (num != 0);
		int num2 = 0;
		int size2 = list._size;
		PlantMixTreeNode plantMixTreeNode4 = list[size2];
		PlantMixTreeNode plantMixTreeNode5 = plantMixTreeNode4.<DirectChildren>k__BackingField[num2].<AllDescendants>k__BackingField[num2];
		PlantMixTreeNode plantMixTreeNode6 = plantMixTreeNode4.<AllDescendants>k__BackingField[num2];
		PlantType <PlantType>k__BackingField2 = plantMixTreeNode5.<PlantType>k__BackingField;
		if (plantMixTreeNode6.<PlantType>k__BackingField != <PlantType>k__BackingField2)
		{
			num2++;
		}
		num2++;
		num2++;
	}

	// Token: 0x06001654 RID: 5716 RVA: 0x0007B5F0 File Offset: 0x000797F0
	[Token(Token = "0x6001654")]
	[Address(RVA = "0x4A6070", Offset = "0x4A4670", VA = "0x1804A6070")]
	private static void AddDescendantIfNeeded(PlantMixTreeNode parent, PlantMixTreeNode descendant)
	{
		int num = 0;
		PlantMixTreeNode plantMixTreeNode = parent.<AllDescendants>k__BackingField[num];
		PlantType <PlantType>k__BackingField = descendant.<PlantType>k__BackingField;
		if (plantMixTreeNode.<PlantType>k__BackingField != <PlantType>k__BackingField)
		{
			num++;
		}
	}

	// Token: 0x06001655 RID: 5717 RVA: 0x0007B628 File Offset: 0x00079828
	[Token(Token = "0x6001655")]
	[Address(RVA = "0x4A6D60", Offset = "0x4A5360", VA = "0x1804A6D60")]
	private static void CalculateStatistics()
	{
		int num;
		do
		{
			PlantMixTreeManager.MixTreeStatistics mixTreeStatistics = PlantMixTreeManager.<Statistics>k__BackingField;
			int count = PlantMixTreeManager.<PlantMixTrees>k__BackingField.Count;
			mixTreeStatistics.TotalPlantTypes = count;
			PlantMixTreeManager.MixTreeStatistics mixTreeStatistics2 = PlantMixTreeManager.<Statistics>k__BackingField;
			num = 0;
			mixTreeStatistics2.MaxTreeDepth = num;
			PlantMixTreeManager.<Statistics>k__BackingField.MaxChildrenCount = num;
			PlantMixTreeManager.<Statistics>k__BackingField.BasicPlantCount = num;
			Dictionary<PlantType, PlantMixTreeNode> dictionary = PlantMixTreeManager.<PlantMixTrees>k__BackingField;
			bool flag;
			if (flag)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x06001656 RID: 5718 RVA: 0x0007B6BC File Offset: 0x000798BC
	[Token(Token = "0x6001656")]
	[Address(RVA = "0x4A84F0", Offset = "0x4A6AF0", VA = "0x1804A84F0")]
	public static PlantMixTreeNode GetTree(PlantType plantType)
	{
		Dictionary<PlantType, PlantMixTreeNode> dictionary = PlantMixTreeManager.<PlantMixTrees>k__BackingField;
		Debug.LogWarning("[PlantMixTreeManager] 未初始化，请先调用 Init()");
		throw new NullReferenceException();
	}

	// Token: 0x06001657 RID: 5719 RVA: 0x0007B6E4 File Offset: 0x000798E4
	[Token(Token = "0x6001657")]
	[Address(RVA = "0x4A7CE0", Offset = "0x4A62E0", VA = "0x1804A7CE0")]
	public static List<PlantType> GetDirectMixablePlants(PlantType plantType)
	{
		PlantMixTreeNode plantMixTreeNode;
		if (plantMixTreeNode != 0)
		{
			List<PlantType> list = new List(plantMixTreeNode.<DirectChildren>k__BackingField._size);
			int num = 0;
			PlantMixTreeNode plantMixTreeNode2 = plantMixTreeNode.<DirectChildren>k__BackingField[num];
			PlantType <PlantType>k__BackingField = plantMixTreeNode2.<PlantType>k__BackingField;
			int size = list._size;
			num++;
			list._size = plantMixTreeNode2;
			num++;
			return list;
		}
		return new List();
	}

	// Token: 0x06001658 RID: 5720 RVA: 0x0007B754 File Offset: 0x00079954
	[Token(Token = "0x6001658")]
	[Address(RVA = "0x4A7B50", Offset = "0x4A6150", VA = "0x1804A7B50")]
	public static List<PlantType> GetAllMixablePlants(PlantType plantType)
	{
		PlantMixTreeNode plantMixTreeNode;
		if (plantMixTreeNode != 0)
		{
			List<PlantType> list = new List(plantMixTreeNode.<AllDescendants>k__BackingField._size);
			int num = 0;
			PlantMixTreeNode plantMixTreeNode2 = plantMixTreeNode.<AllDescendants>k__BackingField[num];
			PlantType <PlantType>k__BackingField = plantMixTreeNode2.<PlantType>k__BackingField;
			int size = list._size;
			num++;
			list._size = plantMixTreeNode2;
			num++;
			return list;
		}
		return new List();
	}

	// Token: 0x06001659 RID: 5721 RVA: 0x0007B7C4 File Offset: 0x000799C4
	[Token(Token = "0x6001659")]
	[Address(RVA = "0x4A7890", Offset = "0x4A5E90", VA = "0x1804A7890")]
	public static List<PlantType> GetAllMixablePlantsCombined(PlantType plantType)
	{
		PlantMixTreeNode plantMixTreeNode;
		if (plantMixTreeNode != 0)
		{
			List<PlantType> list = new List();
			HashSet<PlantType> hashSet = new HashSet();
			List<PlantMixTreeNode> <DirectChildren>k__BackingField = plantMixTreeNode.<DirectChildren>k__BackingField;
			int num = 0;
			PlantType <PlantType>k__BackingField = <DirectChildren>k__BackingField[num].<PlantType>k__BackingField;
			bool flag;
			if (!flag)
			{
			}
			num++;
			PlantType <PlantType>k__BackingField2 = plantMixTreeNode.<AllDescendants>k__BackingField[num].<PlantType>k__BackingField;
			bool flag2;
			if (!flag2)
			{
			}
			num++;
			int size = list._size;
			list._size = num;
			return list;
		}
		return new List();
	}

	// Token: 0x0600165A RID: 5722 RVA: 0x0007B850 File Offset: 0x00079A50
	[Token(Token = "0x600165A")]
	[Address(RVA = "0x4A70D0", Offset = "0x4A56D0", VA = "0x1804A70D0")]
	public static bool CanMixInto(PlantType plantA, PlantType plantB)
	{
		PlantMixTreeNode tree = PlantMixTreeManager.GetTree(plantA);
		if (tree != 0)
		{
			List<PlantMixTreeNode> <AllDescendants>k__BackingField = tree.<AllDescendants>k__BackingField;
			int num = 0;
			if (tree.<AllDescendants>k__BackingField[num].<PlantType>k__BackingField != plantB)
			{
				List<PlantMixTreeNode> <AllDescendants>k__BackingField2 = tree.<AllDescendants>k__BackingField;
				num++;
			}
			return true;
		}
		throw new NullReferenceException();
	}

	// Token: 0x0600165B RID: 5723 RVA: 0x0007B8A0 File Offset: 0x00079AA0
	[Token(Token = "0x600165B")]
	[Address(RVA = "0x4A9110", Offset = "0x4A7710", VA = "0x1804A9110")]
	public static bool TryGetMixResult(PlantType plantA, PlantType plantB, [Out] PlantType result)
	{
		PlantMixTreeNode tree = PlantMixTreeManager.GetTree(plantA);
		if (tree != 0)
		{
			Dictionary<PlantType, PlantType> <Recipes>k__BackingField = tree.<Recipes>k__BackingField;
			bool flag;
			return flag;
		}
		throw new NullReferenceException();
	}

	// Token: 0x0600165C RID: 5724 RVA: 0x0007B8CC File Offset: 0x00079ACC
	[Token(Token = "0x600165C")]
	[Address(RVA = "0x4A8340", Offset = "0x4A6940", VA = "0x1804A8340")]
	public static List<PlantMixTreeManager.MixParentInfo> GetParents(PlantType plantType)
	{
		Dictionary<PlantType, List<PlantMixTreeManager.MixParentInfo>> dictionary = PlantMixTreeManager.<ChildToParents>k__BackingField;
		bool flag;
		if (flag)
		{
			Debug.LogWarning("[PlantMixTreeManager] 未初始化，请先调用 Init()");
		}
		return new List();
	}

	// Token: 0x0600165D RID: 5725 RVA: 0x0007B904 File Offset: 0x00079B04
	[Token(Token = "0x600165D")]
	[Address(RVA = "0x4A8480", Offset = "0x4A6A80", VA = "0x1804A8480")]
	public static Dictionary<PlantType, PlantType> GetRecipes(PlantType plantType)
	{
		PlantMixTreeNode plantMixTreeNode;
		if (plantMixTreeNode != 0)
		{
			return plantMixTreeNode.<Recipes>k__BackingField;
		}
		return new Dictionary();
	}

	// Token: 0x0600165E RID: 5726 RVA: 0x0007B930 File Offset: 0x00079B30
	[Token(Token = "0x600165E")]
	[Address(RVA = "0x4A8F20", Offset = "0x4A7520", VA = "0x1804A8F20")]
	public static void PrintTree(PlantType plantType)
	{
		PlantMixTreeNode plantMixTreeNode;
		if (plantMixTreeNode != 0)
		{
			Debug.Log(string.Format("=== {0} 融合树 ===", plantMixTreeNode));
			int size = plantMixTreeNode.<DirectChildren>k__BackingField._size;
			Debug.Log(string.Format("直接融合: {0} 种", size));
			int size2 = plantMixTreeNode.<AllDescendants>k__BackingField._size;
			Debug.Log(string.Format("所有后代: {0} 种", size2));
			plantMixTreeNode.PrintTree();
			return;
		}
		Debug.Log(string.Format("[PlantMixTreeManager] 未找到植物 {0} 的融合树", plantMixTreeNode));
	}

	// Token: 0x0600165F RID: 5727 RVA: 0x0007B9AC File Offset: 0x00079BAC
	[Token(Token = "0x600165F")]
	[Address(RVA = "0x4A88D0", Offset = "0x4A6ED0", VA = "0x1804A88D0")]
	public static void PrintAllStatistics()
	{
		List<ValueTuple<PlantType, int>> list;
		int num;
		do
		{
			Debug.Log("=== 植物融合树统计 ===");
			Debug.Log(PlantMixTreeManager.<Statistics>k__BackingField.ToString());
			list = new List(10);
			Dictionary<PlantType, PlantMixTreeNode> dictionary = PlantMixTreeManager.<PlantMixTrees>k__BackingField;
			num = 0;
			bool flag;
			if (flag)
			{
				ValueTuple<PlantType, int> valueTuple = list[1];
				ValueTuple<PlantType, int> valueTuple2 = list[num];
				ValueTuple<PlantType, int> valueTuple3 = list[num];
				list[num] = num;
			}
		}
		while (num != 0);
		int num2 = 0;
		int size = list._size;
		if (num2 < size)
		{
			ValueTuple<PlantType, int> valueTuple4 = list[1];
			ValueTuple<PlantType, int> valueTuple5 = list[num2];
			ValueTuple<PlantType, int> valueTuple6 = list[num2];
			ValueTuple<PlantType, int> valueTuple7 = list[1];
			list[num2] = valueTuple7;
			list[1] = valueTuple6;
			num2++;
		}
		Debug.Log("\n融合能力最强的10个植物:");
		ValueTuple<PlantType, int> valueTuple8 = list[num2];
		int num3;
		Debug.Log(string.Format("{0}. {1}: {2} 种可融合植物", num3, num3, num3));
		num2++;
		Debug.LogWarning("[PlantMixTreeManager] 未初始化，请先调用 Init()");
	}

	// Token: 0x06001660 RID: 5728 RVA: 0x0007BAB4 File Offset: 0x00079CB4
	[Token(Token = "0x6001660")]
	[Address(RVA = "0x4A76D0", Offset = "0x4A5CD0", VA = "0x1804A76D0")]
	public static string ExportthistFormat(PlantType rootPlant)
	{
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
			return stringBuilder.ToString();
		}
		return "";
	}

	// Token: 0x06001661 RID: 5729 RVA: 0x0007BB34 File Offset: 0x00079D34
	[Token(Token = "0x6001661")]
	[Address(RVA = "0x4A7390", Offset = "0x4A5990", VA = "0x1804A7390")]
	private static void ExportNodethist(PlantMixTreeNode rootNode, StringBuilder dot)
	{
		ulong num2;
		do
		{
			int num = 0;
			Queue<PlantMixTreeNode> queue = new Queue();
			HashSet<PlantType> hashSet = new HashSet();
			queue.Enqueue(rootNode);
			PlantType <PlantType>k__BackingField = rootNode.<PlantType>k__BackingField;
			bool flag = hashSet.Add(<PlantType>k__BackingField);
			PlantMixTreeNode plantMixTreeNode = queue.Dequeue();
			List<PlantMixTreeNode> <DirectChildren>k__BackingField = plantMixTreeNode.<DirectChildren>k__BackingField;
			bool flag2;
			if (flag2)
			{
				PlantType <PlantType>k__BackingField2 = plantMixTreeNode.<PlantType>k__BackingField;
				string text = string.Format("  \"{0}\" -> \"{1}\";", <PlantType>k__BackingField2, <PlantType>k__BackingField2);
				StringBuilder stringBuilder = dot.AppendLine(text);
				bool flag3;
				while (flag3)
				{
				}
				queue.Enqueue(num);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06001662 RID: 5730 RVA: 0x0007BBC4 File Offset: 0x00079DC4
	[Token(Token = "0x6001662")]
	[Address(RVA = "0x4A7E70", Offset = "0x4A6470", VA = "0x1804A7E70")]
	public static List<List<PlantType>> GetMixPaths(PlantType fromPlant, PlantType toPlant)
	{
		List<List<PlantType>> list = new List();
		PlantMixTreeNode plantMixTreeNode;
		if (plantMixTreeNode != 0)
		{
			Stack<ValueTuple<PlantMixTreeNode, List<PlantType>, HashSet<PlantType>>> stack = new Stack();
			HashSet<PlantType> hashSet = new HashSet();
			List<PlantType> list2 = new List();
			int size = list2._size;
			int num = 0;
			stack.Push(num);
			int size2 = list2._size;
			PlantMixTreeNode plantMixTreeNode2;
			PlantType <PlantType>k__BackingField = plantMixTreeNode2.<PlantType>k__BackingField;
			bool flag;
			if (!flag)
			{
				PlantType <PlantType>k__BackingField2 = plantMixTreeNode2.<PlantType>k__BackingField;
				HashSet<PlantType> hashSet2;
				bool flag2 = hashSet2.Add(<PlantType>k__BackingField2);
				int num2 = 0;
				stack.Push(num2);
			}
		}
		return list;
	}

	// Token: 0x06001663 RID: 5731 RVA: 0x0007BC54 File Offset: 0x00079E54
	[Token(Token = "0x6001663")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public PlantMixTreeManager()
	{
	}

	// Token: 0x020004A3 RID: 1187
	[Token(Token = "0x20004A3")]
	public struct MixParentInfo
	{
		// Token: 0x06001664 RID: 5732 RVA: 0x0007BC68 File Offset: 0x00079E68
		[Token(Token = "0x6001664")]
		[Address(RVA = "0x4A3E80", Offset = "0x4A2480", VA = "0x1804A3E80")]
		public MixParentInfo(PlantType parentA, PlantType parentB, PlantType result)
		{
			this.ParentA = parentA;
			this.ParentB = parentB;
			this.Result = result;
		}

		// Token: 0x04000D7F RID: 3455
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000D7F")]
		public PlantType ParentA;

		// Token: 0x04000D80 RID: 3456
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000D80")]
		public PlantType ParentB;

		// Token: 0x04000D81 RID: 3457
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000D81")]
		public PlantType Result;
	}

	// Token: 0x020004A4 RID: 1188
	[Token(Token = "0x20004A4")]
	public class MixTreeStatistics
	{
		// Token: 0x06001665 RID: 5733 RVA: 0x0007BC8C File Offset: 0x00079E8C
		[Token(Token = "0x6001665")]
		[Address(RVA = "0x4A3E90", Offset = "0x4A2490", VA = "0x1804A3E90", Slot = "3")]
		public override string ToString()
		{
			string[] array = new string[6];
			array[0] = "融合树统计:\n";
			int totalPlantTypes = this.TotalPlantTypes;
			string text = string.Format("  植物类型总数: {0}\n", array);
			array[1] = text;
			int totalMixRecipes = this.TotalMixRecipes;
			string text2 = string.Format("  融合配方总数: {0}\n", totalMixRecipes);
			array[2] = text2;
			int maxTreeDepth = this.MaxTreeDepth;
			string text3 = string.Format("  最大树深度: {0}\n", maxTreeDepth);
			array[3] = text3;
			PlantType plantWithMostChildren = this.PlantWithMostChildren;
			int maxChildrenCount = this.MaxChildrenCount;
			string text4 = string.Format("  最多子植物的植物: {0} ({1}个)\n", plantWithMostChildren, plantWithMostChildren);
			array[4] = text4;
			int basicPlantCount = this.BasicPlantCount;
			string text5 = string.Format("  基础植物数量: {0}", basicPlantCount);
			array[5] = text5;
			return string.Concat(array);
		}

		// Token: 0x06001666 RID: 5734 RVA: 0x0007BD58 File Offset: 0x00079F58
		[Token(Token = "0x6001666")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public MixTreeStatistics()
		{
		}

		// Token: 0x04000D82 RID: 3458
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000D82")]
		public int TotalPlantTypes;

		// Token: 0x04000D83 RID: 3459
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000D83")]
		public int TotalMixRecipes;

		// Token: 0x04000D84 RID: 3460
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000D84")]
		public int MaxTreeDepth;

		// Token: 0x04000D85 RID: 3461
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000D85")]
		public PlantType PlantWithMostChildren;

		// Token: 0x04000D86 RID: 3462
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000D86")]
		public int MaxChildrenCount;

		// Token: 0x04000D87 RID: 3463
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000D87")]
		public int BasicPlantCount;
	}
}
