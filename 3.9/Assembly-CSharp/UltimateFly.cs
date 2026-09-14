using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200048B RID: 1163
[Token(Token = "0x200048B")]
public class UltimateFly : CactusBlover
{
	// Token: 0x0600157E RID: 5502 RVA: 0x000768C0 File Offset: 0x00074AC0
	[Token(Token = "0x600157E")]
	[Address(RVA = "0x4DD070", Offset = "0x4DB670", VA = "0x1804DD070", Slot = "68")]
	protected override Bullet Shoot1()
	{
		ulong num4;
		do
		{
			int num = 0;
			List<Zombie> list = new List();
			List<Zombie> zombieArray = Board.Instance.zombieArray;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
				int thePlantRow = this.thePlantRow;
			}
			ulong num3;
			if (num3 != (ulong)0L)
			{
				goto IL_0063;
			}
			if (Lawnf.TravelUltimate((UltiBuff)((uint)25)))
			{
			}
			bool flag2;
			if (flag2)
			{
			}
		}
		while (num4 != (ulong)0L);
		throw new NullReferenceException();
		IL_0063:
		throw new NullReferenceException();
	}

	// Token: 0x0600157F RID: 5503 RVA: 0x00076938 File Offset: 0x00074B38
	[Token(Token = "0x600157F")]
	[Address(RVA = "0x469910", Offset = "0x467F10", VA = "0x180469910")]
	public UltimateFly()
	{
	}
}
