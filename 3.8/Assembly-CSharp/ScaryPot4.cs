using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;

// Token: 0x020009BE RID: 2494
[Token(Token = "0x20009BE")]
public class ScaryPot4 : ScaryPotLevel
{
	// Token: 0x0600333D RID: 13117 RVA: 0x0010F878 File Offset: 0x0010DA78
	[Token(Token = "0x600333D")]
	[Address(RVA = "0x70C990", Offset = "0x70AF90", VA = "0x18070C990", Slot = "36")]
	public override void OnBoardStart(Board board)
	{
		int theMaxWave = board.theMaxWave;
		board.theWave = theMaxWave;
		int theBoardLevel = GameAPP.theBoardLevel;
		InGameText instance = InGameText.Instance;
		int num = 0;
		instance.ShowText("黑曜石罐子一定开出植物\n开出的植物获得无敌时间以及更多血量", 5f, num != 0);
	}

	// Token: 0x170001F8 RID: 504
	// (get) Token: 0x0600333E RID: 13118 RVA: 0x0010F8C0 File Offset: 0x0010DAC0
	[Token(Token = "0x170001F8")]
	public override string Name
	{
		[Token(Token = "0x600333E")]
		[Address(RVA = "0x70CA50", Offset = "0x70B050", VA = "0x18070CA50", Slot = "8")]
		get
		{
			return "不走寻常路";
		}
	}

	// Token: 0x170001F9 RID: 505
	// (get) Token: 0x0600333F RID: 13119 RVA: 0x0010F8D4 File Offset: 0x0010DAD4
	[Token(Token = "0x170001F9")]
	protected override ChallengeLevel Level
	{
		[Token(Token = "0x600333F")]
		[Address(RVA = "0x4CFEB0", Offset = "0x4CE4B0", VA = "0x1804CFEB0", Slot = "42")]
		get
		{
			return ChallengeLevel.ScaryPot4;
		}
	}

	// Token: 0x170001FA RID: 506
	// (get) Token: 0x06003340 RID: 13120 RVA: 0x0010F8E8 File Offset: 0x0010DAE8
	[Token(Token = "0x170001FA")]
	public override int EmptyColumns
	{
		[Token(Token = "0x6003340")]
		[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "43")]
		get
		{
			return 2;
		}
	}

	// Token: 0x170001FB RID: 507
	// (get) Token: 0x06003341 RID: 13121 RVA: 0x0010F8F8 File Offset: 0x0010DAF8
	[Token(Token = "0x170001FB")]
	public override int NumberOfColumns
	{
		[Token(Token = "0x6003341")]
		[Address(RVA = "0x3AAD70", Offset = "0x3A9370", VA = "0x1803AAD70", Slot = "44")]
		get
		{
			return 8;
		}
	}

	// Token: 0x170001FC RID: 508
	// (get) Token: 0x06003342 RID: 13122 RVA: 0x0010F908 File Offset: 0x0010DB08
	[Token(Token = "0x170001FC")]
	public override int NumberOfRows
	{
		[Token(Token = "0x6003342")]
		[Address(RVA = "0x3ABC00", Offset = "0x3AA200", VA = "0x1803ABC00", Slot = "45")]
		get
		{
			return 5;
		}
	}

	// Token: 0x170001FD RID: 509
	// (get) Token: 0x06003343 RID: 13123 RVA: 0x0010F918 File Offset: 0x0010DB18
	[Token(Token = "0x170001FD")]
	public override int GreenCount
	{
		[Token(Token = "0x6003343")]
		[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "46")]
		get
		{
			return 3;
		}
	}

	// Token: 0x170001FE RID: 510
	// (get) Token: 0x06003344 RID: 13124 RVA: 0x0010F928 File Offset: 0x0010DB28
	[Token(Token = "0x170001FE")]
	public override int ObsidianCount
	{
		[Token(Token = "0x6003344")]
		[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "48")]
		get
		{
			return 1;
		}
	}

	// Token: 0x170001FF RID: 511
	// (get) Token: 0x06003345 RID: 13125 RVA: 0x0010F938 File Offset: 0x0010DB38
	[Token(Token = "0x170001FF")]
	public override List<PlantType> Plants
	{
		[Token(Token = "0x6003345")]
		[Address(RVA = "0x70CA80", Offset = "0x70B080", VA = "0x18070CA80", Slot = "50")]
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

	// Token: 0x17000200 RID: 512
	// (get) Token: 0x06003346 RID: 13126 RVA: 0x0010FA04 File Offset: 0x0010DC04
	[Token(Token = "0x17000200")]
	public override List<ZombieType> Zombies
	{
		[Token(Token = "0x6003346")]
		[Address(RVA = "0x70D1A0", Offset = "0x70B7A0", VA = "0x18070D1A0", Slot = "49")]
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

	// Token: 0x06003347 RID: 13127 RVA: 0x0010FAD0 File Offset: 0x0010DCD0
	[Token(Token = "0x6003347")]
	[Address(RVA = "0x6FAF20", Offset = "0x6F9520", VA = "0x1806FAF20")]
	public ScaryPot4()
	{
	}
}
