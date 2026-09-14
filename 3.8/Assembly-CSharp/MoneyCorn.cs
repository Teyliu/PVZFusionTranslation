using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200053C RID: 1340
[Token(Token = "0x200053C")]
public class MoneyCorn : Cornpult
{
	// Token: 0x060018EC RID: 6380 RVA: 0x00086FF8 File Offset: 0x000851F8
	[Token(Token = "0x60018EC")]
	[Address(RVA = "0x4D62A0", Offset = "0x4D48A0", VA = "0x1804D62A0", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_pea;
	}

	// Token: 0x060018ED RID: 6381 RVA: 0x00087010 File Offset: 0x00085210
	[Token(Token = "0x60018ED")]
	[Address(RVA = "0x4D6280", Offset = "0x4D4880", VA = "0x1804D6280", Slot = "79")]
	protected override BulletType GetBulletType2()
	{
		return BulletType.Bullet_pea;
	}

	// Token: 0x060018EE RID: 6382 RVA: 0x00087028 File Offset: 0x00085228
	[Token(Token = "0x60018EE")]
	[Address(RVA = "0x4D6200", Offset = "0x4D4800", VA = "0x1804D6200", Slot = "42")]
	protected override void AnimSuperShoot()
	{
		Zombie nearestZombie = this.GetNearestZombie();
		int num = 0;
		if (nearestZombie != num)
		{
			Bullet bullet = this.ShootZombie(nearestZombie);
		}
	}

	// Token: 0x060018EF RID: 6383 RVA: 0x00087050 File Offset: 0x00085250
	[Token(Token = "0x60018EF")]
	[Address(RVA = "0x4D6750", Offset = "0x4D4D50", VA = "0x1804D6750", Slot = "76")]
	protected override Bullet ShootZombie(Zombie zombie)
	{
		uint num;
		Transform child = base.transform.GetChild((int)num);
		Vector2 velocity = zombie.Velocity;
		Vector2 colliderPosition = zombie.ColliderPosition;
		CreateBullet instance = CreateBullet.Instance;
		float[] array;
		float num2 = array[0];
		Bullet bullet;
		bullet.Vx = num2;
		float num3 = array[1];
		bullet.Vy = num3;
		float num4 = array[1];
		bullet.detaVy = num4;
		long num5 = (long)(this.attackDamage * (int)((uint)15));
		bullet.Damage = (int)num5;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		bullet.melonSputter = true;
		base.UniqueEffect(bullet);
		return bullet;
	}

	// Token: 0x060018F0 RID: 6384 RVA: 0x000870FC File Offset: 0x000852FC
	[Token(Token = "0x60018F0")]
	[Address(RVA = "0x4D62C0", Offset = "0x4D48C0", VA = "0x1804D62C0")]
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

	// Token: 0x060018F1 RID: 6385 RVA: 0x000871C4 File Offset: 0x000853C4
	[Token(Token = "0x60018F1")]
	[Address(RVA = "0x47E9D0", Offset = "0x47CFD0", VA = "0x18047E9D0")]
	public MoneyCorn()
	{
	}
}
