using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007A3 RID: 1955
[Token(Token = "0x20007A3")]
public class Weapon_puff : PlayerWeapon
{
	// Token: 0x060027B9 RID: 10169 RVA: 0x000D794C File Offset: 0x000D5B4C
	[Token(Token = "0x60027B9")]
	[Address(RVA = "0x617B20", Offset = "0x616120", VA = "0x180617B20", Slot = "11")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_puffLove;
	}

	// Token: 0x060027BA RID: 10170 RVA: 0x000D795C File Offset: 0x000D5B5C
	[Token(Token = "0x60027BA")]
	[Address(RVA = "0x617B40", Offset = "0x616140", VA = "0x180617B40", Slot = "10")]
	protected override void Shoot()
	{
		uint num;
		GameAPP.PlaySound((int)num, 0.5f, 1f);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.GetBulletType();
		Bullet bullet;
		bullet.fromType = (PlantType)((ulong)9L);
		int attackDamage = base.AttackDamage;
		bullet.Damage = attackDamage;
		Transform transform2 = bullet.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		if (attackDamage != 1)
		{
		}
		uint num3;
		uint num2 = num3 + 1U;
		num2 -= (uint)attackDamage;
		CreateBullet instance2 = CreateBullet.Instance;
		BulletType bulletType2 = this.GetBulletType();
		Bullet bullet2;
		Transform transform3 = bullet2.transform;
		Vector3 vector3;
		float z3 = vector3.z;
		Transform transform4 = bullet2.transform;
		Vector3 vector4;
		float z4 = vector4.z;
		num3 += (uint)1;
	}

	// Token: 0x060027BB RID: 10171 RVA: 0x000D7A20 File Offset: 0x000D5C20
	[Token(Token = "0x60027BB")]
	[Address(RVA = "0x614310", Offset = "0x612910", VA = "0x180614310")]
	public Weapon_puff()
	{
	}
}
