using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020009FC RID: 2556
[Token(Token = "0x20009FC")]
public class ScaryPot6 : ScaryPotLevel
{
	// Token: 0x17000252 RID: 594
	// (get) Token: 0x06003487 RID: 13447 RVA: 0x00114DA0 File Offset: 0x00112FA0
	[Token(Token = "0x17000252")]
	public override string Name
	{
		[Token(Token = "0x6003487")]
		[Address(RVA = "0x773D30", Offset = "0x772330", VA = "0x180773D30", Slot = "8")]
		get
		{
			return "有内鬼";
		}
	}

	// Token: 0x17000253 RID: 595
	// (get) Token: 0x06003488 RID: 13448 RVA: 0x00114DB4 File Offset: 0x00112FB4
	[Token(Token = "0x17000253")]
	protected override ChallengeLevel Level
	{
		[Token(Token = "0x6003488")]
		[Address(RVA = "0x525170", Offset = "0x523770", VA = "0x180525170", Slot = "42")]
		get
		{
			return ChallengeLevel.ScaryPot6;
		}
	}

	// Token: 0x17000254 RID: 596
	// (get) Token: 0x06003489 RID: 13449 RVA: 0x00114DC8 File Offset: 0x00112FC8
	[Token(Token = "0x17000254")]
	public override int ObsidianCount
	{
		[Token(Token = "0x6003489")]
		[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "48")]
		get
		{
			return 1;
		}
	}

	// Token: 0x17000255 RID: 597
	// (get) Token: 0x0600348A RID: 13450 RVA: 0x00114DD8 File Offset: 0x00112FD8
	[Token(Token = "0x17000255")]
	public override int HypnoCount
	{
		[Token(Token = "0x600348A")]
		[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "47")]
		get
		{
			return 1;
		}
	}

	// Token: 0x17000256 RID: 598
	// (get) Token: 0x0600348B RID: 13451 RVA: 0x00114DE8 File Offset: 0x00112FE8
	[Token(Token = "0x17000256")]
	public override int EmptyColumns
	{
		[Token(Token = "0x600348B")]
		[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "43")]
		get
		{
			return 2;
		}
	}

	// Token: 0x17000257 RID: 599
	// (get) Token: 0x0600348C RID: 13452 RVA: 0x00114DF8 File Offset: 0x00112FF8
	[Token(Token = "0x17000257")]
	public override int NumberOfColumns
	{
		[Token(Token = "0x600348C")]
		[Address(RVA = "0x3F6B70", Offset = "0x3F5170", VA = "0x1803F6B70", Slot = "44")]
		get
		{
			return 8;
		}
	}

	// Token: 0x17000258 RID: 600
	// (get) Token: 0x0600348D RID: 13453 RVA: 0x00114E08 File Offset: 0x00113008
	[Token(Token = "0x17000258")]
	public override int NumberOfRows
	{
		[Token(Token = "0x600348D")]
		[Address(RVA = "0x3F7A00", Offset = "0x3F6000", VA = "0x1803F7A00", Slot = "45")]
		get
		{
			return 5;
		}
	}

	// Token: 0x17000259 RID: 601
	// (get) Token: 0x0600348E RID: 13454 RVA: 0x00114E18 File Offset: 0x00113018
	[Token(Token = "0x17000259")]
	public override int GreenCount
	{
		[Token(Token = "0x600348E")]
		[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "46")]
		get
		{
			return 2;
		}
	}

	// Token: 0x1700025A RID: 602
	// (get) Token: 0x0600348F RID: 13455 RVA: 0x00114E28 File Offset: 0x00113028
	[Token(Token = "0x1700025A")]
	public override List<PlantType> Plants
	{
		[Token(Token = "0x600348F")]
		[Address(RVA = "0x773D60", Offset = "0x772360", VA = "0x180773D60", Slot = "50")]
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

	// Token: 0x1700025B RID: 603
	// (get) Token: 0x06003490 RID: 13456 RVA: 0x00114EF4 File Offset: 0x001130F4
	[Token(Token = "0x1700025B")]
	public override List<ZombieType> Zombies
	{
		[Token(Token = "0x6003490")]
		[Address(RVA = "0x774480", Offset = "0x772A80", VA = "0x180774480", Slot = "49")]
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

	// Token: 0x06003491 RID: 13457 RVA: 0x00114FC0 File Offset: 0x001131C0
	[Token(Token = "0x6003491")]
	[Address(RVA = "0x7602C0", Offset = "0x75E8C0", VA = "0x1807602C0")]
	public ScaryPot6()
	{
	}
}
