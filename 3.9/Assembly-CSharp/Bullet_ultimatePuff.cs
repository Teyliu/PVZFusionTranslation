using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001D0 RID: 464
[Token(Token = "0x20001D0")]
public class Bullet_ultimatePuff : Bullet_ultimateMelon
{
	// Token: 0x060007E4 RID: 2020 RVA: 0x00027D84 File Offset: 0x00025F84
	[Token(Token = "0x60007E4")]
	[Address(RVA = "0x8169C0", Offset = "0x814FC0", VA = "0x1808169C0", Slot = "17")]
	public override void HitLand()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theBulletRow = this.theBulletRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)57), num, theBulletRow, num3 != 0UL, (float)num2);
		base.Die();
	}

	// Token: 0x060007E5 RID: 2021 RVA: 0x00027DD0 File Offset: 0x00025FD0
	[Token(Token = "0x60007E5")]
	[Address(RVA = "0x816AD0", Offset = "0x8150D0", VA = "0x180816AD0", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theBulletRow = this.theBulletRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)57), num, theBulletRow, num3 != 0UL, (float)num2);
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num4;
		zombie.TakeDamage(damage, this, (DamageType)((uint)4), fromType, num4 != 0UL);
		base.PlaySound(zombie);
		int theZombieRow = zombie.theZombieRow;
		base.Die();
	}

	// Token: 0x060007E6 RID: 2022 RVA: 0x00027E44 File Offset: 0x00026044
	[Token(Token = "0x60007E6")]
	[Address(RVA = "0x816C30", Offset = "0x815230", VA = "0x180816C30")]
	protected void Split(BulletType t1, BulletType t2, BulletType t3, BulletType t4, int row)
	{
		int num = (int)(t1 + (int)t1);
		float num2 = global::UnityEngine.Random.Range(0.9f, 1.1f);
		CreateBullet instance = CreateBullet.Instance;
		Transform transform = base.transform;
		Transform transform2 = base.transform;
		float num3 = this.velocity.y * 0.5f;
		Bullet bullet;
		bullet.velocity.y = num3;
		float num4 = this.velocity * 0.5f;
		bullet.velocity = num4;
		float y = this.acceleration.y;
		Vector2 acceleration = this.acceleration;
		bullet.acceleration.y = y;
		bullet.acceleration = acceleration;
		bool melonSputter = this.melonSputter;
		bullet.melonSputter = melonSputter;
		PlantType fromType = this.fromType;
		bullet.fromType = fromType;
		CreateBullet instance2 = CreateBullet.Instance;
		Transform transform3 = base.transform;
		Transform transform4 = base.transform;
		float num5 = this.velocity.y * 0.4f;
		Bullet bullet2;
		bullet2.velocity.y = num5;
		float num6 = this.velocity * 0.4f;
		bullet2.velocity = num6;
		float y2 = this.acceleration.y;
		Vector2 acceleration2 = this.acceleration;
		bullet2.acceleration.y = y2;
		bullet2.acceleration = acceleration2;
		bool melonSputter2 = this.melonSputter;
		bullet2.melonSputter = melonSputter2;
		PlantType fromType2 = this.fromType;
		bullet2.fromType = fromType2;
		int num7 = (int)fromType2;
		CreateBullet instance3 = CreateBullet.Instance;
		Transform transform5 = base.transform;
		Transform transform6 = base.transform;
		float y3 = this.velocity.y;
		Bullet bullet3;
		bullet3.velocity.y = y3;
		Vector2 velocity = this.velocity;
		bullet3.velocity = velocity;
		Vector2 acceleration3 = this.acceleration;
		float y4 = this.acceleration.y;
		bullet3.acceleration = acceleration3;
		float x;
		if (num7 == 1)
		{
			x = acceleration3.x;
		}
		bullet3.acceleration.y = y4;
		bullet3.Damage = (int)x;
		bool melonSputter3 = this.melonSputter;
		bullet3.melonSputter = melonSputter3;
		PlantType fromType3 = this.fromType;
		bullet3.fromType = fromType3;
	}

	// Token: 0x060007E7 RID: 2023 RVA: 0x0002805C File Offset: 0x0002625C
	[Token(Token = "0x60007E7")]
	[Address(RVA = "0x814E20", Offset = "0x813420", VA = "0x180814E20")]
	public Bullet_ultimatePuff()
	{
	}
}
