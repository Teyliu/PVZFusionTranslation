using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000926 RID: 2342
[Token(Token = "0x2000926")]
public class RoofSub5Strategy : BaseLevelStrategy
{
	// Token: 0x0600301C RID: 12316 RVA: 0x001009A0 File Offset: 0x000FEBA0
	[Token(Token = "0x600301C")]
	[Address(RVA = "0x453480", Offset = "0x451A80", VA = "0x180453480", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Roof_sub5;
	}

	// Token: 0x0600301D RID: 12317 RVA: 0x001009B0 File Offset: 0x000FEBB0
	[Token(Token = "0x600301D")]
	[Address(RVA = "0x698EE0", Offset = "0x6974E0", VA = "0x180698EE0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 30;
	}

	// Token: 0x0600301E RID: 12318 RVA: 0x001009C0 File Offset: 0x000FEBC0
	[Token(Token = "0x600301E")]
	[Address(RVA = "0x6A9270", Offset = "0x6A7870", VA = "0x1806A9270", Slot = "24")]
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

	// Token: 0x0600301F RID: 12319 RVA: 0x00100A2C File Offset: 0x000FEC2C
	[Token(Token = "0x600301F")]
	[Address(RVA = "0x698EE0", Offset = "0x6974E0", VA = "0x180698EE0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Umbrellaleaf;
	}

	// Token: 0x06003020 RID: 12320 RVA: 0x00100A3C File Offset: 0x000FEC3C
	[Token(Token = "0x6003020")]
	[Address(RVA = "0x3AD3E0", Offset = "0x3AB9E0", VA = "0x1803AD3E0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Roof;
	}

	// Token: 0x06003021 RID: 12321 RVA: 0x00100A4C File Offset: 0x000FEC4C
	[Token(Token = "0x6003021")]
	[Address(RVA = "0x6A9210", Offset = "0x6A7810", VA = "0x1806A9210", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：巨人之怒";
	}

	// Token: 0x06003022 RID: 12322 RVA: 0x00100A60 File Offset: 0x000FEC60
	[Token(Token = "0x6003022")]
	[Address(RVA = "0x6A9240", Offset = "0x6A7840", VA = "0x1806A9240", Slot = "31")]
	public override string GetLevelTip()
	{
		return "危机预警：资源短缺";
	}

	// Token: 0x06003023 RID: 12323 RVA: 0x00100A74 File Offset: 0x000FEC74
	[Token(Token = "0x6003023")]
	[Address(RVA = "0x6A9590", Offset = "0x6A7B90", VA = "0x1806A9590", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.boardTag.lessSun = true;
		int num = board.theSun;
		num -= board;
		board.theSun = num;
		int num2 = board.theMoney;
		num2 -= board;
		board.theMoney = num2;
	}

	// Token: 0x06003024 RID: 12324 RVA: 0x00100AB8 File Offset: 0x000FECB8
	[Token(Token = "0x6003024")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public RoofSub5Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
