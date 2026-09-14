using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200095F RID: 2399
[Token(Token = "0x200095F")]
public class RoofSub2Strategy : BaseLevelStrategy
{
	// Token: 0x06003136 RID: 12598 RVA: 0x00105370 File Offset: 0x00103570
	[Token(Token = "0x6003136")]
	[Address(RVA = "0x51F6E0", Offset = "0x51DCE0", VA = "0x18051F6E0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Roof_sub2;
	}

	// Token: 0x06003137 RID: 12599 RVA: 0x00105380 File Offset: 0x00103580
	[Token(Token = "0x6003137")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06003138 RID: 12600 RVA: 0x00105390 File Offset: 0x00103590
	[Token(Token = "0x6003138")]
	[Address(RVA = "0x7226C0", Offset = "0x720CC0", VA = "0x1807226C0", Slot = "24")]
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
		return list;
	}

	// Token: 0x06003139 RID: 12601 RVA: 0x001053FC File Offset: 0x001035FC
	[Token(Token = "0x6003139")]
	[Address(RVA = "0x712FE0", Offset = "0x7115E0", VA = "0x180712FE0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Umbrellaleaf;
	}

	// Token: 0x0600313A RID: 12602 RVA: 0x0010540C File Offset: 0x0010360C
	[Token(Token = "0x600313A")]
	[Address(RVA = "0x3F9250", Offset = "0x3F7850", VA = "0x1803F9250", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Roof;
	}

	// Token: 0x0600313B RID: 12603 RVA: 0x0010541C File Offset: 0x0010361C
	[Token(Token = "0x600313B")]
	[Address(RVA = "0x722690", Offset = "0x720C90", VA = "0x180722690", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：钢铁洪流";
	}

	// Token: 0x0600313C RID: 12604 RVA: 0x00105430 File Offset: 0x00103630
	[Token(Token = "0x600313C")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public RoofSub2Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
