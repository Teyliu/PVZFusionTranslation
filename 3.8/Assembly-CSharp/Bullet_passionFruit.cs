using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000179 RID: 377
[Token(Token = "0x2000179")]
public class Bullet_passionFruit : Bullet
{
	// Token: 0x060006AF RID: 1711 RVA: 0x0002300C File Offset: 0x0002120C
	[Token(Token = "0x60006AF")]
	[Address(RVA = "0x7D9990", Offset = "0x7D7F90", VA = "0x1807D9990", Slot = "25")]
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

	// Token: 0x060006B0 RID: 1712 RVA: 0x000230D4 File Offset: 0x000212D4
	[Token(Token = "0x60006B0")]
	[Address(RVA = "0x7D98D0", Offset = "0x7D7ED0", VA = "0x1807D98D0", Slot = "18")]
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

	// Token: 0x060006B1 RID: 1713 RVA: 0x0002311C File Offset: 0x0002131C
	[Token(Token = "0x60006B1")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_passionFruit()
	{
	}
}
