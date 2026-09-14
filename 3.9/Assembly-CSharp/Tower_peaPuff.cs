using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200060D RID: 1549
[Token(Token = "0x200060D")]
public class Tower_peaPuff : TowerPlant
{
	// Token: 0x06001D16 RID: 7446 RVA: 0x0009AC60 File Offset: 0x00098E60
	[Token(Token = "0x6001D16")]
	[Address(RVA = "0x578930", Offset = "0x576F30", VA = "0x180578930", Slot = "71")]
	public override void AnimShoot()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		int damage = base.Damage;
		Bullet bullet;
		bullet.Damage = damage;
		GameAPP.PlaySound(damage, 0.5f, 1f);
	}

	// Token: 0x06001D17 RID: 7447 RVA: 0x0009ACA4 File Offset: 0x00098EA4
	[Token(Token = "0x6001D17")]
	[Address(RVA = "0x578A70", Offset = "0x577070", VA = "0x180578A70")]
	private BulletType GetBulletType()
	{
		return BulletType.Bullet_firePea_small;
	}

	// Token: 0x06001D18 RID: 7448 RVA: 0x0009ACB4 File Offset: 0x00098EB4
	[Token(Token = "0x6001D18")]
	[Address(RVA = "0x578A90", Offset = "0x577090", VA = "0x180578A90", Slot = "73")]
	public override void Upgrade(TowerUpgradeType towerUpgradeType)
	{
		float basicDamage = this.basicDamage;
		this.basicDamage = basicDamage;
		base.Upgrade(towerUpgradeType);
	}

	// Token: 0x06001D19 RID: 7449 RVA: 0x0009ACD8 File Offset: 0x00098ED8
	[Token(Token = "0x6001D19")]
	[Address(RVA = "0x578AF0", Offset = "0x5770F0", VA = "0x180578AF0")]
	public Tower_peaPuff()
	{
	}
}
