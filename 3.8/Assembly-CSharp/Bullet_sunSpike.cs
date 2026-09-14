using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001BA RID: 442
[Token(Token = "0x20001BA")]
public class Bullet_sunSpike : Bullet_iceSpark
{
	// Token: 0x060007A0 RID: 1952 RVA: 0x000271C0 File Offset: 0x000253C0
	[Token(Token = "0x60007A0")]
	[Address(RVA = "0x7E6440", Offset = "0x7E4A40", VA = "0x1807E6440", Slot = "18")]
	public override void HitLand()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theBulletRow = this.theBulletRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)84), num, theBulletRow, num3 != 0UL, (float)num2);
		base.Die();
	}

	// Token: 0x060007A1 RID: 1953 RVA: 0x0002720C File Offset: 0x0002540C
	[Token(Token = "0x60007A1")]
	[Address(RVA = "0x7E6550", Offset = "0x7E4B50", VA = "0x1807E6550", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		int damage = this._damage;
		Board instance = Board.Instance;
		if (instance.theSun > 15000)
		{
			instance.UseSun(5f);
			int num = this.hitTimes;
			num++;
			CreateItem instance2 = CreateItem.Instance;
			Transform transform = base.transform;
			Vector3 vector;
			float z = vector.z;
		}
		bool flag;
		if (flag)
		{
			CreateBullet instance3 = CreateBullet.Instance;
			Transform transform2 = base.transform;
			Transform transform3 = base.transform;
			BulletType theBulletType = this.theBulletType;
			Bullet bullet;
			Transform transform4 = bullet.transform;
			PlantType fromType = this.fromType;
			bullet.fromType = fromType;
			CreateBullet instance4 = CreateBullet.Instance;
			Transform transform5 = base.transform;
			Transform transform6 = base.transform;
			BulletType theBulletType2 = this.theBulletType;
			Bullet bullet2;
			Transform transform7 = bullet2.transform;
			PlantType fromType2 = this.fromType;
			bullet2.fromType = fromType2;
		}
		PlantType fromType3 = this.fromType;
		ParticleManager instance5 = ParticleManager.Instance;
		Transform transform8 = base.transform;
		base.PlaySound(zombie);
	}

	// Token: 0x060007A2 RID: 1954 RVA: 0x00027304 File Offset: 0x00025504
	[Token(Token = "0x60007A2")]
	[Address(RVA = "0x7E0730", Offset = "0x7DED30", VA = "0x1807E0730")]
	public Bullet_sunSpike()
	{
	}
}
