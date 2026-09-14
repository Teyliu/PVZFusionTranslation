using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using GameLevel;
using GameLevel.RogueShooting;
using UnityEngine;

// Token: 0x020009A6 RID: 2470
[Token(Token = "0x20009A6")]
public static class InitZombieList
{
	// Token: 0x0600322F RID: 12847 RVA: 0x00108C48 File Offset: 0x00106E48
	[Token(Token = "0x600322F")]
	[Address(RVA = "0x6D9380", Offset = "0x6D7980", VA = "0x1806D9380")]
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

	// Token: 0x06003230 RID: 12848 RVA: 0x00108F3C File Offset: 0x0010713C
	[Token(Token = "0x6003230")]
	[Address(RVA = "0x6E14A0", Offset = "0x6DFAA0", VA = "0x1806E14A0")]
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

	// Token: 0x06003231 RID: 12849 RVA: 0x00109038 File Offset: 0x00107238
	[Token(Token = "0x6003231")]
	[Address(RVA = "0x6E13A0", Offset = "0x6DF9A0", VA = "0x1806E13A0")]
	private static void TryAddBoss(ZombieType zombieType, int currentWave, int minWave)
	{
		HashSet<ZombieType> hashSet = InitZombieList.zombieToSpawns;
		bool flag;
		if (flag)
		{
			Board instance = Board.Instance;
		}
	}

	// Token: 0x06003232 RID: 12850 RVA: 0x00109060 File Offset: 0x00107260
	[Token(Token = "0x6003232")]
	[Address(RVA = "0x6DE3B0", Offset = "0x6DC9B0", VA = "0x1806DE3B0")]
	private static bool ShootingLimit(ZombieType theZombieType, int wave)
	{
		bool flag;
		bool flag2;
		bool flag3;
		return (wave < 30 && flag) || flag2 || flag3;
	}

	// Token: 0x06003233 RID: 12851 RVA: 0x0010908C File Offset: 0x0010728C
	[Token(Token = "0x6003233")]
	[Address(RVA = "0x6E1670", Offset = "0x6DFC70", VA = "0x1806E1670")]
	private static bool WheatProtectionLimit(ZombieType theZombieType, int wave)
	{
		bool flag;
		bool flag2;
		bool flag3;
		return (wave < 40 && (theZombieType == ZombieType.QuickJacksonZombie || flag)) || flag2 || flag3;
	}

	// Token: 0x06003234 RID: 12852 RVA: 0x001090C4 File Offset: 0x001072C4
	[Token(Token = "0x6003234")]
	[Address(RVA = "0x6CBD00", Offset = "0x6CA300", VA = "0x1806CBD00")]
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

	// Token: 0x06003235 RID: 12853 RVA: 0x00109144 File Offset: 0x00107344
	[Token(Token = "0x6003235")]
	[Address(RVA = "0x6D8720", Offset = "0x6D6D20", VA = "0x1806D8720")]
	public static int GetPoint(ZombieType zombieType)
	{
		Dictionary<ZombieType, ZombieDataManager.ZombieData> zombieDataDic = ZombieDataManager.zombieDataDic;
		ZombieDataManager.ZombieData zombieData;
		return zombieData.summonLevel;
	}

	// Token: 0x06003236 RID: 12854 RVA: 0x00109168 File Offset: 0x00107368
	[Token(Token = "0x6003236")]
	[Address(RVA = "0x6DF030", Offset = "0x6DD630", VA = "0x1806DF030")]
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

	// Token: 0x06003237 RID: 12855 RVA: 0x00109340 File Offset: 0x00107540
	[Token(Token = "0x6003237")]
	[Address(RVA = "0x6DBD20", Offset = "0x6DA320", VA = "0x1806DBD20")]
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

	// Token: 0x06003238 RID: 12856 RVA: 0x00109554 File Offset: 0x00107754
	[Token(Token = "0x6003238")]
	[Address(RVA = "0x6DF990", Offset = "0x6DDF90", VA = "0x1806DF990")]
	public static void TravelLandGroup(int group)
	{
		if (group <= 11)
		{
			InitZombieList.AllowZombies(new List());
			return;
		}
	}

