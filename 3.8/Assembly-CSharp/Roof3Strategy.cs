using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000918 RID: 2328
[Token(Token = "0x2000918")]
public class Roof3Strategy : BaseLevelStrategy
{
	// Token: 0x06002FC0 RID: 12224 RVA: 0x000FFBBC File Offset: 0x000FDDBC
	[Token(Token = "0x6002FC0")]
	[Address(RVA = "0x6A6F10", Offset = "0x6A5510", VA = "0x1806A6F10", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Roof3;
	}

	// Token: 0x06002FC1 RID: 12225 RVA: 0x000FFBCC File Offset: 0x000FDDCC
	[Token(Token = "0x6002FC1")]
	[Address(RVA = "0x6A7020", Offset = "0x6A5620", VA = "0x1806A7020", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		return list;
	}

	// Token: 0x06002FC2 RID: 12226 RVA: 0x000FFC18 File Offset: 0x000FDE18
	[Token(Token = "0x6002FC2")]
	[Address(RVA = "0x6A1A60", Offset = "0x6A0060", VA = "0x1806A1A60", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Cornpult;
	}

	// Token: 0x06002FC3 RID: 12227 RVA: 0x000FFC28 File Offset: 0x000FDE28
	[Token(Token = "0x6002FC3")]
	[Address(RVA = "0x3AD3E0", Offset = "0x3AB9E0", VA = "0x1803AD3E0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Roof;
	}

	// Token: 0x06002FC4 RID: 12228 RVA: 0x000FFC38 File Offset: 0x000FDE38
	[Token(Token = "0x6002FC4")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06002FC5 RID: 12229 RVA: 0x000FFC48 File Offset: 0x000FDE48
	[Token(Token = "0x6002FC5")]
	[Address(RVA = "0x6A6EE0", Offset = "0x6A54E0", VA = "0x1806A6EE0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉屋顶：第3关";
	}

	// Token: 0x06002FC6 RID: 12230 RVA: 0x000FFC5C File Offset: 0x000FDE5C
	[Token(Token = "0x6002FC6")]
	[Address(RVA = "0x6A6FA0", Offset = "0x6A55A0", VA = "0x1806A6FA0", Slot = "32")]
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

	// Token: 0x06002FC7 RID: 12231 RVA: 0x000FFC84 File Offset: 0x000FDE84
	[Token(Token = "0x6002FC7")]
	[Address(RVA = "0x6A6F20", Offset = "0x6A5520", VA = "0x1806A6F20", Slot = "33")]
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

	// Token: 0x06002FC8 RID: 12232 RVA: 0x000FFCAC File Offset: 0x000FDEAC
	[Token(Token = "0x6002FC8")]
	[Address(RVA = "0x6A6D30", Offset = "0x6A5330", VA = "0x1806A6D30", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		advantureMission.board = board;
		AdvantureLevel level = this.GetLevel();
		advantureMission.level = level;
		AdvantureMission mission = advantureMission;
		Func<MissionResult> func;
		mission.target = func;
		AdvantureConfig.SubmitPlantConfig(mission, (PlantType)((uint)1113), 5, (MissionResult)((uint)2));
		AdvantureMission mission2 = mission;
		AdvantureLevel level2 = this.GetLevel();
		return mission;
	}

	// Token: 0x06002FC9 RID: 12233 RVA: 0x000FFD20 File Offset: 0x000FDF20
	[Token(Token = "0x6002FC9")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public Roof3Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
