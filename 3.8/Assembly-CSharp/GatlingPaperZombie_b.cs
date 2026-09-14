using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000671 RID: 1649
[Token(Token = "0x2000671")]
public class GatlingPaperZombie_b : GatlingPaperZombie_a
{
	// Token: 0x06001F81 RID: 8065 RVA: 0x000A7AB4 File Offset: 0x000A5CB4
	[Token(Token = "0x6001F81")]
	[Address(RVA = "0x54AEC0", Offset = "0x5494C0", VA = "0x18054AEC0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (ZombieStatus)((ulong)4L);
		this.attributeCountDown = 1.5f;
	}

	// Token: 0x06001F82 RID: 8066 RVA: 0x000A7ADC File Offset: 0x000A5CDC
	[Token(Token = "0x6001F82")]
	[Address(RVA = "0x54AE50", Offset = "0x549450", VA = "0x18054AE50", Slot = "23")]
	protected override void AttributeEvent()
	{
		this.anim.SetTrigger("shoot");
		this.attributeCountDown = 1.5f;
	}

	// Token: 0x06001F83 RID: 8067 RVA: 0x000A7B18 File Offset: 0x000A5D18
	[Token(Token = "0x6001F83")]
	[Address(RVA = "0x54ACD0", Offset = "0x5492D0", VA = "0x18054ACD0", Slot = "74")]
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

	// Token: 0x06001F84 RID: 8068 RVA: 0x000A7B5C File Offset: 0x000A5D5C
	[Token(Token = "0x6001F84")]
	[Address(RVA = "0x54AC80", Offset = "0x549280", VA = "0x18054AC80")]
	public GatlingPaperZombie_b()
	{
	}
}
