using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006E2 RID: 1762
[Token(Token = "0x20006E2")]
public class PaperCherryZ95 : PaperZombie
{
	// Token: 0x06002256 RID: 8790 RVA: 0x000B45BC File Offset: 0x000B27BC
	[Token(Token = "0x6002256")]
	[Address(RVA = "0x5C7230", Offset = "0x5C5830", VA = "0x1805C7230", Slot = "16")]
	protected override void Start()
	{
		base.Start();
		this.theStatus = (ZombieStatus)((ulong)4L);
	}

	// Token: 0x06002257 RID: 8791 RVA: 0x000B45D8 File Offset: 0x000B27D8
	[Token(Token = "0x6002257")]
	[Address(RVA = "0x5C6ED0", Offset = "0x5C54D0", VA = "0x1805C6ED0", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		Sprite sprite = GameAPP.spritePrefab[38];
		component.sprite = sprite;
	}

	// Token: 0x06002258 RID: 8792 RVA: 0x000B4608 File Offset: 0x000B2808
	[Token(Token = "0x6002258")]
	[Address(RVA = "0x5A6520", Offset = "0x5A4B20", VA = "0x1805A6520", Slot = "12")]
	public override void TakeDamage(int theDamage, IDamageMaker damageFrom, DamageType theDamageType, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x06002259 RID: 8793 RVA: 0x000B4618 File Offset: 0x000B2818
	[Token(Token = "0x6002259")]
	[Address(RVA = "0x5A6230", Offset = "0x5A4830", VA = "0x1805A6230", Slot = "30")]
	protected override void BodyTakeDamage(int theDamage)
	{
		base.BodyTakeDamage(theDamage);
	}

	// Token: 0x0600225A RID: 8794 RVA: 0x000B4630 File Offset: 0x000B2830
	[Token(Token = "0x600225A")]
	[Address(RVA = "0x5A6310", Offset = "0x5A4910", VA = "0x1805A6310", Slot = "26")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x0600225B RID: 8795 RVA: 0x000B4640 File Offset: 0x000B2840
	[Token(Token = "0x600225B")]
	[Address(RVA = "0x5C6F80", Offset = "0x5C5580", VA = "0x1805C6F80", Slot = "66")]
	protected override void SecondArmorBroken()
	{
		int num = this.theSecondArmorMaxHealth;
		num += num;
		GameObject theSecondArmor = this.theSecondArmor;
		this.theSecondArmorBroken = (int)((ulong)1L);
		SpriteRenderer component = theSecondArmor.GetComponent<SpriteRenderer>();
		Sprite sprite = GameAPP.spritePrefab[10];
		component.sprite = sprite;
		GameObject theSecondArmor2 = this.theSecondArmor;
		this.theSecondArmorBroken = (int)((ulong)2L);
		SpriteRenderer component2 = theSecondArmor2.GetComponent<SpriteRenderer>();
		Sprite sprite2 = GameAPP.spritePrefab[11];
		component2.sprite = sprite2;
	}

	// Token: 0x0600225C RID: 8796 RVA: 0x000B46BC File Offset: 0x000B28BC
	[Token(Token = "0x600225C")]
	[Address(RVA = "0x5C7250", Offset = "0x5C5850", VA = "0x1805C7250", Slot = "17")]
	protected override void Update()
	{
		base.Update();
		float num = this.theZombieAttackCountDown;
		float deltaTime = Time.deltaTime;
		int num2 = 0;
		this.theZombieAttackCountDown = num;
		if (num2 > (int)num)
		{
			float num3 = this.theZombieAttackInterval;
			this.theZombieAttackCountDown = num3;
			base.GetComponent<Animator>().Play("shoot", 1);
			return;
		}
	}

	// Token: 0x0600225D RID: 8797 RVA: 0x000B4714 File Offset: 0x000B2914
	[Token(Token = "0x600225D")]
	[Address(RVA = "0x5C73A0", Offset = "0x5C59A0", VA = "0x1805C73A0")]
	private void ZombieShootUpdate()
	{
		float num = this.theZombieAttackCountDown;
		float deltaTime = Time.deltaTime;
		int num2 = 0;
		this.theZombieAttackCountDown = num;
		if (num2 > (int)num)
		{
			float num3 = this.theZombieAttackInterval;
			this.theZombieAttackCountDown = num3;
			base.GetComponent<Animator>().Play("shoot", 1);
			return;
		}
	}

	// Token: 0x0600225E RID: 8798 RVA: 0x000B4768 File Offset: 0x000B2968
	[Token(Token = "0x600225E")]
	[Address(RVA = "0x5C6C10", Offset = "0x5C5210", VA = "0x1805C6C10", Slot = "78")]
	public virtual Bullet AnimShoot()
	{
		Transform transform = base.transform.Find("Zombie_head");
		int num = 0;
		Transform transform2 = transform.GetChild(num).transform;
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		bullet.Damage = 300;
		bullet.shootByZombie = true;
		return bullet;
	}

	// Token: 0x0600225F RID: 8799 RVA: 0x000B47C4 File Offset: 0x000B29C4
	[Token(Token = "0x600225F")]
	[Address(RVA = "0x5C6DF0", Offset = "0x5C53F0", VA = "0x1805C6DF0", Slot = "58")]
	public override void Buttered(float time = 4f, bool sprite = false)
	{
		if (!Lawnf.TravelDebuff((TravelDebuff)((uint)1)))
		{
			base.Buttered(time, true);
		}
	}

	// Token: 0x06002260 RID: 8800 RVA: 0x000B47E4 File Offset: 0x000B29E4
	[Token(Token = "0x6002260")]
	[Address(RVA = "0x5C7170", Offset = "0x5C5770", VA = "0x1805C7170", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		if (!Lawnf.TravelDebuff((TravelDebuff)((uint)1)))
		{
			int num = 0;
			base.SetFreeze(time, num);
		}
	}

	// Token: 0x06002261 RID: 8801 RVA: 0x000B4808 File Offset: 0x000B2A08
	[Token(Token = "0x6002261")]
	[Address(RVA = "0x5C71C0", Offset = "0x5C57C0", VA = "0x1805C71C0", Slot = "51")]
	public override void SetJalaed()
	{
		if (!Lawnf.TravelDebuff((TravelDebuff)((uint)1)))
		{
			base.SetJalaed();
			return;
		}
	}

	// Token: 0x06002262 RID: 8802 RVA: 0x000B4828 File Offset: 0x000B2A28
	[Token(Token = "0x6002262")]
	[Address(RVA = "0x5C71F0", Offset = "0x5C57F0", VA = "0x1805C71F0", Slot = "54")]
	public override void SetPoison(float time = 10f)
	{
		if (!Lawnf.TravelDebuff((TravelDebuff)((uint)1)))
		{
			base.SetPoison(time);
		}
	}

	// Token: 0x06002263 RID: 8803 RVA: 0x000B4848 File Offset: 0x000B2A48
	[Token(Token = "0x6002263")]
	[Address(RVA = "0x5C6BE0", Offset = "0x5C51E0", VA = "0x1805C6BE0", Slot = "55")]
	public override void AddPoisonLevel()
	{
		if (!Lawnf.TravelDebuff((TravelDebuff)((uint)1)))
		{
			base.AddPoisonLevel();
			return;
		}
	}

	// Token: 0x06002264 RID: 8804 RVA: 0x000B4868 File Offset: 0x000B2A68
	[Token(Token = "0x6002264")]
	[Address(RVA = "0x5C7100", Offset = "0x5C5700", VA = "0x1805C7100", Slot = "56")]
	public override void SetCold(float time, int coldLevel = 0, bool freeze = false)
	{
		if (!Lawnf.TravelDebuff((TravelDebuff)((uint)1)))
		{
			base.SetCold(time, coldLevel, freeze);
		}
	}

	// Token: 0x06002265 RID: 8805 RVA: 0x000B4888 File Offset: 0x000B2A88
	[Token(Token = "0x6002265")]
	[Address(RVA = "0x5C6E40", Offset = "0x5C5440", VA = "0x1805C6E40", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		if (Lawnf.TravelDebuff(TravelDebuff.二爷无视植物))
		{
			Animator anim = this.anim;
			int num = 0;
			anim.SetBool("isAttacking", num != 0);
		}
		return base.CanAttack(target);
	}

	// Token: 0x06002266 RID: 8806 RVA: 0x000B48C4 File Offset: 0x000B2AC4
	[Token(Token = "0x6002266")]
	[Address(RVA = "0x5C6100", Offset = "0x5C4700", VA = "0x1805C6100")]
	public PaperCherryZ95()
	{
	}

	// Token: 0x040011CA RID: 4554
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x40011CA")]
	public float theZombieAttackInterval = 0.75f;

	// Token: 0x040011CB RID: 4555
	[FieldOffset(Offset = "0x27C")]
	[Token(Token = "0x40011CB")]
	private float theZombieAttackCountDown;
}
