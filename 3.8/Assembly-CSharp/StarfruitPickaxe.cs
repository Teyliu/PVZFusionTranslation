using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200056F RID: 1391
[Token(Token = "0x200056F")]
public class StarfruitPickaxe : StarFruit
{
	// Token: 0x060019C8 RID: 6600 RVA: 0x0008AF80 File Offset: 0x00089180
	[Token(Token = "0x60019C8")]
	[Address(RVA = "0x4E80C0", Offset = "0x4E66C0", VA = "0x1804E80C0", Slot = "73")]
	protected override void SetBullet(Transform _transform, BulletMoveWay theMovingWay)
	{
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		Transform transform = bullet.transform;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
	}

	// Token: 0x060019C9 RID: 6601 RVA: 0x0008AFC8 File Offset: 0x000891C8
	[Token(Token = "0x60019C9")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x060019CA RID: 6602 RVA: 0x0008AFD8 File Offset: 0x000891D8
	[Token(Token = "0x60019CA")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public StarfruitPickaxe()
	{
	}
}
