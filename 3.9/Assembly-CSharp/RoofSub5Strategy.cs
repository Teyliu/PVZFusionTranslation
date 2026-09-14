using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000962 RID: 2402
[Token(Token = "0x2000962")]
public class RoofSub5Strategy : BaseLevelStrategy
{
	// Token: 0x0600314F RID: 12623 RVA: 0x001056F0 File Offset: 0x001038F0
	[Token(Token = "0x600314F")]
	[Address(RVA = "0x4A8140", Offset = "0x4A6740", VA = "0x1804A8140", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Roof_sub5;
	}

	// Token: 0x06003150 RID: 12624 RVA: 0x00105700 File Offset: 0x00103900
	[Token(Token = "0x6003150")]
	[Address(RVA = "0x712FE0", Offset = "0x7115E0", VA = "0x180712FE0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 30;
	}

	// Token: 0x06003151 RID: 12625 RVA: 0x00105710 File Offset: 0x00103910
	[Token(Token = "0x6003151")]
	[Address(RVA = "0x7233D0", Offset = "0x7219D0", VA = "0x1807233D0", Slot = "24")]
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

	// Token: 0x06003152 RID: 12626 RVA: 0x0010577C File Offset: 0x0010397C
	[Token(Token = "0x6003152")]
	[Address(RVA = "0x712FE0", Offset = "0x7115E0", VA = "0x180712FE0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Umbrellaleaf;
	}

	// Token: 0x06003153 RID: 12627 RVA: 0x0010578C File Offset: 0x0010398C
	[Token(Token = "0x6003153")]
	[Address(RVA = "0x3F9250", Offset = "0x3F7850", VA = "0x1803F9250", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Roof;
	}

	// Token: 0x06003154 RID: 12628 RVA: 0x0010579C File Offset: 0x0010399C
	[Token(Token = "0x6003154")]
	[Address(RVA = "0x723370", Offset = "0x721970", VA = "0x180723370", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：巨人之怒";
	}

	// Token: 0x06003155 RID: 12629 RVA: 0x001057B0 File Offset: 0x001039B0
	[Token(Token = "0x6003155")]
	[Address(RVA = "0x7233A0", Offset = "0x7219A0", VA = "0x1807233A0", Slot = "31")]
	public override string GetLevelTip()
	{
		return "危机预警：资源短缺";
	}

	// Token: 0x06003156 RID: 12630 RVA: 0x001057C4 File Offset: 0x001039C4
	[Token(Token = "0x6003156")]
	[Address(RVA = "0x7236F0", Offset = "0x721CF0", VA = "0x1807236F0", Slot = "21")]
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

	// Token: 0x06003157 RID: 12631 RVA: 0x00105808 File Offset: 0x00103A08
	[Token(Token = "0x6003157")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public RoofSub5Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
