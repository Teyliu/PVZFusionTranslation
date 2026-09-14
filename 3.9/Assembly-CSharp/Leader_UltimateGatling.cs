using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

// Token: 0x020000E5 RID: 229
[Token(Token = "0x20000E5")]
public static class Leader_UltimateGatling
{
	// Token: 0x06000468 RID: 1128 RVA: 0x000165D4 File Offset: 0x000147D4
	[Token(Token = "0x6000468")]
	[Address(RVA = "0x5E34E0", Offset = "0x5E1AE0", VA = "0x1805E34E0")]
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
					Leader_UltimateGatling.<>c.<>9__1_0 = delegate(Plant item)
					{
						int num2 = 0;
						bool flag2 = item != num2;
						if (!flag2)
						{
							return flag2;
						}
						return item.thePlantType == PlantType.UltimateGatling;
					};
				}
				List<Plant> list2;
				if (Enumerable.Count<Plant>(list2, <>9__1_) != 0)
				{
				}
			}
		}
		while (num != 0);
	}

	// Token: 0x06000469 RID: 1129 RVA: 0x00016630 File Offset: 0x00014830
	[Token(Token = "0x6000469")]
	[Address(RVA = "0x5E33B0", Offset = "0x5E19B0", VA = "0x1805E33B0")]
	private static int CountNearbyGatlings(int theColumn, int theRow)
	{
		List<Plant> list = Lawnf.Get3x3Plants(theColumn, theRow);
		Func<Plant, bool> <>9__1_ = Leader_UltimateGatling.<>c.<>9__1_0;
		if (<>9__1_ == 0)
		{
			Leader_UltimateGatling.<>c.<>9__1_0 = delegate(Plant item)
			{
				int num = 0;
				bool flag = item != num;
				if (!flag)
				{
					return flag;
				}
				return item.thePlantType == PlantType.UltimateGatling;
			};
		}
		return Enumerable.Count<Plant>(list, <>9__1_);
	}
}
