using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000A32 RID: 2610
[Token(Token = "0x2000A32")]
public class TravelPackage5 : TravelPackage
{
	// Token: 0x17000273 RID: 627
	// (get) Token: 0x06003563 RID: 13667 RVA: 0x0011BA8C File Offset: 0x00119C8C
	[Token(Token = "0x17000273")]
	public override bool LandRoute
	{
		[Token(Token = "0x6003563")]
		[Address(RVA = "0x3F1E60", Offset = "0x3F0460", VA = "0x1803F1E60", Slot = "5")]
		get
		{
			return true;
		}
	}

	// Token: 0x17000274 RID: 628
	// (get) Token: 0x06003564 RID: 13668 RVA: 0x0011BA9C File Offset: 0x00119C9C
	[Token(Token = "0x17000274")]
	public override ZombieType RouteBossType
	{
		[Token(Token = "0x6003564")]
		[Address(RVA = "0x794060", Offset = "0x792660", VA = "0x180794060", Slot = "4")]
		get
		{
			return ZombieType.UltimateHorse;
		}
	}

	// Token: 0x17000275 RID: 629
	// (get) Token: 0x06003565 RID: 13669 RVA: 0x0011BAB0 File Offset: 0x00119CB0
	[Token(Token = "0x17000275")]
	public override Dictionary<int, List<ZombieType>> Spawns
	{
		[Token(Token = "0x6003565")]
		[Address(RVA = "0x78F240", Offset = "0x78D840", VA = "0x18078F240", Slot = "6")]
		get;
	}

	// Token: 0x17000276 RID: 630
	// (get) Token: 0x06003566 RID: 13670 RVA: 0x0011BAC4 File Offset: 0x00119CC4
	[Token(Token = "0x17000276")]
	public override List<TravelDebuff> Debuffs
	{
		[Token(Token = "0x6003566")]
		[Address(RVA = "0x78F220", Offset = "0x78D820", VA = "0x18078F220", Slot = "7")]
		get;
	}

	// Token: 0x06003567 RID: 13671 RVA: 0x0011BAD8 File Offset: 0x00119CD8
	[Token(Token = "0x6003567")]
	[Address(RVA = "0x792D00", Offset = "0x791300", VA = "0x180792D00")]
	public TravelPackage5()
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
		dictionary[17] = list17;
		List<ZombieType> list18 = new List();
		int size25 = list18._size;
		int size26 = list18._size;
		int size27 = list18._size;
		int size28 = list18._size;
		int size29 = list18._size;
		int size30 = list18._size;
		int size31 = list18._size;
		dictionary[18] = list18;
		List<ZombieType> list19 = new List();
		int size32 = list19._size;
		int size33 = list19._size;
		dictionary[19] = list19;
		List<ZombieType> list20 = new List();
		int size34 = list20._size;
		int size35 = list20._size;
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
