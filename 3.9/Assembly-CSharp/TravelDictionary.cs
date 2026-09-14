using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

// Token: 0x02000A25 RID: 2597
[Token(Token = "0x2000A25")]
public static class TravelDictionary
{
	// Token: 0x040026D7 RID: 9943
	[Token(Token = "0x40026D7")]
	public static Dictionary<ZombieType, TravelPackage> travelPackages;

	// Token: 0x040026D8 RID: 9944
	[Token(Token = "0x40026D8")]
	public static Dictionary<TravelUnlocks, PlantType> UnlockToPlant;

	// Token: 0x040026D9 RID: 9945
	[Token(Token = "0x40026D9")]
	public static Dictionary<PlantType, TravelUnlocks> PlantToUnlock;

	// Token: 0x040026DA RID: 9946
	[Token(Token = "0x40026DA")]
	[TupleElementNames(new string[] { "subType", "buff1", "buff2", "isStrongUltimate" })]
	public static readonly Dictionary<PlantType, ValueTuple<PlantType?, object, object, bool>> PlantInfo;

	// Token: 0x040026DB RID: 9947
	[Token(Token = "0x40026DB")]
	[TupleElementNames(new string[] { "description", "zombieType" })]
	public static readonly Dictionary<TravelDebuff, ValueTuple<string, ZombieType>> debuffData;

	// Token: 0x040026DC RID: 9948
	[Token(Token = "0x40026DC")]
	public static HashSet<PlantType> SpPlants;

	// Token: 0x040026DD RID: 9949
	[Token(Token = "0x40026DD")]
	public static readonly HashSet<AdvBuff> CurseBuffs;

	// Token: 0x040026DE RID: 9950
	[Token(Token = "0x40026DE")]
	public static readonly HashSet<AdvBuff> RandomBuffs;

	// Token: 0x040026DF RID: 9951
	[Token(Token = "0x40026DF")]
	public static readonly HashSet<AdvBuff> RogueBuffs;

	// Token: 0x040026E0 RID: 9952
	[Token(Token = "0x40026E0")]
	public static Dictionary<AdvBuff, string> advancedBuffsText;

	// Token: 0x040026E1 RID: 9953
	[Token(Token = "0x40026E1")]
	public static readonly Dictionary<UltiBuff, string> ultimateBuffsText;

	// Token: 0x040026E2 RID: 9954
	[Token(Token = "0x40026E2")]
	public static readonly Dictionary<TravelUnlocks, string> unlocksText;

	// Token: 0x040026E3 RID: 9955
	[Token(Token = "0x40026E3")]
	public static Dictionary<AdvBuff, PlantType> AdvBuffPlantPairs;

	// Token: 0x040026E4 RID: 9956
	[Token(Token = "0x40026E4")]
	public static List<PlantType> allStrongUltimtePlant;
}
