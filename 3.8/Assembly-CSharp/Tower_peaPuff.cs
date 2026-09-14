using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005D8 RID: 1496
[Token(Token = "0x20005D8")]
public class Tower_peaPuff : TowerPlant
{
	// Token: 0x06001C17 RID: 7191 RVA: 0x00096050 File Offset: 0x00094250
	[Token(Token = "0x6001C17")]
	[Address(RVA = "0x510F90", Offset = "0x50F590", VA = "0x180510F90", Slot = "72")]
	public override void AnimShoot()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		bullet.Damage = 9;
	}

	// Token: 0x06001C18 RID: 7192 RVA: 0x0009607C File Offset: 0x0009427C
	[Token(Token = "0x6001C18")]
	[Address(RVA = "0x5110D0", Offset = "0x50F6D0", VA = "0x1805110D0")]
	private BulletType GetBulletType()
	{
		return BulletType.Bullet_firePea_small;
	}

	// Token: 0x06001C19 RID: 7193 RVA: 0x0009608C File Offset: 0x0009428C
	[Token(Token = "0x6001C19")]
	[Address(RVA = "0x5110F0", Offset = "0x50F6F0", VA = "0x1805110F0", Slot = "74")]
	public override void Upgrade(TowerUpgradeType towerUpgradeType)
	{
		float basicDamage = this.basicDamage;
		this.basicDamage = basicDamage;
		base.Upgrade(towerUpgradeType);
	}

	// Token: 0x06001C1A RID: 7194 RVA: 0x000960B0 File Offset: 0x000942B0
	[Token(Token = "0x6001C1A")]
	[Address(RVA = "0x50C640", Offset = "0x50AC40", VA = "0x18050C640")]
	public Tower_peaPuff()
	{
		this.towards = (Towards)((ulong)1L);
		this.basicDamage = 1f;
		this.attackSpeed = 1f;
		base..ctor();
	}
}
