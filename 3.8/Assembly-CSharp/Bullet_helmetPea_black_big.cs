using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200014B RID: 331
[Token(Token = "0x200014B")]
public class Bullet_helmetPea_black_big : Bullet_pierce
{
	// Token: 0x0600061C RID: 1564 RVA: 0x00020968 File Offset: 0x0001EB68
	[Token(Token = "0x600061C")]
	[Address(RVA = "0x6C5110", Offset = "0x6C3710", VA = "0x1806C5110", Slot = "27")]
	protected override void SetPenetrationTime()
	{
		this.penetrationTimes = (int)((ulong)10L);
	}

	// Token: 0x0600061D RID: 1565 RVA: 0x00020980 File Offset: 0x0001EB80
	[Token(Token = "0x600061D")]
	[Address(RVA = "0x6C4C10", Offset = "0x6C3210", VA = "0x1806C4C10", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		zombie.KnockBack(0.5f, (Zombie.KnockBackReason)((uint)1));
		int num = 0;
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num2;
		zombie.TakeDamage(damage, this, (DamageType)num, fromType, num2 != 0UL);
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num3 = 0;
		Vector3 vector;
		float z = vector.z;
		int theBulletRow = this.theBulletRow;
		int num4 = 0;
		ulong num5;
		Particle particle = instance.SetParticle((ParticleType)((uint)18), num3, theBulletRow, num5 != 0UL, (float)num4);
		base.PlaySound(zombie);
		Collider2D col = this.col;
		Collider2D col2 = zombie.col;
		int num6 = 0;
		Physics2D.IgnoreCollision(col, col2, num6 != 0);
		Transform transform2 = base.transform;
		int columnNum = this.board.columnNum;
		int penetrationTimes = this.penetrationTimes;
		this.hitTimes = penetrationTimes;
	}

	// Token: 0x0600061E RID: 1566 RVA: 0x00020A40 File Offset: 0x0001EC40
	[Token(Token = "0x600061E")]
	[Address(RVA = "0x6C4B00", Offset = "0x6C3100", VA = "0x1806C4B00", Slot = "18")]
	public override void HitLand()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theBulletRow = this.theBulletRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)18), num, theBulletRow, num3 != 0UL, (float)num2);
		base.Die();
	}

	// Token: 0x0600061F RID: 1567 RVA: 0x00020A8C File Offset: 0x0001EC8C
	[Token(Token = "0x600061F")]
	[Address(RVA = "0x6C4DE0", Offset = "0x6C33E0", VA = "0x1806C4DE0", Slot = "10")]
	protected override void OnDeath()
	{
		int penetrationTimes = this.penetrationTimes;
		int num = 0;
		CreateBullet instance = CreateBullet.Instance;
		Transform transform = base.transform;
		Transform transform2 = base.transform;
		Bullet bullet;
		Transform transform3 = bullet.transform;
		PlantType fromType = this.fromType;
		uint num2;
		num2 += (uint)10;
		bullet.fromType = fromType;
		while (num2 <= (uint)90)
		{
		}
		num++;
		ParticleManager instance2 = ParticleManager.Instance;
		Transform transform4 = base.transform;
	}

	// Token: 0x06000620 RID: 1568 RVA: 0x00020AFC File Offset: 0x0001ECFC
	[Token(Token = "0x6000620")]
	[Address(RVA = "0x6B71A0", Offset = "0x6B57A0", VA = "0x1806B71A0")]
	public Bullet_helmetPea_black_big()
	{
	}
}
