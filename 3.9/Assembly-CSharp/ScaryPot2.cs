using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020009F8 RID: 2552
[Token(Token = "0x20009F8")]
public class ScaryPot2 : ScaryPotLevel
{
	// Token: 0x17000230 RID: 560
	// (get) Token: 0x0600345F RID: 13407 RVA: 0x0011440C File Offset: 0x0011260C
	[Token(Token = "0x17000230")]
	public override string Name
	{
		[Token(Token = "0x600345F")]
		[Address(RVA = "0x7701B0", Offset = "0x76E7B0", VA = "0x1807701B0", Slot = "8")]
		get
		{
			return "砸罐子2";
		}
	}

	// Token: 0x17000231 RID: 561
	// (get) Token: 0x06003460 RID: 13408 RVA: 0x00114420 File Offset: 0x00112620
	[Token(Token = "0x17000231")]
	protected override ChallengeLevel Level
	{
		[Token(Token = "0x6003460")]
		[Address(RVA = "0x3FC040", Offset = "0x3FA640", VA = "0x1803FC040", Slot = "42")]
		get
		{
			return ChallengeLevel.ScaryPot2;
		}
	}

	// Token: 0x17000232 RID: 562
	// (get) Token: 0x06003461 RID: 13409 RVA: 0x00114430 File Offset: 0x00112630
	[Token(Token = "0x17000232")]
	public override int EmptyColumns
	{
		[Token(Token = "0x6003461")]
		[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "43")]
		get
		{
			return 2;
		}
	}

	// Token: 0x17000233 RID: 563
	// (get) Token: 0x06003462 RID: 13410 RVA: 0x00114440 File Offset: 0x00112640
	[Token(Token = "0x17000233")]
	public override int NumberOfColumns
	{
		[Token(Token = "0x6003462")]
		[Address(RVA = "0x3F6B70", Offset = "0x3F5170", VA = "0x1803F6B70", Slot = "44")]
		get
		{
			return 8;
		}
	}

	// Token: 0x17000234 RID: 564
	// (get) Token: 0x06003463 RID: 13411 RVA: 0x00114450 File Offset: 0x00112650
	[Token(Token = "0x17000234")]
	public override int NumberOfRows
	{
		[Token(Token = "0x6003463")]
		[Address(RVA = "0x3F7A00", Offset = "0x3F6000", VA = "0x1803F7A00", Slot = "45")]
		get
		{
			return 5;
		}
	}

	// Token: 0x17000235 RID: 565
	// (get) Token: 0x06003464 RID: 13412 RVA: 0x00114460 File Offset: 0x00112660
	[Token(Token = "0x17000235")]
	public override int GreenCount
	{
		[Token(Token = "0x6003464")]
		[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "46")]
		get
		{
			return 2;
		}
	}

	// Token: 0x17000236 RID: 566
	// (get) Token: 0x06003465 RID: 13413 RVA: 0x00114470 File Offset: 0x00112670
	[Token(Token = "0x17000236")]
	public override List<PlantType> Plants
	{
		[Token(Token = "0x6003465")]
		[Address(RVA = "0x7701E0", Offset = "0x76E7E0", VA = "0x1807701E0", Slot = "50")]
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

	// Token: 0x17000237 RID: 567
	// (get) Token: 0x06003466 RID: 13414 RVA: 0x0011453C File Offset: 0x0011273C
	[Token(Token = "0x17000237")]
	public override List<ZombieType> Zombies
	{
		[Token(Token = "0x6003466")]
		[Address(RVA = "0x770900", Offset = "0x76EF00", VA = "0x180770900", Slot = "49")]
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
			list._size = 1;
			list._syncRoot = (ulong)0L;
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

	// Token: 0x06003467 RID: 13415 RVA: 0x00114664 File Offset: 0x00112864
	[Token(Token = "0x6003467")]
	[Address(RVA = "0x7602C0", Offset = "0x75E8C0", VA = "0x1807602C0")]
	public ScaryPot2()
	{
	}
}
