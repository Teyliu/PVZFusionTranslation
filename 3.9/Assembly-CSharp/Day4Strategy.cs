using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000905 RID: 2309
[Token(Token = "0x2000905")]
public class Day4Strategy : BaseLevelStrategy
{
	// Token: 0x06002EED RID: 12013 RVA: 0x000FF708 File Offset: 0x000FD908
	[Token(Token = "0x6002EED")]
	[Address(RVA = "0x3F9250", Offset = "0x3F7850", VA = "0x1803F9250", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Day4;
	}

	// Token: 0x06002EEE RID: 12014 RVA: 0x000FF718 File Offset: 0x000FD918
	[Token(Token = "0x6002EEE")]
	[Address(RVA = "0x711890", Offset = "0x70FE90", VA = "0x180711890", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		advantureMission.level = (AdvantureLevel)((ulong)4L);
		Func<MissionResult> func = delegate
		{
			Board board3 = board;
			int num = 0;
			if (board3.damageReporter.ReportDic.TryGetValue((uint)1004, num))
			{
			}
			throw new NullReferenceException();
		};
		advantureMission.target = func;
		AdvantureConfig.SubmitPlantConfig(advantureMission, (PlantType)((uint)1003), 5, (MissionResult)((uint)2));
		AdvantureConfig.SetMissionDescription(advantureMission, (AdvantureLevel)((uint)4));
		return advantureMission;
	}

	// Token: 0x06002EEF RID: 12015 RVA: 0x000FF77C File Offset: 0x000FD97C
	[Token(Token = "0x6002EEF")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06002EF0 RID: 12016 RVA: 0x000FF78C File Offset: 0x000FD98C
	[Token(Token = "0x6002EF0")]
	[Address(RVA = "0x711B20", Offset = "0x710120", VA = "0x180711B20", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		return list;
	}

	// Token: 0x06002EF1 RID: 12017 RVA: 0x000FF7D4 File Offset: 0x000FD9D4
	[Token(Token = "0x6002EF1")]
	[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.WallNut;
	}

	// Token: 0x06002EF2 RID: 12018 RVA: 0x000FF7E4 File Offset: 0x000FD9E4
	[Token(Token = "0x6002EF2")]
	[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Day;
	}

	// Token: 0x06002EF3 RID: 12019 RVA: 0x000FF7FC File Offset: 0x000FD9FC
	[Token(Token = "0x6002EF3")]
	[Address(RVA = "0x7119F0", Offset = "0x70FFF0", VA = "0x1807119F0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉白天：第4关";
	}

	// Token: 0x06002EF4 RID: 12020 RVA: 0x000FF810 File Offset: 0x000FDA10
	[Token(Token = "0x6002EF4")]
	[Address(RVA = "0x711AA0", Offset = "0x7100A0", VA = "0x180711AA0", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "破坏者：使用豌豆坚果造成10000点伤害（可以在暂停界面-统计数据查看已造成伤害）";
		}
		if (result == MissionResult.Second)
		{
			return "居安思危：提交5个樱桃坚果";
		}
		return string.Empty;
	}

	// Token: 0x06002EF5 RID: 12021 RVA: 0x000FF838 File Offset: 0x000FDA38
	[Token(Token = "0x6002EF5")]
	[Address(RVA = "0x711A20", Offset = "0x710020", VA = "0x180711A20", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "坚果类植物获得100%伤害加成";
		}
		if (result == MissionResult.Second)
		{
			return "僵尸的爆炸樱桃子弹伤害降至300，且不再溅射";
		}
		return string.Empty;
	}

	// Token: 0x06002EF6 RID: 12022 RVA: 0x000FF860 File Offset: 0x000FDA60
	[Token(Token = "0x6002EF6")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Day4Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
