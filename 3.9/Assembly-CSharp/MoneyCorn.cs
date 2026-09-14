using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000569 RID: 1385
[Token(Token = "0x2000569")]
public class MoneyCorn : Cornpult
{
	// Token: 0x060019BC RID: 6588 RVA: 0x0008ACB0 File Offset: 0x00088EB0
	[Token(Token = "0x60019BC")]
	[Address(RVA = "0x536BB0", Offset = "0x5351B0", VA = "0x180536BB0", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_pea;
	}

	// Token: 0x060019BD RID: 6589 RVA: 0x0008ACC8 File Offset: 0x00088EC8
	[Token(Token = "0x60019BD")]
	[Address(RVA = "0x536B90", Offset = "0x535190", VA = "0x180536B90", Slot = "78")]
	protected override BulletType GetBulletType2()
	{
		return BulletType.Bullet_pea;
	}

	// Token: 0x060019BE RID: 6590 RVA: 0x0008ACE0 File Offset: 0x00088EE0
	[Token(Token = "0x60019BE")]
	[Address(RVA = "0x536B10", Offset = "0x535110", VA = "0x180536B10", Slot = "41")]
	protected override void AnimSuperShoot()
	{
		Zombie nearestZombie = this.GetNearestZombie();
		int num = 0;
		if (nearestZombie != num)
		{
			Bullet bullet = this.ShootZombie(nearestZombie);
		}
	}

	// Token: 0x060019BF RID: 6591 RVA: 0x0008AD08 File Offset: 0x00088F08
	[Token(Token = "0x60019BF")]
	[Address(RVA = "0x537060", Offset = "0x535660", VA = "0x180537060", Slot = "75")]
	protected override Bullet ShootZombie(Zombie zombie)
	{
		uint num;
		Transform child = base.transform.GetChild((int)num);
		int num2 = 0;
		CreateBullet instance = CreateBullet.Instance;
		Vector2 velocity = zombie.Velocity;
		int num3 = 0;
		Vector2 colliderPosition = zombie.ColliderPosition;
		float flightTime = this.flightTime;
		Bullet bullet;
		bullet.SetSpeed(num3, num2, colliderPosition, flightTime);
		int num4 = this.attackDamage;
		num4 -= num3;
		long num5 = (long)(num4 * (int)((uint)15));
		bullet.Damage = (int)num5;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		bullet.melonSputter = true;
		base.UniqueEffect(bullet);
		return bullet;
	}

	// Token: 0x060019C0 RID: 6592 RVA: 0x0008ADA0 File Offset: 0x00088FA0
	[Token(Token = "0x60019C0")]
	[Address(RVA = "0x536BD0", Offset = "0x5351D0", VA = "0x180536BD0")]
	private Zombie GetNearestZombie()
	{
		ulong num6;
		do
		{
			int num = 0;
			int num2 = 0;
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3))
				{
					continue;
				}
				float vision = this.vision;
				int thePlantRow = this.thePlantRow;
				if (!Thrower.ThrowSearchZombie(num))
				{
					continue;
				}
				Transform axis = this.axis;
			}
			if (num2 != 0)
			{
				goto IL_00A2;
			}
			int num4 = 0;
			if (!(num2 == num4))
			{
				break;
			}
			bool flag2;
			if (flag2)
			{
				int num5 = 0;
				if (!(num != num5) || !Thrower.ThrowSearchZombie(num))
				{
					continue;
				}
			}
		}
		while (num6 != (ulong)0L);
		throw new NullReferenceException();
		IL_00A2:
		throw new NullReferenceException();
	}

	// Token: 0x060019C1 RID: 6593 RVA: 0x0008AE68 File Offset: 0x00089068
	[Token(Token = "0x60019C1")]
	[Address(RVA = "0x4D6B50", Offset = "0x4D5150", VA = "0x1804D6B50")]
	public MoneyCorn()
	{
	}
}
