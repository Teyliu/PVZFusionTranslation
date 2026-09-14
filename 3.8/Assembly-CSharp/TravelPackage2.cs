using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020009F3 RID: 2547
[Token(Token = "0x20009F3")]
public class TravelPackage2 : TravelPackage
{
	// Token: 0x1700021F RID: 543
	// (get) Token: 0x06003420 RID: 13344 RVA: 0x001161FC File Offset: 0x001143FC
	[Token(Token = "0x1700021F")]
	public override bool LandRoute
	{
		[Token(Token = "0x6003420")]
		[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "5")]
		get
		{
			return false;
		}
	}

	// Token: 0x17000220 RID: 544
	// (get) Token: 0x06003421 RID: 13345 RVA: 0x0011620C File Offset: 0x0011440C
	[Token(Token = "0x17000220")]
	public override ZombieType RouteBossType
	{
		[Token(Token = "0x6003421")]
		[Address(RVA = "0x4CE6C0", Offset = "0x4CCCC0", VA = "0x1804CE6C0", Slot = "4")]
		get
		{
			return ZombieType.UltimateImpKing;
		}
	}

	// Token: 0x17000221 RID: 545
	// (get) Token: 0x06003422 RID: 13346 RVA: 0x00116220 File Offset: 0x00114420
	[Token(Token = "0x17000221")]
	public override Dictionary<int, List<ZombieType>> Spawns
	{
		[Token(Token = "0x6003422")]
		[Address(RVA = "0x7291C0", Offset = "0x7277C0", VA = "0x1807291C0", Slot = "6")]
		get;
	}

	// Token: 0x17000222 RID: 546
	// (get) Token: 0x06003423 RID: 13347 RVA: 0x00116234 File Offset: 0x00114434
	[Token(Token = "0x17000222")]
	public override List<TravelDebuff> Debuffs
	{
		[Token(Token = "0x6003423")]
		[Address(RVA = "0x7291A0", Offset = "0x7277A0", VA = "0x1807291A0", Slot = "7")]
		get;
	}

	// Token: 0x06003424 RID: 13348 RVA: 0x00116248 File Offset: 0x00114448
	[Token(Token = "0x6003424")]
	[Address(RVA = "0x7291D0", Offset = "0x7277D0", VA = "0x1807291D0")]
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
