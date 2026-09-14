using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001BD RID: 445
[Token(Token = "0x20001BD")]
public class Bullet_star_ice : Bullet_star
{
	// Token: 0x0600079E RID: 1950 RVA: 0x00026714 File Offset: 0x00024914
	[Token(Token = "0x600079E")]
	[Address(RVA = "0x8130C0", Offset = "0x8116C0", VA = "0x1808130C0", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		int num = 0;
		zombie.AddfreezeLevel(10, num);
		bool flag = zombie.HasBuff((EffectType)((uint)2));
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num2;
		zombie.TakeDamage(damage, this, (DamageType)((uint)2), fromType, num2 != 0UL);
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num3 = 0;
		int theZombieRow = zombie.theZombieRow;
		int num4 = 0;
		ulong num5;
		Particle particle = instance.SetParticle((ParticleType)((uint)24), num3, theZombieRow, num5 != 0UL, (float)num4);
		base.PlaySound(zombie);
		base.Die();
	}

	// Token: 0x0600079F RID: 1951 RVA: 0x00026798 File Offset: 0x00024998
	[Token(Token = "0x600079F")]
	[Address(RVA = "0x812FB0", Offset = "0x8115B0", VA = "0x180812FB0", Slot = "17")]
	public override void HitLand()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theBulletRow = this.theBulletRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)24), num, theBulletRow, num3 != 0UL, (float)num2);
		base.Die();
	}

	// Token: 0x060007A0 RID: 1952 RVA: 0x000267E4 File Offset: 0x000249E4
	[Token(Token = "0x60007A0")]
	[Address(RVA = "0x809340", Offset = "0x807940", VA = "0x180809340")]
	public Bullet_star_ice()
	{
		this.movingToCircle = true;
		base..ctor();
	}
}
