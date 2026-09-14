using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020008D0 RID: 2256
[Token(Token = "0x20008D0")]
public class DaySub1Strategy : BaseLevelStrategy
{
	// Token: 0x06002DE1 RID: 11745 RVA: 0x000FB1B0 File Offset: 0x000F93B0
	[Token(Token = "0x6002DE1")]
	[Address(RVA = "0x3AE560", Offset = "0x3ACB60", VA = "0x1803AE560", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Day_sub1;
	}

	// Token: 0x06002DE2 RID: 11746 RVA: 0x000FB1C0 File Offset: 0x000F93C0
	[Token(Token = "0x6002DE2")]
	[Address(RVA = "0x6987E0", Offset = "0x696DE0", VA = "0x1806987E0", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.boardTag.isLoonGame = true;
		board.SetRedLine(2);
		board.cardBank = false;
		board.boardTag.disableSelectCard = true;
		board.boardTag.isConvey = true;
		board.timeUntilNextWave = 3f;
	}

	// Token: 0x06002DE3 RID: 11747 RVA: 0x000FB210 File Offset: 0x000F9410
	[Token(Token = "0x6002DE3")]
	[Address(RVA = "0x3AA5A0", Offset = "0x3A8BA0", VA = "0x1803AA5A0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 10;
	}

	// Token: 0x06002DE4 RID: 11748 RVA: 0x000FB220 File Offset: 0x000F9420
	[Token(Token = "0x6002DE4")]
	[Address(RVA = "0x698670", Offset = "0x696C70", VA = "0x180698670", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		return list;
	}

	// Token: 0x06002DE5 RID: 11749 RVA: 0x000FB268 File Offset: 0x000F9468
	[Token(Token = "0x6002DE5")]
	[Address(RVA = "0x3ABC00", Offset = "0x3AA200", VA = "0x1803ABC00", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Chomper;
	}

	// Token: 0x06002DE6 RID: 11750 RVA: 0x000FB278 File Offset: 0x000F9478
	[Token(Token = "0x6002DE6")]
	[Address(RVA = "0x698390", Offset = "0x696990", VA = "0x180698390", Slot = "26")]
	public override List<PlantType> GetConveyPlants()
	{
		List<PlantType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		int size5 = list._size;
		int size6 = list._size;
		return list;
	}

	// Token: 0x06002DE7 RID: 11751 RVA: 0x000FB2D4 File Offset: 0x000F94D4
	[Token(Token = "0x6002DE7")]
	[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Day;
	}

	// Token: 0x06002DE8 RID: 11752 RVA: 0x000FB2EC File Offset: 0x000F94EC
	[Token(Token = "0x6002DE8")]
	[Address(RVA = "0x698610", Offset = "0x696C10", VA = "0x180698610", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：坚果保龄球";
	}

	// Token: 0x06002DE9 RID: 11753 RVA: 0x000FB300 File Offset: 0x000F9500
	[Token(Token = "0x6002DE9")]
	[Address(RVA = "0x698640", Offset = "0x696C40", VA = "0x180698640", Slot = "31")]
	public override string GetLevelTip()
	{
		return "如果打不过多注意一下主线第四关";
	}

	// Token: 0x06002DEA RID: 11754 RVA: 0x000FB314 File Offset: 0x000F9514
	[Token(Token = "0x6002DEA")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public DaySub1Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
