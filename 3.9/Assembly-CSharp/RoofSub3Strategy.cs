using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using GameLevel;

// Token: 0x02000960 RID: 2400
[Token(Token = "0x2000960")]
public class RoofSub3Strategy : BaseLevelStrategy
{
	// Token: 0x0600313D RID: 12605 RVA: 0x00105448 File Offset: 0x00103648
	[Token(Token = "0x600313D")]
	[Address(RVA = "0x51F6D0", Offset = "0x51DCD0", VA = "0x18051F6D0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Roof_sub3;
	}

	// Token: 0x0600313E RID: 12606 RVA: 0x00105458 File Offset: 0x00103658
	[Token(Token = "0x600313E")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x0600313F RID: 12607 RVA: 0x00105468 File Offset: 0x00103668
	[Token(Token = "0x600313F")]
	[Address(RVA = "0x722A10", Offset = "0x721010", VA = "0x180722A10", Slot = "24")]
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

	// Token: 0x06003140 RID: 12608 RVA: 0x001054C4 File Offset: 0x001036C4
	[Token(Token = "0x6003140")]
	[Address(RVA = "0x712FE0", Offset = "0x7115E0", VA = "0x180712FE0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Umbrellaleaf;
	}

	// Token: 0x06003141 RID: 12609 RVA: 0x001054D4 File Offset: 0x001036D4
	[Token(Token = "0x6003141")]
	[Address(RVA = "0x3F9250", Offset = "0x3F7850", VA = "0x1803F9250", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Roof;
	}

	// Token: 0x06003142 RID: 12610 RVA: 0x001054E4 File Offset: 0x001036E4
	[Token(Token = "0x6003142")]
	[Address(RVA = "0x7229E0", Offset = "0x720FE0", VA = "0x1807229E0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：你看，他们像柱子一样";
	}

	// Token: 0x06003143 RID: 12611 RVA: 0x001054F8 File Offset: 0x001036F8
	[Token(Token = "0x6003143")]
	[Address(RVA = "0x722CB0", Offset = "0x7212B0", VA = "0x180722CB0", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.boardTag.isColumn = true;
		BoardConfig config = board.config;
		board.timeUntilNextWave = 6f;
		config.waveInterval = 15f;
	}

	// Token: 0x06003144 RID: 12612 RVA: 0x00105534 File Offset: 0x00103734
	[Token(Token = "0x6003144")]
	[Address(RVA = "0x722C80", Offset = "0x721280", VA = "0x180722C80", Slot = "35")]
	public override void InitCard(InitBoard board)
	{
		CardUI cardUI = board.PreSelect((PlantType)((uint)32));
	}

	// Token: 0x06003145 RID: 12613 RVA: 0x00105554 File Offset: 0x00103754
	[Token(Token = "0x6003145")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public RoofSub3Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
