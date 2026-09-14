using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200053B RID: 1339
[Token(Token = "0x200053B")]
public class MoneyCabbage : Cabbage
{
	// Token: 0x060018E8 RID: 6376 RVA: 0x00086F64 File Offset: 0x00085164
	[Token(Token = "0x60018E8")]
	[Address(RVA = "0x4D6130", Offset = "0x4D4730", VA = "0x1804D6130", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_pea;
	}

	// Token: 0x060018E9 RID: 6377 RVA: 0x00086F7C File Offset: 0x0008517C
	[Token(Token = "0x60018E9")]
	[Address(RVA = "0x4D5FB0", Offset = "0x4D45B0", VA = "0x1804D5FB0", Slot = "42")]
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

	// Token: 0x060018EA RID: 6378 RVA: 0x00086FC8 File Offset: 0x000851C8
	[Token(Token = "0x60018EA")]
	[Address(RVA = "0x4D6150", Offset = "0x4D4750", VA = "0x1804D6150", Slot = "76")]
	protected override Bullet ShootZombie(Zombie zombie)
	{
		return base.ShootZombie(zombie);
	}

	// Token: 0x060018EB RID: 6379 RVA: 0x00086FE4 File Offset: 0x000851E4
	[Token(Token = "0x60018EB")]
	[Address(RVA = "0x47E9D0", Offset = "0x47CFD0", VA = "0x18047E9D0")]
	public MoneyCabbage()
	{
	}
}
