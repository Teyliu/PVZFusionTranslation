using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using GameLevel;

// Token: 0x020008F9 RID: 2297
[Token(Token = "0x20008F9")]
public class PoolSub1Strategy : BaseLevelStrategy
{
	// Token: 0x06002EED RID: 12013 RVA: 0x000FD99C File Offset: 0x000FBB9C
	[Token(Token = "0x6002EED")]
	[Address(RVA = "0x6A3170", Offset = "0x6A1770", VA = "0x1806A3170", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Pool_sub1;
	}

	// Token: 0x06002EEE RID: 12014 RVA: 0x000FD9AC File Offset: 0x000FBBAC
	[Token(Token = "0x6002EEE")]
	[Address(RVA = "0x6A33A0", Offset = "0x6A19A0", VA = "0x1806A33A0", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.boardTag.isConvey = true;
		board.boardTag.smallZombie = true;
		board.boardTag.disableSelectCard = true;
		BoardConfig config = board.config;
		board.cardBank = false;
		config.zombieSpeedMultiplier = 1.5f;
	}

	// Token: 0x06002EEF RID: 12015 RVA: 0x000FD9FC File Offset: 0x000FBBFC
	[Token(Token = "0x6002EEF")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06002EF0 RID: 12016 RVA: 0x000FDA0C File Offset: 0x000FBC0C
	[Token(Token = "0x6002EF0")]
	[Address(RVA = "0x6A3180", Offset = "0x6A1780", VA = "0x1806A3180", Slot = "24")]
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

	// Token: 0x06002EF1 RID: 12017 RVA: 0x000FDA64 File Offset: 0x000FBC64
	[Token(Token = "0x6002EF1")]
	[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Peashooter;
	}

	// Token: 0x06002EF2 RID: 12018 RVA: 0x000FDA7C File Offset: 0x000FBC7C
	[Token(Token = "0x6002EF2")]
	[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Pool;
	}

	// Token: 0x06002EF3 RID: 12019 RVA: 0x000FDA8C File Offset: 0x000FBC8C
	[Token(Token = "0x6002EF3")]
	[Address(RVA = "0x6A3140", Offset = "0x6A1740", VA = "0x1806A3140", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：小僵尸大麻烦";
	}

	// Token: 0x06002EF4 RID: 12020 RVA: 0x000FDAA0 File Offset: 0x000FBCA0
	[Token(Token = "0x6002EF4")]
	[Address(RVA = "0x6A2B80", Offset = "0x6A1180", VA = "0x1806A2B80", Slot = "26")]
	public override List<PlantType> GetConveyPlants()
	{
		List<PlantType> list = new List();
		int size = list._size;
		int num = 0;
		list._size = 1;
		list._syncRoot = num;
		int size2 = list._size;
		list._size = 1;
		int size3 = list._size;
		list._size = 1;
		int size4 = list._size;
		list._size = 1;
		int size5 = list._size;
		list._size = 1;
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
		list._size = 1;
		int size12 = list._size;
		list._size = 1;
		int size13 = list._size;
		list._size = 1;
		int size14 = list._size;
		list._size = 1;
		int size15 = list._size;
		list._size = 1;
		int size16 = list._size;
		return list;
	}

	// Token: 0x06002EF5 RID: 12021 RVA: 0x000FDBD0 File Offset: 0x000FBDD0
	[Token(Token = "0x6002EF5")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public PoolSub1Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
