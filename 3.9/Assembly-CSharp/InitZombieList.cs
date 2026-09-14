using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using GameLevel;
using GameLevel.RogueShooting;
using UnityEngine;

// Token: 0x020009E2 RID: 2530
[Token(Token = "0x20009E2")]
public static class InitZombieList
{
	// Token: 0x06003363 RID: 13155 RVA: 0x0010DA1C File Offset: 0x0010BC1C
	[Token(Token = "0x6003363")]
	[Address(RVA = "0x73E690", Offset = "0x73CC90", VA = "0x18073E690")]
	public static void InitZombie(LevelType theLevelType, int theLevelNumber, SceneType sceneType = SceneType.Day, int theSurvivalRound = 0)
	{
		for (;;)
		{
			int num = 0;
			int num2 = 0;
			Board instance = Board.Instance;
			InitZombieList.zombieTypeList.Clear();
			InitZombieList.zombieToSpawns.Clear();
			List<List<ZombieSpawnData>> list = InitZombieList.zombieList;
			int size = list._size;
			list._size = num;
			if (size > 0)
			{
			}
			int difficulty = GameAPP.config.difficulty;
			if (difficulty == 0 || difficulty == 0 || difficulty == 0 || difficulty != 1)
			{
			}
			InitZombieList.multiplier = InitZombieList.multiplier;
			BoardConfig config = instance.config;
			int num3 = 0;
			if (config != 0)
			{
				int num4 = InitZombieList.multiplier;
				BoardConfig config2 = instance.config;
				float num5 = (float)(num3 * (int)config2.zombieCountMultiplier);
				InitZombieList.multiplier = num4;
			}
			InitZombieList.multiplier = typeof(InitZombieList).TypeHandle;
			InitZombieList.multiplier = typeof(InitZombieList).TypeHandle;
			if (LevelManager.TryGetLevelData(num) || theSurvivalRound == 0 || theLevelType != LevelType.StarAdvanture)
			{
			}
			InitZombieList.zombiePoint = num;
			int num6;
			InitZombieList.theMaxWave = num6;
			int num7 = InitZombieList.theMaxWave;
			num7++;
			if (num < num7)
			{
				List<List<ZombieSpawnData>> list2 = InitZombieList.zombieList;
				List<ZombieSpawnData> list3 = new List();
				int size2 = list2._size;
				num++;
				list3._syncRoot = list3;
				num++;
			}
			int num8 = InitZombieList.theMaxWave;
			instance.theMaxWave = num8;
			uint num9;
			InitZombieList.zombiePoint = (int)num9;
			InitZombieList.zombiePoint = typeof(InitZombieList).TypeHandle;
			int num10 = InitZombieList.zombiePoint;
			num10 -= typeof(InitZombieList).TypeHandle;
			InitZombieList.zombiePoint = num10;
			InitZombieList.zombiePoint = (int)num9;
			int num11 = InitZombieList.zombiePoint;
			num11 += num11;
			InitZombieList.zombiePoint = num11;
			ulong num12;
			num12 += num12;
			num11 += num11;
			if (num9 == (uint)num11)
			{
				HashSet<ZombieType> hashSet = InitZombieList.zombieToSpawns;
				bool flag;
				if (flag)
				{
				}
				HashSet<ZombieType> hashSet2 = InitZombieList.zombieToSpawns;
				bool flag2;
				if (flag2)
				{
				}
				HashSet<ZombieType> hashSet3 = InitZombieList.zombieToSpawns;
				bool flag3;
				if (flag3)
				{
				}
				int num13 = InitZombieList.zombiePoint;
				num13 += num13;
				InitZombieList.zombiePoint = num13;
				InitZombieList.UltimateBoss((int)num9);
			}
			ZombieType zombieType;
			int num14 = (int)zombieType;
			if (num14 <= 70 || num14 != 215)
			{
				goto IL_01DD;
			}
			ulong num15;
			num15 += num15;
			if ((ulong)num9 < num15)
			{
				goto IL_01DD;
			}
			IL_01E4:
			num9 = (uint)((ulong)num9 - num15);
			uint num16;
			ZombieType zombieType2 = ShootingManager.GetZombieType((int)num9, (int)num16);
			int zombieType3 = (int)FruitNinjaManager.GetZombieType((int)num9);
			ulong num17;
			if (num17 != (ulong)0L)
			{
				if (instance.boardGame != BoardGame.WheatProtection)
				{
					if (num9 >= (uint)10 || GameAPP.config.difficulty == 5)
					{
						goto IL_0236;
					}
					bool flag4;
					while (flag4)
					{
					}
				}
				bool flag5;
				while (flag5)
				{
				}
				bool flag6;
				while (flag6)
				{
				}
			}
			IL_0236:
			HashSet<ZombieType> hashSet4 = InitZombieList.zombieToSpawns;
			bool flag7;
			if (flag7)
			{
				if (TypeMgr.IsLeaderZombie((ZombieType)num2))
				{
					continue;
				}
				int num18 = InitZombieList.AddZombieToList((ZombieType)num2, (int)num9);
			}
			ulong num19;
			if (num19 != (ulong)0L)
			{
				goto IL_02BC;
			}
			num9 += (uint)1;
			bool flag8 = LevelManager.TryGetLevelData(num);
			if (!flag8 || !flag8)
			{
				break;
			}
			bool flag9;
			if (flag9)
			{
				List<List<ZombieSpawnData>> list4 = InitZombieList.zombieList;
				List<List<ZombieSpawnData>> list5 = InitZombieList.zombieList;
				List<ZombieSpawnData> list7;
				List<ZombieSpawnData> list6 = new List(list7);
				bool flag10;
				if (flag10)
				{
					HashSet<ZombieType> hashSet5 = InitZombieList.zombieTypeList;
				}
				ulong num20;
				if (num20 != (ulong)0L)
				{
					goto IL_02C8;
				}
			}
			ulong num21;
			if (num21 == (ulong)0L)
			{
				break;
			}
			continue;
			IL_01DD:
			uint num22;
			if (num22 == (uint)63)
			{
				goto IL_01E4;
			}
			goto IL_01E4;
		}
		return;
		IL_02BC:
		throw new NullReferenceException();
		IL_02C8:
		throw new NullReferenceException();
	}

