using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200092E RID: 2350
[Token(Token = "0x200092E")]
public class Snow4Strategy : BaseLevelStrategy
{
	// Token: 0x06003051 RID: 12369 RVA: 0x00101244 File Offset: 0x000FF444
	[Token(Token = "0x6003051")]
	[Address(RVA = "0x4C8F70", Offset = "0x4C7570", VA = "0x1804C8F70", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Snow4;
	}

	// Token: 0x06003052 RID: 12370 RVA: 0x00101254 File Offset: 0x000FF454
	[Token(Token = "0x6003052")]
	[Address(RVA = "0x6AADE0", Offset = "0x6A93E0", VA = "0x1806AADE0", Slot = "24")]
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

	// Token: 0x06003053 RID: 12371 RVA: 0x001012B4 File Offset: 0x000FF4B4
	[Token(Token = "0x6003053")]
	[Address(RVA = "0x49CC10", Offset = "0x49B210", VA = "0x18049CC10", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.IceLotus;
	}

	// Token: 0x06003054 RID: 12372 RVA: 0x001012C4 File Offset: 0x000FF4C4
	[Token(Token = "0x6003054")]
	[Address(RVA = "0x69BB30", Offset = "0x69A130", VA = "0x18069BB30", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Snow;
	}

	// Token: 0x06003055 RID: 12373 RVA: 0x001012D4 File Offset: 0x000FF4D4
	[Token(Token = "0x6003055")]
	[Address(RVA = "0x6AACB0", Offset = "0x6A92B0", VA = "0x1806AACB0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉雪原：第4关";
	}

	// Token: 0x06003056 RID: 12374 RVA: 0x001012E8 File Offset: 0x000FF4E8
	[Token(Token = "0x6003056")]
	[Address(RVA = "0x6AAD60", Offset = "0x6A9360", VA = "0x1806AAD60", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "能量爆发：累计触发20次冰莲花治疗";
		}
		if (result == MissionResult.Second)
		{
			return "全面恢复：关卡结束时场上至少有10株冰莲花";
		}
		return string.Empty;
	}

	// Token: 0x06003057 RID: 12375 RVA: 0x00101310 File Offset: 0x000FF510
	[Token(Token = "0x6003057")]
	[Address(RVA = "0x6AACE0", Offset = "0x6A92E0", VA = "0x1806AACE0", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "冰莲花的能量获取速度提升50%";
		}
		if (result == MissionResult.Second)
		{
			return "冰莲花的恢复范围扩大到5x5";
		}
		return string.Empty;
	}

	// Token: 0x06003058 RID: 12376 RVA: 0x00101338 File Offset: 0x000FF538
	[Token(Token = "0x6003058")]
	[Address(RVA = "0x6AAB10", Offset = "0x6A9110", VA = "0x1806AAB10", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		AdvantureLevel level = this.GetLevel();
		advantureMission.level = level;
		advantureMission.endResult = (MissionResult)((ulong)2L);
		AdvantureMission mission = advantureMission;
		Func<MissionResult> func;
		mission.target = func;
		AdvantureMission mission2 = mission;
		AdvantureLevel level2 = this.GetLevel();
		return mission;
	}

	// Token: 0x06003059 RID: 12377 RVA: 0x001013A8 File Offset: 0x000FF5A8
	[Token(Token = "0x6003059")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x0600305A RID: 12378 RVA: 0x001013B8 File Offset: 0x000FF5B8
	[Token(Token = "0x600305A")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public Snow4Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
