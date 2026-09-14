using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020004C1 RID: 1217
[Token(Token = "0x20004C1")]
public class XXSPot : Pot
{
	// Token: 0x060016C9 RID: 5833 RVA: 0x0007D6B0 File Offset: 0x0007B8B0
	[Token(Token = "0x60016C9")]
	[Address(RVA = "0x51C860", Offset = "0x51AE60", VA = "0x18051C860", Slot = "54")]
	public override void OnCreate(int theColumn, int theRow)
	{
		int num;
		do
		{
			List<Plant> list = Lawnf.Get1x1Plants(theColumn, theColumn);
			num = 0;
			bool flag;
			if (flag)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x060016CA RID: 5834 RVA: 0x0007D6E0 File Offset: 0x0007B8E0
	[Token(Token = "0x60016CA")]
	[Address(RVA = "0x51C9B0", Offset = "0x51AFB0", VA = "0x18051C9B0", Slot = "53")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
		int num2;
		do
		{
			List<Plant> list = Lawnf.Get1x1Plants(originalColumn, originalColumn);
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

	// Token: 0x060016CB RID: 5835 RVA: 0x0007D72C File Offset: 0x0007B92C
	[Token(Token = "0x60016CB")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public XXSPot()
	{
	}
}
