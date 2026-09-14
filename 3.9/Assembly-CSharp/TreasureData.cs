using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000645 RID: 1605
[Token(Token = "0x2000645")]
public class TreasureData
{
	// Token: 0x17000197 RID: 407
	// (get) Token: 0x06001E55 RID: 7765 RVA: 0x000A13AC File Offset: 0x0009F5AC
	[Token(Token = "0x17000197")]
	public static bool WareHouseUnfull
	{
		[Token(Token = "0x6001E55")]
		[Address(RVA = "0x5947D0", Offset = "0x592DD0", VA = "0x1805947D0")]
		get
		{
			List<TreasureCardData> list = TreasureData.treasureCards;
			Predicate<TreasureCardData> <>9__11_ = TreasureData.<>c.<>9__11_0;
			if (<>9__11_ == 0)
			{
				Predicate<TreasureCardData> predicate;
				TreasureData.<>c.<>9__11_0 = predicate;
			}
			long num;
			return (long)Enumerable.ToList<TreasureCardData>(list.FindAll(<>9__11_))._size < num;
		}
	}

	// Token: 0x06001E56 RID: 7766 RVA: 0x000A13EC File Offset: 0x0009F5EC
	[Token(Token = "0x6001E56")]
	[Address(RVA = "0x593010", Offset = "0x591610", VA = "0x180593010")]
	public static void ResetLevel()
	{
		List<TreasureCardData> list = TreasureData.treasureCards;
		int size = list._size;
		list._size = (int)((ulong)0L);
		if (size > 0)
		{
		}
		List<EquipmentData> list2 = TreasureData.equipmentData;
		int size2 = list2._size;
		list2._size = (int)((ulong)0L);
		if (size2 > 0)
		{
			return;
		}
	}

	// Token: 0x06001E57 RID: 7767 RVA: 0x000A143C File Offset: 0x0009F63C
	[Token(Token = "0x6001E57")]
	[Address(RVA = "0x591480", Offset = "0x58FA80", VA = "0x180591480")]
	public static void GetCard(TreasureCardData data)
	{
		int size = TreasureData.treasureCards._size;
	}

	// Token: 0x06001E58 RID: 7768 RVA: 0x000A145C File Offset: 0x0009F65C
	[Token(Token = "0x6001E58")]
	[Address(RVA = "0x593110", Offset = "0x591710", VA = "0x180593110")]
	public static TreasureSaveData SaveData()
	{
		TreasureSaveData treasureSaveData = new TreasureSaveData();
		List<TreasureCardData> list = TreasureData.treasureCards;
		treasureSaveData.treasureCards = list;
		int num = TreasureData.treasureMoney;
		treasureSaveData.treasureMoney = num;
		int num2 = TreasureData.wareHouseLevel;
		treasureSaveData.wareHouseLevel = num2;
		List<EquipmentData> list2 = TreasureData.equipmentData;
		treasureSaveData.equipmentData = list2;
		BigGardenData bigGardenData = TreasureData.gardenData;
		treasureSaveData.gardenData = bigGardenData;
		List<PlantType> list3 = Enumerable.ToList<PlantType>(TreasureData.collectedPlants);
		treasureSaveData.collectedPlants = list3;
		return treasureSaveData;
	}

	// Token: 0x06001E59 RID: 7769 RVA: 0x000A14D0 File Offset: 0x0009F6D0
	[Token(Token = "0x6001E59")]
	[Address(RVA = "0x592E30", Offset = "0x591430", VA = "0x180592E30")]
	public static void LoadData(TreasureSaveData saved)
	{
		do
		{
			if (saved.treasureCards != (ulong)0L)
			{
				TreasureData.treasureCards = saved.treasureCards;
			}
			if (saved.equipmentData != (ulong)0L)
			{
				TreasureData.equipmentData = saved.equipmentData;
			}
			if (saved.collectedPlants != (ulong)0L)
			{
				TreasureData.collectedPlants = Enumerable.ToHashSet<PlantType>(saved.collectedPlants);
			}
			TreasureData.treasureMoney = saved.treasureMoney;
		}
		while (saved.wareHouseLevel == 0);
		TreasureData.wareHouseLevel = saved.wareHouseLevel;
		TreasureData.gardenData = saved.gardenData;
		throw new NullReferenceException();
	}

