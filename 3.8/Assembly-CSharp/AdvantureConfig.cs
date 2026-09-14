using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using GameLevel;
using Unity.VisualScripting;

// Token: 0x020008B7 RID: 2231
[Token(Token = "0x20008B7")]
public class AdvantureConfig
{
	// Token: 0x06002D38 RID: 11576 RVA: 0x000F8EC8 File Offset: 0x000F70C8
	[Token(Token = "0x6002D38")]
	[Address(RVA = "0x67E8E0", Offset = "0x67CEE0", VA = "0x18067E8E0")]
	private static void InitializeStrategies()
	{
		int num;
		do
		{
			num = 0;
			if (AdvantureConfig.<>c.<>9__2_0 == 0)
			{
				Func<Type, bool> func;
				AdvantureConfig.<>c.<>9__2_0 = func;
			}
			AdvantureConfig._levelStrategies = new Dictionary();
			if (typeof(AdvantureConfig).TypeHandle != 0)
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
				Dictionary<AdvantureLevel, ILevelStrategy> levelStrategies = AdvantureConfig._levelStrategies;
			}
			if ("{il2cpp array field local9->}" != (ulong)0L)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x06002D39 RID: 11577 RVA: 0x000F8F48 File Offset: 0x000F7148
	[Token(Token = "0x6002D39")]
	[Address(RVA = "0x67DA30", Offset = "0x67C030", VA = "0x18067DA30")]
	public static void Advanture2Setting(Board board, AdvantureLevel level)
	{
		int num = 0;
		board.config.zombieHealthMultiplier = 1f;
		Dictionary<AdvantureLevel, ILevelStrategy> levelStrategies = AdvantureConfig._levelStrategies;
		bool flag;
		if (flag)
		{
		}
		ulong num2;
		num2 += (ulong)1L;
		num2 += num2;
		int num3;
		if (level > AdvantureLevel.Tag)
		{
			num3 = AdvantureConfig.data.gameDifficulty;
		}
		if ((AdvantureConfig.data.hardMode ? 1 : 0) != num)
		{
			board.boardTag.disableMower = true;
			num3 += 2;
		}
		BoardData boardData = board.boardData;
		Dictionary<int, int> zombieLevelProbabilitySmart = ZombieLevelDictionary.GetZombieLevelProbabilitySmart(num3);
		boardData.zombieLevelDic = zombieLevelProbabilitySmart;
		uint num4;
		boardData.zombieLevelDic = new Dictionary { { num3, num4 } };
		AdvantureData advantureData = AdvantureConfig.data;
		bool flag2;
		if (flag2)
		{
			float timeUntilNextWave = board.timeUntilNextWave;
			board.timeUntilNextWave = timeUntilNextWave;
		}
		AdvantureData advantureData2 = AdvantureConfig.data;
		bool flag3;
		if (flag3)
		{
			BoardConfig config = board.config;
			float waveInterval = config.waveInterval;
			config.waveInterval = waveInterval;
		}
		AdvantureData advantureData3 = AdvantureConfig.data;
		bool flag4;
		if (flag4)
		{
			uint num5;
			board.AddLightLevel((int)num5);
		}
		AdvantureData advantureData4 = AdvantureConfig.data;
		bool flag5;
		if (flag5)
		{
			BoardConfig config2 = board.config;
			float num6 = config2.zombieHealthMultiplier * 0.8f;
			config2.zombieHealthMultiplier = num6;
		}
		AdvantureData advantureData5 = AdvantureConfig.data;
		bool flag6;
		if (flag6)
		{
			board.GetMoney(3000f);
		}
		AdvantureManager advantureManager = board.AddComponent<AdvantureManager>();
		Dictionary<AdvantureLevel, ILevelStrategy> levelStrategies2 = AdvantureConfig._levelStrategies;
		bool flag7;
		if (flag7 && num < levelStrategies2)
		{
			num += num;
			num++;
		}
		advantureManager.mission = num;
		advantureManager.board = board;
		bool hardMode = AdvantureConfig.data.hardMode;
		advantureManager.hardMode = hardMode;
	}

	// Token: 0x06002D3A RID: 11578 RVA: 0x000F90D4 File Offset: 0x000F72D4
	[Token(Token = "0x6002D3A")]
	[Address(RVA = "0x67EE60", Offset = "0x67D460", VA = "0x18067EE60")]
	public static bool MixLimit(PlantType plantType)
	{
		if (plantType > PlantType.SuperTorch)
		{
			if (plantType > PlantType.SuperStar)
			{
				if (plantType != PlantType.SuperPumpkin)
				{
					if (plantType == PlantType.SuperMelon || plantType == PlantType.SuperUmbrella)
					{
						return AdvantureConfig.data.talents.Contains((uint)38);
					}
					goto IL_00D0;
				}
			}
			else
			{
				if (plantType == PlantType.SuperKelp)
				{
					goto IL_0086;
				}
				if (plantType != PlantType.SuperStar)
				{
					goto IL_00D0;
				}
			}
			return AdvantureConfig.data.talents.Contains((uint)37);
		}
		if (plantType > PlantType.SuperChomper)
		{
			if (plantType == PlantType.SuperHypno || plantType == PlantType.SuperFume)
			{
				return AdvantureConfig.data.talents.Contains((uint)35);
			}
			if (plantType != PlantType.SuperTorch)
			{
				goto IL_00D0;
			}
		}
		else
		{
			if (typeof(AdvantureConfig).TypeHandle == (ulong)4294967287L)
			{
				return AdvantureConfig.data.talents.Contains((uint)34);
			}
			goto IL_00D0;
		}
		IL_0086:
		return AdvantureConfig.data.talents.Contains((uint)36);
		IL_00D0:
		throw new NullReferenceException();
	}

	// Token: 0x06002D3B RID: 11579 RVA: 0x000F91BC File Offset: 0x000F73BC
	[Token(Token = "0x6002D3B")]
	[Address(RVA = "0x67E560", Offset = "0x67CB60", VA = "0x18067E560")]
	public static List<PlantType> GetRandomPlantTypes(AdvantureLevel level)
	{
		Dictionary<AdvantureLevel, ILevelStrategy> levelStrategies = AdvantureConfig._levelStrategies;
		bool flag;
		if (!flag)
		{
			List<PlantType> list = new List();
			int size = list._size;
			return list;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06002D3C RID: 11580 RVA: 0x000F9200 File Offset: 0x000F7400
	[Token(Token = "0x6002D3C")]
	[Address(RVA = "0x67F0D0", Offset = "0x67D6D0", VA = "0x18067F0D0")]
	public static void PreSelectCard(InitBoard board)
	{
		int num = 0;
		Dictionary<AdvantureLevel, ILevelStrategy> levelStrategies = AdvantureConfig._levelStrategies;
		bool flag;
		if (flag && num < levelStrategies)
		{
			num += num;
			num++;
		}
	}

	// Token: 0x06002D3D RID: 11581 RVA: 0x000F922C File Offset: 0x000F742C
	[Token(Token = "0x6002D3D")]
	[Address(RVA = "0x67F620", Offset = "0x67DC20", VA = "0x18067F620")]
	public static bool TryGetRandomZombieTypes(AdvantureLevel level, [Out] List<ZombieType> zombieTypes)
	{
		List<ZombieType> list = new List();
		Dictionary<AdvantureLevel, ILevelStrategy> levelStrategies = AdvantureConfig._levelStrategies;
		bool flag;
		if (!flag)
		{
			return flag;
		}
		return "{il2cpp field on {'constant25' (constant value of type Cpp2IL.Core.Analysis.Il2CppClassIdentifier)}, offset 0x18}" > (ulong)0L;
	}

	// Token: 0x06002D3E RID: 11582 RVA: 0x000F9260 File Offset: 0x000F7460
	[Token(Token = "0x6002D3E")]
	[Address(RVA = "0x67E410", Offset = "0x67CA10", VA = "0x18067E410")]
	private static AdvantureMission GetMission(Board board, AdvantureLevel level)
	{
		int num = 0;
		Dictionary<AdvantureLevel, ILevelStrategy> levelStrategies = AdvantureConfig._levelStrategies;
		bool flag;
		if (!flag)
		{
		}
		if (num < levelStrategies)
		{
			num += num;
			num++;
		}
		num += 2;
		num += 312;
		throw new NullReferenceException();
	}

	// Token: 0x06002D3F RID: 11583 RVA: 0x000F929C File Offset: 0x000F749C
	[Token(Token = "0x6002D3F")]
	[Address(RVA = "0x67E350", Offset = "0x67C950", VA = "0x18067E350")]
	public static int GetMaxWave(AdvantureLevel level)
	{
		Dictionary<AdvantureLevel, ILevelStrategy> levelStrategies = AdvantureConfig._levelStrategies;
		bool flag;
		if (!flag)
		{
			return 10;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06002D40 RID: 11584 RVA: 0x000F92C0 File Offset: 0x000F74C0
	[Token(Token = "0x6002D40")]
	[Address(RVA = "0x67E780", Offset = "0x67CD80", VA = "0x18067E780")]
	public static List<ZombieType> GetZombieTypes(AdvantureLevel level)
	{
		Dictionary<AdvantureLevel, ILevelStrategy> levelStrategies = AdvantureConfig._levelStrategies;
		bool flag;
		if (!flag)
		{
			List<ZombieType> list = new List();
			int size = list._size;
			return list;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06002D41 RID: 11585 RVA: 0x000F9304 File Offset: 0x000F7504
	[Token(Token = "0x6002D41")]
	[Address(RVA = "0x67E1F0", Offset = "0x67C7F0", VA = "0x18067E1F0")]
	public static List<PlantType> GetConveyPlants(AdvantureLevel level)
	{
		Dictionary<AdvantureLevel, ILevelStrategy> levelStrategies = AdvantureConfig._levelStrategies;
		bool flag;
		if (!flag)
		{
			List<PlantType> list = new List();
			int size = list._size;
			return list;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06002D42 RID: 11586 RVA: 0x000F9348 File Offset: 0x000F7548
	[Token(Token = "0x6002D42")]
	[Address(RVA = "0x67E130", Offset = "0x67C730", VA = "0x18067E130")]
	public static PlantType GetBasicPlantType(AdvantureLevel level)
	{
		Dictionary<AdvantureLevel, ILevelStrategy> levelStrategies = AdvantureConfig._levelStrategies;
		bool flag;
		if (!flag)
		{
			return PlantType.SunFlower;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06002D43 RID: 11587 RVA: 0x000F9370 File Offset: 0x000F7570
	[Token(Token = "0x6002D43")]
	[Address(RVA = "0x67E6C0", Offset = "0x67CCC0", VA = "0x18067E6C0")]
	public static SceneType GetSceneType(AdvantureLevel level)
	{
		Dictionary<AdvantureLevel, ILevelStrategy> levelStrategies = AdvantureConfig._levelStrategies;
		bool flag;
		if (!flag)
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x06002D44 RID: 11588 RVA: 0x000F939C File Offset: 0x000F759C
	[Token(Token = "0x6002D44")]
	[Address(RVA = "0x67F520", Offset = "0x67DB20", VA = "0x18067F520")]
	public static void SubmitPlantConfig(AdvantureMission mission, PlantType needType, int needCount, MissionResult result)
	{
		AdvantureMission mission2 = mission;
		MissionResult result = result;
		Func<ValueTuple<MissionResult, int>> func;
		mission.onSubmit = func;
		throw new NullReferenceException();
	}

	// Token: 0x06002D45 RID: 11589 RVA: 0x000F93E4 File Offset: 0x000F75E4
	[Token(Token = "0x6002D45")]
	[Address(RVA = "0x67F240", Offset = "0x67D840", VA = "0x18067F240")]
	public static void SetMissionDescription(AdvantureMission mission, AdvantureLevel level)
	{
		mission.description = "请选择一个任务完成\n";
		if (mission.single)
		{
			mission.description = "";
		}
		Dictionary<AdvantureLevel, ILevelStrategy> levelStrategies = AdvantureConfig._levelStrategies;
		bool flag;
		if (flag)
		{
			bool flag2;
			if (!flag2)
			{
				string description = mission.description;
				string text;
				mission.description = text;
			}
			bool flag3;
			string text2;
			if (!flag3)
			{
				mission.complete1 = flag;
				string description2 = mission.description;
				mission.description = text2;
			}
			if (!string.IsNullOrEmpty(text2))
			{
				string text3 = mission.description + text2;
				mission.description = text3;
			}
			if (!string.IsNullOrEmpty(text2))
			{
				mission.complete2 = text2;
				string text4 = mission.description + "\n<color=yellow>奖励：" + text2 + "</color>";
				mission.description = text4;
			}
		}
	}

	// Token: 0x06002D46 RID: 11590 RVA: 0x000F94A8 File Offset: 0x000F76A8
	[Token(Token = "0x6002D46")]
	[Address(RVA = "0x67E030", Offset = "0x67C630", VA = "0x18067E030")]
	public static bool CheckPlantUnlock(PlantType plantType)
	{
		Dictionary<PlantType, AdvantureLevel> dictionary = AdvantureConfig.unlockLevels;
		bool flag;
		if (!flag)
		{
			return flag;
		}
		ulong num;
		if (num != (ulong)0L)
		{
			List<AdvantureLevel> levelCompleted = AdvantureConfig.data.levelCompleted;
			bool flag2;
			return flag2;
		}
		return true;
	}

	// Token: 0x06002D47 RID: 11591 RVA: 0x000F94E0 File Offset: 0x000F76E0
	[Token(Token = "0x6002D47")]
	[Address(RVA = "0x67ED90", Offset = "0x67D390", VA = "0x18067ED90")]
	public static void LoadData(AdvantureData advantureData)
	{
		AdvantureConfig.data = advantureData;
		AdvantureData advantureData2 = AdvantureConfig.data;
		HashSet<TalentType> hashSet = LinqUtility.ToHashSet<TalentType>(advantureData2.talents);
		advantureData2._talents = hashSet;
		throw new NullReferenceException();
	}

	// Token: 0x06002D48 RID: 11592 RVA: 0x000F9514 File Offset: 0x000F7714
	[Token(Token = "0x6002D48")]
	[Address(RVA = "0x67ED00", Offset = "0x67D300", VA = "0x18067ED00")]
	public static bool IsAutoChess()
	{
		return "{il2cpp field on {'constant14' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0x98}" == (ulong)2026L;
	}

	// Token: 0x06002D49 RID: 11593 RVA: 0x000F9534 File Offset: 0x000F7734
	[Token(Token = "0x6002D49")]
	[Address(RVA = "0x67F770", Offset = "0x67DD70", VA = "0x18067F770")]
	static AdvantureConfig()
	{
		AdvantureData advantureData = new AdvantureData();
		List<AdvantureLevel> list = new List();
		advantureData.levelCompletedHard = list;
		List<AdvantureLevel> list2 = new List();
		advantureData.levelCompleted = list2;
		List<MissionData> list3 = new List();
		advantureData.missionDatas = list3;
		List<TalentType> list4 = new List();
		advantureData.talents = list4;
		HashSet<TalentType> hashSet = new HashSet();
		advantureData._talents = hashSet;
		PlantDevelopData plantDevelopData = new PlantDevelopData();
		advantureData.plantDevelopData = plantDevelopData;
		AdvantureConfig.data = advantureData;
		Dictionary<PlantType, AdvantureLevel> dictionary = new Dictionary();
		int num = 0;
		int num2 = 0;
		dictionary.Add(num2, num);
		AdvantureConfig.unlockLevels = dictionary;
		AdvantureConfig.InitializeStrategies();
	}

	// Token: 0x06002D4A RID: 11594 RVA: 0x000F95D0 File Offset: 0x000F77D0
	[Token(Token = "0x6002D4A")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public AdvantureConfig()
	{
	}

	// Token: 0x04001B77 RID: 7031
	[Token(Token = "0x4001B77")]
	public static AdvantureData data;

	// Token: 0x04001B78 RID: 7032
	[Token(Token = "0x4001B78")]
	public static Dictionary<AdvantureLevel, ILevelStrategy> _levelStrategies;

	// Token: 0x04001B79 RID: 7033
	[Token(Token = "0x4001B79")]
	private static readonly Dictionary<PlantType, AdvantureLevel> unlockLevels;
}
