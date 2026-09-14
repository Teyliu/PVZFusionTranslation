using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000565 RID: 1381
[Token(Token = "0x2000565")]
public class SpruceBallista : Shooter
{
	// Token: 0x060019AE RID: 6574 RVA: 0x0008A900 File Offset: 0x00088B00
	[Token(Token = "0x60019AE")]
	[Address(RVA = "0x4E5840", Offset = "0x4E3E40", VA = "0x1804E5840", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_spruceBallista;
	}

	// Token: 0x060019AF RID: 6575 RVA: 0x0008A914 File Offset: 0x00088B14
	[Token(Token = "0x60019AF")]
	[Address(RVA = "0x4E5850", Offset = "0x4E3E50", VA = "0x1804E5850", Slot = "69")]
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

	// Token: 0x060019B0 RID: 6576 RVA: 0x0008A970 File Offset: 0x00088B70
	[Token(Token = "0x60019B0")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public SpruceBallista()
	{
	}
}
