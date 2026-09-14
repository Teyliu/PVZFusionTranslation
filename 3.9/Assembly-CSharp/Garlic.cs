using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003A1 RID: 929
[Token(Token = "0x20003A1")]
public class Garlic : WallNut
{
	// Token: 0x06001115 RID: 4373 RVA: 0x000610A4 File Offset: 0x0005F2A4
	[Token(Token = "0x6001115")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "68")]
	protected override void OnTriggerStay2D(Collider2D collision)
	{
	}

	// Token: 0x06001116 RID: 4374 RVA: 0x000610B4 File Offset: 0x0005F2B4
	[Token(Token = "0x6001116")]
	[Address(RVA = "0x48A7C0", Offset = "0x488DC0", VA = "0x18048A7C0", Slot = "41")]
	protected override void AnimSuperShoot()
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
				if (!base.SearchUniqueZombie(num))
				{
					continue;
				}
			}
		}
		while (num3 != (ulong)0L);
	}

	// Token: 0x06001117 RID: 4375 RVA: 0x00061104 File Offset: 0x0005F304
	[Token(Token = "0x6001117")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public Garlic()
	{
	}
}
