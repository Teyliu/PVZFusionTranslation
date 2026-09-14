using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000433 RID: 1075
[Token(Token = "0x2000433")]
public class StarNut : WallNut
{
	// Token: 0x060013DB RID: 5083 RVA: 0x0006F668 File Offset: 0x0006D868
	[Token(Token = "0x60013DB")]
	[Address(RVA = "0x46F490", Offset = "0x46DA90", VA = "0x18046F490", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		this.SetBullet((BulletMoveWay)((uint)2), 30f);
		this.SetBullet((BulletMoveWay)((uint)2), -30f);
		this.SetBullet((BulletMoveWay)((uint)9), 180f);
		this.SetBullet((BulletMoveWay)((uint)2), 90f);
		this.SetBullet((BulletMoveWay)((uint)2), -90f);
	}

	// Token: 0x060013DC RID: 5084 RVA: 0x0006F6B8 File Offset: 0x0006D8B8
	[Token(Token = "0x60013DC")]
	[Address(RVA = "0x46F340", Offset = "0x46D940", VA = "0x18046F340")]
	private void SetBullet(BulletMoveWay theMovingWay, float angle)
	{
		Transform shoot = this.shoot;
		Vector3 vector;
		float z = vector.z;
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		Transform transform = bullet.transform;
		float num = angle * 0.017453292f;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
	}

	// Token: 0x060013DD RID: 5085 RVA: 0x0006F708 File Offset: 0x0006D908
	[Token(Token = "0x60013DD")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public StarNut()
	{
	}
}
