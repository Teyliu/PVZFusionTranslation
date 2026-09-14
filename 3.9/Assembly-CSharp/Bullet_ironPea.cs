using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200015C RID: 348
[Token(Token = "0x200015C")]
public class Bullet_ironPea : Bullet
{
	// Token: 0x0600064A RID: 1610 RVA: 0x00020E64 File Offset: 0x0001F064
	[Token(Token = "0x600064A")]
	[Address(RVA = "0x6F2CF0", Offset = "0x6F12F0", VA = "0x1806F2CF0", Slot = "22")]
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

	// Token: 0x0600064B RID: 1611 RVA: 0x00020EC4 File Offset: 0x0001F0C4
	[Token(Token = "0x600064B")]
	[Address(RVA = "0x6F2A70", Offset = "0x6F1070", VA = "0x1806F2A70", Slot = "17")]
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

	// Token: 0x0600064C RID: 1612 RVA: 0x00020F10 File Offset: 0x0001F110
	[Token(Token = "0x600064C")]
	[Address(RVA = "0x6F2B80", Offset = "0x6F1180", VA = "0x1806F2B80", Slot = "21")]
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

	// Token: 0x0600064D RID: 1613 RVA: 0x00020F64 File Offset: 0x0001F164
	[Token(Token = "0x600064D")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_ironPea()
	{
	}
}
