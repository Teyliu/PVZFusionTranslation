using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006BB RID: 1723
[Token(Token = "0x20006BB")]
public class IronBalloonZombie2 : IronBalloonZombie
{
	// Token: 0x0600211D RID: 8477 RVA: 0x000AEC10 File Offset: 0x000ACE10
	[Token(Token = "0x600211D")]
	[Address(RVA = "0x5B4FB0", Offset = "0x5B35B0", VA = "0x1805B4FB0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 1.5f;
	}

	// Token: 0x0600211E RID: 8478 RVA: 0x000AEC30 File Offset: 0x000ACE30
	[Token(Token = "0x600211E")]
	[Address(RVA = "0x5870B0", Offset = "0x5856B0", VA = "0x1805870B0", Slot = "65")]
	protected override int FirstArmorTakeDamage(int theDamage)
	{
		this.Fall();
		return 0;
	}

	// Token: 0x0600211F RID: 8479 RVA: 0x000AEC48 File Offset: 0x000ACE48
	[Token(Token = "0x600211F")]
	[Address(RVA = "0x5B4FD0", Offset = "0x5B35D0", VA = "0x1805B4FD0", Slot = "76")]
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

	// Token: 0x06002120 RID: 8480 RVA: 0x000AECB0 File Offset: 0x000ACEB0
	[Token(Token = "0x6002120")]
	[Address(RVA = "0x5B4F50", Offset = "0x5B3550", VA = "0x1805B4F50", Slot = "24")]
	protected override void AttributeEvent()
	{
		Animator anim = this.anim;
		this.attributeCountDown = 1.5f;
		anim.SetTrigger("shoot");
	}

	// Token: 0x06002121 RID: 8481 RVA: 0x000AECE0 File Offset: 0x000ACEE0
	[Token(Token = "0x6002121")]
	[Address(RVA = "0x5B4DE0", Offset = "0x5B33E0", VA = "0x1805B4DE0")]
	private void AnimShoot()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		bullet.Damage = 80;
	}

	// Token: 0x06002122 RID: 8482 RVA: 0x000AED14 File Offset: 0x000ACF14
	[Token(Token = "0x6002122")]
	[Address(RVA = "0x5B50E0", Offset = "0x5B36E0", VA = "0x1805B50E0")]
	public IronBalloonZombie2()
	{
	}
}
