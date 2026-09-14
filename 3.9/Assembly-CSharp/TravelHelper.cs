using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000A24 RID: 2596
[Token(Token = "0x2000A24")]
public static class TravelHelper
{
	// Token: 0x06003542 RID: 13634 RVA: 0x0011AB2C File Offset: 0x00118D2C
	[Token(Token = "0x6003542")]
	[Address(RVA = "0x78D770", Offset = "0x78BD70", VA = "0x18078D770")]
	public static List<PlantType> GetAllUltimatePlantTypes(bool isStrongUltimate, bool withSub = true)
	{
		List<PlantType> list;
		ulong num;
		do
		{
			list = new List();
			Dictionary<PlantType, ValueTuple<PlantType?, object, object, bool>> plantInfo = TravelDictionary.PlantInfo;
			bool flag;
			if (flag)
			{
				while (flag != isStrongUltimate)
				{
				}
				while (!withSub)
				{
				}
				while (!flag)
				{
				}
			}
		}
		while (num != (ulong)0L);
		return list;
	}

	// Token: 0x06003543 RID: 13635 RVA: 0x0011AB7C File Offset: 0x00118D7C
	[Token(Token = "0x6003543")]
	[Address(RVA = "0x78DA40", Offset = "0x78C040", VA = "0x18078DA40")]
	public static PlantType GetPlantTypeFromBuff(object buff)
	{
		ulong num;
		do
		{
			Dictionary<PlantType, ValueTuple<PlantType?, object, object, bool>> plantInfo = TravelDictionary.PlantInfo;
			bool flag;
			if (flag)
			{
				if (flag)
				{
				}
				while (!flag)
				{
				}
			}
		}
		while (num != (ulong)0L);
		return PlantType.Nothing;
	}

	// Token: 0x06003544 RID: 13636 RVA: 0x0011ABB8 File Offset: 0x00118DB8
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x6003544")]
	[Address(RVA = "0x78DC70", Offset = "0x78C270", VA = "0x18078DC70")]
	static TravelHelper()
	{
		throw new NullReferenceException();
	}

	// Token: 0x040026D5 RID: 9941
	[Token(Token = "0x40026D5")]
	public static HashSet<TravelDebuff> LeaderArmor = new HashSet();

	// Token: 0x040026D6 RID: 9942
	[Token(Token = "0x40026D6")]
	public static HashSet<TravelDebuff> LeaderAppear = new HashSet();
}
