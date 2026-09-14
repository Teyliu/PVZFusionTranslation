using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000568 RID: 1384
[Token(Token = "0x2000568")]
public class MoneyCabbage : Cabbage
{
	// Token: 0x060019B8 RID: 6584 RVA: 0x0008AC1C File Offset: 0x00088E1C
	[Token(Token = "0x60019B8")]
	[Address(RVA = "0x536A40", Offset = "0x535040", VA = "0x180536A40", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_pea;
	}

	// Token: 0x060019B9 RID: 6585 RVA: 0x0008AC34 File Offset: 0x00088E34
	[Token(Token = "0x60019B9")]
	[Address(RVA = "0x5368C0", Offset = "0x534EC0", VA = "0x1805368C0", Slot = "41")]
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
				if (!(num != num2) || !Thrower.ThrowSearchZombie(num))
				{
					continue;
				}
				Bullet bullet = this.ShootZombie(num);
			}
		}
		while (num3 != (ulong)0L);
	}

	// Token: 0x060019BA RID: 6586 RVA: 0x0008AC80 File Offset: 0x00088E80
	[Token(Token = "0x60019BA")]
	[Address(RVA = "0x536A60", Offset = "0x535060", VA = "0x180536A60", Slot = "75")]
	protected override Bullet ShootZombie(Zombie zombie)
	{
		return base.ShootZombie(zombie);
	}

	// Token: 0x060019BB RID: 6587 RVA: 0x0008AC9C File Offset: 0x00088E9C
	[Token(Token = "0x60019BB")]
	[Address(RVA = "0x4D6B50", Offset = "0x4D5150", VA = "0x1804D6B50")]
	public MoneyCabbage()
	{
	}
}
