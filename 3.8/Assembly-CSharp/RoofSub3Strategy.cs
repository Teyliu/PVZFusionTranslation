using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using GameLevel;

// Token: 0x02000924 RID: 2340
[Token(Token = "0x2000924")]
public class RoofSub3Strategy : BaseLevelStrategy
{
	// Token: 0x0600300A RID: 12298 RVA: 0x001006F8 File Offset: 0x000FE8F8
	[Token(Token = "0x600300A")]
	[Address(RVA = "0x49F980", Offset = "0x49DF80", VA = "0x18049F980", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Roof_sub3;
	}

	// Token: 0x0600300B RID: 12299 RVA: 0x00100708 File Offset: 0x000FE908
	[Token(Token = "0x600300B")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x0600300C RID: 12300 RVA: 0x00100718 File Offset: 0x000FE918
	[Token(Token = "0x600300C")]
	[Address(RVA = "0x6A88B0", Offset = "0x6A6EB0", VA = "0x1806A88B0", Slot = "24")]
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

	// Token: 0x0600300D RID: 12301 RVA: 0x00100774 File Offset: 0x000FE974
	[Token(Token = "0x600300D")]
	[Address(RVA = "0x698EE0", Offset = "0x6974E0", VA = "0x180698EE0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Umbrellaleaf;
	}

	// Token: 0x0600300E RID: 12302 RVA: 0x00100784 File Offset: 0x000FE984
	[Token(Token = "0x600300E")]
	[Address(RVA = "0x3AD3E0", Offset = "0x3AB9E0", VA = "0x1803AD3E0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Roof;
	}

	// Token: 0x0600300F RID: 12303 RVA: 0x00100794 File Offset: 0x000FE994
	[Token(Token = "0x600300F")]
	[Address(RVA = "0x6A8880", Offset = "0x6A6E80", VA = "0x1806A8880", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：你看，他们像柱子一样";
	}

	// Token: 0x06003010 RID: 12304 RVA: 0x001007A8 File Offset: 0x000FE9A8
	[Token(Token = "0x6003010")]
	[Address(RVA = "0x6A8B50", Offset = "0x6A7150", VA = "0x1806A8B50", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.boardTag.isColumn = true;
		BoardConfig config = board.config;
		board.timeUntilNextWave = 6f;
		config.waveInterval = 15f;
	}

	// Token: 0x06003011 RID: 12305 RVA: 0x001007E4 File Offset: 0x000FE9E4
	[Token(Token = "0x6003011")]
	[Address(RVA = "0x6A8B20", Offset = "0x6A7120", VA = "0x1806A8B20", Slot = "35")]
	public override void InitCard(InitBoard board)
	{
		CardUI cardUI = board.PreSelect((PlantType)((uint)32));
	}

	// Token: 0x06003012 RID: 12306 RVA: 0x00100804 File Offset: 0x000FEA04
	[Token(Token = "0x6003012")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public RoofSub3Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
