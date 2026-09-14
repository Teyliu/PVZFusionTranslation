using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020009F5 RID: 2549
[Token(Token = "0x20009F5")]
public class TravelPackage4 : TravelPackage
{
	// Token: 0x17000227 RID: 551
	// (get) Token: 0x0600342A RID: 13354 RVA: 0x00116838 File Offset: 0x00114A38
	[Token(Token = "0x17000227")]
	public override bool LandRoute
	{
		[Token(Token = "0x600342A")]
		[Address(RVA = "0x3A5ED0", Offset = "0x3A44D0", VA = "0x1803A5ED0", Slot = "5")]
		get
		{
			return true;
		}
	}

	// Token: 0x17000228 RID: 552
	// (get) Token: 0x0600342B RID: 13355 RVA: 0x00116848 File Offset: 0x00114A48
	[Token(Token = "0x17000228")]
	public override ZombieType RouteBossType
	{
		[Token(Token = "0x600342B")]
		[Address(RVA = "0x4CFEA0", Offset = "0x4CE4A0", VA = "0x1804CFEA0", Slot = "4")]
		get
		{
			return ZombieType.UltimateFootballZombie;
		}
	}

	// Token: 0x17000229 RID: 553
	// (get) Token: 0x0600342C RID: 13356 RVA: 0x0011685C File Offset: 0x00114A5C
	[Token(Token = "0x17000229")]
	public override Dictionary<int, List<ZombieType>> Spawns
	{
		[Token(Token = "0x600342C")]
		[Address(RVA = "0x7291C0", Offset = "0x7277C0", VA = "0x1807291C0", Slot = "6")]
		get;
	}

	// Token: 0x1700022A RID: 554
	// (get) Token: 0x0600342D RID: 13357 RVA: 0x00116870 File Offset: 0x00114A70
	[Token(Token = "0x1700022A")]
	public override List<TravelDebuff> Debuffs
	{
		[Token(Token = "0x600342D")]
		[Address(RVA = "0x7291A0", Offset = "0x7277A0", VA = "0x1807291A0", Slot = "7")]
		get;
	}

	// Token: 0x0600342E RID: 13358 RVA: 0x00116884 File Offset: 0x00114A84
	[Token(Token = "0x600342E")]
	[Address(RVA = "0x72B930", Offset = "0x729F30", VA = "0x18072B930")]
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
