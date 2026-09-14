using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020009FD RID: 2557
[Token(Token = "0x20009FD")]
public class ScaryPotManager
{
	// Token: 0x06003492 RID: 13458 RVA: 0x00114FD4 File Offset: 0x001131D4
	[Token(Token = "0x6003492")]
	[Address(RVA = "0x775610", Offset = "0x773C10", VA = "0x180775610")]
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

	// Token: 0x06003493 RID: 13459 RVA: 0x001150D4 File Offset: 0x001132D4
	[Token(Token = "0x6003493")]
	[Address(RVA = "0x774F30", Offset = "0x773530", VA = "0x180774F30")]
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

	// Token: 0x06003494 RID: 13460 RVA: 0x0011511C File Offset: 0x0011331C
	[Token(Token = "0x6003494")]
	[Address(RVA = "0x7753A0", Offset = "0x7739A0", VA = "0x1807753A0")]
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

	// Token: 0x06003495 RID: 13461 RVA: 0x00115164 File Offset: 0x00113364
	[Token(Token = "0x6003495")]
	[Address(RVA = "0x7754A0", Offset = "0x773AA0", VA = "0x1807754A0")]
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

	// Token: 0x06003496 RID: 13462 RVA: 0x001151D8 File Offset: 0x001133D8
	[Token(Token = "0x6003496")]
	[Address(RVA = "0x775030", Offset = "0x773630", VA = "0x180775030")]
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

	// Token: 0x06003497 RID: 13463 RVA: 0x001152A0 File Offset: 0x001134A0
	[Token(Token = "0x6003497")]
	[Address(RVA = "0x774DF0", Offset = "0x7733F0", VA = "0x180774DF0")]
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

	// Token: 0x06003498 RID: 13464 RVA: 0x001152E8 File Offset: 0x001134E8
	[Token(Token = "0x6003498")]
	[Address(RVA = "0x774CB0", Offset = "0x7732B0", VA = "0x180774CB0")]
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

	// Token: 0x06003499 RID: 13465 RVA: 0x00115330 File Offset: 0x00113530
	[Token(Token = "0x6003499")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public ScaryPotManager()
	{
	}
}
