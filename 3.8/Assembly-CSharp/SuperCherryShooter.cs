using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000579 RID: 1401
[Token(Token = "0x2000579")]
public class SuperCherryShooter : Shooter
{
	// Token: 0x060019E5 RID: 6629 RVA: 0x0008B740 File Offset: 0x00089940
	[Token(Token = "0x60019E5")]
	[Address(RVA = "0x4E87F0", Offset = "0x4E6DF0", VA = "0x1804E87F0", Slot = "69")]
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

	// Token: 0x060019E6 RID: 6630 RVA: 0x0008B788 File Offset: 0x00089988
	[Token(Token = "0x60019E6")]
	[Address(RVA = "0x4E8920", Offset = "0x4E6F20", VA = "0x1804E8920", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		if (damageType != DamageType.CherryExplode)
		{
			return;
		}
	}

	// Token: 0x060019E7 RID: 6631 RVA: 0x0008B79C File Offset: 0x0008999C
	[Token(Token = "0x60019E7")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public SuperCherryShooter()
	{
	}
}
