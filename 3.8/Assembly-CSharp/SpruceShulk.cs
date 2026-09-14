using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000567 RID: 1383
[Token(Token = "0x2000567")]
public class SpruceShulk : Shooter
{
	// Token: 0x060019B4 RID: 6580 RVA: 0x0008AA70 File Offset: 0x00088C70
	[Token(Token = "0x60019B4")]
	[Address(RVA = "0x4E5D30", Offset = "0x4E4330", VA = "0x1804E5D30", Slot = "69")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		float normalSpeed = bullet.normalSpeed;
		bullet.normalSpeed = normalSpeed;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		return bullet;
	}

	// Token: 0x060019B5 RID: 6581 RVA: 0x0008AACC File Offset: 0x00088CCC
	[Token(Token = "0x60019B5")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public SpruceShulk()
	{
	}
}
