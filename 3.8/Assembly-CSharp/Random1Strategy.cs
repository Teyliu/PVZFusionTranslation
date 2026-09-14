using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200093C RID: 2364
[Token(Token = "0x200093C")]
public class Random1Strategy : BaseLevelStrategy
{
	// Token: 0x060030B0 RID: 12464 RVA: 0x001021A4 File Offset: 0x001003A4
	[Token(Token = "0x60030B0")]
	[Address(RVA = "0x3AE1D0", Offset = "0x3AC7D0", VA = "0x1803AE1D0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Random1;
	}

	// Token: 0x060030B1 RID: 12465 RVA: 0x001021B8 File Offset: 0x001003B8
	[Token(Token = "0x60030B1")]
	[Address(RVA = "0x3AAC80", Offset = "0x3A9280", VA = "0x1803AAC80", Slot = "23")]
	public override int GetMaxWave()
	{
		return 100;
	}

	// Token: 0x060030B2 RID: 12466 RVA: 0x001021C8 File Offset: 0x001003C8
	[Token(Token = "0x60030B2")]
	[Address(RVA = "0x6A4920", Offset = "0x6A2F20", VA = "0x1806A4920", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		return list;
	}

	// Token: 0x060030B3 RID: 12467 RVA: 0x00102204 File Offset: 0x00100404
	[Token(Token = "0x60030B3")]
	[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.SunFlower;
	}

	// Token: 0x060030B4 RID: 12468 RVA: 0x00102214 File Offset: 0x00100414
	[Token(Token = "0x60030B4")]
	[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Pool;
	}

	// Token: 0x060030B5 RID: 12469 RVA: 0x00102224 File Offset: 0x00100424
	[Token(Token = "0x60030B5")]
	[Address(RVA = "0x6A48F0", Offset = "0x6A2EF0", VA = "0x1806A48F0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉番外篇：随机植物VS随机僵尸";
	}

	// Token: 0x060030B6 RID: 12470 RVA: 0x00102238 File Offset: 0x00100438
	[Token(Token = "0x60030B6")]
	[Address(RVA = "0x6A4EC0", Offset = "0x6A34C0", VA = "0x1806A4EC0", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.boardTag.disableSelectCard = true;
		board.cardBank = true;
		board.boardTag.isSuperRandom = true;
		board.theSun = (int)((ulong)1000L);
	}

	// Token: 0x060030B7 RID: 12471 RVA: 0x00102278 File Offset: 0x00100478
	[Token(Token = "0x60030B7")]
	[Address(RVA = "0x6A4A40", Offset = "0x6A3040", VA = "0x1806A4A40", Slot = "35")]
	public override void InitCard(InitBoard board)
	{
		int num = 0;
		num++;
		CardUI cardUI;
		cardUI.theSeedCost = (int)((ulong)200L);
		Action<Plant> action;
		if (Random1Strategy.<>c.<>9__7_0 == 0)
		{
			Random1Strategy.<>c.<>9__7_0 = action;
		}
		cardUI.plantAction = action;
		CardUI cardUI2;
		cardUI2.theSeedCost = (int)((ulong)300L);
		Action<Plant> action2;
		if (Random1Strategy.<>c.<>9__7_1 == 0)
		{
			Random1Strategy.<>c.<>9__7_1 = action2;
		}
		cardUI2.plantAction = action2;
		CardUI cardUI3;
		cardUI3.theSeedCost = (int)((ulong)400L);
		Action<Plant> action3;
		if (Random1Strategy.<>c.<>9__7_2 == 0)
		{
			Random1Strategy.<>c.<>9__7_2 = action3;
		}
		cardUI3.plantAction = action3;
		CardUI cardUI4;
		cardUI4.theSeedCost = (int)((ulong)2000L);
		Action<Plant> action4;
		if (Random1Strategy.<>c.<>9__7_3 == 0)
		{
			Random1Strategy.<>c.<>9__7_3 = action4;
		}
		cardUI4.plantAction = action4;
	}

	// Token: 0x060030B8 RID: 12472 RVA: 0x00102328 File Offset: 0x00100528
	[Token(Token = "0x60030B8")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public Random1Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
