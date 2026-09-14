using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020008F7 RID: 2295
[Token(Token = "0x20008F7")]
public class Pool6Strategy : BaseLevelStrategy
{
	// Token: 0x06002EE1 RID: 12001 RVA: 0x000FD7DC File Offset: 0x000FB9DC
	[Token(Token = "0x6002EE1")]
	[Address(RVA = "0x698EE0", Offset = "0x6974E0", VA = "0x180698EE0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Pool6;
	}

	// Token: 0x06002EE2 RID: 12002 RVA: 0x000FD7EC File Offset: 0x000FB9EC
	[Token(Token = "0x6002EE2")]
	[Address(RVA = "0x6A23E0", Offset = "0x6A09E0", VA = "0x1806A23E0", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		return list;
	}

	// Token: 0x06002EE3 RID: 12003 RVA: 0x000FD838 File Offset: 0x000FBA38
	[Token(Token = "0x6002EE3")]
	[Address(RVA = "0x69B710", Offset = "0x699D10", VA = "0x18069B710", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Caltrop;
	}

	// Token: 0x06002EE4 RID: 12004 RVA: 0x000FD848 File Offset: 0x000FBA48
	[Token(Token = "0x6002EE4")]
	[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Pool;
	}

	// Token: 0x06002EE5 RID: 12005 RVA: 0x000FD858 File Offset: 0x000FBA58
	[Token(Token = "0x6002EE5")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06002EE6 RID: 12006 RVA: 0x000FD868 File Offset: 0x000FBA68
	[Token(Token = "0x6002EE6")]
	[Address(RVA = "0x6A22B0", Offset = "0x6A08B0", VA = "0x1806A22B0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉泳池：第6关";
	}

	// Token: 0x06002EE7 RID: 12007 RVA: 0x000FD87C File Offset: 0x000FBA7C
	[Token(Token = "0x6002EE7")]
	[Address(RVA = "0x6A2360", Offset = "0x6A0960", VA = "0x1806A2360", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "禁止通行：使用窝刺对僵尸造成10000点伤害";
		}
		if (result == MissionResult.Second)
		{
			return "载具杀手：提交3株三线地刺";
		}
		return string.Empty;
	}

	// Token: 0x06002EE8 RID: 12008 RVA: 0x000FD8A4 File Offset: 0x000FBAA4
	[Token(Token = "0x6002EE8")]
	[Address(RVA = "0x6A22E0", Offset = "0x6A08E0", VA = "0x1806A22E0", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "窝刺的击退效果+20%";
		}
		if (result == MissionResult.Second)
		{
			return "三线地刺对车的伤害增加100%";
		}
		return string.Empty;
	}

	// Token: 0x06002EE9 RID: 12009 RVA: 0x000FD8CC File Offset: 0x000FBACC
	[Token(Token = "0x6002EE9")]
	[Address(RVA = "0x6A2110", Offset = "0x6A0710", VA = "0x1806A2110", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		AdvantureLevel level = this.GetLevel();
		advantureMission.level = level;
		Func<MissionResult> func;
		advantureMission.target = func;
		AdvantureConfig.SubmitPlantConfig(advantureMission, (PlantType)((uint)1064), 3, (MissionResult)((uint)2));
		AdvantureLevel level2 = this.GetLevel();
		return advantureMission;
	}

	// Token: 0x06002EEA RID: 12010 RVA: 0x000FD92C File Offset: 0x000FBB2C
	[Token(Token = "0x6002EEA")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public Pool6Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
