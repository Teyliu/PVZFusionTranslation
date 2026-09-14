using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000938 RID: 2360
[Token(Token = "0x2000938")]
public class SnowSub4Strategy : BaseLevelStrategy
{
	// Token: 0x06003092 RID: 12434 RVA: 0x00101D38 File Offset: 0x000FFF38
	[Token(Token = "0x6003092")]
	[Address(RVA = "0x49BD00", Offset = "0x49A300", VA = "0x18049BD00", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Snow_sub4;
	}

	// Token: 0x06003093 RID: 12435 RVA: 0x00101D48 File Offset: 0x000FFF48
	[Token(Token = "0x6003093")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06003094 RID: 12436 RVA: 0x00101D58 File Offset: 0x000FFF58
	[Token(Token = "0x6003094")]
	[Address(RVA = "0x6ACD40", Offset = "0x6AB340", VA = "0x1806ACD40", Slot = "24")]
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

	// Token: 0x06003095 RID: 12437 RVA: 0x00101DBC File Offset: 0x000FFFBC
	[Token(Token = "0x6003095")]
	[Address(RVA = "0x6A42A0", Offset = "0x6A28A0", VA = "0x1806A42A0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.PineFurnace;
	}

	// Token: 0x06003096 RID: 12438 RVA: 0x00101DCC File Offset: 0x000FFFCC
	[Token(Token = "0x6003096")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Snow_6;
	}

	// Token: 0x06003097 RID: 12439 RVA: 0x00101DDC File Offset: 0x000FFFDC
	[Token(Token = "0x6003097")]
	[Address(RVA = "0x6ACD10", Offset = "0x6AB310", VA = "0x1806ACD10", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：雪原传送带";
	}

	// Token: 0x06003098 RID: 12440 RVA: 0x00101DF0 File Offset: 0x000FFFF0
	[Token(Token = "0x6003098")]
	[Address(RVA = "0x698E40", Offset = "0x697440", VA = "0x180698E40", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.cardBank = false;
		board.boardTag.disableSelectCard = true;
		board.boardTag.isConvey = true;
		board.timeUntilNextWave = 3f;
	}

	// Token: 0x06003099 RID: 12441 RVA: 0x00101E30 File Offset: 0x00100030
	[Token(Token = "0x6003099")]
	[Address(RVA = "0x6AC890", Offset = "0x6AAE90", VA = "0x1806AC890", Slot = "26")]
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

	// Token: 0x0600309A RID: 12442 RVA: 0x00101EBC File Offset: 0x001000BC
	[Token(Token = "0x600309A")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public SnowSub4Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
