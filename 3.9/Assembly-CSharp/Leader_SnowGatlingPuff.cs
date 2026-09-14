using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020000E8 RID: 232
[Token(Token = "0x20000E8")]
public static class Leader_SnowGatlingPuff
{
	// Token: 0x0600046E RID: 1134 RVA: 0x00016720 File Offset: 0x00014920
	[Token(Token = "0x600046E")]
	[Address(RVA = "0x5E2C80", Offset = "0x5E1280", VA = "0x1805E2C80")]
	public static void UpdateLeaderBonus(int theColumn, int theRow)
	{
		int num2;
		do
		{
			List<Plant> list = Lawnf.Get1x1Plants(theColumn, theRow);
			int num = 0;
			bool flag;
			if (flag)
			{
			}
			if (num != 0)
			{
				goto IL_0036;
			}
			num2 = 0;
			bool flag2;
			if (flag2)
			{
			}
		}
		while (num2 != 0);
		return;
		IL_0036:
		throw new NullReferenceException();
	}
}
