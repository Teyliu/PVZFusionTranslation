using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using GameLevel;

// Token: 0x02000935 RID: 2357
[Token(Token = "0x2000935")]
public class PoolSub1Strategy : BaseLevelStrategy
{
	// Token: 0x06003020 RID: 12320 RVA: 0x001025E8 File Offset: 0x001007E8
	[Token(Token = "0x6003020")]
	[Address(RVA = "0x71D2D0", Offset = "0x71B8D0", VA = "0x18071D2D0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Pool_sub1;
	}

	// Token: 0x06003021 RID: 12321 RVA: 0x001025F8 File Offset: 0x001007F8
	[Token(Token = "0x6003021")]
	[Address(RVA = "0x71D500", Offset = "0x71BB00", VA = "0x18071D500", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.boardTag.isConvey = true;
		board.boardTag.smallZombie = true;
		board.boardTag.disableSelectCard = true;
		BoardConfig config = board.config;
		board.cardBank = false;
		config.zombieSpeedMultiplier = 1.5f;
	}

	// Token: 0x06003022 RID: 12322 RVA: 0x00102648 File Offset: 0x00100848
	[Token(Token = "0x6003022")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06003023 RID: 12323 RVA: 0x00102658 File Offset: 0x00100858
	[Token(Token = "0x6003023")]
	[Address(RVA = "0x71D2E0", Offset = "0x71B8E0", VA = "0x18071D2E0", Slot = "24")]
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

	// Token: 0x06003024 RID: 12324 RVA: 0x001026B0 File Offset: 0x001008B0
	[Token(Token = "0x6003024")]
	[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Peashooter;
	}

	// Token: 0x06003025 RID: 12325 RVA: 0x001026C8 File Offset: 0x001008C8
	[Token(Token = "0x6003025")]
	[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Pool;
	}

	// Token: 0x06003026 RID: 12326 RVA: 0x001026D8 File Offset: 0x001008D8
	[Token(Token = "0x6003026")]
	[Address(RVA = "0x71D2A0", Offset = "0x71B8A0", VA = "0x18071D2A0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：小僵尸大麻烦";
	}

	// Token: 0x06003027 RID: 12327 RVA: 0x001026EC File Offset: 0x001008EC
	[Token(Token = "0x6003027")]
	[Address(RVA = "0x71CCE0", Offset = "0x71B2E0", VA = "0x18071CCE0", Slot = "26")]
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

	// Token: 0x06003028 RID: 12328 RVA: 0x0010281C File Offset: 0x00100A1C
	[Token(Token = "0x6003028")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public PoolSub1Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
