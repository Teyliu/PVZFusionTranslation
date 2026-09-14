using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;

// Token: 0x020004C4 RID: 1220
[Token(Token = "0x20004C4")]
public class PlantMixTreeManager
{
	// Token: 0x17000162 RID: 354
	// (get) Token: 0x060016E7 RID: 5863 RVA: 0x0007DCB0 File Offset: 0x0007BEB0
	// (set) Token: 0x060016E8 RID: 5864 RVA: 0x0007DCC4 File Offset: 0x0007BEC4
	[Token(Token = "0x17000162")]
	public static Dictionary<PlantType, PlantMixTreeNode> PlantMixTrees
	{
		[Token(Token = "0x60016E7")]
		[Address(RVA = "0x514E50", Offset = "0x513450", VA = "0x180514E50")]
		get;
		[Token(Token = "0x60016E8")]
		[Address(RVA = "0x514F70", Offset = "0x513570", VA = "0x180514F70")]
		private set;
	}

	// Token: 0x17000163 RID: 355
	// (get) Token: 0x060016E9 RID: 5865 RVA: 0x0007DCD8 File Offset: 0x0007BED8
	// (set) Token: 0x060016EA RID: 5866 RVA: 0x0007DCEC File Offset: 0x0007BEEC
	[Token(Token = "0x17000163")]
	public static Dictionary<PlantType, List<PlantMixTreeManager.MixParentInfo>> ChildToParents
	{
		[Token(Token = "0x60016E9")]
		[Address(RVA = "0x514DD0", Offset = "0x5133D0", VA = "0x180514DD0")]
		get;
		[Token(Token = "0x60016EA")]
		[Address(RVA = "0x514ED0", Offset = "0x5134D0", VA = "0x180514ED0")]
		private set;
	}

	// Token: 0x17000164 RID: 356
	// (get) Token: 0x060016EB RID: 5867 RVA: 0x0007DD00 File Offset: 0x0007BF00
	// (set) Token: 0x060016EC RID: 5868 RVA: 0x0007DD14 File Offset: 0x0007BF14
	[Token(Token = "0x17000164")]
	public static bool IsInitialized
	{
		[Token(Token = "0x60016EB")]
		[Address(RVA = "0x514E10", Offset = "0x513410", VA = "0x180514E10")]
		get;
		[Token(Token = "0x60016EC")]
		[Address(RVA = "0x514F30", Offset = "0x513530", VA = "0x180514F30")]
		private set;
	}

	// Token: 0x17000165 RID: 357
	// (get) Token: 0x060016ED RID: 5869 RVA: 0x0007DD28 File Offset: 0x0007BF28
	// (set) Token: 0x060016EE RID: 5870 RVA: 0x0007DD3C File Offset: 0x0007BF3C
	[Token(Token = "0x17000165")]
	public static PlantMixTreeManager.MixTreeStatistics Statistics
	{
		[Token(Token = "0x60016ED")]
		[Address(RVA = "0x514E90", Offset = "0x513490", VA = "0x180514E90")]
		get;
		[Token(Token = "0x60016EE")]
		[Address(RVA = "0x514FD0", Offset = "0x5135D0", VA = "0x180514FD0")]
		private set;
	}

	// Token: 0x060016EF RID: 5871 RVA: 0x0007DD50 File Offset: 0x0007BF50
	[Token(Token = "0x60016EF")]
	[Address(RVA = "0x514220", Offset = "0x512820", VA = "0x180514220")]
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

	// Token: 0x060016F0 RID: 5872 RVA: 0x0007DDC8 File Offset: 0x0007BFC8
	[Token(Token = "0x60016F0")]
	[Address(RVA = "0x511D80", Offset = "0x510380", VA = "0x180511D80")]
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

	// Token: 0x060016F1 RID: 5873 RVA: 0x0007DE78 File Offset: 0x0007C078
	[Token(Token = "0x60016F1")]
	[Address(RVA = "0x512C40", Offset = "0x511240", VA = "0x180512C40")]
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

