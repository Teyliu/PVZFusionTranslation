using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020000E3 RID: 227
[Token(Token = "0x20000E3")]
public static class Leader_SnowGatlingPuff
{
	// Token: 0x06000453 RID: 1107 RVA: 0x00016284 File Offset: 0x00014484
	[Token(Token = "0x6000453")]
	[Address(RVA = "0x5AD1F0", Offset = "0x5AB7F0", VA = "0x1805AD1F0")]
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
