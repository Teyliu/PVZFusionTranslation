using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001B4 RID: 436
[Token(Token = "0x20001B4")]
public class Bullet_starFume : Bullet_pierce
{
	// Token: 0x0600078B RID: 1931 RVA: 0x00026CF8 File Offset: 0x00024EF8
	[Token(Token = "0x600078B")]
	[Address(RVA = "0x6BB760", Offset = "0x6B9D60", VA = "0x1806BB760", Slot = "27")]
	protected override void SetPenetrationTime()
	{
		this.penetrationTimes = (int)((ulong)3L);
	}

	// Token: 0x0600078C RID: 1932 RVA: 0x00026D10 File Offset: 0x00024F10
	[Token(Token = "0x600078C")]
	[Address(RVA = "0x7E4EA0", Offset = "0x7E34A0", VA = "0x1807E4EA0", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		this.SetBullet(30f, (BulletMoveWay)((uint)2));
		this.SetBullet(-30f, (BulletMoveWay)((uint)2));
		this.SetBullet(90f, (BulletMoveWay)((uint)2));
		this.SetBullet(-90f, (BulletMoveWay)((uint)2));
	}

	// Token: 0x0600078D RID: 1933 RVA: 0x00026D54 File Offset: 0x00024F54
	[Token(Token = "0x600078D")]
	[Address(RVA = "0x7E4F60", Offset = "0x7E3560", VA = "0x1807E4F60", Slot = "28")]
	protected virtual void SetBullet(float angle, BulletMoveWay theMovingWay)
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		Transform transform2 = bullet.transform;
		float num = angle * 0.017453292f;
		int damage = this._damage;
		bullet.Damage = damage;
		PlantType fromType = this.fromType;
		bullet.fromType = fromType;
	}

	// Token: 0x0600078E RID: 1934 RVA: 0x00026DB4 File Offset: 0x00024FB4
	[Token(Token = "0x600078E")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_starFume()
	{
	}
}
