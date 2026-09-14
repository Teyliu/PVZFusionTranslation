using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001D7 RID: 471
[Token(Token = "0x20001D7")]
public class Bullet_watercan : Bullet
{
	// Token: 0x06000800 RID: 2048 RVA: 0x00028914 File Offset: 0x00026B14
	[Token(Token = "0x6000800")]
	[Address(RVA = "0x8E1B80", Offset = "0x8E0180", VA = "0x1808E1B80", Slot = "22")]
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

	// Token: 0x06000801 RID: 2049 RVA: 0x0002898C File Offset: 0x00026B8C
	[Token(Token = "0x6000801")]
	[Address(RVA = "0x8E1AC0", Offset = "0x8E00C0", VA = "0x1808E1AC0", Slot = "17")]
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

	// Token: 0x06000802 RID: 2050 RVA: 0x000289D4 File Offset: 0x00026BD4
	[Token(Token = "0x6000802")]
	[Address(RVA = "0x8E1CB0", Offset = "0x8E02B0", VA = "0x1808E1CB0")]
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

	// Token: 0x06000803 RID: 2051 RVA: 0x00028A74 File Offset: 0x00026C74
	[Token(Token = "0x6000803")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_watercan()
	{
	}
}
