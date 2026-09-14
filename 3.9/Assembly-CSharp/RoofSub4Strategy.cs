using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000961 RID: 2401
[Token(Token = "0x2000961")]
public class RoofSub4Strategy : BaseLevelStrategy
{
	// Token: 0x06003146 RID: 12614 RVA: 0x0010556C File Offset: 0x0010376C
	[Token(Token = "0x6003146")]
	[Address(RVA = "0x723090", Offset = "0x721690", VA = "0x180723090", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Roof_sub4;
	}

	// Token: 0x06003147 RID: 12615 RVA: 0x0010557C File Offset: 0x0010377C
	[Token(Token = "0x6003147")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06003148 RID: 12616 RVA: 0x0010558C File Offset: 0x0010378C
	[Token(Token = "0x6003148")]
	[Address(RVA = "0x7230A0", Offset = "0x7216A0", VA = "0x1807230A0", Slot = "24")]
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

	// Token: 0x06003149 RID: 12617 RVA: 0x001055F0 File Offset: 0x001037F0
	[Token(Token = "0x6003149")]
	[Address(RVA = "0x712FE0", Offset = "0x7115E0", VA = "0x180712FE0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Umbrellaleaf;
	}

	// Token: 0x0600314A RID: 12618 RVA: 0x00105600 File Offset: 0x00103800
	[Token(Token = "0x600314A")]
	[Address(RVA = "0x3F9250", Offset = "0x3F7850", VA = "0x1803F9250", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Roof;
	}

	// Token: 0x0600314B RID: 12619 RVA: 0x00105610 File Offset: 0x00103810
	[Token(Token = "0x600314B")]
	[Address(RVA = "0x723060", Offset = "0x721660", VA = "0x180723060", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：屋顶传送带";
	}

	// Token: 0x0600314C RID: 12620 RVA: 0x00105624 File Offset: 0x00103824
	[Token(Token = "0x600314C")]
	[Address(RVA = "0x712F40", Offset = "0x711540", VA = "0x180712F40", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.cardBank = false;
		board.boardTag.disableSelectCard = true;
		board.boardTag.isConvey = true;
		board.timeUntilNextWave = 3f;
	}

	// Token: 0x0600314D RID: 12621 RVA: 0x00105664 File Offset: 0x00103864
	[Token(Token = "0x600314D")]
	[Address(RVA = "0x722CF0", Offset = "0x7212F0", VA = "0x180722CF0", Slot = "26")]
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

	// Token: 0x0600314E RID: 12622 RVA: 0x001056D8 File Offset: 0x001038D8
	[Token(Token = "0x600314E")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public RoofSub4Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
