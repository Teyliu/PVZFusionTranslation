using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Unity.VisualScripting;

// Token: 0x020003A2 RID: 930
[Token(Token = "0x20003A2")]
public class GarlicBlover : Blover
{
	// Token: 0x06001118 RID: 4376 RVA: 0x00061118 File Offset: 0x0005F318
	[Token(Token = "0x6001118")]
	[Address(RVA = "0x48A1A0", Offset = "0x4887A0", VA = "0x18048A1A0", Slot = "69")]
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

	// Token: 0x06001119 RID: 4377 RVA: 0x0006115C File Offset: 0x0005F35C
	[Token(Token = "0x6001119")]
	[Address(RVA = "0x48A3E0", Offset = "0x4889E0", VA = "0x18048A3E0", Slot = "63")]
	public override bool OnEat(Zombie zombie)
	{
		zombie.EatGarlic(this, 1f, true);
		return true;
	}

	// Token: 0x0600111A RID: 4378 RVA: 0x00061180 File Offset: 0x0005F380
	[Token(Token = "0x600111A")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public GarlicBlover()
	{
	}
}