	// Token: 0x060016F2 RID: 5874 RVA: 0x0007DEEC File Offset: 0x0007C0EC
	[Token(Token = "0x60016F2")]
	[Address(RVA = "0x511BD0", Offset = "0x5101D0", VA = "0x180511BD0")]
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

	// Token: 0x060016F3 RID: 5875 RVA: 0x0007DF2C File Offset: 0x0007C12C
	[Token(Token = "0x60016F3")]
	[Address(RVA = "0x512200", Offset = "0x510800", VA = "0x180512200")]
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

	// Token: 0x060016F4 RID: 5876 RVA: 0x0007E06C File Offset: 0x0007C26C
	[Token(Token = "0x60016F4")]
	[Address(RVA = "0x511B10", Offset = "0x510110", VA = "0x180511B10")]
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

	// Token: 0x060016F5 RID: 5877 RVA: 0x0007E0A4 File Offset: 0x0007C2A4
	[Token(Token = "0x60016F5")]
	[Address(RVA = "0x512800", Offset = "0x510E00", VA = "0x180512800")]
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

	// Token: 0x060016F6 RID: 5878 RVA: 0x0007E138 File Offset: 0x0007C338
	[Token(Token = "0x60016F6")]
	[Address(RVA = "0x514120", Offset = "0x512720", VA = "0x180514120")]
	public static PlantMixTreeNode GetTree(PlantType plantType)
	{
		Dictionary<PlantType, PlantMixTreeNode> dictionary = PlantMixTreeManager.<PlantMixTrees>k__BackingField;
		Debug.LogWarning("[PlantMixTreeManager] 未初始化，请先调用 Init()");
		throw new NullReferenceException();
	}

	// Token: 0x060016F7 RID: 5879 RVA: 0x0007E160 File Offset: 0x0007C360
	[Token(Token = "0x60016F7")]
	[Address(RVA = "0x513910", Offset = "0x511F10", VA = "0x180513910")]
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

	// Token: 0x060016F8 RID: 5880 RVA: 0x0007E1D0 File Offset: 0x0007C3D0
	[Token(Token = "0x60016F8")]
	[Address(RVA = "0x513780", Offset = "0x511D80", VA = "0x180513780")]
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

	// Token: 0x060016F9 RID: 5881 RVA: 0x0007E240 File Offset: 0x0007C440
	[Token(Token = "0x60016F9")]
	[Address(RVA = "0x513330", Offset = "0x511930", VA = "0x180513330")]
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

	// Token: 0x060016FA RID: 5882 RVA: 0x0007E2CC File Offset: 0x0007C4CC
	[Token(Token = "0x60016FA")]
	[Address(RVA = "0x5135F0", Offset = "0x511BF0", VA = "0x1805135F0")]
	public static List<PlantType> GetAllMixablePlantsCombined(List<PlantType> plants)
	{
		HashSet<PlantType> hashSet;
		ulong num2;
		do
		{
			int num = 0;
			hashSet = new HashSet();
			bool flag;
			if (flag)
			{
				List<PlantType> allMixablePlantsCombined = PlantMixTreeManager.GetAllMixablePlantsCombined((PlantType)num);
				LinqUtility.AddRange<PlantType>(hashSet, allMixablePlantsCombined);
			}
		}
		while (num2 != (ulong)0L);
		return Enumerable.ToList<PlantType>(hashSet);
	}

	// Token: 0x060016FB RID: 5883 RVA: 0x0007E318 File Offset: 0x0007C518
	[Token(Token = "0x60016FB")]
	[Address(RVA = "0x512B70", Offset = "0x511170", VA = "0x180512B70")]
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

	// Token: 0x060016FC RID: 5884 RVA: 0x0007E368 File Offset: 0x0007C568
	[Token(Token = "0x60016FC")]
	[Address(RVA = "0x514D40", Offset = "0x513340", VA = "0x180514D40")]
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

	// Token: 0x060016FD RID: 5885 RVA: 0x0007E394 File Offset: 0x0007C594
	[Token(Token = "0x60016FD")]
	[Address(RVA = "0x513F70", Offset = "0x512570", VA = "0x180513F70")]
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

