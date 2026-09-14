using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200077B RID: 1915
[Token(Token = "0x200077B")]
public class MagnetSystem : MonoBehaviour
{
	// Token: 0x060026B3 RID: 9907 RVA: 0x000CE4F4 File Offset: 0x000CC6F4
	[Token(Token = "0x60026B3")]
	[Address(RVA = "0x5E59F0", Offset = "0x5E3FF0", VA = "0x1805E59F0")]
	public static List<Plant> GetPlants(Plant plant)
	{
		List<Plant> list;
		int num;
		do
		{
			list = new List();
			List<List<Plant>> list2 = MagnetSystem.systems;
			num = 0;
			bool flag;
			if (flag)
			{
				bool flag2;
				while (!flag2)
				{
				}
				bool flag3;
				if (flag3)
				{
				}
				if (num != 0)
				{
					goto IL_003D;
				}
			}
		}
		while (num != 0);
		return list;
		IL_003D:
		throw new NullReferenceException();
	}

	// Token: 0x060026B4 RID: 9908 RVA: 0x000CE550 File Offset: 0x000CC750
	[Token(Token = "0x60026B4")]
	[Address(RVA = "0x5E5F50", Offset = "0x5E4550", VA = "0x1805E5F50")]
	public static void MagnetSystemUpdate()
	{
		int num6;
		do
		{
			int num = 0;
			List<Plant> list = MagnetSystem.plants;
			int size = list._size;
			int num2 = 0;
			list._size = num2;
			if (size > 0)
			{
			}
			List<List<Plant>> list2 = MagnetSystem.systems;
			int size2 = list2._size;
			list2._size = num2;
			if (size2 > 0)
			{
			}
			List<MagnetLine> magnetLines = MagnetLineMgr.Instance.magnetLines;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				GameObject gameObject;
				gameObject.SetActive(num3 != 0);
			}
			if (num2 != 0)
			{
				goto IL_00FC;
			}
			int num4 = 0;
			List<Plant> plantArray = Board.Instance.boardEntity.plantArray;
			bool flag2;
			if (flag2)
			{
				int num5 = 0;
				if (!(num != num5))
				{
					continue;
				}
				List<Plant> list3 = MagnetSystem.plants;
			}
			if (num4 != 0)
			{
				goto IL_0108;
			}
			num6 = 0;
			MagnetSystem.BuildAdjacencyList();
			MagnetSystem.GroupMushroomsIntoSystems();
			bool flag3 = Lawnf.TravelAdvanced((AdvBuff)((uint)35));
			List<List<Plant>> list4 = MagnetSystem.systems;
			bool flag4;
			if (flag4)
			{
				bool flag5;
				if (flag5)
				{
					num++;
				}
				if (num6 != 0)
				{
					goto IL_010E;
				}
				int num7 = 0;
				bool flag6;
				if (flag6)
				{
				}
				if (num7 != 0)
				{
					goto IL_0114;
				}
			}
		}
		while (num6 != 0);
		return;
		IL_00FC:
		throw new NullReferenceException();
		IL_0108:
		throw new NullReferenceException();
		IL_010E:
		throw new NullReferenceException();
		IL_0114:
		throw new NullReferenceException();
	}

	// Token: 0x060026B5 RID: 9909 RVA: 0x000CE680 File Offset: 0x000CC880
	[Token(Token = "0x60026B5")]
	[Address(RVA = "0x5E50A0", Offset = "0x5E36A0", VA = "0x1805E50A0")]
	private static void BuildAdjacencyList()
	{
		int num3;
		do
		{
			int num = 0;
			MagnetSystem.adjacencyList.Clear();
			List<Plant> list = MagnetSystem.plants;
			int num2 = 0;
			bool flag;
			if (flag)
			{
				Dictionary<Plant, List<Plant>> dictionary = MagnetSystem.adjacencyList;
				List<Plant> list2 = new List();
				dictionary[num] = list2;
			}
			if (num2 != 0)
			{
				goto IL_007E;
			}
			num3 = 0;
			List<Plant> list3 = MagnetSystem.plants;
			bool flag2;
			if (flag2)
			{
				List<Plant> list4 = MagnetSystem.plants;
				bool flag3;
				if (flag3)
				{
					if (!(num != num))
					{
						continue;
					}
					List<Plant> list5 = MagnetSystem.adjacencyList[num];
				}
				if (num3 != 0)
				{
					goto IL_0096;
				}
			}
		}
		while (num3 != 0);
		return;
		IL_007E:
		throw new NullReferenceException();
		IL_0096:
		throw new NullReferenceException();
	}

	// Token: 0x060026B6 RID: 9910 RVA: 0x000CE72C File Offset: 0x000CC92C
	[Token(Token = "0x60026B6")]
	[Address(RVA = "0x5E5CF0", Offset = "0x5E42F0", VA = "0x1805E5CF0")]
	private static void GroupMushroomsIntoSystems()
	{
		ulong num2;
		do
		{
			int num = 0;
			HashSet<Plant> hashSet = new HashSet();
			List<Plant> list = MagnetSystem.plants;
			bool flag;
			if (flag)
			{
				if (hashSet.Contains(num))
				{
					continue;
				}
				List<Plant> list2 = new List();
				MagnetSystem.BFS(num, list2, hashSet);
				List<List<Plant>> list3 = MagnetSystem.systems;
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x060026B7 RID: 9911 RVA: 0x000CE784 File Offset: 0x000CC984
	[Token(Token = "0x60026B7")]
	[Address(RVA = "0x5E4BD0", Offset = "0x5E31D0", VA = "0x1805E4BD0")]
	private static void BFS(Plant start, List<Plant> system, HashSet<Plant> visited)
	{
		for (;;)
		{
			int num = 0;
			int num2 = 0;
			Queue<Plant> queue = new Queue();
			queue.Enqueue(start);
			int num3 = 0;
			Plant plant = queue.Dequeue();
			if (!visited.Contains(plant))
			{
				bool flag = visited.Add(plant);
				List<Plant> list = MagnetSystem.adjacencyList[plant];
				bool flag2;
				if (flag2)
				{
					if (visited.Contains(num2))
					{
						continue;
					}
					queue.Enqueue(num2);
					MagnetLineMgr instance = MagnetLineMgr.Instance;
					Board instance2 = Board.Instance;
					MagnetLine magnetLine;
					GameObject gameObject = magnetLine.gameObject;
					int num4 = 0;
					gameObject.SetActive(num4 != 0);
					MagnetSystem.edgeLines[num] = magnetLine;
					bool flag3 = MagnetSystem.activeEdges.Add(num);
				}
				if (num3 == 0)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060026B8 RID: 9912 RVA: 0x000CE860 File Offset: 0x000CCA60
	[Token(Token = "0x60026B8")]
	[Address(RVA = "0x5E5570", Offset = "0x5E3B70", VA = "0x1805E5570")]
	private static void DestroyUnusedLines(HashSet<Plant> visited)
	{
		int num2;
		do
		{
			List<ValueTuple<Plant, Plant>> list = new List();
			Dictionary<ValueTuple<Plant, Plant>, MagnetLine> dictionary = MagnetSystem.edgeLines;
			int num = 0;
			bool flag;
			if (flag)
			{
				bool flag2;
				if (flag2)
				{
					bool flag3;
					while (flag3)
					{
					}
				}
				MagnetLineMgr instance = MagnetLineMgr.Instance;
			}
			if (num != 0)
			{
				goto IL_0066;
			}
			num2 = 0;
			bool flag4;
			if (flag4)
			{
				Dictionary<ValueTuple<Plant, Plant>, MagnetLine> dictionary2 = MagnetSystem.edgeLines;
				HashSet<ValueTuple<Plant, Plant>> hashSet = MagnetSystem.activeEdges;
			}
		}
		while (num2 != 0);
		return;
		IL_0066:
		throw new NullReferenceException();
	}

	// Token: 0x060026B9 RID: 9913 RVA: 0x000CE8E0 File Offset: 0x000CCAE0
	[Token(Token = "0x60026B9")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public MagnetSystem()
	{
	}

	// Token: 0x04001479 RID: 5241
	[Token(Token = "0x4001479")]
	public static List<Plant> plants = new List();

	// Token: 0x0400147A RID: 5242
	[Token(Token = "0x400147A")]
	private static readonly List<List<Plant>> systems = new List();

	// Token: 0x0400147B RID: 5243
	[Token(Token = "0x400147B")]
	private static readonly Dictionary<Plant, List<Plant>> adjacencyList = new Dictionary();

	// Token: 0x0400147C RID: 5244
	[Token(Token = "0x400147C")]
	private static readonly Dictionary<ValueTuple<Plant, Plant>, MagnetLine> edgeLines = new Dictionary();

	// Token: 0x0400147D RID: 5245
	[Token(Token = "0x400147D")]
	private static readonly HashSet<ValueTuple<Plant, Plant>> activeEdges = new HashSet();
}
