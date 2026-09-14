using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200096E RID: 2414
[Token(Token = "0x200096E")]
public class Snow6Strategy : BaseLevelStrategy
{
	// Token: 0x0600319D RID: 12701 RVA: 0x00106464 File Offset: 0x00104664
	[Token(Token = "0x600319D")]
	[Address(RVA = "0x51FE30", Offset = "0x51E430", VA = "0x18051FE30", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Snow6;
	}

	// Token: 0x0600319E RID: 12702 RVA: 0x00106474 File Offset: 0x00104674
	[Token(Token = "0x600319E")]
	[Address(RVA = "0x725A70", Offset = "0x724070", VA = "0x180725A70", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		int size5 = list._size;
		return list;
	}

	// Token: 0x0600319F RID: 12703 RVA: 0x001064C8 File Offset: 0x001046C8
	[Token(Token = "0x600319F")]
	[Address(RVA = "0x716B30", Offset = "0x715130", VA = "0x180716B30", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Bamboo;
	}

	// Token: 0x060031A0 RID: 12704 RVA: 0x001064D8 File Offset: 0x001046D8
	[Token(Token = "0x60031A0")]
	[Address(RVA = "0x715C90", Offset = "0x714290", VA = "0x180715C90", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Snow;
	}

	// Token: 0x060031A1 RID: 12705 RVA: 0x001064E8 File Offset: 0x001046E8
	[Token(Token = "0x60031A1")]
	[Address(RVA = "0x725940", Offset = "0x723F40", VA = "0x180725940", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉雪原：第6关";
	}

	// Token: 0x060031A2 RID: 12706 RVA: 0x001064FC File Offset: 0x001046FC
	[Token(Token = "0x60031A2")]
	[Address(RVA = "0x7259F0", Offset = "0x723FF0", VA = "0x1807259F0", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "竹阵坚守：累计击杀30个僵尸";
		}
		if (result == MissionResult.Second)
		{
			return "竹海战术：提交5株钢竹";
		}
		return string.Empty;
	}

	// Token: 0x060031A3 RID: 12707 RVA: 0x00106524 File Offset: 0x00104724
	[Token(Token = "0x60031A3")]
	[Address(RVA = "0x725970", Offset = "0x723F70", VA = "0x180725970", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "冬笋植物的血量翻倍";
		}
		if (result == MissionResult.Second)
		{
			return "钢叶冬笋的护盾量x3";
		}
		return string.Empty;
	}

	// Token: 0x060031A4 RID: 12708 RVA: 0x0010654C File Offset: 0x0010474C
	[Token(Token = "0x60031A4")]
	[Address(RVA = "0x725750", Offset = "0x723D50", VA = "0x180725750", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		AdvantureLevel level = this.GetLevel();
		advantureMission.level = level;
		advantureMission.single = true;
		Func<ValueTuple<MissionResult, int>> func;
		advantureMission.onSubmit = func;
		AdvantureMission mission = advantureMission;
		AdvantureMission mission3 = mission;
		Func<MissionResult> func2 = delegate
		{
			bool flag = mission.count >= 30;
			throw new NullReferenceException();
		};
		mission3.target = func2;
		AdvantureMission mission2 = mission;
		AdvantureLevel level2 = this.GetLevel();
		return mission;
	}

	// Token: 0x060031A5 RID: 12709 RVA: 0x001065D4 File Offset: 0x001047D4
	[Token(Token = "0x60031A5")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x060031A6 RID: 12710 RVA: 0x001065E4 File Offset: 0x001047E4
	[Token(Token = "0x60031A6")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Snow6Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
