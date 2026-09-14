using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000610 RID: 1552
[Token(Token = "0x2000610")]
public class TreasureData
{
	// Token: 0x17000151 RID: 337
	// (get) Token: 0x06001D56 RID: 7510 RVA: 0x0009C8EC File Offset: 0x0009AAEC
	[Token(Token = "0x17000151")]
	public static bool WareHouseUnfull
	{
		[Token(Token = "0x6001D56")]
		[Address(RVA = "0x529630", Offset = "0x527C30", VA = "0x180529630")]
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

	// Token: 0x06001D57 RID: 7511 RVA: 0x0009C92C File Offset: 0x0009AB2C
	[Token(Token = "0x6001D57")]
	[Address(RVA = "0x527E70", Offset = "0x526470", VA = "0x180527E70")]
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

	// Token: 0x06001D58 RID: 7512 RVA: 0x0009C97C File Offset: 0x0009AB7C
	[Token(Token = "0x6001D58")]
	[Address(RVA = "0x5262F0", Offset = "0x5248F0", VA = "0x1805262F0")]
	public static void GetCard(TreasureCardData data)
	{
		int size = TreasureData.treasureCards._size;
	}

	// Token: 0x06001D59 RID: 7513 RVA: 0x0009C99C File Offset: 0x0009AB9C
	[Token(Token = "0x6001D59")]
	[Address(RVA = "0x527F70", Offset = "0x526570", VA = "0x180527F70")]
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

	// Token: 0x06001D5A RID: 7514 RVA: 0x0009CA10 File Offset: 0x0009AC10
	[Token(Token = "0x6001D5A")]
	[Address(RVA = "0x527C90", Offset = "0x526290", VA = "0x180527C90")]
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

	// Token: 0x06001D5B RID: 7515 RVA: 0x0009CA94 File Offset: 0x0009AC94
	[Token(Token = "0x6001D5B")]
	[Address(RVA = "0x526D50", Offset = "0x525350", VA = "0x180526D50")]
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

	// Token: 0x06001D5C RID: 7516 RVA: 0x0009CBFC File Offset: 0x0009ADFC
	[Token(Token = "0x6001D5C")]
	[Address(RVA = "0x525B40", Offset = "0x524140", VA = "0x180525B40")]
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

	// Token: 0x06001D5D RID: 7517 RVA: 0x0009CC7C File Offset: 0x0009AE7C
	[Token(Token = "0x6001D5D")]
	[Address(RVA = "0x526680", Offset = "0x524C80", VA = "0x180526680")]
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

	// Token: 0x06001D5E RID: 7518 RVA: 0x0009CDA8 File Offset: 0x0009AFA8
	[Token(Token = "0x6001D5E")]
	[Address(RVA = "0x5261C0", Offset = "0x5247C0", VA = "0x1805261C0")]
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

	// Token: 0x06001D5F RID: 7519 RVA: 0x0009CDF4 File Offset: 0x0009AFF4
	[Token(Token = "0x6001D5F")]
	[Address(RVA = "0x526C30", Offset = "0x525230", VA = "0x180526C30")]
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

	// Token: 0x06001D60 RID: 7520 RVA: 0x0009CE1C File Offset: 0x0009B01C
	[Token(Token = "0x6001D60")]
	[Address(RVA = "0x527380", Offset = "0x525980", VA = "0x180527380")]
	public static void LevelEnd()
	{
		int num7;
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
					goto IL_0143;
				}
				int num3 = 0;
				bool flag2;
				if (flag2)
				{
				}
				if (num3 != 0)
				{
					goto IL_014F;
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
				int num6 = 0;
				instance.ShowText("仓库已满，已优先丢弃低价值卡牌", 5f, num6 != 0);
				TreasureData.GetCard(num);
			}
			if (num5 != 0)
			{
				goto IL_0167;
			}
			num7 = 0;
			bool flag4;
			if (flag4)
			{
			}
		}
		while (num7 != 0);
		if (TreasureData.difficulty == TreasureDifficulty.Hard)
		{
			int num8 = TreasureData.treasureMoney;
			num8 += 10000;
			TreasureData.treasureMoney = num8;
		}
		return;
		IL_0143:
		throw new NullReferenceException();
		IL_014F:
		throw new NullReferenceException();
		IL_0167:
		throw new NullReferenceException();
	}

	// Token: 0x06001D61 RID: 7521 RVA: 0x0009CF9C File Offset: 0x0009B19C
	[Token(Token = "0x6001D61")]
	[Address(RVA = "0x525DE0", Offset = "0x5243E0", VA = "0x180525DE0")]
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

	// Token: 0x17000152 RID: 338
	// (get) Token: 0x06001D62 RID: 7522 RVA: 0x0009D07C File Offset: 0x0009B27C
	[Token(Token = "0x17000152")]
	public static List<ZombieType> LevelZombieTypes
	{
		[Token(Token = "0x6001D62")]
		[Address(RVA = "0x529430", Offset = "0x527A30", VA = "0x180529430")]
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

	// Token: 0x06001D63 RID: 7523 RVA: 0x0009D0FC File Offset: 0x0009B2FC
	[Token(Token = "0x6001D63")]
	[Address(RVA = "0x5264C0", Offset = "0x524AC0", VA = "0x1805264C0")]
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

	// Token: 0x06001D64 RID: 7524 RVA: 0x0009D144 File Offset: 0x0009B344
	[Token(Token = "0x6001D64")]
	[Address(RVA = "0x5263C0", Offset = "0x5249C0", VA = "0x1805263C0")]
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

	// Token: 0x06001D65 RID: 7525 RVA: 0x0009D180 File Offset: 0x0009B380
	[Token(Token = "0x6001D65")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public TreasureData()
	{
	}

	// Token: 0x06001D66 RID: 7526 RVA: 0x0009D194 File Offset: 0x0009B394
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x6001D66")]
	[Address(RVA = "0x5280B0", Offset = "0x5266B0", VA = "0x1805280B0")]
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

	// Token: 0x04000FCD RID: 4045
	[Token(Token = "0x4000FCD")]
	public static List<TreasureCardData> treasureCards = new List();

	// Token: 0x04000FCE RID: 4046
	[Token(Token = "0x4000FCE")]
	public static HashSet<PlantType> collectedPlants = new HashSet();

	// Token: 0x04000FCF RID: 4047
	[Token(Token = "0x4000FCF")]
	public static List<EquipmentData> equipmentData = new List();

	// Token: 0x04000FD0 RID: 4048
	[Token(Token = "0x4000FD0")]
	public static BigGardenData gardenData;

	// Token: 0x04000FD1 RID: 4049
	[Token(Token = "0x4000FD1")]
	public static TreasureDifficulty difficulty;

	// Token: 0x04000FD2 RID: 4050
	[Token(Token = "0x4000FD2")]
	public static SceneType levelSceneType;

	// Token: 0x04000FD3 RID: 4051
	[Token(Token = "0x4000FD3")]
	public static int treasureMoney;

	// Token: 0x04000FD4 RID: 4052
	[Token(Token = "0x4000FD4")]
	public static int wareHouseLevel;

	// Token: 0x04000FD5 RID: 4053
	[Token(Token = "0x4000FD5")]
	public static bool autoCollect;

	// Token: 0x04000FD6 RID: 4054
	[Token(Token = "0x4000FD6")]
	public const int Durbility = 40;

	// Token: 0x04000FD7 RID: 4055
	[Token(Token = "0x4000FD7")]
	public static List<ZombieType> NormalZombieTypes;

	// Token: 0x04000FD8 RID: 4056
	[Token(Token = "0x4000FD8")]
	public static List<ZombieType> HardZombieTypes;

	// Token: 0x04000FD9 RID: 4057
	[Token(Token = "0x4000FD9")]
	public static List<ZombieType> HellZombieTypes;

	// Token: 0x04000FDA RID: 4058
	[Token(Token = "0x4000FDA")]
	public static List<ZombieType> NormaWaterTypes;

	// Token: 0x04000FDB RID: 4059
	[Token(Token = "0x4000FDB")]
	public static List<ZombieType> HardWaterTypes;

	// Token: 0x04000FDC RID: 4060
	[Token(Token = "0x4000FDC")]
	public static List<ZombieType> HallWaterTypes;

	// Token: 0x04000FDD RID: 4061
	[Token(Token = "0x4000FDD")]
	public static List<ZombieType> UpgradeWaterTypes;

	// Token: 0x04000FDE RID: 4062
	[Token(Token = "0x4000FDE")]
	[TupleElementNames(new string[] { "cost", "name" })]
	private static readonly Dictionary<EquipmentType, ValueTuple<int, string>> EquipmentCost;
}