	// Token: 0x06003364 RID: 13156 RVA: 0x0010DD10 File Offset: 0x0010BF10
	[Token(Token = "0x6003364")]
	[Address(RVA = "0x7467B0", Offset = "0x744DB0", VA = "0x1807467B0")]
	private static void UltimateBoss(int currentWave)
	{
		if (currentWave >= 30 || Board.Instance.boardTag == (ulong)0L)
		{
		}
		InitZombieList.TryAddBoss((ZombieType)((uint)234), currentWave, 60);
		InitZombieList.TryAddBoss((ZombieType)((uint)229), currentWave, 60);
		InitZombieList.TryAddBoss((ZombieType)((uint)243), currentWave, 60);
		InitZombieList.TryAddBoss((ZombieType)((uint)228), currentWave, 70);
		InitZombieList.TryAddBoss((ZombieType)((uint)224), currentWave, 100);
		InitZombieList.TryAddBoss((ZombieType)((uint)223), currentWave, 90);
		InitZombieList.TryAddBoss((ZombieType)((uint)212), currentWave, 80);
		InitZombieList.TryAddBoss((ZombieType)((uint)221), currentWave, 70);
		InitZombieList.TryAddBoss((ZombieType)((uint)222), currentWave, 60);
		InitZombieList.TryAddBoss((ZombieType)((uint)218), currentWave, 50);
		InitZombieList.TryAddBoss((ZombieType)((uint)244), currentWave, 90);
		InitZombieList.TryAddBoss((ZombieType)((uint)220), currentWave, 40);
		InitZombieList.TryAddBoss((ZombieType)((uint)219), currentWave, 30);
		InitZombieList.TryAddBoss((ZombieType)((uint)249), currentWave, 50);
		InitZombieList.TryAddBoss((ZombieType)((uint)259), currentWave, 80);
	}

	// Token: 0x06003365 RID: 13157 RVA: 0x0010DE0C File Offset: 0x0010C00C
	[Token(Token = "0x6003365")]
	[Address(RVA = "0x7466B0", Offset = "0x744CB0", VA = "0x1807466B0")]
	private static void TryAddBoss(ZombieType zombieType, int currentWave, int minWave)
	{
		HashSet<ZombieType> hashSet = InitZombieList.zombieToSpawns;
		bool flag;
		if (flag)
		{
			Board instance = Board.Instance;
		}
	}

	// Token: 0x06003366 RID: 13158 RVA: 0x0010DE34 File Offset: 0x0010C034
	[Token(Token = "0x6003366")]
	[Address(RVA = "0x7436C0", Offset = "0x741CC0", VA = "0x1807436C0")]
	private static bool ShootingLimit(ZombieType theZombieType, int wave)
	{
		bool flag;
		bool flag2;
		bool flag3;
		return (wave < 30 && flag) || flag2 || flag3;
	}

	// Token: 0x06003367 RID: 13159 RVA: 0x0010DE60 File Offset: 0x0010C060
	[Token(Token = "0x6003367")]
	[Address(RVA = "0x746980", Offset = "0x744F80", VA = "0x180746980")]
	private static bool WheatProtectionLimit(ZombieType theZombieType, int wave)
	{
		bool flag;
		bool flag2;
		bool flag3;
		return (wave < 40 && (theZombieType == ZombieType.QuickJacksonZombie || flag)) || flag2 || flag3;
	}

	// Token: 0x06003368 RID: 13160 RVA: 0x0010DE98 File Offset: 0x0010C098
	[Token(Token = "0x6003368")]
	[Address(RVA = "0x731010", Offset = "0x72F610", VA = "0x180731010")]
	private static int AddZombieToList(ZombieType zombieType, int wave)
	{
		Dictionary<ZombieType, ZombieDataManager.ZombieData> zombieDataDic = ZombieDataManager.zombieDataDic;
		ZombieDataManager.ZombieData zombieData;
		int summonLevel = zombieData.summonLevel;
		Board instance = Board.Instance;
		LevelType theBoardType = GameAPP.theBoardType;
		if (theBoardType == LevelType.Advanture || theBoardType == LevelType.Explore)
		{
		}
		int size = InitZombieList.zombieList[wave]._size;
		Board instance2 = Board.Instance;
		bool flag;
		if (!flag)
		{
			Board instance3 = Board.Instance;
		}
		bool flag2;
		if (flag2)
		{
		}
		HashSet<ZombieType> hashSet = InitZombieList.zombieTypeList;
		int size2 = InitZombieList.zombieList[wave]._size;
		return summonLevel;
	}

	// Token: 0x06003369 RID: 13161 RVA: 0x0010DF18 File Offset: 0x0010C118
	[Token(Token = "0x6003369")]
	[Address(RVA = "0x73DA30", Offset = "0x73C030", VA = "0x18073DA30")]
	public static int GetPoint(ZombieType zombieType)
	{
		Dictionary<ZombieType, ZombieDataManager.ZombieData> zombieDataDic = ZombieDataManager.zombieDataDic;
		ZombieDataManager.ZombieData zombieData;
		return zombieData.summonLevel;
	}

