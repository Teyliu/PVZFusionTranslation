using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020009BB RID: 2491
[Token(Token = "0x20009BB")]
public class ScaryPot1 : ScaryPotLevel
{
	// Token: 0x170001E0 RID: 480
	// (get) Token: 0x06003322 RID: 13090 RVA: 0x0010F18C File Offset: 0x0010D38C
	[Token(Token = "0x170001E0")]
	public override string Name
	{
		[Token(Token = "0x6003322")]
		[Address(RVA = "0x70A350", Offset = "0x708950", VA = "0x18070A350", Slot = "8")]
		get
		{
			return "砸罐子";
		}
	}

	// Token: 0x170001E1 RID: 481
	// (get) Token: 0x06003323 RID: 13091 RVA: 0x0010F1A0 File Offset: 0x0010D3A0
	[Token(Token = "0x170001E1")]
	protected override ChallengeLevel Level
	{
		[Token(Token = "0x6003323")]
		[Address(RVA = "0x3B05A0", Offset = "0x3AEBA0", VA = "0x1803B05A0", Slot = "42")]
		get
		{
			return ChallengeLevel.ScaryPot;
		}
	}

	// Token: 0x170001E2 RID: 482
	// (get) Token: 0x06003324 RID: 13092 RVA: 0x0010F1B0 File Offset: 0x0010D3B0
	[Token(Token = "0x170001E2")]
	public override int EmptyColumns
	{
		[Token(Token = "0x6003324")]
		[Address(RVA = "0x3AD3E0", Offset = "0x3AB9E0", VA = "0x1803AD3E0", Slot = "43")]
		get
		{
			return 4;
		}
	}

	// Token: 0x170001E3 RID: 483
	// (get) Token: 0x06003325 RID: 13093 RVA: 0x0010F1C0 File Offset: 0x0010D3C0
	[Token(Token = "0x170001E3")]
	public override int NumberOfColumns
	{
		[Token(Token = "0x6003325")]
		[Address(RVA = "0x3ABC00", Offset = "0x3AA200", VA = "0x1803ABC00", Slot = "44")]
		get
		{
			return 5;
		}
	}

	// Token: 0x170001E4 RID: 484
	// (get) Token: 0x06003326 RID: 13094 RVA: 0x0010F1D0 File Offset: 0x0010D3D0
	[Token(Token = "0x170001E4")]
	public override int NumberOfRows
	{
		[Token(Token = "0x6003326")]
		[Address(RVA = "0x3ABC00", Offset = "0x3AA200", VA = "0x1803ABC00", Slot = "45")]
		get
		{
			return 5;
		}
	}

	// Token: 0x170001E5 RID: 485
	// (get) Token: 0x06003327 RID: 13095 RVA: 0x0010F1E0 File Offset: 0x0010D3E0
	[Token(Token = "0x170001E5")]
	public override int GreenCount
	{
		[Token(Token = "0x6003327")]
		[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "46")]
		get
		{
			return 2;
		}
	}

	// Token: 0x170001E6 RID: 486
	// (get) Token: 0x06003328 RID: 13096 RVA: 0x0010F1F0 File Offset: 0x0010D3F0
	[Token(Token = "0x170001E6")]
	public override List<PlantType> Plants
	{
		[Token(Token = "0x6003328")]
		[Address(RVA = "0x70A380", Offset = "0x708980", VA = "0x18070A380", Slot = "50")]
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

	// Token: 0x170001E7 RID: 487
	// (get) Token: 0x06003329 RID: 13097 RVA: 0x0010F310 File Offset: 0x0010D510
	[Token(Token = "0x170001E7")]
	public override List<ZombieType> Zombies
	{
		[Token(Token = "0x6003329")]
		[Address(RVA = "0x70A8E0", Offset = "0x708EE0", VA = "0x18070A8E0", Slot = "49")]
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

	// Token: 0x0600332A RID: 13098 RVA: 0x0010F3E8 File Offset: 0x0010D5E8
	[Token(Token = "0x600332A")]
	[Address(RVA = "0x6FAF20", Offset = "0x6F9520", VA = "0x1806FAF20")]
	public ScaryPot1()
	{
	}
}
