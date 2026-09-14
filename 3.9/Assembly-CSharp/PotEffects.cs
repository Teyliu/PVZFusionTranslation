using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020009F5 RID: 2549
[Token(Token = "0x20009F5")]
public class PotEffects
{
	// Token: 0x06003445 RID: 13381 RVA: 0x00113F10 File Offset: 0x00112110
	[Token(Token = "0x6003445")]
	[Address(RVA = "0x76F1E0", Offset = "0x76D7E0", VA = "0x18076F1E0")]
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

	// Token: 0x06003446 RID: 13382 RVA: 0x00113F6C File Offset: 0x0011216C
	[Token(Token = "0x6003446")]
	[Address(RVA = "0x76F400", Offset = "0x76DA00", VA = "0x18076F400")]
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

	// Token: 0x06003447 RID: 13383 RVA: 0x00113FFC File Offset: 0x001121FC
	[Token(Token = "0x6003447")]
	[Address(RVA = "0x76F680", Offset = "0x76DC80", VA = "0x18076F680")]
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

	// Token: 0x06003448 RID: 13384 RVA: 0x00114058 File Offset: 0x00112258
	[Token(Token = "0x6003448")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public PotEffects()
	{
	}
}
