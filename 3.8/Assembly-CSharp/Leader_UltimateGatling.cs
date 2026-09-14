using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

// Token: 0x020000E0 RID: 224
[Token(Token = "0x20000E0")]
public static class Leader_UltimateGatling
{
	// Token: 0x0600044D RID: 1101 RVA: 0x00016158 File Offset: 0x00014358
	[Token(Token = "0x600044D")]
	[Address(RVA = "0x5ADA50", Offset = "0x5AC050", VA = "0x1805ADA50")]
	public static void UpdateLeaderBonus(int theColumn, int theRow)
	{
		int num;
		do
		{
			List<Plant> list = Lawnf.Get3x3Plants(theColumn, theRow);
			num = 0;
			bool flag;
			if (flag)
			{
				Func<Plant, bool> <>9__1_ = Leader_UltimateGatling.<>c.<>9__1_0;
				if (<>9__1_ == 0)
				{
					Func<Plant, bool> func;
					Leader_UltimateGatling.<>c.<>9__1_0 = func;
				}
				List<Plant> list2;
				if (Enumerable.Count<Plant>(list2, <>9__1_) != 0)
				{
				}
			}
		}
		while (num != 0);
	}

	// Token: 0x0600044E RID: 1102 RVA: 0x000161A4 File Offset: 0x000143A4
	[Token(Token = "0x600044E")]
	[Address(RVA = "0x5AD920", Offset = "0x5ABF20", VA = "0x1805AD920")]
	private static int CountNearbyGatlings(int theColumn, int theRow)
	{
		List<Plant> list = Lawnf.Get3x3Plants(theColumn, theRow);
		Func<Plant, bool> <>9__1_ = Leader_UltimateGatling.<>c.<>9__1_0;
		if (<>9__1_ == 0)
		{
			Func<Plant, bool> func;
			Leader_UltimateGatling.<>c.<>9__1_0 = func;
		}
		return Enumerable.Count<Plant>(list, <>9__1_);
	}
}
