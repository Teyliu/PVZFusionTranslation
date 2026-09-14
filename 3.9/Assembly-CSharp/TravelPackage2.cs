using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000A2F RID: 2607
[Token(Token = "0x2000A2F")]
public class TravelPackage2 : TravelPackage
{
	// Token: 0x17000267 RID: 615
	// (get) Token: 0x06003554 RID: 13652 RVA: 0x0011B128 File Offset: 0x00119328
	[Token(Token = "0x17000267")]
	public override bool LandRoute
	{
		[Token(Token = "0x6003554")]
		[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "5")]
		get
		{
			return false;
		}
	}

	// Token: 0x17000268 RID: 616
	// (get) Token: 0x06003555 RID: 13653 RVA: 0x0011B138 File Offset: 0x00119338
	[Token(Token = "0x17000268")]
	public override ZombieType RouteBossType
	{
		[Token(Token = "0x6003555")]
		[Address(RVA = "0x52AA80", Offset = "0x529080", VA = "0x18052AA80", Slot = "4")]
		get
		{
			return ZombieType.UltimateImpKing;
		}
	}

	// Token: 0x17000269 RID: 617
	// (get) Token: 0x06003556 RID: 13654 RVA: 0x0011B14C File Offset: 0x0011934C
	[Token(Token = "0x17000269")]
	public override Dictionary<int, List<ZombieType>> Spawns
	{
		[Token(Token = "0x6003556")]
		[Address(RVA = "0x78F240", Offset = "0x78D840", VA = "0x18078F240", Slot = "6")]
		get;
	}

	// Token: 0x1700026A RID: 618
	// (get) Token: 0x06003557 RID: 13655 RVA: 0x0011B160 File Offset: 0x00119360
	[Token(Token = "0x1700026A")]
	public override List<TravelDebuff> Debuffs
	{
		[Token(Token = "0x6003557")]
		[Address(RVA = "0x78F220", Offset = "0x78D820", VA = "0x18078F220", Slot = "7")]
		get;
	}

	// Token: 0x06003558 RID: 13656 RVA: 0x0011B174 File Offset: 0x00119374
	[Token(Token = "0x6003558")]
	[Address(RVA = "0x78F250", Offset = "0x78D850", VA = "0x18078F250")]
	public TravelPackage2()
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
		int size14 = list13._size;
		dictionary[13] = list13;
		List<ZombieType> list14 = new List();
		int size15 = list14._size;
		int size16 = list14._size;
		dictionary[14] = list14;
		List<ZombieType> list15 = new List();
		int size17 = list15._size;
		int size18 = list15._size;
		int size19 = list15._size;
		int size20 = list15._size;
		int size21 = list15._size;
		dictionary[15] = list15;
		List<ZombieType> list16 = new List();
		int size22 = list16._size;
		int size23 = list16._size;
		dictionary[16] = list16;
		List<ZombieType> list17 = new List();
		int size24 = list17._size;
		int size25 = list17._size;
		int size26 = list17._size;
		int size27 = list17._size;
		dictionary[17] = list17;
		List<ZombieType> list18 = new List();
		int size28 = list18._size;
		int size29 = list18._size;
		int size30 = list18._size;
		int size31 = list18._size;
		int size32 = list18._size;
		int size33 = list18._size;
		int size34 = list18._size;
		int size35 = list18._size;
		dictionary[18] = list18;
		List<ZombieType> list19 = new List();
		int size36 = list19._size;
		int size37 = list19._size;
		dictionary[19] = list19;
		List<ZombieType> list20 = new List();
		dictionary[20] = list20;
		List<ZombieType> list21 = new List();
		dictionary[21] = list21;
		this.Spawns = dictionary;
		List<TravelDebuff> list22 = new List();
	}
}
