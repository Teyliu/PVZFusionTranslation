using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003F6 RID: 1014
[Token(Token = "0x20003F6")]
public class PassionFruit : Shooter
{
	// Token: 0x060012B3 RID: 4787 RVA: 0x0006928C File Offset: 0x0006748C
	[Token(Token = "0x60012B3")]
	[Address(RVA = "0x459610", Offset = "0x457C10", VA = "0x180459610", Slot = "69")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		return bullet;
	}

	// Token: 0x060012B4 RID: 4788 RVA: 0x000692D4 File Offset: 0x000674D4
	[Token(Token = "0x60012B4")]
	[Address(RVA = "0x4594E0", Offset = "0x457AE0", VA = "0x1804594E0", Slot = "42")]
	protected override void AnimSuperShoot()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		bullet.theStatus = (BulletStatus)((ulong)5L);
	}

	// Token: 0x060012B5 RID: 4789 RVA: 0x00069324 File Offset: 0x00067524
	[Token(Token = "0x60012B5")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public PassionFruit()
	{
	}
}
