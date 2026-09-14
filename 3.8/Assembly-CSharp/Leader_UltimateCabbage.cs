using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020000E4 RID: 228
[Token(Token = "0x20000E4")]
public static class Leader_UltimateCabbage
{
	// Token: 0x06000454 RID: 1108 RVA: 0x000162D0 File Offset: 0x000144D0
	[Token(Token = "0x6000454")]
	[Address(RVA = "0x5AD680", Offset = "0x5ABC80", VA = "0x1805AD680")]
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

	// Token: 0x06000455 RID: 1109 RVA: 0x00016314 File Offset: 0x00014514
	[Token(Token = "0x6000455")]
	[Address(RVA = "0x5AD6E0", Offset = "0x5ABCE0", VA = "0x1805AD6E0")]
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
