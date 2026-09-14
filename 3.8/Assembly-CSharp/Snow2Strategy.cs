using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200092A RID: 2346
[Token(Token = "0x200092A")]
public class Snow2Strategy : BaseLevelStrategy
{
	// Token: 0x06003039 RID: 12345 RVA: 0x00100E1C File Offset: 0x000FF01C
	[Token(Token = "0x6003039")]
	[Address(RVA = "0x4C8D60", Offset = "0x4C7360", VA = "0x1804C8D60", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Snow2;
	}

	// Token: 0x0600303A RID: 12346 RVA: 0x00100E2C File Offset: 0x000FF02C
	[Token(Token = "0x600303A")]
	[Address(RVA = "0x6AA500", Offset = "0x6A8B00", VA = "0x1806AA500", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		return list;
	}

	// Token: 0x0600303B RID: 12347 RVA: 0x00100E74 File Offset: 0x000FF074
	[Token(Token = "0x600303B")]
	[Address(RVA = "0x6A44C0", Offset = "0x6A2AC0", VA = "0x1806A44C0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.SpruceShooter;
	}

	// Token: 0x0600303C RID: 12348 RVA: 0x00100E84 File Offset: 0x000FF084
	[Token(Token = "0x600303C")]
	[Address(RVA = "0x69BB30", Offset = "0x69A130", VA = "0x18069BB30", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Snow;
	}

	// Token: 0x0600303D RID: 12349 RVA: 0x00100E94 File Offset: 0x000FF094
	[Token(Token = "0x600303D")]
	[Address(RVA = "0x6AA3D0", Offset = "0x6A89D0", VA = "0x1806AA3D0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉雪原：第2关";
	}

	// Token: 0x0600303E RID: 12350 RVA: 0x00100EA8 File Offset: 0x000FF0A8
	[Token(Token = "0x600303E")]
	[Address(RVA = "0x6AA480", Offset = "0x6A8A80", VA = "0x1806AA480", Slot = "32")]
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

	// Token: 0x0600303F RID: 12351 RVA: 0x00100ED0 File Offset: 0x000FF0D0
	[Token(Token = "0x600303F")]
	[Address(RVA = "0x6AA400", Offset = "0x6A8A00", VA = "0x1806AA400", Slot = "33")]
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

	// Token: 0x06003040 RID: 12352 RVA: 0x00100EF8 File Offset: 0x000FF0F8
	[Token(Token = "0x6003040")]
	[Address(RVA = "0x6AA250", Offset = "0x6A8850", VA = "0x1806AA250", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		AdvantureLevel level = this.GetLevel();
		advantureMission.level = level;
		Func<MissionResult> func;
		advantureMission.target = func;
		AdvantureLevel level2 = this.GetLevel();
		return advantureMission;
	}

	// Token: 0x06003041 RID: 12353 RVA: 0x00100F48 File Offset: 0x000FF148
	[Token(Token = "0x6003041")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06003042 RID: 12354 RVA: 0x00100F58 File Offset: 0x000FF158
	[Token(Token = "0x6003042")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public Snow2Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
