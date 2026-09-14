using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000904 RID: 2308
[Token(Token = "0x2000904")]
public class NightPool3Strategy : BaseLevelStrategy
{
	// Token: 0x06002F3C RID: 12092 RVA: 0x000FE7FC File Offset: 0x000FC9FC
	[Token(Token = "0x6002F3C")]
	[Address(RVA = "0x69C9D0", Offset = "0x69AFD0", VA = "0x18069C9D0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.NightPool3;
	}

	// Token: 0x06002F3D RID: 12093 RVA: 0x000FE80C File Offset: 0x000FCA0C
	[Token(Token = "0x6002F3D")]
	[Address(RVA = "0x69CAE0", Offset = "0x69B0E0", VA = "0x18069CAE0", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		return list;
	}

	// Token: 0x06002F3E RID: 12094 RVA: 0x000FE858 File Offset: 0x000FCA58
	[Token(Token = "0x6002F3E")]
	[Address(RVA = "0x69C990", Offset = "0x69AF90", VA = "0x18069C990", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Cactus;
	}

	// Token: 0x06002F3F RID: 12095 RVA: 0x000FE868 File Offset: 0x000FCA68
	[Token(Token = "0x6002F3F")]
	[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.NightPool;
	}

	// Token: 0x06002F40 RID: 12096 RVA: 0x000FE878 File Offset: 0x000FCA78
	[Token(Token = "0x6002F40")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06002F41 RID: 12097 RVA: 0x000FE888 File Offset: 0x000FCA88
	[Token(Token = "0x6002F41")]
	[Address(RVA = "0x69C9A0", Offset = "0x69AFA0", VA = "0x18069C9A0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉迷雾：第3关";
	}

	// Token: 0x06002F42 RID: 12098 RVA: 0x000FE89C File Offset: 0x000FCA9C
	[Token(Token = "0x6002F42")]
	[Address(RVA = "0x69CA60", Offset = "0x69B060", VA = "0x18069CA60", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "别踩红线：不让僵尸越过红线";
		}
		if (result == MissionResult.Second)
		{
			return "流光射线：使用流光仙人掌造成40000点伤害";
		}
		return string.Empty;
	}

	// Token: 0x06002F43 RID: 12099 RVA: 0x000FE8C4 File Offset: 0x000FCAC4
	[Token(Token = "0x6002F43")]
	[Address(RVA = "0x69C9E0", Offset = "0x69AFE0", VA = "0x18069C9E0", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "高阶僵尸的血量降低20%";
		}
		if (result == MissionResult.Second)
		{
			return "激光对僵尸额外造成2%当前生命值的伤害";
		}
		return string.Empty;
	}

	// Token: 0x06002F44 RID: 12100 RVA: 0x000FE8EC File Offset: 0x000FCAEC
	[Token(Token = "0x6002F44")]
	[Address(RVA = "0x69C7F0", Offset = "0x69ADF0", VA = "0x18069C7F0", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		AdvantureLevel level = this.GetLevel();
		advantureMission.level = level;
		advantureMission.endResult = (MissionResult)((ulong)1L);
		AdvantureMission mission = advantureMission;
		Func<MissionResult> func;
		mission.target = func;
		AdvantureMission mission2 = mission;
		AdvantureLevel level2 = this.GetLevel();
		return mission;
	}

	// Token: 0x06002F45 RID: 12101 RVA: 0x000FE95C File Offset: 0x000FCB5C
	[Token(Token = "0x6002F45")]
	[Address(RVA = "0x69CCB0", Offset = "0x69B2B0", VA = "0x18069CCB0", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.SetRedLine(5);
	}

	// Token: 0x06002F46 RID: 12102 RVA: 0x000FE978 File Offset: 0x000FCB78
	[Token(Token = "0x6002F46")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public NightPool3Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
