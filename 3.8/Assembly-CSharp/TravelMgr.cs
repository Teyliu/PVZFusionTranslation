using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using com.cyborgAssets.inspectorButtonPro;
using Core;
using Cpp2IlInjected;
using GameLevel;
using Unity.VisualScripting;
using UnityEngine;

// Token: 0x02000789 RID: 1929
[Token(Token = "0x2000789")]
public class TravelMgr : MonoBehaviour
{
	// Token: 0x1700018C RID: 396
	// (get) Token: 0x060026E3 RID: 9955 RVA: 0x000CFE0C File Offset: 0x000CE00C
	[Token(Token = "0x1700018C")]
	public float DamageAmplification
	{
		[Token(Token = "0x60026E3")]
		[Address(RVA = "0x612980", Offset = "0x610F80", VA = "0x180612980")]
		get
		{
			return this.data.damageAmplification;
		}
	}

	// Token: 0x1700018D RID: 397
	// (get) Token: 0x060026E4 RID: 9956 RVA: 0x000CFE2C File Offset: 0x000CE02C
	[Token(Token = "0x1700018D")]
	public float LuckyStrike
	{
		[Token(Token = "0x60026E4")]
		[Address(RVA = "0x612AF0", Offset = "0x6110F0", VA = "0x180612AF0")]
		get
		{
			return this.data.moreLuckyStrike;
		}
	}

	// Token: 0x1700018E RID: 398
	// (get) Token: 0x060026E5 RID: 9957 RVA: 0x000CFE4C File Offset: 0x000CE04C
	[Token(Token = "0x1700018E")]
	public int BasicDamage
	{
		[Token(Token = "0x60026E5")]
		[Address(RVA = "0x6128E0", Offset = "0x610EE0", VA = "0x1806128E0")]
		get
		{
			int theCurrentSurvivalRound = Board.Instance.theCurrentSurvivalRound;
			TravelData travelData = this.data;
			long num = (long)(1U * (uint)10000);
			throw new NullReferenceException();
		}
	}

	// Token: 0x060026E6 RID: 9958 RVA: 0x000CFE7C File Offset: 0x000CE07C
	[Token(Token = "0x60026E6")]
	[Address(RVA = "0x610D30", Offset = "0x60F330", VA = "0x180610D30")]
	public void OnGameStart(Board board)
	{
		ZombieType routeBossType = this.data.routeBossType;
		if (routeBossType > ZombieType.UltimateFootballZombie)
		{
			if (routeBossType == ZombieType.UltimateJacksonDriver)
			{
			}
			if (routeBossType == ZombieType.UltimateHorse)
			{
			}
			if (routeBossType != ZombieType.UltimateImpKing)
			{
				goto IL_0050;
			}
		}
		if (routeBossType == ZombieType.UltimateGargantuar || routeBossType != ZombieType.UltimateFootballZombie)
		{
		}
		IL_0050:
		this.GetDebuff((TravelDebuff)((uint)4000));
		if (this.data.Invest)
		{
			Board board2 = board;
			TravelData travelData = this.data;
			Board board3 = board;
			TravelData travelData2 = this.data;
			BoardConfig config = board3.config;
			TravelData travelData3 = this.data;
			List<PlantType> unlockedWeaks = travelData2.unlockedWeaks;
			TravelData travelData4 = this.data;
			Board board4 = board;
			int theCurrentSurvivalRound = board.theCurrentSurvivalRound;
			if (theCurrentSurvivalRound <= 6 || (theCurrentSurvivalRound != 12 && theCurrentSurvivalRound != 18))
			{
				Board board5;
				if (theCurrentSurvivalRound == 1)
				{
					board5 = board;
					board5.config.zombieHealthMultiplier = 0.1f;
				}
				if (board5 != (ulong)6L)
				{
					goto IL_011E;
				}
			}
			TravelData travelData5 = this.data;
			int num = travelData5.difficulty + 1;
			if (travelData5.invest_challenge)
			{
			}
			travelData5.difficulty = num;
		}
		IL_011E:
		DelayAction delayAction = GameAPP.delayAction;
		Action action = delegate
		{
			int theBoardLevel = GameAPP.theBoardLevel;
			int theCurrentSurvivalRound2 = board.theCurrentSurvivalRound;
			if (theCurrentSurvivalRound2 <= 11)
			{
				int num3 = theCurrentSurvivalRound2 - 1;
				if (num3 != 0)
				{
					if (num3 != 0)
					{
						if (num3 == 0 || num3 == 0)
						{
							return;
						}
						if (num3 != 1 && theCurrentSurvivalRound2 != 8)
						{
							if (theCurrentSurvivalRound2 != 11 || theBoardLevel != 40 || !this.data.Invest)
							{
								return;
							}
							int theCurrentSurvivalRound3 = board.theCurrentSurvivalRound;
							if (theCurrentSurvivalRound3 > 11)
							{
								if (theCurrentSurvivalRound3 <= 20)
								{
									return;
								}
								return;
							}
							else
							{
								int num4 = theCurrentSurvivalRound3 - 1;
								if (num4 == 0)
								{
									goto IL_00BA;
								}
								if (num4 != 0 && (num4 == 0 || num4 == 0 || (num4 != 1 && theCurrentSurvivalRound3 != 8 && theCurrentSurvivalRound3 != 11)))
								{
									return;
								}
							}
						}
					}
					UIResourcesLoader uimanager = GameAPP.UIManager;
					return;
				}
				IL_00BA:
				UIResourcesLoader uimanager2 = GameAPP.UIManager;
				return;
			}
			if (theCurrentSurvivalRound2 <= 20)
			{
				return;
			}
		};
		int num2 = 0;
		delayAction.SetAction(action, (float)num2);
	}

