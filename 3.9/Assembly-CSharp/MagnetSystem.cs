using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007B4 RID: 1972
[Token(Token = "0x20007B4")]
public class MagnetSystem : MonoBehaviour
{
	// Token: 0x060027E2 RID: 10210 RVA: 0x000D3524 File Offset: 0x000D1724
	[Token(Token = "0x60027E2")]
	[Address(RVA = "0x648D30", Offset = "0x647330", VA = "0x180648D30")]
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

	// Token: 0x060027E3 RID: 10211 RVA: 0x000D3580 File Offset: 0x000D1780
	[Token(Token = "0x60027E3")]
	[Address(RVA = "0x649290", Offset = "0x647890", VA = "0x180649290")]
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

	// Token: 0x060027E4 RID: 10212 RVA: 0x000D36B0 File Offset: 0x000D18B0
	[Token(Token = "0x60027E4")]
	[Address(RVA = "0x6483E0", Offset = "0x6469E0", VA = "0x1806483E0")]
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

	// Token: 0x060027E5 RID: 10213 RVA: 0x000D375C File Offset: 0x000D195C
	[Token(Token = "0x60027E5")]
	[Address(RVA = "0x649030", Offset = "0x647630", VA = "0x180649030")]
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

	// Token: 0x060027E6 RID: 10214 RVA: 0x000D37B4 File Offset: 0x000D19B4
	[Token(Token = "0x60027E6")]
	[Address(RVA = "0x647F10", Offset = "0x646510", VA = "0x180647F10")]
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

	// Token: 0x060027E7 RID: 10215 RVA: 0x000D3890 File Offset: 0x000D1A90
	[Token(Token = "0x60027E7")]
	[Address(RVA = "0x6488B0", Offset = "0x646EB0", VA = "0x1806488B0")]
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

	// Token: 0x060027E8 RID: 10216 RVA: 0x000D3910 File Offset: 0x000D1B10
	[Token(Token = "0x60027E8")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public MagnetSystem()
	{
	}

	// Token: 0x04001555 RID: 5461
	[Token(Token = "0x4001555")]
	public static List<Plant> plants = new List();

	// Token: 0x04001556 RID: 5462
	[Token(Token = "0x4001556")]
	private static readonly List<List<Plant>> systems = new List();

	// Token: 0x04001557 RID: 5463
	[Token(Token = "0x4001557")]
	private static readonly Dictionary<Plant, List<Plant>> adjacencyList = new Dictionary();

	// Token: 0x04001558 RID: 5464
	[Token(Token = "0x4001558")]
	private static readonly Dictionary<ValueTuple<Plant, Plant>, MagnetLine> edgeLines = new Dictionary();

	// Token: 0x04001559 RID: 5465
	[Token(Token = "0x4001559")]
	private static readonly HashSet<ValueTuple<Plant, Plant>> activeEdges = new HashSet();
}