	// Token: 0x06003239 RID: 12857 RVA: 0x00109794 File Offset: 0x00107994
	[Token(Token = "0x6003239")]
	[Address(RVA = "0x6E0E90", Offset = "0x6DF490", VA = "0x1806E0E90")]
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

	// Token: 0x0600323A RID: 12858 RVA: 0x0010982C File Offset: 0x00107A2C
	[Token(Token = "0x600323A")]
	[Address(RVA = "0x6CC080", Offset = "0x6CA680", VA = "0x1806CC080")]
	private static void AdvantureZombieTypeSpawn(int theLevelNumber)
	{
		while (theLevelNumber - 1 > 44)
		{
		}
		int num = theLevelNumber - 1;
		InitZombieList.AllowZombies(new List());
	}

	// Token: 0x0600323B RID: 12859 RVA: 0x00109C28 File Offset: 0x00107E28
	[Token(Token = "0x600323B")]
	[Address(RVA = "0x6DBB40", Offset = "0x6DA140", VA = "0x1806DBB40")]
	private static void SetAllowZombieTypeSpawn(LevelType theLevelType, int theLevelNumber)
	{
		if (theLevelType <= LevelType.StarAdvanture)
		{
			InitZombieList.AdvantureZombieTypeSpawn(theLevelNumber);
			return;
		}
	}

	// Token: 0x0600323C RID: 12860 RVA: 0x00109C58 File Offset: 0x00107E58
	[Token(Token = "0x600323C")]
	[Address(RVA = "0x6DAAC0", Offset = "0x6D90C0", VA = "0x1806DAAC0")]
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

	// Token: 0x0600323D RID: 12861 RVA: 0x00109CD4 File Offset: 0x00107ED4
	[Token(Token = "0x600323D")]
	[Address(RVA = "0x6DE470", Offset = "0x6DCA70", VA = "0x1806DE470")]
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

	// Token: 0x0600323E RID: 12862 RVA: 0x00109DD0 File Offset: 0x00107FD0
	[Token(Token = "0x600323E")]
	[Address(RVA = "0x6CFA70", Offset = "0x6CE070", VA = "0x1806CFA70")]
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

	// Token: 0x0600323F RID: 12863 RVA: 0x00109E20 File Offset: 0x00108020
	[Token(Token = "0x600323F")]
	[Address(RVA = "0x6CFC20", Offset = "0x6CE220", VA = "0x1806CFC20")]
	private static void ChallengeSpawner(int theLevelNumber)
	{
		while (theLevelNumber - 1 > 173)
		{
		}
		int num = theLevelNumber - 1;
		InitZombieList.LandHard();
	}

	// Token: 0x06003240 RID: 12864 RVA: 0x0010A160 File Offset: 0x00108360
	[Token(Token = "0x6003240")]
	[Address(RVA = "0x6D8990", Offset = "0x6D6F90", VA = "0x1806D8990")]
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

	// Token: 0x06003241 RID: 12865 RVA: 0x0010A1C8 File Offset: 0x001083C8
	[Token(Token = "0x6003241")]
	[Address(RVA = "0x6D87A0", Offset = "0x6D6DA0", VA = "0x1806D87A0")]
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

	// Token: 0x06003242 RID: 12866 RVA: 0x0010A23C File Offset: 0x0010843C
	[Token(Token = "0x6003242")]
	[Address(RVA = "0x6D8D40", Offset = "0x6D7340", VA = "0x1806D8D40")]
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

	// Token: 0x06003243 RID: 12867 RVA: 0x0010A2A4 File Offset: 0x001084A4
	[Token(Token = "0x6003243")]
	[Address(RVA = "0x6D8B50", Offset = "0x6D7150", VA = "0x1806D8B50")]
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

	// Token: 0x06003244 RID: 12868 RVA: 0x0010A318 File Offset: 0x00108518
	[Token(Token = "0x6003244")]
	[Address(RVA = "0x6D90E0", Offset = "0x6D76E0", VA = "0x1806D90E0")]
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

	// Token: 0x06003245 RID: 12869 RVA: 0x0010A380 File Offset: 0x00108580
	[Token(Token = "0x6003245")]
	[Address(RVA = "0x6D8F00", Offset = "0x6D7500", VA = "0x1806D8F00")]
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

