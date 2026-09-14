using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007E1 RID: 2017
[Token(Token = "0x20007E1")]
public class Weapon_torch : PlayerWeapon
{
	// Token: 0x060028F9 RID: 10489 RVA: 0x000DD008 File Offset: 0x000DB208
	[Token(Token = "0x60028F9")]
	[Address(RVA = "0x67CEE0", Offset = "0x67B4E0", VA = "0x18067CEE0", Slot = "10")]
	protected override void Shoot()
	{
		uint num;
		uint num2;
		GameAPP.PlaySound(global::UnityEngine.Random.Range((int)num, (int)num2), 0.5f, 1f);
		Transform transform = base.transform;
		int num3 = 0;
		Vector3 vector;
		float z = vector.z;
		int num4 = this.shootCount;
		num4++;
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.GetBulletType();
		int num5 = 0;
		int attackDamage = base.AttackDamage;
		Player player = this.player;
		Bullet bullet;
		bullet.Damage = num5;
		bullet.fromType = (PlantType)((ulong)18L);
		Transform transform2 = bullet.transform;
		num3++;
	}

	// Token: 0x060028FA RID: 10490 RVA: 0x000DD098 File Offset: 0x000DB298
	[Token(Token = "0x60028FA")]
	[Address(RVA = "0x67CEC0", Offset = "0x67B4C0", VA = "0x18067CEC0", Slot = "11")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_firePea_yellow;
	}

	// Token: 0x060028FB RID: 10491 RVA: 0x000DD0A8 File Offset: 0x000DB2A8
	[Token(Token = "0x60028FB")]
	[Address(RVA = "0x677BA0", Offset = "0x6761A0", VA = "0x180677BA0")]
	public Weapon_torch()
	{
	}
}
