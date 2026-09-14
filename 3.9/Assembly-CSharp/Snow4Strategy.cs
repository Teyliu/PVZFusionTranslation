using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200096A RID: 2410
[Token(Token = "0x200096A")]
public class Snow4Strategy : BaseLevelStrategy
{
	// Token: 0x06003184 RID: 12676 RVA: 0x00105FC0 File Offset: 0x001041C0
	[Token(Token = "0x6003184")]
	[Address(RVA = "0x525160", Offset = "0x523760", VA = "0x180525160", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Snow4;
	}

	// Token: 0x06003185 RID: 12677 RVA: 0x00105FD0 File Offset: 0x001041D0
	[Token(Token = "0x6003185")]
	[Address(RVA = "0x724F40", Offset = "0x723540", VA = "0x180724F40", Slot = "24")]
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

	// Token: 0x06003186 RID: 12678 RVA: 0x00106030 File Offset: 0x00104230
	[Token(Token = "0x6003186")]
	[Address(RVA = "0x50C610", Offset = "0x50AC10", VA = "0x18050C610", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.IceLotus;
	}

	// Token: 0x06003187 RID: 12679 RVA: 0x00106040 File Offset: 0x00104240
	[Token(Token = "0x6003187")]
	[Address(RVA = "0x715C90", Offset = "0x714290", VA = "0x180715C90", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Snow;
	}

	// Token: 0x06003188 RID: 12680 RVA: 0x00106050 File Offset: 0x00104250
	[Token(Token = "0x6003188")]
	[Address(RVA = "0x724E10", Offset = "0x723410", VA = "0x180724E10", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉雪原：第4关";
	}

	// Token: 0x06003189 RID: 12681 RVA: 0x00106064 File Offset: 0x00104264
	[Token(Token = "0x6003189")]
	[Address(RVA = "0x724EC0", Offset = "0x7234C0", VA = "0x180724EC0", Slot = "32")]
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

	// Token: 0x0600318A RID: 12682 RVA: 0x0010608C File Offset: 0x0010428C
	[Token(Token = "0x600318A")]
	[Address(RVA = "0x724E40", Offset = "0x723440", VA = "0x180724E40", Slot = "33")]
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

	// Token: 0x0600318B RID: 12683 RVA: 0x001060B4 File Offset: 0x001042B4
	[Token(Token = "0x600318B")]
	[Address(RVA = "0x724C70", Offset = "0x723270", VA = "0x180724C70", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		AdvantureLevel level = this.GetLevel();
		advantureMission.level = level;
		advantureMission.endResult = (MissionResult)((ulong)2L);
		AdvantureMission mission = advantureMission;
		AdvantureMission mission3 = mission;
		Func<MissionResult> func = delegate
		{
			if (mission.count < 20)
			{
				Board board3 = board;
				int plantCount = Lawnf.GetPlantCount((PlantType)((uint)37), board3);
				Board board4 = board;
				int theMaxWave = board4.theMaxWave;
				if (board4.theWave == theMaxWave)
				{
					mission.endResult = (MissionResult)((ulong)2L);
				}
			}
			return MissionResult.First;
		};
		mission3.target = func;
		AdvantureMission mission2 = mission;
		AdvantureLevel level2 = this.GetLevel();
		return mission;
	}

	// Token: 0x0600318C RID: 12684 RVA: 0x00106138 File Offset: 0x00104338
	[Token(Token = "0x600318C")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x0600318D RID: 12685 RVA: 0x00106148 File Offset: 0x00104348
	[Token(Token = "0x600318D")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Snow4Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
