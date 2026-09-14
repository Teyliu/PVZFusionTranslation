using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000925 RID: 2341
[Token(Token = "0x2000925")]
public class RoofSub4Strategy : BaseLevelStrategy
{
	// Token: 0x06003013 RID: 12307 RVA: 0x0010081C File Offset: 0x000FEA1C
	[Token(Token = "0x6003013")]
	[Address(RVA = "0x6A8F30", Offset = "0x6A7530", VA = "0x1806A8F30", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Roof_sub4;
	}

	// Token: 0x06003014 RID: 12308 RVA: 0x0010082C File Offset: 0x000FEA2C
	[Token(Token = "0x6003014")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06003015 RID: 12309 RVA: 0x0010083C File Offset: 0x000FEA3C
	[Token(Token = "0x6003015")]
	[Address(RVA = "0x6A8F40", Offset = "0x6A7540", VA = "0x1806A8F40", Slot = "24")]
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

	// Token: 0x06003016 RID: 12310 RVA: 0x001008A0 File Offset: 0x000FEAA0
	[Token(Token = "0x6003016")]
	[Address(RVA = "0x698EE0", Offset = "0x6974E0", VA = "0x180698EE0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Umbrellaleaf;
	}

	// Token: 0x06003017 RID: 12311 RVA: 0x001008B0 File Offset: 0x000FEAB0
	[Token(Token = "0x6003017")]
	[Address(RVA = "0x3AD3E0", Offset = "0x3AB9E0", VA = "0x1803AD3E0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Roof;
	}

	// Token: 0x06003018 RID: 12312 RVA: 0x001008C0 File Offset: 0x000FEAC0
	[Token(Token = "0x6003018")]
	[Address(RVA = "0x6A8F00", Offset = "0x6A7500", VA = "0x1806A8F00", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：屋顶传送带";
	}

	// Token: 0x06003019 RID: 12313 RVA: 0x001008D4 File Offset: 0x000FEAD4
	[Token(Token = "0x6003019")]
	[Address(RVA = "0x698E40", Offset = "0x697440", VA = "0x180698E40", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.cardBank = false;
		board.boardTag.disableSelectCard = true;
		board.boardTag.isConvey = true;
		board.timeUntilNextWave = 3f;
	}

	// Token: 0x0600301A RID: 12314 RVA: 0x00100914 File Offset: 0x000FEB14
	[Token(Token = "0x600301A")]
	[Address(RVA = "0x6A8B90", Offset = "0x6A7190", VA = "0x1806A8B90", Slot = "26")]
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

	// Token: 0x0600301B RID: 12315 RVA: 0x00100988 File Offset: 0x000FEB88
	[Token(Token = "0x600301B")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public RoofSub4Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
