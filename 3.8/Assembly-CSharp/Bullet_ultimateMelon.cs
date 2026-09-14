using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001C5 RID: 453
[Token(Token = "0x20001C5")]
public class Bullet_ultimateMelon : Bullet_superMelon
{
	// Token: 0x060007CA RID: 1994 RVA: 0x00027F84 File Offset: 0x00026184
	[Token(Token = "0x60007CA")]
	[Address(RVA = "0x7E87E0", Offset = "0x7E6DE0", VA = "0x1807E87E0", Slot = "18")]
	public override void HitLand()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theBulletRow = this.theBulletRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)58), num, theBulletRow, num3 != 0UL, (float)num2);
		int num4 = 0;
		base.AttackOtherZombie(num4, (MelonSputterType)((uint)2));
		GameAPP.PlaySound(global::UnityEngine.Random.Range(104, 106), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x060007CB RID: 1995 RVA: 0x00027FF0 File Offset: 0x000261F0
	[Token(Token = "0x60007CB")]
	[Address(RVA = "0x7E8910", Offset = "0x7E6F10", VA = "0x1807E8910", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		PlantType fromType = this.fromType;
		uint num;
		uint num2;
		GameAPP.PlaySound(global::UnityEngine.Random.Range((int)num, (int)num2), 0.5f, 1f);
		CreateBullet instance2 = CreateBullet.Instance;
		Transform transform2 = base.transform;
		Transform transform3 = base.transform;
		float vy = this.Vy;
		Bullet bullet;
		bullet.Vy = vy;
		float vx = this.Vx;
		bullet.Vx = vx;
		float detaVy = this.detaVy;
		bullet.detaVy = detaVy;
		uint num3;
		bullet.Damage = (int)num3;
		bool melonSputter = this.melonSputter;
		bullet.melonSputter = melonSputter;
		PlantType fromType2 = this.fromType;
		bullet.fromType = fromType2;
		CreateBullet instance3 = CreateBullet.Instance;
		Transform transform4 = base.transform;
		Transform transform5 = base.transform;
		float num4 = this.Vy * 0.4f;
		Bullet bullet2;
		bullet2.Vy = num4;
		float num5 = this.Vx * 0.4f;
		bullet2.Vx = num5;
		float detaVy2 = this.detaVy;
		bullet2.detaVy = detaVy2;
		uint num6;
		bullet2.Damage = (int)num6;
		bool melonSputter2 = this.melonSputter;
		bullet2.melonSputter = melonSputter2;
		PlantType fromType3 = this.fromType;
		bullet2.fromType = fromType3;
		CreateBullet instance4 = CreateBullet.Instance;
		Transform transform6 = base.transform;
		Transform transform7 = base.transform;
		float vy2 = this.Vy;
		Bullet bullet3;
		bullet3.Vy = vy2;
		float vx2 = this.Vx;
		bullet3.Vx = vx2;
		float detaVy3 = this.detaVy;
		bullet3.detaVy = detaVy3;
		bullet3.Damage = (int)num3;
		bool melonSputter3 = this.melonSputter;
		bullet3.melonSputter = melonSputter3;
		PlantType fromType4 = this.fromType;
		bullet3.fromType = fromType4;
		base.Die();
	}

	// Token: 0x060007CC RID: 1996 RVA: 0x000281B8 File Offset: 0x000263B8
	[Token(Token = "0x60007CC")]
	[Address(RVA = "0x7E7570", Offset = "0x7E5B70", VA = "0x1807E7570")]
	public Bullet_ultimateMelon()
	{
	}
}
