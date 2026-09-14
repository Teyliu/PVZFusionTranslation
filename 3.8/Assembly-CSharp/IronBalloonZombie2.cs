using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000685 RID: 1669
[Token(Token = "0x2000685")]
public class IronBalloonZombie2 : IronBalloonZombie
{
	// Token: 0x0600201B RID: 8219 RVA: 0x000AA30C File Offset: 0x000A850C
	[Token(Token = "0x600201B")]
	[Address(RVA = "0x551420", Offset = "0x54FA20", VA = "0x180551420", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 1.5f;
	}

	// Token: 0x0600201C RID: 8220 RVA: 0x000AA32C File Offset: 0x000A852C
	[Token(Token = "0x600201C")]
	[Address(RVA = "0x530530", Offset = "0x52EB30", VA = "0x180530530", Slot = "63")]
	protected override int FirstArmorTakeDamage(int theDamage)
	{
		this.Fall();
		return 0;
	}

	// Token: 0x0600201D RID: 8221 RVA: 0x000AA344 File Offset: 0x000A8544
	[Token(Token = "0x600201D")]
	[Address(RVA = "0x551440", Offset = "0x54FA40", VA = "0x180551440", Slot = "74")]
	public override void Fall()
	{
		this.fall = true;
		int num = 0;
		base.ChangeStatus((ZombieStatus)num);
		GameAPP.PlaySound(77, 0.5f, 1f);
		if (base.BoxType != BoxType.Water)
		{
			int num2 = 0;
			this.theFirstArmorHealth = num2;
			this.theFirstArmorType = (Zombie.FirstArmorType)num2;
			this.theFirstArmor = num2;
			this.anim.SetTrigger("fall");
		}
	}

	// Token: 0x0600201E RID: 8222 RVA: 0x000AA3AC File Offset: 0x000A85AC
	[Token(Token = "0x600201E")]
	[Address(RVA = "0x5513C0", Offset = "0x54F9C0", VA = "0x1805513C0", Slot = "23")]
	protected override void AttributeEvent()
	{
		Animator anim = this.anim;
		this.attributeCountDown = 1.5f;
		anim.SetTrigger("shoot");
	}

	// Token: 0x0600201F RID: 8223 RVA: 0x000AA3DC File Offset: 0x000A85DC
	[Token(Token = "0x600201F")]
	[Address(RVA = "0x551250", Offset = "0x54F850", VA = "0x180551250")]
	private void AnimShoot()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		bullet.Damage = 80;
	}

	// Token: 0x06002020 RID: 8224 RVA: 0x000AA410 File Offset: 0x000A8610
	[Token(Token = "0x6002020")]
	[Address(RVA = "0x551550", Offset = "0x54FB50", VA = "0x180551550")]
	public IronBalloonZombie2()
	{
	}
}
