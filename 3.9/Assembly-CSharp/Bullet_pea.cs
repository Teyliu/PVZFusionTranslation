using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000180 RID: 384
[Token(Token = "0x2000180")]
public class Bullet_pea : Bullet
{
	// Token: 0x060006BD RID: 1725 RVA: 0x00022A80 File Offset: 0x00020C80
	[Token(Token = "0x60006BD")]
	[Address(RVA = "0x807970", Offset = "0x805F70", VA = "0x180807970", Slot = "22")]
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
		int num4 = 0;
		ulong num5;
		Particle particle = instance.SetParticle((ParticleType)num4, num2, theZombieRow, num5 != 0UL, (float)num3);
		base.PlaySound(zombie);
		base.Die();
	}

	// Token: 0x060006BE RID: 1726 RVA: 0x00022AEC File Offset: 0x00020CEC
	[Token(Token = "0x60006BE")]
	[Address(RVA = "0x807810", Offset = "0x805E10", VA = "0x180807810", Slot = "21")]
	protected override void HitPlant(Plant plant)
	{
		plant.FlashOnce();
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int thePlantRow = plant.thePlantRow;
		int num2 = 0;
		int num3 = 0;
		ulong num4;
		Particle particle = instance.SetParticle((ParticleType)num3, num, thePlantRow, num4 != 0UL, (float)num2);
		base.Die();
	}

	// Token: 0x060006BF RID: 1727 RVA: 0x00022B40 File Offset: 0x00020D40
	[Token(Token = "0x60006BF")]
	[Address(RVA = "0x807700", Offset = "0x805D00", VA = "0x180807700", Slot = "17")]
	public override void HitLand()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theBulletRow = this.theBulletRow;
		int num2 = 0;
		int num3 = 0;
		ulong num4;
		Particle particle = instance.SetParticle((ParticleType)num3, num, theBulletRow, num4 != 0UL, (float)num2);
		base.Die();
	}

	// Token: 0x060006C0 RID: 1728 RVA: 0x00022B8C File Offset: 0x00020D8C
	[Token(Token = "0x60006C0")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_pea()
	{
	}
}
