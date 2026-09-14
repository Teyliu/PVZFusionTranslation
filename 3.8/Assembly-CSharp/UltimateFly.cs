using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200046B RID: 1131
[Token(Token = "0x200046B")]
public class UltimateFly : CactusBlover
{
	// Token: 0x060014EB RID: 5355 RVA: 0x000743BC File Offset: 0x000725BC
	[Token(Token = "0x60014EB")]
	[Address(RVA = "0x480700", Offset = "0x47ED00", VA = "0x180480700", Slot = "69")]
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

	// Token: 0x060014EC RID: 5356 RVA: 0x00074434 File Offset: 0x00072634
	[Token(Token = "0x60014EC")]
	[Address(RVA = "0x429630", Offset = "0x427C30", VA = "0x180429630")]
	public UltimateFly()
	{
	}
}
