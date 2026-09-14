using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004C3 RID: 1219
[Token(Token = "0x20004C3")]
public class PlantMixTreeNode
{
	// Token: 0x1700015C RID: 348
	// (get) Token: 0x060016D5 RID: 5845 RVA: 0x0007D9CC File Offset: 0x0007BBCC
	// (set) Token: 0x060016D6 RID: 5846 RVA: 0x0007D9E0 File Offset: 0x0007BBE0
	[Token(Token = "0x1700015C")]
	public PlantType PlantType
	{
		[Token(Token = "0x60016D5")]
		[Address(RVA = "0x3E8430", Offset = "0x3E6A30", VA = "0x1803E8430")]
		get;
		[Token(Token = "0x60016D6")]
		[Address(RVA = "0x5159A0", Offset = "0x513FA0", VA = "0x1805159A0")]
		set;
	}

	// Token: 0x1700015D RID: 349
	// (get) Token: 0x060016D7 RID: 5847 RVA: 0x0007D9F4 File Offset: 0x0007BBF4
	// (set) Token: 0x060016D8 RID: 5848 RVA: 0x0007DA08 File Offset: 0x0007BC08
	[Token(Token = "0x1700015D")]
	public List<PlantMixTreeNode> DirectChildren
	{
		[Token(Token = "0x60016D7")]
		[Address(RVA = "0x3FDA60", Offset = "0x3FC060", VA = "0x1803FDA60")]
		get;
		[Token(Token = "0x60016D8")]
		[Address(RVA = "0x515980", Offset = "0x513F80", VA = "0x180515980")]
		set;
	}

	// Token: 0x1700015E RID: 350
	// (get) Token: 0x060016D9 RID: 5849 RVA: 0x0007DA1C File Offset: 0x0007BC1C
	// (set) Token: 0x060016DA RID: 5850 RVA: 0x0007DA30 File Offset: 0x0007BC30
	[Token(Token = "0x1700015E")]
	public List<PlantMixTreeNode> AllDescendants
	{
		[Token(Token = "0x60016D9")]
		[Address(RVA = "0x515920", Offset = "0x513F20", VA = "0x180515920")]
		get;
		[Token(Token = "0x60016DA")]
		[Address(RVA = "0x515960", Offset = "0x513F60", VA = "0x180515960")]
		set;
	}

	// Token: 0x1700015F RID: 351
	// (get) Token: 0x060016DB RID: 5851 RVA: 0x0007DA44 File Offset: 0x0007BC44
	// (set) Token: 0x060016DC RID: 5852 RVA: 0x0007DA58 File Offset: 0x0007BC58
	[Token(Token = "0x1700015F")]
	public Dictionary<PlantType, PlantType> Recipes
	{
		[Token(Token = "0x60016DB")]
		[Address(RVA = "0x515950", Offset = "0x513F50", VA = "0x180515950")]
		get;
		[Token(Token = "0x60016DC")]
		[Address(RVA = "0x5159B0", Offset = "0x513FB0", VA = "0x1805159B0")]
		set;
	}

	// Token: 0x17000160 RID: 352
	// (get) Token: 0x060016DD RID: 5853 RVA: 0x0007DA6C File Offset: 0x0007BC6C
	// (set) Token: 0x060016DE RID: 5854 RVA: 0x0007DA80 File Offset: 0x0007BC80
	[Token(Token = "0x17000160")]
	public int Depth
	{
		[Token(Token = "0x60016DD")]
		[Address(RVA = "0x515930", Offset = "0x513F30", VA = "0x180515930")]
		get;
		[Token(Token = "0x60016DE")]
		[Address(RVA = "0x515970", Offset = "0x513F70", VA = "0x180515970")]
		set;
	}

	// Token: 0x17000161 RID: 353
	// (get) Token: 0x060016DF RID: 5855 RVA: 0x0007DA94 File Offset: 0x0007BC94
	// (set) Token: 0x060016E0 RID: 5856 RVA: 0x0007DAA8 File Offset: 0x0007BCA8
	[Token(Token = "0x17000161")]
	public bool IsBasicPlant
	{
		[Token(Token = "0x60016DF")]
		[Address(RVA = "0x515940", Offset = "0x513F40", VA = "0x180515940")]
		get;
		[Token(Token = "0x60016E0")]
		[Address(RVA = "0x515990", Offset = "0x513F90", VA = "0x180515990")]
		set;
	}

