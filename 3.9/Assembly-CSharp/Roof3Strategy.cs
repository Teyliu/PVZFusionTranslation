using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000954 RID: 2388
[Token(Token = "0x2000954")]
public class Roof3Strategy : BaseLevelStrategy
{
	// Token: 0x060030F3 RID: 12531 RVA: 0x00104894 File Offset: 0x00102A94
	[Token(Token = "0x60030F3")]
	[Address(RVA = "0x721070", Offset = "0x71F670", VA = "0x180721070", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Roof3;
	}

	// Token: 0x060030F4 RID: 12532 RVA: 0x001048A4 File Offset: 0x00102AA4
	[Token(Token = "0x60030F4")]
	[Address(RVA = "0x721180", Offset = "0x71F780", VA = "0x180721180", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		return list;
	}

	// Token: 0x060030F5 RID: 12533 RVA: 0x001048F0 File Offset: 0x00102AF0
	[Token(Token = "0x60030F5")]
	[Address(RVA = "0x71BBC0", Offset = "0x71A1C0", VA = "0x18071BBC0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Cornpult;
	}

	// Token: 0x060030F6 RID: 12534 RVA: 0x00104900 File Offset: 0x00102B00
	[Token(Token = "0x60030F6")]
	[Address(RVA = "0x3F9250", Offset = "0x3F7850", VA = "0x1803F9250", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Roof;
	}

	// Token: 0x060030F7 RID: 12535 RVA: 0x00104910 File Offset: 0x00102B10
	[Token(Token = "0x60030F7")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x060030F8 RID: 12536 RVA: 0x00104920 File Offset: 0x00102B20
	[Token(Token = "0x60030F8")]
	[Address(RVA = "0x721040", Offset = "0x71F640", VA = "0x180721040", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉屋顶：第3关";
	}

	// Token: 0x060030F9 RID: 12537 RVA: 0x00104934 File Offset: 0x00102B34
	[Token(Token = "0x60030F9")]
	[Address(RVA = "0x721100", Offset = "0x71F700", VA = "0x180721100", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "黄油大师：使用黄油定身50次僵尸";
		}
		if (result == MissionResult.Second)
		{
			return "弹射研究：提交5个玉米卷投手";
		}
		return string.Empty;
	}

	// Token: 0x060030FA RID: 12538 RVA: 0x0010495C File Offset: 0x00102B5C
	[Token(Token = "0x60030FA")]
	[Address(RVA = "0x721080", Offset = "0x71F680", VA = "0x180721080", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "黄油定身时间延长20%";
		}
		if (result == MissionResult.Second)
		{
			return "玉米卷的弹射次数+4";
		}
		return string.Empty;
	}

	// Token: 0x060030FB RID: 12539 RVA: 0x00104984 File Offset: 0x00102B84
	[Token(Token = "0x60030FB")]
	[Address(RVA = "0x720E90", Offset = "0x71F490", VA = "0x180720E90", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		advantureMission.board = board;
		AdvantureLevel level = this.GetLevel();
		advantureMission.level = level;
		AdvantureMission mission = advantureMission;
		AdvantureMission mission3 = mission;
		Func<MissionResult> func = delegate
		{
			bool flag = mission.count >= 50;
			throw new NullReferenceException();
		};
		mission3.target = func;
		AdvantureConfig.SubmitPlantConfig(mission, (PlantType)((uint)1113), 5, (MissionResult)((uint)2));
		AdvantureMission mission2 = mission;
		AdvantureLevel level2 = this.GetLevel();
		return mission;
	}

	// Token: 0x060030FC RID: 12540 RVA: 0x00104A08 File Offset: 0x00102C08
	[Token(Token = "0x60030FC")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Roof3Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
