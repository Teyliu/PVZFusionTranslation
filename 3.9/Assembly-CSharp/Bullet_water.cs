using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001D4 RID: 468
[Token(Token = "0x20001D4")]
public class Bullet_water : Bullet_cabbage
{
	// Token: 0x060007F9 RID: 2041 RVA: 0x000286E8 File Offset: 0x000268E8
	[Token(Token = "0x60007F9")]
	[Address(RVA = "0x818840", Offset = "0x816E40", VA = "0x180818840", Slot = "22")]
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

	// Token: 0x060007FA RID: 2042 RVA: 0x00028754 File Offset: 0x00026954
	[Token(Token = "0x60007FA")]
	[Address(RVA = "0x818730", Offset = "0x816D30", VA = "0x180818730", Slot = "17")]
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

	// Token: 0x060007FB RID: 2043 RVA: 0x000287A0 File Offset: 0x000269A0
	[Token(Token = "0x60007FB")]
	[Address(RVA = "0x6E2090", Offset = "0x6E0690", VA = "0x1806E2090")]
	public Bullet_water()
	{
	}
}
