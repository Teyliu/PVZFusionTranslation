using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000974 RID: 2420
[Token(Token = "0x2000974")]
public class SnowSub4Strategy : BaseLevelStrategy
{
	// Token: 0x060031C5 RID: 12741 RVA: 0x00106AA8 File Offset: 0x00104CA8
	[Token(Token = "0x60031C5")]
	[Address(RVA = "0x50B640", Offset = "0x509C40", VA = "0x18050B640", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Snow_sub4;
	}

	// Token: 0x060031C6 RID: 12742 RVA: 0x00106AB8 File Offset: 0x00104CB8
	[Token(Token = "0x60031C6")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x060031C7 RID: 12743 RVA: 0x00106AC8 File Offset: 0x00104CC8
	[Token(Token = "0x60031C7")]
	[Address(RVA = "0x726EC0", Offset = "0x7254C0", VA = "0x180726EC0", Slot = "24")]
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

	// Token: 0x060031C8 RID: 12744 RVA: 0x00106B2C File Offset: 0x00104D2C
	[Token(Token = "0x60031C8")]
	[Address(RVA = "0x71E400", Offset = "0x71CA00", VA = "0x18071E400", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.PineFurnace;
	}

	// Token: 0x060031C9 RID: 12745 RVA: 0x00106B3C File Offset: 0x00104D3C
	[Token(Token = "0x60031C9")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Snow_6;
	}

	// Token: 0x060031CA RID: 12746 RVA: 0x00106B4C File Offset: 0x00104D4C
	[Token(Token = "0x60031CA")]
	[Address(RVA = "0x726E90", Offset = "0x725490", VA = "0x180726E90", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：雪原传送带";
	}

	// Token: 0x060031CB RID: 12747 RVA: 0x00106B60 File Offset: 0x00104D60
	[Token(Token = "0x60031CB")]
	[Address(RVA = "0x712F40", Offset = "0x711540", VA = "0x180712F40", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.cardBank = false;
		board.boardTag.disableSelectCard = true;
		board.boardTag.isConvey = true;
		board.timeUntilNextWave = 3f;
	}

	// Token: 0x060031CC RID: 12748 RVA: 0x00106BA0 File Offset: 0x00104DA0
	[Token(Token = "0x60031CC")]
	[Address(RVA = "0x726A10", Offset = "0x725010", VA = "0x180726A10", Slot = "26")]
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
		int size12 = list._size;
		return list;
	}

	// Token: 0x060031CD RID: 12749 RVA: 0x00106C2C File Offset: 0x00104E2C
	[Token(Token = "0x60031CD")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public SnowSub4Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
