using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006AE RID: 1710
[Token(Token = "0x20006AE")]
public class PeaShooterZ : Zombie
{
	// Token: 0x0600215D RID: 8541 RVA: 0x000AFF40 File Offset: 0x000AE140
	[Token(Token = "0x600215D")]
	[Address(RVA = "0x564790", Offset = "0x562D90", VA = "0x180564790", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		float num = global::UnityEngine.Random.Range(0.5f, 1.5f);
		this.attributeCountDown = num;
	}

	// Token: 0x0600215E RID: 8542 RVA: 0x000AFF6C File Offset: 0x000AE16C
	[Token(Token = "0x600215E")]
	[Address(RVA = "0x5646E0", Offset = "0x562CE0", VA = "0x1805646E0", Slot = "23")]
	protected override void AttributeEvent()
	{
		this.anim.Play("shoot", 1);
		this.attributeCountDown = 1.5f;
	}

	// Token: 0x0600215F RID: 8543 RVA: 0x000AFF9C File Offset: 0x000AE19C
	[Token(Token = "0x600215F")]
	[Address(RVA = "0x564510", Offset = "0x562B10", VA = "0x180564510", Slot = "74")]
	public virtual Bullet AnimShoot()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.GetBulletType();
		BulletType bulletType2 = this.GetBulletType();
		int bulletDamage = this.GetBulletDamage();
		Bullet bullet;
		bullet.Damage = bulletDamage;
		bullet.shootByZombie = true;
		GameAPP.PlaySound(bulletDamage, 0.5f, 1f);
		return bullet;
	}

	// Token: 0x06002160 RID: 8544 RVA: 0x000B0004 File Offset: 0x000AE204
	[Token(Token = "0x6002160")]
	[Address(RVA = "0x5647F0", Offset = "0x562DF0", VA = "0x1805647F0", Slot = "75")]
	protected virtual BulletType GetBulletType()
	{
		bool flag = this.hypnoPea;
		return BulletType.Bullet_pea;
	}

	// Token: 0x06002161 RID: 8545 RVA: 0x000B0024 File Offset: 0x000AE224
	[Token(Token = "0x6002161")]
	[Address(RVA = "0x5647D0", Offset = "0x562DD0", VA = "0x1805647D0", Slot = "76")]
	protected virtual int GetBulletDamage()
	{
		return 0;
	}

	// Token: 0x06002162 RID: 8546 RVA: 0x000B0034 File Offset: 0x000AE234
	[Token(Token = "0x6002162")]
	[Address(RVA = "0x564810", Offset = "0x562E10", VA = "0x180564810")]
	public PeaShooterZ()
	{
	}

	// Token: 0x040010FF RID: 4351
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x40010FF")]
	public bool hypnoPea;

	// Token: 0x04001100 RID: 4352
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x4001100")]
	public GameObject hypnoHead;

	// Token: 0x04001101 RID: 4353
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x4001101")]
	public GameObject normalHead;
}
