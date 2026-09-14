using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020008FC RID: 2300
[Token(Token = "0x20008FC")]
public class PoolSub4Strategy : BaseLevelStrategy
{
	// Token: 0x06002F06 RID: 12038 RVA: 0x000FDEC0 File Offset: 0x000FC0C0
	[Token(Token = "0x6002F06")]
	[Address(RVA = "0x6A3F60", Offset = "0x6A2560", VA = "0x1806A3F60", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Pool_sub4;
	}

	// Token: 0x06002F07 RID: 12039 RVA: 0x000FDED0 File Offset: 0x000FC0D0
	[Token(Token = "0x6002F07")]
	[Address(RVA = "0x698E40", Offset = "0x697440", VA = "0x180698E40", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.cardBank = false;
		board.boardTag.disableSelectCard = true;
		board.boardTag.isConvey = true;
		board.timeUntilNextWave = 3f;
	}

	// Token: 0x06002F08 RID: 12040 RVA: 0x000FDF10 File Offset: 0x000FC110
	[Token(Token = "0x6002F08")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06002F09 RID: 12041 RVA: 0x000FDF20 File Offset: 0x000FC120
	[Token(Token = "0x6002F09")]
	[Address(RVA = "0x6A3F70", Offset = "0x6A2570", VA = "0x1806A3F70", Slot = "24")]
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
		return list;
	}

	// Token: 0x06002F0A RID: 12042 RVA: 0x000FDF84 File Offset: 0x000FC184
	[Token(Token = "0x6002F0A")]
	[Address(RVA = "0x69AA70", Offset = "0x699070", VA = "0x18069AA70", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.ThreePeater;
	}

	// Token: 0x06002F0B RID: 12043 RVA: 0x000FDF94 File Offset: 0x000FC194
	[Token(Token = "0x6002F0B")]
	[Address(RVA = "0x6A3B10", Offset = "0x6A2110", VA = "0x1806A3B10", Slot = "26")]
	public override List<PlantType> GetConveyPlants()
	{
		List<PlantType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		int size5 = list._size;
		list._size = 1;
		list._syncRoot = (ulong)0L;
		int size6 = list._size;
		list._size = 1;
		int size7 = list._size;
		list._size = 1;
		int size8 = list._size;
		list._size = 1;
		int size9 = list._size;
		list._size = 1;
		int size10 = list._size;
		list._size = 1;
		int size11 = list._size;
		return list;
	}

	// Token: 0x06002F0C RID: 12044 RVA: 0x000FE050 File Offset: 0x000FC250
	[Token(Token = "0x6002F0C")]
	[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Pool;
	}

	// Token: 0x06002F0D RID: 12045 RVA: 0x000FE060 File Offset: 0x000FC260
	[Token(Token = "0x6002F0D")]
	[Address(RVA = "0x6A3F30", Offset = "0x6A2530", VA = "0x1806A3F30", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：泳池传送带";
	}

	// Token: 0x06002F0E RID: 12046 RVA: 0x000FE074 File Offset: 0x000FC274
	[Token(Token = "0x6002F0E")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public PoolSub4Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
