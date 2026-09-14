using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;

// Token: 0x020009FB RID: 2555
[Token(Token = "0x20009FB")]
public class ScaryPot5 : ScaryPotLevel
{
	// Token: 0x0600347C RID: 13436 RVA: 0x00114ADC File Offset: 0x00112CDC
	[Token(Token = "0x600347C")]
	[Address(RVA = "0x772DE0", Offset = "0x7713E0", VA = "0x180772DE0", Slot = "36")]
	public override void OnBoardStart(Board board)
	{
		int theMaxWave = board.theMaxWave;
		board.theWave = theMaxWave;
		int theBoardLevel = GameAPP.theBoardLevel;
		InGameText instance = InGameText.Instance;
	}

	// Token: 0x17000249 RID: 585
	// (get) Token: 0x0600347D RID: 13437 RVA: 0x00114B0C File Offset: 0x00112D0C
	[Token(Token = "0x17000249")]
	public override string Name
	{
		[Token(Token = "0x600347D")]
		[Address(RVA = "0x772EC0", Offset = "0x7714C0", VA = "0x180772EC0", Slot = "8")]
		get
		{
			return "绝对火力";
		}
	}

	// Token: 0x1700024A RID: 586
	// (get) Token: 0x0600347E RID: 13438 RVA: 0x00114B20 File Offset: 0x00112D20
	[Token(Token = "0x1700024A")]
	protected override ChallengeLevel Level
	{
		[Token(Token = "0x600347E")]
		[Address(RVA = "0x772EB0", Offset = "0x7714B0", VA = "0x180772EB0", Slot = "42")]
		get
		{
			return ChallengeLevel.ScaryPot5;
		}
	}

	// Token: 0x1700024B RID: 587
	// (get) Token: 0x0600347F RID: 13439 RVA: 0x00114B34 File Offset: 0x00112D34
	[Token(Token = "0x1700024B")]
	public override int HypnoCount
	{
		[Token(Token = "0x600347F")]
		[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "47")]
		get
		{
			return 1;
		}
	}

	// Token: 0x1700024C RID: 588
	// (get) Token: 0x06003480 RID: 13440 RVA: 0x00114B44 File Offset: 0x00112D44
	[Token(Token = "0x1700024C")]
	public override int EmptyColumns
	{
		[Token(Token = "0x6003480")]
		[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "43")]
		get
		{
			return 2;
		}
	}

	// Token: 0x1700024D RID: 589
	// (get) Token: 0x06003481 RID: 13441 RVA: 0x00114B54 File Offset: 0x00112D54
	[Token(Token = "0x1700024D")]
	public override int NumberOfColumns
	{
		[Token(Token = "0x6003481")]
		[Address(RVA = "0x3F6B70", Offset = "0x3F5170", VA = "0x1803F6B70", Slot = "44")]
		get
		{
			return 8;
		}
	}

	// Token: 0x1700024E RID: 590
	// (get) Token: 0x06003482 RID: 13442 RVA: 0x00114B64 File Offset: 0x00112D64
	[Token(Token = "0x1700024E")]
	public override int NumberOfRows
	{
		[Token(Token = "0x6003482")]
		[Address(RVA = "0x3F7A00", Offset = "0x3F6000", VA = "0x1803F7A00", Slot = "45")]
		get
		{
			return 5;
		}
	}

	// Token: 0x1700024F RID: 591
	// (get) Token: 0x06003483 RID: 13443 RVA: 0x00114B74 File Offset: 0x00112D74
	[Token(Token = "0x1700024F")]
	public override int GreenCount
	{
		[Token(Token = "0x6003483")]
		[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "46")]
		get
		{
			return 3;
		}
	}

	// Token: 0x17000250 RID: 592
	// (get) Token: 0x06003484 RID: 13444 RVA: 0x00114B84 File Offset: 0x00112D84
	[Token(Token = "0x17000250")]
	public override List<PlantType> Plants
	{
		[Token(Token = "0x6003484")]
		[Address(RVA = "0x772EF0", Offset = "0x7714F0", VA = "0x180772EF0", Slot = "50")]
		get
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
			int size13 = list._size;
			int size14 = list._size;
			int size15 = list._size;
			int size16 = list._size;
			int size17 = list._size;
			int size18 = list._size;
			int size19 = list._size;
			int size20 = list._size;
			return list;
		}
	}

	// Token: 0x17000251 RID: 593
	// (get) Token: 0x06003485 RID: 13445 RVA: 0x00114C50 File Offset: 0x00112E50
	[Token(Token = "0x17000251")]
	public override List<ZombieType> Zombies
	{
		[Token(Token = "0x6003485")]
		[Address(RVA = "0x773610", Offset = "0x771C10", VA = "0x180773610", Slot = "49")]
		get
		{
			List<ZombieType> list = new List();
			int size = list._size;
			int size2 = list._size;
			int size3 = list._size;
			int size4 = list._size;
			int size5 = list._size;
			int size6 = list._size;
			list._size = 1;
			list._syncRoot = (ulong)0L;
			int size7 = list._size;
			list._size = 1;
			int size8 = list._size;
			list._size = 1;
			int size9 = list._size;
			list._size = 1;
			int size10 = list._size;
			list._size = 1;
			int size11 = list._size;
			list._size = 1;
			int size12 = list._size;
			list._size = 1;
			int size13 = list._size;
			list._size = 1;
			int size14 = list._size;
			list._size = 1;
			int size15 = list._size;
			list._size = 1;
			int size16 = list._size;
			list._size = 1;
			int size17 = list._size;
			list._size = 1;
			int size18 = list._size;
			list._size = 1;
			int size19 = list._size;
			list._size = 1;
			int size20 = list._size;
			return list;
		}
	}

	// Token: 0x06003486 RID: 13446 RVA: 0x00114D8C File Offset: 0x00112F8C
	[Token(Token = "0x6003486")]
	[Address(RVA = "0x7602C0", Offset = "0x75E8C0", VA = "0x1807602C0")]
	public ScaryPot5()
	{
	}
}
