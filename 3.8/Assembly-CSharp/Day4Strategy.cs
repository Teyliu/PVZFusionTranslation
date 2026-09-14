using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020008C9 RID: 2249
[Token(Token = "0x20008C9")]
public class Day4Strategy : BaseLevelStrategy
{
	// Token: 0x06002DBA RID: 11706 RVA: 0x000FAC0C File Offset: 0x000F8E0C
	[Token(Token = "0x6002DBA")]
	[Address(RVA = "0x3AD3E0", Offset = "0x3AB9E0", VA = "0x1803AD3E0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Day4;
	}

	// Token: 0x06002DBB RID: 11707 RVA: 0x000FAC1C File Offset: 0x000F8E1C
	[Token(Token = "0x6002DBB")]
	[Address(RVA = "0x697790", Offset = "0x695D90", VA = "0x180697790", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		advantureMission.level = (AdvantureLevel)((ulong)4L);
		Func<MissionResult> func;
		advantureMission.target = func;
		AdvantureConfig.SubmitPlantConfig(advantureMission, (PlantType)((uint)1003), 5, (MissionResult)((uint)2));
		AdvantureConfig.SetMissionDescription(advantureMission, (AdvantureLevel)((uint)4));
		return advantureMission;
	}

	// Token: 0x06002DBC RID: 11708 RVA: 0x000FAC74 File Offset: 0x000F8E74
	[Token(Token = "0x6002DBC")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06002DBD RID: 11709 RVA: 0x000FAC84 File Offset: 0x000F8E84
	[Token(Token = "0x6002DBD")]
	[Address(RVA = "0x697A20", Offset = "0x696020", VA = "0x180697A20", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		return list;
	}

	// Token: 0x06002DBE RID: 11710 RVA: 0x000FACCC File Offset: 0x000F8ECC
	[Token(Token = "0x6002DBE")]
	[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.WallNut;
	}

	// Token: 0x06002DBF RID: 11711 RVA: 0x000FACDC File Offset: 0x000F8EDC
	[Token(Token = "0x6002DBF")]
	[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Day;
	}

	// Token: 0x06002DC0 RID: 11712 RVA: 0x000FACF4 File Offset: 0x000F8EF4
	[Token(Token = "0x6002DC0")]
	[Address(RVA = "0x6978F0", Offset = "0x695EF0", VA = "0x1806978F0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉白天：第4关";
	}

	// Token: 0x06002DC1 RID: 11713 RVA: 0x000FAD08 File Offset: 0x000F8F08
	[Token(Token = "0x6002DC1")]
	[Address(RVA = "0x6979A0", Offset = "0x695FA0", VA = "0x1806979A0", Slot = "32")]
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

	// Token: 0x06002DC2 RID: 11714 RVA: 0x000FAD34 File Offset: 0x000F8F34
	[Token(Token = "0x6002DC2")]
	[Address(RVA = "0x697920", Offset = "0x695F20", VA = "0x180697920", Slot = "33")]
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

	// Token: 0x06002DC3 RID: 11715 RVA: 0x000FAD5C File Offset: 0x000F8F5C
	[Token(Token = "0x6002DC3")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public Day4Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
