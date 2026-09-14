using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200062C RID: 1580
[Token(Token = "0x200062C")]
public class BlackFootballZombie_c2 : BlackFootballZombie_b
{
	// Token: 0x06001DE4 RID: 7652 RVA: 0x000A0270 File Offset: 0x0009E470
	[Token(Token = "0x6001DE4")]
	[Address(RVA = "0x531EB0", Offset = "0x5304B0", VA = "0x180531EB0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 0.1f;
	}

	// Token: 0x06001DE5 RID: 7653 RVA: 0x000A0290 File Offset: 0x0009E490
	[Token(Token = "0x6001DE5")]
	[Address(RVA = "0x531E10", Offset = "0x530410", VA = "0x180531E10", Slot = "23")]
	protected override void AttributeEvent()
	{
		float theSpeed = this.theSpeed;
		if (0 > (int)theSpeed || theSpeed > 1f)
		{
		}
		this.anim.SetTrigger("shoot");
	}

	// Token: 0x06001DE6 RID: 7654 RVA: 0x000A02CC File Offset: 0x0009E4CC
	[Token(Token = "0x6001DE6")]
	[Address(RVA = "0x531C60", Offset = "0x530260", VA = "0x180531C60")]
	private void AnimShoot()
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

	// Token: 0x06001DE7 RID: 7655 RVA: 0x000A0320 File Offset: 0x0009E520
	[Token(Token = "0x6001DE7")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "54")]
	public override void SetCold(float time, int coldLevel = 0, bool freeze = false)
	{
	}

	// Token: 0x06001DE8 RID: 7656 RVA: 0x000A0330 File Offset: 0x0009E530
	[Token(Token = "0x6001DE8")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "51")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
	}

	// Token: 0x06001DE9 RID: 7657 RVA: 0x000A0340 File Offset: 0x0009E540
	[Token(Token = "0x6001DE9")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "71")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x06001DEA RID: 7658 RVA: 0x000A0350 File Offset: 0x0009E550
	[Token(Token = "0x6001DEA")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "56")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
	}

	// Token: 0x06001DEB RID: 7659 RVA: 0x000A0360 File Offset: 0x0009E560
	[Token(Token = "0x6001DEB")]
	[Address(RVA = "0x531AE0", Offset = "0x5300E0", VA = "0x180531AE0")]
	public BlackFootballZombie_c2()
	{
	}
}
