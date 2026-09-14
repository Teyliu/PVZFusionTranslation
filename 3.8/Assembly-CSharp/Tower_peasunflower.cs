using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005D9 RID: 1497
[Token(Token = "0x20005D9")]
public class Tower_peasunflower : TowerPlant
{
	// Token: 0x06001C1B RID: 7195 RVA: 0x000960E4 File Offset: 0x000942E4
	[Token(Token = "0x6001C1B")]
	[Address(RVA = "0x511150", Offset = "0x50F750", VA = "0x180511150", Slot = "72")]
	public override void AnimShoot()
	{
		Transform shoot = this.shoot;
		Vector3 vector;
		float z = vector.z;
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		bullet.Damage = 9;
		int num = this.attributeCount;
		num++;
		this.attributeCount = num;
		if (num == 3)
		{
			this.attributeCount = (int)((ulong)0L);
			bullet.theStatus = (BulletStatus)num;
		}
	}

	// Token: 0x06001C1C RID: 7196 RVA: 0x00096144 File Offset: 0x00094344
	[Token(Token = "0x6001C1C")]
	[Address(RVA = "0x5112C0", Offset = "0x50F8C0", VA = "0x1805112C0", Slot = "74")]
	public override void Upgrade(TowerUpgradeType towerUpgradeType)
	{
		float basicDamage = this.basicDamage;
		this.basicDamage = basicDamage;
		base.Upgrade(towerUpgradeType);
	}

	// Token: 0x06001C1D RID: 7197 RVA: 0x0009618C File Offset: 0x0009438C
	[Token(Token = "0x6001C1D")]
	[Address(RVA = "0x50C640", Offset = "0x50AC40", VA = "0x18050C640")]
	public Tower_peasunflower()
	{
		this.towards = (Towards)((ulong)1L);
		this.basicDamage = 1f;
		this.attackSpeed = 1f;
		base..ctor();
	}
}
