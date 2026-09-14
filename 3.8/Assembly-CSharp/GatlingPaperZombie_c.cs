using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000672 RID: 1650
[Token(Token = "0x2000672")]
public class GatlingPaperZombie_c : GatlingPaperZombie_b
{
	// Token: 0x06001F85 RID: 8069 RVA: 0x000A7B70 File Offset: 0x000A5D70
	[Token(Token = "0x6001F85")]
	[Address(RVA = "0x54B080", Offset = "0x549680", VA = "0x18054B080", Slot = "23")]
	protected override void AttributeEvent()
	{
		this.anim.SetTrigger("shoot");
		this.anim.SetTrigger("shoot2");
	}

	// Token: 0x06001F86 RID: 8070 RVA: 0x000A7BA8 File Offset: 0x000A5DA8
	[Token(Token = "0x6001F86")]
	[Address(RVA = "0x54B130", Offset = "0x549730", VA = "0x18054B130")]
	private void TakeGun()
	{
		this.gun.sortingOrder = 25;
	}

	// Token: 0x06001F87 RID: 8071 RVA: 0x000A7BC8 File Offset: 0x000A5DC8
	[Token(Token = "0x6001F87")]
	[Address(RVA = "0x54AEF0", Offset = "0x5494F0", VA = "0x18054AEF0")]
	private void AnimShootGun()
	{
		Towards towards = this.towards;
		Transform transform = this.shoot_gun;
		CreateBullet instance = CreateBullet.Instance;
		Transform transform2 = this.shoot_gun;
		Bullet bullet;
		bullet.Damage = 1800;
		bullet.theStatus = (BulletStatus)((ulong)6L);
		bullet.shootByZombie = true;
	}

	// Token: 0x06001F88 RID: 8072 RVA: 0x000A7C18 File Offset: 0x000A5E18
	[Token(Token = "0x6001F88")]
	[Address(RVA = "0x54AC80", Offset = "0x549280", VA = "0x18054AC80")]
	public GatlingPaperZombie_c()
	{
	}

	// Token: 0x04001089 RID: 4233
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x4001089")]
	public SortingGroup gun;

	// Token: 0x0400108A RID: 4234
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x400108A")]
	public Transform shoot_gun;
}
