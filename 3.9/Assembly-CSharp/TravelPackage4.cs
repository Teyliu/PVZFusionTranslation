using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000A31 RID: 2609
[Token(Token = "0x2000A31")]
public class TravelPackage4 : TravelPackage
{
	// Token: 0x1700026F RID: 623
	// (get) Token: 0x0600355E RID: 13662 RVA: 0x0011B764 File Offset: 0x00119964
	[Token(Token = "0x1700026F")]
	public override bool LandRoute
	{
		[Token(Token = "0x600355E")]
		[Address(RVA = "0x3F1E60", Offset = "0x3F0460", VA = "0x1803F1E60", Slot = "5")]
		get
		{
			return true;
		}
	}

	// Token: 0x17000270 RID: 624
	// (get) Token: 0x0600355F RID: 13663 RVA: 0x0011B774 File Offset: 0x00119974
	[Token(Token = "0x17000270")]
	public override ZombieType RouteBossType
	{
		[Token(Token = "0x600355F")]
		[Address(RVA = "0x52C7D0", Offset = "0x52ADD0", VA = "0x18052C7D0", Slot = "4")]
		get
		{
			return ZombieType.UltimateFootballZombie;
		}
	}

	// Token: 0x17000271 RID: 625
	// (get) Token: 0x06003560 RID: 13664 RVA: 0x0011B788 File Offset: 0x00119988
	[Token(Token = "0x17000271")]
	public override Dictionary<int, List<ZombieType>> Spawns
	{
		[Token(Token = "0x6003560")]
		[Address(RVA = "0x78F240", Offset = "0x78D840", VA = "0x18078F240", Slot = "6")]
		get;
	}

	// Token: 0x17000272 RID: 626
	// (get) Token: 0x06003561 RID: 13665 RVA: 0x0011B79C File Offset: 0x0011999C
	[Token(Token = "0x17000272")]
	public override List<TravelDebuff> Debuffs
	{
		[Token(Token = "0x6003561")]
		[Address(RVA = "0x78F220", Offset = "0x78D820", VA = "0x18078F220", Slot = "7")]
		get;
	}

	// Token: 0x06003562 RID: 13666 RVA: 0x0011B7B0 File Offset: 0x001199B0
	[Token(Token = "0x6003562")]
	[Address(RVA = "0x7919B0", Offset = "0x78FFB0", VA = "0x1807919B0")]
	public TravelPackage4()
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
		dictionary[18] = list18;
		List<ZombieType> list19 = new List();
		int size31 = list19._size;
		int size32 = list19._size;
		dictionary[19] = list19;
		List<ZombieType> list20 = new List();
		int size33 = list20._size;
		int size34 = list20._size;
		int size35 = list20._size;
		int size36 = list20._size;
		dictionary[20] = list20;
		List<ZombieType> list21 = new List();
		int size37 = list21._size;
		dictionary[21] = list21;
		this.Spawns = dictionary;
		List<TravelDebuff> list22 = new List();
		this.Debuffs = list22;
		base..ctor();
	}
}
