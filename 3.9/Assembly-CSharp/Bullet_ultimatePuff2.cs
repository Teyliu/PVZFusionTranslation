using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001D1 RID: 465
[Token(Token = "0x20001D1")]
public class Bullet_ultimatePuff2 : Bullet_ultimatePuff
{
	// Token: 0x060007E8 RID: 2024 RVA: 0x00028070 File Offset: 0x00026270
	[Token(Token = "0x60007E8")]
	[Address(RVA = "0x816710", Offset = "0x814D10", VA = "0x180816710", Slot = "17")]
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

	// Token: 0x060007E9 RID: 2025 RVA: 0x000280BC File Offset: 0x000262BC
	[Token(Token = "0x60007E9")]
	[Address(RVA = "0x816820", Offset = "0x814E20", VA = "0x180816820", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theBulletRow = this.theBulletRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)24), num, theBulletRow, num3 != 0UL, (float)num2);
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num4;
		zombie.TakeDamage(damage, this, (DamageType)((uint)5), fromType, num4 != 0UL);
		int num5 = 0;
		zombie.AddfreezeLevel(5, num5);
		base.PlaySound(zombie);
		int theZombieRow = zombie.theZombieRow;
		int theZombieRow2 = zombie.theZombieRow;
		base.Die();
	}

	// Token: 0x060007EA RID: 2026 RVA: 0x00028144 File Offset: 0x00026344
	[Token(Token = "0x60007EA")]
	[Address(RVA = "0x814E20", Offset = "0x813420", VA = "0x180814E20")]
	public Bullet_ultimatePuff2()
	{
	}
}
