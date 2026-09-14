using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020009C1 RID: 2497
[Token(Token = "0x20009C1")]
public class ScaryPotManager
{
	// Token: 0x0600335E RID: 13150 RVA: 0x0010FFF4 File Offset: 0x0010E1F4
	[Token(Token = "0x600335E")]
	[Address(RVA = "0x7100E0", Offset = "0x70E6E0", VA = "0x1807100E0")]
	public static void SetPots(ChallengeLevel theBoardLevel)
	{
		int num = 0;
		bool flag;
		if (flag && num != 0 && num != 0)
		{
			Queue<PlantType> queue = new Queue();
			Queue<ZombieType> queue2 = new Queue();
			ZombieType zombieType;
			int num2 = (int)zombieType;
			int num3 = (int)zombieType;
			int num4 = (int)zombieType;
			List<int> list = new List();
			if (num3 * num2 > 0)
			{
				int num5 = 0;
				int size = list._size;
				list._size = list;
				num5++;
			}
			PlantType plantType = queue.Dequeue();
			int num6 = list._size;
			if (num4 > 0)
			{
			}
			int num7 = list[num6];
			int num8 = list[num6];
			num8 = num7;
			num6 = num8;
			list.RemoveAt(num6);
			ZombieType zombieType2 = queue2.Dequeue();
			int num9 = list._size;
			int num10 = list[num9];
			int num11 = list[num9];
			num11 = num10;
			num9 = num11;
			list.RemoveAt(num9);
		}
	}

	// Token: 0x0600335F RID: 13151 RVA: 0x001100F4 File Offset: 0x0010E2F4
	[Token(Token = "0x600335F")]
	[Address(RVA = "0x70FA00", Offset = "0x70E000", VA = "0x18070FA00")]
	private static Queue<PlantType> GetPlantTypes(List<PlantType> pool)
	{
		Queue<PlantType> queue = new Queue();
		int num = pool._size;
		int num2 = global::UnityEngine.Random.Range(0, num);
		num = num2;
		int num3 = pool[num];
		num3 = num2;
		pool.RemoveAt(num3);
		return queue;
	}

	// Token: 0x06003360 RID: 13152 RVA: 0x0011013C File Offset: 0x0010E33C
	[Token(Token = "0x6003360")]
	[Address(RVA = "0x70FE70", Offset = "0x70E470", VA = "0x18070FE70")]
	private static Queue<ZombieType> GetZombieTypes(List<ZombieType> pool)
	{
		Queue<ZombieType> queue = new Queue();
		int num = pool._size;
		int num2 = global::UnityEngine.Random.Range(0, num);
		num = num2;
		int num3 = pool[num];
		num3 = num2;
		pool.RemoveAt(num3);
		return queue;
	}

	// Token: 0x06003361 RID: 13153 RVA: 0x00110184 File Offset: 0x0010E384
	[Token(Token = "0x6003361")]
	[Address(RVA = "0x70FF70", Offset = "0x70E570", VA = "0x18070FF70")]
	public static void SetPVPPots()
	{
		Board instance = Board.Instance;
		int num = 0;
		if (3 < instance.columnNum)
		{
			Board instance2 = Board.Instance;
			if (num < instance2.rowNum)
			{
				int num2 = 0;
				if (GridItem.SetGridItem(3, num, (GridItemType)((uint)4), (GraveType)num2) == 0)
				{
					goto IL_0054;
				}
				ZombieType randomZombieType = ScaryPotManager.GetRandomZombieType();
				if (randomZombieType == ZombieType.NormalZombie)
				{
					ZombieType randomZombieType2 = ScaryPotManager.GetRandomZombieType();
				}
				num++;
			}
			if (instance2 != 0)
			{
				return;
			}
			IL_0054:
			ZombieType randomZombieType3 = ScaryPotManager.GetRandomZombieType();
			throw new NullReferenceException();
		}
	}

	// Token: 0x06003362 RID: 13154 RVA: 0x001101F8 File Offset: 0x0010E3F8
	[Token(Token = "0x6003362")]
	[Address(RVA = "0x70FB00", Offset = "0x70E100", VA = "0x18070FB00")]
	public static ZombieType GetRandomZombieType()
	{
		Array values = Enum.GetValues(typeof(ZombieType));
		if (values == 0 || values != 0)
		{
			List<ZombieType> list = Enumerable.ToList<ZombieType>(values);
			Predicate<ZombieType> predicate;
			if (ScaryPotManager.<>c.<>9__4_0 == 0)
			{
				predicate = delegate(ZombieType p)
				{
					if (typeof(TypeMgr).TypeHandle > (ulong)1L)
					{
						if (typeof(TypeMgr).TypeHandle <= (ulong)24L)
						{
						}
						if (p != ZombieType.VoodooDollZombie)
						{
							bool flag;
							return flag;
						}
					}
					return true;
				};
				ScaryPotManager.<>c.<>9__4_0 = predicate;
			}
			int num = list.RemoveAll(predicate);
			Board instance = Board.Instance;
			Predicate<ZombieType> predicate2;
			if (ScaryPotManager.<>c.<>9__4_1 == 0)
			{
				predicate2 = delegate(ZombieType p)
				{
					List<ZombieType> bannedInPVPScaryPot_zombie = GameAPP.bannedInPVPScaryPot_zombie;
					bool flag2;
					return flag2;
				};
				ScaryPotManager.<>c.<>9__4_1 = predicate2;
			}
			int num2 = list.RemoveAll(predicate2);
			int size = list._size;
			list._size = num2;
			int num3 = list._size;
			num3 = global::UnityEngine.Random.Range(0, num3);
			return list[num3];
		}
		throw new InvalidCastException();
	}

	// Token: 0x06003363 RID: 13155 RVA: 0x001102C0 File Offset: 0x0010E4C0
	[Token(Token = "0x6003363")]
	[Address(RVA = "0x70F8C0", Offset = "0x70DEC0", VA = "0x18070F8C0")]
	public static void CreateScaryPot(PlantType thePlantType, int theColumn, int theRow)
	{
		List<Plant> list = Lawnf.Get1x1Plants(theColumn, theColumn);
		CreatePlant instance = CreatePlant.Instance;
		int num = 0;
		if (instance.CheckBox(theColumn, theRow, (PlantType)num))
		{
			int num2 = 0;
			GridItem gridItem = GridItem.SetGridItem(theColumn, theColumn, (GridItemType)((uint)4), (GraveType)num2);
		}
	}

	// Token: 0x06003364 RID: 13156 RVA: 0x00110308 File Offset: 0x0010E508
	[Token(Token = "0x6003364")]
	[Address(RVA = "0x70F780", Offset = "0x70DD80", VA = "0x18070F780")]
	public static void CreateScaryPot(ZombieType theZombieType, int theColumn, int theRow)
	{
		List<Plant> list = Lawnf.Get1x1Plants(theColumn, theColumn);
		CreatePlant instance = CreatePlant.Instance;
		int num = 0;
		if (instance.CheckBox(theColumn, theRow, (PlantType)num))
		{
			int num2 = 0;
			GridItem gridItem = GridItem.SetGridItem(theColumn, theColumn, (GridItemType)((uint)4), (GraveType)num2);
		}
	}

	// Token: 0x06003365 RID: 13157 RVA: 0x00110350 File Offset: 0x0010E550
	[Token(Token = "0x6003365")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public ScaryPotManager()
	{
	}
}
