using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020009B9 RID: 2489
[Token(Token = "0x20009B9")]
public class PotEffects
{
	// Token: 0x06003311 RID: 13073 RVA: 0x0010EF00 File Offset: 0x0010D100
	[Token(Token = "0x6003311")]
	[Address(RVA = "0x709CC0", Offset = "0x7082C0", VA = "0x180709CC0")]
	public static void CabbagePotEffect(Plant cabbage, int theColumn, int theRow, float originalValue, float targetValue)
	{
		ulong num3;
		do
		{
			int num = 0;
			List<Plant> plants = Board.Instance.gridSystem.GetGrid(theColumn, theRow).plants;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
				cabbage.thePlantAttackInterval = (float)0;
			}
		}
		while (num3 != (ulong)0L);
	}

	// Token: 0x06003312 RID: 13074 RVA: 0x0010EF5C File Offset: 0x0010D15C
	[Token(Token = "0x6003312")]
	[Address(RVA = "0x709EE0", Offset = "0x7084E0", VA = "0x180709EE0")]
	public static void CornPotEffect(Plant corn, int theColumn, int theRow, int originalValue, int targetValue)
	{
		ulong num3;
		do
		{
			int num = 0;
			List<Plant> plants = Board.Instance.gridSystem.GetGrid(theColumn, theRow).plants;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				bool flag2 = num != num2;
				while (!flag2)
				{
				}
				bool flag3;
				if (flag2)
				{
					flag3 = Lawnf.TravelAdvanced((AdvBuff)((uint)33));
					corn.butterP = 0;
				}
				if (!flag3)
				{
					corn.butterP = 0;
				}
				corn.butterP = 0;
			}
		}
		while (num3 != (ulong)0L);
	}

	// Token: 0x06003313 RID: 13075 RVA: 0x0010EFEC File Offset: 0x0010D1EC
	[Token(Token = "0x6003313")]
	[Address(RVA = "0x70A160", Offset = "0x708760", VA = "0x18070A160")]
	public static void MelonPotEffect(Plant melon, int theColumn, int theRow)
	{
		ulong num3;
		do
		{
			int num = 0;
			List<Plant> plants = Board.Instance.gridSystem.GetGrid(theColumn, theRow).plants;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
				melon.melonSputter = true;
			}
		}
		while (num3 != (ulong)0L);
	}

	// Token: 0x06003314 RID: 13076 RVA: 0x0010F048 File Offset: 0x0010D248
	[Token(Token = "0x6003314")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public PotEffects()
	{
	}
}
