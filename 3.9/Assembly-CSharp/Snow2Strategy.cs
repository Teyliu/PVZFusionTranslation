using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000966 RID: 2406
[Token(Token = "0x2000966")]
public class Snow2Strategy : BaseLevelStrategy
{
	// Token: 0x0600316C RID: 12652 RVA: 0x00105B80 File Offset: 0x00103D80
	[Token(Token = "0x600316C")]
	[Address(RVA = "0x524F50", Offset = "0x523550", VA = "0x180524F50", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Snow2;
	}

	// Token: 0x0600316D RID: 12653 RVA: 0x00105B90 File Offset: 0x00103D90
	[Token(Token = "0x600316D")]
	[Address(RVA = "0x724660", Offset = "0x722C60", VA = "0x180724660", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		return list;
	}

	// Token: 0x0600316E RID: 12654 RVA: 0x00105BD8 File Offset: 0x00103DD8
	[Token(Token = "0x600316E")]
	[Address(RVA = "0x71E620", Offset = "0x71CC20", VA = "0x18071E620", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.SpruceShooter;
	}

	// Token: 0x0600316F RID: 12655 RVA: 0x00105BE8 File Offset: 0x00103DE8
	[Token(Token = "0x600316F")]
	[Address(RVA = "0x715C90", Offset = "0x714290", VA = "0x180715C90", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Snow;
	}

	// Token: 0x06003170 RID: 12656 RVA: 0x00105BF8 File Offset: 0x00103DF8
	[Token(Token = "0x6003170")]
	[Address(RVA = "0x724530", Offset = "0x722B30", VA = "0x180724530", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉雪原：第2关";
	}

	// Token: 0x06003171 RID: 12657 RVA: 0x00105C0C File Offset: 0x00103E0C
	[Token(Token = "0x6003171")]
	[Address(RVA = "0x7245E0", Offset = "0x722BE0", VA = "0x1807245E0", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "云杉林立：种植10株云杉弓手";
		}
		if (result == MissionResult.Second)
		{
			return "火力全开：使用云杉弓手对僵尸造成30000点伤害";
		}
		return string.Empty;
	}

	// Token: 0x06003172 RID: 12658 RVA: 0x00105C34 File Offset: 0x00103E34
	[Token(Token = "0x6003172")]
	[Address(RVA = "0x724560", Offset = "0x722B60", VA = "0x180724560", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "云杉弓手的价格降低50";
		}
		if (result == MissionResult.Second)
		{
			return "云杉弓手获得30%独立伤害增幅";
		}
		return string.Empty;
	}

	// Token: 0x06003173 RID: 12659 RVA: 0x00105C5C File Offset: 0x00103E5C
	[Token(Token = "0x6003173")]
	[Address(RVA = "0x7243B0", Offset = "0x7229B0", VA = "0x1807243B0", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		AdvantureLevel level = this.GetLevel();
		advantureMission.level = level;
		Func<MissionResult> func = delegate
		{
			Board board3 = board;
			int num = 0;
			if (Lawnf.GetPlantCount((PlantType)((uint)36), board3) < 10)
			{
				if (board.damageReporter.ReportDic.TryGetValue((uint)36, num))
				{
				}
			}
			return MissionResult.First;
		};
		advantureMission.target = func;
		AdvantureLevel level2 = this.GetLevel();
		return advantureMission;
	}

	// Token: 0x06003174 RID: 12660 RVA: 0x00105CB8 File Offset: 0x00103EB8
	[Token(Token = "0x6003174")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06003175 RID: 12661 RVA: 0x00105CC8 File Offset: 0x00103EC8
	[Token(Token = "0x6003175")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Snow2Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
