using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000186 RID: 390
[Token(Token = "0x2000186")]
public class Bullet_potato_explode : Bullet
{
	// Token: 0x060006DF RID: 1759 RVA: 0x00023D20 File Offset: 0x00021F20
	[Token(Token = "0x60006DF")]
	[Address(RVA = "0x7DC570", Offset = "0x7DAB70", VA = "0x1807DC570", Slot = "25")]
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

	// Token: 0x060006E0 RID: 1760 RVA: 0x00023D98 File Offset: 0x00021F98
	[Token(Token = "0x60006E0")]
	[Address(RVA = "0x7DC3F0", Offset = "0x7DA9F0", VA = "0x1807DC3F0", Slot = "18")]
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

	// Token: 0x060006E1 RID: 1761 RVA: 0x00023E10 File Offset: 0x00022010
	[Token(Token = "0x60006E1")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_potato_explode()
	{
	}
}
