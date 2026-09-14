using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200090A RID: 2314
[Token(Token = "0x200090A")]
public class NightPool6Strategy : BaseLevelStrategy
{
	// Token: 0x06002F64 RID: 12132 RVA: 0x000FEEB8 File Offset: 0x000FD0B8
	[Token(Token = "0x6002F64")]
	[Address(RVA = "0x69D930", Offset = "0x69BF30", VA = "0x18069D930", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.NightPool6;
	}

	// Token: 0x06002F65 RID: 12133 RVA: 0x000FEEC8 File Offset: 0x000FD0C8
	[Token(Token = "0x6002F65")]
	[Address(RVA = "0x69DA40", Offset = "0x69C040", VA = "0x18069DA40", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		return list;
	}

	// Token: 0x06002F66 RID: 12134 RVA: 0x000FEF14 File Offset: 0x000FD114
	[Token(Token = "0x6002F66")]
	[Address(RVA = "0x69C990", Offset = "0x69AF90", VA = "0x18069C990", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Cactus;
	}

	// Token: 0x06002F67 RID: 12135 RVA: 0x000FEF24 File Offset: 0x000FD124
	[Token(Token = "0x6002F67")]
	[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.NightPool;
	}

	// Token: 0x06002F68 RID: 12136 RVA: 0x000FEF34 File Offset: 0x000FD134
	[Token(Token = "0x6002F68")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06002F69 RID: 12137 RVA: 0x000FEF44 File Offset: 0x000FD144
	[Token(Token = "0x6002F69")]
	[Address(RVA = "0x69D900", Offset = "0x69BF00", VA = "0x18069D900", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉迷雾：第6关";
	}

	// Token: 0x06002F6A RID: 12138 RVA: 0x000FEF58 File Offset: 0x000FD158
	[Token(Token = "0x6002F6A")]
	[Address(RVA = "0x69D9C0", Offset = "0x69BFC0", VA = "0x18069D9C0", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "爆炸保护：小丑王爆炸次数不能超过1次";
		}
		if (result == MissionResult.Second)
		{
			return "保护IV：提交6个原版南瓜头";
		}
		return string.Empty;
	}

	// Token: 0x06002F6B RID: 12139 RVA: 0x000FEF80 File Offset: 0x000FD180
	[Token(Token = "0x6002F6B")]
	[Address(RVA = "0x69D940", Offset = "0x69BF40", VA = "0x18069D940", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "小丑爆炸伤害降低至5000，且不再伤害南瓜里的植物";
		}
		if (result == MissionResult.Second)
		{
			return "南瓜植物获得30%伤害减免";
		}
		return string.Empty;
	}

	// Token: 0x06002F6C RID: 12140 RVA: 0x000FEFA8 File Offset: 0x000FD1A8
	[Token(Token = "0x6002F6C")]
	[Address(RVA = "0x69D750", Offset = "0x69BD50", VA = "0x18069D750", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		advantureMission.board = board;
		AdvantureLevel level = this.GetLevel();
		advantureMission.level = level;
		advantureMission.endResult = (MissionResult)((ulong)1L);
		AdvantureMission mission = advantureMission;
		Func<MissionResult> func;
		mission.target = func;
		AdvantureConfig.SubmitPlantConfig(mission, (PlantType)((uint)24), 6, (MissionResult)((uint)2));
		AdvantureMission mission2 = mission;
		AdvantureLevel level2 = this.GetLevel();
		return mission;
	}

	// Token: 0x06002F6D RID: 12141 RVA: 0x000FF024 File Offset: 0x000FD224
	[Token(Token = "0x6002F6D")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public NightPool6Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
