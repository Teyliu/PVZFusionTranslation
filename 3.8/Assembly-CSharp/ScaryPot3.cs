using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020009BD RID: 2493
[Token(Token = "0x20009BD")]
public class ScaryPot3 : ScaryPotLevel
{
	// Token: 0x170001F0 RID: 496
	// (get) Token: 0x06003334 RID: 13108 RVA: 0x0010F668 File Offset: 0x0010D868
	[Token(Token = "0x170001F0")]
	public override string Name
	{
		[Token(Token = "0x6003334")]
		[Address(RVA = "0x70BB10", Offset = "0x70A110", VA = "0x18070BB10", Slot = "8")]
		get
		{
			return "连锁反应";
		}
	}

	// Token: 0x170001F1 RID: 497
	// (get) Token: 0x06003335 RID: 13109 RVA: 0x0010F67C File Offset: 0x0010D87C
	[Token(Token = "0x170001F1")]
	protected override ChallengeLevel Level
	{
		[Token(Token = "0x6003335")]
		[Address(RVA = "0x70BB00", Offset = "0x70A100", VA = "0x18070BB00", Slot = "42")]
		get
		{
			return ChallengeLevel.ScaryPot3;
		}
	}

	// Token: 0x170001F2 RID: 498
	// (get) Token: 0x06003336 RID: 13110 RVA: 0x0010F68C File Offset: 0x0010D88C
	[Token(Token = "0x170001F2")]
	public override int EmptyColumns
	{
		[Token(Token = "0x6003336")]
		[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "43")]
		get
		{
			return 2;
		}
	}

	// Token: 0x170001F3 RID: 499
	// (get) Token: 0x06003337 RID: 13111 RVA: 0x0010F69C File Offset: 0x0010D89C
	[Token(Token = "0x170001F3")]
	public override int NumberOfColumns
	{
		[Token(Token = "0x6003337")]
		[Address(RVA = "0x3AAD70", Offset = "0x3A9370", VA = "0x1803AAD70", Slot = "44")]
		get
		{
			return 8;
		}
	}

	// Token: 0x170001F4 RID: 500
	// (get) Token: 0x06003338 RID: 13112 RVA: 0x0010F6AC File Offset: 0x0010D8AC
	[Token(Token = "0x170001F4")]
	public override int NumberOfRows
	{
		[Token(Token = "0x6003338")]
		[Address(RVA = "0x3ABC00", Offset = "0x3AA200", VA = "0x1803ABC00", Slot = "45")]
		get
		{
			return 5;
		}
	}

	// Token: 0x170001F5 RID: 501
	// (get) Token: 0x06003339 RID: 13113 RVA: 0x0010F6BC File Offset: 0x0010D8BC
	[Token(Token = "0x170001F5")]
	public override int GreenCount
	{
		[Token(Token = "0x6003339")]
		[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "46")]
		get
		{
			return 2;
		}
	}

	// Token: 0x170001F6 RID: 502
	// (get) Token: 0x0600333A RID: 13114 RVA: 0x0010F6CC File Offset: 0x0010D8CC
	[Token(Token = "0x170001F6")]
	public override List<PlantType> Plants
	{
		[Token(Token = "0x600333A")]
		[Address(RVA = "0x70BB40", Offset = "0x70A140", VA = "0x18070BB40", Slot = "50")]
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

	// Token: 0x170001F7 RID: 503
	// (get) Token: 0x0600333B RID: 13115 RVA: 0x0010F798 File Offset: 0x0010D998
	[Token(Token = "0x170001F7")]
	public override List<ZombieType> Zombies
	{
		[Token(Token = "0x600333B")]
		[Address(RVA = "0x70C270", Offset = "0x70A870", VA = "0x18070C270", Slot = "49")]
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

	// Token: 0x0600333C RID: 13116 RVA: 0x0010F864 File Offset: 0x0010DA64
	[Token(Token = "0x600333C")]
	[Address(RVA = "0x6FAF20", Offset = "0x6F9520", VA = "0x1806FAF20")]
	public ScaryPot3()
	{
	}
}
