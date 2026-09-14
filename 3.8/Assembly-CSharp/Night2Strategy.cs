using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020008D9 RID: 2265
[Token(Token = "0x20008D9")]
public class Night2Strategy : BaseLevelStrategy
{
	// Token: 0x06002E27 RID: 11815 RVA: 0x000FBBD8 File Offset: 0x000F9DD8
	[Token(Token = "0x6002E27")]
	[Address(RVA = "0x69AA70", Offset = "0x699070", VA = "0x18069AA70", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Night2;
	}

	// Token: 0x06002E28 RID: 11816 RVA: 0x000FBBE8 File Offset: 0x000F9DE8
	[Token(Token = "0x6002E28")]
	[Address(RVA = "0x69A8F0", Offset = "0x698EF0", VA = "0x18069A8F0", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission mission = new AdvantureMission
		{
			board = board,
			level = (AdvantureLevel)((ulong)14L),
			endResult = (MissionResult)((ulong)1L)
		};
		Func<MissionResult> func;
		mission.target = func;
		AdvantureConfig.SetMissionDescription(mission, (AdvantureLevel)((uint)14));
		return mission;
	}

	// Token: 0x06002E29 RID: 11817 RVA: 0x000FBC4C File Offset: 0x000F9E4C
	[Token(Token = "0x6002E29")]
	[Address(RVA = "0x3AA5A0", Offset = "0x3A8BA0", VA = "0x1803AA5A0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 10;
	}

	// Token: 0x06002E2A RID: 11818 RVA: 0x000FBC5C File Offset: 0x000F9E5C
	[Token(Token = "0x6002E2A")]
	[Address(RVA = "0x69AB80", Offset = "0x699180", VA = "0x18069AB80", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		return list;
	}

	// Token: 0x06002E2B RID: 11819 RVA: 0x000FBCA4 File Offset: 0x000F9EA4
	[Token(Token = "0x6002E2B")]
	[Address(RVA = "0x3AE560", Offset = "0x3ACB60", VA = "0x1803AE560", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.FumeShroom;
	}

	// Token: 0x06002E2C RID: 11820 RVA: 0x000FBCB4 File Offset: 0x000F9EB4
	[Token(Token = "0x6002E2C")]
	[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Night;
	}

	// Token: 0x06002E2D RID: 11821 RVA: 0x000FBCC4 File Offset: 0x000F9EC4
	[Token(Token = "0x6002E2D")]
	[Address(RVA = "0x69AA40", Offset = "0x699040", VA = "0x18069AA40", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉黑夜：第2关";
	}

	// Token: 0x06002E2E RID: 11822 RVA: 0x000FBCD8 File Offset: 0x000F9ED8
	[Token(Token = "0x6002E2E")]
	[Address(RVA = "0x69AB00", Offset = "0x699100", VA = "0x18069AB00", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "后勤补给：不在第5列及以右放置植物（从左到右开始一共10列）";
		}
		if (result == MissionResult.Second)
		{
			return "墓碑克星：使用墓碑吞噬者消灭15个墓碑（通过支线1获取植物）（需要开启难度3及以上）";
		}
		return string.Empty;
	}

	// Token: 0x06002E2F RID: 11823 RVA: 0x000FBD00 File Offset: 0x000F9F00
	[Token(Token = "0x6002E2F")]
	[Address(RVA = "0x69AA80", Offset = "0x699080", VA = "0x18069AA80", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "第一波僵尸到达的时间延后5秒";
		}
		if (result == MissionResult.Second)
		{
			return "额外的墓碑数量减半";
		}
		return string.Empty;
	}

	// Token: 0x06002E30 RID: 11824 RVA: 0x000FBD28 File Offset: 0x000F9F28
	[Token(Token = "0x6002E30")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public Night2Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
