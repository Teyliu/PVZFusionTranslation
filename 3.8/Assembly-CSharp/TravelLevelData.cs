using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using GameLevel;
using UnityEngine.Events;

// Token: 0x0200099C RID: 2460
[Token(Token = "0x200099C")]
public class TravelLevelData : SurvivalLevelData
{
	// Token: 0x170001D0 RID: 464
	// (get) Token: 0x06003210 RID: 12816 RVA: 0x00108058 File Offset: 0x00106258
	[Token(Token = "0x170001D0")]
	protected override SurvivalLevel Level
	{
		[Token(Token = "0x6003210")]
		[Address(RVA = "0x69CF20", Offset = "0x69B520", VA = "0x18069CF20", Slot = "42")]
		get
		{
			return SurvivalLevel.CustomTravel;
		}
	}

	// Token: 0x170001D1 RID: 465
	// (get) Token: 0x06003211 RID: 12817 RVA: 0x00108068 File Offset: 0x00106268
	// (set) Token: 0x06003212 RID: 12818 RVA: 0x0010810C File Offset: 0x0010630C
	[Token(Token = "0x170001D1")]
	public override string Name
	{
		[Token(Token = "0x6003211")]
		[Address(RVA = "0x6FAF30", Offset = "0x6F9530", VA = "0x1806FAF30", Slot = "8")]
		get
		{
			int theCurrentSurvivalRound = Board.Instance.theCurrentSurvivalRound;
			ZombieType routeBossType = TravelMgr.Instance.data.routeBossType;
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
					goto IL_0045;
				}
			}
			if (routeBossType == ZombieType.UltimateGargantuar)
			{
			}
			IL_0045:
			string text;
			if (!string.IsNullOrEmpty("将军线"))
			{
				text = "旅行：" + " " + "将军线";
			}
			if (theCurrentSurvivalRound != 1)
			{
				int theCurrentSurvivalRound2 = Board.Instance.theCurrentSurvivalRound;
				string text2 = string.Format(" 第{0}轮", theCurrentSurvivalRound2);
				return text + text2;
			}
			throw new NullReferenceException();
		}
		[Token(Token = "0x6003212")]
		[Address(RVA = "0x4A9D50", Offset = "0x4A8350", VA = "0x1804A9D50", Slot = "9")]
		set
		{
			this.<Name>k__BackingField = value;
		}
	}

	// Token: 0x170001D2 RID: 466
	// (get) Token: 0x06003213 RID: 12819 RVA: 0x00108120 File Offset: 0x00106320
	[Token(Token = "0x170001D2")]
	public override int MaxWave
	{
		[Token(Token = "0x6003213")]
		[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "10")]
		get
		{
			return 20;
		}
	}

	// Token: 0x06003214 RID: 12820 RVA: 0x00108130 File Offset: 0x00106330
	[Token(Token = "0x6003214")]
	[Address(RVA = "0x6F8910", Offset = "0x6F6F10", VA = "0x1806F8910", Slot = "39")]
	public override void OnBoardAwake(Board board)
	{
		base.OnBoardAwake(board);
		board.boardTag.isTravel = true;
		board.boardTag.enableTravelPlant = true;
		TravelProcess travelProcess = TravelMgr.Instance.data.travelProcess;
		if (travelProcess == TravelProcess.Normal)
		{
			board.theSurvivalMaxRound = (int)((ulong)21L);
			return;
		}
		if (travelProcess == TravelProcess.Normal)
		{
			board.theSurvivalMaxRound = (int)((ulong)7L);
			return;
		}
		if (travelProcess != TravelProcess.Normal)
		{
			if (travelProcess == TravelProcess.Fast)
			{
				board.theSurvivalMaxRound = (int)((ulong)2147483647L);
			}
			return;
		}
		board.theSurvivalMaxRound = (int)((ulong)22L);
	}

	// Token: 0x06003215 RID: 12821 RVA: 0x001081B4 File Offset: 0x001063B4
	[Token(Token = "0x6003215")]
	[Address(RVA = "0x6F8330", Offset = "0x6F6930", VA = "0x1806F8330", Slot = "40")]
	public override void OnAnimUIOver(Board board)
	{
		if (!TravelMgr.Instance.data.Invest)
		{
			Board board2 = board;
			UIResourcesLoader uimanager = GameAPP.UIManager;
			if (TravelLevelData.<>c.<>9__12_0 == 0)
			{
				TravelLevelData.<>c.<>9__12_0 = delegate
				{
				};
			}
			UnityAction unityAction;
			if (TravelLevelData.<>c.<>9__12_1 == 0)
			{
				unityAction = delegate
				{
					TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)1000));
				};
				TravelLevelData.<>c.<>9__12_1 = unityAction;
			}
			UnityAction unityAction2 = delegate
			{
				Board board3 = board;
				int num2 = 0;
				board3.GetPoint(6000f, num2 != 0);
			};
			Action action;
			if (TravelLevelData.<>c.<>9__12_3 == 0)
			{
				action = delegate
				{
					InGameText.Instance.TimeOver();
				};
				TravelLevelData.<>c.<>9__12_3 = action;
			}
			Delegate @delegate = Delegate.Combine(unityAction, action);
			if (@delegate == 0)
			{
			}
			if (@delegate == 0 || @delegate == 0)
			{
				throw new InvalidCastException();
			}
			InGameText instance = InGameText.Instance;
			int num = 0;
			instance.ShowText("欢迎来到旅行模式\n请选择一项初始祝福", 30f, num != 0);
		}
	}

	// Token: 0x170001D3 RID: 467
	// (get) Token: 0x06003216 RID: 12822 RVA: 0x001082B8 File Offset: 0x001064B8
	// (set) Token: 0x06003217 RID: 12823 RVA: 0x00108338 File Offset: 0x00106538
	[Token(Token = "0x170001D3")]
	public override SceneType SceneType
	{
		[Token(Token = "0x6003216")]
		[Address(RVA = "0x6FB160", Offset = "0x6F9760", VA = "0x1806FB160", Slot = "12")]
		get
		{
			int num = 0;
			int temp_round = TravelMgr.Instance.data.temp_round;
			if (TravelMgr.Instance.data.travelProcess == TravelProcess.Fast)
			{
			}
			if (temp_round > 21)
			{
			}
			if ((!TravelMgr.Instance.TravelPackage.LandRoute && !TravelLevelData.WaterScenes.TryGetValue(0, num)) || !TravelLevelData.LandScenes.TryGetValue(0, num))
			{
			}
			throw new NullReferenceException();
		}
		[Token(Token = "0x6003217")]
		[Address(RVA = "0x6FBEA0", Offset = "0x6FA4A0", VA = "0x1806FBEA0", Slot = "13")]
		set
		{
			this.<SceneType>k__BackingField = value;
		}
	}

	// Token: 0x170001D4 RID: 468
	// (get) Token: 0x06003218 RID: 12824 RVA: 0x0010834C File Offset: 0x0010654C
	// (set) Token: 0x06003219 RID: 12825 RVA: 0x00108598 File Offset: 0x00106798
	[Token(Token = "0x170001D4")]
	public override List<ZombieType> SpawnZombies
	{
		[Token(Token = "0x6003218")]
		[Address(RVA = "0x6FB340", Offset = "0x6F9940", VA = "0x1806FB340", Slot = "20")]
		get
		{
			List<ZombieType> list2;
			ulong num3;
			do
			{
				int num = 0;
				int theCurrentSurvivalRound = Board.Instance.theCurrentSurvivalRound;
				if (TravelMgr.Instance.data.travelProcess == TravelProcess.Fast)
				{
				}
				if (theCurrentSurvivalRound > 21)
				{
				}
				ZombieType routeBossType = TravelMgr.Instance.data.routeBossType;
				if (routeBossType <= ZombieType.UltimateFootballZombie || routeBossType == ZombieType.UltimateJacksonDriver || routeBossType == ZombieType.UltimateImpKing)
				{
				}
				Dictionary<int, List<ZombieType>> landSpawns = TravelLevelData.LandSpawns;
				List<ZombieType> list = new List();
				bool flag;
				if (flag)
				{
				}
				TravelPackage travelPackage = TravelMgr.Instance.TravelPackage;
				if (travelPackage != 0)
				{
					Dictionary<int, List<ZombieType>> spawns = travelPackage.Spawns;
					bool flag2;
					if (flag2)
					{
					}
				}
				uint num2;
				if (num2 != list2)
				{
					break;
				}
				TravelData data = TravelMgr.Instance.data;
				HashSet<TravelDebuff> leaderAppear = TravelHelper.LeaderAppear;
				bool flag3;
				if (flag3)
				{
					if (!TravelMgr.Instance.data.travelDebuffs.Contains(num))
					{
						continue;
					}
					Dictionary<TravelDebuff, ValueTuple<string, ZombieType>> debuffData = TravelDictionary.debuffData;
				}
			}
			while (num3 != (ulong)0L);
			List<TravelDebuff> travelDebuffs = TravelMgr.Instance.data.travelDebuffs;
			bool flag4;
			if (flag4)
			{
				int size = list2._size;
				list2._size = (flag4 ? 1 : 0);
			}
			List<TravelDebuff> travelDebuffs2 = TravelMgr.Instance.data.travelDebuffs;
			bool flag5;
			if (flag5)
			{
				int size2 = list2._size;
				list2._size = (flag5 ? 1 : 0);
			}
			List<TravelDebuff> travelDebuffs3 = TravelMgr.Instance.data.travelDebuffs;
			bool flag6;
			if (flag6)
			{
				int size3 = list2._size;
				list2._size = (flag6 ? 1 : 0);
			}
			List<TravelDebuff> travelDebuffs4 = TravelMgr.Instance.data.travelDebuffs;
			bool flag7;
			if (flag7)
			{
				int size4 = list2._size;
				list2._size = (flag7 ? 1 : 0);
			}
			List<TravelDebuff> travelDebuffs5 = TravelMgr.Instance.data.travelDebuffs;
			bool flag8;
			if (flag8)
			{
				int size5 = list2._size;
				list2._size = (flag8 ? 1 : 0);
			}
			List<TravelDebuff> travelDebuffs6 = TravelMgr.Instance.data.travelDebuffs;
			bool flag9;
			if (flag9)
			{
				int size6 = list2._size;
				list2._size = (flag9 ? 1 : 0);
			}
			List<TravelDebuff> travelDebuffs7 = TravelMgr.Instance.data.travelDebuffs;
			bool flag10;
			if (flag10)
			{
				int size7 = list2._size;
				list2._size = (flag10 ? 1 : 0);
			}
			return list2;
		}
		[Token(Token = "0x6003219")]
		[Address(RVA = "0x6FBEB0", Offset = "0x6FA4B0", VA = "0x1806FBEB0", Slot = "21")]
		set
		{
			this.<SpawnZombies>k__BackingField = value;
		}
	}

	// Token: 0x0600321A RID: 12826 RVA: 0x001085AC File Offset: 0x001067AC
	[Token(Token = "0x600321A")]
	[Address(RVA = "0x6FAF20", Offset = "0x6F9520", VA = "0x1806FAF20")]
	public TravelLevelData()
	{
	}

	// Token: 0x0600321B RID: 12827 RVA: 0x001085C0 File Offset: 0x001067C0
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x600321B")]
	[Address(RVA = "0x6F8A00", Offset = "0x6F7000", VA = "0x1806F8A00")]
	static TravelLevelData()
	{
		Dictionary<int, SceneType> dictionary = new Dictionary();
		dictionary[1] = (uint)6;
		dictionary[2] = (uint)7;
		dictionary[3] = (uint)2;
		dictionary[4] = (uint)3;
		dictionary[5] = (uint)10;
		dictionary[6] = (uint)12;
		dictionary[7] = (uint)13;
		TravelLevelData.LandScenes = dictionary;
		Dictionary<int, List<ZombieType>> dictionary2 = new Dictionary();
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		dictionary2[1] = list;
		List<ZombieType> list2 = new List();
		int size4 = list2._size;
		int size5 = list2._size;
		int size6 = list2._size;
		int size7 = list2._size;
		dictionary2[2] = list2;
		List<ZombieType> list3 = new List();
		int size8 = list3._size;
		int size9 = list3._size;
		int size10 = list3._size;
		int size11 = list3._size;
		dictionary2[3] = list3;
		List<ZombieType> list4 = new List();
		int size12 = list4._size;
		int size13 = list4._size;
		int size14 = list4._size;
		int size15 = list4._size;
		int size16 = list4._size;
		dictionary2[4] = list4;
		List<ZombieType> list5 = new List();
		int size17 = list5._size;
		int size18 = list5._size;
		int size19 = list5._size;
		int size20 = list5._size;
		dictionary2[5] = list5;
		List<ZombieType> list6 = new List();
		int size21 = list6._size;
		int size22 = list6._size;
		int size23 = list6._size;
		int size24 = list6._size;
		int size25 = list6._size;
		dictionary2[6] = list6;
		List<ZombieType> list7 = new List();
		int size26 = list7._size;
		int size27 = list7._size;
		int size28 = list7._size;
		int size29 = list7._size;
		int size30 = list7._size;
		dictionary2[7] = list7;
		List<ZombieType> list8 = new List();
		int size31 = list8._size;
		dictionary2[8] = list8;
		List<ZombieType> list9 = new List();
		dictionary2[9] = list9;
		List<ZombieType> list10 = new List();
		dictionary2[10] = list10;
		List<ZombieType> list11 = new List();
		dictionary2[11] = list11;
		List<ZombieType> list12 = new List();
		dictionary2[12] = list12;
		List<ZombieType> list13 = new List();
		dictionary2[13] = list13;
		List<ZombieType> list14 = new List();
		dictionary2[14] = list14;
		List<ZombieType> list15 = new List();
		dictionary2[15] = list15;
		List<ZombieType> list16 = new List();
		dictionary2[16] = list16;
		List<ZombieType> list17 = new List();
	}

	// Token: 0x04002414 RID: 9236
	[Token(Token = "0x4002414")]
	private static readonly Dictionary<int, SceneType> LandScenes;

	// Token: 0x04002415 RID: 9237
	[Token(Token = "0x4002415")]
	private static readonly Dictionary<int, List<ZombieType>> LandSpawns;

	// Token: 0x04002416 RID: 9238
	[Token(Token = "0x4002416")]
	private static readonly Dictionary<int, SceneType> WaterScenes;

	// Token: 0x04002417 RID: 9239
	[Token(Token = "0x4002417")]
	private static readonly Dictionary<int, List<ZombieType>> WaterSpawns;
}
