using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000452 RID: 1106
[Token(Token = "0x2000452")]
public class StarNut : WallNut
{
	// Token: 0x06001465 RID: 5221 RVA: 0x00071914 File Offset: 0x0006FB14
	[Token(Token = "0x6001465")]
	[Address(RVA = "0x4C6CE0", Offset = "0x4C52E0", VA = "0x1804C6CE0", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		this.SetBullet((BulletMoveWay)((uint)5), 30f);
		this.SetBullet((BulletMoveWay)((uint)5), -30f);
		this.SetBullet((BulletMoveWay)((uint)6), 180f);
		this.SetBullet((BulletMoveWay)((uint)5), 90f);
		this.SetBullet((BulletMoveWay)((uint)5), -90f);
	}

	// Token: 0x06001466 RID: 5222 RVA: 0x00071964 File Offset: 0x0006FB64
	[Token(Token = "0x6001466")]
	[Address(RVA = "0x4C6B90", Offset = "0x4C5190", VA = "0x1804C6B90")]
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

	// Token: 0x06001467 RID: 5223 RVA: 0x000719B4 File Offset: 0x0006FBB4
	[Token(Token = "0x6001467")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public StarNut()
	{
	}
}
