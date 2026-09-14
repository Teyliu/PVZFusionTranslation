using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000940 RID: 2368
[Token(Token = "0x2000940")]
public class PitChallengeStrategy : BaseLevelStrategy
{
	// Token: 0x060030D0 RID: 12496 RVA: 0x00102648 File Offset: 0x00100848
	[Token(Token = "0x60030D0")]
	[Address(RVA = "0x3AC8C0", Offset = "0x3AAEC0", VA = "0x1803AC8C0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.PitChallenge;
	}

	// Token: 0x060030D1 RID: 12497 RVA: 0x0010265C File Offset: 0x0010085C
	[Token(Token = "0x60030D1")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x060030D2 RID: 12498 RVA: 0x0010266C File Offset: 0x0010086C
	[Token(Token = "0x60030D2")]
	[Address(RVA = "0x6A0910", Offset = "0x69EF10", VA = "0x1806A0910", Slot = "24")]
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

	// Token: 0x060030D3 RID: 12499 RVA: 0x001026C4 File Offset: 0x001008C4
	[Token(Token = "0x60030D3")]
	[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.SunFlower;
	}

	// Token: 0x060030D4 RID: 12500 RVA: 0x001026D4 File Offset: 0x001008D4
	[Token(Token = "0x60030D4")]
	[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.NightPool;
	}

	// Token: 0x060030D5 RID: 12501 RVA: 0x001026E4 File Offset: 0x001008E4
	[Token(Token = "0x60030D5")]
	[Address(RVA = "0x6A08E0", Offset = "0x69EEE0", VA = "0x1806A08E0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉挑战：你挖不掉它";
	}

	// Token: 0x060030D6 RID: 12502 RVA: 0x001026F8 File Offset: 0x001008F8
	[Token(Token = "0x60030D6")]
	[Address(RVA = "0x6A0B30", Offset = "0x69F130", VA = "0x1806A0B30", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		int num = 0;
		int num2 = 0;
		if (num2 < board.columnNum)
		{
			int num3 = 0;
			if (num3 < board.rowNum)
			{
				if (board.GetBoxType(num, num3) != BoxType.Water)
				{
					board.boardAction.SetPit(num, num3).maxTimer = 100000f;
				}
				num3++;
			}
			num++;
		}
	}

	// Token: 0x060030D7 RID: 12503 RVA: 0x00102750 File Offset: 0x00100950
	[Token(Token = "0x60030D7")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public PitChallengeStrategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
