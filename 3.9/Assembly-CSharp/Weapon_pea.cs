using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007DB RID: 2011
[Token(Token = "0x20007DB")]
public class Weapon_pea : PlayerWeapon
{
	// Token: 0x060028E5 RID: 10469 RVA: 0x000DC80C File Offset: 0x000DAA0C
	[Token(Token = "0x60028E5")]
	[Address(RVA = "0x67AF60", Offset = "0x679560", VA = "0x18067AF60", Slot = "11")]
	protected override BulletType GetBulletType()
	{
		int evolution = this.evolution;
		return BulletType.Bullet_pea;
	}

	// Token: 0x060028E6 RID: 10470 RVA: 0x000DC82C File Offset: 0x000DAA2C
	[Token(Token = "0x60028E6")]
	[Address(RVA = "0x67AF70", Offset = "0x679570", VA = "0x18067AF70", Slot = "10")]
	protected override void Shoot()
	{
		uint num;
		uint num2;
		GameAPP.PlaySound(global::UnityEngine.Random.Range((int)num, (int)num2), 0.5f, 1f);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.GetBulletType();
		int num3 = 0;
		int attackDamage = base.AttackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		bullet.fromType = (PlantType)num3;
		Transform transform2 = bullet.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		if (attackDamage != 1)
		{
		}
		uint num5;
		uint num4 = num5 + 1U;
		num4 -= (uint)attackDamage;
		CreateBullet instance2 = CreateBullet.Instance;
		BulletType bulletType2 = this.GetBulletType();
		Bullet bullet2;
		Transform transform3 = bullet2.transform;
		Vector3 vector3;
		float z3 = vector3.z;
		Transform transform4 = bullet2.transform;
		Vector3 vector4;
		float z4 = vector4.z;
		num5 += (uint)1;
	}

	// Token: 0x060028E7 RID: 10471 RVA: 0x000DC8F4 File Offset: 0x000DAAF4
	[Token(Token = "0x60028E7")]
	[Address(RVA = "0x677BA0", Offset = "0x6761A0", VA = "0x180677BA0")]
	public Weapon_pea()
	{
	}
}
