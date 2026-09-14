using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020009F1 RID: 2545
[Token(Token = "0x20009F1")]
public abstract class TravelPackage
{
	// Token: 0x17000217 RID: 535
	// (get) Token: 0x06003415 RID: 13333 RVA: 0x00115D2C File Offset: 0x00113F2C
	[Token(Token = "0x17000217")]
	public virtual ZombieType RouteBossType
	{
		[Token(Token = "0x6003415")]
		[Address(RVA = "0x72EBF0", Offset = "0x72D1F0", VA = "0x18072EBF0", Slot = "4")]
		get;
	}

	// Token: 0x17000218 RID: 536
	// (get) Token: 0x06003416 RID: 13334 RVA: 0x00115D40 File Offset: 0x00113F40
	[Token(Token = "0x17000218")]
	public virtual bool LandRoute
	{
		[Token(Token = "0x6003416")]
		[Address(RVA = "0x72EBE0", Offset = "0x72D1E0", VA = "0x18072EBE0", Slot = "5")]
		get;
	}

	// Token: 0x17000219 RID: 537
	// (get) Token: 0x06003417 RID: 13335 RVA: 0x00115D54 File Offset: 0x00113F54
	[Token(Token = "0x17000219")]
	public virtual Dictionary<int, List<ZombieType>> Spawns
	{
		[Token(Token = "0x6003417")]
		[Address(RVA = "0x4A9CF0", Offset = "0x4A82F0", VA = "0x1804A9CF0", Slot = "6")]
		get;
	}

	// Token: 0x1700021A RID: 538
	// (get) Token: 0x06003418 RID: 13336 RVA: 0x00115D68 File Offset: 0x00113F68
	[Token(Token = "0x1700021A")]
	public virtual List<TravelDebuff> Debuffs
	{
		[Token(Token = "0x6003418")]
		[Address(RVA = "0x4A9D20", Offset = "0x4A8320", VA = "0x1804A9D20", Slot = "7")]
		get;
	}

	// Token: 0x06003419 RID: 13337 RVA: 0x00115D7C File Offset: 0x00113F7C
	[Token(Token = "0x6003419")]
	[Address(RVA = "0x72DFF0", Offset = "0x72C5F0", VA = "0x18072DFF0", Slot = "8")]
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

	// Token: 0x0600341A RID: 13338 RVA: 0x00115DE8 File Offset: 0x00113FE8
	[Token(Token = "0x600341A")]
	[Address(RVA = "0x72E3D0", Offset = "0x72C9D0", VA = "0x18072E3D0")]
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

	// Token: 0x0400274E RID: 10062
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400274E")]
	private readonly List<TravelDebuff> UniversalDebuffs;
}
