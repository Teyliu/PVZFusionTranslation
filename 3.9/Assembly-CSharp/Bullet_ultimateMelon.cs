using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001CF RID: 463
[Token(Token = "0x20001CF")]
public class Bullet_ultimateMelon : Bullet_superMelon
{
	// Token: 0x060007E1 RID: 2017 RVA: 0x00027ACC File Offset: 0x00025CCC
	[Token(Token = "0x60007E1")]
	[Address(RVA = "0x816080", Offset = "0x814680", VA = "0x180816080", Slot = "17")]
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

	// Token: 0x060007E2 RID: 2018 RVA: 0x00027B38 File Offset: 0x00025D38
	[Token(Token = "0x60007E2")]
	[Address(RVA = "0x8161B0", Offset = "0x8147B0", VA = "0x1808161B0", Slot = "22")]
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
		float y = this.velocity.y;
		Bullet bullet;
		bullet.velocity.y = y;
		Vector2 velocity = this.velocity;
		bullet.velocity = velocity;
		float y2 = this.acceleration.y;
		Vector2 acceleration = this.acceleration;
		bullet.acceleration.y = y2;
		bullet.acceleration = acceleration;
		uint num3;
		bullet.Damage = (int)num3;
		bool melonSputter = this.melonSputter;
		bullet.melonSputter = melonSputter;
		PlantType fromType2 = this.fromType;
		bullet.fromType = fromType2;
		CreateBullet instance3 = CreateBullet.Instance;
		Transform transform4 = base.transform;
		Transform transform5 = base.transform;
		float num4 = this.velocity.y * 0.4f;
		Bullet bullet2;
		bullet2.velocity.y = num4;
		float num5 = this.velocity * 0.4f;
		bullet2.velocity = num5;
		float y3 = this.acceleration.y;
		Vector2 acceleration2 = this.acceleration;
		bullet2.acceleration.y = y3;
		bullet2.acceleration = acceleration2;
		uint num6;
		bullet2.Damage = (int)num6;
		bool melonSputter2 = this.melonSputter;
		bullet2.melonSputter = melonSputter2;
		PlantType fromType3 = this.fromType;
		bullet2.fromType = fromType3;
		CreateBullet instance4 = CreateBullet.Instance;
		Transform transform6 = base.transform;
		Transform transform7 = base.transform;
		float y4 = this.velocity.y;
		Bullet bullet3;
		bullet3.velocity.y = y4;
		Vector2 velocity2 = this.velocity;
		bullet3.velocity = velocity2;
		float y5 = this.acceleration.y;
		Vector2 acceleration3 = this.acceleration;
		bullet3.acceleration.y = y5;
		bullet3.acceleration = acceleration3;
		bullet3.Damage = (int)num3;
		bool melonSputter3 = this.melonSputter;
		bullet3.melonSputter = melonSputter3;
		PlantType fromType4 = this.fromType;
		bullet3.fromType = fromType4;
		base.Die();
	}

	// Token: 0x060007E3 RID: 2019 RVA: 0x00027D70 File Offset: 0x00025F70
	[Token(Token = "0x60007E3")]
	[Address(RVA = "0x814E20", Offset = "0x813420", VA = "0x180814E20")]
	public Bullet_ultimateMelon()
	{
	}
}
