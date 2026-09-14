using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200095E RID: 2398
[Token(Token = "0x200095E")]
public class RoofSub1Strategy : BaseLevelStrategy
{
	// Token: 0x0600312D RID: 12589 RVA: 0x00105218 File Offset: 0x00103418
	[Token(Token = "0x600312D")]
	[Address(RVA = "0x5202E0", Offset = "0x51E8E0", VA = "0x1805202E0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Roof_sub1;
	}

	// Token: 0x0600312E RID: 12590 RVA: 0x00105228 File Offset: 0x00103428
	[Token(Token = "0x600312E")]
	[Address(RVA = "0x722660", Offset = "0x720C60", VA = "0x180722660", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.boardTag.disableSelectCard = true;
		board.cardBank = false;
		board.boardTag.isConvey = true;
		board.boardTag.bungiBattle = true;
	}

	// Token: 0x0600312F RID: 12591 RVA: 0x00105268 File Offset: 0x00103468
	[Token(Token = "0x600312F")]
	[Address(RVA = "0x7221F0", Offset = "0x7207F0", VA = "0x1807221F0", Slot = "26")]
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

	// Token: 0x06003130 RID: 12592 RVA: 0x001052E0 File Offset: 0x001034E0
	[Token(Token = "0x6003130")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06003131 RID: 12593 RVA: 0x001052F0 File Offset: 0x001034F0
	[Token(Token = "0x6003131")]
	[Address(RVA = "0x722590", Offset = "0x720B90", VA = "0x180722590", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		return list;
	}

	// Token: 0x06003132 RID: 12594 RVA: 0x00105324 File Offset: 0x00103524
	[Token(Token = "0x6003132")]
	[Address(RVA = "0x3F7A00", Offset = "0x3F6000", VA = "0x1803F7A00", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Chomper;
	}

	// Token: 0x06003133 RID: 12595 RVA: 0x00105334 File Offset: 0x00103534
	[Token(Token = "0x6003133")]
	[Address(RVA = "0x3F9250", Offset = "0x3F7850", VA = "0x1803F9250", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Roof;
	}

	// Token: 0x06003134 RID: 12596 RVA: 0x00105344 File Offset: 0x00103544
	[Token(Token = "0x6003134")]
	[Address(RVA = "0x722560", Offset = "0x720B60", VA = "0x180722560", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：蹦极闪电战";
	}

	// Token: 0x06003135 RID: 12597 RVA: 0x00105358 File Offset: 0x00103558
	[Token(Token = "0x6003135")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public RoofSub1Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
