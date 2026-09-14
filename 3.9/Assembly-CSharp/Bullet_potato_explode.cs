using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200018D RID: 397
[Token(Token = "0x200018D")]
public class Bullet_potato_explode : Bullet
{
	// Token: 0x060006EC RID: 1772 RVA: 0x00023640 File Offset: 0x00021840
	[Token(Token = "0x60006EC")]
	[Address(RVA = "0x809C60", Offset = "0x808260", VA = "0x180809C60", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		Vector3 vector;
		float z = vector.z;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)8), num, 11, num3 != 0UL, (float)num2);
		GameAPP.PlaySound(47, 0.5f, 1f);
		Transform transform2 = base.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		PlantType fromType = this.fromType;
		int damage = this._damage;
		base.Die();
	}

	// Token: 0x060006ED RID: 1773 RVA: 0x000236B8 File Offset: 0x000218B8
	[Token(Token = "0x60006ED")]
	[Address(RVA = "0x809AE0", Offset = "0x8080E0", VA = "0x180809AE0", Slot = "17")]
	public override void HitLand()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		Vector3 vector;
		float z = vector.z;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)8), num, 11, num3 != 0UL, (float)num2);
		GameAPP.PlaySound(47, 0.5f, 1f);
		Transform transform2 = base.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		PlantType fromType = this.fromType;
		int damage = this._damage;
		base.Die();
	}

	// Token: 0x060006EE RID: 1774 RVA: 0x00023730 File Offset: 0x00021930
	[Token(Token = "0x60006EE")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_potato_explode()
	{
	}
}
