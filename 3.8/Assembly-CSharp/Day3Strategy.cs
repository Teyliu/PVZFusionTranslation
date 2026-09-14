using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020008C7 RID: 2247
[Token(Token = "0x20008C7")]
public class Day3Strategy : BaseLevelStrategy
{
	// Token: 0x06002DAE RID: 11694 RVA: 0x000FA9E8 File Offset: 0x000F8BE8
	[Token(Token = "0x6002DAE")]
	[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Day3;
	}

	// Token: 0x06002DAF RID: 11695 RVA: 0x000FA9F8 File Offset: 0x000F8BF8
	[Token(Token = "0x6002DAF")]
	[Address(RVA = "0x6973B0", Offset = "0x6959B0", VA = "0x1806973B0", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		advantureMission.level = (AdvantureLevel)((ulong)3L);
		advantureMission.timer = -1f;
		AdvantureMission mission = advantureMission;
		AdvantureMission mission2 = mission;
		float startSun = 0f;
		Func<MissionResult> func;
		mission2.target = func;
		AdvantureConfig.SubmitPlantConfig(mission, (PlantType)((uint)1017), 3, (MissionResult)((uint)2));
		AdvantureConfig.SetMissionDescription(mission, (AdvantureLevel)((uint)3));
		return mission;
	}

	// Token: 0x06002DB0 RID: 11696 RVA: 0x000FAA84 File Offset: 0x000F8C84
	[Token(Token = "0x6002DB0")]
	[Address(RVA = "0x3AA5A0", Offset = "0x3A8BA0", VA = "0x1803AA5A0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 10;
	}

	// Token: 0x06002DB1 RID: 11697 RVA: 0x000FAA94 File Offset: 0x000F8C94
	[Token(Token = "0x6002DB1")]
	[Address(RVA = "0x697670", Offset = "0x695C70", VA = "0x180697670", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		return list;
	}

	// Token: 0x06002DB2 RID: 11698 RVA: 0x000FAAD4 File Offset: 0x000F8CD4
	[Token(Token = "0x6002DB2")]
	[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.SunFlower;
	}

	// Token: 0x06002DB3 RID: 11699 RVA: 0x000FAAE4 File Offset: 0x000F8CE4
	[Token(Token = "0x6002DB3")]
	[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Day;
	}

	// Token: 0x06002DB4 RID: 11700 RVA: 0x000FAAFC File Offset: 0x000F8CFC
	[Token(Token = "0x6002DB4")]
	[Address(RVA = "0x697540", Offset = "0x695B40", VA = "0x180697540", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉白天：第3关";
	}

	// Token: 0x06002DB5 RID: 11701 RVA: 0x000FAB10 File Offset: 0x000F8D10
	[Token(Token = "0x6002DB5")]
	[Address(RVA = "0x6975F0", Offset = "0x695BF0", VA = "0x1806975F0", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "极速制备：在1秒内获得250阳光";
		}
		if (result == MissionResult.Second)
		{
			return "樱桃研究：提交3个樱桃机枪射手";
		}
		return string.Empty;
	}

	// Token: 0x06002DB6 RID: 11702 RVA: 0x000FAB38 File Offset: 0x000F8D38
	[Token(Token = "0x6002DB6")]
	[Address(RVA = "0x697570", Offset = "0x695B70", VA = "0x180697570", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "阳光炸弹的阳光产量永久x3";
		}
		if (result == MissionResult.Second)
		{
			return "樱桃子弹击中僵尸时有概率释放小樱桃爆炸";
		}
		return string.Empty;
	}

	// Token: 0x06002DB7 RID: 11703 RVA: 0x000FAB60 File Offset: 0x000F8D60
	[Token(Token = "0x6002DB7")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public Day3Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
