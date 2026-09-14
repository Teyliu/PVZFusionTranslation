using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007DC RID: 2012
[Token(Token = "0x20007DC")]
public class Weapon_puff : PlayerWeapon
{
	// Token: 0x060028E8 RID: 10472 RVA: 0x000DC908 File Offset: 0x000DAB08
	[Token(Token = "0x60028E8")]
	[Address(RVA = "0x67B3C0", Offset = "0x6799C0", VA = "0x18067B3C0", Slot = "11")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_puffLove;
	}

	// Token: 0x060028E9 RID: 10473 RVA: 0x000DC918 File Offset: 0x000DAB18
	[Token(Token = "0x60028E9")]
	[Address(RVA = "0x67B3E0", Offset = "0x6799E0", VA = "0x18067B3E0", Slot = "10")]
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

	// Token: 0x060028EA RID: 10474 RVA: 0x000DC9DC File Offset: 0x000DABDC
	[Token(Token = "0x60028EA")]
	[Address(RVA = "0x677BA0", Offset = "0x6761A0", VA = "0x180677BA0")]
	public Weapon_puff()
	{
	}
}
