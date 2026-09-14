using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000964 RID: 2404
[Token(Token = "0x2000964")]
public class Snow1Strategy : BaseLevelStrategy
{
	// Token: 0x06003160 RID: 12640 RVA: 0x00105984 File Offset: 0x00103B84
	[Token(Token = "0x6003160")]
	[Address(RVA = "0x524F60", Offset = "0x523560", VA = "0x180524F60", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Snow1;
	}

	// Token: 0x06003161 RID: 12641 RVA: 0x00105994 File Offset: 0x00103B94
	[Token(Token = "0x6003161")]
	[Address(RVA = "0x724290", Offset = "0x722890", VA = "0x180724290", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		return list;
	}

	// Token: 0x06003162 RID: 12642 RVA: 0x001059D4 File Offset: 0x00103BD4
	[Token(Token = "0x6003162")]
	[Address(RVA = "0x71E400", Offset = "0x71CA00", VA = "0x18071E400", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.PineFurnace;
	}

	// Token: 0x06003163 RID: 12643 RVA: 0x001059E4 File Offset: 0x00103BE4
	[Token(Token = "0x6003163")]
	[Address(RVA = "0x715C90", Offset = "0x714290", VA = "0x180715C90", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Snow;
	}

	// Token: 0x06003164 RID: 12644 RVA: 0x001059F4 File Offset: 0x00103BF4
	[Token(Token = "0x6003164")]
	[Address(RVA = "0x724160", Offset = "0x722760", VA = "0x180724160", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉雪原：第1关";
	}

	// Token: 0x06003165 RID: 12645 RVA: 0x00105A08 File Offset: 0x00103C08
	[Token(Token = "0x6003165")]
	[Address(RVA = "0x724210", Offset = "0x722810", VA = "0x180724210", Slot = "32")]
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

	// Token: 0x06003166 RID: 12646 RVA: 0x00105A30 File Offset: 0x00103C30
	[Token(Token = "0x6003166")]
	[Address(RVA = "0x724190", Offset = "0x722790", VA = "0x180724190", Slot = "33")]
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

	// Token: 0x06003167 RID: 12647 RVA: 0x00105A58 File Offset: 0x00103C58
	[Token(Token = "0x6003167")]
	[Address(RVA = "0x723FC0", Offset = "0x7225C0", VA = "0x180723FC0", Slot = "22")]
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
			if (mission.count < 5)
			{
				Board board3 = board;
				int plantCount = Lawnf.GetPlantCount((PlantType)((uint)35), board3);
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

	// Token: 0x06003168 RID: 12648 RVA: 0x00105ADC File Offset: 0x00103CDC
	[Token(Token = "0x6003168")]
	[Address(RVA = "0x3F63A0", Offset = "0x3F49A0", VA = "0x1803F63A0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 10;
	}

	// Token: 0x06003169 RID: 12649 RVA: 0x00105AEC File Offset: 0x00103CEC
	[Token(Token = "0x6003169")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Snow1Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