	// Token: 0x060026E7 RID: 9959 RVA: 0x000CFFD4 File Offset: 0x000CE1D4
	[Token(Token = "0x60026E7")]
	[Address(RVA = "0x6104F0", Offset = "0x60EAF0", VA = "0x1806104F0")]
	public void OnBoardStart(Board board)
	{
		for (;;)
		{
			int num = 0;
			int num2 = 0;
			this.UpdateSynergies();
			List<InvestBuff> investmentBuffs = this.data.investmentBuffs;
			bool flag;
			if (!flag || TravelMgr.InvestBuffsData.TryGetValue(num, num2))
			{
				if (num2 != 0)
				{
					goto IL_00DD;
				}
				int num3 = 0;
				bool flag2;
				if (!flag2 || TravelMgr.AdvBuffData.TryGetValue(num, num2))
				{
					if (num3 != 0)
					{
						goto IL_00E9;
					}
					int num4 = 0;
					bool flag3;
					if (!flag3 || TravelMgr.DeBuffData.TryGetValue(num, num2))
					{
						if (num4 != 0)
						{
							goto IL_00F5;
						}
						int num5 = 0;
						SynergyManager instance = SynergyManager.Instance;
						int num6 = 0;
						List<SynergyType> activeSynergies = instance.GetActiveSynergies(num6 != 0);
						bool flag4;
						if (!flag4 || TravelMgr.SynergysData.TryGetValue(num, num2))
						{
							if (num5 != 0)
							{
								goto IL_0101;
							}
							int num7 = 0;
							bool flag5;
							if ((!flag5 || TravelMgr.InvestBuffsData.TryGetValue(num, num2)) && num7 == 0)
							{
								break;
							}
						}
					}
				}
			}
		}
		return;
		IL_00DD:
		throw new NullReferenceException();
		IL_00E9:
		throw new NullReferenceException();
		IL_00F5:
		throw new NullReferenceException();
		IL_0101:
		throw new NullReferenceException();
	}

	// Token: 0x060026E8 RID: 9960 RVA: 0x000D00F0 File Offset: 0x000CE2F0
	[Token(Token = "0x60026E8")]
	[Address(RVA = "0x610170", Offset = "0x60E770", VA = "0x180610170")]
	public void OnBoardEnd(Board board)
	{
		for (;;)
		{
			int num = 0;
			List<InvestBuff> investmentBuffs = this.data.investmentBuffs;
			bool flag;
			if (!flag || TravelMgr.InvestBuffsData.TryGetValue(num, num))
			{
				ulong num2;
				if (num2 != (ulong)0L)
				{
					goto IL_0071;
				}
				SynergyManager instance = SynergyManager.Instance;
				int num3 = 0;
				List<SynergyType> activeSynergies = instance.GetActiveSynergies(num3 != 0);
				bool flag2;
				ulong num4;
				if ((!flag2 || TravelMgr.SynergysData.TryGetValue(num, num)) && num4 == (ulong)0L)
				{
					break;
				}
			}
		}
		return;
		IL_0071:
		throw new NullReferenceException();
	}

	// Token: 0x060026E9 RID: 9961 RVA: 0x000D017C File Offset: 0x000CE37C
	[Token(Token = "0x60026E9")]
	[Address(RVA = "0x611970", Offset = "0x60FF70", VA = "0x180611970")]
	public void UpdateRandom()
	{
		int num;
		List<InvestBuff> list;
		do
		{
			int i = 0;
			List<InvestBuff> investBuffs = this.data.investBuffs;
			num = 0;
			investBuffs._size = num;
			InvestBuff[] enumValues = global::Core.Lawnf.GetEnumValues<InvestBuff>();
			Func<InvestBuff, bool> <>9__21_ = TravelMgr.<>c.<>9__21_0;
			if (<>9__21_ == 0)
			{
				TravelMgr.<>c.<>9__21_0 = delegate(InvestBuff a)
				{
					bool flag2;
					return flag2;
				};
			}
			list = Enumerable.ToList<InvestBuff>(Enumerable.Where<InvestBuff>(enumValues, <>9__21_));
			List<InvestBuff> list2 = new List(list);
			bool flag;
			if (flag)
			{
				while (i >= 2000)
				{
				}
			}
		}
		while (num != 0);
		int num2 = 0;
		uint num3;
		if (global::UnityEngine.Random.Range(0, (int)num3) != 0)
		{
			Predicate<InvestBuff> predicate;
			if (TravelMgr.<>c.<>9__21_1 == 0)
			{
				predicate = (InvestBuff a) => a == InvestBuff.积分大使飘飘;
				TravelMgr.<>c.<>9__21_1 = predicate;
			}
			int num4 = list.RemoveAll(predicate);
		}
		int num5 = list._size;
		num5 = global::UnityEngine.Random.Range(0, num5);
		InvestBuff investBuff = list[num5];
		TravelMgr.<>c__DisplayClass21_0 CS$<>8__locals1;
		CS$<>8__locals1.buff = investBuff;
		Predicate<InvestBuff> predicate2 = (InvestBuff a) => a == CS$<>8__locals1.buff;
		int num6 = list.RemoveAll(predicate2);
		num2++;
	}

