using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020000E9 RID: 233
[Token(Token = "0x20000E9")]
public static class Leader_UltimateCabbage
{
	// Token: 0x0600046F RID: 1135 RVA: 0x0001676C File Offset: 0x0001496C
	[Token(Token = "0x600046F")]
	[Address(RVA = "0x5E3110", Offset = "0x5E1710", VA = "0x1805E3110")]
	public static void UpdateLeaderBonus(int theColumn, int theRow)
	{
		Leader_UltimateCabbage.UpdateSingleBox(theColumn, theRow);
		int num = theColumn + 1;
		Leader_UltimateCabbage.UpdateSingleBox(num, theRow);
		Leader_UltimateCabbage.UpdateSingleBox(theColumn, theRow);
		int num2 = theRow - 1;
		Leader_UltimateCabbage.UpdateSingleBox(theColumn, num2);
		int num3 = theRow + 1;
		Leader_UltimateCabbage.UpdateSingleBox(theColumn, num3);
	}

	// Token: 0x06000470 RID: 1136 RVA: 0x000167B0 File Offset: 0x000149B0
	[Token(Token = "0x6000470")]
	[Address(RVA = "0x5E3170", Offset = "0x5E1770", VA = "0x1805E3170")]
	private static void UpdateSingleBox(int theColumn, int theRow)
	{
		int num5;
		do
		{
			int num = theRow - 1;
			List<Plant> list = Lawnf.Get1x1Plants(theColumn, num);
			int num2 = theRow + 1;
			List<Plant> list2 = Lawnf.Get1x1Plants(theColumn, num2);
			int num3 = theColumn - 1;
			List<Plant> list3 = Lawnf.Get1x1Plants(num3, theRow);
			int num4 = theColumn + 1;
			List<Plant> list4 = Lawnf.Get1x1Plants(num4, theRow);
			List<Plant> list5 = Lawnf.Get1x1Plants(theColumn, theRow);
			num5 = 0;
			bool flag;
			if (flag)
			{
			}
		}
		while (num5 != 0);
	}
}
