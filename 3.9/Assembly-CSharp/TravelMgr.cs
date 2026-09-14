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

// Token: 0x020007C2 RID: 1986
[Token(Token = "0x20007C2")]
public class TravelMgr : MonoBehaviour
{
	// Token: 0x170001D6 RID: 470
	// (get) Token: 0x06002812 RID: 10258 RVA: 0x000D4E38 File Offset: 0x000D3038
	[Token(Token = "0x170001D6")]
	public float DamageAmplification
	{
		[Token(Token = "0x6002812")]
		[Address(RVA = "0x6762A0", Offset = "0x6748A0", VA = "0x1806762A0")]
		get
		{
			return this.data.damageAmplification;
		}
	}

	// Token: 0x170001D7 RID: 471
	// (get) Token: 0x06002813 RID: 10259 RVA: 0x000D4E58 File Offset: 0x000D3058
	[Token(Token = "0x170001D7")]
	public float LuckyStrike
	{
		[Token(Token = "0x6002813")]
		[Address(RVA = "0x676410", Offset = "0x674A10", VA = "0x180676410")]
		get
		{
			return this.data.moreLuckyStrike;
		}
	}

	// Token: 0x170001D8 RID: 472
	// (get) Token: 0x06002814 RID: 10260 RVA: 0x000D4E78 File Offset: 0x000D3078
	[Token(Token = "0x170001D8")]
	public int BasicDamage
	{
		[Token(Token = "0x6002814")]
		[Address(RVA = "0x676200", Offset = "0x674800", VA = "0x180676200")]
		get
		{
			int theCurrentSurvivalRound = Board.Instance.theCurrentSurvivalRound;
			TravelData travelData = this.data;
			long num = (long)(1U * (uint)10000);
			throw new NullReferenceException();
		}
	}

	// Token: 0x06002815 RID: 10261 RVA: 0x000D4EA8 File Offset: 0x000D30A8
	[Token(Token = "0x6002815")]
	[Address(RVA = "0x6744B0", Offset = "0x672AB0", VA = "0x1806744B0")]
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

	// Token: 0x06002816 RID: 10262 RVA: 0x000D5000 File Offset: 0x000D3200
	[Token(Token = "0x6002816")]
	[Address(RVA = "0x673C70", Offset = "0x672270", VA = "0x180673C70")]
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

	// Token: 0x06002817 RID: 10263 RVA: 0x000D511C File Offset: 0x000D331C
	[Token(Token = "0x6002817")]
	[Address(RVA = "0x6738F0", Offset = "0x671EF0", VA = "0x1806738F0")]
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

	// Token: 0x06002818 RID: 10264 RVA: 0x000D51A8 File Offset: 0x000D33A8
	[Token(Token = "0x6002818")]
	[Address(RVA = "0x675290", Offset = "0x673890", VA = "0x180675290")]
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

