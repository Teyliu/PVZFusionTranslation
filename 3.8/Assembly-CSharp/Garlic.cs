using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200038E RID: 910
[Token(Token = "0x200038E")]
public class Garlic : WallNut
{
	// Token: 0x060010BB RID: 4283 RVA: 0x0005FB58 File Offset: 0x0005DD58
	[Token(Token = "0x60010BB")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "69")]
	protected override void OnTriggerStay2D(Collider2D collision)
	{
	}

	// Token: 0x060010BC RID: 4284 RVA: 0x0005FB68 File Offset: 0x0005DD68
	[Token(Token = "0x60010BC")]
	[Address(RVA = "0x436EE0", Offset = "0x4354E0", VA = "0x180436EE0", Slot = "42")]
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

	// Token: 0x060010BD RID: 4285 RVA: 0x0005FBB8 File Offset: 0x0005DDB8
	[Token(Token = "0x60010BD")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public Garlic()
	{
	}
}
