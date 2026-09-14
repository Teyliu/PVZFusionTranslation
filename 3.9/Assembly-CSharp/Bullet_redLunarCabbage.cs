using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000194 RID: 404
[Token(Token = "0x2000194")]
public class Bullet_redLunarCabbage : Bullet_cabbage
{
	// Token: 0x06000707 RID: 1799 RVA: 0x00023D4C File Offset: 0x00021F4C
	[Token(Token = "0x6000707")]
	[Address(RVA = "0x80B670", Offset = "0x809C70", VA = "0x18080B670", Slot = "22")]
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

	// Token: 0x06000708 RID: 1800 RVA: 0x00023DB8 File Offset: 0x00021FB8
	[Token(Token = "0x6000708")]
	[Address(RVA = "0x80B560", Offset = "0x809B60", VA = "0x18080B560", Slot = "17")]
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

	// Token: 0x06000709 RID: 1801 RVA: 0x00023E04 File Offset: 0x00022004
	[Token(Token = "0x6000709")]
	[Address(RVA = "0x6E2090", Offset = "0x6E0690", VA = "0x1806E2090")]
	public Bullet_redLunarCabbage()
	{
	}
}
