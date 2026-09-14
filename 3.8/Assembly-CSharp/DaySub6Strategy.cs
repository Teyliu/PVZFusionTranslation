using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using GameLevel;

// Token: 0x020008D5 RID: 2261
[Token(Token = "0x20008D5")]
public class DaySub6Strategy : BaseLevelStrategy
{
	// Token: 0x06002E0F RID: 11791 RVA: 0x000FB844 File Offset: 0x000F9A44
	[Token(Token = "0x6002E0F")]
	[Address(RVA = "0x3AB4C0", Offset = "0x3A9AC0", VA = "0x1803AB4C0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Day_sub6;
	}

	// Token: 0x06002E10 RID: 11792 RVA: 0x000FB854 File Offset: 0x000F9A54
	[Token(Token = "0x6002E10")]
	[Address(RVA = "0x699E00", Offset = "0x698400", VA = "0x180699E00", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		BoardConfig config = board.config;
		config.zombieDamageMultiplier = 2f;
		config.zombieHealthMultiplier = 2f;
		config.zombieCountMultiplier = 2f;
	}

	// Token: 0x06002E11 RID: 11793 RVA: 0x000FB890 File Offset: 0x000F9A90
	[Token(Token = "0x6002E11")]
	[Address(RVA = "0x698EE0", Offset = "0x6974E0", VA = "0x180698EE0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 30;
	}

	// Token: 0x06002E12 RID: 11794 RVA: 0x000FB8A0 File Offset: 0x000F9AA0
	[Token(Token = "0x6002E12")]
	[Address(RVA = "0x6998E0", Offset = "0x697EE0", VA = "0x1806998E0", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		int size5 = list._size;
		int size6 = list._size;
		int size7 = list._size;
		int size8 = list._size;
		int size9 = list._size;
		int size10 = list._size;
		int size11 = list._size;
		int size12 = list._size;
		int size13 = list._size;
		int size14 = list._size;
		return list;
	}

	// Token: 0x06002E13 RID: 11795 RVA: 0x000FB940 File Offset: 0x000F9B40
	[Token(Token = "0x6002E13")]
	[Address(RVA = "0x3ABC00", Offset = "0x3AA200", VA = "0x1803ABC00", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Chomper;
	}

	// Token: 0x06002E14 RID: 11796 RVA: 0x000FB950 File Offset: 0x000F9B50
	[Token(Token = "0x6002E14")]
	[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Day;
	}

	// Token: 0x06002E15 RID: 11797 RVA: 0x000FB968 File Offset: 0x000F9B68
	[Token(Token = "0x6002E15")]
	[Address(RVA = "0x699880", Offset = "0x697E80", VA = "0x180699880", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：最终决战";
	}

	// Token: 0x06002E16 RID: 11798 RVA: 0x000FB97C File Offset: 0x000F9B7C
	[Token(Token = "0x6002E16")]
	[Address(RVA = "0x6998B0", Offset = "0x697EB0", VA = "0x1806998B0", Slot = "31")]
	public override string GetLevelTip()
	{
		return "精英预警：僵尸强化2倍";
	}

	// Token: 0x06002E17 RID: 11799 RVA: 0x000FB990 File Offset: 0x000F9B90
	[Token(Token = "0x6002E17")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public DaySub6Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
