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

// Token: 0x020009E4 RID: 2532
[Token(Token = "0x20009E4")]
public static class Lawnf
{
	// Token: 0x06003390 RID: 13200 RVA: 0x0010FCD4 File Offset: 0x0010DED4
	[Token(Token = "0x6003390")]
	[Address(RVA = "0xA775E0", Offset = "0xA75BE0", VA = "0x180A775E0")]
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

	// Token: 0x06003391 RID: 13201 RVA: 0x0010FD68 File Offset: 0x0010DF68
	[Token(Token = "0x6003391")]
	[Address(RVA = "0x752100", Offset = "0x750700", VA = "0x180752100")]
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

	// Token: 0x06003392 RID: 13202 RVA: 0x0010FDE0 File Offset: 0x0010DFE0
	[Token(Token = "0x6003392")]
	[Address(RVA = "0x750AC0", Offset = "0x74F0C0", VA = "0x180750AC0")]
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

	// Token: 0x06003393 RID: 13203 RVA: 0x0010FE14 File Offset: 0x0010E014
	[Token(Token = "0x6003393")]
	[Address(RVA = "0x751350", Offset = "0x74F950", VA = "0x180751350")]
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

	// Token: 0x06003394 RID: 13204 RVA: 0x0010FE50 File Offset: 0x0010E050
	[Token(Token = "0x6003394")]
	[Address(RVA = "0x74F390", Offset = "0x74D990", VA = "0x18074F390")]
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

	// Token: 0x06003395 RID: 13205 RVA: 0x0010FEAC File Offset: 0x0010E0AC
	[Token(Token = "0x6003395")]
	[Address(RVA = "0x74EA50", Offset = "0x74D050", VA = "0x18074EA50")]
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

	// Token: 0x06003396 RID: 13206 RVA: 0x0010FF08 File Offset: 0x0010E108
	[Token(Token = "0x6003396")]
	[Address(RVA = "0x750D90", Offset = "0x74F390", VA = "0x180750D90")]
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

	// Token: 0x06003397 RID: 13207 RVA: 0x0010FF74 File Offset: 0x0010E174
	[Token(Token = "0x6003397")]
	[Address(RVA = "0x74EC40", Offset = "0x74D240", VA = "0x18074EC40")]
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

	// Token: 0x06003398 RID: 13208 RVA: 0x0010FFD0 File Offset: 0x0010E1D0
	[Token(Token = "0x6003398")]
	[Address(RVA = "0x753700", Offset = "0x751D00", VA = "0x180753700")]
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

	// Token: 0x06003399 RID: 13209 RVA: 0x0011003C File Offset: 0x0010E23C
	[Token(Token = "0x6003399")]
	[Address(RVA = "0x7534F0", Offset = "0x751AF0", VA = "0x1807534F0")]
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

