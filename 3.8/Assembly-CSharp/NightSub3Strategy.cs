using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020008E7 RID: 2279
[Token(Token = "0x20008E7")]
public class NightSub3Strategy : BaseLevelStrategy
{
	// Token: 0x06002E7C RID: 11900 RVA: 0x000FC7E4 File Offset: 0x000FA9E4
	[Token(Token = "0x6002E7C")]
	[Address(RVA = "0x69C990", Offset = "0x69AF90", VA = "0x18069C990", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Night_sub3;
	}

	// Token: 0x06002E7D RID: 11901 RVA: 0x000FC7F4 File Offset: 0x000FA9F4
	[Token(Token = "0x6002E7D")]
	[Address(RVA = "0x698E40", Offset = "0x697440", VA = "0x180698E40", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.cardBank = false;
		board.boardTag.disableSelectCard = true;
		board.boardTag.isConvey = true;
		board.timeUntilNextWave = 3f;
	}

	// Token: 0x06002E7E RID: 11902 RVA: 0x000FC834 File Offset: 0x000FAA34
	[Token(Token = "0x6002E7E")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06002E7F RID: 11903 RVA: 0x000FC844 File Offset: 0x000FAA44
	[Token(Token = "0x6002E7F")]
	[Address(RVA = "0x69FDA0", Offset = "0x69E3A0", VA = "0x18069FDA0", Slot = "24")]
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

	// Token: 0x06002E80 RID: 11904 RVA: 0x000FC898 File Offset: 0x000FAA98
	[Token(Token = "0x6002E80")]
	[Address(RVA = "0x3AAD70", Offset = "0x3A9370", VA = "0x1803AAD70", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.HypnoShroom;
	}

	// Token: 0x06002E81 RID: 11905 RVA: 0x000FC8A8 File Offset: 0x000FAAA8
	[Token(Token = "0x6002E81")]
	[Address(RVA = "0x69F950", Offset = "0x69DF50", VA = "0x18069F950", Slot = "26")]
	public override List<PlantType> GetConveyPlants()
	{
		List<PlantType> list = new List();
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
		return list;
	}

	// Token: 0x06002E82 RID: 11906 RVA: 0x000FC92C File Offset: 0x000FAB2C
	[Token(Token = "0x6002E82")]
	[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Night;
	}

	// Token: 0x06002E83 RID: 11907 RVA: 0x000FC93C File Offset: 0x000FAB3C
	[Token(Token = "0x6002E83")]
	[Address(RVA = "0x69FD70", Offset = "0x69E370", VA = "0x18069FD70", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：黑夜传送带";
	}

	// Token: 0x06002E84 RID: 11908 RVA: 0x000FC950 File Offset: 0x000FAB50
	[Token(Token = "0x6002E84")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public NightSub3Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
