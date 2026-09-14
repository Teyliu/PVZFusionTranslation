using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001CA RID: 458
[Token(Token = "0x20001CA")]
public class Bullet_water : Bullet_cabbage
{
	// Token: 0x060007E3 RID: 2019 RVA: 0x00028B28 File Offset: 0x00026D28
	[Token(Token = "0x60007E3")]
	[Address(RVA = "0x7EB150", Offset = "0x7E9750", VA = "0x1807EB150", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)4), fromType, num != 0UL);
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num2 = 0;
		int theZombieRow = zombie.theZombieRow;
		int num3 = 0;
		ulong num4;
		Particle particle = instance.SetParticle((ParticleType)((uint)32), num2, theZombieRow, num4 != 0UL, (float)num3);
		base.PlaySound(zombie);
		base.Die();
	}

	// Token: 0x060007E4 RID: 2020 RVA: 0x00028B94 File Offset: 0x00026D94
	[Token(Token = "0x60007E4")]
	[Address(RVA = "0x7EB040", Offset = "0x7E9640", VA = "0x1807EB040", Slot = "18")]
	public override void HitLand()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theBulletRow = this.theBulletRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)32), num, theBulletRow, num3 != 0UL, (float)num2);
		base.Die();
	}

	// Token: 0x060007E5 RID: 2021 RVA: 0x00028BE0 File Offset: 0x00026DE0
	[Token(Token = "0x60007E5")]
	[Address(RVA = "0x6B71A0", Offset = "0x6B57A0", VA = "0x1806B71A0")]
	public Bullet_water()
	{
	}
}
