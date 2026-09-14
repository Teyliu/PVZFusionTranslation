using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000609 RID: 1545
[Token(Token = "0x2000609")]
public class Tower_cherryShooter : TowerPlant
{
	// Token: 0x06001CFC RID: 7420 RVA: 0x0009A194 File Offset: 0x00098394
	[Token(Token = "0x6001CFC")]
	[Address(RVA = "0x55F7E0", Offset = "0x55DDE0", VA = "0x18055F7E0", Slot = "71")]
	public override void AnimShoot()
	{
		Transform shoot = this.shoot;
		Vector3 vector;
		float z = vector.z;
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		bullet.Damage = 6;
		bullet.rogueStatus = (int)((ulong)3L);
	}

	// Token: 0x06001CFD RID: 7421 RVA: 0x0009A1D0 File Offset: 0x000983D0
	[Token(Token = "0x6001CFD")]
	[Address(RVA = "0x55F940", Offset = "0x55DF40", VA = "0x18055F940", Slot = "73")]
	public override void Upgrade(TowerUpgradeType towerUpgradeType)
	{
		float attackSpeed = this.attackSpeed;
		this.attackSpeed = attackSpeed;
		base.Upgrade(towerUpgradeType);
	}

	// Token: 0x06001CFE RID: 7422 RVA: 0x0009A20C File Offset: 0x0009840C
	[Token(Token = "0x6001CFE")]
	[Address(RVA = "0x55D890", Offset = "0x55BE90", VA = "0x18055D890")]
	public Tower_cherryShooter()
	{
		this.towards = (Towards)((ulong)1L);
		this.basicDamage = 1f;
		this.attackSpeed = 1f;
		base..ctor();
	}
}
