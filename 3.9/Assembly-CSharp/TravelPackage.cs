using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000A2D RID: 2605
[Token(Token = "0x2000A2D")]
public abstract class TravelPackage
{
	// Token: 0x1700025F RID: 607
	// (get) Token: 0x06003549 RID: 13641 RVA: 0x0011AC58 File Offset: 0x00118E58
	[Token(Token = "0x1700025F")]
	public virtual ZombieType RouteBossType
	{
		[Token(Token = "0x6003549")]
		[Address(RVA = "0x794C70", Offset = "0x793270", VA = "0x180794C70", Slot = "4")]
		get;
	}

	// Token: 0x17000260 RID: 608
	// (get) Token: 0x0600354A RID: 13642 RVA: 0x0011AC6C File Offset: 0x00118E6C
	[Token(Token = "0x17000260")]
	public virtual bool LandRoute
	{
		[Token(Token = "0x600354A")]
		[Address(RVA = "0x794C60", Offset = "0x793260", VA = "0x180794C60", Slot = "5")]
		get;
	}

	// Token: 0x17000261 RID: 609
	// (get) Token: 0x0600354B RID: 13643 RVA: 0x0011AC80 File Offset: 0x00118E80
	[Token(Token = "0x17000261")]
	public virtual Dictionary<int, List<ZombieType>> Spawns
	{
		[Token(Token = "0x600354B")]
		[Address(RVA = "0x515920", Offset = "0x513F20", VA = "0x180515920", Slot = "6")]
		get;
	}

	// Token: 0x17000262 RID: 610
	// (get) Token: 0x0600354C RID: 13644 RVA: 0x0011AC94 File Offset: 0x00118E94
	[Token(Token = "0x17000262")]
	public virtual List<TravelDebuff> Debuffs
	{
		[Token(Token = "0x600354C")]
		[Address(RVA = "0x515950", Offset = "0x513F50", VA = "0x180515950", Slot = "7")]
		get;
	}

	// Token: 0x0600354D RID: 13645 RVA: 0x0011ACA8 File Offset: 0x00118EA8
	[Token(Token = "0x600354D")]
	[Address(RVA = "0x794070", Offset = "0x792670", VA = "0x180794070", Slot = "8")]
	public virtual void Init()
	{
		int num;
		do
		{
			List<TravelDebuff> debuffs = this.Debuffs;
			List<TravelDebuff> universalDebuffs = this.UniversalDebuffs;
			debuffs.AddRange(universalDebuffs);
			Dictionary<int, List<ZombieType>> spawns = this.Spawns;
			num = 0;
			bool flag;
			if (flag)
			{
				Dictionary<TravelDebuff, ValueTuple<string, ZombieType>> debuffData = TravelDictionary.debuffData;
				bool flag2;
				if (flag2)
				{
					bool flag3;
					while (!flag3)
					{
					}
					List<TravelDebuff> debuffs2 = this.Debuffs;
				}
				if (num != 0)
				{
					goto IL_0057;
				}
			}
		}
		while (num != 0);
		return;
		IL_0057:
		throw new NullReferenceException();
	}

	// Token: 0x0600354E RID: 13646 RVA: 0x0011AD14 File Offset: 0x00118F14
	[Token(Token = "0x600354E")]
	[Address(RVA = "0x794450", Offset = "0x792A50", VA = "0x180794450")]
	protected TravelPackage()
	{
		List<TravelDebuff> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		int size5 = list._size;
		int size6 = list._size;
		int size7 = list._size;
		int size8 = list._size;
		int size9 = list._size;
		int size10 = list._size;
		int size11 = list._size;
		int size12 = list._size;
		int size13 = list._size;
		int size14 = list._size;
		int size15 = list._size;
		int size16 = list._size;
		int size17 = list._size;
		int size18 = list._size;
		int size19 = list._size;
		int size20 = list._size;
		int size21 = list._size;
		this.UniversalDebuffs = list;
		Dictionary<int, List<ZombieType>> dictionary = new Dictionary();
		this.Spawns = dictionary;
		List<TravelDebuff> list2 = new List();
		this.Debuffs = list2;
		base..ctor();
	}

	// Token: 0x040028AE RID: 10414
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40028AE")]
	private readonly List<TravelDebuff> UniversalDebuffs;
}
