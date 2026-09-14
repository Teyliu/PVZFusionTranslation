using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200018D RID: 397
[Token(Token = "0x200018D")]
public class Bullet_redLunarCabbage : Bullet_cabbage
{
	// Token: 0x060006FA RID: 1786 RVA: 0x0002440C File Offset: 0x0002260C
	[Token(Token = "0x60006FA")]
	[Address(RVA = "0x7DDF00", Offset = "0x7DC500", VA = "0x1807DDF00", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)4), fromType, num != 0UL);
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num2 = 0;
		int theBulletRow = this.theBulletRow;
		int num3 = 0;
		ulong num4;
		Particle particle = instance.SetParticle((ParticleType)((uint)111), num2, theBulletRow, num4 != 0UL, (float)num3);
		base.PlaySound(zombie);
		base.Die();
	}

	// Token: 0x060006FB RID: 1787 RVA: 0x00024478 File Offset: 0x00022678
	[Token(Token = "0x60006FB")]
	[Address(RVA = "0x7DDDF0", Offset = "0x7DC3F0", VA = "0x1807DDDF0", Slot = "18")]
	public override void HitLand()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theBulletRow = this.theBulletRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)111), num, theBulletRow, num3 != 0UL, (float)num2);
		base.Die();
	}

	// Token: 0x060006FC RID: 1788 RVA: 0x000244C4 File Offset: 0x000226C4
	[Token(Token = "0x60006FC")]
	[Address(RVA = "0x6B71A0", Offset = "0x6B57A0", VA = "0x1806B71A0")]
	public Bullet_redLunarCabbage()
	{
	}
}
