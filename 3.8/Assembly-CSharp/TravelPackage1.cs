using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020009F2 RID: 2546
[Token(Token = "0x20009F2")]
public class TravelPackage1 : TravelPackage
{
	// Token: 0x1700021B RID: 539
	// (get) Token: 0x0600341B RID: 13339 RVA: 0x00115ED4 File Offset: 0x001140D4
	[Token(Token = "0x1700021B")]
	public override bool LandRoute
	{
		[Token(Token = "0x600341B")]
		[Address(RVA = "0x3A5ED0", Offset = "0x3A44D0", VA = "0x1803A5ED0", Slot = "5")]
		get
		{
			return true;
		}
	}

	// Token: 0x1700021C RID: 540
	// (get) Token: 0x0600341C RID: 13340 RVA: 0x00115EE4 File Offset: 0x001140E4
	[Token(Token = "0x1700021C")]
	public override ZombieType RouteBossType
	{
		[Token(Token = "0x600341C")]
		[Address(RVA = "0x7291B0", Offset = "0x7277B0", VA = "0x1807291B0", Slot = "4")]
		get
		{
			return ZombieType.UltimateGargantuar;
		}
	}

	// Token: 0x1700021D RID: 541
	// (get) Token: 0x0600341D RID: 13341 RVA: 0x00115EF8 File Offset: 0x001140F8
	[Token(Token = "0x1700021D")]
	public override Dictionary<int, List<ZombieType>> Spawns
	{
		[Token(Token = "0x600341D")]
		[Address(RVA = "0x7291C0", Offset = "0x7277C0", VA = "0x1807291C0", Slot = "6")]
		get;
	}

	// Token: 0x1700021E RID: 542
	// (get) Token: 0x0600341E RID: 13342 RVA: 0x00115F0C File Offset: 0x0011410C
	[Token(Token = "0x1700021E")]
	public override List<TravelDebuff> Debuffs
	{
		[Token(Token = "0x600341E")]
		[Address(RVA = "0x7291A0", Offset = "0x7277A0", VA = "0x1807291A0", Slot = "7")]
		get;
	}

	// Token: 0x0600341F RID: 13343 RVA: 0x00115F20 File Offset: 0x00114120
	[Token(Token = "0x600341F")]
	[Address(RVA = "0x727E60", Offset = "0x726460", VA = "0x180727E60")]
	public TravelPackage1()
	{
		Dictionary<int, List<ZombieType>> dictionary = new Dictionary();
		List<ZombieType> list = new List();
		dictionary[1] = list;
		List<ZombieType> list2 = new List();
		int size = list2._size;
		dictionary[2] = list2;
		List<ZombieType> list3 = new List();
		int size2 = list3._size;
		int size3 = list3._size;
		dictionary[3] = list3;
		List<ZombieType> list4 = new List();
		dictionary[4] = list4;
		List<ZombieType> list5 = new List();
		int size4 = list5._size;
		dictionary[5] = list5;
		List<ZombieType> list6 = new List();
		int size5 = list6._size;
		int size6 = list6._size;
		dictionary[6] = list6;
		List<ZombieType> list7 = new List();
		dictionary[7] = list7;
		List<ZombieType> list8 = new List();
		int size7 = list8._size;
		dictionary[8] = list8;
		List<ZombieType> list9 = new List();
		int size8 = list9._size;
		int size9 = list9._size;
		dictionary[9] = list9;
		List<ZombieType> list10 = new List();
		dictionary[10] = list10;
		List<ZombieType> list11 = new List();
		int size10 = list11._size;
		dictionary[11] = list11;
		List<ZombieType> list12 = new List();
		int size11 = list12._size;
		int size12 = list12._size;
		dictionary[12] = list12;
		List<ZombieType> list13 = new List();
		int size13 = list13._size;
		dictionary[13] = list13;
		List<ZombieType> list14 = new List();
		int size14 = list14._size;
		int size15 = list14._size;
		dictionary[14] = list14;
		List<ZombieType> list15 = new List();
		int size16 = list15._size;
		int size17 = list15._size;
		int size18 = list15._size;
		dictionary[15] = list15;
		List<ZombieType> list16 = new List();
		int size19 = list16._size;
		int size20 = list16._size;
		dictionary[16] = list16;
		List<ZombieType> list17 = new List();
		int size21 = list17._size;
		int size22 = list17._size;
		int size23 = list17._size;
		dictionary[17] = list17;
		List<ZombieType> list18 = new List();
		int size24 = list18._size;
		int size25 = list18._size;
		int size26 = list18._size;
		int size27 = list18._size;
		int size28 = list18._size;
		int size29 = list18._size;
		dictionary[18] = list18;
		List<ZombieType> list19 = new List();
		int size30 = list19._size;
		int size31 = list19._size;
		dictionary[19] = list19;
		List<ZombieType> list20 = new List();
		int size32 = list20._size;
		int size33 = list20._size;
		int size34 = list20._size;
		int size35 = list20._size;
		dictionary[20] = list20;
		List<ZombieType> list21 = new List();
		int size36 = list21._size;
		int size37 = list21._size;
		dictionary[21] = list21;
		this.Spawns = dictionary;
		List<TravelDebuff> list22 = new List();
		this.Debuffs = list22;
		base..ctor();
	}
}
