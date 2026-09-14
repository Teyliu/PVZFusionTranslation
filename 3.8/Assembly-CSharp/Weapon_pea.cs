using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007A2 RID: 1954
[Token(Token = "0x20007A2")]
public class Weapon_pea : PlayerWeapon
{
	// Token: 0x060027B6 RID: 10166 RVA: 0x000D7850 File Offset: 0x000D5A50
	[Token(Token = "0x60027B6")]
	[Address(RVA = "0x6176D0", Offset = "0x615CD0", VA = "0x1806176D0", Slot = "11")]
	protected override BulletType GetBulletType()
	{
		int evolution = this.evolution;
		return BulletType.Bullet_pea;
	}

	// Token: 0x060027B7 RID: 10167 RVA: 0x000D7870 File Offset: 0x000D5A70
	[Token(Token = "0x60027B7")]
	[Address(RVA = "0x6176E0", Offset = "0x615CE0", VA = "0x1806176E0", Slot = "10")]
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

	// Token: 0x060027B8 RID: 10168 RVA: 0x000D7938 File Offset: 0x000D5B38
	[Token(Token = "0x60027B8")]
	[Address(RVA = "0x614310", Offset = "0x612910", VA = "0x180614310")]
	public Weapon_pea()
	{
	}
}
