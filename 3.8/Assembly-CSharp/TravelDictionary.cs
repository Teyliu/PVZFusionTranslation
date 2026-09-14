using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

// Token: 0x020009E9 RID: 2537
[Token(Token = "0x20009E9")]
public static class TravelDictionary
{
	// Token: 0x06003411 RID: 13329 RVA: 0x00115C88 File Offset: 0x00113E88
	[Token(Token = "0x6003411")]
	[Address(RVA = "0x71F050", Offset = "0x71D650", VA = "0x18071F050")]
	static TravelDictionary()
	{
		Dictionary<PlantType, ValueTuple<PlantType?, object, object, bool>> dictionary = new Dictionary();
	}

	// Token: 0x040025C5 RID: 9669
	[Token(Token = "0x40025C5")]
	public static Dictionary<ZombieType, TravelPackage> travelPackages = new Dictionary();

	// Token: 0x040025C6 RID: 9670
	[Token(Token = "0x40025C6")]
	public static Dictionary<TravelUnlocks, PlantType> UnlockToPlant = new Dictionary();

	// Token: 0x040025C7 RID: 9671
	[Token(Token = "0x40025C7")]
	public static Dictionary<PlantType, TravelUnlocks> PlantToUnlock = new Dictionary();

	// Token: 0x040025C8 RID: 9672
	[Token(Token = "0x40025C8")]
	[TupleElementNames(new string[] { "subType", "buff1", "buff2", "isStrongUltimate" })]
	public static readonly Dictionary<PlantType, ValueTuple<PlantType?, object, object, bool>> PlantInfo;

	// Token: 0x040025C9 RID: 9673
	[Token(Token = "0x40025C9")]
	[TupleElementNames(new string[] { "description", "zombieType" })]
	public static readonly Dictionary<TravelDebuff, ValueTuple<string, ZombieType>> debuffData;

	// Token: 0x040025CA RID: 9674
	[Token(Token = "0x40025CA")]
	public static readonly HashSet<AdvBuff> CurseBuffs;

	// Token: 0x040025CB RID: 9675
	[Token(Token = "0x40025CB")]
	public static readonly HashSet<AdvBuff> RandomBuffs;

	// Token: 0x040025CC RID: 9676
	[Token(Token = "0x40025CC")]
	public static readonly HashSet<AdvBuff> RogueBuffs;

	// Token: 0x040025CD RID: 9677
	[Token(Token = "0x40025CD")]
	public static Dictionary<AdvBuff, string> advancedBuffsText;

	// Token: 0x040025CE RID: 9678
	[Token(Token = "0x40025CE")]
	public static readonly Dictionary<UltiBuff, string> ultimateBuffsText;

	// Token: 0x040025CF RID: 9679
	[Token(Token = "0x40025CF")]
	public static readonly Dictionary<TravelUnlocks, string> unlocksText;

	// Token: 0x040025D0 RID: 9680
	[Token(Token = "0x40025D0")]
	public static Dictionary<AdvBuff, PlantType> AdvBuffPlantPairs;

	// Token: 0x040025D1 RID: 9681
	[Token(Token = "0x40025D1")]
	public static List<PlantType> allStrongUltimtePlant;
}
