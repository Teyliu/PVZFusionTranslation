using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200090E RID: 2318
[Token(Token = "0x200090E")]
public class DaySub3Strategy : BaseLevelStrategy
{
	// Token: 0x06002F25 RID: 12069 RVA: 0x000FFF10 File Offset: 0x000FE110
	[Token(Token = "0x6002F25")]
	[Address(RVA = "0x3F87C0", Offset = "0x3F6DC0", VA = "0x1803F87C0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Day_sub3;
	}

	// Token: 0x06002F26 RID: 12070 RVA: 0x000FFF20 File Offset: 0x000FE120
	[Token(Token = "0x6002F26")]
	[Address(RVA = "0x712F40", Offset = "0x711540", VA = "0x180712F40", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.cardBank = false;
		board.boardTag.disableSelectCard = true;
		board.boardTag.isConvey = true;
		board.timeUntilNextWave = 3f;
	}

	// Token: 0x06002F27 RID: 12071 RVA: 0x000FFF60 File Offset: 0x000FE160
	[Token(Token = "0x6002F27")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06002F28 RID: 12072 RVA: 0x000FFF70 File Offset: 0x000FE170
	[Token(Token = "0x6002F28")]
	[Address(RVA = "0x712D20", Offset = "0x711320", VA = "0x180712D20", Slot = "24")]
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

	// Token: 0x06002F29 RID: 12073 RVA: 0x000FFFC8 File Offset: 0x000FE1C8
	[Token(Token = "0x6002F29")]
	[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.WallNut;
	}

	// Token: 0x06002F2A RID: 12074 RVA: 0x000FFFD8 File Offset: 0x000FE1D8
	[Token(Token = "0x6002F2A")]
	[Address(RVA = "0x712A80", Offset = "0x711080", VA = "0x180712A80", Slot = "26")]
	public override List<PlantType> GetConveyPlants()
	{
		List<PlantType> list = new List();
		int size = list._size;
		list._size = 1;
		list._syncRoot = (ulong)0L;
		int size2 = list._size;
		list._size = 1;
		int size3 = list._size;
		list._size = 1;
		int size4 = list._size;
		list._size = 1;
		int size5 = list._size;
		list._size = 1;
		int size6 = list._size;
		return list;
	}

	// Token: 0x06002F2B RID: 12075 RVA: 0x00100068 File Offset: 0x000FE268
	[Token(Token = "0x6002F2B")]
	[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Day;
	}

	// Token: 0x06002F2C RID: 12076 RVA: 0x00100080 File Offset: 0x000FE280
	[Token(Token = "0x6002F2C")]
	[Address(RVA = "0x712CF0", Offset = "0x7112F0", VA = "0x180712CF0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：白天传送带";
	}

	// Token: 0x06002F2D RID: 12077 RVA: 0x00100094 File Offset: 0x000FE294
	[Token(Token = "0x6002F2D")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public DaySub3Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
