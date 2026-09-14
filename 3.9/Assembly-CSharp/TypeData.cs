using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

// Token: 0x02000A33 RID: 2611
[Token(Token = "0x2000A33")]
public class TypeData
{
	// Token: 0x06003568 RID: 13672 RVA: 0x0011BDB4 File Offset: 0x00119FB4
	[Token(Token = "0x6003568")]
	[Address(RVA = "0x794E70", Offset = "0x793470", VA = "0x180794E70")]
	static TypeData()
	{
		HashSet<PlantType> hashSet = new HashSet();
	}

	// Token: 0x06003569 RID: 13673 RVA: 0x0011BE2C File Offset: 0x0011A02C
	[Token(Token = "0x6003569")]
	[Address(RVA = "0x794C80", Offset = "0x793280", VA = "0x180794C80")]
	private static void InitSnowPlants()
	{
		List<PlantType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		TypeData.SnowPlants = Enumerable.ToHashSet<PlantType>(PlantMixTreeManager.GetAllMixablePlantsCombined(list));
		throw new NullReferenceException();
	}

	// Token: 0x0600356A RID: 13674 RVA: 0x0011BE6C File Offset: 0x0011A06C
	[Token(Token = "0x600356A")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public TypeData()
	{
	}

	// Token: 0x040028BD RID: 10429
	[Token(Token = "0x40028BD")]
	public static HashSet<PlantType> WhiteCardPlants = new HashSet();

	// Token: 0x040028BE RID: 10430
	[Token(Token = "0x40028BE")]
	public static HashSet<PlantType> SpecialCardPlants = new HashSet();

	// Token: 0x040028BF RID: 10431
	[Token(Token = "0x40028BF")]
	public static HashSet<PlantType> WallNutPlants = new HashSet();

	// Token: 0x040028C0 RID: 10432
	[Token(Token = "0x40028C0")]
	public static HashSet<PlantType> TallNutPlants = new HashSet();

	// Token: 0x040028C1 RID: 10433
	[Token(Token = "0x40028C1")]
	public static HashSet<PlantType> PumpkinPlants = new HashSet();

	// Token: 0x040028C2 RID: 10434
	[Token(Token = "0x40028C2")]
	public static HashSet<PlantType> TorchPlants = new HashSet();

	// Token: 0x040028C3 RID: 10435
	[Token(Token = "0x40028C3")]
	public static HashSet<PlantType> LilyPlants = new HashSet();

	// Token: 0x040028C4 RID: 10436
	[Token(Token = "0x40028C4")]
	public static HashSet<PlantType> KelpPlants = new HashSet();

	// Token: 0x040028C5 RID: 10437
	[Token(Token = "0x40028C5")]
	public static HashSet<PlantType> WaterPlants = new HashSet();

	// Token: 0x040028C6 RID: 10438
	[Token(Token = "0x40028C6")]
	public static HashSet<PlantType> SpikeRockPlants = new HashSet();

	// Token: 0x040028C7 RID: 10439
	[Token(Token = "0x40028C7")]
	public static HashSet<PlantType> CaltropPlants;

	// Token: 0x040028C8 RID: 10440
	[Token(Token = "0x40028C8")]
	public static HashSet<PlantType> PotatoPlants;

	// Token: 0x040028C9 RID: 10441
	[Token(Token = "0x40028C9")]
	public static HashSet<PlantType> PotPlants;

	// Token: 0x040028CA RID: 10442
	[Token(Token = "0x40028CA")]
	public static HashSet<PlantType> PuffPlants;

	// Token: 0x040028CB RID: 10443
	[Token(Token = "0x40028CB")]
	public static HashSet<PlantType> BigNutPlants;

	// Token: 0x040028CC RID: 10444
	[Token(Token = "0x40028CC")]
	public static HashSet<PlantType> FirePlants;

	// Token: 0x040028CD RID: 10445
	[Token(Token = "0x40028CD")]
	public static HashSet<PlantType> FlyingPlants;

	// Token: 0x040028CE RID: 10446
	[Token(Token = "0x40028CE")]
	public static HashSet<PlantType> UmbrellaPlants;

	// Token: 0x040028CF RID: 10447
	[Token(Token = "0x40028CF")]
	public static HashSet<PlantType> DoubleBoxPlants;

	// Token: 0x040028D0 RID: 10448
	[Token(Token = "0x40028D0")]
	public static HashSet<PlantType> MagnetPlants;

	// Token: 0x040028D1 RID: 10449
	[Token(Token = "0x40028D1")]
	public static HashSet<PlantType> SnowPlants;

	// Token: 0x040028D2 RID: 10450
	[Token(Token = "0x40028D2")]
	public static HashSet<PlantType> PickaxeStars;

	// Token: 0x040028D3 RID: 10451
	[Token(Token = "0x40028D3")]
	public static HashSet<PlantType> IcePlants;

	// Token: 0x040028D4 RID: 10452
	[Token(Token = "0x40028D4")]
	public static HashSet<PlantType> SmallPlanternPlants;

	// Token: 0x040028D5 RID: 10453
	[Token(Token = "0x40028D5")]
	public static HashSet<PlantType> PlanternPlants;

	// Token: 0x040028D6 RID: 10454
	[Token(Token = "0x40028D6")]
	public static HashSet<PlantType> VirtualPlants;
}
