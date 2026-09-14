using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000939 RID: 2361
[Token(Token = "0x2000939")]
public class SnowSub5Strategy : BaseLevelStrategy
{
	// Token: 0x0600309B RID: 12443 RVA: 0x00101ED4 File Offset: 0x001000D4
	[Token(Token = "0x600309B")]
	[Address(RVA = "0x4E9AF0", Offset = "0x4E80F0", VA = "0x1804E9AF0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Snow_sub5;
	}

	// Token: 0x0600309C RID: 12444 RVA: 0x00101EE4 File Offset: 0x001000E4
	[Token(Token = "0x600309C")]
	[Address(RVA = "0x698EE0", Offset = "0x6974E0", VA = "0x180698EE0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 30;
	}

	// Token: 0x0600309D RID: 12445 RVA: 0x00101EF4 File Offset: 0x001000F4
	[Token(Token = "0x600309D")]
	[Address(RVA = "0x6AD070", Offset = "0x6AB670", VA = "0x1806AD070", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		int size5 = list._size;
		int size6 = list._size;
		return list;
	}

	// Token: 0x0600309E RID: 12446 RVA: 0x00101F50 File Offset: 0x00100150
	[Token(Token = "0x600309E")]
	[Address(RVA = "0x6A42A0", Offset = "0x6A28A0", VA = "0x1806A42A0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.PineFurnace;
	}

	// Token: 0x0600309F RID: 12447 RVA: 0x00101F60 File Offset: 0x00100160
	[Token(Token = "0x600309F")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Snow_6;
	}

	// Token: 0x060030A0 RID: 12448 RVA: 0x00101F70 File Offset: 0x00100170
	[Token(Token = "0x60030A0")]
	[Address(RVA = "0x6AD010", Offset = "0x6AB610", VA = "0x1806AD010", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：雪皇之怒";
	}

	// Token: 0x060030A1 RID: 12449 RVA: 0x00101F84 File Offset: 0x00100184
	[Token(Token = "0x60030A1")]
	[Address(RVA = "0x6AD040", Offset = "0x6AB640", VA = "0x1806AD040", Slot = "31")]
	public override string GetLevelTip()
	{
		return "危机预警：资源短缺";
	}

	// Token: 0x060030A2 RID: 12450 RVA: 0x00101F98 File Offset: 0x00100198
	[Token(Token = "0x60030A2")]
	[Address(RVA = "0x6AD2E0", Offset = "0x6AB8E0", VA = "0x1806AD2E0", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.boardTag.snowBoss = true;
		board.boardTag.lessSun = true;
		int num = board.theSun;
		num -= board;
		board.theSun = num;
		int num2 = board.theMoney;
		num2 -= board;
		board.theMoney = num2;
	}

	// Token: 0x060030A3 RID: 12451 RVA: 0x00101FE8 File Offset: 0x001001E8
	[Token(Token = "0x60030A3")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public SnowSub5Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
