using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006E4 RID: 1764
[Token(Token = "0x20006E4")]
public class PeaDolphinriderZombie : SnowDolphinrider
{
	// Token: 0x0600226E RID: 8814 RVA: 0x000B4AF0 File Offset: 0x000B2CF0
	[Token(Token = "0x600226E")]
	[Address(RVA = "0x5C7D80", Offset = "0x5C6380", VA = "0x1805C7D80", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 0.75f;
	}

	// Token: 0x0600226F RID: 8815 RVA: 0x000B4B10 File Offset: 0x000B2D10
	[Token(Token = "0x600226F")]
	[Address(RVA = "0x5C7D10", Offset = "0x5C6310", VA = "0x1805C7D10", Slot = "24")]
	protected override void AttributeEvent()
	{
		base.JumpFail();
		this.anim.SetTrigger("shoot");
		this.attributeCountDown = 0.75f;
	}

	// Token: 0x06002270 RID: 8816 RVA: 0x000B4B48 File Offset: 0x000B2D48
	[Token(Token = "0x6002270")]
	[Address(RVA = "0x5C7B30", Offset = "0x5C6130", VA = "0x1805C7B30")]
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

	// Token: 0x06002271 RID: 8817 RVA: 0x000B4BAC File Offset: 0x000B2DAC
	[Token(Token = "0x6002271")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "78")]
	protected virtual int GetDamage()
	{
		return 20;
	}

	// Token: 0x06002272 RID: 8818 RVA: 0x000B4BBC File Offset: 0x000B2DBC
	[Token(Token = "0x6002272")]
	[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "79")]
	protected virtual BulletType GetBulletType()
	{
		return BulletType.Bullet_pea;
	}

	// Token: 0x06002273 RID: 8819 RVA: 0x000B4BD4 File Offset: 0x000B2DD4
	[Token(Token = "0x6002273")]
	[Address(RVA = "0x5C7DB0", Offset = "0x5C63B0", VA = "0x1805C7DB0")]
	public PeaDolphinriderZombie()
	{
	}
}