	// Token: 0x060016FE RID: 5886 RVA: 0x0007E3CC File Offset: 0x0007C5CC
	[Token(Token = "0x60016FE")]
	[Address(RVA = "0x5140B0", Offset = "0x5126B0", VA = "0x1805140B0")]
	public static Dictionary<PlantType, PlantType> GetRecipes(PlantType plantType)
	{
		PlantMixTreeNode plantMixTreeNode;
		if (plantMixTreeNode != 0)
		{
			return plantMixTreeNode.<Recipes>k__BackingField;
		}
		return new Dictionary();
	}

	// Token: 0x060016FF RID: 5887 RVA: 0x0007E3F8 File Offset: 0x0007C5F8
	[Token(Token = "0x60016FF")]
	[Address(RVA = "0x514B50", Offset = "0x513150", VA = "0x180514B50")]
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

	// Token: 0x06001700 RID: 5888 RVA: 0x0007E474 File Offset: 0x0007C674
	[Token(Token = "0x6001700")]
	[Address(RVA = "0x514500", Offset = "0x512B00", VA = "0x180514500")]
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

	// Token: 0x06001701 RID: 5889 RVA: 0x0007E57C File Offset: 0x0007C77C
	[Token(Token = "0x6001701")]
	[Address(RVA = "0x513170", Offset = "0x511770", VA = "0x180513170")]
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

	// Token: 0x06001702 RID: 5890 RVA: 0x0007E5FC File Offset: 0x0007C7FC
	[Token(Token = "0x6001702")]
	[Address(RVA = "0x512E30", Offset = "0x511430", VA = "0x180512E30")]
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

	// Token: 0x06001703 RID: 5891 RVA: 0x0007E68C File Offset: 0x0007C88C
	[Token(Token = "0x6001703")]
	[Address(RVA = "0x513AA0", Offset = "0x5120A0", VA = "0x180513AA0")]
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

	// Token: 0x06001704 RID: 5892 RVA: 0x0007E71C File Offset: 0x0007C91C
	[Token(Token = "0x6001704")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public PlantMixTreeManager()
	{
	}

	// Token: 0x020004C5 RID: 1221
	[Token(Token = "0x20004C5")]
	public struct MixParentInfo
	{
		// Token: 0x06001705 RID: 5893 RVA: 0x0007E730 File Offset: 0x0007C930
		[Token(Token = "0x6001705")]
		[Address(RVA = "0x50F920", Offset = "0x50DF20", VA = "0x18050F920")]
		public MixParentInfo(PlantType parentA, PlantType parentB, PlantType result)
		{
			this.ParentA = parentA;
			this.ParentB = parentB;
			this.Result = result;
		}

		// Token: 0x04000E18 RID: 3608
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E18")]
		public PlantType ParentA;

		// Token: 0x04000E19 RID: 3609
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000E19")]
		public PlantType ParentB;

		// Token: 0x04000E1A RID: 3610
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000E1A")]
		public PlantType Result;
	}

	// Token: 0x020004C6 RID: 1222
	[Token(Token = "0x20004C6")]
	public class MixTreeStatistics
	{
		// Token: 0x06001706 RID: 5894 RVA: 0x0007E754 File Offset: 0x0007C954
		[Token(Token = "0x6001706")]
		[Address(RVA = "0x50F930", Offset = "0x50DF30", VA = "0x18050F930", Slot = "3")]
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

		// Token: 0x06001707 RID: 5895 RVA: 0x0007E820 File Offset: 0x0007CA20
		[Token(Token = "0x6001707")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public MixTreeStatistics()
		{
		}

		// Token: 0x04000E1B RID: 3611
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000E1B")]
		public int TotalPlantTypes;

		// Token: 0x04000E1C RID: 3612
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000E1C")]
		public int TotalMixRecipes;

		// Token: 0x04000E1D RID: 3613
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000E1D")]
		public int MaxTreeDepth;

		// Token: 0x04000E1E RID: 3614
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000E1E")]
		public PlantType PlantWithMostChildren;

		// Token: 0x04000E1F RID: 3615
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000E1F")]
		public int MaxChildrenCount;

		// Token: 0x04000E20 RID: 3616
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000E20")]
		public int BasicPlantCount;
	}
}
