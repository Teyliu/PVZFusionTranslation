using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004DA RID: 1242
[Token(Token = "0x20004DA")]
public class CornPuff : Cornpult
{
	// Token: 0x0600175F RID: 5983 RVA: 0x00080340 File Offset: 0x0007E540
	[Token(Token = "0x600175F")]
	[Address(RVA = "0x4A0250", Offset = "0x49E850", VA = "0x1804A0250", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_smallKernal;
	}

	// Token: 0x06001760 RID: 5984 RVA: 0x00080350 File Offset: 0x0007E550
	[Token(Token = "0x6001760")]
	[Address(RVA = "0x4A0240", Offset = "0x49E840", VA = "0x1804A0240", Slot = "79")]
	protected override BulletType GetBulletType2()
	{
		return BulletType.Bullet_smallButter;
	}

	// Token: 0x06001761 RID: 5985 RVA: 0x00080360 File Offset: 0x0007E560
	[Token(Token = "0x6001761")]
	[Address(RVA = "0x4A0260", Offset = "0x49E860", VA = "0x1804A0260", Slot = "75")]
	protected override Zombie ThrowerSearchZombie()
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3))
				{
					continue;
				}
				int thePlantRow = this.thePlantRow;
				float vision = this.vision;
				if (!base.CheckRange(num) || !Thrower.ThrowSearchZombie(num))
				{
					continue;
				}
				Transform axis = this.axis;
			}
		}
		while (num2 != 0);
		int num4 = 0;
		bool flag2 = num2 != num4;
		this.targetZombie = num2;
		bool flag3;
		if (flag3)
		{
		}
		Zombie zombie;
		return zombie;
	}

	// Token: 0x06001762 RID: 5986 RVA: 0x00080400 File Offset: 0x0007E600
	[Token(Token = "0x6001762")]
	[Address(RVA = "0x41DAA0", Offset = "0x41C0A0", VA = "0x18041DAA0")]
	public CornPuff()
	{
	}
}
