using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000181 RID: 385
[Token(Token = "0x2000181")]
public class Bullet_pea2 : Bullet
{
	// Token: 0x170000A6 RID: 166
	// (get) Token: 0x060006C1 RID: 1729 RVA: 0x00022BA0 File Offset: 0x00020DA0
	[Token(Token = "0x170000A6")]
	protected override bool Ignore
	{
		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "8")]
		get
		{
			return false;
		}
	}

	// Token: 0x060006C2 RID: 1730 RVA: 0x00022BB0 File Offset: 0x00020DB0
	[Token(Token = "0x60006C2")]
	[Address(RVA = "0x8076E0", Offset = "0x805CE0", VA = "0x1808076E0", Slot = "9")]
	public override void InitData()
	{
		base.InitData();
		this.maxHitCount = (int)((ulong)6L);
	}

	// Token: 0x060006C3 RID: 1731 RVA: 0x00022BCC File Offset: 0x00020DCC
	[Token(Token = "0x60006C3")]
	[Address(RVA = "0x8075D0", Offset = "0x805BD0", VA = "0x1808075D0", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)1), fromType, num != 0UL);
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num2 = 0;
		int theZombieRow = zombie.theZombieRow;
		int num3 = 0;
		int num4 = 0;
		ulong num5;
		Particle particle = instance.SetParticle((ParticleType)num4, num2, theZombieRow, num5 != 0UL, (float)num3);
		base.PlaySound(zombie);
	}

	// Token: 0x060006C4 RID: 1732 RVA: 0x00022C34 File Offset: 0x00020E34
	[Token(Token = "0x60006C4")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_pea2()
	{
	}
}
