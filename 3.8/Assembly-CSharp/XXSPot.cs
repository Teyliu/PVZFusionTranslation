using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200049F RID: 1183
[Token(Token = "0x200049F")]
public class XXSPot : Pot
{
	// Token: 0x06001629 RID: 5673 RVA: 0x0007AC34 File Offset: 0x00078E34
	[Token(Token = "0x6001629")]
	[Address(RVA = "0x4AE090", Offset = "0x4AC690", VA = "0x1804AE090", Slot = "55")]
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

	// Token: 0x0600162A RID: 5674 RVA: 0x0007AC64 File Offset: 0x00078E64
	[Token(Token = "0x600162A")]
	[Address(RVA = "0x4AE1E0", Offset = "0x4AC7E0", VA = "0x1804AE1E0", Slot = "54")]
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

	// Token: 0x0600162B RID: 5675 RVA: 0x0007ACB0 File Offset: 0x00078EB0
	[Token(Token = "0x600162B")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public XXSPot()
	{
	}
}