	// Token: 0x060026EA RID: 9962 RVA: 0x000D0288 File Offset: 0x000CE488
	[Token(Token = "0x60026EA")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10")]
	public void OnUpdate()
	{
	}

	// Token: 0x060026EB RID: 9963 RVA: 0x000D0298 File Offset: 0x000CE498
	[Token(Token = "0x60026EB")]
	[Address(RVA = "0x60E460", Offset = "0x60CA60", VA = "0x18060E460")]
	public void GetInvestBuff(InvestBuff buff)
	{
		TravelData travelData = this.data;
		Board instance = Board.Instance;
		TravelData travelData2 = this.data;
		BoardData boardData = instance.boardData;
		Dictionary<int, int> zombieLevelProbabilitySmart = ZombieLevelDictionary.GetZombieLevelProbabilitySmart(travelData2.difficulty);
		boardData.zombieLevelDic = zombieLevelProbabilitySmart;
		List<InvestBuff> investmentBuffs = this.data.investmentBuffs;
		Dictionary<InvestBuff, InvestBuffData> investBuffsData = TravelMgr.InvestBuffsData;
		bool flag;
		if (flag)
		{
		}
		this.UpdateSynergies();
	}

	// Token: 0x060026EC RID: 9964 RVA: 0x000D0304 File Offset: 0x000CE504
	[Token(Token = "0x60026EC")]
	[Address(RVA = "0x6118E0", Offset = "0x60FEE0", VA = "0x1806118E0")]
	public void UnlockPlant(TravelUnlocks unlock)
	{
		List<TravelUnlocks> unlockedPlants = this.data.unlockedPlants;
		this.UpdateSynergies();
	}

	// Token: 0x060026ED RID: 9965 RVA: 0x000D032C File Offset: 0x000CE52C
	[Token(Token = "0x60026ED")]
	[Address(RVA = "0x60E670", Offset = "0x60CC70", VA = "0x18060E670")]
	public void GetNormalBuff(AdvBuff buff)
	{
		int num;
		do
		{
			num = 0;
			int num2 = 0;
			Board instance = Board.Instance;
			Dictionary<AdvBuff, BaseBuff<AdvBuff>> advBuffData = TravelMgr.AdvBuffData;
			bool flag;
			if (flag)
			{
			}
			if (buff > AdvBuff.聚光盆)
			{
				if (buff == AdvBuff.灯火通明)
				{
					instance.AddLightLevel(4);
				}
				if (buff != AdvBuff.Curse_贪婪诅咒)
				{
					break;
				}
				InGameUI instance2 = InGameUI.Instance;
				int num3 = 0;
				if (instance2 == num3)
				{
					break;
				}
				HashSet<CardUI> cards = InGameUI.Instance.cards;
				bool flag2;
				if (flag2)
				{
					int num4 = 0;
					if (!(num2 != num4))
					{
						continue;
					}
				}
				if (num != 0)
				{
					goto IL_00B5;
				}
			}
			List<Plant> plantArray = instance.boardEntity.plantArray;
			bool flag3;
			if (flag3)
			{
				int num5 = 0;
				if (!(num2 != num5))
				{
					continue;
				}
			}
		}
		while (num != 0);
		return;
		IL_00B5:
		throw new NullReferenceException();
	}

	// Token: 0x060026EE RID: 9966 RVA: 0x000D03F4 File Offset: 0x000CE5F4
	[Token(Token = "0x60026EE")]
	[Address(RVA = "0x60F700", Offset = "0x60DD00", VA = "0x18060F700")]
	public void GetUltiBuff(UltiBuff buff, bool upgrade = false)
	{
		int num6;
		do
		{
			int num = 0;
			int num2 = 0;
			if (upgrade)
			{
				List<UltiBuff> ultiBuffs_lv = this.data.ultiBuffs_lv2;
			}
			List<UltiBuff> ultiBuffs = this.data.ultiBuffs;
			bool flag;
			if (!flag)
			{
				break;
			}
			int num4;
			if (buff == UltiBuff.世纪之盾)
			{
				PlantDataManager.PlantData plantData = PlantDataManager.GetPlantData((PlantType)((uint)913));
				List<Plant> plantArray = Board.Instance.boardEntity.plantArray;
				bool flag2;
				if (flag2)
				{
					int num3 = 0;
					if (!(num != num3))
					{
						continue;
					}
				}
				if (num2 != 0)
				{
					goto IL_00F7;
				}
				num4 = 0;
			}
			if (num == 24)
			{
				List<Plant> plantArray2 = Board.Instance.boardEntity.plantArray;
				bool flag3;
				if (flag3)
				{
					int num5 = 0;
					if (!(num != num5))
					{
						continue;
					}
					bool flag4;
					while (!flag4)
					{
					}
				}
				if (num4 != 0)
				{
					goto IL_0103;
				}
				num6 = 0;
			}
			if (num != 28)
			{
				break;
			}
			List<Plant> plantArray3 = Board.Instance.boardEntity.plantArray;
			bool flag5;
			if (flag5)
			{
				int num7 = 0;
				if (!(num != num7))
				{
					continue;
				}
				float thePoints = Board.Instance.thePoints;
			}
		}
		while (num6 != 0);
		return;
		IL_00F7:
		throw new NullReferenceException();
		IL_0103:
		throw new NullReferenceException();
	}

	// Token: 0x060026EF RID: 9967 RVA: 0x000D0510 File Offset: 0x000CE710
	[Token(Token = "0x60026EF")]
	[Address(RVA = "0x60E130", Offset = "0x60C730", VA = "0x18060E130")]
	public void GetDebuff(TravelDebuff buff)
	{
		int num = 0;
		if (typeof(TravelMgr.<>c).TypeHandle != 0)
		{
			if (typeof(TravelMgr.<>c).TypeHandle != 0)
			{
				if (typeof(TravelMgr.<>c).TypeHandle == 0 || typeof(TravelMgr.<>c).TypeHandle != (ulong)1L)
				{
					goto IL_0096;
				}
				List<Plant> allPlants = global::Lawnf.GetAllPlants();
				Predicate<Plant> <>9__27_ = TravelMgr.<>c.<>9__27_0;
				if (<>9__27_ == 0)
				{
					Predicate<Plant> predicate;
					TravelMgr.<>c.<>9__27_0 = predicate;
				}
				int num2 = allPlants.RemoveAll(<>9__27_);
				int size = allPlants._size;
				int num3 = size - 1;
				if (size <= 0)
				{
					goto IL_0096;
				}
				uint num4;
				if (global::UnityEngine.Random.Range(0, (int)num4) == 0)
				{
					Plant plant = allPlants[num3];
					int num5 = 0;
					plant.Die((Plant.DieReason)num5);
				}
			}
			Board.Instance.thePoints = (float)num;
		}
		Board.Instance.theSun = num;
		IL_0096:
		List<TravelDebuff> travelDebuffs = this.data.travelDebuffs;
		Dictionary<TravelDebuff, BaseBuff<TravelDebuff>> deBuffData = TravelMgr.DeBuffData;
		bool flag;
		if (flag)
		{
		}
		this.UpdateSynergies();
	}

	// Token: 0x060026F0 RID: 9968 RVA: 0x000D05DC File Offset: 0x000CE7DC
	[Token(Token = "0x60026F0")]
	[Address(RVA = "0x60FC90", Offset = "0x60E290", VA = "0x18060FC90")]
	public List<TravelUnlocks> GetUnlocksPool()
	{
		List<TravelUnlocks> list = Enumerable.ToList<TravelUnlocks>(global::Core.Lawnf.GetEnumValues<TravelUnlocks>());
		TravelPackage travelPackage = this.TravelPackage;
		if (travelPackage == 0 || travelPackage.LandRoute)
		{
		}
		Predicate<TravelUnlocks> predicate;
		if (TravelMgr.<>c.<>9__28_0 == 0)
		{
			predicate = delegate(TravelUnlocks a)
			{
				bool flag;
				return flag;
			};
			TravelMgr.<>c.<>9__28_0 = predicate;
		}
		int num = list.RemoveAll(predicate);
		TravelData travelData = this.data;
		if (travelData.travelDifficulty == TravelDifficulty.Curse || travelData.Invest)
		{
		}
		return list;
	}

	// Token: 0x060026F1 RID: 9969 RVA: 0x000D0664 File Offset: 0x000CE864
	[Token(Token = "0x60026F1")]
	[Address(RVA = "0x60D3B0", Offset = "0x60B9B0", VA = "0x18060D3B0")]
	public List<AdvBuff> GetAdvancedBuffPool(bool inStore = false)
	{
		List<AdvBuff> list;
		int num2;
		AdvBuff advBuff;
		bool flag9;
		do
		{
			int num = 0;
			list = new List();
			Board instance = Board.Instance;
			bool flag = global::Lawnf.TravelCurse();
			bool isRogue = instance.boardTag.isRogue;
			bool isSuperRandom = instance.boardTag.isSuperRandom;
			AdvBuff[] enumValues = global::Core.Lawnf.GetEnumValues<AdvBuff>();
			num2 = 0;
			if (num2 >= enumValues.Length)
			{
				return list;
			}
			advBuff = enumValues[num2];
			List<AdvBuff> advBuffs = this.data.advBuffs;
			bool flag2;
			if (flag2 || advBuff >= AdvBuff.Tool_手拖车)
			{
				goto IL_01D3;
			}
			bool flag3;
			if (flag3)
			{
			}
			bool flag4;
			if (flag4)
			{
			}
			bool flag5;
			if (flag5)
			{
			}
			bool flag6;
			if (flag6)
			{
				List<AdvBuff> advBuffs2 = this.data.advBuffs;
				bool flag7;
				if (flag7)
				{
					bool flag8 = this.IsMini((AdvBuff)num);
				}
				ulong num3;
				if (num3 != (ulong)0L)
				{
					continue;
				}
			}
			if (flag9 || advBuff == AdvBuff.魔力升级II || flag9 <= true || flag9 <= true)
			{
				goto IL_01D3;
			}
		}
		while (advBuff <= AdvBuff.魔力升级II);
		if (flag9 <= true)
		{
			int num4;
			if (num4 != 2)
			{
			}
			int num5;
			if (num5 != 2)
			{
			}
			int num6;
			if (num6 != 2)
			{
			}
			int num7;
			if (num7 != 2)
			{
			}
			int num8;
			if (num8 != 2)
			{
			}
			int num9;
			if (num9 != 2)
			{
			}
			int num10;
			if (num10 != 2)
			{
			}
			int num11;
			if (num11 != 2)
			{
			}
			int num12;
			if (num12 != 2)
			{
			}
		}
		int num13;
		if (num13 <= 9)
		{
			int num14;
			if (num14 != 2)
			{
			}
			List<AdvBuff> advBuffs3 = this.data.advBuffs;
			int num15;
			if (num15 != 2)
			{
			}
			List<AdvBuff> advBuffs4 = this.data.advBuffs;
			int num16;
			if (num16 != 2)
			{
			}
			List<AdvBuff> advBuffs5 = this.data.advBuffs;
			int num17;
			if (num17 != 2)
			{
			}
			List<AdvBuff> advBuffs6 = this.data.advBuffs;
			int num18;
			if (num18 != 2)
			{
			}
			List<AdvBuff> advBuffs7 = this.data.advBuffs;
			int num19;
			if (num19 != 2)
			{
			}
			List<AdvBuff> advBuffs8 = this.data.advBuffs;
			int num20;
			if (num20 != 2)
			{
			}
			List<AdvBuff> advBuffs9 = this.data.advBuffs;
			int num21;
			if (num21 != 2)
			{
			}
			List<AdvBuff> advBuffs10 = this.data.advBuffs;
			bool flag10;
			if ((RogueManager.Instance > (ulong)1L && advBuff != AdvBuff.魔力升级II) || flag10)
			{
			}
		}
		IL_01D3:
		num2++;
		return list;
	}

	// Token: 0x060026F2 RID: 9970 RVA: 0x000D085C File Offset: 0x000CEA5C
	[Token(Token = "0x60026F2")]
	[Address(RVA = "0x60F300", Offset = "0x60D900", VA = "0x18060F300")]
	public List<UltiBuff> GetUltiBuffPool()
	{
		List<UltiBuff> list;
		ulong num2;
		do
		{
			int num = 0;
			list = new List();
			List<TravelUnlocks> unlockedPlants = this.data.unlockedPlants;
			bool flag;
			if (flag)
			{
				PlantType plantType = TravelDictionary.UnlockToPlant[num];
				Dictionary<PlantType, ValueTuple<PlantType?, object, object, bool>> plantInfo = TravelDictionary.PlantInfo;
				bool flag2;
				while (!flag2)
				{
				}
				List<UltiBuff> ultiBuffs = this.data.ultiBuffs;
				bool flag3;
				if (!flag3)
				{
				}
				List<UltiBuff> ultiBuffs2 = this.data.ultiBuffs;
				bool flag4;
				while (flag4)
				{
				}
			}
		}
		while (num2 != (ulong)0L);
		return list;
	}

	// Token: 0x060026F3 RID: 9971 RVA: 0x000D0940 File Offset: 0x000CEB40
	[Token(Token = "0x60026F3")]
	[Address(RVA = "0x60DF80", Offset = "0x60C580", VA = "0x18060DF80")]
	public List<TravelDebuff> GetDebuffPool()
	{
		List<TravelDebuff> list = new List();
		TravelDebuff[] enumValues = global::Core.Lawnf.GetEnumValues<TravelDebuff>();
		int num = 0;
		if (num < enumValues.Length)
		{
			HashSet<TravelDebuff> leaderArmor = TravelHelper.LeaderArmor;
			bool flag;
			if (!flag)
			{
				List<TravelDebuff> travelDebuffs = this.data.travelDebuffs;
				bool flag2;
				if (!flag2)
				{
				}
			}
			num++;
		}
		return list;
	}

	// Token: 0x060026F4 RID: 9972 RVA: 0x000D0998 File Offset: 0x000CEB98
	[Token(Token = "0x60026F4")]
	[Address(RVA = "0x6110A0", Offset = "0x60F6A0", VA = "0x1806110A0")]
	public void ReinforcePlant(Board board, Plant plant)
	{
		for (;;)
		{
			int num = 0;
			int num2 = 0;
			List<InvestBuff> investmentBuffs = this.data.investmentBuffs;
			bool flag;
			if (!flag || TravelMgr.InvestBuffsData.TryGetValue(num, num2))
			{
				if (num2 != 0)
				{
					goto IL_0092;
				}
				int num3 = 0;
				SynergyManager instance = SynergyManager.Instance;
				int num4 = 0;
				List<SynergyType> activeSynergies = instance.GetActiveSynergies(num4 != 0);
				bool flag2;
				if (flag2)
				{
					if (!TravelMgr.SynergysData.TryGetValue(num, num2))
					{
						continue;
					}
					TypeCode typeCode = num2.GetTypeCode();
				}
				if (num3 != 0)
				{
					goto IL_009E;
				}
				int num5 = 0;
				bool flag3;
				if ((!flag3 || TravelMgr.DeBuffData.TryGetValue(num, num2)) && num5 == 0)
				{
					break;
				}
			}
		}
		return;
		IL_0092:
		throw new NullReferenceException();
		IL_009E:
		throw new NullReferenceException();
	}

	// Token: 0x060026F5 RID: 9973 RVA: 0x000D0A50 File Offset: 0x000CEC50
	[Token(Token = "0x60026F5")]
	[Address(RVA = "0x6115D0", Offset = "0x60FBD0", VA = "0x1806115D0")]
	public void ReinforceZombie(Zombie zombie)
	{
		int num;
		int num2;
		bool flag;
		do
		{
			num = 0;
			num2 = 0;
			List<TravelDebuff> travelDebuffs = this.data.travelDebuffs;
		}
		while ((flag && !TravelMgr.DeBuffData.TryGetValue(num, num2)) || num2 != 0);
	}

	// Token: 0x060026F6 RID: 9974 RVA: 0x000D0A94 File Offset: 0x000CEC94
	[Token(Token = "0x60026F6")]
	[Address(RVA = "0x611E90", Offset = "0x610490", VA = "0x180611E90")]
	[ProButton]
	public void UpdateSynergies()
	{
		while (this.data.Invest || Board.Instance.isEveStarted)
		{
			HashSet<PlantType> hashSet = new HashSet();
			Dictionary<PlantType, ValueTuple<PlantType?, object, object, bool>> plantInfo = TravelDictionary.PlantInfo;
			bool flag;
			if (flag)
			{
				if (!flag)
				{
				}
				bool flag2;
				while (!flag2)
				{
				}
			}
			ulong num;
			if (num == (ulong)0L)
			{
				SynergyManager instance = SynergyManager.Instance;
				List<PlantType> list = Enumerable.ToList<PlantType>(hashSet);
				instance.UpdateActiveSynergies(list);
				break;
			}
		}
	}

	// Token: 0x060026F7 RID: 9975 RVA: 0x000D0B14 File Offset: 0x000CED14
	[Token(Token = "0x60026F7")]
	[Address(RVA = "0x60E650", Offset = "0x60CC50", VA = "0x18060E650")]
	public int GetInvestLevel(InvestBuff investBuff)
	{
		bool flag = investBuff >= InvestBuff.幸运闪避;
		return 0;
	}

	// Token: 0x060026F8 RID: 9976 RVA: 0x000D0B30 File Offset: 0x000CED30
	[Token(Token = "0x60026F8")]
	[Address(RVA = "0x60FF30", Offset = "0x60E530", VA = "0x18060FF30")]
	public bool IsMini(AdvBuff advBuff)
	{
		HashSet<AdvBuff> hashSet = new HashSet();
		bool flag = hashSet.Add((uint)4003);
		bool flag2 = hashSet.Add((uint)4001);
		bool flag3 = hashSet.Add((uint)4002);
		bool flag4 = hashSet.Add((uint)4000);
		bool flag5 = hashSet.Add((uint)4004);
		bool flag6 = hashSet.Add((uint)4005);
		bool flag7 = hashSet.Add((uint)4006);
		bool flag8 = hashSet.Add((uint)4007);
		bool flag9;
		return flag9;
	}

	// Token: 0x060026F9 RID: 9977 RVA: 0x000D0BBC File Offset: 0x000CEDBC
	[Token(Token = "0x60026F9")]
	[Address(RVA = "0x60DCD0", Offset = "0x60C2D0", VA = "0x18060DCD0")]
	public HashSet<AdvBuff> GetAllNormalUltimatePlantBuffID()
	{
		HashSet<AdvBuff> hashSet;
		ulong num;
		do
		{
			hashSet = new HashSet();
			Dictionary<PlantType, ValueTuple<PlantType?, object, object, bool>> plantInfo = TravelDictionary.PlantInfo;
			bool flag;
			if (flag)
			{
			}
		}
		while (num != (ulong)0L);
		return hashSet;
	}

	// Token: 0x060026FA RID: 9978 RVA: 0x000D0C10 File Offset: 0x000CEE10
	[Token(Token = "0x60026FA")]
	[Address(RVA = "0x60EC90", Offset = "0x60D290", VA = "0x18060EC90")]
	public static PlantType GetPlantTypeByAdvBuff(object buff)
	{
		if (buff != 0 && buff != 0)
		{
			Dictionary<AdvBuff, PlantType> advBuffPlantPairs = TravelDictionary.AdvBuffPlantPairs;
			bool flag;
			bool flag2;
			if (!flag && flag2)
			{
				return PlantType.Present;
			}
		}
		return TravelHelper.GetPlantTypeFromBuff(buff);
	}

	// Token: 0x060026FB RID: 9979 RVA: 0x000D0C54 File Offset: 0x000CEE54
	[Token(Token = "0x60026FB")]
	[Address(RVA = "0x60EB60", Offset = "0x60D160", VA = "0x18060EB60")]
	public int GetPlantBuffUnlockCount(PlantType plantType)
	{
		int num = 0;
		int num2 = 0;
		Dictionary<PlantType, ValueTuple<PlantType?, object, object, bool>> plantInfo = TravelDictionary.PlantInfo;
		bool flag;
		bool flag2;
		if (flag && num != 0 && flag2)
		{
			num2++;
		}
		return num2;
	}

	// Token: 0x060026FC RID: 9980 RVA: 0x000D0C90 File Offset: 0x000CEE90
	[Token(Token = "0x60026FC")]
	[Address(RVA = "0x611790", Offset = "0x60FD90", VA = "0x180611790")]
	public int StrongUltiPlantBuffUnlockCount(PlantType plantType)
	{
		int num = 0;
		int num2 = 0;
		Dictionary<PlantType, ValueTuple<PlantType?, object, object, bool>> plantInfo = TravelDictionary.PlantInfo;
		bool flag;
		bool flag2;
		if (flag && num != 0 && flag2)
		{
			num2++;
		}
		return num2;
	}

	// Token: 0x060026FD RID: 9981 RVA: 0x000D0CCC File Offset: 0x000CEECC
	[Token(Token = "0x60026FD")]
	[Address(RVA = "0x612210", Offset = "0x610810", VA = "0x180612210")]
	public bool WeakUltiPlantBuffUnlock(PlantType plantType)
	{
		return this.GetPlantBuffUnlockCount(plantType) == 2;
	}

	// Token: 0x060026FE RID: 9982 RVA: 0x000D0CE4 File Offset: 0x000CEEE4
	[Token(Token = "0x60026FE")]
	[Address(RVA = "0x6118C0", Offset = "0x60FEC0", VA = "0x1806118C0")]
	public bool StrongUltiPlantBuffUnlock(PlantType plantType)
	{
		return this.StrongUltiPlantBuffUnlockCount(plantType) == 2;
	}

	// Token: 0x060026FF RID: 9983 RVA: 0x000D0CFC File Offset: 0x000CEEFC
	[Token(Token = "0x60026FF")]
	[Address(RVA = "0x60FEB0", Offset = "0x60E4B0", VA = "0x18060FEB0")]
	public static bool IsCurseBuff(AdvBuff buff)
	{
		HashSet<AdvBuff> curseBuffs = TravelDictionary.CurseBuffs;
		bool flag;
		return flag;
	}

	// Token: 0x06002700 RID: 9984 RVA: 0x000D0D18 File Offset: 0x000CEF18
	[Token(Token = "0x6002700")]
	[Address(RVA = "0x610070", Offset = "0x60E670", VA = "0x180610070")]
	public static bool IsRandomBuff(AdvBuff buff)
	{
		HashSet<AdvBuff> randomBuffs = TravelDictionary.RandomBuffs;
		bool flag;
		return flag;
	}

	// Token: 0x06002701 RID: 9985 RVA: 0x000D0D34 File Offset: 0x000CEF34
	[Token(Token = "0x6002701")]
	[Address(RVA = "0x6100F0", Offset = "0x60E6F0", VA = "0x1806100F0")]
	public static bool IsRogueBuff(AdvBuff buff)
	{
		HashSet<AdvBuff> rogueBuffs = TravelDictionary.RogueBuffs;
		bool flag;
		return flag;
	}

	// Token: 0x06002702 RID: 9986 RVA: 0x000D0D50 File Offset: 0x000CEF50
	[Token(Token = "0x6002702")]
	[Address(RVA = "0x60EDF0", Offset = "0x60D3F0", VA = "0x18060EDF0")]
	public static int GetStringUltimtePlantIndex(PlantType plantType)
	{
		List<PlantType> allStrongUltimtePlant = TravelDictionary.allStrongUltimtePlant;
		int num;
		return num;
	}

	// Token: 0x06002703 RID: 9987 RVA: 0x000D0D6C File Offset: 0x000CEF6C
	[Token(Token = "0x6002703")]
	[Address(RVA = "0x60EE70", Offset = "0x60D470", VA = "0x18060EE70")]
	public string GetText(object buff)
	{
		if (buff != 0)
		{
			if (buff == 0)
			{
				if (buff == 0)
				{
					if (buff == 0)
					{
						if (buff == 0)
						{
							if (buff == 0)
							{
								goto IL_0072;
							}
							string text2;
							string text = text2 + "：";
							Dictionary<InvestBuff, InvestBuffData> investBuffsData = TravelMgr.InvestBuffsData;
							bool flag;
							if (flag)
							{
								string text3;
								return text3;
							}
							goto IL_006C;
						}
						else
						{
							Dictionary<TravelDebuff, ValueTuple<string, ZombieType>> debuffData = TravelDictionary.debuffData;
							bool flag2;
							if (!flag2)
							{
								goto IL_006C;
							}
						}
					}
					Dictionary<UltiBuff, string> ultimateBuffsText = TravelDictionary.ultimateBuffsText;
					bool flag3;
					if (!flag3)
					{
						goto IL_006C;
					}
				}
				Dictionary<AdvBuff, string> advancedBuffsText = TravelDictionary.advancedBuffsText;
				bool flag4;
				if (!flag4)
				{
					goto IL_006C;
				}
			}
			Dictionary<TravelUnlocks, string> unlocksText = TravelDictionary.unlocksText;
			bool flag5;
			if (flag5)
			{
			}
			IL_006C:
			return "未知索引";
		}
		IL_0072:
		return "获得5000阳光";
	}

	// Token: 0x06002704 RID: 9988 RVA: 0x000D0DF8 File Offset: 0x000CEFF8
	[Token(Token = "0x6002704")]
	[Address(RVA = "0x60D2E0", Offset = "0x60B8E0", VA = "0x18060D2E0")]
	public void Clear()
	{
		int num = 0;
		this.TravelPackage = num;
		TravelData travelData = new TravelData();
		this.data = travelData;
		List<PlantType> list = new List();
		this.ulockedPlants_temp = list;
		this.plantZeroHealth = num != 0;
		this.damageReduction = (float)num;
		this.luckyDamage = 1f;
	}

	// Token: 0x1700018F RID: 399
	// (get) Token: 0x06002705 RID: 9989 RVA: 0x000D0E44 File Offset: 0x000CF044
	[Token(Token = "0x1700018F")]
	public static TravelMgr Instance
	{
		[Token(Token = "0x6002705")]
		[Address(RVA = "0x6129B0", Offset = "0x610FB0", VA = "0x1806129B0")]
		get
		{
			TravelMgr instance = TravelMgr._instance;
			int num = 0;
			if (instance == num)
			{
				TravelMgr._instance = GameAPP.Instance.AddComponent<TravelMgr>();
			}
			return TravelMgr._instance;
		}
	}

	// Token: 0x06002706 RID: 9990 RVA: 0x000D0E7C File Offset: 0x000CF07C
	[Token(Token = "0x6002706")]
	[Address(RVA = "0x612230", Offset = "0x610830", VA = "0x180612230")]
	static TravelMgr()
	{
		int num;
		do
		{
			num = 0;
			TravelMgr.SynergysData = new Dictionary();
			TravelMgr.InvestBuffsData = new Dictionary();
			TravelMgr.AdvBuffData = new Dictionary();
			TravelMgr.DeBuffData = new Dictionary();
			Dictionary<SynergyType, BaseSynergyData> dictionary = new Dictionary();
			TravelMgr.SynergysData = dictionary;
			if (dictionary != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					if (num != typeof(IEnumerator).TypeHandle)
					{
						num++;
					}
				}
				object obj;
				obj += obj;
				Dictionary<SynergyType, BaseSynergyData> synergysData = TravelMgr.SynergysData;
				SynergyManager instance = SynergyManager.Instance;
				List<PlantType> list;
				HashSet<PlantType> hashSet = Enumerable.ToHashSet<PlantType>(list);
			}
			if ("{il2cpp array field local11->}" != (ulong)0L)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x06002707 RID: 9991 RVA: 0x000D0F34 File Offset: 0x000CF134
	[Token(Token = "0x6002707")]
	[Address(RVA = "0x612820", Offset = "0x610E20", VA = "0x180612820")]
	public TravelMgr()
	{
		TravelData travelData = new TravelData();
		this.data = travelData;
		List<PlantType> list = new List();
		this.ulockedPlants_temp = list;
		this.luckyDamage = 1f;
		base..ctor();
	}

	// Token: 0x04001570 RID: 5488
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001570")]
	public TravelData data;

	// Token: 0x04001571 RID: 5489
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001571")]
	public List<PlantType> ulockedPlants_temp;

	// Token: 0x04001572 RID: 5490
	[Token(Token = "0x4001572")]
	public static Dictionary<SynergyType, BaseSynergyData> SynergysData;

	// Token: 0x04001573 RID: 5491
	[Token(Token = "0x4001573")]
	public static Dictionary<InvestBuff, InvestBuffData> InvestBuffsData;

	// Token: 0x04001574 RID: 5492
	[Token(Token = "0x4001574")]
	public static Dictionary<AdvBuff, BaseBuff<AdvBuff>> AdvBuffData;

	// Token: 0x04001575 RID: 5493
	[Token(Token = "0x4001575")]
	public static Dictionary<TravelDebuff, BaseBuff<TravelDebuff>> DeBuffData;

	// Token: 0x04001576 RID: 5494
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001576")]
	public TravelPackage TravelPackage;

	// Token: 0x04001577 RID: 5495
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001577")]
	public float damageReduction;

	// Token: 0x04001578 RID: 5496
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4001578")]
	public float luckyStrike;

	// Token: 0x04001579 RID: 5497
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001579")]
	public float luckyDamage;

	// Token: 0x0400157A RID: 5498
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x400157A")]
	public float damageAmplification;

	// Token: 0x0400157B RID: 5499
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400157B")]
	public bool plantZeroHealth;

	// Token: 0x0400157C RID: 5500
	[Token(Token = "0x400157C")]
	private static TravelMgr _instance;
}
