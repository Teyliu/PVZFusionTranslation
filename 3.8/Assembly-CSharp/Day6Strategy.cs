using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020008CE RID: 2254
[Token(Token = "0x20008CE")]
public class Day6Strategy : BaseLevelStrategy
{
	// Token: 0x06002DD5 RID: 11733 RVA: 0x000FAFD8 File Offset: 0x000F91D8
	[Token(Token = "0x6002DD5")]
	[Address(RVA = "0x3A5EC0", Offset = "0x3A44C0", VA = "0x1803A5EC0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Day6;
	}

	// Token: 0x06002DD6 RID: 11734 RVA: 0x000FAFE8 File Offset: 0x000F91E8
	[Token(Token = "0x6002DD6")]
	[Address(RVA = "0x697F90", Offset = "0x696590", VA = "0x180697F90", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		advantureMission.level = (AdvantureLevel)((ulong)6L);
		AdvantureMission mission = advantureMission;
		Func<MissionResult> func;
		mission.target = func;
		AdvantureConfig.SetMissionDescription(mission, (AdvantureLevel)((uint)6));
		return mission;
	}

	// Token: 0x06002DD7 RID: 11735 RVA: 0x000FB048 File Offset: 0x000F9248
	[Token(Token = "0x6002DD7")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06002DD8 RID: 11736 RVA: 0x000FB058 File Offset: 0x000F9258
	[Token(Token = "0x6002DD8")]
	[Address(RVA = "0x698220", Offset = "0x696820", VA = "0x180698220", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		return list;
	}

	// Token: 0x06002DD9 RID: 11737 RVA: 0x000FB0A0 File Offset: 0x000F92A0
	[Token(Token = "0x6002DD9")]
	[Address(RVA = "0x3ABC00", Offset = "0x3AA200", VA = "0x1803ABC00", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Chomper;
	}

	// Token: 0x06002DDA RID: 11738 RVA: 0x000FB0B0 File Offset: 0x000F92B0
	[Token(Token = "0x6002DDA")]
	[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Day;
	}

	// Token: 0x06002DDB RID: 11739 RVA: 0x000FB0C8 File Offset: 0x000F92C8
	[Token(Token = "0x6002DDB")]
	[Address(RVA = "0x6980F0", Offset = "0x6966F0", VA = "0x1806980F0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉白天：第6关";
	}

	// Token: 0x06002DDC RID: 11740 RVA: 0x000FB0DC File Offset: 0x000F92DC
	[Token(Token = "0x6002DDC")]
	[Address(RVA = "0x6981A0", Offset = "0x6967A0", VA = "0x1806981A0", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "大嘴狂欢：在场上集齐豌豆、向日葵、樱桃炸弹、坚果墙、土豆雷的大嘴花融合体";
		}
		if (result == MissionResult.Second)
		{
			return "盛宴：使用任意大嘴花吞咽25只僵尸";
		}
		return string.Empty;
	}

	// Token: 0x06002DDD RID: 11741 RVA: 0x000FB104 File Offset: 0x000F9304
	[Token(Token = "0x6002DDD")]
	[Address(RVA = "0x698120", Offset = "0x696720", VA = "0x180698120", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "所有的大嘴花咀嚼速度+50%";
		}
		if (result == MissionResult.Second)
		{
			return "大嘴花的攻击范围+100%";
		}
		return string.Empty;
	}

	// Token: 0x06002DDE RID: 11742 RVA: 0x000FB12C File Offset: 0x000F932C
	[Token(Token = "0x6002DDE")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public Day6Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
