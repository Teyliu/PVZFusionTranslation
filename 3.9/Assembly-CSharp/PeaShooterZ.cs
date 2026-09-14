using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006E5 RID: 1765
[Token(Token = "0x20006E5")]
public class PeaShooterZ : Zombie
{
	// Token: 0x06002274 RID: 8820 RVA: 0x000B4BE8 File Offset: 0x000B2DE8
	[Token(Token = "0x6002274")]
	[Address(RVA = "0x5C8040", Offset = "0x5C6640", VA = "0x1805C8040", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		float num = global::UnityEngine.Random.Range(0.5f, 1.5f);
		this.attributeCountDown = num;
	}

	// Token: 0x06002275 RID: 8821 RVA: 0x000B4C14 File Offset: 0x000B2E14
	[Token(Token = "0x6002275")]
	[Address(RVA = "0x5C7F90", Offset = "0x5C6590", VA = "0x1805C7F90", Slot = "24")]
	protected override void AttributeEvent()
	{
		this.anim.Play("shoot", 1);
		this.attributeCountDown = 1.5f;
	}

	// Token: 0x06002276 RID: 8822 RVA: 0x000B4C44 File Offset: 0x000B2E44
	[Token(Token = "0x6002276")]
	[Address(RVA = "0x5C7DC0", Offset = "0x5C63C0", VA = "0x1805C7DC0", Slot = "76")]
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

	// Token: 0x06002277 RID: 8823 RVA: 0x000B4CAC File Offset: 0x000B2EAC
	[Token(Token = "0x6002277")]
	[Address(RVA = "0x5C80A0", Offset = "0x5C66A0", VA = "0x1805C80A0", Slot = "77")]
	protected virtual BulletType GetBulletType()
	{
		bool flag = this.hypnoPea;
		return BulletType.Bullet_pea;
	}

	// Token: 0x06002278 RID: 8824 RVA: 0x000B4CCC File Offset: 0x000B2ECC
	[Token(Token = "0x6002278")]
	[Address(RVA = "0x5C8080", Offset = "0x5C6680", VA = "0x1805C8080", Slot = "78")]
	protected virtual int GetBulletDamage()
	{
		return 0;
	}

	// Token: 0x06002279 RID: 8825 RVA: 0x000B4CDC File Offset: 0x000B2EDC
	[Token(Token = "0x6002279")]
	[Address(RVA = "0x5C80C0", Offset = "0x5C66C0", VA = "0x1805C80C0")]
	public PeaShooterZ()
	{
	}

	// Token: 0x040011CC RID: 4556
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x40011CC")]
	public bool hypnoPea;

	// Token: 0x040011CD RID: 4557
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x40011CD")]
	public GameObject hypnoHead;

	// Token: 0x040011CE RID: 4558
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x40011CE")]
	public GameObject normalHead;
}
