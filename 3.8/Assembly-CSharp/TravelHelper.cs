using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020009E8 RID: 2536
[Token(Token = "0x20009E8")]
public static class TravelHelper
{
	// Token: 0x0600340E RID: 13326 RVA: 0x00115BD4 File Offset: 0x00113DD4
	[Token(Token = "0x600340E")]
	[Address(RVA = "0x7276F0", Offset = "0x725CF0", VA = "0x1807276F0")]
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

	// Token: 0x0600340F RID: 13327 RVA: 0x00115C24 File Offset: 0x00113E24
	[Token(Token = "0x600340F")]
	[Address(RVA = "0x7279C0", Offset = "0x725FC0", VA = "0x1807279C0")]
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

	// Token: 0x06003410 RID: 13328 RVA: 0x00115C60 File Offset: 0x00113E60
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x6003410")]
	[Address(RVA = "0x727BF0", Offset = "0x7261F0", VA = "0x180727BF0")]
	static TravelHelper()
	{
		throw new NullReferenceException();
	}

	// Token: 0x040025C3 RID: 9667
	[Token(Token = "0x40025C3")]
	public static HashSet<TravelDebuff> LeaderArmor = new HashSet();

	// Token: 0x040025C4 RID: 9668
	[Token(Token = "0x40025C4")]
	public static HashSet<TravelDebuff> LeaderAppear = new HashSet();
}
