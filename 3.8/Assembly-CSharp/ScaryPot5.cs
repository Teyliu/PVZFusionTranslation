using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;

// Token: 0x020009BF RID: 2495
[Token(Token = "0x20009BF")]
public class ScaryPot5 : ScaryPotLevel
{
	// Token: 0x06003348 RID: 13128 RVA: 0x0010FAE4 File Offset: 0x0010DCE4
	[Token(Token = "0x6003348")]
	[Address(RVA = "0x70D8C0", Offset = "0x70BEC0", VA = "0x18070D8C0", Slot = "36")]
	public override void OnBoardStart(Board board)
	{
		int theMaxWave = board.theMaxWave;
		board.theWave = theMaxWave;
		int theBoardLevel = GameAPP.theBoardLevel;
		InGameText instance = InGameText.Instance;
		int num = 0;
		instance.ShowText("魅惑罐子一定开出魅惑僵尸", 5f, num != 0);
	}

	// Token: 0x17000201 RID: 513
	// (get) Token: 0x06003349 RID: 13129 RVA: 0x0010FB2C File Offset: 0x0010DD2C
	[Token(Token = "0x17000201")]
	public override string Name
	{
		[Token(Token = "0x6003349")]
		[Address(RVA = "0x70D990", Offset = "0x70BF90", VA = "0x18070D990", Slot = "8")]
		get
		{
			return "绝对火力";
		}
	}

	// Token: 0x17000202 RID: 514
	// (get) Token: 0x0600334A RID: 13130 RVA: 0x0010FB40 File Offset: 0x0010DD40
	[Token(Token = "0x17000202")]
	protected override ChallengeLevel Level
	{
		[Token(Token = "0x600334A")]
		[Address(RVA = "0x70D980", Offset = "0x70BF80", VA = "0x18070D980", Slot = "42")]
		get
		{
			return ChallengeLevel.ScaryPot5;
		}
	}

	// Token: 0x17000203 RID: 515
	// (get) Token: 0x0600334B RID: 13131 RVA: 0x0010FB54 File Offset: 0x0010DD54
	[Token(Token = "0x17000203")]
	public override int HypnoCount
	{
		[Token(Token = "0x600334B")]
		[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "47")]
		get
		{
			return 1;
		}
	}

	// Token: 0x17000204 RID: 516
	// (get) Token: 0x0600334C RID: 13132 RVA: 0x0010FB64 File Offset: 0x0010DD64
	[Token(Token = "0x17000204")]
	public override int EmptyColumns
	{
		[Token(Token = "0x600334C")]
		[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "43")]
		get
		{
			return 2;
		}
	}

	// Token: 0x17000205 RID: 517
	// (get) Token: 0x0600334D RID: 13133 RVA: 0x0010FB74 File Offset: 0x0010DD74
	[Token(Token = "0x17000205")]
	public override int NumberOfColumns
	{
		[Token(Token = "0x600334D")]
		[Address(RVA = "0x3AAD70", Offset = "0x3A9370", VA = "0x1803AAD70", Slot = "44")]
		get
		{
			return 8;
		}
	}

	// Token: 0x17000206 RID: 518
	// (get) Token: 0x0600334E RID: 13134 RVA: 0x0010FB84 File Offset: 0x0010DD84
	[Token(Token = "0x17000206")]
	public override int NumberOfRows
	{
		[Token(Token = "0x600334E")]
		[Address(RVA = "0x3ABC00", Offset = "0x3AA200", VA = "0x1803ABC00", Slot = "45")]
		get
		{
			return 5;
		}
	}

	// Token: 0x17000207 RID: 519
	// (get) Token: 0x0600334F RID: 13135 RVA: 0x0010FB94 File Offset: 0x0010DD94
	[Token(Token = "0x17000207")]
	public override int GreenCount
	{
		[Token(Token = "0x600334F")]
		[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "46")]
		get
		{
			return 3;
		}
	}

	// Token: 0x17000208 RID: 520
	// (get) Token: 0x06003350 RID: 13136 RVA: 0x0010FBA4 File Offset: 0x0010DDA4
	[Token(Token = "0x17000208")]
	public override List<PlantType> Plants
	{
		[Token(Token = "0x6003350")]
		[Address(RVA = "0x70D9C0", Offset = "0x70BFC0", VA = "0x18070D9C0", Slot = "50")]
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

	// Token: 0x17000209 RID: 521
	// (get) Token: 0x06003351 RID: 13137 RVA: 0x0010FC70 File Offset: 0x0010DE70
	[Token(Token = "0x17000209")]
	public override List<ZombieType> Zombies
	{
		[Token(Token = "0x6003351")]
		[Address(RVA = "0x70E0E0", Offset = "0x70C6E0", VA = "0x18070E0E0", Slot = "49")]
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

	// Token: 0x06003352 RID: 13138 RVA: 0x0010FDAC File Offset: 0x0010DFAC
	[Token(Token = "0x6003352")]
	[Address(RVA = "0x6FAF20", Offset = "0x6F9520", VA = "0x1806FAF20")]
	public ScaryPot5()
	{
	}
}
