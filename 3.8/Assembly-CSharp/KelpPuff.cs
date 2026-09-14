using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000524 RID: 1316
[Token(Token = "0x2000524")]
public class KelpPuff : Plant
{
	// Token: 0x0600187B RID: 6267 RVA: 0x000850B4 File Offset: 0x000832B4
	[Token(Token = "0x600187B")]
	[Address(RVA = "0x4D11C0", Offset = "0x4CF7C0", VA = "0x1804D11C0", Slot = "17")]
	protected override void FixedUpdate()
	{
		int num = 0;
		base.FixedUpdate();
		if (base.Active)
		{
			Transform axis = this.axis;
			int num2 = this.zombieLayer;
			Collider2D[] array;
			if (num < array.Length)
			{
				bool flag;
				if (flag)
				{
					int thePlantRow = this.thePlantRow;
					if (Lawnf.ThrowLandStatus((ZombieStatus)num))
					{
						goto IL_0048;
					}
				}
				num++;
				IL_0048:
				this.anim.SetTrigger("shoot");
			}
		}
	}

	// Token: 0x0600187C RID: 6268 RVA: 0x00085120 File Offset: 0x00083320
	[Token(Token = "0x600187C")]
	[Address(RVA = "0x4D0EE0", Offset = "0x4CF4E0", VA = "0x1804D0EE0")]
	private void AnimExplode()
	{
		int num = 0;
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		float num2 = global::UnityEngine.Random.Range(-0.1f, 0.1f);
		Transform shoot2 = this.shoot;
		float num3 = global::UnityEngine.Random.Range(-0.1f, 0.1f);
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		float num4;
		bullet.Vx = num4;
		float num5 = global::UnityEngine.Random.Range(num4, 3f);
		num++;
		bullet.Vy = num5;
		bullet.detaVy = 10f;
		Transform shoot3 = this.shoot;
		ParticleManager instance2 = ParticleManager.Instance;
		int num6 = 0;
		int thePlantRow = this.thePlantRow;
		int num7 = 0;
		ulong num8;
		Particle particle = instance2.SetParticle((ParticleType)((uint)108), num6, thePlantRow, num8 != 0UL, (float)num7);
		GameAPP.PlaySound(75, 0.5f, 1f);
		throw new NullReferenceException();
	}

	// Token: 0x0600187D RID: 6269 RVA: 0x000851F0 File Offset: 0x000833F0
	[Token(Token = "0x600187D")]
	[Address(RVA = "0x4D1360", Offset = "0x4CF960", VA = "0x1804D1360", Slot = "36")]
	protected override bool OnCrash()
	{
		this.AnimExplode();
		return true;
	}

	// Token: 0x0600187E RID: 6270 RVA: 0x00085204 File Offset: 0x00083404
	[Token(Token = "0x600187E")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public KelpPuff()
	{
	}
}
