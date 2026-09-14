using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

// Token: 0x020009F0 RID: 2544
[Token(Token = "0x20009F0")]
public class PlayerShootingData
{
	// Token: 0x06003414 RID: 13332 RVA: 0x00113830 File Offset: 0x00111A30
	[Token(Token = "0x6003414")]
	[Address(RVA = "0x76B8B0", Offset = "0x769EB0", VA = "0x18076B8B0")]
	public static int GetWave(int level)
	{
		if (level == 1)
		{
			return 0;
		}
		return 0;
	}

	// Token: 0x06003415 RID: 13333 RVA: 0x00113844 File Offset: 0x00111A44
	[Token(Token = "0x6003415")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public PlayerShootingData()
	{
	}

	// Token: 0x06003416 RID: 13334 RVA: 0x00113858 File Offset: 0x00111A58
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x6003416")]
	[Address(RVA = "0x76B8F0", Offset = "0x769EF0", VA = "0x18076B8F0")]
	static PlayerShootingData()
	{
		Dictionary<PlayerWeaponBuff, ValueTuple<PlayerWeaponType, Action<PlayerWeapon>>> dictionary = new Dictionary();
		int num = 0;
		dictionary.Add((uint)42, num);
		int num2 = 0;
		dictionary.Add((uint)44, num2);
		int num3 = 0;
		dictionary.Add((uint)43, num3);
		int num4 = 0;
		dictionary.Add((uint)39, num4);
		int num5 = 0;
		dictionary.Add((uint)38, num5);
		int num6 = 0;
		dictionary.Add((uint)40, num6);
		int num7 = 0;
		dictionary.Add((uint)41, num7);
		int num8 = 0;
		dictionary.Add((uint)19, num8);
		int num9 = 0;
		dictionary.Add((uint)20, num9);
		int num10 = 0;
		dictionary.Add((uint)21, num10);
		int num11 = 0;
		dictionary.Add((uint)22, num11);
		int num12 = 0;
		dictionary.Add((uint)1, num12);
		int num13 = 0;
		dictionary.Add((uint)2, num13);
		int num14 = 0;
		dictionary.Add((uint)3, num14);
		int num15 = 0;
		dictionary.Add((uint)4, num15);
		int num16 = 0;
		dictionary.Add((uint)5, num16);
		int num17 = 0;
		dictionary.Add((uint)6, num17);
		int num18 = 0;
		dictionary.Add((uint)7, num18);
		int num19 = 0;
		dictionary.Add((uint)8, num19);
		int num20 = 0;
		dictionary.Add((uint)9, num20);
		int num21 = 0;
		dictionary.Add((uint)12, num21);
	}

	// Token: 0x0400259B RID: 9627
	[Token(Token = "0x400259B")]
	public static List<PlayerWeaponType> UnlockedWeapons = new List();

	// Token: 0x0400259C RID: 9628
	[Token(Token = "0x400259C")]
	public static int arrivedLevel;

	// Token: 0x0400259D RID: 9629
	[Token(Token = "0x400259D")]
	public static readonly Dictionary<PlayerWeaponBuff, ValueTuple<PlayerWeaponType, Action<PlayerWeapon>>> buffActions;

	// Token: 0x0400259E RID: 9630
	[Token(Token = "0x400259E")]
	public static readonly Dictionary<PlayerWeaponBuff, string> BuffData;

	// Token: 0x0400259F RID: 9631
	[Token(Token = "0x400259F")]
	public static readonly Dictionary<PlayerWeaponType, string> EvolutionDescription;

	// Token: 0x040025A0 RID: 9632
	[Token(Token = "0x40025A0")]
	[TupleElementNames(new string[] { "damage", "shootInterval", "loadingInterval" })]
	public static readonly Dictionary<PlayerWeaponType, ValueTuple<int, float, float>> WeaponDataDic;

	// Token: 0x040025A1 RID: 9633
	[Token(Token = "0x40025A1")]
	public static readonly Dictionary<PlayerWeaponType, PlantType> WeaponPlantPairs;

	// Token: 0x040025A2 RID: 9634
	[Token(Token = "0x40025A2")]
	public static readonly Dictionary<PlayerWeaponType, PlayerWeaponBuff[]> _weaponBuffsMap;

	// Token: 0x040025A3 RID: 9635
	[Token(Token = "0x40025A3")]
	[TupleElementNames(new string[] { "description", "count" })]
	public static readonly Dictionary<PlayerBuff, ValueTuple<string, int>> PlayerDescription;
}