	// Token: 0x06003246 RID: 12870 RVA: 0x0010A3F4 File Offset: 0x001085F4
	[Token(Token = "0x6003246")]
	[Address(RVA = "0x6DB160", Offset = "0x6D9760", VA = "0x1806DB160")]
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

	// Token: 0x06003247 RID: 12871 RVA: 0x0010A4C0 File Offset: 0x001086C0
	[Token(Token = "0x6003247")]
	[Address(RVA = "0x6D92A0", Offset = "0x6D78A0", VA = "0x1806D92A0")]
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

	// Token: 0x06003248 RID: 12872 RVA: 0x0010A508 File Offset: 0x00108708
	[Token(Token = "0x6003248")]
	[Address(RVA = "0x6DA790", Offset = "0x6D8D90", VA = "0x1806DA790")]
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

	// Token: 0x06003249 RID: 12873 RVA: 0x0010A590 File Offset: 0x00108790
	[Token(Token = "0x6003249")]
	[Address(RVA = "0x6DA610", Offset = "0x6D8C10", VA = "0x1806DA610")]
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

	// Token: 0x0600324A RID: 12874 RVA: 0x0010A5CC File Offset: 0x001087CC
	[Token(Token = "0x600324A")]
	[Address(RVA = "0x6DEC90", Offset = "0x6DD290", VA = "0x1806DEC90")]
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

	// Token: 0x0600324B RID: 12875 RVA: 0x0010A644 File Offset: 0x00108844
	[Token(Token = "0x600324B")]
	[Address(RVA = "0x6DB790", Offset = "0x6D9D90", VA = "0x1806DB790")]
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

	// Token: 0x0600324C RID: 12876 RVA: 0x0010A6CC File Offset: 0x001088CC
	[Token(Token = "0x600324C")]
	[Address(RVA = "0x6DB610", Offset = "0x6D9C10", VA = "0x1806DB610")]
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

	// Token: 0x0600324D RID: 12877 RVA: 0x0010A708 File Offset: 0x00108908
	[Token(Token = "0x600324D")]
	[Address(RVA = "0x6DBAC0", Offset = "0x6DA0C0", VA = "0x1806DBAC0")]
	public static void RoofHard()
	{
		bool flag = InitZombieList.zombieToSpawns.Remove((uint)28);
	}

	// Token: 0x0600324E RID: 12878 RVA: 0x0010A72C File Offset: 0x0010892C
	[Token(Token = "0x600324E")]
	[Address(RVA = "0x6E1070", Offset = "0x6DF670", VA = "0x1806E1070")]
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

	// Token: 0x0600324F RID: 12879 RVA: 0x0010A7B4 File Offset: 0x001089B4
	[Token(Token = "0x600324F")]
	[Address(RVA = "0x6E0A40", Offset = "0x6DF040", VA = "0x1806E0A40")]
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

	// Token: 0x06003250 RID: 12880 RVA: 0x0010A87C File Offset: 0x00108A7C
	[Token(Token = "0x6003250")]
	[Address(RVA = "0x6E08C0", Offset = "0x6DEEC0", VA = "0x1806E08C0")]
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

	// Token: 0x06003251 RID: 12881 RVA: 0x0010A8B8 File Offset: 0x00108AB8
	[Token(Token = "0x6003251")]
	[Address(RVA = "0x6CF220", Offset = "0x6CD820", VA = "0x1806CF220")]
	private static void AllowNormal()
	{
		HashSet<ZombieType> hashSet = InitZombieList.zombieToSpawns;
		int num = 0;
		bool flag = hashSet.Add(num);
		bool flag2 = InitZombieList.zombieToSpawns.Add((uint)2);
		bool flag3 = InitZombieList.zombieToSpawns.Add((uint)4);
	}

	// Token: 0x06003252 RID: 12882 RVA: 0x0010A8F8 File Offset: 0x00108AF8
	[Token(Token = "0x6003252")]
	[Address(RVA = "0x6CEA50", Offset = "0x6CD050", VA = "0x1806CEA50")]
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

	// Token: 0x06003253 RID: 12883 RVA: 0x0010A9BC File Offset: 0x00108BBC
	[Token(Token = "0x6003253")]
	[Address(RVA = "0x6CE8B0", Offset = "0x6CCEB0", VA = "0x1806CE8B0")]
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

