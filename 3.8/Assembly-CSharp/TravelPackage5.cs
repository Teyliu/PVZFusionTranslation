using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020009F6 RID: 2550
[Token(Token = "0x20009F6")]
public class TravelPackage5 : TravelPackage
{
	// Token: 0x1700022B RID: 555
	// (get) Token: 0x0600342F RID: 13359 RVA: 0x00116B60 File Offset: 0x00114D60
	[Token(Token = "0x1700022B")]
	public override bool LandRoute
	{
		[Token(Token = "0x600342F")]
		[Address(RVA = "0x3A5ED0", Offset = "0x3A44D0", VA = "0x1803A5ED0", Slot = "5")]
		get
		{
			return true;
		}
	}

	// Token: 0x1700022C RID: 556
	// (get) Token: 0x06003430 RID: 13360 RVA: 0x00116B70 File Offset: 0x00114D70
	[Token(Token = "0x1700022C")]
	public override ZombieType RouteBossType
	{
		[Token(Token = "0x6003430")]
		[Address(RVA = "0x72DFE0", Offset = "0x72C5E0", VA = "0x18072DFE0", Slot = "4")]
		get
		{
			return ZombieType.UltimateHorse;
		}
	}

	// Token: 0x1700022D RID: 557
	// (get) Token: 0x06003431 RID: 13361 RVA: 0x00116B84 File Offset: 0x00114D84
	[Token(Token = "0x1700022D")]
	public override Dictionary<int, List<ZombieType>> Spawns
	{
		[Token(Token = "0x6003431")]
		[Address(RVA = "0x7291C0", Offset = "0x7277C0", VA = "0x1807291C0", Slot = "6")]
		get;
	}

	// Token: 0x1700022E RID: 558
	// (get) Token: 0x06003432 RID: 13362 RVA: 0x00116B98 File Offset: 0x00114D98
	[Token(Token = "0x1700022E")]
	public override List<TravelDebuff> Debuffs
	{
		[Token(Token = "0x6003432")]
		[Address(RVA = "0x7291A0", Offset = "0x7277A0", VA = "0x1807291A0", Slot = "7")]
		get;
	}

	// Token: 0x06003433 RID: 13363 RVA: 0x00116BAC File Offset: 0x00114DAC
	[Token(Token = "0x6003433")]
	[Address(RVA = "0x72CC80", Offset = "0x72B280", VA = "0x18072CC80")]
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
