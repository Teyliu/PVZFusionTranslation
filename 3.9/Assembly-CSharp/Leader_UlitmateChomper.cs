using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020000E7 RID: 231
[Token(Token = "0x20000E7")]
public static class Leader_UlitmateChomper
{
	// Token: 0x0600046D RID: 1133 RVA: 0x000166CC File Offset: 0x000148CC
	[Token(Token = "0x600046D")]
	[Address(RVA = "0x5E2EC0", Offset = "0x5E14C0", VA = "0x1805E2EC0")]
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
