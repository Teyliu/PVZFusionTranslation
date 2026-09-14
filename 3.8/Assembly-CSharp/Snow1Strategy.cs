using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000928 RID: 2344
[Token(Token = "0x2000928")]
public class Snow1Strategy : BaseLevelStrategy
{
	// Token: 0x0600302D RID: 12333 RVA: 0x00100C34 File Offset: 0x000FEE34
	[Token(Token = "0x600302D")]
	[Address(RVA = "0x4C8D70", Offset = "0x4C7370", VA = "0x1804C8D70", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Snow1;
	}

	// Token: 0x0600302E RID: 12334 RVA: 0x00100C44 File Offset: 0x000FEE44
	[Token(Token = "0x600302E")]
	[Address(RVA = "0x6AA130", Offset = "0x6A8730", VA = "0x1806AA130", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		return list;
	}

	// Token: 0x0600302F RID: 12335 RVA: 0x00100C84 File Offset: 0x000FEE84
	[Token(Token = "0x600302F")]
	[Address(RVA = "0x6A42A0", Offset = "0x6A28A0", VA = "0x1806A42A0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.PineFurnace;
	}

	// Token: 0x06003030 RID: 12336 RVA: 0x00100C94 File Offset: 0x000FEE94
	[Token(Token = "0x6003030")]
	[Address(RVA = "0x69BB30", Offset = "0x69A130", VA = "0x18069BB30", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Snow;
	}

	// Token: 0x06003031 RID: 12337 RVA: 0x00100CA4 File Offset: 0x000FEEA4
	[Token(Token = "0x6003031")]
	[Address(RVA = "0x6AA000", Offset = "0x6A8600", VA = "0x1806AA000", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉雪原：第1关";
	}

	// Token: 0x06003032 RID: 12338 RVA: 0x00100CB8 File Offset: 0x000FEEB8
	[Token(Token = "0x6003032")]
	[Address(RVA = "0x6AA0B0", Offset = "0x6A86B0", VA = "0x1806AA0B0", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "新的开端：使用小松炉融化5个冰块";
		}
		if (result == MissionResult.Second)
		{
			return "小松炉批发：关卡结束时场上至少有10个小松炉";
		}
		return string.Empty;
	}

	// Token: 0x06003033 RID: 12339 RVA: 0x00100CE0 File Offset: 0x000FEEE0
	[Token(Token = "0x6003033")]
	[Address(RVA = "0x6AA030", Offset = "0x6A8630", VA = "0x1806AA030", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "小松炉的融化范围扩大到3x3";
		}
		if (result == MissionResult.Second)
		{
			return "小松炉的价格降低至0";
		}
		return string.Empty;
	}

	// Token: 0x06003034 RID: 12340 RVA: 0x00100D08 File Offset: 0x000FEF08
	[Token(Token = "0x6003034")]
	[Address(RVA = "0x6A9E60", Offset = "0x6A8460", VA = "0x1806A9E60", Slot = "22")]
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

	// Token: 0x06003035 RID: 12341 RVA: 0x00100D78 File Offset: 0x000FEF78
	[Token(Token = "0x6003035")]
	[Address(RVA = "0x3AA5A0", Offset = "0x3A8BA0", VA = "0x1803AA5A0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 10;
	}

	// Token: 0x06003036 RID: 12342 RVA: 0x00100D88 File Offset: 0x000FEF88
	[Token(Token = "0x6003036")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public Snow1Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
