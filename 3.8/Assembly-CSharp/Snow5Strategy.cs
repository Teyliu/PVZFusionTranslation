using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000930 RID: 2352
[Token(Token = "0x2000930")]
public class Snow5Strategy : BaseLevelStrategy
{
	// Token: 0x0600305D RID: 12381 RVA: 0x0010144C File Offset: 0x000FF64C
	[Token(Token = "0x600305D")]
	[Address(RVA = "0x56D370", Offset = "0x56B970", VA = "0x18056D370", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Snow5;
	}

	// Token: 0x0600305E RID: 12382 RVA: 0x0010145C File Offset: 0x000FF65C
	[Token(Token = "0x600305E")]
	[Address(RVA = "0x6AB370", Offset = "0x6A9970", VA = "0x1806AB370", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		int size5 = list._size;
		int size6 = list._size;
		return list;
	}

	// Token: 0x0600305F RID: 12383 RVA: 0x001014B8 File Offset: 0x000FF6B8
	[Token(Token = "0x600305F")]
	[Address(RVA = "0x69C510", Offset = "0x69AB10", VA = "0x18069C510", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.WaterAloes;
	}

	// Token: 0x06003060 RID: 12384 RVA: 0x001014C8 File Offset: 0x000FF6C8
	[Token(Token = "0x6003060")]
	[Address(RVA = "0x69BB30", Offset = "0x69A130", VA = "0x18069BB30", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Snow;
	}

	// Token: 0x06003061 RID: 12385 RVA: 0x001014D8 File Offset: 0x000FF6D8
	[Token(Token = "0x6003061")]
	[Address(RVA = "0x6AB240", Offset = "0x6A9840", VA = "0x1806AB240", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉雪原：第5关";
	}

	// Token: 0x06003062 RID: 12386 RVA: 0x001014EC File Offset: 0x000FF6EC
	[Token(Token = "0x6003062")]
	[Address(RVA = "0x6AB2F0", Offset = "0x6A98F0", VA = "0x1806AB2F0", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "冰块连射：累计发射30次冰块";
		}
		if (result == MissionResult.Second)
		{
			return "水润全场：提交5株芦荟医师";
		}
		return string.Empty;
	}

	// Token: 0x06003063 RID: 12387 RVA: 0x00101514 File Offset: 0x000FF714
	[Token(Token = "0x6003063")]
	[Address(RVA = "0x6AB270", Offset = "0x6A9870", VA = "0x1806AB270", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "水芦荟的价格降低50";
		}
		if (result == MissionResult.Second)
		{
			return "芦荟医师的能量消耗降低2点";
		}
		return string.Empty;
	}

	// Token: 0x06003064 RID: 12388 RVA: 0x0010153C File Offset: 0x000FF73C
	[Token(Token = "0x6003064")]
	[Address(RVA = "0x6AB050", Offset = "0x6A9650", VA = "0x1806AB050", Slot = "22")]
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

	// Token: 0x06003065 RID: 12389 RVA: 0x001015B4 File Offset: 0x000FF7B4
	[Token(Token = "0x6003065")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06003066 RID: 12390 RVA: 0x001015C4 File Offset: 0x000FF7C4
	[Token(Token = "0x6003066")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public Snow5Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
