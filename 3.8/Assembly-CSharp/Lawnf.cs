using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using AlmanacData;
using Core;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

// Token: 0x020009A8 RID: 2472
[Token(Token = "0x20009A8")]
public static class Lawnf
{
	// Token: 0x0600325C RID: 12892 RVA: 0x0010AF00 File Offset: 0x00109100
	[Token(Token = "0x600325C")]
	[Address(RVA = "0x9C9390", Offset = "0x9C7990", VA = "0x1809C9390")]
	public static void BuildBuff<T, T2>(Dictionary<T, T2> dic) where T : Enum where T2 : IBuff<T>
	{
		int num;
		do
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			num = 0;
			IEnumerable<Type> enumerable;
			if (enumerable != 0)
			{
				if (num >= typeof(IEnumerator).TypeHandle)
				{
					goto IL_0032;
				}
				num += num;
				if (num != typeof(IEnumerator).TypeHandle)
				{
					num++;
					goto IL_0032;
				}
				IL_0037:
				enumerable += enumerable;
				int num2;
				num2 += 312;
				object obj;
				if (obj == 0)
				{
					goto IL_0075;
				}
				int num3;
				if (num >= num3)
				{
					goto IL_005A;
				}
				num += num;
				if (num != num3)
				{
					num++;
					goto IL_005A;
				}
				goto IL_005A;
				IL_0032:
				num3 = 0;
				num2 = 0;
				goto IL_0037;
			}
			IL_005A:
			if ("{il2cpp array field local6->}" != (ulong)0L)
			{
			}
		}
		while (num != 0);
		return;
		IL_0075:
		throw new InvalidCastException();
	}

	// Token: 0x0600325D RID: 12893 RVA: 0x0010AF94 File Offset: 0x00109194
	[Token(Token = "0x600325D")]
	[Address(RVA = "0x6EF270", Offset = "0x6ED870", VA = "0x1806EF270")]
	public static void SetBulletTarget(Bullet bullet, Vector2 projetilePosition, Vector2 targetVelocity, Vector2 targetCurrentPosition, float flightTime)
	{
		float[] array;
		float num = array[0];
		bullet.Vx = num;
		float num2 = array[1];
		bullet.Vy = num2;
		float num3 = array[1];
		bullet.detaVy = num3;
	}

	// Token: 0x0600325E RID: 12894 RVA: 0x0010AFD8 File Offset: 0x001091D8
	[Token(Token = "0x600325E")]
	[Address(RVA = "0x6ECB50", Offset = "0x6EB150", VA = "0x1806ECB50")]
	public static Vector2 GetRandomGrid(int column, int row, [Out] int Row, int columnRange, int rowRange)
	{
		List<int> list = new List();
		Board instance = Board.Instance;
		if (column < instance.columnNum)
		{
		}
		while (column <= columnRange)
		{
		}
		List<int> list2 = new List();
		Board instance2 = Board.Instance;
		if (column < instance2.rowNum)
		{
		}
		while (column <= columnRange)
		{
		}
		int num;
		float boxXFromColumn = Mouse.Instance.GetBoxXFromColumn(num);
		float boxYFromRow = Mouse.Instance.GetBoxYFromRow(column);
		Row.m_value = column;
		throw new NullReferenceException();
	}

	// Token: 0x0600325F RID: 12895 RVA: 0x0010B050 File Offset: 0x00109250
	[Token(Token = "0x600325F")]
	[Address(RVA = "0x6EB510", Offset = "0x6E9B10", VA = "0x1806EB510")]
	public static int GetPlantCount(PlantType theSeedType, Board board)
	{
		int num = 0;
		if (!(board == num))
		{
			Dictionary<PlantType, List<Plant>> plantHeads = board.boardEntity.plantHeads;
			bool flag;
			if (flag)
			{
			}
		}
		return 0;
	}

	// Token: 0x06003260 RID: 12896 RVA: 0x0010B084 File Offset: 0x00109284
	[Token(Token = "0x6003260")]
	[Address(RVA = "0x6EBDA0", Offset = "0x6EA3A0", VA = "0x1806EBDA0")]
	public static List<Plant> GetPlants(PlantType theSeedType, Board board, bool alloc = false)
	{
		Dictionary<PlantType, List<Plant>> plantHeads = board.boardEntity.plantHeads;
		bool flag;
		if (!flag)
		{
			return new List();
		}
		if (!alloc)
		{
		}
		List<Plant> list;
		return list;
	}

	// Token: 0x06003261 RID: 12897 RVA: 0x0010B0C0 File Offset: 0x001092C0
	[Token(Token = "0x6003261")]
	[Address(RVA = "0x6E9E80", Offset = "0x6E8480", VA = "0x1806E9E80")]
	public static Plant GetCertainPlant(int theColumn, int theRow, PlantType thePlantType, Board board)
	{
		ulong num3;
		do
		{
			int num = 0;
			if (theColumn >= board.columnNum || theRow >= board.rowNum)
			{
				break;
			}
			List<Plant> plants = board.gridSystem.GetGrid(theRow, theRow).plants;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
			}
		}
		while (num3 != (ulong)0L);
		throw new NullReferenceException();
	}

	// Token: 0x06003262 RID: 12898 RVA: 0x0010B11C File Offset: 0x0010931C
	[Token(Token = "0x6003262")]
	[Address(RVA = "0x6E9540", Offset = "0x6E7B40", VA = "0x1806E9540")]
	public static List<Plant> GetAllPlants()
	{
		List<Plant> list;
		ulong num3;
		do
		{
			int num = 0;
			list = new List();
			List<Plant> plantArray = Board.Instance.boardEntity.plantArray;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
			}
		}
		while (num3 != (ulong)0L);
		return list;
	}

	// Token: 0x06003263 RID: 12899 RVA: 0x0010B178 File Offset: 0x00109378
	[Token(Token = "0x6003263")]
	[Address(RVA = "0x6EB7E0", Offset = "0x6E9DE0", VA = "0x1806EB7E0")]
	public static HashSet<PlantType> GetPlantTypes()
	{
		HashSet<PlantType> hashSet;
		ulong num3;
		do
		{
			int num = 0;
			hashSet = new HashSet();
			List<Plant> plantArray = Board.Instance.boardEntity.plantArray;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
				bool flag2 = hashSet.Add(num2);
			}
		}
		while (num3 != (ulong)0L);
		return hashSet;
	}

	// Token: 0x06003264 RID: 12900 RVA: 0x0010B1E4 File Offset: 0x001093E4
	[Token(Token = "0x6003264")]
	[Address(RVA = "0x6E9730", Offset = "0x6E7D30", VA = "0x1806E9730")]
	public static List<Zombie> GetAllZombies(bool isMindControlled = false)
	{
		List<Zombie> list;
		ulong num3;
		do
		{
			int num = 0;
			list = new List();
			List<Zombie> zombieArray = Board.Instance.zombieArray;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
			}
		}
		while (num3 != (ulong)0L);
		return list;
	}

	// Token: 0x06003265 RID: 12901 RVA: 0x0010B240 File Offset: 0x00109440
	[Token(Token = "0x6003265")]
	[Address(RVA = "0x6EE150", Offset = "0x6EC750", VA = "0x1806EE150")]
	public static List<Zombie> GetZombiesByRows(HashSet<int> rows, bool isMindControlled = false)
	{
		List<Zombie> list;
		ulong num3;
		do
		{
			int num = 0;
			list = new List();
			List<Zombie> zombieArray = Board.Instance.zombieArray;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2) || !rows.Contains(num2))
				{
					continue;
				}
			}
		}
		while (num3 != (ulong)0L);
		return list;
	}

	// Token: 0x06003266 RID: 12902 RVA: 0x0010B2AC File Offset: 0x001094AC
	[Token(Token = "0x6003266")]
	[Address(RVA = "0x6EDF40", Offset = "0x6EC540", VA = "0x1806EDF40")]
	public static List<Zombie> GetZombiesByRow(int row, bool isMindControlled = false)
	{
		List<Zombie> list;
		ulong num3;
		do
		{
			int num = 0;
			list = new List();
			List<Zombie> zombieArray = Board.Instance.zombieArray;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
			}
		}
		while (num3 != (ulong)0L);
		return list;
	}

	// Token: 0x06003267 RID: 12903 RVA: 0x0010B308 File Offset: 0x00109508
	[Token(Token = "0x6003267")]
	[Address(RVA = "0x6F0A60", Offset = "0x6EF060", VA = "0x1806F0A60")]
	public static void ZombieExplode(Vector2 position, Board board, bool isMindControlled, int theRow, DamageType damageType = DamageType.JackboxExplode, int dmgToZombie = 1800, int dmgToPlant = 1000000, [Optional] Action<Plant> actionToPlant)
	{
		int num;
		for (;;)
		{
			num = 0;
			uint num2;
			GameAPP.PlaySound((int)num2, 0.5f, 1f);
			ScreenShake.TriggerShake(0.15f);
			GameObject gameObject = GameAPP.particlePrefab[42];
			Transform transform = board.transform;
			AdvantureData data = AdvantureConfig.data;
			bool flag;
			if (flag)
			{
			}
			int mask = LayerMask.GetMask(new string[] { "Plant", "TorchWood", "Zombie" });
			Collider2D[] array;
			if (num < array.Length)
			{
				bool flag2;
				if (!flag2)
				{
					goto IL_00AB;
				}
				LayerMask layerMask;
				int mask2 = layerMask.m_Mask;
				if (layerMask == 0)
				{
					goto IL_00AB;
				}
				if (!isMindControlled)
				{
					goto IL_00F0;
				}
				num++;
				int num3 = 0;
				Plant plant;
				if (!(plant == num3))
				{
					goto IL_00AB;
				}
				goto IL_00AB;
				IL_00F8:
				Zombie zombie;
				if (zombie.TryGetComponent<ScaryPot>(num))
				{
					break;
				}
				continue;
				IL_00AB:
				if (!plant.TryGetComponent<Zombie>(num))
				{
					goto IL_00F8;
				}
				bool flag3;
				bool flag4;
				if (flag3 && flag4 && (flag4 || flag4))
				{
					CreateZombie instance = CreateZombie.Instance;
					int num4 = 0;
					if (zombie != num4)
					{
						zombie.isSplited = true;
						zombie.revived = true;
					}
				}
				IL_00F0:
				num++;
				num++;
				goto IL_00F8;
			}
			return;
		}
		num++;
	}

	// Token: 0x06003268 RID: 12904 RVA: 0x0010B428 File Offset: 0x00109628
	[Token(Token = "0x6003268")]
	[Address(RVA = "0x6F0580", Offset = "0x6EEB80", VA = "0x1806F0580")]
	public static bool TravelUnlock(TravelUnlocks unlocks)
	{
		List<TravelUnlocks> unlockedPlants = TravelMgr.Instance.data.unlockedPlants;
		bool flag;
		return flag;
	}

	// Token: 0x06003269 RID: 12905 RVA: 0x0010B450 File Offset: 0x00109650
	[Token(Token = "0x6003269")]
	[Address(RVA = "0x6F01D0", Offset = "0x6EE7D0", VA = "0x1806F01D0")]
	public static bool TravelAdvanced(AdvBuff buff)
	{
		List<AdvBuff> advBuffs = TravelMgr.Instance.data.advBuffs;
		bool flag;
		return flag;
	}

	// Token: 0x0600326A RID: 12906 RVA: 0x0010B478 File Offset: 0x00109678
	[Token(Token = "0x600326A")]
	[Address(RVA = "0x6EE560", Offset = "0x6ECB60", VA = "0x1806EE560")]
	public static bool HasZombie(ZombieType zombieType)
	{
		Dictionary<ZombieType, List<Zombie>> zombieHeads = Board.Instance.zombieHeads;
		bool flag;
		if (!flag)
		{
			List<Zombie> list = new List();
		}
		bool flag2;
		return flag2;
	}

	// Token: 0x0600326B RID: 12907 RVA: 0x0010B4A4 File Offset: 0x001096A4
	[Token(Token = "0x600326B")]
	[Address(RVA = "0x6EE390", Offset = "0x6EC990", VA = "0x1806EE390")]
	public static bool HasTravelBuff(object buff)
	{
		if (buff != 0)
		{
			if (buff != 0)
			{
				bool flag;
				return flag;
			}
			if (buff != 0)
			{
				bool flag2;
				return flag2;
			}
			if (buff != 0)
			{
				List<TravelUnlocks> unlockedPlants = TravelMgr.Instance.data.unlockedPlants;
				bool flag3;
				return flag3;
			}
			if (buff != 0)
			{
				bool flag4;
				return flag4;
			}
		}
		throw new InvalidCastException();
	}

	// Token: 0x0600326C RID: 12908 RVA: 0x0010B4EC File Offset: 0x001096EC
	[Token(Token = "0x600326C")]
	[Address(RVA = "0x6F0500", Offset = "0x6EEB00", VA = "0x1806F0500")]
	public static bool TravelUltimate(UltiBuff buff)
	{
		List<UltiBuff> ultiBuffs = TravelMgr.Instance.data.ultiBuffs;
		bool flag;
		return flag;
	}

	// Token: 0x0600326D RID: 12909 RVA: 0x0010B514 File Offset: 0x00109714
	[Token(Token = "0x600326D")]
	[Address(RVA = "0x6F0490", Offset = "0x6EEA90", VA = "0x1806F0490")]
	public static int TravelUltimateLevel(UltiBuff buff)
	{
		TravelData data = TravelMgr.Instance.data;
		int num;
		return num;
	}

	// Token: 0x0600326E RID: 12910 RVA: 0x0010B538 File Offset: 0x00109738
	[Token(Token = "0x600326E")]
	[Address(RVA = "0x6F0410", Offset = "0x6EEA10", VA = "0x1806F0410")]
	public static bool TravelInvest(InvestBuff investmentBuff)
	{
		List<InvestBuff> investmentBuffs = TravelMgr.Instance.data.investmentBuffs;
		bool flag;
		return flag;
	}

	// Token: 0x0600326F RID: 12911 RVA: 0x0010B560 File Offset: 0x00109760
	[Token(Token = "0x600326F")]
	[Address(RVA = "0x6F02B0", Offset = "0x6EE8B0", VA = "0x1806F02B0")]
	public static bool TravelDebuff(TravelDebuff buff)
	{
		List<TravelDebuff> travelDebuffs = TravelMgr.Instance.data.travelDebuffs;
		bool flag;
		return flag;
	}

	// Token: 0x06003270 RID: 12912 RVA: 0x0010B588 File Offset: 0x00109788
	[Token(Token = "0x6003270")]
	[Address(RVA = "0x6F0250", Offset = "0x6EE850", VA = "0x1806F0250")]
	public static bool TravelCurse()
	{
		return TravelMgr.Instance.data.travelDifficulty == TravelDifficulty.Curse;
	}

	// Token: 0x06003271 RID: 12913 RVA: 0x0010B5B0 File Offset: 0x001097B0
	[Token(Token = "0x6003271")]
	[Address(RVA = "0x6E86E0", Offset = "0x6E6CE0", VA = "0x1806E86E0")]
	public static bool EveBalaced()
	{
		Board instance = Board.Instance;
		int num = 0;
		if (instance != num)
		{
			Board instance2 = Board.Instance;
			if (instance2.isEveStarted)
			{
				return instance2.evebalance;
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x06003272 RID: 12914 RVA: 0x0010B5F0 File Offset: 0x001097F0
	[Token(Token = "0x6003272")]
	[Address(RVA = "0x6ED530", Offset = "0x6EBB30", VA = "0x1806ED530")]
	public static List<Plant> GetRangePlants(int theColumn, int theRow, int range)
	{
		List<Plant> list;
		ulong num3;
		do
		{
			int num = 0;
			list = new List();
			Board instance = Board.Instance;
			Board instance2 = Board.Instance;
			if (theRow >= instance2.rowNum)
			{
				break;
			}
			GridSystem gridSystem = instance2.gridSystem;
			BoardGrid boardGrid;
			List<Plant> plants = boardGrid.plants;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
			}
		}
		while (num3 != (ulong)0L);
		return list;
	}

	// Token: 0x06003273 RID: 12915 RVA: 0x0010B65C File Offset: 0x0010985C
	[Token(Token = "0x6003273")]
	[Address(RVA = "0x6E8C50", Offset = "0x6E7250", VA = "0x1806E8C50")]
	public static List<Plant> Get3x3Plants(int theColumn, int theRow)
	{
		List<Plant> list;
		int num2;
		int num3;
		do
		{
			int num = 0;
			list = new List();
			num2 = 0;
			Board instance = Board.Instance;
			num3 = theRow - 1;
			int num4 = theRow + 1;
			Board instance2 = Board.Instance;
			if (num3 >= instance2.rowNum)
			{
				break;
			}
			GridSystem gridSystem = instance2.gridSystem;
			BoardGrid boardGrid;
			List<Plant> plants = boardGrid.plants;
			bool flag;
			if (flag)
			{
				int num5 = 0;
				if (!(num != num5))
				{
					continue;
				}
			}
		}
		while (num2 != 0);
		num3++;
		return list;
	}

	// Token: 0x06003274 RID: 12916 RVA: 0x0010B6DC File Offset: 0x001098DC
	[Token(Token = "0x6003274")]
	[Address(RVA = "0x6E8A20", Offset = "0x6E7020", VA = "0x1806E8A20")]
	public static List<Plant> Get1x1Plants(int theColumn, int theRow)
	{
		List<Plant> list;
		ulong num3;
		do
		{
			int num = 0;
			list = new List();
			Board instance = Board.Instance;
			if (theColumn >= instance.columnNum || theRow >= instance.rowNum)
			{
				break;
			}
			List<Plant> plants = instance.gridSystem.GetGrid(theColumn, theRow).plants;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
			}
		}
		while (num3 != (ulong)0L);
		return list;
	}

	// Token: 0x06003275 RID: 12917 RVA: 0x0010B754 File Offset: 0x00109954
	[Token(Token = "0x6003275")]
	[Address(RVA = "0x6EF360", Offset = "0x6ED960", VA = "0x1806EF360")]
	public static DroppedCard SetDroppedCard(Vector2 position, PlantType theSeedType, int theSeedCost = 0)
	{
		GameObject gameObject = GameAPP.itemPrefab[9];
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Board instance = Board.Instance;
		GameObject gameObject2;
		DroppedCard component = gameObject2.GetComponent<DroppedCard>();
		component.theSeedCost = theSeedCost;
		component.thePlantType = theSeedType;
		component.movingWay = (int)((ulong)0L);
		return component;
	}

	// Token: 0x06003276 RID: 12918 RVA: 0x0010B7AC File Offset: 0x001099AC
	[Token(Token = "0x6003276")]
	[Address(RVA = "0x6EEA60", Offset = "0x6ED060", VA = "0x1806EEA60")]
	public static bool IsTravelLevel(LevelType theLevelType, int theLevelNumber)
	{
		if (theLevelType == LevelType.Survival && (theLevelNumber <= 12 || theLevelNumber != 16) && theLevelNumber != 8)
		{
			return theLevelNumber == 12;
		}
		int num = 0;
		num = (int)(num + theLevelType);
		return false;
	}

	// Token: 0x06003277 RID: 12919 RVA: 0x0010B7D8 File Offset: 0x001099D8
	[Token(Token = "0x6003277")]
	[Address(RVA = "0x6F09E0", Offset = "0x6EEFE0", VA = "0x1806F09E0")]
	public static bool WithTravelBuff(LevelType theLevelType, int theLevelNumber)
	{
		if (theLevelType == LevelType.Survival)
		{
			if (theLevelNumber <= 12 || theLevelNumber == 16 || theLevelNumber == 15)
			{
			}
			return theLevelNumber == 22;
		}
		return false;
	}

	// Token: 0x06003278 RID: 12920 RVA: 0x0010B804 File Offset: 0x00109A04
	[Token(Token = "0x6003278")]
	[Address(RVA = "0x6E89A0", Offset = "0x6E6FA0", VA = "0x1806E89A0")]
	public static void FastBuffs(TravelMgr travel)
	{
		travel.GetNormalBuff((AdvBuff)((uint)1002));
		travel.GetNormalBuff((AdvBuff)((uint)1003));
		travel.GetNormalBuff((AdvBuff)((uint)1006));
		travel.GetNormalBuff((AdvBuff)((uint)1000));
		travel.GetNormalBuff((AdvBuff)((uint)1005));
		travel.GetNormalBuff((AdvBuff)((uint)1001));
	}

	// Token: 0x06003279 RID: 12921 RVA: 0x0010B860 File Offset: 0x00109A60
	[Token(Token = "0x6003279")]
	[Address(RVA = "0x6EFC60", Offset = "0x6EE260", VA = "0x1806EFC60")]
	public static void SetWaterSplat(Vector2 position, Vector2 scale, int row)
	{
		GameObject gameObject = Resources.Load<GameObject>("Particle/Anim/Water/WaterSplashPrefab");
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = Board.Instance.transform;
		GameObject gameObject2;
		SortingGroup component = gameObject2.GetComponent<SortingGroup>();
		string text = string.Format("particle{0}", component);
		component.sortingLayerName = text;
		Transform transform2 = gameObject2.transform;
		GameObject gameObject3 = GameAPP.particlePrefab[32];
		Quaternion identityQuaternion2 = Quaternion.identityQuaternion;
		Transform transform3 = Board.Instance.transform;
	}

	// Token: 0x0600327A RID: 12922 RVA: 0x0010B8DC File Offset: 0x00109ADC
	[Token(Token = "0x600327A")]
	[Address(RVA = "0x6F0070", Offset = "0x6EE670", VA = "0x1806F0070")]
	public static void SetZombieHealth(Zombie zombie, float ratio)
	{
	}

	// Token: 0x0600327B RID: 12923 RVA: 0x0010B8F0 File Offset: 0x00109AF0
	[Token(Token = "0x600327B")]
	[Address(RVA = "0x6F1240", Offset = "0x6EF840", VA = "0x1806F1240")]
	public static bool ZombieWithIron(Zombie zombie)
	{
		if (zombie.theFirstArmorType <= Zombie.FirstArmorType.TallNut)
		{
		}
		Zombie.SecondArmorType theSecondArmorType = zombie.theSecondArmorType;
		ZombieType theZombieType;
		if (theSecondArmorType != Zombie.SecondArmorType.Door && theSecondArmorType != Zombie.SecondArmorType.Ladder && theSecondArmorType != Zombie.SecondArmorType.RedLadder)
		{
			theZombieType = zombie.theZombieType;
			if (theZombieType <= ZombieType.JacksonDriver)
			{
				goto IL_0065;
			}
			if (theZombieType <= ZombieType.UltimateJacksonDriver)
			{
				goto IL_0055;
			}
			if (theZombieType > ZombieType.PortalBalloonZombie && theSecondArmorType > Zombie.SecondArmorType.SnowShield && theSecondArmorType > Zombie.SecondArmorType.Paper)
			{
				goto IL_007D;
			}
		}
		while (theZombieType == ZombieType.CherrySubmarine)
		{
		}
		while (theZombieType == ZombieType.PortalBalloonZombie)
		{
		}
		int i = 0;
		IL_0055:
		while (theZombieType == ZombieType.SuperMachineNutZombie)
		{
		}
		while (theZombieType == ZombieType.UltimateMachineNutZombie)
		{
		}
		IL_0065:
		if (theZombieType > ZombieType.MachineNutZombie)
		{
			while (theZombieType == ZombieType.IronPeaZombie)
			{
			}
			while (theZombieType == ZombieType.IronBalloonZombie2)
			{
			}
		}
		while (theZombieType == ZombieType.IronBalloonZombie)
		{
		}
		while (i <= 2)
		{
		}
		IL_007D:
		throw new NullReferenceException();
	}

	// Token: 0x0600327C RID: 12924 RVA: 0x0010B984 File Offset: 0x00109B84
	[Token(Token = "0x600327C")]
	[Address(RVA = "0x6E8330", Offset = "0x6E6930", VA = "0x1806E8330")]
	public static CardUI CreateCard(PlantType theSeedType, Vector2 position)
	{
		GameObject gameObject = GameAPP.itemPrefab[29];
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		GameObject gameObject2;
		CardUI component = gameObject2.GetComponent<CardUI>();
		PlantDataManager.PlantData plantData;
		if (plantData != 0)
		{
			float cd = plantData.cd;
			component.fullCD = cd;
			component.CD = cd;
			int cost = plantData.cost;
			component.theSeedCost = cost;
		}
		component.thePlantType = theSeedType;
		return component;
	}

	// Token: 0x0600327D RID: 12925 RVA: 0x0010B9F8 File Offset: 0x00109BF8
	[Token(Token = "0x600327D")]
	[Address(RVA = "0x6E8530", Offset = "0x6E6B30", VA = "0x1806E8530")]
	public static IZECard CreateZombieCardCard(ZombieType theZombieType, Vector2 position)
	{
		GameObject gameObject = GameAPP.itemPrefab[49];
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		GameObject gameObject2;
		IZECard component = gameObject2.GetComponent<IZECard>();
		component.theZombieType = theZombieType;
		return component;
	}

	// Token: 0x0600327E RID: 12926 RVA: 0x0010BA38 File Offset: 0x00109C38
	[Token(Token = "0x600327E")]
	[Address(RVA = "0x6EFF70", Offset = "0x6EE570", VA = "0x1806EFF70")]
	public static ZombieCardPackage SetZombieCardPackage(ZombieType theZombieType)
	{
		GameObject[] itemPrefab = GameAPP.itemPrefab;
		Transform canvasUp = GameAPP.canvasUp;
		ZombieCardPackage component = global::UnityEngine.Object.Instantiate<GameObject>(itemPrefab[57], canvasUp).GetComponent<ZombieCardPackage>();
		component.card.theZombieType = theZombieType;
		return component;
	}

	// Token: 0x0600327F RID: 12927 RVA: 0x0010BA7C File Offset: 0x00109C7C
	[Token(Token = "0x600327F")]
	[Address(RVA = "0x6EFBA0", Offset = "0x6EE1A0", VA = "0x1806EFBA0")]
	public static GameObject SetPlantCardPackage(PlantType thePlantType)
	{
		GameObject gameObject = GameAPP.itemPrefab[58];
		Transform canvasUp = GameAPP.canvasUp;
		return global::UnityEngine.Object.Instantiate<GameObject>(gameObject, canvasUp);
	}

	// Token: 0x06003280 RID: 12928 RVA: 0x0010BAAC File Offset: 0x00109CAC
	[Token(Token = "0x6003280")]
	[Address(RVA = "0x6E6010", Offset = "0x6E4610", VA = "0x1806E6010")]
	private static void ChangeCardSprite(PlantType theSeedType, GameObject card)
	{
		Transform transform = card.transform;
		int num = 0;
		Image component = transform.GetChild(num).GetComponent<Image>();
		Transform transform2 = card.transform;
		int num2 = 0;
		RectTransform component2 = transform2.GetChild(num2).GetComponent<RectTransform>();
		Dictionary<PlantType, GameObject> plantPreviews = GameAPP.resourcesManager.plantPreviews;
		if (theSeedType == PlantType.Pit)
		{
		}
		if (theSeedType != PlantType.Refrash)
		{
			SpriteRenderer spriteRenderer;
			Sprite sprite = spriteRenderer.sprite;
		}
		Sprite sprite2 = Resources.Load<Sprite>("Image/arrow");
		component.sprite = sprite2;
		component.SetNativeSize();
		Vector2 sizeDelta = component2.sizeDelta;
		int num3 = 0;
		Vector2 sizeDelta2 = component2.sizeDelta;
		component2.sizeDelta = num3;
	}

	// Token: 0x06003281 RID: 12929 RVA: 0x0010BB54 File Offset: 0x00109D54
	[Token(Token = "0x6003281")]
	[Address(RVA = "0x6EF540", Offset = "0x6EDB40", VA = "0x1806EF540")]
	public static void SetMusic(Board board)
	{
		TowerManager instance = TowerManager.Instance;
		int num = 0;
		if (instance != num)
		{
			TowerManager instance2 = TowerManager.Instance;
			GameAPP instance3 = GameAPP.Instance;
			MusicType musicType = instance2.musicType;
			instance3.PlayMusic(musicType);
			return;
		}
		int sceneType = (int)board.sceneType;
		bool flag;
		if (flag)
		{
			GameAPP instance4 = GameAPP.Instance;
			return;
		}
		if (board.sceneType <= SceneType.ShootingDay)
		{
			GameAPP instance5 = GameAPP.Instance;
			return;
		}
	}

	// Token: 0x06003282 RID: 12930 RVA: 0x0010BC2C File Offset: 0x00109E2C
	[Token(Token = "0x6003282")]
	[Address(RVA = "0x6EAC70", Offset = "0x6E9270", VA = "0x1806EAC70")]
	public static int GetMagnetValue(BucketType bucketType)
	{
		if (bucketType <= BucketType.Door)
		{
		}
		return 0;
	}

	// Token: 0x06003283 RID: 12931 RVA: 0x0010BC4C File Offset: 0x00109E4C
	[Token(Token = "0x6003283")]
	[Address(RVA = "0x6EA1F0", Offset = "0x6E87F0", VA = "0x1806EA1F0")]
	public static float GetGloveCD()
	{
		Board instance = Board.Instance;
		bool flag;
		int num;
		if (instance.freeCD || instance.enermyCount == 0 || flag || instance.enermyCount == 0)
		{
			int theBoardLevel = GameAPP.theBoardLevel;
			num = 0;
			return ExploreDataManager.GetExploreData(theBoardLevel).gloveCD;
		}
		if (num > 98)
		{
			while (num == 104)
			{
			}
			num += -111;
			while (num == 104)
			{
			}
			while (num == 104)
			{
			}
			while (num == 104)
			{
			}
			while (num != 1)
			{
			}
		}
		while (18446744073709551520UL == (ulong)4294967293L)
		{
		}
		if (num > 65)
		{
			if (num > 73)
			{
				while (num == 76)
				{
				}
				if (18446744073709551536UL <= (ulong)8L)
				{
				}
				while (num == 93)
				{
				}
			}
			if (num == 68)
			{
				goto IL_010E;
			}
		}
		if (num > 17)
		{
			while (-38 == 0)
			{
			}
			while (-38 == 0)
			{
			}
			while (-38 == 0)
			{
			}
			while (-38 == 0)
			{
			}
			if (18446744073709551578UL == (ulong)1L)
			{
				goto IL_010E;
			}
		}
		while (18446744073709551601UL != (ulong)4294967293L)
		{
		}
		IL_010E:
		throw new NullReferenceException();
	}

	// Token: 0x06003284 RID: 12932 RVA: 0x0010BD74 File Offset: 0x00109F74
	[Token(Token = "0x6003284")]
	[Address(RVA = "0x6E7FA0", Offset = "0x6E65A0", VA = "0x1806E7FA0")]
	public static void ConnectPlant(int column)
	{
		do
		{
			int num = 0;
			int num2 = 0;
			Board instance = Board.Instance;
			if (num2 >= instance.rowNum)
			{
				break;
			}
			int num3 = 0;
			GridSystem gridSystem = Board.Instance.gridSystem;
			List<Plant> plants = gridSystem.GetGrid(column, num).plants;
			GridSystem gridSystem2 = Board.Instance.gridSystem;
			Plant plant = gridSystem2.GetGrid(column, num).plants[num3];
			int num4 = 0;
			if (plant != num4 && plant.isConnected)
			{
				plant.DisConnected();
			}
			num3++;
			num++;
		}
		while (Board.Instance != 0);
		int num5 = 0;
		int num6 = 0;
		int rowNum = Board.Instance.rowNum;
		if (num6 < rowNum)
		{
			int num7 = 0;
			List<Plant> plants2 = Board.Instance.gridSystem.GetGrid(column, num5).plants;
			Plant plant2 = Board.Instance.gridSystem.GetGrid(column, num5).plants[num7];
			int num8 = 0;
			if (plant2 != num8 && !plant2.isConnected)
			{
				Plant sameLower = plant2.SameLower;
				int num9 = 0;
				if (sameLower != num9)
				{
					plant2.Connected(sameLower);
					sameLower.Connected(plant2);
				}
			}
			num7++;
			num5++;
			Board instance2 = Board.Instance;
		}
	}

	// Token: 0x06003285 RID: 12933 RVA: 0x0010BEC4 File Offset: 0x0010A0C4
	[Token(Token = "0x6003285")]
	[Address(RVA = "0x6E7CF0", Offset = "0x6E62F0", VA = "0x1806E7CF0")]
	public static void ClearPlant(PlantType thePlantType, Board board)
	{
		ulong num4;
		do
		{
			int num = 0;
			List<Plant> list = new List();
			List<Plant> plantArray = board.boardEntity.plantArray;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
			}
			ulong num3;
			if (num3 != (ulong)0L)
			{
				goto IL_004C;
			}
			bool flag2;
			if (flag2)
			{
			}
		}
		while (num4 != (ulong)0L);
		return;
		IL_004C:
		throw new NullReferenceException();
	}

	// Token: 0x06003286 RID: 12934 RVA: 0x0010BF24 File Offset: 0x0010A124
	[Token(Token = "0x6003286")]
	[Address(RVA = "0x6EBED0", Offset = "0x6EA4D0", VA = "0x1806EBED0")]
	public static Vector2Int GetRandomBox(Board board)
	{
		int columnNum = board.columnNum;
		int num = global::UnityEngine.Random.Range(0, columnNum);
		int rowNum = board.rowNum;
		int num2 = global::UnityEngine.Random.Range(0, rowNum);
		throw new NullReferenceException();
	}

	// Token: 0x06003287 RID: 12935 RVA: 0x0010BF60 File Offset: 0x0010A160
	[Token(Token = "0x6003287")]
	[Address(RVA = "0x6EBF20", Offset = "0x6EA520", VA = "0x1806EBF20")]
	public static List<Vector2Int> GetRandomBoxes(Board board, int count)
	{
		List<Vector2Int> list = new List();
		int num = 0;
		if (num < board.columnNum)
		{
			if (num < board.rowNum)
			{
				num++;
			}
			num++;
		}
		List<Vector2Int> list2 = new List();
		if (count > 0)
		{
			int num2 = list._size;
			int num3 = global::UnityEngine.Random.Range(0, num2);
			num2 = num3;
			Vector2Int vector2Int = list[num2];
			list.RemoveAt(num3);
			num++;
		}
		return list2;
	}

	// Token: 0x06003288 RID: 12936 RVA: 0x0010BFD4 File Offset: 0x0010A1D4
	[Token(Token = "0x6003288")]
	[Address(RVA = "0x6EC820", Offset = "0x6EAE20", VA = "0x1806EC820")]
	public static List<Vector2Int> GetRandomFreeBoxes(Board board, int count, Func<Plant, bool> func)
	{
		List<Vector2Int> list;
		int num;
		do
		{
			list = new List();
			num = 0;
			if (num >= board.columnNum)
			{
				goto IL_004B;
			}
			if (num >= board.rowNum)
			{
				goto IL_0047;
			}
			List<Plant> plants = board.gridSystem.GetGrid(num, num).plants;
			bool flag;
			if (flag)
			{
				while (!flag)
				{
				}
			}
		}
		while (num != 0);
		int num2 = 0;
		num++;
		IL_0047:
		num++;
		IL_004B:
		List<Vector2Int> list2 = new List();
		int num3 = list._size;
		int num4 = global::UnityEngine.Random.Range(0, num3);
		num3 = num4;
		Vector2Int vector2Int = list[num3];
		list.RemoveAt(num4);
		num2++;
		return list2;
	}

	// Token: 0x06003289 RID: 12937 RVA: 0x0010C07C File Offset: 0x0010A27C
	[Token(Token = "0x6003289")]
	[Address(RVA = "0x6ED050", Offset = "0x6EB650", VA = "0x1806ED050")]
	public static ZombieType GetRandomUltimateZombie([Optional] List<ZombieType> excludeTypes, [Optional] List<ZombieType> extraTypes)
	{
		List<ZombieType> list;
		for (;;)
		{
			int num = 0;
			list = new List();
			Dictionary<ZombieType, GameObject> zombiePrefabs = GameAPP.resourcesManager.zombiePrefabs;
			bool flag;
			if (flag)
			{
				bool flag2;
				while (flag2)
				{
				}
				bool flag3;
				while (!flag3)
				{
				}
				bool flag4;
				while (flag4)
				{
				}
				bool flag5;
				while (flag5)
				{
				}
			}
			ulong num2;
			if (num2 == (ulong)0L)
			{
				bool flag6 = list.Remove((uint)210);
				if (excludeTypes != (ulong)0L)
				{
					Predicate<ZombieType> predicate = delegate(ZombieType p)
					{
						List<ZombieType> excludeTypes2 = excludeTypes;
						bool flag8;
						return flag8;
					};
					int num3 = list.RemoveAll(predicate);
				}
				bool flag7;
				ulong num4;
				if ((!flag7 || !list.Contains(num)) && num4 == (ulong)0L)
				{
					break;
				}
			}
		}
		int num5 = list._size;
		num5 = global::UnityEngine.Random.Range(0, num5);
		return list[num5];
	}

	// Token: 0x0600328A RID: 12938 RVA: 0x0010C14C File Offset: 0x0010A34C
	[Token(Token = "0x600328A")]
	[Address(RVA = "0x6EC0B0", Offset = "0x6EA6B0", VA = "0x1806EC0B0")]
	public static ZombieType GetRandomBungiType(bool ultimate)
	{
		List<ZombieType> list = new List();
		if (global::Lawnf.TravelDebuff((TravelDebuff)((uint)20)) && global::UnityEngine.Random.Range(0, 3) == 0)
		{
			List<ZombieType> list2 = new List();
			int size = list2._size;
			list2._size = list2;
			int size2 = list2._size;
			list2._size = list2;
			int size3 = list2._size;
			list2._size = list2;
			int size4 = list2._size;
			list2._size = list2;
			int size5 = list2._size;
			list2._size = list2;
			int size6 = list2._size;
			list2._size = list2;
			int size7 = list2._size;
			list2._size = list2;
			int size8 = list2._size;
			list2._size = list2;
			int size9 = list2._size;
			list2._size = list2;
			int size10 = list2._size;
			list2._size = list2;
			int size11 = list2._size;
			list2._size = list2;
			int size12 = list2._size;
			list2._size = list2;
			int size13 = list2._size;
			list2._size = list2;
		}
		List<ZombieType> list3 = new List();
		int size14 = list3._size;
		list3._size = list3;
		int size15 = list3._size;
		list3._size = list3;
		int size16 = list3._size;
		list3._size = list3;
		int size17 = list3._size;
		list3._size = list3;
		int size18 = list3._size;
		list3._size = list3;
		int size19 = list3._size;
		list3._size = list3;
		int num = list3._size;
		num = global::UnityEngine.Random.Range(0, num);
		return list3[num];
	}

	// Token: 0x0600328B RID: 12939 RVA: 0x0010C2E4 File Offset: 0x0010A4E4
	[Token(Token = "0x600328B")]
	[Address(RVA = "0x6EB5E0", Offset = "0x6E9BE0", VA = "0x1806EB5E0")]
	public static Vector2 GetPlantPosition(Board board, int theColumn, int theRow, PlantType theSeedType, [Optional] Vector2 pos)
	{
		float boxXFromColumn = Mouse.Instance.GetBoxXFromColumn(theColumn);
		float landY = Mouse.Instance.GetLandY(boxXFromColumn, theRow);
		bool flag;
		if (theColumn >= 5 || flag)
		{
		}
		if (theColumn < board.columnNum)
		{
		}
		int num = 0;
		bool flag2;
		if (!flag2 && num != 0)
		{
			bool flag3 = board.gridSystem.HasPot(theColumn, theRow);
			if (!flag3 || !flag3)
			{
			}
		}
		if (num == 0)
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x0600328C RID: 12940 RVA: 0x0010C358 File Offset: 0x0010A558
	[Token(Token = "0x600328C")]
	[Address(RVA = "0x6E9930", Offset = "0x6E7F30", VA = "0x1806E9930")]
	public static List<Plant> GetBejeweledConnect(Plant plant)
	{
		List<Plant> list;
		HashSet<Plant> hashSet2;
		Plant sameLower2;
		do
		{
			int num = 0;
			if (plant == num)
			{
				goto IL_0124;
			}
			list = new List();
			List<Plant> list2 = new List();
			List<Plant> list3 = new List();
			HashSet<Plant> hashSet = new HashSet();
			bool flag = hashSet.Add(plant);
			hashSet2 = new HashSet();
			bool flag2 = hashSet2.Add(plant);
			Plant sameLeft = plant.SameLeft;
			int num2 = 0;
			if (sameLeft != num2)
			{
				Plant sameLeft2 = plant.SameLeft;
				if (hashSet.Add(sameLeft2))
				{
					Plant sameLeft3 = plant.SameLeft;
				}
			}
			Plant sameRight = plant.SameRight;
			int num3 = 0;
			if (sameRight != num3)
			{
				Plant sameRight2 = plant.SameRight;
				if (hashSet.Add(sameRight2) && plant.SameRight != 0)
				{
					continue;
				}
			}
			Plant sameUpper = plant.SameUpper;
			int num4 = 0;
			if (sameUpper != num4)
			{
				Plant sameUpper2 = plant.SameUpper;
				if (hashSet2.Add(sameUpper2) && plant.SameUpper != 0)
				{
					continue;
				}
			}
			Plant sameLower = plant.SameLower;
			int num5 = 0;
			if (!(sameLower != num5))
			{
				break;
			}
			sameLower2 = plant.SameLower;
		}
		while (hashSet2.Add(sameLower2) && plant.SameLower != 0);
		return list;
		IL_0124:
		return new List();
	}

	// Token: 0x0600328D RID: 12941 RVA: 0x0010C494 File Offset: 0x0010A694
	[Token(Token = "0x600328D")]
	[Address(RVA = "0x6EBA10", Offset = "0x6EA010", VA = "0x1806EBA10")]
	public static Plant GetPlant(int theColumn, int theRow, Board board)
	{
		ulong num3;
		do
		{
			int num = 0;
			List<Plant> plants = board.gridSystem.GetGrid(theRow, theRow).plants;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
			}
		}
		while (num3 != (ulong)0L);
		return null;
	}

	// Token: 0x0600328E RID: 12942 RVA: 0x0010C4D8 File Offset: 0x0010A6D8
	[Token(Token = "0x600328E")]
	[Address(RVA = "0x6E8780", Offset = "0x6E6D80", VA = "0x1806E8780")]
	public static void ExchangePlant(Plant plant1, Plant plant2, Board board)
	{
		int num = 0;
		if (!(plant1 == num))
		{
			int num2 = 0;
			if (!(plant2 == num2))
			{
				GridSystem gridSystem = board.gridSystem;
				int thePlantRow = plant1.thePlantRow;
				int thePlantColumn = plant1.thePlantColumn;
				bool flag = gridSystem.GetGrid(thePlantColumn, thePlantRow).plants.Remove(plant1);
				GridSystem gridSystem2 = board.gridSystem;
				int thePlantRow2 = plant2.thePlantRow;
				int thePlantColumn2 = plant2.thePlantColumn;
				bool flag2 = gridSystem2.GetGrid(thePlantColumn2, thePlantRow2).plants.Remove(plant2);
				GridSystem gridSystem3 = board.gridSystem;
				int thePlantRow3 = plant1.thePlantRow;
				int thePlantColumn3 = plant1.thePlantColumn;
				List<Plant> plants = gridSystem3.GetGrid(thePlantColumn3, thePlantRow3).plants;
				GridSystem gridSystem4 = board.gridSystem;
				int thePlantRow4 = plant2.thePlantRow;
				int thePlantColumn4 = plant2.thePlantColumn;
				List<Plant> plants2 = gridSystem4.GetGrid(thePlantColumn4, thePlantRow4).plants;
				int thePlantColumn5 = plant2.thePlantColumn;
				int thePlantColumn6 = plant1.thePlantColumn;
				int thePlantRow5 = plant1.thePlantRow;
				plant1.thePlantColumn = thePlantColumn5;
				int thePlantRow6 = plant2.thePlantRow;
				plant1.thePlantRow = thePlantRow6;
				plant2.thePlantColumn = thePlantColumn6;
				plant2.thePlantRow = thePlantRow5;
			}
		}
	}

	// Token: 0x0600328F RID: 12943 RVA: 0x0010C5FC File Offset: 0x0010A7FC
	[Token(Token = "0x600328F")]
	[Address(RVA = "0x6EEEA0", Offset = "0x6ED4A0", VA = "0x1806EEEA0")]
	public static PrizeMgr SetAward(Board board, Vector2 position, bool killZombie = false, bool fake = false)
	{
		string text = "Board/Award/TrophyPrefab";
		if (fake)
		{
			text = "Board/Award/FakeTrophyPrefab";
		}
		GameObject gameObject = Resources.Load<GameObject>(text);
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = board.transform;
		Camera main = Camera.main;
		GameObject gameObject2;
		Transform transform2 = gameObject2.transform;
		Transform transform3 = gameObject2.transform;
		Camera main2 = Camera.main;
		Transform transform4 = gameObject2.transform;
		Transform transform5 = gameObject2.transform;
		Transform transform6 = gameObject2.transform;
		if (killZombie)
		{
			int size = board.zombieArray._size;
			int num = size - 1;
			if (size > 0)
			{
				Zombie zombie = board.zombieArray[num];
				int num2 = 0;
				if (zombie != num2)
				{
					int num3 = 0;
					zombie.Die(num3);
				}
			}
			board.boardTag.disableSummonZombie = true;
		}
		return gameObject2.GetComponent<PrizeMgr>();
	}

	// Token: 0x06003290 RID: 12944 RVA: 0x0010C6D0 File Offset: 0x0010A8D0
	[Token(Token = "0x6003290")]
	[Address(RVA = "0x6ED820", Offset = "0x6EBE20", VA = "0x1806ED820")]
	public static int GetScaryPotNum(Board board)
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			List<GridItem> griditemArray = board.griditemArray;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3))
				{
					continue;
				}
				if (18446744073709551612UL > (ulong)2L)
				{
					while (18446744073709551607UL > (ulong)3L)
					{
					}
				}
				num2++;
			}
		}
		while (num2 != 0);
		return num2;
	}

	// Token: 0x06003291 RID: 12945 RVA: 0x0010C724 File Offset: 0x0010A924
	[Token(Token = "0x6003291")]
	[Address(RVA = "0x6ECDF0", Offset = "0x6EB3F0", VA = "0x1806ECDF0")]
	public static List<PlantType> GetRandomPlant()
	{
		List<PlantType> list = new List();
		int num = 0;
		List<PlantType> allPlants = GameAPP.resourcesManager.allPlants;
		int num2 = GameAPP.resourcesManager.allPlants[num];
		bool flag;
		bool flag2;
		bool flag3;
		bool flag4;
		if (flag || flag2 || flag3 || flag4 || (num2 > 233 && ((num2 > 250 && (num2 == 256 || num2 == 1169)) || flag4 <= true || num2 == 250)) || flag4 <= true)
		{
		}
		num++;
		return list;
	}

	// Token: 0x06003292 RID: 12946 RVA: 0x0010C7B4 File Offset: 0x0010A9B4
	[Token(Token = "0x6003292")]
	[Address(RVA = "0x6EA530", Offset = "0x6E8B30", VA = "0x1806EA530")]
	public static PlantType GetHappyRandomPlantType(Board board)
	{
		List<PlantType> list;
		ulong num9;
		do
		{
			int i = 0;
			uint num2;
			int num = global::UnityEngine.Random.Range(0, (int)num2);
			list = new List();
			int num3 = 0;
			float num4 = (float)(0 * (int)50f);
			if (0 > (int)num4 || num4 > 1f)
			{
			}
			int num5 = 0;
			List<PlantType> allPlantTypes = global::Lawnf.GetAllPlantTypes();
			Predicate<PlantType> predicate;
			if (global::Lawnf.<>c.<>9__54_0 == 0)
			{
				predicate = delegate(PlantType p)
				{
					bool flag5;
					return flag5;
				};
				global::Lawnf.<>c.<>9__54_0 = predicate;
			}
			int num6 = allPlantTypes.RemoveAll(predicate);
			if (num5 > num3)
			{
				bool flag;
				if (flag && !global::Lawnf.IsUltiPlant((PlantType)i))
				{
					continue;
				}
				ulong num7;
				if (num7 != (ulong)0L)
				{
					goto IL_00ED;
				}
			}
			bool flag2;
			if (flag2)
			{
			}
			ulong num8;
			if (num8 != (ulong)0L)
			{
				goto IL_00F3;
			}
			bool flag3;
			if (flag3)
			{
				while (i >= 200)
				{
				}
			}
		}
		while (num9 != (ulong)0L);
		int num10 = list._size;
		int num11 = global::UnityEngine.Random.Range(0, num10);
		num10 = num11;
		int num12 = list[num10];
		num10 = num11;
		list.RemoveAt(num10);
		bool flag4;
		while (flag4)
		{
		}
		throw new NullReferenceException();
		IL_00ED:
		throw new NullReferenceException();
		IL_00F3:
		throw new NullReferenceException();
	}

	// Token: 0x06003293 RID: 12947 RVA: 0x0010C8C4 File Offset: 0x0010AAC4
	[Token(Token = "0x6003293")]
	[Address(RVA = "0x6EED80", Offset = "0x6ED380", VA = "0x1806EED80")]
	public static bool PresentLim(PlantType theSeedType)
	{
		if (theSeedType > PlantType.Present)
		{
			if (theSeedType > PlantType.CactusBlover)
			{
				if (theSeedType == PlantType.CacstusStar || theSeedType == PlantType.BigPumpkin || theSeedType == PlantType.SunJalapeno)
				{
					return true;
				}
				return false;
			}
			else
			{
				while (theSeedType == PlantType.UltimateFly)
				{
				}
				while (theSeedType == PlantType.GoldHypnoDoom)
				{
				}
			}
		}
		if (theSeedType > PlantType.SnowPresent)
		{
			while (theSeedType == PlantType.PresentZombie)
			{
			}
		}
		while (theSeedType == PlantType.VectorPlant)
		{
		}
		while (theSeedType == PlantType.SnowPresent)
		{
		}
		return false;
	}

	// Token: 0x06003294 RID: 12948 RVA: 0x0010C930 File Offset: 0x0010AB30
	[Token(Token = "0x6003294")]
	[Address(RVA = "0x6ECDA0", Offset = "0x6EB3A0", VA = "0x1806ECDA0")]
	public static int GetRandomPlantLevel()
	{
		if (global::UnityEngine.Random.Range(0, 100) < 50)
		{
			return 1;
		}
		return 0;
	}

	// Token: 0x06003295 RID: 12949 RVA: 0x0010C950 File Offset: 0x0010AB50
	[Token(Token = "0x6003295")]
	[Address(RVA = "0x6E7CC0", Offset = "0x6E62C0", VA = "0x1806E7CC0")]
	public static int CheckPlantClass(PlantType thePlantType)
	{
		bool flag = global::Lawnf.IsUltiPlant(thePlantType) + true;
		return 0;
	}

	// Token: 0x06003296 RID: 12950 RVA: 0x0010C970 File Offset: 0x0010AB70
	[Token(Token = "0x6003296")]
	[Address(RVA = "0x6EE940", Offset = "0x6ECF40", VA = "0x1806EE940")]
	public static bool IsSuperPlant(PlantType thePlantType)
	{
		if (thePlantType > PlantType.SuperMelon)
		{
			if (thePlantType > PlantType.SuperSpruce)
			{
				if (thePlantType > PlantType.BigGloom && thePlantType != PlantType.HelmetGatling && thePlantType != PlantType.CabbageCannon && thePlantType != PlantType.MagicSnowPea)
				{
					goto IL_009D;
				}
				while (thePlantType == PlantType.SuperFurnace)
				{
				}
				while (thePlantType == PlantType.HugeWallNut)
				{
				}
				while (thePlantType == PlantType.BigGloom)
				{
				}
			}
			int i;
			if (thePlantType > PlantType.BigGatling)
			{
				while (thePlantType == PlantType.BigPumpkin)
				{
				}
				while (thePlantType == PlantType.SuperSpruce)
				{
				}
				i = 0;
			}
			while (i == -17)
			{
			}
			while (i <= 1)
			{
			}
			goto IL_0075;
		}
		goto IL_0075;
		IL_00A0:
		while (thePlantType == PlantType.GoldScaryPot)
		{
		}
		while (thePlantType == PlantType.Hamburger)
		{
		}
		return thePlantType == PlantType.SwordStar;
		IL_0075:
		if (thePlantType > PlantType.SuperHypno)
		{
			while (thePlantType == PlantType.SuperPumpkin)
			{
			}
			while (thePlantType == PlantType.SuperMelon)
			{
			}
		}
		if (thePlantType > PlantType.SwordStar)
		{
			if (thePlantType <= PlantType.Cactus)
			{
			}
		}
		IL_009D:
		goto IL_00A0;
	}

	// Token: 0x06003297 RID: 12951 RVA: 0x0010CA38 File Offset: 0x0010AC38
	[Token(Token = "0x6003297")]
	[Address(RVA = "0x6EE8A0", Offset = "0x6ECEA0", VA = "0x1806EE8A0")]
	public static bool IsSecondPlant(PlantType thePlantType)
	{
		bool flag;
		if (!global::Lawnf.IsSuperPlant(thePlantType) && !flag)
		{
			HashSet<PlantType> baiscPlants = CoreEnums.baiscPlants;
			bool flag2;
			return flag2;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06003298 RID: 12952 RVA: 0x0010CA68 File Offset: 0x0010AC68
	[Token(Token = "0x6003298")]
	[Address(RVA = "0x6EE820", Offset = "0x6ECE20", VA = "0x1806EE820")]
	public static bool IsBasicPlant(PlantType thePlantType)
	{
		HashSet<PlantType> baiscPlants = CoreEnums.baiscPlants;
		bool flag;
		return flag;
	}

	// Token: 0x06003299 RID: 12953 RVA: 0x0010CA84 File Offset: 0x0010AC84
	[Token(Token = "0x6003299")]
	[Address(RVA = "0x6EEAD0", Offset = "0x6ED0D0", VA = "0x1806EEAD0")]
	public static bool IsUltiPlant(PlantType thePlantType)
	{
		if (thePlantType > PlantType.SuperSnowGatling)
		{
			if (thePlantType > PlantType.GarlicSniper && ((thePlantType > PlantType.SuperGatlingPumpkin && (typeof(TypeMgr).TypeHandle <= (ulong)1L || thePlantType == PlantType.StarSniper || thePlantType == PlantType.SuperGatlingPeaMine)) || thePlantType == PlantType.SuperCherryGatling || thePlantType == PlantType.SniperPot || thePlantType == PlantType.SuperGatlingPumpkin))
			{
				return true;
			}
			if (thePlantType > PlantType.DoomSniper && typeof(TypeMgr).TypeHandle > (ulong)39L)
			{
				goto IL_00C7;
			}
			if (typeof(TypeMgr).TypeHandle <= (ulong)1L || typeof(TypeMgr).TypeHandle <= (ulong)1L)
			{
				return true;
			}
		}
		if (thePlantType > PlantType.ObsidianWheat)
		{
			if ((thePlantType > PlantType.AshThreePeater && typeof(TypeMgr).TypeHandle > (ulong)56L) || thePlantType == PlantType.EndoFlameGirl || (thePlantType != PlantType.UltimateFly && thePlantType != PlantType.AshThreePeater))
			{
				return true;
			}
		}
		if (typeof(TypeMgr).TypeHandle <= (ulong)24L)
		{
		}
		IL_00C7:
		HashSet<PlantType> redPlant = TypeMgr.RedPlant;
		bool flag;
		return flag;
	}

	// Token: 0x0600329A RID: 12954 RVA: 0x0010CB68 File Offset: 0x0010AD68
	[Token(Token = "0x600329A")]
	[Address(RVA = "0x6E6000", Offset = "0x6E4600", VA = "0x1806E6000")]
	public static bool BannedInAbyss(PlantType thePlantType)
	{
		return thePlantType == PlantType.SuperSunNut;
	}

	// Token: 0x0600329B RID: 12955 RVA: 0x0010CB80 File Offset: 0x0010AD80
	[Token(Token = "0x600329B")]
	[Address(RVA = "0x6ED9A0", Offset = "0x6EBFA0", VA = "0x1806ED9A0")]
	public static int GetSuperPlantCount(Board board)
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			List<Plant> plantArray = board.boardEntity.plantArray;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3) || !global::Lawnf.IsSuperPlant((PlantType)num))
				{
					continue;
				}
				num2++;
			}
		}
		while (num2 != 0);
		return num2;
	}

	// Token: 0x0600329C RID: 12956 RVA: 0x0010CBD4 File Offset: 0x0010ADD4
	[Token(Token = "0x600329C")]
	[Address(RVA = "0x6EB350", Offset = "0x6E9950", VA = "0x1806EB350")]
	public static int GetPlantCount(Board board)
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			List<Plant> plantArray = board.boardEntity.plantArray;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3) || TypeMgr.IsLily((PlantType)num))
				{
					continue;
				}
				num2++;
			}
		}
		while (num2 != 0);
		return num2;
	}

	// Token: 0x0600329D RID: 12957 RVA: 0x0010CC28 File Offset: 0x0010AE28
	[Token(Token = "0x600329D")]
	[Address(RVA = "0x6EDB30", Offset = "0x6EC130", VA = "0x1806EDB30")]
	public static int GetUltiPlantCount(Board board)
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			List<Plant> plantArray = board.boardEntity.plantArray;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3) || !global::Lawnf.IsUltiPlant((PlantType)num))
				{
					continue;
				}
				num2++;
			}
		}
		while (num2 != 0);
		return num2;
	}

	// Token: 0x0600329E RID: 12958 RVA: 0x0010CC7C File Offset: 0x0010AE7C
	[Token(Token = "0x600329E")]
	[Address(RVA = "0x6EB9D0", Offset = "0x6E9FD0", VA = "0x1806EB9D0")]
	public static int GetPlantUpgradeCost(PlantType thePlantType, int targetLevel)
	{
		if (global::Lawnf.IsUltiPlant(thePlantType))
		{
			long num = (long)(targetLevel * (int)((uint)1500));
		}
		long num2 = (long)(targetLevel * (int)((uint)150));
		long num3 = (long)(targetLevel * (int)((uint)50));
		return 0;
	}

	// Token: 0x0600329F RID: 12959 RVA: 0x0010CCAC File Offset: 0x0010AEAC
	[Token(Token = "0x600329F")]
	[Address(RVA = "0x6EDE40", Offset = "0x6EC440", VA = "0x1806EDE40")]
	public static int GetUpgradedPlantCost(PlantType thePlantType, int targetLevel)
	{
		int num = 0;
		bool flag = global::Lawnf.IsUltiPlant(thePlantType);
		int num2 = targetLevel + 1;
		if (flag)
		{
			long num3 = (long)(num2 * targetLevel * (int)((uint)1500));
			num3 -= (long)num;
		}
		long num4 = (long)(num2 * targetLevel * (int)((uint)150));
		num4 -= (long)num;
		long num5 = (long)(1U * (uint)50);
		num5 -= (long)num;
		return 0;
	}

	// Token: 0x060032A0 RID: 12960 RVA: 0x0010CCFC File Offset: 0x0010AEFC
	[Token(Token = "0x60032A0")]
	[Address(RVA = "0x6E65A0", Offset = "0x6E4BA0", VA = "0x1806E65A0")]
	public static UnlockType CheckIfPlantUnlock(PlantType thePlantType)
	{
		for (;;)
		{
			int num = 0;
			Dictionary<PlantType, int> unlockPlantLevel = TowerData.UnlockPlantLevel;
			bool flag;
			if (!flag)
			{
				if (thePlantType > PlantType.SpikeRock)
				{
					if (thePlantType > PlantType.GloomShroom)
					{
						if (thePlantType == PlantType.CobCannon)
						{
							bool[] advLevelCompleted = GameAPP.advLevelCompleted;
							bool flag2 = "{il2cpp array field local5->}" == num;
						}
						if (thePlantType == PlantType.SpruceBallista)
						{
							goto IL_0441;
						}
					}
					bool flag3;
					if (thePlantType == PlantType.CattailPlant)
					{
						bool[] advLevelCompleted2 = GameAPP.advLevelCompleted;
						flag3 = "{il2cpp array field local9->}" == num;
					}
					bool[] advLevelCompleted3 = GameAPP.advLevelCompleted;
					bool flag4 = "{il2cpp array field local12->}" == flag3;
				}
				bool flag5;
				if (thePlantType > PlantType.Present)
				{
					if (thePlantType == PlantType.TallNut)
					{
					}
					while (thePlantType != PlantType.SpikeRock)
					{
					}
					bool[] advLevelCompleted4 = GameAPP.advLevelCompleted;
					flag5 = "{il2cpp array field local16->}" == num;
				}
				bool[] advLevelCompleted5 = GameAPP.advLevelCompleted;
				bool flag6 = "{il2cpp array field local20->}" == flag5;
				bool[] advLevelCompleted6 = GameAPP.advLevelCompleted;
				bool flag7 = "{il2cpp array field local23->}" == flag6;
				bool[] advLevelCompleted7 = GameAPP.advLevelCompleted;
				bool flag8 = "{il2cpp array field local26->}" == flag7;
				bool[] advLevelCompleted8 = GameAPP.advLevelCompleted;
				bool flag9 = "{il2cpp array field local29->}" == flag8;
				bool[] advLevelCompleted9 = GameAPP.advLevelCompleted;
				bool flag10 = "{il2cpp array field local32->}" == flag9;
				bool[] advLevelCompleted10 = GameAPP.advLevelCompleted;
				bool flag11 = "{il2cpp array field local35->}" == flag10;
				bool[] advLevelCompleted11 = GameAPP.advLevelCompleted;
				bool flag12 = "{il2cpp array field local38->}" == flag11;
				bool[] advLevelCompleted12 = GameAPP.advLevelCompleted;
				bool flag13 = "{il2cpp array field local41->}" == flag12;
				bool[] advLevelCompleted13 = GameAPP.advLevelCompleted;
				bool flag14 = "{il2cpp array field local44->}" == flag13;
				bool[] advLevelCompleted14 = GameAPP.advLevelCompleted;
				bool flag15 = "{il2cpp array field local47->}" == flag14;
				bool[] advLevelCompleted15 = GameAPP.advLevelCompleted;
				bool flag16 = "{il2cpp array field local50->}" == flag15;
				bool[] advLevelCompleted16 = GameAPP.advLevelCompleted;
				bool flag17 = "{il2cpp array field local53->}" == flag16;
				bool[] advLevelCompleted17 = GameAPP.advLevelCompleted;
				bool flag18 = "{il2cpp array field local56->}" == flag17;
				bool[] advLevelCompleted18 = GameAPP.advLevelCompleted;
				bool flag19 = "{il2cpp array field local59->}" == flag18;
				bool[] advLevelCompleted19 = GameAPP.advLevelCompleted;
				bool flag20 = "{il2cpp array field local62->}" == flag19;
				bool[] advLevelCompleted20 = GameAPP.advLevelCompleted;
				bool flag21 = "{il2cpp array field local65->}" == flag20;
				bool[] advLevelCompleted21 = GameAPP.advLevelCompleted;
				bool flag22 = "{il2cpp array field local68->}" == flag21;
				bool[] advLevelCompleted22 = GameAPP.advLevelCompleted;
				bool flag23 = "{il2cpp array field local71->}" == flag22;
				bool[] advLevelCompleted23 = GameAPP.advLevelCompleted;
				bool flag24 = "{il2cpp array field local74->}" == flag23;
				bool[] advLevelCompleted24 = GameAPP.advLevelCompleted;
				bool flag25 = "{il2cpp array field local77->}" == flag24;
				bool[] advLevelCompleted25 = GameAPP.advLevelCompleted;
				bool flag26 = "{il2cpp array field local80->}" == flag25;
				bool[] advLevelCompleted26 = GameAPP.advLevelCompleted;
				bool flag27 = "{il2cpp array field local83->}" == flag26;
				bool[] advLevelCompleted27 = GameAPP.advLevelCompleted;
				bool flag28 = "{il2cpp array field local86->}" == flag27;
				bool[] advLevelCompleted28 = GameAPP.advLevelCompleted;
				bool flag29 = "{il2cpp array field local89->}" == flag28;
				bool[] advLevelCompleted29 = GameAPP.advLevelCompleted;
				bool flag30 = "{il2cpp array field local92->}" == flag29;
				bool[] advLevelCompleted30 = GameAPP.advLevelCompleted;
				bool flag31 = "{il2cpp array field local95->}" == flag30;
				bool[] advLevelCompleted31 = GameAPP.advLevelCompleted;
				bool flag32 = "{il2cpp array field local98->}" == flag31;
				bool[] advLevelCompleted32 = GameAPP.advLevelCompleted;
				bool flag33 = "{il2cpp array field local101->}" == flag32;
				bool[] advLevelCompleted33 = GameAPP.advLevelCompleted;
				bool flag34 = "{il2cpp array field local104->}" == flag33;
				bool[] advLevelCompleted34 = GameAPP.advLevelCompleted;
				bool flag35 = "{il2cpp array field local107->}" == flag34;
				bool flag36 = "{il2cpp field on {'constant343' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0x88}" <= (ulong)2L;
				bool flag37 = "{il2cpp field on {'constant351' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0x88}" <= (ulong)1L;
				bool flag38 = "{il2cpp field on {'constant359' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0x88}" <= (ulong)3L;
				bool flag39 = "{il2cpp field on {'constant367' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0x88}" <= (ulong)4L;
				bool flag40 = "{il2cpp field on {'constant375' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0x88}" <= (ulong)5L;
				bool flag41 = "{il2cpp field on {'constant383' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0x88}" <= (ulong)6L;
				if (0 > 36)
				{
					continue;
				}
				bool[] clgLevelCompleted = GameAPP.clgLevelCompleted;
				bool flag42;
				if ("{il2cpp array field local123->}" != flag41)
				{
					bool[] clgLevelCompleted2 = GameAPP.clgLevelCompleted;
					if ("{il2cpp array field local124->}" != flag41)
					{
						flag42 = GameAPP.clgLevelCompleted[22];
						bool flag43 = flag42;
					}
				}
				bool flag44 = !flag42;
				flag42 = flag44;
				bool[] clgLevelCompleted3 = GameAPP.clgLevelCompleted;
				bool flag45 = "{il2cpp array field local131->}" == flag44;
				IL_0441:
				bool flag46 = "{il2cpp field on {'constant426' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0x88}" <= (ulong)7L;
				bool[] advLevelCompleted35 = GameAPP.advLevelCompleted;
				bool flag47 = "{il2cpp array field local136->}" == flag46;
				bool[] advLevelCompleted36 = GameAPP.advLevelCompleted;
				bool flag48 = "{il2cpp array field local139->}" == flag47;
				bool[] clgLevelCompleted4 = GameAPP.clgLevelCompleted;
				bool flag49 = "{il2cpp array field local142->}" == flag48;
				bool[] survivalLevelCompleted = GameAPP.survivalLevelCompleted;
				bool flag50 = "{il2cpp array field local145->}" == flag49;
				bool[] clgLevelCompleted5 = GameAPP.clgLevelCompleted;
				bool flag51 = "{il2cpp array field local148->}" == flag50;
				bool[] clgLevelCompleted6 = GameAPP.clgLevelCompleted;
				if ("{il2cpp array field local151->}" != flag51)
				{
					break;
				}
			}
		}
		uint num2;
		bool flag52 = num2 != (uint)0;
		bool flag53 = "{il2cpp field on {'constant492' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0x98}" != (ulong)162L;
		bool[] clgLevelCompleted7 = GameAPP.clgLevelCompleted;
		if ("{il2cpp array field local157->}" != flag53)
		{
			uint num3;
			bool flag54 = num3 == (uint)0;
		}
		bool flag55 = !GameAPP.clgLevelCompleted[11];
		return UnlockType.Unlocked;
	}

	// Token: 0x060032A1 RID: 12961 RVA: 0x0010D244 File Offset: 0x0010B444
	[Token(Token = "0x60032A1")]
	[Address(RVA = "0x6F0330", Offset = "0x6EE930", VA = "0x1806F0330")]
	public static bool TravelHell()
	{
		if (TravelMgr.Instance.data.travelDifficulty == TravelDifficulty.Normal)
		{
			int num = GameAPP.theBoardLevel;
			if (num != 16)
			{
				num += -34;
				if (num <= 4)
				{
				}
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x060032A2 RID: 12962 RVA: 0x0010D284 File Offset: 0x0010B484
	[Token(Token = "0x60032A2")]
	[Address(RVA = "0x6EEE20", Offset = "0x6ED420", VA = "0x1806EEE20")]
	public static bool RogueLevel()
	{
		return "{il2cpp field on {'constant14' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0x98}" == (ulong)30L;
	}

	// Token: 0x060032A3 RID: 12963 RVA: 0x0010D2A0 File Offset: 0x0010B4A0
	[Token(Token = "0x60032A3")]
	[Address(RVA = "0x6EDCC0", Offset = "0x6EC2C0", VA = "0x1806EDCC0")]
	public static List<PlantType> GetUltimatePlants()
	{
		List<PlantType> allPlants = GameAPP.resourcesManager.allPlants;
		Func<PlantType, bool> <>9__71_ = global::Lawnf.<>c.<>9__71_0;
		if (<>9__71_ == 0)
		{
			global::Lawnf.<>c.<>9__71_0 = delegate(PlantType a)
			{
				bool flag;
				return flag;
			};
		}
		return Enumerable.ToList<PlantType>(Enumerable.Where<PlantType>(allPlants, <>9__71_));
	}

	// Token: 0x060032A4 RID: 12964 RVA: 0x0010D2F4 File Offset: 0x0010B4F4
	[Token(Token = "0x60032A4")]
	[Address(RVA = "0x6E9340", Offset = "0x6E7940", VA = "0x1806E9340")]
	public static List<PlantType> GetAllPlantTypes()
	{
		List<PlantType> list;
		ulong num;
		do
		{
			list = new List();
			List<PlantType> allPlants = GameAPP.resourcesManager.allPlants;
			bool flag;
			if (flag)
			{
				int size = list._size;
				list._size = (flag ? 1 : 0);
			}
		}
		while (num != (ulong)0L);
		return list;
	}

	// Token: 0x060032A5 RID: 12965 RVA: 0x0010D358 File Offset: 0x0010B558
	[Token(Token = "0x60032A5")]
	[Address(RVA = "0x6EE650", Offset = "0x6ECC50", VA = "0x1806EE650")]
	public static bool InDodgeStatus(ZombieStatus zombieStatus)
	{
		return zombieStatus == ZombieStatus.Bungi_awake;
	}

	// Token: 0x060032A6 RID: 12966 RVA: 0x0010D370 File Offset: 0x0010B570
	[Token(Token = "0x60032A6")]
	[Address(RVA = "0x6F01B0", Offset = "0x6EE7B0", VA = "0x1806F01B0")]
	public static bool TowerPlant(PlantType thePlantType)
	{
		if (thePlantType < PlantType.Tower_peasunflower)
		{
		}
		return thePlantType < (PlantType)500;
	}

	// Token: 0x060032A7 RID: 12967 RVA: 0x0010D394 File Offset: 0x0010B594
	[Token(Token = "0x60032A7")]
	[Address(RVA = "0x6EAEB0", Offset = "0x6E94B0", VA = "0x1806EAEB0")]
	public static int GetMowerCount(Board board)
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			List<Mower> mowerArray = board.mowerArray;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3))
				{
					continue;
				}
				num2++;
			}
		}
		while (num2 != 0);
		return num2;
	}

	// Token: 0x060032A8 RID: 12968 RVA: 0x0010D3D8 File Offset: 0x0010B5D8
	[Token(Token = "0x60032A8")]
	[Address(RVA = "0x6EA140", Offset = "0x6E8740", VA = "0x1806EA140")]
	public static CrackStatus GetCrackStatus(float value, float fullValue)
	{
		if (value <= fullValue)
		{
			float num;
			bool flag = global::Core.Lawnf.ValueBetween(value, fullValue, num);
		}
		return CrackStatus.Good;
	}

	// Token: 0x060032A9 RID: 12969 RVA: 0x0010D400 File Offset: 0x0010B600
	[Token(Token = "0x60032A9")]
	[Address(RVA = "0x6E62B0", Offset = "0x6E48B0", VA = "0x1806E62B0")]
	public static void ChangeSprite(float value, float fullValue, GameObject obj)
	{
		int num = 0;
		bool flag;
		if (obj != num && flag)
		{
			float num2;
			if (value <= num2)
			{
				float num3;
				if (!global::Core.Lawnf.ValueBetween(num2, fullValue, num3))
				{
					int num4 = 0;
					Transform transform;
					GameObject gameObject = transform.GetChild(num4).gameObject;
					int num5 = 0;
					gameObject.SetActive(num5 != 0);
					Transform transform2;
					transform2.GetChild(1).gameObject.SetActive(true);
					return;
				}
				int num6 = 0;
				Transform transform3;
				GameObject gameObject2 = transform3.GetChild(num6).gameObject;
			}
			int num7 = 0;
			Transform transform4;
			GameObject gameObject3 = transform4.GetChild(num7).gameObject;
			int num8 = 0;
			gameObject3.SetActive(num8 != 0);
			Transform transform5;
			GameObject gameObject4 = transform5.GetChild(1).gameObject;
			throw new NullReferenceException();
		}
	}

	// Token: 0x060032AA RID: 12970 RVA: 0x0010D4B0 File Offset: 0x0010B6B0
	[Token(Token = "0x60032AA")]
	[Address(RVA = "0x6EAB30", Offset = "0x6E9130", VA = "0x1806EAB30")]
	public static bool GetKeyDown(KeyCode keyCode)
	{
		if (typeof(GameAPP).TypeHandle == 0)
		{
		}
		return true;
	}

	// Token: 0x060032AB RID: 12971 RVA: 0x0010D4CC File Offset: 0x0010B6CC
	[Token(Token = "0x60032AB")]
	[Address(RVA = "0x6EABD0", Offset = "0x6E91D0", VA = "0x1806EABD0")]
	public static bool GetKey(KeyCode keyCode)
	{
		if (typeof(GameAPP).TypeHandle == 0)
		{
			List<KeyCode> keyCode2 = GameAPP.keyCode2;
			bool flag;
			if (!flag)
			{
				return flag;
			}
		}
		return true;
	}

	// Token: 0x060032AC RID: 12972 RVA: 0x0010D4F8 File Offset: 0x0010B6F8
	[Token(Token = "0x60032AC")]
	[Address(RVA = "0x6E9E30", Offset = "0x6E8430", VA = "0x1806E9E30")]
	public static float GetBoxXFromColumn(int theColumn)
	{
		float num;
		return num;
	}

	// Token: 0x060032AD RID: 12973 RVA: 0x0010D50C File Offset: 0x0010B70C
	[Token(Token = "0x60032AD")]
	[Address(RVA = "0x6E9E50", Offset = "0x6E8450", VA = "0x1806E9E50")]
	public static float GetBoxYFromRow(int theRow, int rowNum = 5)
	{
		if (rowNum != 6)
		{
			return 0f;
		}
		return 0f;
	}

	// Token: 0x060032AE RID: 12974 RVA: 0x0010D528 File Offset: 0x0010B728
	[Token(Token = "0x60032AE")]
	[Address(RVA = "0x6ED800", Offset = "0x6EBE00", VA = "0x1806ED800")]
	public static int GetRowFromY(float y)
	{
		return 0;
	}

	// Token: 0x060032AF RID: 12975 RVA: 0x0010D538 File Offset: 0x0010B738
	[Token(Token = "0x60032AF")]
	[Address(RVA = "0x6EA120", Offset = "0x6E8720", VA = "0x1806EA120")]
	public static int GetColumnFromX(float x)
	{
		return 0;
	}

	// Token: 0x060032B0 RID: 12976 RVA: 0x0010D548 File Offset: 0x0010B748
	[Token(Token = "0x60032B0")]
	[Address(RVA = "0x6EE6F0", Offset = "0x6ECCF0", VA = "0x1806EE6F0")]
	public static bool InLandStatus(ZombieStatus status)
	{
		return status != ZombieStatus.Bungi_awake;
	}

	// Token: 0x060032B1 RID: 12977 RVA: 0x0010D564 File Offset: 0x0010B764
	[Token(Token = "0x60032B1")]
	[Address(RVA = "0x6EE790", Offset = "0x6ECD90", VA = "0x1806EE790")]
	public static bool InLandUpStatus(ZombieStatus status)
	{
		if (status != ZombieStatus.Snokle_inWater)
		{
			return status != ZombieStatus.Bungi_awake;
		}
		int num = 0;
		num = (int)(num + status);
		return false;
	}

	// Token: 0x060032B2 RID: 12978 RVA: 0x0010D588 File Offset: 0x0010B788
	[Token(Token = "0x60032B2")]
	[Address(RVA = "0x6EE800", Offset = "0x6ECE00", VA = "0x1806EE800")]
	public static bool InNotWudiStatus(ZombieStatus status)
	{
		return status != ZombieStatus.Boss;
	}

	// Token: 0x060032B3 RID: 12979 RVA: 0x0010D5A0 File Offset: 0x0010B7A0
	[Token(Token = "0x60032B3")]
	[Address(RVA = "0x6EE810", Offset = "0x6ECE10", VA = "0x1806EE810")]
	public static bool InUpStatus(ZombieStatus status)
	{
		return status != ZombieStatus.Miner_digging && status != ZombieStatus.Boss;
	}

	// Token: 0x060032B4 RID: 12980 RVA: 0x0010D5C0 File Offset: 0x0010B7C0
	[Token(Token = "0x60032B4")]
	[Address(RVA = "0x6F0130", Offset = "0x6EE730", VA = "0x1806F0130")]
	public static bool ThrowLandStatus(ZombieStatus status)
	{
		if (status != ZombieStatus.Pol_jump)
		{
			return status != ZombieStatus.Bungi_awake;
		}
		int num = 0;
		num = (int)(num + status);
		return false;
	}

	// Token: 0x060032B5 RID: 12981 RVA: 0x0010D5E4 File Offset: 0x0010B7E4
	[Token(Token = "0x60032B5")]
	[Address(RVA = "0x6F0600", Offset = "0x6EEC00", VA = "0x1806F0600")]
	public static bool UnlockRandomTravelBuff(Board board)
	{
		List<object> list = new List();
		TravelMgr instance = TravelMgr.Instance;
		int num = 0;
		List<AdvBuff> advancedBuffPool = instance.GetAdvancedBuffPool(num != 0);
		list.AddRange(advancedBuffPool);
		UltiBuff[] enumValues = global::Core.Lawnf.GetEnumValues<UltiBuff>();
		int num2 = 0;
		int num3 = 0;
		if (num2 < enumValues.Length)
		{
			List<UltiBuff> ultiBuffs = TravelMgr.Instance.data.ultiBuffs;
			bool flag;
			if (!flag)
			{
			}
			num3++;
		}
		int num4 = list._size;
		num4 = global::UnityEngine.Random.Range(0, num4);
		object obj = list[num4];
		if (obj != 0)
		{
			if (obj != 0)
			{
				goto IL_00BF;
			}
			if (obj != 0)
			{
				TravelMgr instance2 = TravelMgr.Instance;
			}
		}
		InGameText instance3 = InGameText.Instance;
		string text = TravelMgr.Instance.GetText(obj);
		ulong num5;
		instance3.ShowText(text, 10f, num5 != 0UL);
		IL_00BF:
		TravelMgr instance4 = TravelMgr.Instance;
		throw new NullReferenceException();
	}

	// Token: 0x060032B6 RID: 12982 RVA: 0x0010D6C4 File Offset: 0x0010B8C4
	[Token(Token = "0x60032B6")]
	[Address(RVA = "0x6EEC80", Offset = "0x6ED280", VA = "0x1806EEC80")]
	public static bool NearPlant3x3(Plant centerPlant, Vector2Int position, PlantType plantType)
	{
		int x = position.m_X;
		List<Plant> list;
		Func<Plant, bool> func;
		return Enumerable.Any<Plant>(list, func);
	}

	// Token: 0x060032B7 RID: 12983 RVA: 0x0010D700 File Offset: 0x0010B900
	[Token(Token = "0x60032B7")]
	[Address(RVA = "0x6E8F20", Offset = "0x6E7520", VA = "0x1806E8F20")]
	public static AirProjectile GetAirProjectile(Vector2 center, float r, LayerMask layerMask)
	{
		int mask = layerMask.m_Mask;
		int num = 0;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			bool flag2;
			if (!flag || num == 0 || num == 0 || flag2)
			{
			}
			num++;
		}
		throw new NullReferenceException();
	}

	// Token: 0x060032B8 RID: 12984 RVA: 0x0010D73C File Offset: 0x0010B93C
	[Token(Token = "0x60032B8")]
	[Address(RVA = "0x6E90D0", Offset = "0x6E76D0", VA = "0x1806E90D0")]
	public static List<AirProjectile> GetAirProjectiles(Vector2 center, float r, LayerMask layerMask)
	{
		int mask = layerMask.m_Mask;
		int num = 0;
		List<AirProjectile> list = new List();
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag && num != 0 && num != 0)
			{
				bool flag2;
				if (flag2)
				{
				}
				if (num == 0 || num != 0)
				{
				}
			}
			num++;
		}
		return list;
	}

	// Token: 0x060032B9 RID: 12985 RVA: 0x0010D794 File Offset: 0x0010B994
	[Token(Token = "0x60032B9")]
	[Address(RVA = "0x6EB120", Offset = "0x6E9720", VA = "0x1806EB120")]
	public static Zombie GetNearestZombie(Board board, Vector2 position, Func<Zombie, bool> condition)
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			List<Zombie> zombieArray = board.zombieArray;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				bool flag2 = num != num3;
				while (!flag2)
				{
				}
				while (!flag2)
				{
				}
			}
		}
		while (num2 != 0);
		throw new NullReferenceException();
	}

	// Token: 0x060032BA RID: 12986 RVA: 0x0010D7E8 File Offset: 0x0010B9E8
	[Token(Token = "0x60032BA")]
	[Address(RVA = "0x6EACE0", Offset = "0x6E92E0", VA = "0x1806EACE0")]
	public static Zombie GetMostHealthZombie(Board board, Func<Zombie, bool> condition)
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			List<Zombie> zombieArray = board.zombieArray;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				bool flag2 = num != num3;
				while (!flag2)
				{
				}
				while (!flag2)
				{
				}
				float num4;
				while (num4 <= -3.4028235E+38f)
				{
				}
			}
		}
		while (num2 != 0);
		throw new NullReferenceException();
	}

	// Token: 0x060032BB RID: 12987 RVA: 0x0010D840 File Offset: 0x0010BA40
	[Token(Token = "0x60032BB")]
	[Address(RVA = "0x6EDEA0", Offset = "0x6EC4A0", VA = "0x1806EDEA0")]
	public static float GetZombieY(float x, int row)
	{
		float landY = Mouse.Instance.GetLandY(x, row);
		Board instance = Board.Instance;
		return landY;
	}

	// Token: 0x060032BC RID: 12988 RVA: 0x0010D870 File Offset: 0x0010BA70
	[Token(Token = "0x60032BC")]
	[Address(RVA = "0x6EB090", Offset = "0x6E9690", VA = "0x1806EB090")]
	public static string GetName(PlantType thePlantType)
	{
		PlantInfo plantInfo;
		if (plantInfo == 0)
		{
			string text = "魅惑僵尸";
			if (thePlantType != PlantType.Synergy_魅惑僵尸)
			{
				text = "未命名";
			}
			return text;
		}
		return plantInfo.name;
	}

	// Token: 0x060032BD RID: 12989 RVA: 0x0010D8A4 File Offset: 0x0010BAA4
	[Token(Token = "0x60032BD")]
	[Address(RVA = "0x6EB020", Offset = "0x6E9620", VA = "0x1806EB020")]
	public static string GetName(ZombieType theZombieType)
	{
		ZombieInfo zombieInfo;
		if (zombieInfo == 0)
		{
			return "未命名";
		}
		return zombieInfo.name;
	}

	// Token: 0x060032BE RID: 12990 RVA: 0x0010D8C8 File Offset: 0x0010BAC8
	[Token(Token = "0x60032BE")]
	[Address(RVA = "0x6EBBD0", Offset = "0x6EA1D0", VA = "0x1806EBBD0")]
	public static List<Plant> GetPlantsByRow(Board board, int row)
	{
		List<Plant> list;
		int num;
		ulong num2;
		do
		{
			list = new List();
			num = 0;
			if (num >= board.columnNum)
			{
				return list;
			}
			List<Plant> list2 = global::Lawnf.Get1x1Plants(num, row);
			bool flag;
			if (flag)
			{
			}
		}
		while (num2 != (ulong)0L);
		num++;
		return list;
	}

	// Token: 0x060032BF RID: 12991 RVA: 0x0010D91C File Offset: 0x0010BB1C
	[Token(Token = "0x60032BF")]
	[Address(RVA = "0x6EA060", Offset = "0x6E8660", VA = "0x1806EA060")]
	public static List<Zombie> GetCertainZombies(Board board, ZombieType zombieType)
	{
		Dictionary<ZombieType, List<Zombie>> zombieHeads = board.zombieHeads;
		bool flag;
		if (!flag)
		{
			return new List();
		}
		throw new NullReferenceException();
	}
}
