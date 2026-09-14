using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200060E RID: 1550
[Token(Token = "0x200060E")]
public class Tower_peasunflower : TowerPlant
{
	// Token: 0x06001D1A RID: 7450 RVA: 0x0009ACEC File Offset: 0x00098EEC
	[Token(Token = "0x6001D1A")]
	[Address(RVA = "0x578B00", Offset = "0x577100", VA = "0x180578B00", Slot = "71")]
	public override void AnimShoot()
	{
		Transform shoot = this.shoot;
		Vector3 vector;
		float z = vector.z;
		CreateBullet instance = CreateBullet.Instance;
		int damage = base.Damage;
		Bullet bullet;
		bullet.Damage = damage;
		GameAPP.PlaySound(damage, 0.5f, 1f);
		int num = this.attributeCount;
		num++;
		this.attributeCount = num;
		if (num == 3)
		{
			this.attributeCount = (int)((ulong)0L);
			bullet.theStatus = (BulletStatus)num;
		}
	}

	// Token: 0x06001D1B RID: 7451 RVA: 0x0009AD64 File Offset: 0x00098F64
	[Token(Token = "0x6001D1B")]
	[Address(RVA = "0x578C70", Offset = "0x577270", VA = "0x180578C70", Slot = "73")]
	public override void Upgrade(TowerUpgradeType towerUpgradeType)
	{
		float basicDamage = this.basicDamage;
		this.basicDamage = basicDamage;
		base.Upgrade(towerUpgradeType);
	}

	// Token: 0x06001D1C RID: 7452 RVA: 0x0009ADAC File Offset: 0x00098FAC
	[Token(Token = "0x6001D1C")]
	[Address(RVA = "0x578AF0", Offset = "0x5770F0", VA = "0x180578AF0")]
	public Tower_peasunflower()
	{
	}
}
