using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000150 RID: 336
[Token(Token = "0x2000150")]
public class Bullet_helmetPea_black_big : Bullet_pierce
{
	// Token: 0x06000624 RID: 1572 RVA: 0x0002020C File Offset: 0x0001E40C
	[Token(Token = "0x6000624")]
	[Address(RVA = "0x6F02F0", Offset = "0x6EE8F0", VA = "0x1806F02F0", Slot = "25")]
	protected override void SetPenetrationTime()
	{
		this.maxHitCount = (int)((ulong)10L);
	}

	// Token: 0x06000625 RID: 1573 RVA: 0x00020224 File Offset: 0x0001E424
	[Token(Token = "0x6000625")]
	[Address(RVA = "0x6EFDF0", Offset = "0x6EE3F0", VA = "0x1806EFDF0", Slot = "22")]
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
		int maxHitCount = this.maxHitCount;
		this.hitCount = maxHitCount;
	}

	// Token: 0x06000626 RID: 1574 RVA: 0x000202E4 File Offset: 0x0001E4E4
	[Token(Token = "0x6000626")]
	[Address(RVA = "0x6EFCE0", Offset = "0x6EE2E0", VA = "0x1806EFCE0", Slot = "17")]
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

	// Token: 0x06000627 RID: 1575 RVA: 0x00020330 File Offset: 0x0001E530
	[Token(Token = "0x6000627")]
	[Address(RVA = "0x6EFFC0", Offset = "0x6EE5C0", VA = "0x1806EFFC0", Slot = "11")]
	protected override void OnDeath()
	{
		int maxHitCount = this.maxHitCount;
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

	// Token: 0x06000628 RID: 1576 RVA: 0x000203A0 File Offset: 0x0001E5A0
	[Token(Token = "0x6000628")]
	[Address(RVA = "0x6E2090", Offset = "0x6E0690", VA = "0x1806E2090")]
	public Bullet_helmetPea_black_big()
	{
	}
}
