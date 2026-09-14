using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000A2E RID: 2606
[Token(Token = "0x2000A2E")]
public class TravelPackage1 : TravelPackage
{
	// Token: 0x17000263 RID: 611
	// (get) Token: 0x0600354F RID: 13647 RVA: 0x0011AE00 File Offset: 0x00119000
	[Token(Token = "0x17000263")]
	public override bool LandRoute
	{
		[Token(Token = "0x600354F")]
		[Address(RVA = "0x3F1E60", Offset = "0x3F0460", VA = "0x1803F1E60", Slot = "5")]
		get
		{
			return true;
		}
	}

	// Token: 0x17000264 RID: 612
	// (get) Token: 0x06003550 RID: 13648 RVA: 0x0011AE10 File Offset: 0x00119010
	[Token(Token = "0x17000264")]
	public override ZombieType RouteBossType
	{
		[Token(Token = "0x6003550")]
		[Address(RVA = "0x78F230", Offset = "0x78D830", VA = "0x18078F230", Slot = "4")]
		get
		{
			return ZombieType.UltimateGargantuar;
		}
	}

	// Token: 0x17000265 RID: 613
	// (get) Token: 0x06003551 RID: 13649 RVA: 0x0011AE24 File Offset: 0x00119024
	[Token(Token = "0x17000265")]
	public override Dictionary<int, List<ZombieType>> Spawns
	{
		[Token(Token = "0x6003551")]
		[Address(RVA = "0x78F240", Offset = "0x78D840", VA = "0x18078F240", Slot = "6")]
		get;
	}

	// Token: 0x17000266 RID: 614
	// (get) Token: 0x06003552 RID: 13650 RVA: 0x0011AE38 File Offset: 0x00119038
	[Token(Token = "0x17000266")]
	public override List<TravelDebuff> Debuffs
	{
		[Token(Token = "0x6003552")]
		[Address(RVA = "0x78F220", Offset = "0x78D820", VA = "0x18078F220", Slot = "7")]
		get;
	}

	// Token: 0x06003553 RID: 13651 RVA: 0x0011AE4C File Offset: 0x0011904C
	[Token(Token = "0x6003553")]
	[Address(RVA = "0x78DEE0", Offset = "0x78C4E0", VA = "0x18078DEE0")]
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