	// Token: 0x0600336A RID: 13162 RVA: 0x0010DF3C File Offset: 0x0010C13C
	[Token(Token = "0x600336A")]
	[Address(RVA = "0x744340", Offset = "0x742940", VA = "0x180744340")]
	private static void SurvivalZombieTypeSpawn(int theLevelNumber, int theRound, SceneType sceneType)
	{
		if (Board.Instance <= (ulong)1L)
		{
			List<ZombieType> list;
			InitZombieList.AllowZombies(list);
			return;
		}
		List<ZombieType> list2;
		if (theLevelNumber == 33)
		{
			if (theRound != 1)
			{
				List<ZombieType> sandZombieTypes = EndlessData.GetSandZombieTypes(theRound);
			}
			list2 = new List();
		}
		if (theLevelNumber == 15)
		{
			HashSet<ZombieType> hashSet = InitZombieList.zombieToSpawns;
			HashSet<ZombieType> hashSet2 = InitZombieList.zombieToSpawns;
			if (typeof(InitZombieList).TypeHandle <= (ulong)3L)
			{
				HashSet<ZombieType> hashSet3 = InitZombieList.zombieToSpawns;
				HashSet<ZombieType> hashSet4 = InitZombieList.zombieToSpawns;
				HashSet<ZombieType> hashSet5 = InitZombieList.zombieToSpawns;
			}
			return;
		}
		if (list2 == (ulong)1L)
		{
			HashSet<ZombieType> hashSet6 = InitZombieList.zombieToSpawns;
			int num = 0;
			bool flag = hashSet6.Add(num);
			HashSet<ZombieType> hashSet7 = InitZombieList.zombieToSpawns;
			HashSet<ZombieType> hashSet8 = InitZombieList.zombieToSpawns;
			return;
		}
		bool flag2;
		if (flag2)
		{
			if (flag2)
			{
				while (!flag2)
				{
				}
				HashSet<ZombieType> hashSet9 = InitZombieList.zombieToSpawns;
				int num2 = 0;
				bool flag3 = hashSet9.Add(num2);
				HashSet<ZombieType> hashSet10 = InitZombieList.zombieToSpawns;
				HashSet<ZombieType> hashSet11 = InitZombieList.zombieToSpawns;
				HashSet<ZombieType> hashSet12 = InitZombieList.zombieToSpawns;
				HashSet<ZombieType> hashSet13 = InitZombieList.zombieToSpawns;
			}
			HashSet<ZombieType> hashSet14 = InitZombieList.zombieToSpawns;
			int num3 = 0;
			bool flag4 = hashSet14.Add(num3);
			HashSet<ZombieType> hashSet15 = InitZombieList.zombieToSpawns;
			HashSet<ZombieType> hashSet16 = InitZombieList.zombieToSpawns;
			HashSet<ZombieType> hashSet17 = InitZombieList.zombieToSpawns;
			HashSet<ZombieType> hashSet18 = InitZombieList.zombieToSpawns;
		}
		HashSet<ZombieType> hashSet19 = InitZombieList.zombieToSpawns;
		int num4 = 0;
		bool flag5 = hashSet19.Add(num4);
		HashSet<ZombieType> hashSet20 = InitZombieList.zombieToSpawns;
		HashSet<ZombieType> hashSet21 = InitZombieList.zombieToSpawns;
		HashSet<ZombieType> hashSet22 = InitZombieList.zombieToSpawns;
		HashSet<ZombieType> hashSet23 = InitZombieList.zombieToSpawns;
		HashSet<ZombieType> hashSet24 = InitZombieList.zombieToSpawns;
		if (theLevelNumber - 1 <= 28)
		{
			int num5 = theLevelNumber - 1;
			InitZombieList.PoolNormal();
			return;
		}
		InitZombieList.LandHard();
	}

	// Token: 0x0600336B RID: 13163 RVA: 0x0010E114 File Offset: 0x0010C314
	[Token(Token = "0x600336B")]
	[Address(RVA = "0x741030", Offset = "0x73F630", VA = "0x180741030")]
	private static void SetTravelZombie(int theLevel, int theRound, SceneType sceneType)
	{
		do
		{
			int num = 0;
			if (theLevel == 12)
			{
				if (theRound < 15)
				{
					if (theRound == 1)
					{
						InitZombieList.TravelLandGroup(0);
					}
					if (theRound == 2)
					{
						uint num2;
						InitZombieList.TravelLandGroup((int)num2);
					}
					bool flag2;
					if (num > 1)
					{
						List<int> list;
						if (sceneType == SceneType.Travel_roof)
						{
							list = new List();
							InitZombieList.TravelLandGroup(theLevel);
							bool flag = list.Remove(theLevel);
							InitZombieList.TravelLandGroup(list[flag ? 1 : 0]);
							HashSet<ZombieType> hashSet = InitZombieList.zombieToSpawns;
							HashSet<ZombieType> hashSet2 = InitZombieList.zombieToSpawns;
						}
						if (list != (ulong)21L)
						{
							InitZombieList.TravelLandGroup(flag2 ? 1 : 0);
						}
					}
					InitZombieList.TravelLandGroup(flag2 ? 1 : 0);
					if (!flag2)
					{
						HashSet<ZombieType> hashSet3 = InitZombieList.zombieToSpawns;
						HashSet<ZombieType> hashSet4 = InitZombieList.zombieToSpawns;
					}
					if (!flag2)
					{
						continue;
					}
					HashSet<ZombieType> hashSet5 = InitZombieList.zombieToSpawns;
					HashSet<ZombieType> hashSet6 = InitZombieList.zombieToSpawns;
					HashSet<ZombieType> hashSet7 = InitZombieList.zombieToSpawns;
					HashSet<ZombieType> hashSet8 = InitZombieList.zombieToSpawns;
					HashSet<ZombieType> hashSet9 = InitZombieList.zombieToSpawns;
					HashSet<ZombieType> hashSet10 = InitZombieList.zombieToSpawns;
				}
				uint num3;
				InitZombieList.TravelLandGroup((int)num3);
			}
			if (num <= 6)
			{
				if (theRound - 1 > 6)
				{
					continue;
				}
				int num4 = theRound - 1;
				List<ZombieType> list2 = new List();
				List<ZombieType> list3 = new List();
				List<ZombieType> list4 = new List();
				List<ZombieType> list5 = new List();
				List<ZombieType> list6 = new List();
				List<ZombieType> list7 = new List();
				InitZombieList.AllowZombies(InitZombieList.allowAllzombies);
				HashSet<ZombieType> hashSet11 = InitZombieList.zombieToSpawns;
				HashSet<ZombieType> hashSet12 = InitZombieList.zombieToSpawns;
				HashSet<ZombieType> hashSet13 = InitZombieList.zombieToSpawns;
				if (theRound != 1)
				{
					if (theRound != 2)
					{
						if (theRound == hashSet13)
						{
						}
						InitZombieList.TravelWater();
					}
					if (list7 == (ulong)20L)
					{
						InitZombieList.LandNormal();
						InitZombieList.SnowHard();
					}
					InitZombieList.TravelLand();
					InitZombieList.PoolHard();
				}
				List<ZombieType> list8 = new List();
				InitZombieList.AllowZombies(RogueManager.Instance.GetZombieTypes(theRound));
			}
			TravelData data = TravelMgr.Instance.data;
		}
		while (theRound - 1 > 20);
		int num5 = theRound - 1;
		List<ZombieType> list9 = new List();
		List<ZombieType> list10 = new List();
		if (list9 != (ulong)234L)
		{
		}
		List<ZombieType> list11 = new List();
		if (list10 != (ulong)234L)
		{
		}
		List<ZombieType> list12 = new List();
		if (list11 != (ulong)234L)
		{
		}
		List<ZombieType> list13 = new List();
		if (list12 != (ulong)234L)
		{
		}
		List<ZombieType> list14 = new List();
		if (list13 != (ulong)234L)
		{
		}
	}

