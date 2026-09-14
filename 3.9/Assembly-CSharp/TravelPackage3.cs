using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000A30 RID: 2608
[Token(Token = "0x2000A30")]
public class TravelPackage3 : TravelPackage
{
	// Token: 0x1700026B RID: 619
	// (get) Token: 0x06003559 RID: 13657 RVA: 0x0011B43C File Offset: 0x0011963C
	[Token(Token = "0x1700026B")]
	public override bool LandRoute
	{
		[Token(Token = "0x6003559")]
		[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "5")]
		get
		{
			return false;
		}
	}

	// Token: 0x1700026C RID: 620
	// (get) Token: 0x0600355A RID: 13658 RVA: 0x0011B44C File Offset: 0x0011964C
	[Token(Token = "0x1700026C")]
	public override ZombieType RouteBossType
	{
		[Token(Token = "0x600355A")]
		[Address(RVA = "0x7919A0", Offset = "0x78FFA0", VA = "0x1807919A0", Slot = "4")]
		get
		{
			return ZombieType.UltimateJacksonDriver;
		}
	}

	// Token: 0x1700026D RID: 621
	// (get) Token: 0x0600355B RID: 13659 RVA: 0x0011B460 File Offset: 0x00119660
	[Token(Token = "0x1700026D")]
	public override Dictionary<int, List<ZombieType>> Spawns
	{
		[Token(Token = "0x600355B")]
		[Address(RVA = "0x78F240", Offset = "0x78D840", VA = "0x18078F240", Slot = "6")]
		get;
	}

	// Token: 0x1700026E RID: 622
	// (get) Token: 0x0600355C RID: 13660 RVA: 0x0011B474 File Offset: 0x00119674
	[Token(Token = "0x1700026E")]
	public override List<TravelDebuff> Debuffs
	{
		[Token(Token = "0x600355C")]
		[Address(RVA = "0x78F220", Offset = "0x78D820", VA = "0x18078F220", Slot = "7")]
		get;
	}

	// Token: 0x0600355D RID: 13661 RVA: 0x0011B488 File Offset: 0x00119688
	[Token(Token = "0x600355D")]
	[Address(RVA = "0x790610", Offset = "0x78EC10", VA = "0x180790610")]
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