	// Token: 0x060016E1 RID: 5857 RVA: 0x0007DABC File Offset: 0x0007BCBC
	[Token(Token = "0x60016E1")]
	[Address(RVA = "0x515810", Offset = "0x513E10", VA = "0x180515810")]
	public PlantMixTreeNode(PlantType plantType)
	{
		this.PlantType = plantType;
		List<PlantMixTreeNode> list = new List();
		this.DirectChildren = list;
		List<PlantMixTreeNode> list2 = new List();
		this.AllDescendants = list2;
		Dictionary<PlantType, PlantType> dictionary = new Dictionary();
		this.Recipes = dictionary;
		this.Depth = (int)((ulong)0L);
		bool flag;
		this.IsBasicPlant = flag;
	}

	// Token: 0x060016E2 RID: 5858 RVA: 0x0007DB14 File Offset: 0x0007BD14
	[Token(Token = "0x60016E2")]
	[Address(RVA = "0x515120", Offset = "0x513720", VA = "0x180515120")]
	public int GetDirectChildrenCount()
	{
		return this.<DirectChildren>k__BackingField._size;
	}

	// Token: 0x060016E3 RID: 5859 RVA: 0x0007DB34 File Offset: 0x0007BD34
	[Token(Token = "0x60016E3")]
	[Address(RVA = "0x5150E0", Offset = "0x5136E0", VA = "0x1805150E0")]
	public int GetAllDescendantsCount()
	{
		return this.<AllDescendants>k__BackingField._size;
	}

	// Token: 0x060016E4 RID: 5860 RVA: 0x0007DB54 File Offset: 0x0007BD54
	[Token(Token = "0x60016E4")]
	[Address(RVA = "0x515030", Offset = "0x513630", VA = "0x180515030")]
	public bool CanMixInto(PlantType targetPlant)
	{
		List<PlantMixTreeNode> list = this.<AllDescendants>k__BackingField;
		int num = 0;
		if (this.<AllDescendants>k__BackingField[num].<PlantType>k__BackingField != targetPlant)
		{
			List<PlantMixTreeNode> list2 = this.<AllDescendants>k__BackingField;
			num++;
		}
		return true;
	}

	// Token: 0x060016E5 RID: 5861 RVA: 0x0007DB98 File Offset: 0x0007BD98
	[Token(Token = "0x60016E5")]
	[Address(RVA = "0x5157A0", Offset = "0x513DA0", VA = "0x1805157A0")]
	public bool TryMixWith(PlantType otherPlant, [Out] PlantType result)
	{
		Dictionary<PlantType, PlantType> dictionary = this.<Recipes>k__BackingField;
		bool flag;
		return flag;
	}

	// Token: 0x060016E6 RID: 5862 RVA: 0x0007DBB8 File Offset: 0x0007BDB8
	[Token(Token = "0x60016E6")]
	[Address(RVA = "0x515160", Offset = "0x513760", VA = "0x180515160")]
	public void PrintTree()
	{
		ulong num3;
		do
		{
			Queue<ValueTuple<PlantMixTreeNode, int>> queue = new Queue();
			HashSet<PlantType> hashSet = new HashSet();
			int num = 0;
			queue.Enqueue(num);
			PlantType plantType = this.<PlantType>k__BackingField;
			bool flag = hashSet.Add(plantType);
			PlantType plantType2 = this.<PlantType>k__BackingField;
			Debug.Log(string.Format("=== {0} 融合树 ===", plantType2));
			object[] array = new object[4];
			string text;
			if (text != 0)
			{
			}
			array[0] = text;
			if (array != 0)
			{
			}
			array[1] = array;
			if (array != 0)
			{
			}
			array[2] = array;
			int length = array.Length;
			if (length != 0)
			{
			}
			array[3] = length;
			string text2 = string.Format("{0}{1} (深度:{2}, 直接子节点:{3})", array);
			Debug.Log(text2);
			bool flag2;
			if (flag2)
			{
				bool flag3;
				while (flag3)
				{
				}
				int num2 = 0;
				queue.Enqueue(num2);
			}
		}
		while (num3 != (ulong)0L);
		bool flag4;
		Debug.Log(string.Format("总后代数: {0}", flag4));
	}
}
