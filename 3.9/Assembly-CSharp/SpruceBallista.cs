using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000595 RID: 1429
[Token(Token = "0x2000595")]
public class SpruceBallista : Shooter
{
	// Token: 0x06001A8E RID: 6798 RVA: 0x0008E9B4 File Offset: 0x0008CBB4
	[Token(Token = "0x6001A8E")]
	[Address(RVA = "0x543CB0", Offset = "0x5422B0", VA = "0x180543CB0", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_spruceBallista;
	}

	// Token: 0x06001A8F RID: 6799 RVA: 0x0008E9C8 File Offset: 0x0008CBC8
	[Token(Token = "0x6001A8F")]
	[Address(RVA = "0x543CC0", Offset = "0x5422C0", VA = "0x180543CC0", Slot = "68")]
	protected override Bullet Shoot1()
	{
		CreateBullet instance = CreateBullet.Instance;
		Transform shoot = this.shoot;
		Transform shoot2 = this.shoot;
		Bullet bullet;
		bullet.normalSpeed = 12f;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		return bullet;
	}

	// Token: 0x06001A90 RID: 6800 RVA: 0x0008EA24 File Offset: 0x0008CC24
	[Token(Token = "0x6001A90")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public SpruceBallista()
	{
	}
}
