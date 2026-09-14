using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200017F RID: 383
[Token(Token = "0x200017F")]
public class Bullet_passionFruit : Bullet
{
	// Token: 0x060006BA RID: 1722 RVA: 0x0002295C File Offset: 0x00020B5C
	[Token(Token = "0x60006BA")]
	[Address(RVA = "0x807220", Offset = "0x805820", VA = "0x180807220", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		uint num;
		GameAPP.PlaySound((int)num, 0.2f, 1f);
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		int num2 = this._damage;
		Particle particle;
		num2 -= particle;
		PlantType fromType = this.fromType;
		base.Die();
	}

	// Token: 0x060006BB RID: 1723 RVA: 0x00022A24 File Offset: 0x00020C24
	[Token(Token = "0x60006BB")]
	[Address(RVA = "0x807160", Offset = "0x805760", VA = "0x180807160", Slot = "17")]
	public override void HitLand()
	{
		base.HitLand();
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theBulletRow = this.theBulletRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)102), num, theBulletRow, num3 != 0UL, (float)num2);
	}

	// Token: 0x060006BC RID: 1724 RVA: 0x00022A6C File Offset: 0x00020C6C
	[Token(Token = "0x60006BC")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_passionFruit()
	{
	}
}
