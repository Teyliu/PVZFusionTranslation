using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006AD RID: 1709
[Token(Token = "0x20006AD")]
public class PeaDolphinriderZombie : SnowDolphinrider
{
	// Token: 0x06002157 RID: 8535 RVA: 0x000AFE48 File Offset: 0x000AE048
	[Token(Token = "0x6002157")]
	[Address(RVA = "0x5644D0", Offset = "0x562AD0", VA = "0x1805644D0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 0.75f;
	}

	// Token: 0x06002158 RID: 8536 RVA: 0x000AFE68 File Offset: 0x000AE068
	[Token(Token = "0x6002158")]
	[Address(RVA = "0x564460", Offset = "0x562A60", VA = "0x180564460", Slot = "23")]
	protected override void AttributeEvent()
	{
		base.JumpFail();
		this.anim.SetTrigger("shoot");
		this.attributeCountDown = 0.75f;
	}

	// Token: 0x06002159 RID: 8537 RVA: 0x000AFEA0 File Offset: 0x000AE0A0
	[Token(Token = "0x6002159")]
	[Address(RVA = "0x564280", Offset = "0x562880", VA = "0x180564280")]
	private void AnimShoot()
	{
		Transform transform = base.transform.Find("Shoot");
		int bulletType = (int)this.GetBulletType();
		CreateBullet instance = CreateBullet.Instance;
		CreateBullet instance2 = CreateBullet.Instance;
		int damage = this.GetDamage();
		Bullet bullet;
		bullet.Damage = damage;
		GameAPP.PlaySound(damage, 0.5f, 1f);
	}

	// Token: 0x0600215A RID: 8538 RVA: 0x000AFF04 File Offset: 0x000AE104
	[Token(Token = "0x600215A")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "76")]
	protected virtual int GetDamage()
	{
		return 20;
	}

	// Token: 0x0600215B RID: 8539 RVA: 0x000AFF14 File Offset: 0x000AE114
	[Token(Token = "0x600215B")]
	[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "77")]
	protected virtual BulletType GetBulletType()
	{
		return BulletType.Bullet_pea;
	}

	// Token: 0x0600215C RID: 8540 RVA: 0x000AFF2C File Offset: 0x000AE12C
	[Token(Token = "0x600215C")]
	[Address(RVA = "0x564500", Offset = "0x562B00", VA = "0x180564500")]
	public PeaDolphinriderZombie()
	{
	}
}