	// Token: 0x0600339A RID: 13210 RVA: 0x00110098 File Offset: 0x0010E298
	[Token(Token = "0x600339A")]
	[Address(RVA = "0x755DE0", Offset = "0x7543E0", VA = "0x180755DE0")]
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
					goto IL_00F8;
				}
				num++;
				int num3 = 0;
				Plant plant;
				if (!(plant == num3))
				{
					goto IL_00AB;
				}
				goto IL_00AB;
				IL_010A:
				Zombie zombie;
				if (zombie.TryGetComponent<ScaryPot>(num))
				{
					break;
				}
				continue;
				IL_00AB:
				if (!plant.TryGetComponent<Zombie>(num))
				{
					goto IL_010A;
				}
				bool flag3;
				ulong num4;
				int num5;
				if (flag3 && num4 != (ulong)0L && (num4 == (ulong)24L || num4 == (ulong)30L))
				{
					CreateZombie instance = CreateZombie.Instance;
					num5 = 0;
					if (zombie != num5)
					{
						zombie.isSplited = true;
						zombie.revived = true;
					}
				}
				IL_00F8:
				num++;
				int num6 = num.System.IConvertible.ToInt32(num5);
				num++;
				goto IL_010A;
			}
			return;
		}
		num++;
	}

	// Token: 0x0600339B RID: 13211 RVA: 0x001101C8 File Offset: 0x0010E3C8
	[Token(Token = "0x600339B")]
	[Address(RVA = "0x7558F0", Offset = "0x753EF0", VA = "0x1807558F0")]
	public static bool TravelUnlock(TravelUnlocks unlocks)
	{
		List<TravelUnlocks> unlockedPlants = TravelMgr.Instance.data.unlockedPlants;
		bool flag;
		return flag;
	}

	// Token: 0x0600339C RID: 13212 RVA: 0x001101F0 File Offset: 0x0010E3F0
	[Token(Token = "0x600339C")]
	[Address(RVA = "0x755540", Offset = "0x753B40", VA = "0x180755540")]
	public static bool TravelAdvanced(AdvBuff buff)
	{
		List<AdvBuff> advBuffs = TravelMgr.Instance.data.advBuffs;
		bool flag;
		return flag;
	}

	// Token: 0x0600339D RID: 13213 RVA: 0x00110218 File Offset: 0x0010E418
	[Token(Token = "0x600339D")]
	[Address(RVA = "0x753B10", Offset = "0x752110", VA = "0x180753B10")]
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

	// Token: 0x0600339E RID: 13214 RVA: 0x00110244 File Offset: 0x0010E444
	[Token(Token = "0x600339E")]
	[Address(RVA = "0x753940", Offset = "0x751F40", VA = "0x180753940")]
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

	// Token: 0x0600339F RID: 13215 RVA: 0x0011028C File Offset: 0x0010E48C
	[Token(Token = "0x600339F")]
	[Address(RVA = "0x755870", Offset = "0x753E70", VA = "0x180755870")]
	public static bool TravelUltimate(UltiBuff buff)
	{
		List<UltiBuff> ultiBuffs = TravelMgr.Instance.data.ultiBuffs;
		bool flag;
		return flag;
	}

	// Token: 0x060033A0 RID: 13216 RVA: 0x001102B4 File Offset: 0x0010E4B4
	[Token(Token = "0x60033A0")]
	[Address(RVA = "0x755800", Offset = "0x753E00", VA = "0x180755800")]
	public static int TravelUltimateLevel(UltiBuff buff)
	{
		TravelData data = TravelMgr.Instance.data;
		int num;
		return num;
	}

	// Token: 0x060033A1 RID: 13217 RVA: 0x001102D8 File Offset: 0x0010E4D8
	[Token(Token = "0x60033A1")]
	[Address(RVA = "0x755780", Offset = "0x753D80", VA = "0x180755780")]
	public static bool TravelInvest(InvestBuff investmentBuff)
	{
		List<InvestBuff> investmentBuffs = TravelMgr.Instance.data.investmentBuffs;
		bool flag;
		return flag;
	}

	// Token: 0x060033A2 RID: 13218 RVA: 0x00110300 File Offset: 0x0010E500
	[Token(Token = "0x60033A2")]
	[Address(RVA = "0x755620", Offset = "0x753C20", VA = "0x180755620")]
	public static bool TravelDebuff(TravelDebuff buff)
	{
		List<TravelDebuff> travelDebuffs = TravelMgr.Instance.data.travelDebuffs;
		bool flag;
		return flag;
	}

	// Token: 0x060033A3 RID: 13219 RVA: 0x00110328 File Offset: 0x0010E528
	[Token(Token = "0x60033A3")]
	[Address(RVA = "0x7555C0", Offset = "0x753BC0", VA = "0x1807555C0")]
	public static bool TravelCurse()
	{
		return TravelMgr.Instance.data.travelDifficulty == TravelDifficulty.Curse;
	}

	// Token: 0x060033A4 RID: 13220 RVA: 0x00110350 File Offset: 0x0010E550
	[Token(Token = "0x60033A4")]
	[Address(RVA = "0x74DBF0", Offset = "0x74C1F0", VA = "0x18074DBF0")]
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

	// Token: 0x060033A5 RID: 13221 RVA: 0x00110390 File Offset: 0x0010E590
	[Token(Token = "0x60033A5")]
	[Address(RVA = "0x752AE0", Offset = "0x7510E0", VA = "0x180752AE0")]
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

	// Token: 0x060033A6 RID: 13222 RVA: 0x001103FC File Offset: 0x0010E5FC
	[Token(Token = "0x60033A6")]
	[Address(RVA = "0x74E160", Offset = "0x74C760", VA = "0x18074E160")]
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

	// Token: 0x060033A7 RID: 13223 RVA: 0x0011047C File Offset: 0x0010E67C
	[Token(Token = "0x60033A7")]
	[Address(RVA = "0x74DF30", Offset = "0x74C530", VA = "0x18074DF30")]
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

	// Token: 0x060033A8 RID: 13224 RVA: 0x001104F4 File Offset: 0x0010E6F4
	[Token(Token = "0x60033A8")]
	[Address(RVA = "0x754890", Offset = "0x752E90", VA = "0x180754890")]
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

	// Token: 0x060033A9 RID: 13225 RVA: 0x0011054C File Offset: 0x0010E74C
	[Token(Token = "0x60033A9")]
	[Address(RVA = "0x754050", Offset = "0x752650", VA = "0x180754050")]
	public static bool IsTravelLevel(LevelType theLevelType, int theLevelNumber)
	{
		while (theLevelType != LevelType.Survival || (theLevelNumber > 12 && theLevelNumber == 16) || theLevelNumber == 8)
		{
			if (theLevelNumber == 12)
			{
			}
			if (theLevelNumber == 12)
			{
				return false;
			}
		}
		return theLevelNumber == 12;
	}

	// Token: 0x060033AA RID: 13226 RVA: 0x00110580 File Offset: 0x0010E780
	[Token(Token = "0x60033AA")]
	[Address(RVA = "0x755D60", Offset = "0x754360", VA = "0x180755D60")]
	public static bool WithTravelBuff(LevelType theLevelType, int theLevelNumber)
	{
		while (theLevelType != LevelType.Survival)
		{
			if (theLevelNumber == 22)
			{
			}
			if (theLevelNumber == 22)
			{
				return false;
			}
		}
		if (theLevelNumber <= 12 || theLevelNumber == 16 || theLevelNumber == 15)
		{
		}
		return theLevelNumber == 22;
	}

	// Token: 0x060033AB RID: 13227 RVA: 0x001105B4 File Offset: 0x0010E7B4
	[Token(Token = "0x60033AB")]
	[Address(RVA = "0x74DEB0", Offset = "0x74C4B0", VA = "0x18074DEB0")]
	public static void FastBuffs(TravelMgr travel)
	{
		travel.GetNormalBuff((AdvBuff)((uint)1002));
		travel.GetNormalBuff((AdvBuff)((uint)1003));
		travel.GetNormalBuff((AdvBuff)((uint)1006));
		travel.GetNormalBuff((AdvBuff)((uint)1000));
		travel.GetNormalBuff((AdvBuff)((uint)1005));
		travel.GetNormalBuff((AdvBuff)((uint)1001));
	}

	// Token: 0x060033AC RID: 13228 RVA: 0x00110610 File Offset: 0x0010E810
	[Token(Token = "0x60033AC")]
	[Address(RVA = "0x754FD0", Offset = "0x7535D0", VA = "0x180754FD0")]
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

	// Token: 0x060033AD RID: 13229 RVA: 0x0011068C File Offset: 0x0010E88C
	[Token(Token = "0x60033AD")]
	[Address(RVA = "0x7553E0", Offset = "0x7539E0", VA = "0x1807553E0")]
	public static void SetZombieHealth(Zombie zombie, float ratio)
	{
	}

	// Token: 0x060033AE RID: 13230 RVA: 0x001106A0 File Offset: 0x0010E8A0
	[Token(Token = "0x60033AE")]
	[Address(RVA = "0x7565D0", Offset = "0x754BD0", VA = "0x1807565D0")]
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

	// Token: 0x060033AF RID: 13231 RVA: 0x00110734 File Offset: 0x0010E934
	[Token(Token = "0x60033AF")]
	[Address(RVA = "0x74D840", Offset = "0x74BE40", VA = "0x18074D840")]
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

	// Token: 0x060033B0 RID: 13232 RVA: 0x001107A8 File Offset: 0x0010E9A8
	[Token(Token = "0x60033B0")]
	[Address(RVA = "0x74DA40", Offset = "0x74C040", VA = "0x18074DA40")]
	public static IZECard CreateZombieCardCard(ZombieType theZombieType, Vector2 position)
	{
		GameObject gameObject = GameAPP.itemPrefab[49];
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		GameObject gameObject2;
		IZECard component = gameObject2.GetComponent<IZECard>();
		component.theZombieType = theZombieType;
		return component;
	}

	// Token: 0x060033B1 RID: 13233 RVA: 0x001107E8 File Offset: 0x0010E9E8
	[Token(Token = "0x60033B1")]
	[Address(RVA = "0x7552E0", Offset = "0x7538E0", VA = "0x1807552E0")]
	public static ZombieCardPackage SetZombieCardPackage(ZombieType theZombieType)
	{
		GameObject[] itemPrefab = GameAPP.itemPrefab;
		Transform canvasUp = GameAPP.canvasUp;
		ZombieCardPackage component = global::UnityEngine.Object.Instantiate<GameObject>(itemPrefab[57], canvasUp).GetComponent<ZombieCardPackage>();
		component.card.theZombieType = theZombieType;
		return component;
	}

	// Token: 0x060033B2 RID: 13234 RVA: 0x0011082C File Offset: 0x0010EA2C
	[Token(Token = "0x60033B2")]
	[Address(RVA = "0x754F10", Offset = "0x753510", VA = "0x180754F10")]
	public static GameObject SetPlantCardPackage(PlantType thePlantType)
	{
		GameObject gameObject = GameAPP.itemPrefab[58];
		Transform canvasUp = GameAPP.canvasUp;
		return global::UnityEngine.Object.Instantiate<GameObject>(gameObject, canvasUp);
	}

	// Token: 0x060033B3 RID: 13235 RVA: 0x0011085C File Offset: 0x0010EA5C
	[Token(Token = "0x60033B3")]
	[Address(RVA = "0x74B520", Offset = "0x749B20", VA = "0x18074B520")]
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

	// Token: 0x060033B4 RID: 13236 RVA: 0x00110904 File Offset: 0x0010EB04
	[Token(Token = "0x60033B4")]
	[Address(RVA = "0x754A70", Offset = "0x753070", VA = "0x180754A70")]
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
		if (!flag)
		{
			SceneType sceneType2 = board.sceneType;
			GameAPP instance4 = GameAPP.Instance;
			if (sceneType2 <= SceneType.NightWinter)
			{
			}
			return;
		}
		GameAPP instance5 = GameAPP.Instance;
	}

	// Token: 0x060033B5 RID: 13237 RVA: 0x001109A8 File Offset: 0x0010EBA8
	[Token(Token = "0x60033B5")]
	[Address(RVA = "0x750200", Offset = "0x74E800", VA = "0x180750200")]
	public static int GetMagnetValue(BucketType bucketType)
	{
		if (bucketType <= BucketType.Door)
		{
		}
		return 0;
	}

	// Token: 0x060033B6 RID: 13238 RVA: 0x001109E8 File Offset: 0x0010EBE8
	[Token(Token = "0x60033B6")]
	[Address(RVA = "0x74F700", Offset = "0x74DD00", VA = "0x18074F700")]
	public static float GetGloveCD()
	{
		Board instance = Board.Instance;
		bool flag;
		int num;
		if (!instance.freeCD && instance.enermyCount != 0 && !flag)
		{
			List<InvestBuff> investmentBuffs = TravelMgr.Instance.data.investmentBuffs;
			bool flag2;
			if (!flag2 && instance.enermyCount != 0)
			{
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
						goto IL_0127;
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
						goto IL_0127;
					}
				}
				while (18446744073709551601UL != (ulong)4294967293L)
				{
				}
				IL_0127:
				throw new NullReferenceException();
			}
		}
		int theBoardLevel = GameAPP.theBoardLevel;
		num = 0;
		return ExploreDataManager.GetExploreData(theBoardLevel).gloveCD;
	}

	// Token: 0x060033B7 RID: 13239 RVA: 0x00110B28 File Offset: 0x0010ED28
	[Token(Token = "0x60033B7")]
	[Address(RVA = "0x74D4B0", Offset = "0x74BAB0", VA = "0x18074D4B0")]
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

	// Token: 0x060033B8 RID: 13240 RVA: 0x00110C78 File Offset: 0x0010EE78
	[Token(Token = "0x60033B8")]
	[Address(RVA = "0x74D200", Offset = "0x74B800", VA = "0x18074D200")]
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

	// Token: 0x060033B9 RID: 13241 RVA: 0x00110CD8 File Offset: 0x0010EED8
	[Token(Token = "0x60033B9")]
	[Address(RVA = "0x751480", Offset = "0x74FA80", VA = "0x180751480")]
	public static Vector2Int GetRandomBox(Board board)
	{
		int columnNum = board.columnNum;
		int num = global::UnityEngine.Random.Range(0, columnNum);
		int rowNum = board.rowNum;
		int num2 = global::UnityEngine.Random.Range(0, rowNum);
		throw new NullReferenceException();
	}

	// Token: 0x060033BA RID: 13242 RVA: 0x00110D14 File Offset: 0x0010EF14
	[Token(Token = "0x60033BA")]
	[Address(RVA = "0x7514D0", Offset = "0x74FAD0", VA = "0x1807514D0")]
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

	// Token: 0x060033BB RID: 13243 RVA: 0x00110D88 File Offset: 0x0010EF88
	[Token(Token = "0x60033BB")]
	[Address(RVA = "0x751DD0", Offset = "0x7503D0", VA = "0x180751DD0")]
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

	// Token: 0x060033BC RID: 13244 RVA: 0x00110E30 File Offset: 0x0010F030
	[Token(Token = "0x60033BC")]
	[Address(RVA = "0x752600", Offset = "0x750C00", VA = "0x180752600")]
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

	// Token: 0x060033BD RID: 13245 RVA: 0x00110F00 File Offset: 0x0010F100
	[Token(Token = "0x60033BD")]
	[Address(RVA = "0x751660", Offset = "0x74FC60", VA = "0x180751660")]
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

	// Token: 0x060033BE RID: 13246 RVA: 0x00111098 File Offset: 0x0010F298
	[Token(Token = "0x60033BE")]
	[Address(RVA = "0x750B90", Offset = "0x74F190", VA = "0x180750B90")]
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

	// Token: 0x060033BF RID: 13247 RVA: 0x0011110C File Offset: 0x0010F30C
	[Token(Token = "0x60033BF")]
	[Address(RVA = "0x74EE40", Offset = "0x74D440", VA = "0x18074EE40")]
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

	// Token: 0x060033C0 RID: 13248 RVA: 0x00111248 File Offset: 0x0010F448
	[Token(Token = "0x60033C0")]
	[Address(RVA = "0x750FC0", Offset = "0x74F5C0", VA = "0x180750FC0")]
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

	// Token: 0x060033C1 RID: 13249 RVA: 0x0011128C File Offset: 0x0010F48C
	[Token(Token = "0x60033C1")]
	[Address(RVA = "0x74DC90", Offset = "0x74C290", VA = "0x18074DC90")]
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

	// Token: 0x060033C2 RID: 13250 RVA: 0x001113B0 File Offset: 0x0010F5B0
	[Token(Token = "0x60033C2")]
	[Address(RVA = "0x7544C0", Offset = "0x752AC0", VA = "0x1807544C0")]
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

	// Token: 0x060033C3 RID: 13251 RVA: 0x00111484 File Offset: 0x0010F684
	[Token(Token = "0x60033C3")]
	[Address(RVA = "0x752DD0", Offset = "0x7513D0", VA = "0x180752DD0")]
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

	// Token: 0x060033C4 RID: 13252 RVA: 0x001114D8 File Offset: 0x0010F6D8
	[Token(Token = "0x60033C4")]
	[Address(RVA = "0x7523A0", Offset = "0x7509A0", VA = "0x1807523A0")]
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

	// Token: 0x060033C5 RID: 13253 RVA: 0x00111568 File Offset: 0x0010F768
	[Token(Token = "0x60033C5")]
	[Address(RVA = "0x74FAC0", Offset = "0x74E0C0", VA = "0x18074FAC0")]
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
			if (global::Lawnf.<>c.<>9__53_0 == 0)
			{
				predicate = delegate(PlantType p)
				{
					bool flag5;
					return flag5;
				};
				global::Lawnf.<>c.<>9__53_0 = predicate;
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

	// Token: 0x060033C6 RID: 13254 RVA: 0x00111678 File Offset: 0x0010F878
	[Token(Token = "0x60033C6")]
	[Address(RVA = "0x7543A0", Offset = "0x7529A0", VA = "0x1807543A0")]
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

	// Token: 0x060033C7 RID: 13255 RVA: 0x001116E4 File Offset: 0x0010F8E4
	[Token(Token = "0x60033C7")]
	[Address(RVA = "0x752350", Offset = "0x750950", VA = "0x180752350")]
	public static int GetRandomPlantLevel()
	{
		if (global::UnityEngine.Random.Range(0, 100) < 50)
		{
			return 1;
		}
		return 0;
	}

	// Token: 0x060033C8 RID: 13256 RVA: 0x00111704 File Offset: 0x0010F904
	[Token(Token = "0x60033C8")]
	[Address(RVA = "0x74D1D0", Offset = "0x74B7D0", VA = "0x18074D1D0")]
	public static int CheckPlantClass(PlantType thePlantType)
	{
		bool flag = global::Lawnf.IsUltiPlant(thePlantType) + true;
		return 0;
	}

	// Token: 0x060033C9 RID: 13257 RVA: 0x00111724 File Offset: 0x0010F924
	[Token(Token = "0x60033C9")]
	[Address(RVA = "0x753F30", Offset = "0x752530", VA = "0x180753F30")]
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

	// Token: 0x060033CA RID: 13258 RVA: 0x001117EC File Offset: 0x0010F9EC
	[Token(Token = "0x60033CA")]
	[Address(RVA = "0x753E90", Offset = "0x752490", VA = "0x180753E90")]
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

	// Token: 0x060033CB RID: 13259 RVA: 0x0011181C File Offset: 0x0010FA1C
	[Token(Token = "0x60033CB")]
	[Address(RVA = "0x753E50", Offset = "0x752450", VA = "0x180753E50")]
	public static bool IsLandPlant(Plant plant)
	{
		if (plant.plantTag == (ulong)0L)
		{
			return !plant.isLily;
		}
		throw new NullReferenceException();
	}

	// Token: 0x060033CC RID: 13260 RVA: 0x00111848 File Offset: 0x0010FA48
	[Token(Token = "0x60033CC")]
	[Address(RVA = "0x753DD0", Offset = "0x7523D0", VA = "0x180753DD0")]
	public static bool IsBasicPlant(PlantType thePlantType)
	{
		HashSet<PlantType> baiscPlants = CoreEnums.baiscPlants;
		bool flag;
		return flag;
	}

	// Token: 0x060033CD RID: 13261 RVA: 0x00111864 File Offset: 0x0010FA64
	[Token(Token = "0x60033CD")]
	[Address(RVA = "0x7540C0", Offset = "0x7526C0", VA = "0x1807540C0")]
	public static bool IsUltiPlant(PlantType thePlantType)
	{
		if (thePlantType > PlantType.SuperGatling)
		{
			if (thePlantType > PlantType.SniperPot)
			{
				if (thePlantType <= PlantType.StarSniper)
				{
					while (thePlantType == PlantType.SuperGatlingPumpkin)
					{
					}
					while (typeof(TypeMgr).TypeHandle <= (ulong)1L)
					{
					}
					while (thePlantType == PlantType.StarSniper)
					{
					}
					HashSet<PlantType> redPlant = TypeMgr.RedPlant;
					bool flag;
					return flag;
				}
				if (typeof(TypeMgr).TypeHandle <= (ulong)16L && typeof(TypeMgr).TypeHandle < (ulong)16L)
				{
					return true;
				}
				return true;
			}
			else
			{
				if (thePlantType > PlantType.SuperHypnoGatling)
				{
					while (thePlantType == PlantType.GarlicSniper)
					{
					}
					while (thePlantType == PlantType.SuperCherryGatling)
					{
					}
				}
				while (typeof(TypeMgr).TypeHandle <= (ulong)1L)
				{
				}
			}
		}
		int i;
		if (thePlantType > PlantType.EndoFlameGirl)
		{
			if (thePlantType > PlantType.SniperPea)
			{
				while (thePlantType == PlantType.SuperMachineNut)
				{
				}
				while (thePlantType == PlantType.SuperSnowGatling)
				{
				}
				while (typeof(TypeMgr).TypeHandle <= (ulong)1L)
				{
				}
			}
			if (thePlantType != PlantType.UltimateFly && thePlantType != PlantType.AshThreePeater)
			{
				while (thePlantType == PlantType.SniperPea)
				{
				}
				return true;
			}
			i = 0;
		}
		while (i > 26)
		{
		}
		while (i >= 26)
		{
		}
		return true;
	}

	// Token: 0x060033CE RID: 13262 RVA: 0x0011194C File Offset: 0x0010FB4C
	[Token(Token = "0x60033CE")]
	[Address(RVA = "0x74B510", Offset = "0x749B10", VA = "0x18074B510")]
	public static bool BannedInAbyss(PlantType thePlantType)
	{
		return thePlantType == PlantType.SuperSunNut;
	}

	// Token: 0x060033CF RID: 13263 RVA: 0x00111964 File Offset: 0x0010FB64
	[Token(Token = "0x60033CF")]
	[Address(RVA = "0x752F50", Offset = "0x751550", VA = "0x180752F50")]
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

	// Token: 0x060033D0 RID: 13264 RVA: 0x001119B8 File Offset: 0x0010FBB8
	[Token(Token = "0x60033D0")]
	[Address(RVA = "0x750900", Offset = "0x74EF00", VA = "0x180750900")]
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

	// Token: 0x060033D1 RID: 13265 RVA: 0x00111A0C File Offset: 0x0010FC0C
	[Token(Token = "0x60033D1")]
	[Address(RVA = "0x7530E0", Offset = "0x7516E0", VA = "0x1807530E0")]
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

	// Token: 0x060033D2 RID: 13266 RVA: 0x00111A60 File Offset: 0x0010FC60
	[Token(Token = "0x60033D2")]
	[Address(RVA = "0x750F80", Offset = "0x74F580", VA = "0x180750F80")]
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

	// Token: 0x060033D3 RID: 13267 RVA: 0x00111A90 File Offset: 0x0010FC90
	[Token(Token = "0x60033D3")]
	[Address(RVA = "0x7533F0", Offset = "0x7519F0", VA = "0x1807533F0")]
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

	// Token: 0x060033D4 RID: 13268 RVA: 0x00111AE0 File Offset: 0x0010FCE0
	[Token(Token = "0x60033D4")]
	[Address(RVA = "0x74BAB0", Offset = "0x74A0B0", VA = "0x18074BAB0")]
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

	// Token: 0x060033D5 RID: 13269 RVA: 0x00112028 File Offset: 0x00110228
	[Token(Token = "0x60033D5")]
	[Address(RVA = "0x7556A0", Offset = "0x753CA0", VA = "0x1807556A0")]
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

	// Token: 0x060033D6 RID: 13270 RVA: 0x00112068 File Offset: 0x00110268
	[Token(Token = "0x60033D6")]
	[Address(RVA = "0x754440", Offset = "0x752A40", VA = "0x180754440")]
	public static bool RogueLevel()
	{
		return "{il2cpp field on {'constant14' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0x98}" == (ulong)30L;
	}

	// Token: 0x060033D7 RID: 13271 RVA: 0x00112084 File Offset: 0x00110284
	[Token(Token = "0x60033D7")]
	[Address(RVA = "0x753270", Offset = "0x751870", VA = "0x180753270")]
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

	// Token: 0x060033D8 RID: 13272 RVA: 0x001120D8 File Offset: 0x001102D8
	[Token(Token = "0x60033D8")]
	[Address(RVA = "0x74E850", Offset = "0x74CE50", VA = "0x18074E850")]
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

	// Token: 0x060033D9 RID: 13273 RVA: 0x0011213C File Offset: 0x0011033C
	[Token(Token = "0x60033D9")]
	[Address(RVA = "0x753C00", Offset = "0x752200", VA = "0x180753C00")]
	public static bool InDodgeStatus(ZombieStatus zombieStatus)
	{
		return zombieStatus == ZombieStatus.Bungi_awake;
	}

	// Token: 0x060033DA RID: 13274 RVA: 0x00112274 File Offset: 0x00110474
	[Token(Token = "0x60033DA")]
	[Address(RVA = "0x755520", Offset = "0x753B20", VA = "0x180755520")]
	public static bool TowerPlant(PlantType thePlantType)
	{
		if (thePlantType < PlantType.Tower_peasunflower)
		{
		}
		return thePlantType < (PlantType)500;
	}

	// Token: 0x060033DB RID: 13275 RVA: 0x00112298 File Offset: 0x00110498
	[Token(Token = "0x60033DB")]
	[Address(RVA = "0x750460", Offset = "0x74EA60", VA = "0x180750460")]
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

	// Token: 0x060033DC RID: 13276 RVA: 0x001122DC File Offset: 0x001104DC
	[Token(Token = "0x60033DC")]
	[Address(RVA = "0x74F650", Offset = "0x74DC50", VA = "0x18074F650")]
	public static CrackStatus GetCrackStatus(float value, float fullValue)
	{
		if (value <= fullValue)
		{
			float num;
			bool flag = global::Core.Lawnf.ValueBetween(value, fullValue, num);
		}
		return CrackStatus.Good;
	}

	// Token: 0x060033DD RID: 13277 RVA: 0x00112304 File Offset: 0x00110504
	[Token(Token = "0x60033DD")]
	[Address(RVA = "0x74B7C0", Offset = "0x749DC0", VA = "0x18074B7C0")]
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

	// Token: 0x060033DE RID: 13278 RVA: 0x001123B4 File Offset: 0x001105B4
	[Token(Token = "0x60033DE")]
	[Address(RVA = "0x7500C0", Offset = "0x74E6C0", VA = "0x1807500C0")]
	public static bool GetKeyDown(KeyCode keyCode)
	{
		if (typeof(GameAPP).TypeHandle == 0)
		{
		}
		return true;
	}

	// Token: 0x060033DF RID: 13279 RVA: 0x001123D0 File Offset: 0x001105D0
	[Token(Token = "0x60033DF")]
	[Address(RVA = "0x750160", Offset = "0x74E760", VA = "0x180750160")]
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

	// Token: 0x060033E0 RID: 13280 RVA: 0x001123FC File Offset: 0x001105FC
	[Token(Token = "0x60033E0")]
	[Address(RVA = "0x74F340", Offset = "0x74D940", VA = "0x18074F340")]
	public static float GetBoxXFromColumn(int theColumn)
	{
		float num;
		return num;
	}

	// Token: 0x060033E1 RID: 13281 RVA: 0x00112410 File Offset: 0x00110610
	[Token(Token = "0x60033E1")]
	[Address(RVA = "0x74F360", Offset = "0x74D960", VA = "0x18074F360")]
	public static float GetBoxYFromRow(int theRow, int rowNum = 5)
	{
		if (rowNum != 6)
		{
			return 0f;
		}
		return 0f;
	}

	// Token: 0x060033E2 RID: 13282 RVA: 0x0011242C File Offset: 0x0011062C
	[Token(Token = "0x60033E2")]
	[Address(RVA = "0x752DB0", Offset = "0x7513B0", VA = "0x180752DB0")]
	public static int GetRowFromY(float y)
	{
		return 0;
	}

	// Token: 0x060033E3 RID: 13283 RVA: 0x0011243C File Offset: 0x0011063C
	[Token(Token = "0x60033E3")]
	[Address(RVA = "0x74F630", Offset = "0x74DC30", VA = "0x18074F630")]
	public static int GetColumnFromX(float x)
	{
		return 0;
	}

	// Token: 0x060033E4 RID: 13284 RVA: 0x0011244C File Offset: 0x0011064C
	[Token(Token = "0x60033E4")]
	[Address(RVA = "0x753CA0", Offset = "0x7522A0", VA = "0x180753CA0")]
	public static bool InLandStatus(ZombieStatus status)
	{
		return status != ZombieStatus.Bungi_awake;
	}

	// Token: 0x060033E5 RID: 13285 RVA: 0x00112530 File Offset: 0x00110730
	[Token(Token = "0x60033E5")]
	[Address(RVA = "0x753D40", Offset = "0x752340", VA = "0x180753D40")]
	public static bool InLandUpStatus(ZombieStatus status)
	{
		while (status == ZombieStatus.Snokle_inWater)
		{
			int num = 0;
			if (status == ZombieStatus.Bungi_awake)
			{
			}
			if (status == ZombieStatus.Bungi_awake)
			{
			}
			if (num == 1030160501)
			{
			}
			if (num == 1030160501)
			{
			}
			if (num == 1030160501)
			{
			}
			if (num == 1030815861)
			{
			}
			if (num == 1030815861)
			{
			}
			if (num == 1030815861)
			{
			}
			if (num == 1030815861)
			{
				return false;
			}
		}
		return status != ZombieStatus.Bungi_awake;
	}

	// Token: 0x060033E6 RID: 13286 RVA: 0x00112590 File Offset: 0x00110790
	[Token(Token = "0x60033E6")]
	[Address(RVA = "0x753DB0", Offset = "0x7523B0", VA = "0x180753DB0")]
	public static bool InNotWudiStatus(ZombieStatus status)
	{
		return status != ZombieStatus.Boss;
	}

	// Token: 0x060033E7 RID: 13287 RVA: 0x001125A8 File Offset: 0x001107A8
	[Token(Token = "0x60033E7")]
	[Address(RVA = "0x753DC0", Offset = "0x7523C0", VA = "0x180753DC0")]
	public static bool InUpStatus(ZombieStatus status)
	{
		return status != ZombieStatus.Miner_digging && status != ZombieStatus.Boss;
	}

	// Token: 0x060033E8 RID: 13288 RVA: 0x001125C8 File Offset: 0x001107C8
	[Token(Token = "0x60033E8")]
	[Address(RVA = "0x7554A0", Offset = "0x753AA0", VA = "0x1807554A0")]
	public static bool ThrowLandStatus(ZombieStatus status)
	{
		while (status == ZombieStatus.Pol_jump)
		{
			if (status == ZombieStatus.Bungi_awake)
			{
			}
			if (status == ZombieStatus.Bungi_awake)
			{
			}
			if (status == ZombieStatus.Bungi_awake)
			{
			}
			if (status == ZombieStatus.Bungi_awake)
			{
			}
			if (status == ZombieStatus.Bungi_awake)
			{
			}
			if (status == ZombieStatus.Bungi_awake)
			{
			}
			if (status == ZombieStatus.Bungi_awake)
			{
				return false;
			}
		}
		return status != ZombieStatus.Bungi_awake;
	}

	// Token: 0x060033E9 RID: 13289 RVA: 0x00112608 File Offset: 0x00110808
	[Token(Token = "0x60033E9")]
	[Address(RVA = "0x755970", Offset = "0x753F70", VA = "0x180755970")]
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
				goto IL_00AF;
			}
			if (obj != 0)
			{
				TravelMgr instance2 = TravelMgr.Instance;
			}
		}
		InGameText instance3 = InGameText.Instance;
		string text = TravelMgr.Instance.GetText(obj);
		IL_00AF:
		TravelMgr instance4 = TravelMgr.Instance;
		throw new NullReferenceException();
	}

	// Token: 0x060033EA RID: 13290 RVA: 0x001126D8 File Offset: 0x001108D8
	[Token(Token = "0x60033EA")]
	[Address(RVA = "0x7542A0", Offset = "0x7528A0", VA = "0x1807542A0")]
	public static bool NearPlant3x3(Plant centerPlant, Vector2Int position, PlantType plantType)
	{
		int x = position.m_X;
		Func<Plant, bool> func = delegate(Plant plant)
		{
			Plant centerPlant2 = centerPlant;
			bool flag = plant != centerPlant2;
			if (!flag)
			{
				return flag;
			}
			PlantType plantType2 = plantType;
			return plant.thePlantType == plantType2;
		};
		List<Plant> list;
		return Enumerable.Any<Plant>(list, func);
	}

	// Token: 0x060033EB RID: 13291 RVA: 0x00112720 File Offset: 0x00110920
	[Token(Token = "0x60033EB")]
	[Address(RVA = "0x74E430", Offset = "0x74CA30", VA = "0x18074E430")]
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

	// Token: 0x060033EC RID: 13292 RVA: 0x0011275C File Offset: 0x0011095C
	[Token(Token = "0x60033EC")]
	[Address(RVA = "0x74E5E0", Offset = "0x74CBE0", VA = "0x18074E5E0")]
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

	// Token: 0x060033ED RID: 13293 RVA: 0x001127B4 File Offset: 0x001109B4
	[Token(Token = "0x60033ED")]
	[Address(RVA = "0x7506D0", Offset = "0x74ECD0", VA = "0x1807506D0")]
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

	// Token: 0x060033EE RID: 13294 RVA: 0x00112808 File Offset: 0x00110A08
	[Token(Token = "0x60033EE")]
	[Address(RVA = "0x750270", Offset = "0x74E870", VA = "0x180750270")]
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
			}
		}
		while (num2 != 0);
		throw new NullReferenceException();
	}

	// Token: 0x060033EF RID: 13295 RVA: 0x00112858 File Offset: 0x00110A58
	[Token(Token = "0x60033EF")]
	[Address(RVA = "0x753450", Offset = "0x751A50", VA = "0x180753450")]
	public static float GetZombieY(float x, int row)
	{
		float landY = Mouse.Instance.GetLandY(x, row);
		Board instance = Board.Instance;
		return landY;
	}

	// Token: 0x060033F0 RID: 13296 RVA: 0x00112888 File Offset: 0x00110A88
	[Token(Token = "0x60033F0")]
	[Address(RVA = "0x750640", Offset = "0x74EC40", VA = "0x180750640")]
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

	// Token: 0x060033F1 RID: 13297 RVA: 0x001128BC File Offset: 0x00110ABC
	[Token(Token = "0x60033F1")]
	[Address(RVA = "0x7505D0", Offset = "0x74EBD0", VA = "0x1807505D0")]
	public static string GetName(ZombieType theZombieType)
	{
		ZombieInfo zombieInfo;
		if (zombieInfo == 0)
		{
			return "未命名";
		}
		return zombieInfo.name;
	}

	// Token: 0x060033F2 RID: 13298 RVA: 0x001128E0 File Offset: 0x00110AE0
	[Token(Token = "0x60033F2")]
	[Address(RVA = "0x751180", Offset = "0x74F780", VA = "0x180751180")]
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

	// Token: 0x060033F3 RID: 13299 RVA: 0x00112934 File Offset: 0x00110B34
	[Token(Token = "0x60033F3")]
	[Address(RVA = "0x74F570", Offset = "0x74DB70", VA = "0x18074F570")]
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
