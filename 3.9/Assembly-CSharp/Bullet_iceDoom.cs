using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000157 RID: 343
[Token(Token = "0x2000157")]
public class Bullet_iceDoom : Bullet_pierce
{
	// Token: 0x06000638 RID: 1592 RVA: 0x00020924 File Offset: 0x0001EB24
	[Token(Token = "0x6000638")]
	[Address(RVA = "0x6F18F0", Offset = "0x6EFEF0", VA = "0x1806F18F0", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		int num = 0;
		uint num2;
		zombie.AddfreezeLevel((int)num2, num);
		int num3 = this._damage;
		Transform transform = base.transform;
		PlantType fromType = this.fromType;
		Vector3 vector;
		float z = vector.z;
		num3 -= transform;
		if (transform == 0)
		{
		}
		PlantType fromType2 = this.fromType;
		ParticleManager instance = ParticleManager.Instance;
		Transform transform2 = base.transform;
		uint num4;
		GameAPP.PlaySound((int)num4, 0.5f, 1f);
	}

	// Token: 0x06000639 RID: 1593 RVA: 0x00020994 File Offset: 0x0001EB94
	[Token(Token = "0x6000639")]
	[Address(RVA = "0x6F1770", Offset = "0x6EFD70", VA = "0x1806F1770", Slot = "17")]
	public override void HitLand()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		Vector3 vector;
		float z = vector.z;
		int theBulletRow = this.theBulletRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)28), num, theBulletRow, num3 != 0UL, (float)num2);
		Transform transform2 = base.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		PlantType fromType = this.fromType;
		GameAPP.PlaySound(70, 0.5f, 1f);
		base.Die();
	}

	// Token: 0x0600063A RID: 1594 RVA: 0x00020A0C File Offset: 0x0001EC0C
	[Token(Token = "0x600063A")]
	[Address(RVA = "0x6E2090", Offset = "0x6E0690", VA = "0x1806E2090")]
	public Bullet_iceDoom()
	{
	}
}
