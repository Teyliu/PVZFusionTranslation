using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using GameLevel;
using UnityEngine.Events;

// Token: 0x020009D8 RID: 2520
[Token(Token = "0x20009D8")]
public class TravelLevelData : SurvivalLevelData
{
	// Token: 0x17000218 RID: 536
	// (get) Token: 0x06003344 RID: 13124 RVA: 0x0010CE44 File Offset: 0x0010B044
	[Token(Token = "0x17000218")]
	protected override SurvivalLevel Level
	{
		[Token(Token = "0x6003344")]
		[Address(RVA = "0x717080", Offset = "0x715680", VA = "0x180717080", Slot = "42")]
		get
		{
			return SurvivalLevel.CustomTravel;
		}
	}

	// Token: 0x17000219 RID: 537
	// (get) Token: 0x06003345 RID: 13125 RVA: 0x0010CE54 File Offset: 0x0010B054
	// (set) Token: 0x06003346 RID: 13126 RVA: 0x0010CEF8 File Offset: 0x0010B0F8
	[Token(Token = "0x17000219")]
	public override string Name
	{
		[Token(Token = "0x6003345")]
		[Address(RVA = "0x7602D0", Offset = "0x75E8D0", VA = "0x1807602D0", Slot = "8")]
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
		[Token(Token = "0x6003346")]
		[Address(RVA = "0x515980", Offset = "0x513F80", VA = "0x180515980", Slot = "9")]
		set
		{
			this.<Name>k__BackingField = value;
		}
	}

	// Token: 0x1700021A RID: 538
	// (get) Token: 0x06003347 RID: 13127 RVA: 0x0010CF0C File Offset: 0x0010B10C
	[Token(Token = "0x1700021A")]
	public override int MaxWave
	{
		[Token(Token = "0x6003347")]
		[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "10")]
		get
		{
			return 20;
		}
	}

	// Token: 0x06003348 RID: 13128 RVA: 0x0010CF1C File Offset: 0x0010B11C
	[Token(Token = "0x6003348")]
	[Address(RVA = "0x75DCD0", Offset = "0x75C2D0", VA = "0x18075DCD0", Slot = "39")]
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

	// Token: 0x06003349 RID: 13129 RVA: 0x0010CFA0 File Offset: 0x0010B1A0
	[Token(Token = "0x6003349")]
	[Address(RVA = "0x75D6E0", Offset = "0x75BCE0", VA = "0x18075D6E0", Slot = "40")]
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
				int num = 0;
				board3.GetPoint(6000f, num != 0);
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
		}
	}

	// Token: 0x1700021B RID: 539
	// (get) Token: 0x0600334A RID: 13130 RVA: 0x0010D08C File Offset: 0x0010B28C
	// (set) Token: 0x0600334B RID: 13131 RVA: 0x0010D10C File Offset: 0x0010B30C
	[Token(Token = "0x1700021B")]
	public override SceneType SceneType
	{
		[Token(Token = "0x600334A")]
		[Address(RVA = "0x760500", Offset = "0x75EB00", VA = "0x180760500", Slot = "12")]
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
		[Token(Token = "0x600334B")]
		[Address(RVA = "0x761240", Offset = "0x75F840", VA = "0x180761240", Slot = "13")]
		set
		{
			this.<SceneType>k__BackingField = value;
		}
	}

	// Token: 0x1700021C RID: 540
	// (get) Token: 0x0600334C RID: 13132 RVA: 0x0010D120 File Offset: 0x0010B320
	// (set) Token: 0x0600334D RID: 13133 RVA: 0x0010D36C File Offset: 0x0010B56C
	[Token(Token = "0x1700021C")]
	public override List<ZombieType> SpawnZombies
	{
		[Token(Token = "0x600334C")]
		[Address(RVA = "0x7606E0", Offset = "0x75ECE0", VA = "0x1807606E0", Slot = "20")]
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
		[Token(Token = "0x600334D")]
		[Address(RVA = "0x761250", Offset = "0x75F850", VA = "0x180761250", Slot = "21")]
		set
		{
			this.<SpawnZombies>k__BackingField = value;
		}
	}

	// Token: 0x0600334E RID: 13134 RVA: 0x0010D380 File Offset: 0x0010B580
	[Token(Token = "0x600334E")]
	[Address(RVA = "0x7602C0", Offset = "0x75E8C0", VA = "0x1807602C0")]
	public TravelLevelData()
	{
	}

	// Token: 0x0600334F RID: 13135 RVA: 0x0010D394 File Offset: 0x0010B594
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x600334F")]
	[Address(RVA = "0x75DDC0", Offset = "0x75C3C0", VA = "0x18075DDC0")]
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

	// Token: 0x04002525 RID: 9509
	[Token(Token = "0x4002525")]
	private static readonly Dictionary<int, SceneType> LandScenes;

	// Token: 0x04002526 RID: 9510
	[Token(Token = "0x4002526")]
	private static readonly Dictionary<int, List<ZombieType>> LandSpawns;

	// Token: 0x04002527 RID: 9511
	[Token(Token = "0x4002527")]
	private static readonly Dictionary<int, SceneType> WaterScenes;

	// Token: 0x04002528 RID: 9512
	[Token(Token = "0x4002528")]
	private static readonly Dictionary<int, List<ZombieType>> WaterSpawns;
}
