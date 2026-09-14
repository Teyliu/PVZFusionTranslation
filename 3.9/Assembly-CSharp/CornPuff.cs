using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000502 RID: 1282
[Token(Token = "0x2000502")]
public class CornPuff : Cornpult
{
	// Token: 0x06001816 RID: 6166 RVA: 0x000835C0 File Offset: 0x000817C0
	[Token(Token = "0x6001816")]
	[Address(RVA = "0x51FF00", Offset = "0x51E500", VA = "0x18051FF00", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_smallKernal;
	}

	// Token: 0x06001817 RID: 6167 RVA: 0x000835D0 File Offset: 0x000817D0
	[Token(Token = "0x6001817")]
	[Address(RVA = "0x51FEF0", Offset = "0x51E4F0", VA = "0x18051FEF0", Slot = "78")]
	protected override BulletType GetBulletType2()
	{
		return BulletType.Bullet_smallButter;
	}

	// Token: 0x06001818 RID: 6168 RVA: 0x000835E0 File Offset: 0x000817E0
	[Token(Token = "0x6001818")]
	[Address(RVA = "0x51FF10", Offset = "0x51E510", VA = "0x18051FF10", Slot = "74")]
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

	// Token: 0x06001819 RID: 6169 RVA: 0x00083680 File Offset: 0x00081880
	[Token(Token = "0x6001819")]
	[Address(RVA = "0x474940", Offset = "0x472F40", VA = "0x180474940")]
	public CornPuff()
	{
	}
}
