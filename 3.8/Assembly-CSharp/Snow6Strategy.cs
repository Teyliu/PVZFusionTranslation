using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000932 RID: 2354
[Token(Token = "0x2000932")]
public class Snow6Strategy : BaseLevelStrategy
{
	// Token: 0x0600306A RID: 12394 RVA: 0x001016D8 File Offset: 0x000FF8D8
	[Token(Token = "0x600306A")]
	[Address(RVA = "0x4A0180", Offset = "0x49E780", VA = "0x1804A0180", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Snow6;
	}

	// Token: 0x0600306B RID: 12395 RVA: 0x001016E8 File Offset: 0x000FF8E8
	[Token(Token = "0x600306B")]
	[Address(RVA = "0x6AB900", Offset = "0x6A9F00", VA = "0x1806AB900", Slot = "24")]
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

	// Token: 0x0600306C RID: 12396 RVA: 0x0010173C File Offset: 0x000FF93C
	[Token(Token = "0x600306C")]
	[Address(RVA = "0x69C9D0", Offset = "0x69AFD0", VA = "0x18069C9D0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Bamboo;
	}

	// Token: 0x0600306D RID: 12397 RVA: 0x0010174C File Offset: 0x000FF94C
	[Token(Token = "0x600306D")]
	[Address(RVA = "0x69BB30", Offset = "0x69A130", VA = "0x18069BB30", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Snow;
	}

	// Token: 0x0600306E RID: 12398 RVA: 0x0010175C File Offset: 0x000FF95C
	[Token(Token = "0x600306E")]
	[Address(RVA = "0x6AB7D0", Offset = "0x6A9DD0", VA = "0x1806AB7D0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉雪原：第6关";
	}

	// Token: 0x0600306F RID: 12399 RVA: 0x00101770 File Offset: 0x000FF970
	[Token(Token = "0x600306F")]
	[Address(RVA = "0x6AB880", Offset = "0x6A9E80", VA = "0x1806AB880", Slot = "32")]
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

	// Token: 0x06003070 RID: 12400 RVA: 0x00101798 File Offset: 0x000FF998
	[Token(Token = "0x6003070")]
	[Address(RVA = "0x6AB800", Offset = "0x6A9E00", VA = "0x1806AB800", Slot = "33")]
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

	// Token: 0x06003071 RID: 12401 RVA: 0x001017C0 File Offset: 0x000FF9C0
	[Token(Token = "0x6003071")]
	[Address(RVA = "0x6AB5E0", Offset = "0x6A9BE0", VA = "0x1806AB5E0", Slot = "22")]
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
		Func<MissionResult> func2;
		mission.target = func2;
		AdvantureMission mission2 = mission;
		AdvantureLevel level2 = this.GetLevel();
		return mission;
	}

	// Token: 0x06003072 RID: 12402 RVA: 0x00101838 File Offset: 0x000FFA38
	[Token(Token = "0x6003072")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06003073 RID: 12403 RVA: 0x00101848 File Offset: 0x000FFA48
	[Token(Token = "0x6003073")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public Snow6Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
