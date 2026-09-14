using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020009C0 RID: 2496
[Token(Token = "0x20009C0")]
public class ScaryPot6 : ScaryPotLevel
{
	// Token: 0x1700020A RID: 522
	// (get) Token: 0x06003353 RID: 13139 RVA: 0x0010FDC0 File Offset: 0x0010DFC0
	[Token(Token = "0x1700020A")]
	public override string Name
	{
		[Token(Token = "0x6003353")]
		[Address(RVA = "0x70E800", Offset = "0x70CE00", VA = "0x18070E800", Slot = "8")]
		get
		{
			return "有内鬼";
		}
	}

	// Token: 0x1700020B RID: 523
	// (get) Token: 0x06003354 RID: 13140 RVA: 0x0010FDD4 File Offset: 0x0010DFD4
	[Token(Token = "0x1700020B")]
	protected override ChallengeLevel Level
	{
		[Token(Token = "0x6003354")]
		[Address(RVA = "0x4C8F80", Offset = "0x4C7580", VA = "0x1804C8F80", Slot = "42")]
		get
		{
			return ChallengeLevel.ScaryPot6;
		}
	}

	// Token: 0x1700020C RID: 524
	// (get) Token: 0x06003355 RID: 13141 RVA: 0x0010FDE8 File Offset: 0x0010DFE8
	[Token(Token = "0x1700020C")]
	public override int ObsidianCount
	{
		[Token(Token = "0x6003355")]
		[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "48")]
		get
		{
			return 1;
		}
	}

	// Token: 0x1700020D RID: 525
	// (get) Token: 0x06003356 RID: 13142 RVA: 0x0010FDF8 File Offset: 0x0010DFF8
	[Token(Token = "0x1700020D")]
	public override int HypnoCount
	{
		[Token(Token = "0x6003356")]
		[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "47")]
		get
		{
			return 1;
		}
	}

	// Token: 0x1700020E RID: 526
	// (get) Token: 0x06003357 RID: 13143 RVA: 0x0010FE08 File Offset: 0x0010E008
	[Token(Token = "0x1700020E")]
	public override int EmptyColumns
	{
		[Token(Token = "0x6003357")]
		[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "43")]
		get
		{
			return 2;
		}
	}

	// Token: 0x1700020F RID: 527
	// (get) Token: 0x06003358 RID: 13144 RVA: 0x0010FE18 File Offset: 0x0010E018
	[Token(Token = "0x1700020F")]
	public override int NumberOfColumns
	{
		[Token(Token = "0x6003358")]
		[Address(RVA = "0x3AAD70", Offset = "0x3A9370", VA = "0x1803AAD70", Slot = "44")]
		get
		{
			return 8;
		}
	}

	// Token: 0x17000210 RID: 528
	// (get) Token: 0x06003359 RID: 13145 RVA: 0x0010FE28 File Offset: 0x0010E028
	[Token(Token = "0x17000210")]
	public override int NumberOfRows
	{
		[Token(Token = "0x6003359")]
		[Address(RVA = "0x3ABC00", Offset = "0x3AA200", VA = "0x1803ABC00", Slot = "45")]
		get
		{
			return 5;
		}
	}

	// Token: 0x17000211 RID: 529
	// (get) Token: 0x0600335A RID: 13146 RVA: 0x0010FE38 File Offset: 0x0010E038
	[Token(Token = "0x17000211")]
	public override int GreenCount
	{
		[Token(Token = "0x600335A")]
		[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "46")]
		get
		{
			return 2;
		}
	}

	// Token: 0x17000212 RID: 530
	// (get) Token: 0x0600335B RID: 13147 RVA: 0x0010FE48 File Offset: 0x0010E048
	[Token(Token = "0x17000212")]
	public override List<PlantType> Plants
	{
		[Token(Token = "0x600335B")]
		[Address(RVA = "0x70E830", Offset = "0x70CE30", VA = "0x18070E830", Slot = "50")]
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

	// Token: 0x17000213 RID: 531
	// (get) Token: 0x0600335C RID: 13148 RVA: 0x0010FF14 File Offset: 0x0010E114
	[Token(Token = "0x17000213")]
	public override List<ZombieType> Zombies
	{
		[Token(Token = "0x600335C")]
		[Address(RVA = "0x70EF50", Offset = "0x70D550", VA = "0x18070EF50", Slot = "49")]
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

	// Token: 0x0600335D RID: 13149 RVA: 0x0010FFE0 File Offset: 0x0010E1E0
	[Token(Token = "0x600335D")]
	[Address(RVA = "0x6FAF20", Offset = "0x6F9520", VA = "0x1806FAF20")]
	public ScaryPot6()
	{
	}
}
