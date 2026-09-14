using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020000E2 RID: 226
[Token(Token = "0x20000E2")]
public static class Leader_UlitmateChomper
{
	// Token: 0x06000452 RID: 1106 RVA: 0x00016230 File Offset: 0x00014430
	[Token(Token = "0x6000452")]
	[Address(RVA = "0x5AD430", Offset = "0x5ABA30", VA = "0x1805AD430")]
	public static void UpdateLeaderBonus(int theColumn, int theRow)
	{
		int num2;
		do
		{
			if (theColumn > 4)
			{
				List<Plant> list = Lawnf.Get1x1Plants(theColumn, theRow);
				int num = 0;
				bool flag;
				if (flag)
				{
				}
				if (num != 0)
				{
					goto IL_0040;
				}
			}
			List<Plant> list2 = Lawnf.Get1x1Plants(theColumn, theRow);
			num2 = 0;
			bool flag2;
			if (flag2)
			{
			}
		}
		while (num2 != 0);
		return;
		IL_0040:
		throw new NullReferenceException();
	}
}
