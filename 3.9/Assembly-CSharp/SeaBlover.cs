using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Unity.VisualScripting;

// Token: 0x0200042E RID: 1070
[Token(Token = "0x200042E")]
public class SeaBlover : Blover
{
	// Token: 0x060013BB RID: 5051 RVA: 0x0006E764 File Offset: 0x0006C964
	[Token(Token = "0x60013BB")]
	[Address(RVA = "0x4BAD50", Offset = "0x4B9350", VA = "0x1804BAD50", Slot = "69")]
	protected override void BlowZombie()
	{
		ulong num3;
		do
		{
			int num = 0;
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
				int thePlantRow = this.thePlantRow;
				Blow blow = num.AddComponent<Blow>();
			}
		}
		while (num3 != (ulong)0L);
	}

	// Token: 0x060013BC RID: 5052 RVA: 0x0006E7B4 File Offset: 0x0006C9B4
	[Token(Token = "0x60013BC")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public SeaBlover()
	{
	}
}
