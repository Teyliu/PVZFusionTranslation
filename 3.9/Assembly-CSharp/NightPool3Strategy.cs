using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using GameLevel;

// Token: 0x02000940 RID: 2368
[Token(Token = "0x2000940")]
public class NightPool3Strategy : BaseLevelStrategy
{
	// Token: 0x0600306F RID: 12399 RVA: 0x00103454 File Offset: 0x00101654
	[Token(Token = "0x600306F")]
	[Address(RVA = "0x716B30", Offset = "0x715130", VA = "0x180716B30", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.NightPool3;
	}

	// Token: 0x06003070 RID: 12400 RVA: 0x00103464 File Offset: 0x00101664
	[Token(Token = "0x6003070")]
	[Address(RVA = "0x716C40", Offset = "0x715240", VA = "0x180716C40", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		return list;
	}

	// Token: 0x06003071 RID: 12401 RVA: 0x001034B0 File Offset: 0x001016B0
	[Token(Token = "0x6003071")]
	[Address(RVA = "0x716AF0", Offset = "0x7150F0", VA = "0x180716AF0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Cactus;
	}

	// Token: 0x06003072 RID: 12402 RVA: 0x001034C0 File Offset: 0x001016C0
	[Token(Token = "0x6003072")]
	[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.NightPool;
	}

	// Token: 0x06003073 RID: 12403 RVA: 0x001034D0 File Offset: 0x001016D0
	[Token(Token = "0x6003073")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06003074 RID: 12404 RVA: 0x001034E0 File Offset: 0x001016E0
	[Token(Token = "0x6003074")]
	[Address(RVA = "0x716B00", Offset = "0x715100", VA = "0x180716B00", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉迷雾：第3关";
	}

	// Token: 0x06003075 RID: 12405 RVA: 0x001034F4 File Offset: 0x001016F4
	[Token(Token = "0x6003075")]
	[Address(RVA = "0x716BC0", Offset = "0x7151C0", VA = "0x180716BC0", Slot = "32")]
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

	// Token: 0x06003076 RID: 12406 RVA: 0x0010351C File Offset: 0x0010171C
	[Token(Token = "0x6003076")]
	[Address(RVA = "0x716B40", Offset = "0x715140", VA = "0x180716B40", Slot = "33")]
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

	// Token: 0x06003077 RID: 12407 RVA: 0x00103544 File Offset: 0x00101744
	[Token(Token = "0x6003077")]
	[Address(RVA = "0x716950", Offset = "0x714F50", VA = "0x180716950", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		AdvantureLevel level = this.GetLevel();
		advantureMission.level = level;
		advantureMission.endResult = (MissionResult)((ulong)1L);
		AdvantureMission mission = advantureMission;
		AdvantureMission mission3 = mission;
		Func<Zombie, bool> <>9__1;
		Func<MissionResult> func = delegate
		{
			int num = 0;
			List<Zombie> allZombies = Lawnf.GetAllZombies(false);
			Func<Zombie, bool> <>9__ = <>9__1;
			if (<>9__ == 0)
			{
				Func<Zombie, bool> func2 = delegate(Zombie z)
				{
					int column = z.Column;
					BoardConfig config = board.config;
					return column < config.redLineColumn;
				};
				<>9__1 = func2;
			}
			if (Enumerable.FirstOrDefault<Zombie>(Enumerable.Where<Zombie>(allZombies, <>9__)))
			{
				mission.endResult = (MissionResult)num;
			}
			if (board.damageReporter.ReportDic.TryGetValue((uint)1079, num))
			{
			}
			throw new NullReferenceException();
		};
		mission3.target = func;
		AdvantureMission mission2 = mission;
		AdvantureLevel level2 = this.GetLevel();
		return mission;
	}

	// Token: 0x06003078 RID: 12408 RVA: 0x001035C8 File Offset: 0x001017C8
	[Token(Token = "0x6003078")]
	[Address(RVA = "0x716E10", Offset = "0x715410", VA = "0x180716E10", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.SetRedLine(5);
	}

	// Token: 0x06003079 RID: 12409 RVA: 0x001035E4 File Offset: 0x001017E4
	[Token(Token = "0x6003079")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public NightPool3Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
