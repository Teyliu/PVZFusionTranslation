using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000933 RID: 2355
[Token(Token = "0x2000933")]
public class Pool6Strategy : BaseLevelStrategy
{
	// Token: 0x06003014 RID: 12308 RVA: 0x0010241C File Offset: 0x0010061C
	[Token(Token = "0x6003014")]
	[Address(RVA = "0x712FE0", Offset = "0x7115E0", VA = "0x180712FE0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Pool6;
	}

	// Token: 0x06003015 RID: 12309 RVA: 0x0010242C File Offset: 0x0010062C
	[Token(Token = "0x6003015")]
	[Address(RVA = "0x71C540", Offset = "0x71AB40", VA = "0x18071C540", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		return list;
	}

	// Token: 0x06003016 RID: 12310 RVA: 0x00102478 File Offset: 0x00100678
	[Token(Token = "0x6003016")]
	[Address(RVA = "0x715870", Offset = "0x713E70", VA = "0x180715870", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Caltrop;
	}

	// Token: 0x06003017 RID: 12311 RVA: 0x00102488 File Offset: 0x00100688
	[Token(Token = "0x6003017")]
	[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Pool;
	}

	// Token: 0x06003018 RID: 12312 RVA: 0x00102498 File Offset: 0x00100698
	[Token(Token = "0x6003018")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06003019 RID: 12313 RVA: 0x001024A8 File Offset: 0x001006A8
	[Token(Token = "0x6003019")]
	[Address(RVA = "0x71C410", Offset = "0x71AA10", VA = "0x18071C410", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉泳池：第6关";
	}

	// Token: 0x0600301A RID: 12314 RVA: 0x001024BC File Offset: 0x001006BC
	[Token(Token = "0x600301A")]
	[Address(RVA = "0x71C4C0", Offset = "0x71AAC0", VA = "0x18071C4C0", Slot = "32")]
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

	// Token: 0x0600301B RID: 12315 RVA: 0x001024E4 File Offset: 0x001006E4
	[Token(Token = "0x600301B")]
	[Address(RVA = "0x71C440", Offset = "0x71AA40", VA = "0x18071C440", Slot = "33")]
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

	// Token: 0x0600301C RID: 12316 RVA: 0x0010250C File Offset: 0x0010070C
	[Token(Token = "0x600301C")]
	[Address(RVA = "0x71C270", Offset = "0x71A870", VA = "0x18071C270", Slot = "22")]
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
			if (board3.damageReporter.ReportDic.TryGetValue((uint)1063, num))
			{
			}
			throw new NullReferenceException();
		};
		advantureMission.target = func;
		AdvantureConfig.SubmitPlantConfig(advantureMission, (PlantType)((uint)1064), 3, (MissionResult)((uint)2));
		AdvantureLevel level2 = this.GetLevel();
		return advantureMission;
	}

	// Token: 0x0600301D RID: 12317 RVA: 0x00102578 File Offset: 0x00100778
	[Token(Token = "0x600301D")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Pool6Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
