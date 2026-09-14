using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020008F4 RID: 2292
[Token(Token = "0x20008F4")]
public class Pool5Strategy : BaseLevelStrategy
{
	// Token: 0x06002ED2 RID: 11986 RVA: 0x000FD5CC File Offset: 0x000FB7CC
	[Token(Token = "0x6002ED2")]
	[Address(RVA = "0x6A1E90", Offset = "0x6A0490", VA = "0x1806A1E90", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Pool5;
	}

	// Token: 0x06002ED3 RID: 11987 RVA: 0x000FD5DC File Offset: 0x000FB7DC
	[Token(Token = "0x6002ED3")]
	[Address(RVA = "0x6A1FA0", Offset = "0x6A05A0", VA = "0x1806A1FA0", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		return list;
	}

	// Token: 0x06002ED4 RID: 11988 RVA: 0x000FD620 File Offset: 0x000FB820
	[Token(Token = "0x6002ED4")]
	[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.SunFlower;
	}

	// Token: 0x06002ED5 RID: 11989 RVA: 0x000FD630 File Offset: 0x000FB830
	[Token(Token = "0x6002ED5")]
	[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Pool;
	}

	// Token: 0x06002ED6 RID: 11990 RVA: 0x000FD640 File Offset: 0x000FB840
	[Token(Token = "0x6002ED6")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06002ED7 RID: 11991 RVA: 0x000FD650 File Offset: 0x000FB850
	[Token(Token = "0x6002ED7")]
	[Address(RVA = "0x6A1E60", Offset = "0x6A0460", VA = "0x1806A1E60", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉泳池：第5关";
	}

	// Token: 0x06002ED8 RID: 11992 RVA: 0x000FD664 File Offset: 0x000FB864
	[Token(Token = "0x6002ED8")]
	[Address(RVA = "0x6A1F20", Offset = "0x6A0520", VA = "0x1806A1F20", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "燃烧生命：使15株植物的血量低于100";
		}
		if (result == MissionResult.Second)
		{
			return "怒火攻心：使僵尸一共产生100次红温爆炸";
		}
		return string.Empty;
	}

	// Token: 0x06002ED9 RID: 11993 RVA: 0x000FD68C File Offset: 0x000FB88C
	[Token(Token = "0x6002ED9")]
	[Address(RVA = "0x6A1EA0", Offset = "0x6A04A0", VA = "0x1806A1EA0", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "血量低于30%的植物获得50%伤害减免";
		}
		if (result == MissionResult.Second)
		{
			return "红温爆炸的影响范围增加50%";
		}
		return string.Empty;
	}

	// Token: 0x06002EDA RID: 11994 RVA: 0x000FD6B4 File Offset: 0x000FB8B4
	[Token(Token = "0x6002EDA")]
	[Address(RVA = "0x6A1CE0", Offset = "0x6A02E0", VA = "0x1806A1CE0", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		advantureMission.board = board;
		AdvantureLevel level = this.GetLevel();
		advantureMission.level = level;
		AdvantureMission mission = advantureMission;
		Func<MissionResult> func;
		mission.target = func;
		AdvantureMission mission2 = mission;
		AdvantureLevel level2 = this.GetLevel();
		return mission;
	}

	// Token: 0x06002EDB RID: 11995 RVA: 0x000FD714 File Offset: 0x000FB914
	[Token(Token = "0x6002EDB")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public Pool5Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
