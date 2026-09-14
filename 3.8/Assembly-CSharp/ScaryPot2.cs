using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020009BC RID: 2492
[Token(Token = "0x20009BC")]
public class ScaryPot2 : ScaryPotLevel
{
	// Token: 0x170001E8 RID: 488
	// (get) Token: 0x0600332B RID: 13099 RVA: 0x0010F3FC File Offset: 0x0010D5FC
	[Token(Token = "0x170001E8")]
	public override string Name
	{
		[Token(Token = "0x600332B")]
		[Address(RVA = "0x70AC90", Offset = "0x709290", VA = "0x18070AC90", Slot = "8")]
		get
		{
			return "砸罐子2";
		}
	}

	// Token: 0x170001E9 RID: 489
	// (get) Token: 0x0600332C RID: 13100 RVA: 0x0010F410 File Offset: 0x0010D610
	[Token(Token = "0x170001E9")]
	protected override ChallengeLevel Level
	{
		[Token(Token = "0x600332C")]
		[Address(RVA = "0x3AFD80", Offset = "0x3AE380", VA = "0x1803AFD80", Slot = "42")]
		get
		{
			return ChallengeLevel.ScaryPot2;
		}
	}

	// Token: 0x170001EA RID: 490
	// (get) Token: 0x0600332D RID: 13101 RVA: 0x0010F420 File Offset: 0x0010D620
	[Token(Token = "0x170001EA")]
	public override int EmptyColumns
	{
		[Token(Token = "0x600332D")]
		[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "43")]
		get
		{
			return 2;
		}
	}

	// Token: 0x170001EB RID: 491
	// (get) Token: 0x0600332E RID: 13102 RVA: 0x0010F430 File Offset: 0x0010D630
	[Token(Token = "0x170001EB")]
	public override int NumberOfColumns
	{
		[Token(Token = "0x600332E")]
		[Address(RVA = "0x3AAD70", Offset = "0x3A9370", VA = "0x1803AAD70", Slot = "44")]
		get
		{
			return 8;
		}
	}

	// Token: 0x170001EC RID: 492
	// (get) Token: 0x0600332F RID: 13103 RVA: 0x0010F440 File Offset: 0x0010D640
	[Token(Token = "0x170001EC")]
	public override int NumberOfRows
	{
		[Token(Token = "0x600332F")]
		[Address(RVA = "0x3ABC00", Offset = "0x3AA200", VA = "0x1803ABC00", Slot = "45")]
		get
		{
			return 5;
		}
	}

	// Token: 0x170001ED RID: 493
	// (get) Token: 0x06003330 RID: 13104 RVA: 0x0010F450 File Offset: 0x0010D650
	[Token(Token = "0x170001ED")]
	public override int GreenCount
	{
		[Token(Token = "0x6003330")]
		[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "46")]
		get
		{
			return 2;
		}
	}

	// Token: 0x170001EE RID: 494
	// (get) Token: 0x06003331 RID: 13105 RVA: 0x0010F460 File Offset: 0x0010D660
	[Token(Token = "0x170001EE")]
	public override List<PlantType> Plants
	{
		[Token(Token = "0x6003331")]
		[Address(RVA = "0x70ACC0", Offset = "0x7092C0", VA = "0x18070ACC0", Slot = "50")]
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

	// Token: 0x170001EF RID: 495
	// (get) Token: 0x06003332 RID: 13106 RVA: 0x0010F52C File Offset: 0x0010D72C
	[Token(Token = "0x170001EF")]
	public override List<ZombieType> Zombies
	{
		[Token(Token = "0x6003332")]
		[Address(RVA = "0x70B3E0", Offset = "0x7099E0", VA = "0x18070B3E0", Slot = "49")]
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

	// Token: 0x06003333 RID: 13107 RVA: 0x0010F654 File Offset: 0x0010D854
	[Token(Token = "0x6003333")]
	[Address(RVA = "0x6FAF20", Offset = "0x6F9520", VA = "0x1806FAF20")]
	public ScaryPot2()
	{
	}
}