	// Token: 0x06003254 RID: 12884 RVA: 0x0010AA44 File Offset: 0x00108C44
	[Token(Token = "0x6003254")]
	[Address(RVA = "0x6CEE20", Offset = "0x6CD420", VA = "0x1806CEE20")]
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

	// Token: 0x06003255 RID: 12885 RVA: 0x0010AABC File Offset: 0x00108CBC
	[Token(Token = "0x6003255")]
	[Address(RVA = "0x6CEFA0", Offset = "0x6CD5A0", VA = "0x1806CEFA0")]
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

	// Token: 0x06003256 RID: 12886 RVA: 0x0010AB90 File Offset: 0x00108D90
	[Token(Token = "0x6003256")]
	[Address(RVA = "0x6CECA0", Offset = "0x6CD2A0", VA = "0x1806CECA0")]
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

	// Token: 0x06003257 RID: 12887 RVA: 0x0010AC08 File Offset: 0x00108E08
	[Token(Token = "0x6003257")]
	[Address(RVA = "0x6CF2F0", Offset = "0x6CD8F0", VA = "0x1806CF2F0")]
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

	// Token: 0x06003258 RID: 12888 RVA: 0x0010ACA0 File Offset: 0x00108EA0
	[Token(Token = "0x6003258")]
	[Address(RVA = "0x6CE850", Offset = "0x6CCE50", VA = "0x1806CE850")]
	public static void AllowAllTravel()
	{
		InitZombieList.AllowZombies(InitZombieList.allowAllzombies);
	}

	// Token: 0x06003259 RID: 12889 RVA: 0x0010ACB8 File Offset: 0x00108EB8
	[Token(Token = "0x6003259")]
	[Address(RVA = "0x6CF4C0", Offset = "0x6CDAC0", VA = "0x1806CF4C0")]
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

	// Token: 0x0600325A RID: 12890 RVA: 0x0010AD70 File Offset: 0x00108F70
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x600325A")]
	[Address(RVA = "0x6E1750", Offset = "0x6DFD50", VA = "0x1806E1750")]
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

	// Token: 0x0400245F RID: 9311
	[Token(Token = "0x400245F")]
	private static int multiplier;

	// Token: 0x04002460 RID: 9312
	[Token(Token = "0x4002460")]
	public static int theMaxWave;

	// Token: 0x04002461 RID: 9313
	[Token(Token = "0x4002461")]
	public static List<List<ZombieSpawnData>> zombieList = new List();

	// Token: 0x04002462 RID: 9314
	[Token(Token = "0x4002462")]
	public static HashSet<ZombieType> zombieTypeList = new HashSet();

	// Token: 0x04002463 RID: 9315
	[Token(Token = "0x4002463")]
	public static HashSet<ZombieType> zombieToSpawns = new HashSet();

	// Token: 0x04002464 RID: 9316
	[Token(Token = "0x4002464")]
	private static int zombiePoint;

	// Token: 0x04002465 RID: 9317
	[Token(Token = "0x4002465")]
	private static readonly List<ZombieType> zombieInLandNormal;

	// Token: 0x04002466 RID: 9318
	[Token(Token = "0x4002466")]
	private static readonly List<ZombieType> zombieInLandHard;

	// Token: 0x04002467 RID: 9319
	[Token(Token = "0x4002467")]
	private static readonly List<ZombieType> zombieInPoolNormal;

	// Token: 0x04002468 RID: 9320
	[Token(Token = "0x4002468")]
	private static readonly List<ZombieType> zombieInPoolHard;

	// Token: 0x04002469 RID: 9321
	[Token(Token = "0x4002469")]
	private static readonly List<ZombieType> zombieInTravel_water;

	// Token: 0x0400246A RID: 9322
	[Token(Token = "0x400246A")]
	private static readonly List<ZombieType> zombieInTravel_snow;

	// Token: 0x0400246B RID: 9323
	[Token(Token = "0x400246B")]
	private static readonly List<ZombieType> zombieInTravel_land;

	// Token: 0x0400246C RID: 9324
	[Token(Token = "0x400246C")]
	public static List<ZombieType> allowAllzombies;
}
