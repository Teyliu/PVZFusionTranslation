using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000922 RID: 2338
[Token(Token = "0x2000922")]
public class RoofSub1Strategy : BaseLevelStrategy
{
	// Token: 0x06002FFA RID: 12282 RVA: 0x001004C8 File Offset: 0x000FE6C8
	[Token(Token = "0x6002FFA")]
	[Address(RVA = "0x4A0630", Offset = "0x49EC30", VA = "0x1804A0630", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Roof_sub1;
	}

	// Token: 0x06002FFB RID: 12283 RVA: 0x001004D8 File Offset: 0x000FE6D8
	[Token(Token = "0x6002FFB")]
	[Address(RVA = "0x6A8500", Offset = "0x6A6B00", VA = "0x1806A8500", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.boardTag.disableSelectCard = true;
		board.cardBank = false;
		board.boardTag.isConvey = true;
		board.boardTag.bungiBattle = true;
	}

	// Token: 0x06002FFC RID: 12284 RVA: 0x00100518 File Offset: 0x000FE718
	[Token(Token = "0x6002FFC")]
	[Address(RVA = "0x6A8090", Offset = "0x6A6690", VA = "0x1806A8090", Slot = "26")]
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

	// Token: 0x06002FFD RID: 12285 RVA: 0x00100590 File Offset: 0x000FE790
	[Token(Token = "0x6002FFD")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06002FFE RID: 12286 RVA: 0x001005A0 File Offset: 0x000FE7A0
	[Token(Token = "0x6002FFE")]
	[Address(RVA = "0x6A8430", Offset = "0x6A6A30", VA = "0x1806A8430", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		return list;
	}

	// Token: 0x06002FFF RID: 12287 RVA: 0x001005D4 File Offset: 0x000FE7D4
	[Token(Token = "0x6002FFF")]
	[Address(RVA = "0x3ABC00", Offset = "0x3AA200", VA = "0x1803ABC00", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Chomper;
	}

	// Token: 0x06003000 RID: 12288 RVA: 0x001005E4 File Offset: 0x000FE7E4
	[Token(Token = "0x6003000")]
	[Address(RVA = "0x3AD3E0", Offset = "0x3AB9E0", VA = "0x1803AD3E0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Roof;
	}

	// Token: 0x06003001 RID: 12289 RVA: 0x001005F4 File Offset: 0x000FE7F4
	[Token(Token = "0x6003001")]
	[Address(RVA = "0x6A8400", Offset = "0x6A6A00", VA = "0x1806A8400", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：蹦极闪电战";
	}

	// Token: 0x06003002 RID: 12290 RVA: 0x00100608 File Offset: 0x000FE808
	[Token(Token = "0x6003002")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public RoofSub1Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
