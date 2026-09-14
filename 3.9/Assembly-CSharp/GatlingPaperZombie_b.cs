using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006A7 RID: 1703
[Token(Token = "0x20006A7")]
public class GatlingPaperZombie_b : GatlingPaperZombie_a
{
	// Token: 0x06002083 RID: 8323 RVA: 0x000AC38C File Offset: 0x000AA58C
	[Token(Token = "0x6002083")]
	[Address(RVA = "0x5AD540", Offset = "0x5ABB40", VA = "0x1805AD540", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (ZombieStatus)((ulong)4L);
		this.attributeCountDown = 1.5f;
	}

	// Token: 0x06002084 RID: 8324 RVA: 0x000AC3B4 File Offset: 0x000AA5B4
	[Token(Token = "0x6002084")]
	[Address(RVA = "0x5AD4D0", Offset = "0x5ABAD0", VA = "0x1805AD4D0", Slot = "24")]
	protected override void AttributeEvent()
	{
		this.anim.SetTrigger("shoot");
		this.attributeCountDown = 1.5f;
	}

	// Token: 0x06002085 RID: 8325 RVA: 0x000AC3F0 File Offset: 0x000AA5F0
	[Token(Token = "0x6002085")]
	[Address(RVA = "0x5AD350", Offset = "0x5AB950", VA = "0x1805AD350", Slot = "76")]
	protected override void AnimShoot()
	{
		Towards towards = this.towards;
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		Transform shoot2 = this.shoot;
		Bullet bullet;
		bullet.Damage = 1000;
		bullet.shootByZombie = true;
	}

	// Token: 0x06002086 RID: 8326 RVA: 0x000AC434 File Offset: 0x000AA634
	[Token(Token = "0x6002086")]
	[Address(RVA = "0x5AD300", Offset = "0x5AB900", VA = "0x1805AD300")]
	public GatlingPaperZombie_b()
	{
	}
}
