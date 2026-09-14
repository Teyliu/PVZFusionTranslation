using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000978 RID: 2424
[Token(Token = "0x2000978")]
public class Random1Strategy : BaseLevelStrategy
{
	// Token: 0x060031E3 RID: 12771 RVA: 0x00106F14 File Offset: 0x00105114
	[Token(Token = "0x60031E3")]
	[Address(RVA = "0x3FA040", Offset = "0x3F8640", VA = "0x1803FA040", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Random1;
	}

	// Token: 0x060031E4 RID: 12772 RVA: 0x00106F28 File Offset: 0x00105128
	[Token(Token = "0x60031E4")]
	[Address(RVA = "0x3F6A80", Offset = "0x3F5080", VA = "0x1803F6A80", Slot = "23")]
	public override int GetMaxWave()
	{
		return 100;
	}

	// Token: 0x060031E5 RID: 12773 RVA: 0x00106F38 File Offset: 0x00105138
	[Token(Token = "0x60031E5")]
	[Address(RVA = "0x71EA80", Offset = "0x71D080", VA = "0x18071EA80", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		return list;
	}

	// Token: 0x060031E6 RID: 12774 RVA: 0x00106F74 File Offset: 0x00105174
	[Token(Token = "0x60031E6")]
	[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.SunFlower;
	}

	// Token: 0x060031E7 RID: 12775 RVA: 0x00106F84 File Offset: 0x00105184
	[Token(Token = "0x60031E7")]
	[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Pool;
	}

	// Token: 0x060031E8 RID: 12776 RVA: 0x00106F94 File Offset: 0x00105194
	[Token(Token = "0x60031E8")]
	[Address(RVA = "0x71EA50", Offset = "0x71D050", VA = "0x18071EA50", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉番外篇：随机植物VS随机僵尸";
	}

	// Token: 0x060031E9 RID: 12777 RVA: 0x00106FA8 File Offset: 0x001051A8
	[Token(Token = "0x60031E9")]
	[Address(RVA = "0x71F020", Offset = "0x71D620", VA = "0x18071F020", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.boardTag.disableSelectCard = true;
		board.cardBank = true;
		board.boardTag.isSuperRandom = true;
		board.theSun = (int)((ulong)1000L);
	}

	// Token: 0x060031EA RID: 12778 RVA: 0x00106FE8 File Offset: 0x001051E8
	[Token(Token = "0x60031EA")]
	[Address(RVA = "0x71EBA0", Offset = "0x71D1A0", VA = "0x18071EBA0", Slot = "35")]
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

	// Token: 0x060031EB RID: 12779 RVA: 0x00107098 File Offset: 0x00105298
	[Token(Token = "0x60031EB")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Random1Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
