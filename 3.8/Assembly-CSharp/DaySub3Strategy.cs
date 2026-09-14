using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020008D2 RID: 2258
[Token(Token = "0x20008D2")]
public class DaySub3Strategy : BaseLevelStrategy
{
	// Token: 0x06002DF2 RID: 11762 RVA: 0x000FB3DC File Offset: 0x000F95DC
	[Token(Token = "0x6002DF2")]
	[Address(RVA = "0x3AC960", Offset = "0x3AAF60", VA = "0x1803AC960", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Day_sub3;
	}

	// Token: 0x06002DF3 RID: 11763 RVA: 0x000FB3EC File Offset: 0x000F95EC
	[Token(Token = "0x6002DF3")]
	[Address(RVA = "0x698E40", Offset = "0x697440", VA = "0x180698E40", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.cardBank = false;
		board.boardTag.disableSelectCard = true;
		board.boardTag.isConvey = true;
		board.timeUntilNextWave = 3f;
	}

	// Token: 0x06002DF4 RID: 11764 RVA: 0x000FB42C File Offset: 0x000F962C
	[Token(Token = "0x6002DF4")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06002DF5 RID: 11765 RVA: 0x000FB43C File Offset: 0x000F963C
	[Token(Token = "0x6002DF5")]
	[Address(RVA = "0x698C20", Offset = "0x697220", VA = "0x180698C20", Slot = "24")]
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

	// Token: 0x06002DF6 RID: 11766 RVA: 0x000FB494 File Offset: 0x000F9694
	[Token(Token = "0x6002DF6")]
	[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.WallNut;
	}

	// Token: 0x06002DF7 RID: 11767 RVA: 0x000FB4A4 File Offset: 0x000F96A4
	[Token(Token = "0x6002DF7")]
	[Address(RVA = "0x698980", Offset = "0x696F80", VA = "0x180698980", Slot = "26")]
	public override List<PlantType> GetConveyPlants()
	{
		List<PlantType> list = new List();
		int size = list._size;
		list._size = 1;
		list._syncRoot = (ulong)0L;
		int size2 = list._size;
		list._size = 1;
		int size3 = list._size;
		list._size = 1;
		int size4 = list._size;
		list._size = 1;
		int size5 = list._size;
		list._size = 1;
		int size6 = list._size;
		return list;
	}

	// Token: 0x06002DF8 RID: 11768 RVA: 0x000FB534 File Offset: 0x000F9734
	[Token(Token = "0x6002DF8")]
	[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Day;
	}

	// Token: 0x06002DF9 RID: 11769 RVA: 0x000FB54C File Offset: 0x000F974C
	[Token(Token = "0x6002DF9")]
	[Address(RVA = "0x698BF0", Offset = "0x6971F0", VA = "0x180698BF0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：白天传送带";
	}

	// Token: 0x06002DFA RID: 11770 RVA: 0x000FB560 File Offset: 0x000F9760
	[Token(Token = "0x6002DFA")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public DaySub3Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
