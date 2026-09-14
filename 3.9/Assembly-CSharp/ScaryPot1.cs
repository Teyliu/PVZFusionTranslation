using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020009F7 RID: 2551
[Token(Token = "0x20009F7")]
public class ScaryPot1 : ScaryPotLevel
{
	// Token: 0x17000228 RID: 552
	// (get) Token: 0x06003456 RID: 13398 RVA: 0x0011419C File Offset: 0x0011239C
	[Token(Token = "0x17000228")]
	public override string Name
	{
		[Token(Token = "0x6003456")]
		[Address(RVA = "0x76F870", Offset = "0x76DE70", VA = "0x18076F870", Slot = "8")]
		get
		{
			return "砸罐子";
		}
	}

	// Token: 0x17000229 RID: 553
	// (get) Token: 0x06003457 RID: 13399 RVA: 0x001141B0 File Offset: 0x001123B0
	[Token(Token = "0x17000229")]
	protected override ChallengeLevel Level
	{
		[Token(Token = "0x6003457")]
		[Address(RVA = "0x3FC860", Offset = "0x3FAE60", VA = "0x1803FC860", Slot = "42")]
		get
		{
			return ChallengeLevel.ScaryPot;
		}
	}

	// Token: 0x1700022A RID: 554
	// (get) Token: 0x06003458 RID: 13400 RVA: 0x001141C0 File Offset: 0x001123C0
	[Token(Token = "0x1700022A")]
	public override int EmptyColumns
	{
		[Token(Token = "0x6003458")]
		[Address(RVA = "0x3F9250", Offset = "0x3F7850", VA = "0x1803F9250", Slot = "43")]
		get
		{
			return 4;
		}
	}

	// Token: 0x1700022B RID: 555
	// (get) Token: 0x06003459 RID: 13401 RVA: 0x001141D0 File Offset: 0x001123D0
	[Token(Token = "0x1700022B")]
	public override int NumberOfColumns
	{
		[Token(Token = "0x6003459")]
		[Address(RVA = "0x3F7A00", Offset = "0x3F6000", VA = "0x1803F7A00", Slot = "44")]
		get
		{
			return 5;
		}
	}

	// Token: 0x1700022C RID: 556
	// (get) Token: 0x0600345A RID: 13402 RVA: 0x001141E0 File Offset: 0x001123E0
	[Token(Token = "0x1700022C")]
	public override int NumberOfRows
	{
		[Token(Token = "0x600345A")]
		[Address(RVA = "0x3F7A00", Offset = "0x3F6000", VA = "0x1803F7A00", Slot = "45")]
		get
		{
			return 5;
		}
	}

	// Token: 0x1700022D RID: 557
	// (get) Token: 0x0600345B RID: 13403 RVA: 0x001141F0 File Offset: 0x001123F0
	[Token(Token = "0x1700022D")]
	public override int GreenCount
	{
		[Token(Token = "0x600345B")]
		[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "46")]
		get
		{
			return 2;
		}
	}

	// Token: 0x1700022E RID: 558
	// (get) Token: 0x0600345C RID: 13404 RVA: 0x00114200 File Offset: 0x00112400
	[Token(Token = "0x1700022E")]
	public override List<PlantType> Plants
	{
		[Token(Token = "0x600345C")]
		[Address(RVA = "0x76F8A0", Offset = "0x76DEA0", VA = "0x18076F8A0", Slot = "50")]
		get
		{
			List<PlantType> list = new List();
			int size = list._size;
			int num = 0;
			list._size = 1;
			list._syncRoot = num;
			int size2 = list._size;
			list._size = 1;
			int size3 = list._size;
			list._size = 1;
			int size4 = list._size;
			list._size = 1;
			int size5 = list._size;
			list._size = 1;
			int size6 = list._size;
			list._size = 1;
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
			return list;
		}
	}

	// Token: 0x1700022F RID: 559
	// (get) Token: 0x0600345D RID: 13405 RVA: 0x00114320 File Offset: 0x00112520
	[Token(Token = "0x1700022F")]
	public override List<ZombieType> Zombies
	{
		[Token(Token = "0x600345D")]
		[Address(RVA = "0x76FE00", Offset = "0x76E400", VA = "0x18076FE00", Slot = "49")]
		get
		{
			List<ZombieType> list = new List();
			int size = list._size;
			int num = 0;
			list._size = 1;
			list._syncRoot = num;
			int size2 = list._size;
			list._size = 1;
			int size3 = list._size;
			list._size = 1;
			int size4 = list._size;
			list._size = 1;
			int size5 = list._size;
			list._size = 1;
			int size6 = list._size;
			list._size = 1;
			int size7 = list._size;
			list._size = 1;
			int size8 = list._size;
			list._size = 1;
			int size9 = list._size;
			list._size = 1;
			int size10 = list._size;
			return list;
		}
	}

	// Token: 0x0600345E RID: 13406 RVA: 0x001143F8 File Offset: 0x001125F8
	[Token(Token = "0x600345E")]
	[Address(RVA = "0x7602C0", Offset = "0x75E8C0", VA = "0x1807602C0")]
	public ScaryPot1()
	{
	}
}
