using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001C3 RID: 451
[Token(Token = "0x20001C3")]
public class Bullet_sunSpike : Bullet_iceSpark
{
	// Token: 0x060007B2 RID: 1970 RVA: 0x00026C34 File Offset: 0x00024E34
	[Token(Token = "0x60007B2")]
	[Address(RVA = "0x813CD0", Offset = "0x8122D0", VA = "0x180813CD0", Slot = "17")]
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

	// Token: 0x060007B3 RID: 1971 RVA: 0x00026C80 File Offset: 0x00024E80
	[Token(Token = "0x60007B3")]
	[Address(RVA = "0x813DE0", Offset = "0x8123E0", VA = "0x180813DE0", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		int damage = this._damage;
		Board instance = Board.Instance;
		if (instance.theSun > 15000)
		{
			instance.UseSun(5f);
			int num = this.hitCount;
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

	// Token: 0x060007B4 RID: 1972 RVA: 0x00026D78 File Offset: 0x00024F78
	[Token(Token = "0x60007B4")]
	[Address(RVA = "0x80DE70", Offset = "0x80C470", VA = "0x18080DE70")]
	public Bullet_sunSpike()
	{
	}
}
