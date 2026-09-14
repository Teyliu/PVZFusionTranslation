using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020006A8 RID: 1704
[Token(Token = "0x20006A8")]
public class GatlingPaperZombie_c : GatlingPaperZombie_b
{
	// Token: 0x06002087 RID: 8327 RVA: 0x000AC448 File Offset: 0x000AA648
	[Token(Token = "0x6002087")]
	[Address(RVA = "0x5AD710", Offset = "0x5ABD10", VA = "0x1805AD710", Slot = "24")]
	protected override void AttributeEvent()
	{
		this.anim.SetTrigger("shoot");
		this.anim.SetTrigger("shoot2");
	}

	// Token: 0x06002088 RID: 8328 RVA: 0x000AC480 File Offset: 0x000AA680
	[Token(Token = "0x6002088")]
	[Address(RVA = "0x5AD7C0", Offset = "0x5ABDC0", VA = "0x1805AD7C0")]
	private void TakeGun()
	{
		this.gun.sortingOrder = 25;
	}

	// Token: 0x06002089 RID: 8329 RVA: 0x000AC4A0 File Offset: 0x000AA6A0
	[Token(Token = "0x6002089")]
	[Address(RVA = "0x5AD570", Offset = "0x5ABB70", VA = "0x1805AD570")]
	private void AnimShootGun()
	{
		Towards towards = this.towards;
		Transform transform = this.shoot_gun;
		CreateBullet instance = CreateBullet.Instance;
		Transform transform2 = this.shoot_gun;
		Bullet bullet;
		bullet.Damage = 1800;
		bullet.theStatus = (BulletStatus)((uint)6);
		bullet.shootByZombie = true;
	}

	// Token: 0x0600208A RID: 8330 RVA: 0x000AC4F0 File Offset: 0x000AA6F0
	[Token(Token = "0x600208A")]
	[Address(RVA = "0x5AD300", Offset = "0x5AB900", VA = "0x1805AD300")]
	public GatlingPaperZombie_c()
	{
	}

	// Token: 0x04001156 RID: 4438
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x4001156")]
	public SortingGroup gun;

	// Token: 0x04001157 RID: 4439
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x4001157")]
	public Transform shoot_gun;
}