	// Token: 0x06002819 RID: 10265 RVA: 0x000D52B4 File Offset: 0x000D34B4
	[Token(Token = "0x6002819")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20")]
	public void OnUpdate()
	{
	}

	// Token: 0x0600281A RID: 10266 RVA: 0x000D52C4 File Offset: 0x000D34C4
	[Token(Token = "0x600281A")]
	[Address(RVA = "0x671DA0", Offset = "0x6703A0", VA = "0x180671DA0")]
	[ProButton]
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

	// Token: 0x0600281B RID: 10267 RVA: 0x000D5330 File Offset: 0x000D3530
	[Token(Token = "0x600281B")]
	[Address(RVA = "0x675200", Offset = "0x673800", VA = "0x180675200")]
	public void UnlockPlant(TravelUnlocks unlock)
	{
		List<TravelUnlocks> unlockedPlants = this.data.unlockedPlants;
		this.UpdateSynergies();
	}

	// Token: 0x0600281C RID: 10268 RVA: 0x000D5358 File Offset: 0x000D3558
	[Token(Token = "0x600281C")]
	[Address(RVA = "0x671FB0", Offset = "0x6705B0", VA = "0x180671FB0")]
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

	// Token: 0x0600281D RID: 10269 RVA: 0x000D5420 File Offset: 0x000D3620
	[Token(Token = "0x600281D")]
	[Address(RVA = "0x673040", Offset = "0x671640", VA = "0x180673040")]
	public void GetUltiBuff(UltiBuff buff, bool upgrade = false)
	{
		int num4;
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
					goto IL_00AC;
				}
				num4 = 0;
			}
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
		}
		while (num4 != 0);
		return;
		IL_00AC:
		throw new NullReferenceException();
	}

	// Token: 0x0600281E RID: 10270 RVA: 0x000D54E8 File Offset: 0x000D36E8
	[Token(Token = "0x600281E")]
	[Address(RVA = "0x671A70", Offset = "0x670070", VA = "0x180671A70")]
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

	// Token: 0x0600281F RID: 10271 RVA: 0x000D55B4 File Offset: 0x000D37B4
	[Token(Token = "0x600281F")]
	[Address(RVA = "0x673450", Offset = "0x671A50", VA = "0x180673450")]
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
		return list;
	}

	// Token: 0x06002820 RID: 10272 RVA: 0x000D5620 File Offset: 0x000D3820
	[Token(Token = "0x6002820")]
	[Address(RVA = "0x670C00", Offset = "0x66F200", VA = "0x180670C00")]
	public List<AdvBuff> GetAdvancedBuffPool(bool inStore = false)
	{
		int num;
		List<AdvBuff> list;
		for (;;)
		{
			num = 0;
			int num2 = 0;
			list = new List();
			Board instance = Board.Instance;
			bool flag = global::Lawnf.TravelCurse();
			bool isRogue = instance.boardTag.isRogue;
			bool isSuperRandom = instance.boardTag.isSuperRandom;
			AdvBuff[] enumValues = global::Core.Lawnf.GetEnumValues<AdvBuff>();
			if (num >= enumValues.Length)
			{
				return list;
			}
			AdvBuff advBuff = enumValues[num];
			List<AdvBuff> advBuffs = this.data.advBuffs;
			bool flag2;
			bool flag3;
			if (flag2 || advBuff >= AdvBuff.Tool_手拖车 || (flag3 && !isSuperRandom))
			{
				goto IL_01FF;
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
					bool flag8 = this.IsMini((AdvBuff)num2);
				}
				if (num != 0)
				{
					continue;
				}
			}
			bool flag9;
			bool flag10;
			if (flag9 || flag10 || advBuff == AdvBuff.魔力升级II || flag10 <= true || flag10 <= true)
			{
				goto IL_01FF;
			}
			if (advBuff > AdvBuff.魔力升级II)
			{
				if (flag10 <= true)
				{
					int num3;
					if (num3 != 2)
					{
					}
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
				}
				int num12;
				if (num12 <= 9)
				{
					uint num13;
					num12 += (int)num13;
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
					if (RogueManager.Instance <= (ulong)1L || advBuff == AdvBuff.魔力升级II)
					{
					}
				}
				bool flag11;
				if (flag11)
				{
					break;
				}
			}
		}
		if (this.GetPlantBuffUnlockCount((PlantType)num) == 2)
		{
		}
		IL_01FF:
		num++;
		return list;
	}

	// Token: 0x06002821 RID: 10273 RVA: 0x000D5844 File Offset: 0x000D3A44
	[Token(Token = "0x6002821")]
	[Address(RVA = "0x672C40", Offset = "0x671240", VA = "0x180672C40")]
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

	// Token: 0x06002822 RID: 10274 RVA: 0x000D5928 File Offset: 0x000D3B28
	[Token(Token = "0x6002822")]
	[Address(RVA = "0x6718C0", Offset = "0x66FEC0", VA = "0x1806718C0")]
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

	// Token: 0x06002823 RID: 10275 RVA: 0x000D5980 File Offset: 0x000D3B80
	[Token(Token = "0x6002823")]
	[Address(RVA = "0x674820", Offset = "0x672E20", VA = "0x180674820")]
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
					goto IL_00B7;
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
					goto IL_00C3;
				}
				int num5 = 0;
				bool flag3;
				if (!flag3 || TravelMgr.DeBuffData.TryGetValue(num, num2))
				{
					if (num5 != 0)
					{
						goto IL_00CF;
					}
					int num6 = 0;
					bool flag4;
					if ((!flag4 || TravelMgr.AdvBuffData.TryGetValue(num, num2)) && num6 == 0)
					{
						break;
					}
				}
			}
		}
		return;
		IL_00B7:
		throw new NullReferenceException();
		IL_00C3:
		throw new NullReferenceException();
		IL_00CF:
		throw new NullReferenceException();
	}

	// Token: 0x06002824 RID: 10276 RVA: 0x000D5A68 File Offset: 0x000D3C68
	[Token(Token = "0x6002824")]
	[Address(RVA = "0x674EF0", Offset = "0x6734F0", VA = "0x180674EF0")]
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

	// Token: 0x06002825 RID: 10277 RVA: 0x000D5AAC File Offset: 0x000D3CAC
	[Token(Token = "0x6002825")]
	[Address(RVA = "0x6757B0", Offset = "0x673DB0", VA = "0x1806757B0")]
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

	// Token: 0x06002826 RID: 10278 RVA: 0x000D5B2C File Offset: 0x000D3D2C
	[Token(Token = "0x6002826")]
	[Address(RVA = "0x671F90", Offset = "0x670590", VA = "0x180671F90")]
	public int GetInvestLevel(InvestBuff investBuff)
	{
		bool flag = investBuff >= InvestBuff.幸运闪避;
		return 0;
	}

	// Token: 0x06002827 RID: 10279 RVA: 0x000D5B48 File Offset: 0x000D3D48
	[Token(Token = "0x6002827")]
	[Address(RVA = "0x6736B0", Offset = "0x671CB0", VA = "0x1806736B0")]
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

	// Token: 0x06002828 RID: 10280 RVA: 0x000D5BD4 File Offset: 0x000D3DD4
	[Token(Token = "0x6002828")]
	[Address(RVA = "0x671610", Offset = "0x66FC10", VA = "0x180671610")]
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

	// Token: 0x06002829 RID: 10281 RVA: 0x000D5C28 File Offset: 0x000D3E28
	[Token(Token = "0x6002829")]
	[Address(RVA = "0x6725D0", Offset = "0x670BD0", VA = "0x1806725D0")]
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

	// Token: 0x0600282A RID: 10282 RVA: 0x000D5C6C File Offset: 0x000D3E6C
	[Token(Token = "0x600282A")]
	[Address(RVA = "0x6724A0", Offset = "0x670AA0", VA = "0x1806724A0")]
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

	// Token: 0x0600282B RID: 10283 RVA: 0x000D5CA8 File Offset: 0x000D3EA8
	[Token(Token = "0x600282B")]
	[Address(RVA = "0x6750B0", Offset = "0x6736B0", VA = "0x1806750B0")]
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

	// Token: 0x0600282C RID: 10284 RVA: 0x000D5CE4 File Offset: 0x000D3EE4
	[Token(Token = "0x600282C")]
	[Address(RVA = "0x675B30", Offset = "0x674130", VA = "0x180675B30")]
	public bool WeakUltiPlantBuffUnlock(PlantType plantType)
	{
		return this.GetPlantBuffUnlockCount(plantType) == 2;
	}

	// Token: 0x0600282D RID: 10285 RVA: 0x000D5CFC File Offset: 0x000D3EFC
	[Token(Token = "0x600282D")]
	[Address(RVA = "0x6751E0", Offset = "0x6737E0", VA = "0x1806751E0")]
	public bool StrongUltiPlantBuffUnlock(PlantType plantType)
	{
		return this.StrongUltiPlantBuffUnlockCount(plantType) == 2;
	}

	// Token: 0x0600282E RID: 10286 RVA: 0x000D5D14 File Offset: 0x000D3F14
	[Token(Token = "0x600282E")]
	[Address(RVA = "0x673630", Offset = "0x671C30", VA = "0x180673630")]
	public static bool IsCurseBuff(AdvBuff buff)
	{
		HashSet<AdvBuff> curseBuffs = TravelDictionary.CurseBuffs;
		bool flag;
		return flag;
	}

	// Token: 0x0600282F RID: 10287 RVA: 0x000D5D30 File Offset: 0x000D3F30
	[Token(Token = "0x600282F")]
	[Address(RVA = "0x6737F0", Offset = "0x671DF0", VA = "0x1806737F0")]
	public static bool IsRandomBuff(AdvBuff buff)
	{
		HashSet<AdvBuff> randomBuffs = TravelDictionary.RandomBuffs;
		bool flag;
		return flag;
	}

	// Token: 0x06002830 RID: 10288 RVA: 0x000D5D4C File Offset: 0x000D3F4C
	[Token(Token = "0x6002830")]
	[Address(RVA = "0x673870", Offset = "0x671E70", VA = "0x180673870")]
	public static bool IsRogueBuff(AdvBuff buff)
	{
		HashSet<AdvBuff> rogueBuffs = TravelDictionary.RogueBuffs;
		bool flag;
		return flag;
	}

	// Token: 0x06002831 RID: 10289 RVA: 0x000D5D68 File Offset: 0x000D3F68
	[Token(Token = "0x6002831")]
	[Address(RVA = "0x672730", Offset = "0x670D30", VA = "0x180672730")]
	public static int GetStringUltimtePlantIndex(PlantType plantType)
	{
		List<PlantType> allStrongUltimtePlant = TravelDictionary.allStrongUltimtePlant;
		int num;
		return num;
	}

	// Token: 0x06002832 RID: 10290 RVA: 0x000D5D84 File Offset: 0x000D3F84
	[Token(Token = "0x6002832")]
	[Address(RVA = "0x6727B0", Offset = "0x670DB0", VA = "0x1806727B0")]
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

	// Token: 0x06002833 RID: 10291 RVA: 0x000D5E10 File Offset: 0x000D4010
	[Token(Token = "0x6002833")]
	[Address(RVA = "0x670B30", Offset = "0x66F130", VA = "0x180670B30")]
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

	// Token: 0x170001D9 RID: 473
	// (get) Token: 0x06002834 RID: 10292 RVA: 0x000D5E5C File Offset: 0x000D405C
	[Token(Token = "0x170001D9")]
	public static TravelMgr Instance
	{
		[Token(Token = "0x6002834")]
		[Address(RVA = "0x6762D0", Offset = "0x6748D0", VA = "0x1806762D0")]
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

	// Token: 0x06002835 RID: 10293 RVA: 0x000D5E94 File Offset: 0x000D4094
	[Token(Token = "0x6002835")]
	[Address(RVA = "0x675B50", Offset = "0x674150", VA = "0x180675B50")]
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
			Func<Type, bool> func = delegate(Type t)
			{
				if (typeof(BaseSynergyData).IsAssignableFrom(t) && !t.IsInterface)
				{
					return t.IsAbstract;
				}
				throw new NullReferenceException();
			};
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

	// Token: 0x06002836 RID: 10294 RVA: 0x000D5F5C File Offset: 0x000D415C
	[Token(Token = "0x6002836")]
	[Address(RVA = "0x676140", Offset = "0x674740", VA = "0x180676140")]
	public TravelMgr()
	{
		TravelData travelData = new TravelData();
		this.data = travelData;
		List<PlantType> list = new List();
		this.ulockedPlants_temp = list;
		this.luckyDamage = 1f;
		base..ctor();
	}

	// Token: 0x0400164C RID: 5708
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400164C")]
	public TravelData data;

	// Token: 0x0400164D RID: 5709
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400164D")]
	public List<PlantType> ulockedPlants_temp;

	// Token: 0x0400164E RID: 5710
	[Token(Token = "0x400164E")]
	public static Dictionary<SynergyType, BaseSynergyData> SynergysData;

	// Token: 0x0400164F RID: 5711
	[Token(Token = "0x400164F")]
	public static Dictionary<InvestBuff, InvestBuffData> InvestBuffsData;

	// Token: 0x04001650 RID: 5712
	[Token(Token = "0x4001650")]
	public static Dictionary<AdvBuff, BaseBuff<AdvBuff>> AdvBuffData;

	// Token: 0x04001651 RID: 5713
	[Token(Token = "0x4001651")]
	public static Dictionary<TravelDebuff, BaseBuff<TravelDebuff>> DeBuffData;

	// Token: 0x04001652 RID: 5714
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001652")]
	public TravelPackage TravelPackage;

	// Token: 0x04001653 RID: 5715
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001653")]
	public float damageReduction;

	// Token: 0x04001654 RID: 5716
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4001654")]
	public float luckyStrike;

	// Token: 0x04001655 RID: 5717
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001655")]
	public float luckyDamage;

	// Token: 0x04001656 RID: 5718
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4001656")]
	public float damageAmplification;

	// Token: 0x04001657 RID: 5719
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001657")]
	public bool plantZeroHealth;

	// Token: 0x04001658 RID: 5720
	[Token(Token = "0x4001658")]
	private static TravelMgr _instance;
}