	// Token: 0x0600336C RID: 13164 RVA: 0x0010E328 File Offset: 0x0010C528
	[Token(Token = "0x600336C")]
	[Address(RVA = "0x744CA0", Offset = "0x7432A0", VA = "0x180744CA0")]
	public static void TravelLandGroup(int group)
	{
		if (group <= 11)
		{
			InitZombieList.AllowZombies(new List());
			return;
		}
	}

	// Token: 0x0600336D RID: 13165 RVA: 0x0010E568 File Offset: 0x0010C768
	[Token(Token = "0x600336D")]
	[Address(RVA = "0x7461A0", Offset = "0x7447A0", VA = "0x1807461A0")]
	public static void TravelWaterGroup(int group)
	{
		if (group == 0)
		{
			bool flag = InitZombieList.zombieToSpawns.Add((uint)14);
			bool flag2 = InitZombieList.zombieToSpawns.Add((uint)200);
			return;
		}
		while (group != 1)
		{
		}
		bool flag3 = InitZombieList.zombieToSpawns.Add((uint)17);
		bool flag4 = InitZombieList.zombieToSpawns.Add((uint)27);
		bool flag5 = InitZombieList.zombieToSpawns.Add((uint)113);
		bool flag6 = InitZombieList.zombieToSpawns.Add((uint)19);
		bool flag7 = InitZombieList.zombieToSpawns.Add((uint)113);
		bool flag8 = InitZombieList.zombieToSpawns.Add((uint)214);
	}

	// Token: 0x0600336E RID: 13166 RVA: 0x0010E600 File Offset: 0x0010C800
	[Token(Token = "0x600336E")]
	[Address(RVA = "0x731390", Offset = "0x72F990", VA = "0x180731390")]
	private static void AdvantureZombieTypeSpawn(int theLevelNumber)
	{
		while (theLevelNumber - 1 > 44)
		{
		}
		int num = theLevelNumber - 1;
		InitZombieList.AllowZombies(new List());
	}

	// Token: 0x0600336F RID: 13167 RVA: 0x0010E9FC File Offset: 0x0010CBFC
	[Token(Token = "0x600336F")]
	[Address(RVA = "0x740E50", Offset = "0x73F450", VA = "0x180740E50")]
	private static void SetAllowZombieTypeSpawn(LevelType theLevelType, int theLevelNumber)
	{
		if (theLevelType <= LevelType.StarAdvanture)
		{
			InitZombieList.AdvantureZombieTypeSpawn(theLevelNumber);
			return;
		}
	}

	// Token: 0x06003370 RID: 13168 RVA: 0x0010EA2C File Offset: 0x0010CC2C
	[Token(Token = "0x6003370")]
	[Address(RVA = "0x73FDD0", Offset = "0x73E3D0", VA = "0x18073FDD0")]
	private static void NewAdvSpawner(int theLevelNumber)
	{
		if (theLevelNumber - 1 <= 8)
		{
			int num = theLevelNumber - 1;
			InitZombieList.AllowZombies(new List());
			return;
		}
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		throw new NullReferenceException();
	}

	// Token: 0x06003371 RID: 13169 RVA: 0x0010EAA8 File Offset: 0x0010CCA8
	[Token(Token = "0x6003371")]
	[Address(RVA = "0x743780", Offset = "0x741D80", VA = "0x180743780")]
	public static void SkinLevelSpawner(int theLevelNumber)
	{
		int num = theLevelNumber - 1;
		if (num != 0)
		{
			if (num != 0)
			{
				if (num != 1)
				{
					return;
				}
				List<ZombieType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				int size4 = list._size;
				int size5 = list._size;
				int size6 = list._size;
				int size7 = list._size;
			}
			List<ZombieType> list2 = new List();
			int size8 = list2._size;
			int size9 = list2._size;
			int size10 = list2._size;
			int size11 = list2._size;
			int size12 = list2._size;
			int size13 = list2._size;
			int size14 = list2._size;
		}
		List<ZombieType> list3 = new List();
		int size15 = list3._size;
		int size16 = list3._size;
		int size17 = list3._size;
		int size18 = list3._size;
		int size19 = list3._size;
		int size20 = list3._size;
		int size21 = list3._size;
		InitZombieList.AllowZombies(list3);
	}

	// Token: 0x06003372 RID: 13170 RVA: 0x0010EBA4 File Offset: 0x0010CDA4
	[Token(Token = "0x6003372")]
	[Address(RVA = "0x734D80", Offset = "0x733380", VA = "0x180734D80")]
	private static void AllowZombies(List<ZombieType> zombieTypes)
	{
		ulong num2;
		do
		{
			int num = 0;
			if (zombieTypes == 0)
			{
				break;
			}
			bool flag;
			if (flag)
			{
				bool flag2 = InitZombieList.zombieToSpawns.Add(num);
			}
		}
		while (num2 != (ulong)0L);
		HashSet<ZombieType> hashSet = InitZombieList.zombieToSpawns;
		int num3 = 0;
		bool flag3 = hashSet.Add(num3);
	}

	// Token: 0x06003373 RID: 13171 RVA: 0x0010EBF4 File Offset: 0x0010CDF4
	[Token(Token = "0x6003373")]
	[Address(RVA = "0x734F30", Offset = "0x733530", VA = "0x180734F30")]
	private static void ChallengeSpawner(int theLevelNumber)
	{
		while (theLevelNumber - 1 > 173)
		{
		}
		int num = theLevelNumber - 1;
		InitZombieList.LandHard();
	}

