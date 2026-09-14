using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006A4 RID: 1700
[Token(Token = "0x20006A4")]
public class GatlingBlackFootball : GatlingFootballZombie
{
	// Token: 0x0600206C RID: 8300 RVA: 0x000ABEFC File Offset: 0x000AA0FC
	[Token(Token = "0x600206C")]
	[Address(RVA = "0x5AC650", Offset = "0x5AAC50", VA = "0x1805AC650", Slot = "76")]
	protected override void AnimShoot()
	{
		Transform shoot = this.shoot;
		int num = 0;
		if (!(shoot == num))
		{
			Transform shoot2 = this.shoot;
			if (Lawnf.TravelDebuff((TravelDebuff)((uint)37)))
			{
			}
			CreateBullet instance = CreateBullet.Instance;
			Bullet bullet;
			bullet.Damage = 80;
			bullet.fromType = (PlantType)((ulong)268L);
		}
	}

	// Token: 0x0600206D RID: 8301 RVA: 0x000ABF5C File Offset: 0x000AA15C
	[Token(Token = "0x600206D")]
	[Address(RVA = "0x5AC820", Offset = "0x5AAE20", VA = "0x1805AC820", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return !Lawnf.TravelDebuff((TravelDebuff)((uint)36)) && base.CanAttack(target);
	}

	// Token: 0x0600206E RID: 8302 RVA: 0x000ABF80 File Offset: 0x000AA180
	[Token(Token = "0x600206E")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "73")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x0600206F RID: 8303 RVA: 0x000ABF90 File Offset: 0x000AA190
	[Token(Token = "0x600206F")]
	[Address(RVA = "0x5AC870", Offset = "0x5AAE70", VA = "0x1805AC870")]
	public GatlingBlackFootball()
	{
	}
}
