using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005D4 RID: 1492
[Token(Token = "0x20005D4")]
public class Tower_cherryShooter : TowerPlant
{
	// Token: 0x06001BFD RID: 7165 RVA: 0x0009557C File Offset: 0x0009377C
	[Token(Token = "0x6001BFD")]
	[Address(RVA = "0x50E590", Offset = "0x50CB90", VA = "0x18050E590", Slot = "72")]
	public override void AnimShoot()
	{
		Transform shoot = this.shoot;
		Vector3 vector;
		float z = vector.z;
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		bullet.Damage = 9;
		bullet.rogueStatus = (int)((ulong)3L);
	}

	// Token: 0x06001BFE RID: 7166 RVA: 0x000955B8 File Offset: 0x000937B8
	[Token(Token = "0x6001BFE")]
	[Address(RVA = "0x50E6F0", Offset = "0x50CCF0", VA = "0x18050E6F0", Slot = "74")]
	public override void Upgrade(TowerUpgradeType towerUpgradeType)
	{
		float attackSpeed = this.attackSpeed;
		this.attackSpeed = attackSpeed;
		base.Upgrade(towerUpgradeType);
	}

	// Token: 0x06001BFF RID: 7167 RVA: 0x000955F4 File Offset: 0x000937F4
	[Token(Token = "0x6001BFF")]
	[Address(RVA = "0x50C640", Offset = "0x50AC40", VA = "0x18050C640")]
	public Tower_cherryShooter()
	{
		this.towards = (Towards)((ulong)1L);
		this.basicDamage = 1f;
		this.attackSpeed = 1f;
		base..ctor();
	}
}
