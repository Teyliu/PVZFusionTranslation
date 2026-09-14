using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001CD RID: 461
[Token(Token = "0x20001CD")]
public class Bullet_watercan : Bullet
{
	// Token: 0x060007EA RID: 2026 RVA: 0x00028D54 File Offset: 0x00026F54
	[Token(Token = "0x60007EA")]
	[Address(RVA = "0x7EB330", Offset = "0x7E9930", VA = "0x1807EB330", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theBulletRow = this.theBulletRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)116), num, theBulletRow, num3 != 0UL, (float)num2);
		base.PlaySound(zombie);
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num4;
		zombie.TakeDamage(damage, this, (DamageType)((uint)4), fromType, num4 != 0UL);
		if (!this.SearchCan())
		{
			base.Die();
		}
	}

	// Token: 0x060007EB RID: 2027 RVA: 0x00028DCC File Offset: 0x00026FCC
	[Token(Token = "0x60007EB")]
	[Address(RVA = "0x7EB270", Offset = "0x7E9870", VA = "0x1807EB270", Slot = "18")]
	public override void HitLand()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theBulletRow = this.theBulletRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)116), num, theBulletRow, num3 != 0UL, (float)num2);
		base.HitLand();
	}

	// Token: 0x060007EC RID: 2028 RVA: 0x00028E14 File Offset: 0x00027014
	[Token(Token = "0x60007EC")]
	[Address(RVA = "0x7EB460", Offset = "0x7E9A60", VA = "0x1807EB460")]
	private bool SearchCan()
	{
		List<Tower_waterCan> list;
		int num4;
		do
		{
			int num = 0;
			Transform transform = base.transform;
			int theBulletRow = this.theBulletRow;
			int num2;
			uint num3;
			List<Plant> rangePlants = Lawnf.GetRangePlants(num2, theBulletRow, (int)num3);
			list = new List();
			num4 = 0;
			bool flag;
			if (flag)
			{
				while (num == 0)
				{
				}
				while (num == 0)
				{
				}
				Plant from = this.from;
				if (!(num != from))
				{
					continue;
				}
			}
		}
		while (num4 != 0);
		Func<Tower_waterCan, int> func;
		if (Bullet_watercan.<>c.<>9__2_0 == 0)
		{
			Bullet_watercan.<>c.<>9__2_0 = func;
		}
		Tower_waterCan tower_waterCan = Enumerable.FirstOrDefault<Tower_waterCan>(Enumerable.OrderBy<Tower_waterCan, int>(list, func));
		Vector3 vector;
		float z = vector.z;
		Transform shoot = tower_waterCan.shoot;
		throw new NullReferenceException();
	}

	// Token: 0x060007ED RID: 2029 RVA: 0x00028EB4 File Offset: 0x000270B4
	[Token(Token = "0x60007ED")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_watercan()
	{
	}
}