	// Token: 0x06001E5A RID: 7770 RVA: 0x000A1554 File Offset: 0x0009F754
	[Token(Token = "0x6001E5A")]
	[Address(RVA = "0x591EE0", Offset = "0x5904E0", VA = "0x180591EE0")]
	public static List<ZombieType> GetZombieType()
	{
		List<ZombieType> list = new List();
		TreasureDifficulty treasureDifficulty = TreasureData.difficulty;
		if (treasureDifficulty != TreasureDifficulty.Normal)
		{
			if (treasureDifficulty != TreasureDifficulty.Normal)
			{
				if (treasureDifficulty != TreasureDifficulty.Normal)
				{
					if (treasureDifficulty != TreasureDifficulty.Normal)
					{
						if (treasureDifficulty != TreasureDifficulty.Hard)
						{
							List<ZombieType> list2 = new List();
						}
						uint num;
						List<ZombieType> random = global::Core.Lawnf.GetRandom<ZombieType>(TreasureData.LevelZombieTypes, (int)num);
						uint num2;
						List<ZombieType> random2 = global::Core.Lawnf.GetRandom<ZombieType>(TreasureData.HellZombieTypes, (int)num2);
						IEnumerable<ZombieType> enumerable = Enumerable.Concat<ZombieType>(random, random2);
						HashSet<ZombieType> leaderZombies = TypeMgr.LeaderZombies;
						List<ZombieType> list3 = Enumerable.ToList<ZombieType>(Enumerable.Concat<ZombieType>(enumerable, leaderZombies));
					}
					uint num3;
					List<ZombieType> random3 = global::Core.Lawnf.GetRandom<ZombieType>(TreasureData.LevelZombieTypes, (int)num3);
					uint num4;
					List<ZombieType> random4 = global::Core.Lawnf.GetRandom<ZombieType>(TreasureData.HellZombieTypes, (int)num4);
					IEnumerable<ZombieType> enumerable2 = Enumerable.Concat<ZombieType>(random3, random4);
					uint num5;
					List<ZombieType> random5 = global::Core.Lawnf.GetRandom<ZombieType>(Enumerable.ToList<ZombieType>(TypeMgr.LeaderZombies), (int)num5);
				}
				uint num6;
				List<ZombieType> random6 = global::Core.Lawnf.GetRandom<ZombieType>(TreasureData.HellZombieTypes, (int)num6);
				uint num7;
				List<ZombieType> random7 = global::Core.Lawnf.GetRandom<ZombieType>(TreasureData.HardZombieTypes, (int)num7);
				IEnumerable<ZombieType> enumerable3 = Enumerable.Concat<ZombieType>(random6, random7);
				List<ZombieType> list4 = Enumerable.ToList<ZombieType>(TypeMgr.LeaderZombies);
			}
			uint num8;
			List<ZombieType> random8 = global::Core.Lawnf.GetRandom<ZombieType>(TreasureData.HardZombieTypes, (int)num8);
			uint num9;
			List<ZombieType> random9 = global::Core.Lawnf.GetRandom<ZombieType>(TreasureData.NormalZombieTypes, (int)num9);
		}
		uint num10;
		List<ZombieType> random10 = global::Core.Lawnf.GetRandom<ZombieType>(TreasureData.NormalZombieTypes, (int)num10);
		if (TreasureData.levelSceneType > SceneType.Night)
		{
			return random10;
		}
		TreasureDifficulty treasureDifficulty2 = TreasureData.difficulty;
		if (treasureDifficulty2 != TreasureDifficulty.Normal && treasureDifficulty2 != TreasureDifficulty.Normal && treasureDifficulty2 != TreasureDifficulty.Normal && (treasureDifficulty2 == TreasureDifficulty.Normal || treasureDifficulty2 == TreasureDifficulty.Hard))
		{
			uint num11;
			List<ZombieType> random11 = global::Core.Lawnf.GetRandom<ZombieType>(TreasureData.UpgradeWaterTypes, (int)num11);
			IEnumerable<ZombieType> enumerable4;
			return Enumerable.ToList<ZombieType>(enumerable4);
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001E5B RID: 7771 RVA: 0x000A16BC File Offset: 0x0009F8BC
	[Token(Token = "0x6001E5B")]
	[Address(RVA = "0x590CD0", Offset = "0x58F2D0", VA = "0x180590CD0")]
	public static void DropCard(Vector2 position)
	{
		List<PlantType> lastPool = TreasureData.GetLastPool(TreasureData.difficulty);
		Board instance = Board.Instance;
		if (instance.boardMinX <= position)
		{
			float boardMaxX = instance.boardMaxX;
			if (position > boardMaxX)
			{
			}
		}
		float boardMinY = instance.boardMinY;
		float boardMaxY = instance.boardMaxY;
		GameObject gameObject = Resources.Load<GameObject>("Items/DroppedTreasureCard");
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Board instance2 = Board.Instance;
		GameObject gameObject2;
		DroppedTreasureCard component = gameObject2.GetComponent<DroppedTreasureCard>();
		PlantType plantType;
		component.thePlantType = plantType;
	}

	// Token: 0x06001E5C RID: 7772 RVA: 0x000A173C File Offset: 0x0009F93C
	[Token(Token = "0x6001E5C")]
	[Address(RVA = "0x591810", Offset = "0x58FE10", VA = "0x180591810")]
	public static List<PlantType> GetLastPool(TreasureDifficulty stage)
	{
		for (;;)
		{
			List<PlantType> list = new List(GameAPP.resourcesManager.allPlants);
			Predicate<PlantType> <>9__18_ = TreasureData.<>c.<>9__18_0;
			if (<>9__18_ == 0)
			{
				TreasureData.<>c.<>9__18_0 = delegate(PlantType p)
				{
					bool flag;
					return flag;
				};
			}
			int num = list.RemoveAll(<>9__18_);
			uint num3;
			int num2 = global::UnityEngine.Random.Range(0, (int)num3);
			int num4 = stage - TreasureDifficulty.Hard;
			if (num4 != 0)
			{
				uint num5;
				num4 -= (int)num5;
				if (num4 != 0)
				{
					num4 -= (int)num5;
					if (num4 == 0 || num4 == (int)num5)
					{
					}
				}
			}
			Predicate<PlantType> predicate;
			if (TreasureData.<>c.<>9__18_4 == 0)
			{
				predicate = delegate(PlantType p)
				{
					bool flag2;
					return flag2;
				};
				TreasureData.<>c.<>9__18_4 = predicate;
			}
			int num6 = list.RemoveAll(predicate);
			if (TreasureData.<>c.<>9__18_3 == 0)
			{
				TreasureData.<>c.<>9__18_3 = delegate(PlantType p)
				{
					bool flag3;
					return flag3;
				};
				if (TreasureData.<>c.<>9__18_2 == 0)
				{
					TreasureData.<>c.<>9__18_2 = delegate(PlantType p)
					{
						bool flag4;
						return flag4;
					};
					if (TreasureData.<>c.<>9__18_1 == 0)
					{
						break;
					}
				}
			}
		}
		TreasureData.<>c.<>9__18_1 = delegate(PlantType p)
		{
			bool flag5;
			if (flag5)
			{
				List<PlantType> allUltimatePlantTypes2 = TravelHelper.GetAllUltimatePlantTypes(true, true);
				bool flag6;
				if (!flag6)
				{
					HashSet<PlantType> redPlant = TypeMgr.RedPlant;
					bool flag7;
					return flag7;
				}
			}
			return true;
		};
		ulong num7;
		List<PlantType> allUltimatePlantTypes = TravelHelper.GetAllUltimatePlantTypes(num7 != 0UL, num7 != 0UL);
		return Enumerable.ToList<PlantType>(TypeMgr.RedPlant);
	}

	// Token: 0x06001E5D RID: 7773 RVA: 0x000A1868 File Offset: 0x0009FA68
	[Token(Token = "0x6001E5D")]
	[Address(RVA = "0x591350", Offset = "0x58F950", VA = "0x180591350")]
	public static CardLevel GetCardLevel(PlantType thePlantType)
	{
		HashSet<PlantType> redPlant = TypeMgr.RedPlant;
		bool flag;
		if (!flag)
		{
			bool flag2;
			if (!flag2)
			{
				bool flag3;
				if (!flag3)
				{
					bool flag5;
					bool flag4 = flag5 + true;
				}
				List<PlantType> allUltimatePlantTypes = TravelHelper.GetAllUltimatePlantTypes(true, true);
			}
		}
		return CardLevel.Red;
	}

	// Token: 0x06001E5E RID: 7774 RVA: 0x000A18B4 File Offset: 0x0009FAB4
	[Token(Token = "0x6001E5E")]
	[Address(RVA = "0x591DC0", Offset = "0x5903C0", VA = "0x180591DC0")]
	public static int GetPlantCost(PlantType thePlantType)
	{
		PlantDataManager.PlantData plantData;
		int cost = plantData.cost;
		CardLevel cardLevel;
		if (cardLevel <= CardLevel.Red)
		{
			uint num;
			num += num;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001E5F RID: 7775 RVA: 0x000A18DC File Offset: 0x0009FADC
	[Token(Token = "0x6001E5F")]
	[Address(RVA = "0x592510", Offset = "0x590B10", VA = "0x180592510")]
	public static void LevelEnd()
	{
		int num6;
		do
		{
			int num = 0;
			List<CardUI> cards = InGameUI.Instance.Cards;
			List<TreasureCardData> cardData = TreasureManager.Instance.cardData;
			if (TreasureManager.Instance.taskType == TreasureTask.TaskType.LoseBagEvacuate)
			{
				int num2 = 0;
				bool flag;
				if (flag)
				{
				}
				if (num2 != 0)
				{
					goto IL_012D;
				}
				int num3 = 0;
				bool flag2;
				if (flag2)
				{
				}
				if (num3 != 0)
				{
					goto IL_0139;
				}
				Predicate<TreasureCardData> predicate;
				if (TreasureData.<>c.<>9__21_0 == 0)
				{
					TreasureData.<>c.<>9__21_0 = predicate;
				}
				int num4 = cardData.RemoveAll(predicate);
			}
			int num5 = 0;
			Func<TreasureCardData, CardLevel> func;
			if (TreasureData.<>c.<>9__21_1 == 0)
			{
				TreasureData.<>c.<>9__21_1 = func;
			}
			List<TreasureCardData> list = Enumerable.ToList<TreasureCardData>(Enumerable.OrderByDescending<TreasureCardData, CardLevel>(cardData, func));
			bool flag3;
			if (flag3)
			{
				List<TreasureCardData> list2 = TreasureData.treasureCards;
				Predicate<TreasureCardData> predicate2;
				if (TreasureData.<>c.<>9__11_0 == 0)
				{
					TreasureData.<>c.<>9__11_0 = predicate2;
				}
				int size = Enumerable.ToList<TreasureCardData>(list2.FindAll(predicate2))._size;
				InGameText instance = InGameText.Instance;
				TreasureData.GetCard(num);
			}
			if (num5 != 0)
			{
				goto IL_0151;
			}
			num6 = 0;
			bool flag4;
			if (flag4)
			{
			}
		}
		while (num6 != 0);
		if (TreasureData.difficulty == TreasureDifficulty.Hard)
		{
			int num7 = TreasureData.treasureMoney;
			num7 += 10000;
			TreasureData.treasureMoney = num7;
		}
		return;
		IL_012D:
		throw new NullReferenceException();
		IL_0139:
		throw new NullReferenceException();
		IL_0151:
		throw new NullReferenceException();
	}

	// Token: 0x06001E60 RID: 7776 RVA: 0x000A1A48 File Offset: 0x0009FC48
	[Token(Token = "0x6001E60")]
	[Address(RVA = "0x590F70", Offset = "0x58F570", VA = "0x180590F70")]
	public static int GetBuffCost()
	{
		int num2;
		for (;;)
		{
			int num = 0;
			HashSet<AdvBuff> allNormalUltimatePlantBuffID = TravelMgr.Instance.GetAllNormalUltimatePlantBuffID();
			num2 = 0;
			List<AdvBuff> advBuffs = TravelMgr.Instance.data.advBuffs;
			bool flag;
			if (flag)
			{
				if (!allNormalUltimatePlantBuffID.Contains(num))
				{
					num2 += 50000;
				}
				num2 += 20000;
			}
			if (num2 == 0)
			{
				List<UltiBuff> ultiBuffs = TravelMgr.Instance.data.ultiBuffs;
				bool flag2;
				if (flag2)
				{
					num2 += 40000;
				}
				ulong num3;
				if (num3 == (ulong)0L)
				{
					List<UltiBuff> ultiBuffs_lv = TravelMgr.Instance.data.ultiBuffs_lv2;
					bool flag3;
					if (flag3)
					{
						if ((num <= 13 || num != 21) && num != 9)
						{
							while (num != 13)
							{
							}
						}
						num2 += 160000;
					}
					ulong num4;
					if (num4 == (ulong)0L)
					{
						break;
					}
				}
			}
		}
		return num2;
	}

	// Token: 0x17000198 RID: 408
	// (get) Token: 0x06001E61 RID: 7777 RVA: 0x000A1B28 File Offset: 0x0009FD28
	[Token(Token = "0x17000198")]
	public static List<ZombieType> LevelZombieTypes
	{
		[Token(Token = "0x6001E61")]
		[Address(RVA = "0x5945D0", Offset = "0x592BD0", VA = "0x1805945D0")]
		get
		{
			List<ZombieType> list = Enumerable.ToList<ZombieType>(TypeMgr.UltiZombie_level_a);
			List<ZombieType> list2 = Enumerable.ToList<ZombieType>(TypeMgr.UltiZombie_level_b);
			List<ZombieType> list3 = Enumerable.ToList<ZombieType>(TypeMgr.UltiZombie_level_c);
			List<ZombieType> list4 = Enumerable.ToList<ZombieType>(Enumerable.Concat<ZombieType>(Enumerable.Concat<ZombieType>(list, list2), list3));
			Predicate<ZombieType> <>9__31_ = TreasureData.<>c.<>9__31_0;
			if (<>9__31_ == 0)
			{
				TreasureData.<>c.<>9__31_0 = delegate(ZombieType z)
				{
					bool flag;
					return flag;
				};
			}
			int num = list4.RemoveAll(<>9__31_);
			return list4;
		}
	}

	// Token: 0x06001E62 RID: 7778 RVA: 0x000A1BA8 File Offset: 0x0009FDA8
	[Token(Token = "0x6001E62")]
	[Address(RVA = "0x591650", Offset = "0x58FC50", VA = "0x180591650")]
	public static ValueTuple<int, int> GetEquipmentCount(EquipmentType equipmentType)
	{
		int num;
		do
		{
			num = 0;
			int num2 = 0;
			List<EquipmentData> list = TreasureData.equipmentData;
			bool flag;
			if (flag)
			{
				num++;
				num2++;
			}
		}
		while (num != 0);
		throw new NullReferenceException();
	}

	// Token: 0x06001E63 RID: 7779 RVA: 0x000A1BF0 File Offset: 0x0009FDF0
	[Token(Token = "0x6001E63")]
	[Address(RVA = "0x591550", Offset = "0x58FB50", VA = "0x180591550")]
	public static ValueTuple<int, string> GetEquipmentCostAndName(EquipmentType equipmentType)
	{
		int num = 0;
		Dictionary<EquipmentType, ValueTuple<int, string>> equipmentCost = TreasureData.EquipmentCost;
		bool flag;
		if (!flag)
		{
			int num2 = 0;
			equipmentType.value__ = num2;
		}
		equipmentType.value__ = num;
		throw new NullReferenceException();
	}

	// Token: 0x06001E64 RID: 7780 RVA: 0x000A1C2C File Offset: 0x0009FE2C
	[Token(Token = "0x6001E64")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public TreasureData()
	{
	}

	// Token: 0x06001E65 RID: 7781 RVA: 0x000A1C40 File Offset: 0x0009FE40
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x6001E65")]
	[Address(RVA = "0x593250", Offset = "0x591850", VA = "0x180593250")]
	static TreasureData()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		int size5 = list._size;
		int size6 = list._size;
		int size7 = list._size;
		int size8 = list._size;
		int size9 = list._size;
		int size10 = list._size;
		int size11 = list._size;
		int size12 = list._size;
		int size13 = list._size;
		int size14 = list._size;
		int size15 = list._size;
		int size16 = list._size;
		TreasureData.NormalZombieTypes = list;
		List<ZombieType> list2 = new List();
		int size17 = list2._size;
		int size18 = list2._size;
		int size19 = list2._size;
		int size20 = list2._size;
		int size21 = list2._size;
		int size22 = list2._size;
		int size23 = list2._size;
		int size24 = list2._size;
		int size25 = list2._size;
		int size26 = list2._size;
		int size27 = list2._size;
		int size28 = list2._size;
		int size29 = list2._size;
		int size30 = list2._size;
		TreasureData.HardZombieTypes = list2;
		List<ZombieType> list3 = new List();
		int size31 = list3._size;
		int size32 = list3._size;
		int size33 = list3._size;
		int size34 = list3._size;
		int size35 = list3._size;
		int size36 = list3._size;
		int size37 = list3._size;
		int size38 = list3._size;
		TreasureData.HellZombieTypes = list3;
		TreasureData.NormaWaterTypes = new List();
		TreasureData.HardWaterTypes = new List();
		TreasureData.HallWaterTypes = new List();
		TreasureData.UpgradeWaterTypes = new List();
		Dictionary<EquipmentType, ValueTuple<int, string>> dictionary = new Dictionary();
		int num = 0;
		int num2 = 0;
		dictionary.Add(num2, num);
		TreasureData.EquipmentCost = dictionary;
	}

	// Token: 0x04001095 RID: 4245
	[Token(Token = "0x4001095")]
	public static List<TreasureCardData> treasureCards = new List();

	// Token: 0x04001096 RID: 4246
	[Token(Token = "0x4001096")]
	public static HashSet<PlantType> collectedPlants = new HashSet();

	// Token: 0x04001097 RID: 4247
	[Token(Token = "0x4001097")]
	public static List<EquipmentData> equipmentData = new List();

	// Token: 0x04001098 RID: 4248
	[Token(Token = "0x4001098")]
	public static BigGardenData gardenData;

	// Token: 0x04001099 RID: 4249
	[Token(Token = "0x4001099")]
	public static TreasureDifficulty difficulty;

	// Token: 0x0400109A RID: 4250
	[Token(Token = "0x400109A")]
	public static SceneType levelSceneType;

	// Token: 0x0400109B RID: 4251
	[Token(Token = "0x400109B")]
	public static int treasureMoney;

	// Token: 0x0400109C RID: 4252
	[Token(Token = "0x400109C")]
	public static int wareHouseLevel;

	// Token: 0x0400109D RID: 4253
	[Token(Token = "0x400109D")]
	public static bool autoCollect;

	// Token: 0x0400109E RID: 4254
	[Token(Token = "0x400109E")]
	public const int Durbility = 40;

	// Token: 0x0400109F RID: 4255
	[Token(Token = "0x400109F")]
	public static List<ZombieType> NormalZombieTypes;

	// Token: 0x040010A0 RID: 4256
	[Token(Token = "0x40010A0")]
	public static List<ZombieType> HardZombieTypes;

	// Token: 0x040010A1 RID: 4257
	[Token(Token = "0x40010A1")]
	public static List<ZombieType> HellZombieTypes;

	// Token: 0x040010A2 RID: 4258
	[Token(Token = "0x40010A2")]
	public static List<ZombieType> NormaWaterTypes;

	// Token: 0x040010A3 RID: 4259
	[Token(Token = "0x40010A3")]
	public static List<ZombieType> HardWaterTypes;

	// Token: 0x040010A4 RID: 4260
	[Token(Token = "0x40010A4")]
	public static List<ZombieType> HallWaterTypes;

	// Token: 0x040010A5 RID: 4261
	[Token(Token = "0x40010A5")]
	public static List<ZombieType> UpgradeWaterTypes;

	// Token: 0x040010A6 RID: 4262
	[Token(Token = "0x40010A6")]
	[TupleElementNames(new string[] { "cost", "name" })]
	private static readonly Dictionary<EquipmentType, ValueTuple<int, string>> EquipmentCost;
}
