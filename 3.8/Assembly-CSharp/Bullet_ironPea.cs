using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000156 RID: 342
[Token(Token = "0x2000156")]
public class Bullet_ironPea : Bullet
{
	// Token: 0x06000640 RID: 1600 RVA: 0x000214C8 File Offset: 0x0001F6C8
	[Token(Token = "0x6000640")]
	[Address(RVA = "0x6C74C0", Offset = "0x6C5AC0", VA = "0x1806C74C0", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		int num = 0;
		PlantType fromType = this.fromType;
		if (zombie.theSecondArmorHealth == num)
		{
		}
		int theSecondArmorHealth = zombie.theSecondArmorHealth;
		zombie.TakeDamage(theSecondArmorHealth, this, (DamageType)num, fromType, num != 0);
		if (!zombie.isMindControlled)
		{
		}
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		base.PlaySound(zombie);
		base.Die();
	}

	// Token: 0x06000641 RID: 1601 RVA: 0x00021528 File Offset: 0x0001F728
	[Token(Token = "0x6000641")]
	[Address(RVA = "0x6C7240", Offset = "0x6C5840", VA = "0x1806C7240", Slot = "18")]
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

	// Token: 0x06000642 RID: 1602 RVA: 0x00021574 File Offset: 0x0001F774
	[Token(Token = "0x6000642")]
	[Address(RVA = "0x6C7350", Offset = "0x6C5950", VA = "0x1806C7350", Slot = "24")]
	protected override void HitPlant(Plant plant)
	{
		plant.FlashOnce();
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int thePlantRow = plant.thePlantRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)18), num, thePlantRow, num3 != 0UL, (float)num2);
		base.Die();
	}

	// Token: 0x06000643 RID: 1603 RVA: 0x000215C8 File Offset: 0x0001F7C8
	[Token(Token = "0x6000643")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_ironPea()
	{
	}
}
