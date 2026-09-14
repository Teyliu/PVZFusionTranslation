using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000410 RID: 1040
[Token(Token = "0x2000410")]
public class PassionFruit : Shooter
{
	// Token: 0x06001326 RID: 4902 RVA: 0x0006B01C File Offset: 0x0006921C
	[Token(Token = "0x6001326")]
	[Address(RVA = "0x4AD9F0", Offset = "0x4ABFF0", VA = "0x1804AD9F0", Slot = "68")]
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

	// Token: 0x06001327 RID: 4903 RVA: 0x0006B064 File Offset: 0x00069264
	[Token(Token = "0x6001327")]
	[Address(RVA = "0x4AD8C0", Offset = "0x4ABEC0", VA = "0x1804AD8C0", Slot = "41")]
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

	// Token: 0x06001328 RID: 4904 RVA: 0x0006B0B4 File Offset: 0x000692B4
	[Token(Token = "0x6001328")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public PassionFruit()
	{
	}
}
