using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;

// Token: 0x020009FA RID: 2554
[Token(Token = "0x20009FA")]
public class ScaryPot4 : ScaryPotLevel
{
	// Token: 0x06003471 RID: 13425 RVA: 0x00114888 File Offset: 0x00112A88
	[Token(Token = "0x6003471")]
	[Address(RVA = "0x771EA0", Offset = "0x7704A0", VA = "0x180771EA0", Slot = "36")]
	public override void OnBoardStart(Board board)
	{
		int theMaxWave = board.theMaxWave;
		board.theWave = theMaxWave;
		int theBoardLevel = GameAPP.theBoardLevel;
		InGameText instance = InGameText.Instance;
	}

	// Token: 0x17000240 RID: 576
	// (get) Token: 0x06003472 RID: 13426 RVA: 0x001148B8 File Offset: 0x00112AB8
	[Token(Token = "0x17000240")]
	public override string Name
	{
		[Token(Token = "0x6003472")]
		[Address(RVA = "0x771F70", Offset = "0x770570", VA = "0x180771F70", Slot = "8")]
		get
		{
			return "不走寻常路";
		}
	}

	// Token: 0x17000241 RID: 577
	// (get) Token: 0x06003473 RID: 13427 RVA: 0x001148CC File Offset: 0x00112ACC
	[Token(Token = "0x17000241")]
	protected override ChallengeLevel Level
	{
		[Token(Token = "0x6003473")]
		[Address(RVA = "0x52C7E0", Offset = "0x52ADE0", VA = "0x18052C7E0", Slot = "42")]
		get
		{
			return ChallengeLevel.ScaryPot4;
		}
	}

	// Token: 0x17000242 RID: 578
	// (get) Token: 0x06003474 RID: 13428 RVA: 0x001148E0 File Offset: 0x00112AE0
	[Token(Token = "0x17000242")]
	public override int EmptyColumns
	{
		[Token(Token = "0x6003474")]
		[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "43")]
		get
		{
			return 2;
		}
	}

	// Token: 0x17000243 RID: 579
	// (get) Token: 0x06003475 RID: 13429 RVA: 0x001148F0 File Offset: 0x00112AF0
	[Token(Token = "0x17000243")]
	public override int NumberOfColumns
	{
		[Token(Token = "0x6003475")]
		[Address(RVA = "0x3F6B70", Offset = "0x3F5170", VA = "0x1803F6B70", Slot = "44")]
		get
		{
			return 8;
		}
	}

	// Token: 0x17000244 RID: 580
	// (get) Token: 0x06003476 RID: 13430 RVA: 0x00114900 File Offset: 0x00112B00
	[Token(Token = "0x17000244")]
	public override int NumberOfRows
	{
		[Token(Token = "0x6003476")]
		[Address(RVA = "0x3F7A00", Offset = "0x3F6000", VA = "0x1803F7A00", Slot = "45")]
		get
		{
			return 5;
		}
	}

	// Token: 0x17000245 RID: 581
	// (get) Token: 0x06003477 RID: 13431 RVA: 0x00114910 File Offset: 0x00112B10
	[Token(Token = "0x17000245")]
	public override int GreenCount
	{
		[Token(Token = "0x6003477")]
		[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "46")]
		get
		{
			return 3;
		}
	}

	// Token: 0x17000246 RID: 582
	// (get) Token: 0x06003478 RID: 13432 RVA: 0x00114920 File Offset: 0x00112B20
	[Token(Token = "0x17000246")]
	public override int ObsidianCount
	{
		[Token(Token = "0x6003478")]
		[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "48")]
		get
		{
			return 1;
		}
	}

	// Token: 0x17000247 RID: 583
	// (get) Token: 0x06003479 RID: 13433 RVA: 0x00114930 File Offset: 0x00112B30
	[Token(Token = "0x17000247")]
	public override List<PlantType> Plants
	{
		[Token(Token = "0x6003479")]
		[Address(RVA = "0x771FA0", Offset = "0x7705A0", VA = "0x180771FA0", Slot = "50")]
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

	// Token: 0x17000248 RID: 584
	// (get) Token: 0x0600347A RID: 13434 RVA: 0x001149FC File Offset: 0x00112BFC
	[Token(Token = "0x17000248")]
	public override List<ZombieType> Zombies
	{
		[Token(Token = "0x600347A")]
		[Address(RVA = "0x7726C0", Offset = "0x770CC0", VA = "0x1807726C0", Slot = "49")]
		get
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

	// Token: 0x0600347B RID: 13435 RVA: 0x00114AC8 File Offset: 0x00112CC8
	[Token(Token = "0x600347B")]
	[Address(RVA = "0x7602C0", Offset = "0x75E8C0", VA = "0x1807602C0")]
	public ScaryPot4()
	{
	}
}
