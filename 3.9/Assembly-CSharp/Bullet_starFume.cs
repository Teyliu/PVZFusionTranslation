using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001BB RID: 443
[Token(Token = "0x20001BB")]
public class Bullet_starFume : Bullet_pierce
{
	// Token: 0x06000797 RID: 1943 RVA: 0x0002659C File Offset: 0x0002479C
	[Token(Token = "0x6000797")]
	[Address(RVA = "0x6E65D0", Offset = "0x6E4BD0", VA = "0x1806E65D0", Slot = "25")]
	protected override void SetPenetrationTime()
	{
		this.maxHitCount = (int)((ulong)3L);
	}

	// Token: 0x06000798 RID: 1944 RVA: 0x000265B4 File Offset: 0x000247B4
	[Token(Token = "0x6000798")]
	[Address(RVA = "0x812590", Offset = "0x810B90", VA = "0x180812590", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		this.SetBullet(30f, (BulletMoveWay)((uint)5));
		this.SetBullet(-30f, (BulletMoveWay)((uint)5));
		this.SetBullet(90f, (BulletMoveWay)((uint)5));
		this.SetBullet(-90f, (BulletMoveWay)((uint)5));
	}

	// Token: 0x06000799 RID: 1945 RVA: 0x000265F8 File Offset: 0x000247F8
	[Token(Token = "0x6000799")]
	[Address(RVA = "0x812650", Offset = "0x810C50", VA = "0x180812650", Slot = "26")]
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

	// Token: 0x0600079A RID: 1946 RVA: 0x00026658 File Offset: 0x00024858
	[Token(Token = "0x600079A")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_starFume()
	{
	}
}