	// Token: 0x06003374 RID: 13172 RVA: 0x0010EF34 File Offset: 0x0010D134
	[Token(Token = "0x6003374")]
	[Address(RVA = "0x73DCA0", Offset = "0x73C2A0", VA = "0x18073DCA0")]
	private static List<ZombieType> GetRandomZombiesFromLandNormal()
	{
		List<ZombieType> list = new List();
		List<ZombieType> list2 = new List(InitZombieList.zombieInLandNormal);
		int num = 0;
		int num2 = list2._size;
		int num3 = global::UnityEngine.Random.Range(0, num2);
		num2 = num3;
		int num4 = list2[num2];
		int size = list._size;
		num4 = num3;
		list2.RemoveAt(num4);
		num++;
		return list;
	}

	// Token: 0x06003375 RID: 13173 RVA: 0x0010EF9C File Offset: 0x0010D19C
	[Token(Token = "0x6003375")]
	[Address(RVA = "0x73DAB0", Offset = "0x73C0B0", VA = "0x18073DAB0")]
	public static List<ZombieType> GetRandomZombiesFromLandHard()
	{
		List<ZombieType> list = new List();
		List<ZombieType> list2 = new List(InitZombieList.zombieInLandHard);
		if (global::UnityEngine.Random.Range(7, 11) > 0)
		{
			int num = 0;
			int num2 = list2._size;
			int num3 = global::UnityEngine.Random.Range(0, num2);
			num2 = num3;
			int num4 = list2[num2];
			int size = list._size;
			num4 = num3;
			list2.RemoveAt(num4);
			num++;
		}
		return list;
	}

	// Token: 0x06003376 RID: 13174 RVA: 0x0010F010 File Offset: 0x0010D210
	[Token(Token = "0x6003376")]
	[Address(RVA = "0x73E050", Offset = "0x73C650", VA = "0x18073E050")]
	private static List<ZombieType> GetRandomZombiesFromPoolNormal()
	{
		List<ZombieType> list = new List();
		List<ZombieType> list2 = new List(InitZombieList.zombieInPoolNormal);
		int num = 0;
		int num2 = list2._size;
		int num3 = global::UnityEngine.Random.Range(0, num2);
		num2 = num3;
		int num4 = list2[num2];
		int size = list._size;
		num4 = num3;
		list2.RemoveAt(num4);
		num++;
		return list;
	}

	// Token: 0x06003377 RID: 13175 RVA: 0x0010F078 File Offset: 0x0010D278
	[Token(Token = "0x6003377")]
	[Address(RVA = "0x73DE60", Offset = "0x73C460", VA = "0x18073DE60")]
	private static List<ZombieType> GetRandomZombiesFromPoolHard()
	{
		List<ZombieType> list = new List();
		List<ZombieType> list2 = new List(InitZombieList.zombieInPoolHard);
		if (global::UnityEngine.Random.Range(7, 11) > 0)
		{
			int num = 0;
			int num2 = list2._size;
			int num3 = global::UnityEngine.Random.Range(0, num2);
			num2 = num3;
			int num4 = list2[num2];
			int size = list._size;
			num4 = num3;
			list2.RemoveAt(num4);
			num++;
		}
		return list;
	}

	// Token: 0x06003378 RID: 13176 RVA: 0x0010F0EC File Offset: 0x0010D2EC
	[Token(Token = "0x6003378")]
	[Address(RVA = "0x73E3F0", Offset = "0x73C9F0", VA = "0x18073E3F0")]
	private static List<ZombieType> GetTravelZombieWater()
	{
		List<ZombieType> list = new List();
		List<ZombieType> list2 = new List(InitZombieList.zombieInTravel_water);
		int num = 0;
		int num2 = list2._size;
		int num3 = global::UnityEngine.Random.Range(0, num2);
		num2 = num3;
		int num4 = list2[num2];
		int size = list._size;
		num4 = num3;
		list2.RemoveAt(num4);
		num++;
		return list;
	}

	// Token: 0x06003379 RID: 13177 RVA: 0x0010F154 File Offset: 0x0010D354
	[Token(Token = "0x6003379")]
	[Address(RVA = "0x73E210", Offset = "0x73C810", VA = "0x18073E210")]
	public static List<ZombieType> GetTravelZombieLand()
	{
		List<ZombieType> list = new List();
		List<ZombieType> list2 = new List(InitZombieList.zombieInTravel_land);
		if (global::UnityEngine.Random.Range(5, 9) > 0)
		{
			int num = 0;
			int num2 = list2._size;
			int num3 = global::UnityEngine.Random.Range(0, num2);
			num2 = num3;
			int num4 = list2[num2];
			int size = list._size;
			num4 = num3;
			list2.RemoveAt(num4);
			num++;
		}
		return list;
	}

	// Token: 0x0600337A RID: 13178 RVA: 0x0010F1C8 File Offset: 0x0010D3C8
	[Token(Token = "0x600337A")]
	[Address(RVA = "0x740470", Offset = "0x73EA70", VA = "0x180740470")]
	private static ZombieType PickZombie(SpawnZombieConfig config, int wave)
	{
		Dictionary<ZombieType, int> dictionary;
		for (;;)
		{
			int num = 0;
			int num2 = 0;
			dictionary = new Dictionary();
			List<ZombieType> allZombieTypes = GameAPP.resourcesManager.allZombieTypes;
			bool flag;
			if (flag)
			{
				if (!InitZombieList.zombieToSpawns.Contains(num))
				{
					continue;
				}
				if (config == 0 || config.minWaveSpawnConfig.TryGetValue(num, num2))
				{
				}
				int summonWeight = ZombieDataManager.zombieDataDic[num].summonWeight;
				dictionary.Add(num, summonWeight);
				num2 += summonWeight;
			}
			if (num2 == 0)
			{
				if (dictionary.Count == 0)
				{
					goto IL_0091;
				}
				int num3 = global::UnityEngine.Random.Range(0, num2);
				bool flag2;
				if (flag2)
				{
				}
				ulong num4;
				if (num4 == (ulong)0L)
				{
					break;
				}
			}
		}
		ZombieType zombieType = Enumerable.First<ZombieType>(dictionary.Keys);
		IL_0091:
		throw new NullReferenceException();
	}

	// Token: 0x0600337B RID: 13179 RVA: 0x0010F294 File Offset: 0x0010D494
	[Token(Token = "0x600337B")]
	[Address(RVA = "0x73E5B0", Offset = "0x73CBB0", VA = "0x18073E5B0")]
	private static void InitList()
	{
		InitZombieList.zombieTypeList.Clear();
		InitZombieList.zombieToSpawns.Clear();
		List<List<ZombieSpawnData>> list = InitZombieList.zombieList;
		int size = list._size;
		list._size = (int)((ulong)0L);
		if (size > 0)
		{
			return;
		}
	}

