using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200094B RID: 2379
[Token(Token = "0x200094B")]
public class NightPoolSub4Strategy : BaseLevelStrategy
{
	// Token: 0x060030BA RID: 12474 RVA: 0x00103FC8 File Offset: 0x001021C8
	[Token(Token = "0x60030BA")]
	[Address(RVA = "0x718990", Offset = "0x716F90", VA = "0x180718990", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.NightPool_sub4;
	}

	// Token: 0x060030BB RID: 12475 RVA: 0x00103FD8 File Offset: 0x001021D8
	[Token(Token = "0x60030BB")]
	[Address(RVA = "0x712F40", Offset = "0x711540", VA = "0x180712F40", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.cardBank = false;
		board.boardTag.disableSelectCard = true;
		board.boardTag.isConvey = true;
		board.timeUntilNextWave = 3f;
	}

	// Token: 0x060030BC RID: 12476 RVA: 0x00104018 File Offset: 0x00102218
	[Token(Token = "0x60030BC")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x060030BD RID: 12477 RVA: 0x00104028 File Offset: 0x00102228
	[Token(Token = "0x60030BD")]
	[Address(RVA = "0x7189A0", Offset = "0x716FA0", VA = "0x1807189A0", Slot = "24")]
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

	// Token: 0x060030BE RID: 12478 RVA: 0x0010408C File Offset: 0x0010228C
	[Token(Token = "0x60030BE")]
	[Address(RVA = "0x7185D0", Offset = "0x716BD0", VA = "0x1807185D0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.StarFruit;
	}

	// Token: 0x060030BF RID: 12479 RVA: 0x0010409C File Offset: 0x0010229C
	[Token(Token = "0x60030BF")]
	[Address(RVA = "0x7185E0", Offset = "0x716BE0", VA = "0x1807185E0", Slot = "26")]
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
		return list;
	}

	// Token: 0x060030C0 RID: 12480 RVA: 0x00104110 File Offset: 0x00102310
	[Token(Token = "0x60030C0")]
	[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.NightPool;
	}

	// Token: 0x060030C1 RID: 12481 RVA: 0x00104120 File Offset: 0x00102320
	[Token(Token = "0x60030C1")]
	[Address(RVA = "0x718960", Offset = "0x716F60", VA = "0x180718960", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：浓雾传送带";
	}

	// Token: 0x060030C2 RID: 12482 RVA: 0x00104134 File Offset: 0x00102334
	[Token(Token = "0x60030C2")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public NightPoolSub4Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
