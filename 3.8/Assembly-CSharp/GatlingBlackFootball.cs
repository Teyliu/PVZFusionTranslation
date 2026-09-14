using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200066E RID: 1646
[Token(Token = "0x200066E")]
public class GatlingBlackFootball : GatlingFootballZombie
{
	// Token: 0x06001F6B RID: 8043 RVA: 0x000A7654 File Offset: 0x000A5854
	[Token(Token = "0x6001F6B")]
	[Address(RVA = "0x54A040", Offset = "0x548640", VA = "0x18054A040", Slot = "74")]
	protected override void AnimShoot()
	{
		Transform shoot = this.shoot;
		int num = 0;
		if (!(shoot == num))
		{
			Transform shoot2 = this.shoot;
			CreateBullet instance = CreateBullet.Instance;
			Bullet bullet;
			bullet.Damage = 80;
			bullet.fromType = (PlantType)((ulong)268L);
		}
	}

	// Token: 0x06001F6C RID: 8044 RVA: 0x000A76A8 File Offset: 0x000A58A8
	[Token(Token = "0x6001F6C")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "71")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x06001F6D RID: 8045 RVA: 0x000A76B8 File Offset: 0x000A58B8
	[Token(Token = "0x6001F6D")]
	[Address(RVA = "0x54A1F0", Offset = "0x5487F0", VA = "0x18054A1F0")]
	public GatlingBlackFootball()
	{
	}
}
