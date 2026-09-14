using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200093F RID: 2367
[Token(Token = "0x200093F")]
public class GraveChallengeStrategy : BaseLevelStrategy
{
	// Token: 0x060030C7 RID: 12487 RVA: 0x001024CC File Offset: 0x001006CC
	[Token(Token = "0x60030C7")]
	[Address(RVA = "0x3AD150", Offset = "0x3AB750", VA = "0x1803AD150", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.GraveChallenge;
	}

	// Token: 0x060030C8 RID: 12488 RVA: 0x001024E0 File Offset: 0x001006E0
	[Token(Token = "0x60030C8")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x060030C9 RID: 12489 RVA: 0x001024F0 File Offset: 0x001006F0
	[Token(Token = "0x60030C9")]
	[Address(RVA = "0x699E70", Offset = "0x698470", VA = "0x180699E70", Slot = "24")]
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
		int size9 = list._size;
		int size10 = list._size;
		return list;
	}

	// Token: 0x060030CA RID: 12490 RVA: 0x00102570 File Offset: 0x00100770
	[Token(Token = "0x60030CA")]
	[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.SunFlower;
	}

	// Token: 0x060030CB RID: 12491 RVA: 0x00102580 File Offset: 0x00100780
	[Token(Token = "0x60030CB")]
	[Address(RVA = "0x3AE560", Offset = "0x3ACB60", VA = "0x1803AE560", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Night_6;
	}

	// Token: 0x060030CC RID: 12492 RVA: 0x00102590 File Offset: 0x00100790
	[Token(Token = "0x60030CC")]
	[Address(RVA = "0x699E40", Offset = "0x698440", VA = "0x180699E40", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉挑战：你能挖掉它吗";
	}

	// Token: 0x060030CD RID: 12493 RVA: 0x001025A4 File Offset: 0x001007A4
	[Token(Token = "0x60030CD")]
	[Address(RVA = "0x69A270", Offset = "0x698870", VA = "0x18069A270", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		int num = 0;
		if (num < board.columnNum)
		{
			if (num < board.rowNum)
			{
				if (0UL != (ulong)1L)
				{
					int num2 = 0;
					GridItem gridItem = GridItem.SetGridItem(num, num, (GridItemType)((uint)7), (GraveType)num2);
					num++;
				}
				board.boardAction.SetPit(num, num).maxTimer = 360f;
				num++;
			}
			num++;
		}
	}

	// Token: 0x060030CE RID: 12494 RVA: 0x00102604 File Offset: 0x00100804
	[Token(Token = "0x60030CE")]
	[Address(RVA = "0x69A230", Offset = "0x698830", VA = "0x18069A230", Slot = "35")]
	public override void InitCard(InitBoard board)
	{
		board.PreSelect((PlantType)((uint)239)).fullCD = 15f;
	}

	// Token: 0x060030CF RID: 12495 RVA: 0x00102630 File Offset: 0x00100830
	[Token(Token = "0x60030CF")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public GraveChallengeStrategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
