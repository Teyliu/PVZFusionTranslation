using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Unity.VisualScripting;

// Token: 0x0200038F RID: 911
[Token(Token = "0x200038F")]
public class GarlicBlover : Blover
{
	// Token: 0x060010BE RID: 4286 RVA: 0x0005FBCC File Offset: 0x0005DDCC
	[Token(Token = "0x60010BE")]
	[Address(RVA = "0x4368C0", Offset = "0x434EC0", VA = "0x1804368C0", Slot = "70")]
	protected override void BlowZombie()
	{
		ulong num3;
		do
		{
			int num = 0;
			List<Zombie> allZombies = Lawnf.GetAllZombies(false);
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
				Blow blow = num.AddComponent<Blow>();
			}
		}
		while (num3 != (ulong)0L);
	}

	// Token: 0x060010BF RID: 4287 RVA: 0x0005FC10 File Offset: 0x0005DE10
	[Token(Token = "0x60010BF")]
	[Address(RVA = "0x436B00", Offset = "0x435100", VA = "0x180436B00", Slot = "64")]
	public override bool OnEat(Zombie zombie)
	{
		zombie.EatGarlic(this, 1f, true);
		return true;
	}

	// Token: 0x060010C0 RID: 4288 RVA: 0x0005FC34 File Offset: 0x0005DE34
	[Token(Token = "0x60010C0")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public GarlicBlover()
	{
	}
}
