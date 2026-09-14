using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

// Token: 0x020009B4 RID: 2484
[Token(Token = "0x20009B4")]
public class PlayerShootingData
{
	// Token: 0x060032E0 RID: 13024 RVA: 0x0010E820 File Offset: 0x0010CA20
	[Token(Token = "0x60032E0")]
	[Address(RVA = "0x706390", Offset = "0x704990", VA = "0x180706390")]
	public static int GetWave(int level)
	{
		if (level == 1)
		{
			return 0;
		}
		return 0;
	}

	// Token: 0x060032E1 RID: 13025 RVA: 0x0010E834 File Offset: 0x0010CA34
	[Token(Token = "0x60032E1")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public PlayerShootingData()
	{
	}

	// Token: 0x060032E2 RID: 13026 RVA: 0x0010E848 File Offset: 0x0010CA48
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x60032E2")]
	[Address(RVA = "0x7063D0", Offset = "0x7049D0", VA = "0x1807063D0")]
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

	// Token: 0x04002489 RID: 9353
	[Token(Token = "0x4002489")]
	public static List<PlayerWeaponType> UnlockedWeapons = new List();

	// Token: 0x0400248A RID: 9354
	[Token(Token = "0x400248A")]
	public static int arrivedLevel;

	// Token: 0x0400248B RID: 9355
	[Token(Token = "0x400248B")]
	public static readonly Dictionary<PlayerWeaponBuff, ValueTuple<PlayerWeaponType, Action<PlayerWeapon>>> buffActions;

	// Token: 0x0400248C RID: 9356
	[Token(Token = "0x400248C")]
	public static readonly Dictionary<PlayerWeaponBuff, string> BuffData;

	// Token: 0x0400248D RID: 9357
	[Token(Token = "0x400248D")]
	public static readonly Dictionary<PlayerWeaponType, string> EvolutionDescription;

	// Token: 0x0400248E RID: 9358
	[Token(Token = "0x400248E")]
	[TupleElementNames(new string[] { "damage", "shootInterval", "loadingInterval" })]
	public static readonly Dictionary<PlayerWeaponType, ValueTuple<int, float, float>> WeaponDataDic;

	// Token: 0x0400248F RID: 9359
	[Token(Token = "0x400248F")]
	public static readonly Dictionary<PlayerWeaponType, PlantType> WeaponPlantPairs;

	// Token: 0x04002490 RID: 9360
	[Token(Token = "0x4002490")]
	public static readonly Dictionary<PlayerWeaponType, PlayerWeaponBuff[]> _weaponBuffsMap;

	// Token: 0x04002491 RID: 9361
	[Token(Token = "0x4002491")]
	[TupleElementNames(new string[] { "description", "count" })]
	public static readonly Dictionary<PlayerBuff, ValueTuple<string, int>> PlayerDescription;
}
