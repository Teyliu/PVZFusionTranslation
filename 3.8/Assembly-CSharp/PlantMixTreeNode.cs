using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004A1 RID: 1185
[Token(Token = "0x20004A1")]
public class PlantMixTreeNode
{
	// Token: 0x17000116 RID: 278
	// (get) Token: 0x06001635 RID: 5685 RVA: 0x0007AF50 File Offset: 0x00079150
	// (set) Token: 0x06001636 RID: 5686 RVA: 0x0007AF64 File Offset: 0x00079164
	[Token(Token = "0x17000116")]
	public PlantType PlantType
	{
		[Token(Token = "0x6001635")]
		[Address(RVA = "0x39C420", Offset = "0x39AA20", VA = "0x18039C420")]
		get;
		[Token(Token = "0x6001636")]
		[Address(RVA = "0x4A9D70", Offset = "0x4A8370", VA = "0x1804A9D70")]
		set;
	}

	// Token: 0x17000117 RID: 279
	// (get) Token: 0x06001637 RID: 5687 RVA: 0x0007AF78 File Offset: 0x00079178
	// (set) Token: 0x06001638 RID: 5688 RVA: 0x0007AF8C File Offset: 0x0007918C
	[Token(Token = "0x17000117")]
	public List<PlantMixTreeNode> DirectChildren
	{
		[Token(Token = "0x6001637")]
		[Address(RVA = "0x3C9940", Offset = "0x3C7F40", VA = "0x1803C9940")]
		get;
		[Token(Token = "0x6001638")]
		[Address(RVA = "0x4A9D50", Offset = "0x4A8350", VA = "0x1804A9D50")]
		set;
	}

	// Token: 0x17000118 RID: 280
	// (get) Token: 0x06001639 RID: 5689 RVA: 0x0007AFA0 File Offset: 0x000791A0
	// (set) Token: 0x0600163A RID: 5690 RVA: 0x0007AFB4 File Offset: 0x000791B4
	[Token(Token = "0x17000118")]
	public List<PlantMixTreeNode> AllDescendants
	{
		[Token(Token = "0x6001639")]
		[Address(RVA = "0x4A9CF0", Offset = "0x4A82F0", VA = "0x1804A9CF0")]
		get;
		[Token(Token = "0x600163A")]
		[Address(RVA = "0x4A9D30", Offset = "0x4A8330", VA = "0x1804A9D30")]
		set;
	}

	// Token: 0x17000119 RID: 281
	// (get) Token: 0x0600163B RID: 5691 RVA: 0x0007AFC8 File Offset: 0x000791C8
	// (set) Token: 0x0600163C RID: 5692 RVA: 0x0007AFDC File Offset: 0x000791DC
	[Token(Token = "0x17000119")]
	public Dictionary<PlantType, PlantType> Recipes
	{
		[Token(Token = "0x600163B")]
		[Address(RVA = "0x4A9D20", Offset = "0x4A8320", VA = "0x1804A9D20")]
		get;
		[Token(Token = "0x600163C")]
		[Address(RVA = "0x4A9D80", Offset = "0x4A8380", VA = "0x1804A9D80")]
		set;
	}

	// Token: 0x1700011A RID: 282
	// (get) Token: 0x0600163D RID: 5693 RVA: 0x0007AFF0 File Offset: 0x000791F0
	// (set) Token: 0x0600163E RID: 5694 RVA: 0x0007B004 File Offset: 0x00079204
	[Token(Token = "0x1700011A")]
	public int Depth
	{
		[Token(Token = "0x600163D")]
		[Address(RVA = "0x4A9D00", Offset = "0x4A8300", VA = "0x1804A9D00")]
		get;
		[Token(Token = "0x600163E")]
		[Address(RVA = "0x4A9D40", Offset = "0x4A8340", VA = "0x1804A9D40")]
		set;
	}

	// Token: 0x1700011B RID: 283
	// (get) Token: 0x0600163F RID: 5695 RVA: 0x0007B018 File Offset: 0x00079218
	// (set) Token: 0x06001640 RID: 5696 RVA: 0x0007B02C File Offset: 0x0007922C
	[Token(Token = "0x1700011B")]
	public bool IsBasicPlant
	{
		[Token(Token = "0x600163F")]
		[Address(RVA = "0x4A9D10", Offset = "0x4A8310", VA = "0x1804A9D10")]
		get;
		[Token(Token = "0x6001640")]
		[Address(RVA = "0x4A9D60", Offset = "0x4A8360", VA = "0x1804A9D60")]
		set;
	}

	// Token: 0x06001641 RID: 5697 RVA: 0x0007B040 File Offset: 0x00079240
	[Token(Token = "0x6001641")]
	[Address(RVA = "0x4A9BE0", Offset = "0x4A81E0", VA = "0x1804A9BE0")]
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

	// Token: 0x06001642 RID: 5698 RVA: 0x0007B098 File Offset: 0x00079298
	[Token(Token = "0x6001642")]
	[Address(RVA = "0x4A94F0", Offset = "0x4A7AF0", VA = "0x1804A94F0")]
	public int GetDirectChildrenCount()
	{
		return this.<DirectChildren>k__BackingField._size;
	}

	// Token: 0x06001643 RID: 5699 RVA: 0x0007B0B8 File Offset: 0x000792B8
	[Token(Token = "0x6001643")]
	[Address(RVA = "0x4A94B0", Offset = "0x4A7AB0", VA = "0x1804A94B0")]
	public int GetAllDescendantsCount()
	{
		return this.<AllDescendants>k__BackingField._size;
	}

	// Token: 0x06001644 RID: 5700 RVA: 0x0007B0D8 File Offset: 0x000792D8
	[Token(Token = "0x6001644")]
	[Address(RVA = "0x4A9400", Offset = "0x4A7A00", VA = "0x1804A9400")]
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

	// Token: 0x06001645 RID: 5701 RVA: 0x0007B11C File Offset: 0x0007931C
	[Token(Token = "0x6001645")]
	[Address(RVA = "0x4A9B70", Offset = "0x4A8170", VA = "0x1804A9B70")]
	public bool TryMixWith(PlantType otherPlant, [Out] PlantType result)
	{
		Dictionary<PlantType, PlantType> dictionary = this.<Recipes>k__BackingField;
		bool flag;
		return flag;
	}

	// Token: 0x06001646 RID: 5702 RVA: 0x0007B13C File Offset: 0x0007933C
	[Token(Token = "0x6001646")]
	[Address(RVA = "0x4A9530", Offset = "0x4A7B30", VA = "0x1804A9530")]
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
