using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using GameLevel;
using Unity.VisualScripting;

// Token: 0x020008F3 RID: 2291
[Token(Token = "0x20008F3")]
public class AdvantureConfig
{
	// Token: 0x06002E6B RID: 11883 RVA: 0x000FDA4C File Offset: 0x000FBC4C
	[Token(Token = "0x6002E6B")]
	[Address(RVA = "0x6F7EA0", Offset = "0x6F64A0", VA = "0x1806F7EA0")]
	private static void InitializeStrategies()
	{
		int num;
		do
		{
			num = 0;
			if (AdvantureConfig.<>c.<>9__2_0 == 0)
			{
				AdvantureConfig.<>c.<>9__2_0 = delegate(Type t)
				{
					if (typeof(ILevelStrategy).IsAssignableFrom(t) && !t.IsInterface)
					{
						return t.IsAbstract;
					}
					throw new NullReferenceException();
				};
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

	// Token: 0x06002E6C RID: 11884 RVA: 0x000FDADC File Offset: 0x000FBCDC
	[Token(Token = "0x6002E6C")]
	[Address(RVA = "0x6F6FF0", Offset = "0x6F55F0", VA = "0x1806F6FF0")]
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

	// Token: 0x06002E6D RID: 11885 RVA: 0x000FDC68 File Offset: 0x000FBE68
	[Token(Token = "0x6002E6D")]
	[Address(RVA = "0x6F8420", Offset = "0x6F6A20", VA = "0x1806F8420")]
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

	// Token: 0x06002E6E RID: 11886 RVA: 0x000FDD50 File Offset: 0x000FBF50
	[Token(Token = "0x6002E6E")]
	[Address(RVA = "0x6F7B20", Offset = "0x6F6120", VA = "0x1806F7B20")]
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

	// Token: 0x06002E6F RID: 11887 RVA: 0x000FDD94 File Offset: 0x000FBF94
	[Token(Token = "0x6002E6F")]
	[Address(RVA = "0x6F8690", Offset = "0x6F6C90", VA = "0x1806F8690")]
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

	// Token: 0x06002E70 RID: 11888 RVA: 0x000FDDC0 File Offset: 0x000FBFC0
	[Token(Token = "0x6002E70")]
	[Address(RVA = "0x6F8BE0", Offset = "0x6F71E0", VA = "0x1806F8BE0")]
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

	// Token: 0x06002E71 RID: 11889 RVA: 0x000FDDF4 File Offset: 0x000FBFF4
	[Token(Token = "0x6002E71")]
	[Address(RVA = "0x6F79D0", Offset = "0x6F5FD0", VA = "0x1806F79D0")]
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

	// Token: 0x06002E72 RID: 11890 RVA: 0x000FDE30 File Offset: 0x000FC030
	[Token(Token = "0x6002E72")]
	[Address(RVA = "0x6F7910", Offset = "0x6F5F10", VA = "0x1806F7910")]
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

	// Token: 0x06002E73 RID: 11891 RVA: 0x000FDE54 File Offset: 0x000FC054
	[Token(Token = "0x6002E73")]
	[Address(RVA = "0x6F7D40", Offset = "0x6F6340", VA = "0x1806F7D40")]
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

	// Token: 0x06002E74 RID: 11892 RVA: 0x000FDE98 File Offset: 0x000FC098
	[Token(Token = "0x6002E74")]
	[Address(RVA = "0x6F77B0", Offset = "0x6F5DB0", VA = "0x1806F77B0")]
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

	// Token: 0x06002E75 RID: 11893 RVA: 0x000FDEDC File Offset: 0x000FC0DC
	[Token(Token = "0x6002E75")]
	[Address(RVA = "0x6F76F0", Offset = "0x6F5CF0", VA = "0x1806F76F0")]
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

	// Token: 0x06002E76 RID: 11894 RVA: 0x000FDF04 File Offset: 0x000FC104
	[Token(Token = "0x6002E76")]
	[Address(RVA = "0x6F7C80", Offset = "0x6F6280", VA = "0x1806F7C80")]
	public static SceneType GetSceneType(AdvantureLevel level)
	{
		Dictionary<AdvantureLevel, ILevelStrategy> levelStrategies = AdvantureConfig._levelStrategies;
		bool flag;
		if (!flag)
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x06002E77 RID: 11895 RVA: 0x000FDF30 File Offset: 0x000FC130
	[Token(Token = "0x6002E77")]
	[Address(RVA = "0x6F8AE0", Offset = "0x6F70E0", VA = "0x1806F8AE0")]
	public static void SubmitPlantConfig(AdvantureMission mission, PlantType needType, int needCount, MissionResult result)
	{
		AdvantureMission mission2 = mission;
		MissionResult result = result;
		Func<ValueTuple<MissionResult, int>> func;
		mission.onSubmit = func;
		throw new NullReferenceException();
	}

	// Token: 0x06002E78 RID: 11896 RVA: 0x000FDF78 File Offset: 0x000FC178
	[Token(Token = "0x6002E78")]
	[Address(RVA = "0x6F8800", Offset = "0x6F6E00", VA = "0x1806F8800")]
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

	// Token: 0x06002E79 RID: 11897 RVA: 0x000FE03C File Offset: 0x000FC23C
	[Token(Token = "0x6002E79")]
	[Address(RVA = "0x6F75F0", Offset = "0x6F5BF0", VA = "0x1806F75F0")]
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

	// Token: 0x06002E7A RID: 11898 RVA: 0x000FE074 File Offset: 0x000FC274
	[Token(Token = "0x6002E7A")]
	[Address(RVA = "0x6F8350", Offset = "0x6F6950", VA = "0x1806F8350")]
	public static void LoadData(AdvantureData advantureData)
	{
		AdvantureConfig.data = advantureData;
		AdvantureData advantureData2 = AdvantureConfig.data;
		HashSet<TalentType> hashSet = LinqUtility.ToHashSet<TalentType>(advantureData2.talents);
		advantureData2._talents = hashSet;
		throw new NullReferenceException();
	}

	// Token: 0x06002E7B RID: 11899 RVA: 0x000FE0A8 File Offset: 0x000FC2A8
	[Token(Token = "0x6002E7B")]
	[Address(RVA = "0x6F82C0", Offset = "0x6F68C0", VA = "0x1806F82C0")]
	public static bool IsAutoChess()
	{
		return "{il2cpp field on {'constant14' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0x98}" == (ulong)2026L;
	}

	// Token: 0x06002E7C RID: 11900 RVA: 0x000FE0C8 File Offset: 0x000FC2C8
	[Token(Token = "0x6002E7C")]
	[Address(RVA = "0x6F8D30", Offset = "0x6F7330", VA = "0x1806F8D30")]
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

	// Token: 0x06002E7D RID: 11901 RVA: 0x000FE164 File Offset: 0x000FC364
	[Token(Token = "0x6002E7D")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public AdvantureConfig()
	{
	}

	// Token: 0x04001C67 RID: 7271
	[Token(Token = "0x4001C67")]
	public static AdvantureData data;

	// Token: 0x04001C68 RID: 7272
	[Token(Token = "0x4001C68")]
	public static Dictionary<AdvantureLevel, ILevelStrategy> _levelStrategies;

	// Token: 0x04001C69 RID: 7273
	[Token(Token = "0x4001C69")]
	private static readonly Dictionary<PlantType, AdvantureLevel> unlockLevels;
}