	// Token: 0x0600337C RID: 13180 RVA: 0x0010F2DC File Offset: 0x0010D4DC
	[Token(Token = "0x600337C")]
	[Address(RVA = "0x73FAA0", Offset = "0x73E0A0", VA = "0x18073FAA0")]
	private static void LandNormal()
	{
		ulong num6;
		do
		{
			int num = 0;
			List<ZombieType> list = new List();
			List<ZombieType> list2 = new List(InitZombieList.zombieInLandNormal);
			int num2 = 0;
			int num3 = list2._size;
			int num4 = global::UnityEngine.Random.Range(0, num3);
			num3 = num4;
			int num5 = list2[num3];
			int size = list._size;
			num5 = num4;
			list2.RemoveAt(num5);
			num2++;
			bool flag;
			if (flag)
			{
				bool flag2 = InitZombieList.zombieToSpawns.Add(num);
			}
		}
		while (num6 != (ulong)0L);
	}

	// Token: 0x0600337D RID: 13181 RVA: 0x0010F364 File Offset: 0x0010D564
	[Token(Token = "0x600337D")]
	[Address(RVA = "0x73F920", Offset = "0x73DF20", VA = "0x18073F920")]
	public static void LandHard()
	{
		ulong num2;
		do
		{
			int num = 0;
			List<ZombieType> randomZombiesFromLandHard = InitZombieList.GetRandomZombiesFromLandHard();
			bool flag;
			if (flag)
			{
				bool flag2 = InitZombieList.zombieToSpawns.Add(num);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x0600337E RID: 13182 RVA: 0x0010F3A0 File Offset: 0x0010D5A0
	[Token(Token = "0x600337E")]
	[Address(RVA = "0x743FA0", Offset = "0x7425A0", VA = "0x180743FA0")]
	private static void SnowHard()
	{
		uint num3;
		do
		{
			int num = 0;
			List<ZombieType> list = new List();
			int size = list._size;
			int size2 = list._size;
			int size3 = list._size;
			int size4 = list._size;
			int size5 = list._size;
			int num2 = list._size;
			num2 = global::UnityEngine.Random.Range(0, num2);
			list.RemoveAt(num2);
			bool flag;
			if (flag)
			{
				bool flag2 = InitZombieList.zombieToSpawns.Add(num);
			}
		}
		while (num3 != (uint)0);
	}

	// Token: 0x0600337F RID: 13183 RVA: 0x0010F418 File Offset: 0x0010D618
	[Token(Token = "0x600337F")]
	[Address(RVA = "0x740AA0", Offset = "0x73F0A0", VA = "0x180740AA0")]
	private static void PoolNormal()
	{
		ulong num6;
		do
		{
			int num = 0;
			List<ZombieType> list = new List();
			List<ZombieType> list2 = new List(InitZombieList.zombieInPoolNormal);
			int num2 = 0;
			int num3 = list2._size;
			int num4 = global::UnityEngine.Random.Range(0, num3);
			num3 = num4;
			int num5 = list2[num3];
			int size = list._size;
			num5 = num4;
			list2.RemoveAt(num5);
			num2++;
			bool flag;
			if (flag)
			{
				bool flag2 = InitZombieList.zombieToSpawns.Add(num);
			}
		}
		while (num6 != (ulong)0L);
	}

	// Token: 0x06003380 RID: 13184 RVA: 0x0010F4A0 File Offset: 0x0010D6A0
	[Token(Token = "0x6003380")]
	[Address(RVA = "0x740920", Offset = "0x73EF20", VA = "0x180740920")]
	private static void PoolHard()
	{
		ulong num2;
		do
		{
			int num = 0;
			List<ZombieType> randomZombiesFromPoolHard = InitZombieList.GetRandomZombiesFromPoolHard();
			bool flag;
			if (flag)
			{
				bool flag2 = InitZombieList.zombieToSpawns.Add(num);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06003381 RID: 13185 RVA: 0x0010F4DC File Offset: 0x0010D6DC
	[Token(Token = "0x6003381")]
	[Address(RVA = "0x740DD0", Offset = "0x73F3D0", VA = "0x180740DD0")]
	public static void RoofHard()
	{
		bool flag = InitZombieList.zombieToSpawns.Remove((uint)28);
	}

	// Token: 0x06003382 RID: 13186 RVA: 0x0010F500 File Offset: 0x0010D700
	[Token(Token = "0x6003382")]
	[Address(RVA = "0x746380", Offset = "0x744980", VA = "0x180746380")]
	private static void TravelWater()
	{
		ulong num6;
		do
		{
			int num = 0;
			List<ZombieType> list = new List();
			List<ZombieType> list2 = new List(InitZombieList.zombieInTravel_water);
			int num2 = 0;
			int num3 = list2._size;
			int num4 = global::UnityEngine.Random.Range(0, num3);
			num3 = num4;
			int num5 = list2[num3];
			int size = list._size;
			num5 = num4;
			list2.RemoveAt(num5);
			num2++;
			bool flag;
			if (flag)
			{
				bool flag2 = InitZombieList.zombieToSpawns.Add(num);
			}
		}
		while (num6 != (ulong)0L);
	}

	// Token: 0x06003383 RID: 13187 RVA: 0x0010F588 File Offset: 0x0010D788
	[Token(Token = "0x6003383")]
	[Address(RVA = "0x745D50", Offset = "0x744350", VA = "0x180745D50")]
	private static void TravelUltimate(int count)
	{
		List<ZombieType> list;
		int num;
		do
		{
			list = new List();
			Dictionary<ZombieType, GameObject> zombiePrefabs = GameAPP.resourcesManager.zombiePrefabs;
			num = 0;
			bool flag;
			if (flag)
			{
				bool flag2;
				while (!flag2)
				{
				}
			}
		}
		while (num != 0);
		int num2 = 0;
		int num3 = list._size;
		int num4 = global::UnityEngine.Random.Range(0, num3);
		HashSet<ZombieType> hashSet = InitZombieList.zombieToSpawns;
		num3 = num4;
		int num5 = list[num3];
		num5 = num4;
		list.RemoveAt(num5);
		num2++;
		if (InitZombieList.zombieToSpawns.Contains((uint)212) && InitZombieList.zombieToSpawns.Contains((uint)219))
		{
			if (global::UnityEngine.Random.Range(0, 2) == 0)
			{
				HashSet<ZombieType> hashSet2 = InitZombieList.zombieToSpawns;
				throw new NullReferenceException();
			}
			bool flag3 = InitZombieList.zombieToSpawns.Remove((uint)219);
		}
	}

	// Token: 0x06003384 RID: 13188 RVA: 0x0010F650 File Offset: 0x0010D850
	[Token(Token = "0x6003384")]
	[Address(RVA = "0x745BD0", Offset = "0x7441D0", VA = "0x180745BD0")]
	public static void TravelLand()
	{
		ulong num2;
		do
		{
			int num = 0;
			List<ZombieType> travelZombieLand = InitZombieList.GetTravelZombieLand();
			bool flag;
			if (flag)
			{
				bool flag2 = InitZombieList.zombieToSpawns.Add(num);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06003385 RID: 13189 RVA: 0x0010F68C File Offset: 0x0010D88C
	[Token(Token = "0x6003385")]
	[Address(RVA = "0x734530", Offset = "0x732B30", VA = "0x180734530")]
	private static void AllowNormal()
	{
		HashSet<ZombieType> hashSet = InitZombieList.zombieToSpawns;
		int num = 0;
		bool flag = hashSet.Add(num);
		bool flag2 = InitZombieList.zombieToSpawns.Add((uint)2);
		bool flag3 = InitZombieList.zombieToSpawns.Add((uint)4);
	}

	// Token: 0x06003386 RID: 13190 RVA: 0x0010F6CC File Offset: 0x0010D8CC
	[Token(Token = "0x6003386")]
	[Address(RVA = "0x733D60", Offset = "0x732360", VA = "0x180733D60")]
	private static void AllowDay()
	{
		HashSet<ZombieType> hashSet = InitZombieList.zombieToSpawns;
		int num = 0;
		bool flag = hashSet.Add(num);
		bool flag2 = InitZombieList.zombieToSpawns.Add((uint)2);
		bool flag3 = InitZombieList.zombieToSpawns.Add((uint)3);
		bool flag4 = InitZombieList.zombieToSpawns.Add((uint)5);
		bool flag5 = InitZombieList.zombieToSpawns.Add((uint)4);
		bool flag6 = InitZombieList.zombieToSpawns.Add((uint)104);
		bool flag7 = InitZombieList.zombieToSpawns.Add((uint)106);
		bool flag8 = InitZombieList.zombieToSpawns.Add((uint)108);
		bool flag9 = InitZombieList.zombieToSpawns.Add((uint)100);
		bool flag10 = InitZombieList.zombieToSpawns.Add((uint)101);
		bool flag11 = InitZombieList.zombieToSpawns.Add((uint)107);
		bool flag12 = InitZombieList.zombieToSpawns.Add((uint)103);
	}

	// Token: 0x06003387 RID: 13191 RVA: 0x0010F790 File Offset: 0x0010D990
	[Token(Token = "0x6003387")]
	[Address(RVA = "0x733BC0", Offset = "0x7321C0", VA = "0x180733BC0")]
	private static void AllowDayNormal()
	{
		HashSet<ZombieType> hashSet = InitZombieList.zombieToSpawns;
		int num = 0;
		bool flag = hashSet.Add(num);
		bool flag2 = InitZombieList.zombieToSpawns.Add((uint)2);
		bool flag3 = InitZombieList.zombieToSpawns.Add((uint)3);
		bool flag4 = InitZombieList.zombieToSpawns.Add((uint)4);
		bool flag5 = InitZombieList.zombieToSpawns.Add((uint)5);
		bool flag6 = InitZombieList.zombieToSpawns.Add((uint)100);
		bool flag7 = InitZombieList.zombieToSpawns.Add((uint)101);
		bool flag8 = InitZombieList.zombieToSpawns.Add((uint)103);
	}

	// Token: 0x06003388 RID: 13192 RVA: 0x0010F818 File Offset: 0x0010DA18
	[Token(Token = "0x6003388")]
	[Address(RVA = "0x734130", Offset = "0x732730", VA = "0x180734130")]
	private static void AllowNightNormal()
	{
		HashSet<ZombieType> hashSet = InitZombieList.zombieToSpawns;
		int num = 0;
		bool flag = hashSet.Add(num);
		bool flag2 = InitZombieList.zombieToSpawns.Add((uint)2);
		bool flag3 = InitZombieList.zombieToSpawns.Add((uint)3);
		bool flag4 = InitZombieList.zombieToSpawns.Add((uint)4);
		bool flag5 = InitZombieList.zombieToSpawns.Add((uint)8);
		bool flag6 = InitZombieList.zombieToSpawns.Add((uint)9);
		bool flag7 = InitZombieList.zombieToSpawns.Add((uint)111);
	}

	// Token: 0x06003389 RID: 13193 RVA: 0x0010F890 File Offset: 0x0010DA90
	[Token(Token = "0x6003389")]
	[Address(RVA = "0x7342B0", Offset = "0x7328B0", VA = "0x1807342B0")]
	private static void AllowNight()
	{
		HashSet<ZombieType> hashSet = InitZombieList.zombieToSpawns;
		int num = 0;
		bool flag = hashSet.Add(num);
		bool flag2 = InitZombieList.zombieToSpawns.Add((uint)2);
		bool flag3 = InitZombieList.zombieToSpawns.Add((uint)3);
		bool flag4 = InitZombieList.zombieToSpawns.Add((uint)100);
		bool flag5 = InitZombieList.zombieToSpawns.Add((uint)103);
		bool flag6 = InitZombieList.zombieToSpawns.Add((uint)4);
		bool flag7 = InitZombieList.zombieToSpawns.Add((uint)9);
		bool flag8 = InitZombieList.zombieToSpawns.Add((uint)8);
		bool flag9 = InitZombieList.zombieToSpawns.Add((uint)6);
		bool flag10 = InitZombieList.zombieToSpawns.Add((uint)10);
		bool flag11 = InitZombieList.zombieToSpawns.Add((uint)104);
		bool flag12 = InitZombieList.zombieToSpawns.Add((uint)111);
		bool flag13 = InitZombieList.zombieToSpawns.Add((uint)109);
	}

	// Token: 0x0600338A RID: 13194 RVA: 0x0010F964 File Offset: 0x0010DB64
	[Token(Token = "0x600338A")]
	[Address(RVA = "0x733FB0", Offset = "0x7325B0", VA = "0x180733FB0")]
	private static void AllowEliteNight()
	{
		bool flag = InitZombieList.zombieToSpawns.Add((uint)104);
		bool flag2 = InitZombieList.zombieToSpawns.Add((uint)108);
		bool flag3 = InitZombieList.zombieToSpawns.Add((uint)106);
		bool flag4 = InitZombieList.zombieToSpawns.Add((uint)109);
		bool flag5 = InitZombieList.zombieToSpawns.Add((uint)111);
		bool flag6 = InitZombieList.zombieToSpawns.Add((uint)6);
		bool flag7 = InitZombieList.zombieToSpawns.Add((uint)10);
	}

	// Token: 0x0600338B RID: 13195 RVA: 0x0010F9DC File Offset: 0x0010DBDC
	[Token(Token = "0x600338B")]
	[Address(RVA = "0x734600", Offset = "0x732C00", VA = "0x180734600")]
	private static void AllowPlantZombie()
	{
		bool flag = InitZombieList.zombieToSpawns.Add((uint)100);
		bool flag2 = InitZombieList.zombieToSpawns.Add((uint)101);
		bool flag3 = InitZombieList.zombieToSpawns.Add((uint)103);
		bool flag4 = InitZombieList.zombieToSpawns.Add((uint)104);
		bool flag5 = InitZombieList.zombieToSpawns.Add((uint)106);
		bool flag6 = InitZombieList.zombieToSpawns.Add((uint)107);
		bool flag7 = InitZombieList.zombieToSpawns.Add((uint)108);
		bool flag8 = InitZombieList.zombieToSpawns.Add((uint)109);
		bool flag9 = InitZombieList.zombieToSpawns.Add((uint)111);
	}

	// Token: 0x0600338C RID: 13196 RVA: 0x0010FA74 File Offset: 0x0010DC74
	[Token(Token = "0x600338C")]
	[Address(RVA = "0x733B60", Offset = "0x732160", VA = "0x180733B60")]
	public static void AllowAllTravel()
	{
		InitZombieList.AllowZombies(InitZombieList.allowAllzombies);
	}

	// Token: 0x0600338D RID: 13197 RVA: 0x0010FA8C File Offset: 0x0010DC8C
	[Token(Token = "0x600338D")]
	[Address(RVA = "0x7347D0", Offset = "0x732DD0", VA = "0x1807347D0")]
	private static void AllowUltimate(int count)
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
		if (count > 0)
		{
			int num = list._size;
			int num2 = global::UnityEngine.Random.Range(0, num);
			num = num2;
			HashSet<ZombieType> hashSet = InitZombieList.zombieToSpawns;
			int num3 = list[num];
			num3 = num2;
			list.RemoveAt(num3);
		}
	}

	// Token: 0x0600338E RID: 13198 RVA: 0x0010FB44 File Offset: 0x0010DD44
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x600338E")]
	[Address(RVA = "0x746A60", Offset = "0x745060", VA = "0x180746A60")]
	static InitZombieList()
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
		int size17 = list._size;
		int size18 = list._size;
		int size19 = list._size;
		int size20 = list._size;
		int size21 = list._size;
		InitZombieList.zombieInLandNormal = list;
		List<ZombieType> list2 = new List();
		int size22 = list2._size;
		int size23 = list2._size;
		int size24 = list2._size;
		int size25 = list2._size;
		int size26 = list2._size;
		int size27 = list2._size;
		int size28 = list2._size;
		int size29 = list2._size;
		int size30 = list2._size;
		int size31 = list2._size;
		int size32 = list2._size;
		int size33 = list2._size;
		int size34 = list2._size;
		int size35 = list2._size;
		InitZombieList.zombieInLandHard = list2;
		InitZombieList.zombieInPoolNormal = new List();
		List<ZombieType> list3 = new List();
	}

	// Token: 0x04002571 RID: 9585
	[Token(Token = "0x4002571")]
	private static int multiplier;

	// Token: 0x04002572 RID: 9586
	[Token(Token = "0x4002572")]
	public static int theMaxWave;

	// Token: 0x04002573 RID: 9587
	[Token(Token = "0x4002573")]
	public static List<List<ZombieSpawnData>> zombieList = new List();

	// Token: 0x04002574 RID: 9588
	[Token(Token = "0x4002574")]
	public static HashSet<ZombieType> zombieTypeList = new HashSet();

	// Token: 0x04002575 RID: 9589
	[Token(Token = "0x4002575")]
	public static HashSet<ZombieType> zombieToSpawns = new HashSet();

	// Token: 0x04002576 RID: 9590
	[Token(Token = "0x4002576")]
	private static int zombiePoint;

	// Token: 0x04002577 RID: 9591
	[Token(Token = "0x4002577")]
	private static readonly List<ZombieType> zombieInLandNormal;

	// Token: 0x04002578 RID: 9592
	[Token(Token = "0x4002578")]
	private static readonly List<ZombieType> zombieInLandHard;

	// Token: 0x04002579 RID: 9593
	[Token(Token = "0x4002579")]
	private static readonly List<ZombieType> zombieInPoolNormal;

	// Token: 0x0400257A RID: 9594
	[Token(Token = "0x400257A")]
	private static readonly List<ZombieType> zombieInPoolHard;

	// Token: 0x0400257B RID: 9595
	[Token(Token = "0x400257B")]
	private static readonly List<ZombieType> zombieInTravel_water;

	// Token: 0x0400257C RID: 9596
	[Token(Token = "0x400257C")]
	private static readonly List<ZombieType> zombieInTravel_snow;

	// Token: 0x0400257D RID: 9597
	[Token(Token = "0x400257D")]
	private static readonly List<ZombieType> zombieInTravel_land;

	// Token: 0x0400257E RID: 9598
	[Token(Token = "0x400257E")]
	public static List<ZombieType> allowAllzombies;
}
