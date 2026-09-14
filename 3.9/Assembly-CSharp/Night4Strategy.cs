using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

// Token: 0x0200091A RID: 2330
[Token(Token = "0x200091A")]
public class Night4Strategy : BaseLevelStrategy
{
	// Token: 0x06002F75 RID: 12149 RVA: 0x00100B30 File Offset: 0x000FED30
	[Token(Token = "0x6002F75")]
	[Address(RVA = "0x715410", Offset = "0x713A10", VA = "0x180715410", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Night4;
	}

	// Token: 0x06002F76 RID: 12150 RVA: 0x00100B40 File Offset: 0x000FED40
	[Token(Token = "0x6002F76")]
	[Address(RVA = "0x715260", Offset = "0x713860", VA = "0x180715260", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission mission = new AdvantureMission
		{
			board = board,
			level = (AdvantureLevel)((ulong)16L),
			endResult = (MissionResult)((ulong)1L)
		};
		AdvantureMission mission2 = mission;
		Func<MissionResult> func = delegate
		{
			List<Plant> allPlants = Lawnf.GetAllPlants();
			Func<Plant, bool> <>9__1_ = Night4Strategy.<>c.<>9__1_1;
			if (<>9__1_ == 0)
			{
				Night4Strategy.<>c.<>9__1_1 = (Plant p) => p.thePlantColumn < 3;
			}
			if (Enumerable.FirstOrDefault<Plant>(allPlants, <>9__1_))
			{
				mission.endResult = (MissionResult)((ulong)0L);
			}
			throw new NullReferenceException();
		};
		mission2.target = func;
		AdvantureConfig.SubmitPlantConfig(mission, (PlantType)((uint)9), 10, (MissionResult)((uint)2));
		AdvantureConfig.SetMissionDescription(mission, (AdvantureLevel)((uint)16));
		return mission;
	}

	// Token: 0x06002F77 RID: 12151 RVA: 0x00100BC4 File Offset: 0x000FEDC4
	[Token(Token = "0x6002F77")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06002F78 RID: 12152 RVA: 0x00100BD4 File Offset: 0x000FEDD4
	[Token(Token = "0x6002F78")]
	[Address(RVA = "0x715520", Offset = "0x713B20", VA = "0x180715520", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		return list;
	}

	// Token: 0x06002F79 RID: 12153 RVA: 0x00100C18 File Offset: 0x000FEE18
	[Token(Token = "0x6002F79")]
	[Address(RVA = "0x3F87C0", Offset = "0x3F6DC0", VA = "0x1803F87C0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.ScaredyShroom;
	}

	// Token: 0x06002F7A RID: 12154 RVA: 0x00100C28 File Offset: 0x000FEE28
	[Token(Token = "0x6002F7A")]
	[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Night;
	}

	// Token: 0x06002F7B RID: 12155 RVA: 0x00100C38 File Offset: 0x000FEE38
	[Token(Token = "0x6002F7B")]
	[Address(RVA = "0x7153E0", Offset = "0x7139E0", VA = "0x1807153E0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉黑夜：第4关";
	}

	// Token: 0x06002F7C RID: 12156 RVA: 0x00100C4C File Offset: 0x000FEE4C
	[Token(Token = "0x6002F7C")]
	[Address(RVA = "0x7154A0", Offset = "0x713AA0", VA = "0x1807154A0", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "前线作战：不在第3列及以左放置植物（从左到右开始一共10列）";
		}
		if (result == MissionResult.Second)
		{
			return "物美价廉：提交10个胆小菇";
		}
		return string.Empty;
	}

	// Token: 0x06002F7D RID: 12157 RVA: 0x00100C74 File Offset: 0x000FEE74
	[Token(Token = "0x6002F7D")]
	[Address(RVA = "0x715420", Offset = "0x713A20", VA = "0x180715420", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "每一波僵尸的自然刷新间隔增加5秒";
		}
		if (result == MissionResult.Second)
		{
			return "蘑菇在黑夜时冷却降低10%，在白天时价格降低10";
		}
		return string.Empty;
	}

	// Token: 0x06002F7E RID: 12158 RVA: 0x00100C9C File Offset: 0x000FEE9C
	[Token(Token = "0x6002F7E")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Night4Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
