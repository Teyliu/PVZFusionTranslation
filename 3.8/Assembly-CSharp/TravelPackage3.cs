using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020009F4 RID: 2548
[Token(Token = "0x20009F4")]
public class TravelPackage3 : TravelPackage
{
	// Token: 0x17000223 RID: 547
	// (get) Token: 0x06003425 RID: 13349 RVA: 0x00116510 File Offset: 0x00114710
	[Token(Token = "0x17000223")]
	public override bool LandRoute
	{
		[Token(Token = "0x6003425")]
		[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "5")]
		get
		{
			return false;
		}
	}

	// Token: 0x17000224 RID: 548
	// (get) Token: 0x06003426 RID: 13350 RVA: 0x00116520 File Offset: 0x00114720
	[Token(Token = "0x17000224")]
	public override ZombieType RouteBossType
	{
		[Token(Token = "0x6003426")]
		[Address(RVA = "0x72B920", Offset = "0x729F20", VA = "0x18072B920", Slot = "4")]
		get
		{
			return ZombieType.UltimateJacksonDriver;
		}
	}

	// Token: 0x17000225 RID: 549
	// (get) Token: 0x06003427 RID: 13351 RVA: 0x00116534 File Offset: 0x00114734
	[Token(Token = "0x17000225")]
	public override Dictionary<int, List<ZombieType>> Spawns
	{
		[Token(Token = "0x6003427")]
		[Address(RVA = "0x7291C0", Offset = "0x7277C0", VA = "0x1807291C0", Slot = "6")]
		get;
	}

	// Token: 0x17000226 RID: 550
	// (get) Token: 0x06003428 RID: 13352 RVA: 0x00116548 File Offset: 0x00114748
	[Token(Token = "0x17000226")]
	public override List<TravelDebuff> Debuffs
	{
		[Token(Token = "0x6003428")]
		[Address(RVA = "0x7291A0", Offset = "0x7277A0", VA = "0x1807291A0", Slot = "7")]
		get;
	}

	// Token: 0x06003429 RID: 13353 RVA: 0x0011655C File Offset: 0x0011475C
	[Token(Token = "0x6003429")]
	[Address(RVA = "0x72A590", Offset = "0x728B90", VA = "0x18072A590")]
	public TravelPackage3()
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
		int size19 = list15._size;
		dictionary[15] = list15;
		List<ZombieType> list16 = new List();
		int size20 = list16._size;
		int size21 = list16._size;
		dictionary[16] = list16;
		List<ZombieType> list17 = new List();
		int size22 = list17._size;
		int size23 = list17._size;
		int size24 = list17._size;
		int size25 = list17._size;
		dictionary[17] = list17;
		List<ZombieType> list18 = new List();
		int size26 = list18._size;
		int size27 = list18._size;
		int size28 = list18._size;
		int size29 = list18._size;
		int size30 = list18._size;
		int size31 = list18._size;
		int size32 = list18._size;
		int size33 = list18._size;
		dictionary[18] = list18;
		List<ZombieType> list19 = new List();
		int size34 = list19._size;
		int size35 = list19._size;
		dictionary[19] = list19;
		List<ZombieType> list20 = new List();
		int size36 = list20._size;
		int size37 = list20._size;
		dictionary[20] = list20;
		List<ZombieType> list21 = new List();
		dictionary[21] = list21;
		this.Spawns = dictionary;
		List<TravelDebuff> list22 = new List();
		this.Debuffs = list22;
		base..ctor();
	}
}
