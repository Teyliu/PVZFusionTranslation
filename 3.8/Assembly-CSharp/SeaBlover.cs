using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Unity.VisualScripting;

// Token: 0x02000413 RID: 1043
[Token(Token = "0x2000413")]
public class SeaBlover : Blover
{
	// Token: 0x06001345 RID: 4933 RVA: 0x0006C8D4 File Offset: 0x0006AAD4
	[Token(Token = "0x6001345")]
	[Address(RVA = "0x464640", Offset = "0x462C40", VA = "0x180464640", Slot = "70")]
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

	// Token: 0x06001346 RID: 4934 RVA: 0x0006C924 File Offset: 0x0006AB24
	[Token(Token = "0x6001346")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public SeaBlover()
	{
	}
}
