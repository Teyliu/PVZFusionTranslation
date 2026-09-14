using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006A6 RID: 1702
[Token(Token = "0x20006A6")]
public class GatlingPaperZombie_a : Zombie
{
	// Token: 0x06002076 RID: 8310 RVA: 0x000AC16C File Offset: 0x000AA36C
	[Token(Token = "0x6002076")]
	[Address(RVA = "0x5AD0D0", Offset = "0x5AB6D0", VA = "0x1805AD0D0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 1f;
		this.theStatus = (ZombieStatus)((ulong)4L);
	}

	// Token: 0x06002077 RID: 8311 RVA: 0x000AC194 File Offset: 0x000AA394
	[Token(Token = "0x6002077")]
	[Address(RVA = "0x5AD070", Offset = "0x5AB670", VA = "0x1805AD070", Slot = "24")]
	protected override void AttributeEvent()
	{
		this.anim.SetTrigger("shoot");
		this.attributeCountDown = 0.5f;
	}

	// Token: 0x06002078 RID: 8312 RVA: 0x000AC1C4 File Offset: 0x000AA3C4
	[Token(Token = "0x6002078")]
	[Address(RVA = "0x5AD120", Offset = "0x5AB720", VA = "0x1805AD120", Slot = "58")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
		base.Buttered(time, sprite);
	}

	// Token: 0x06002079 RID: 8313 RVA: 0x000AC1DC File Offset: 0x000AA3DC
	[Token(Token = "0x6002079")]
	[Address(RVA = "0x5A6500", Offset = "0x5A4B00", VA = "0x1805A6500", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		int num = 0;
		base.SetFreeze(time, num);
	}

	// Token: 0x0600207A RID: 8314 RVA: 0x000AC1F8 File Offset: 0x000AA3F8
	[Token(Token = "0x600207A")]
	[Address(RVA = "0x5AD230", Offset = "0x5AB830", VA = "0x1805AD230", Slot = "35")]
	protected override void SecondArmorFall()
	{
		base.SecondArmorFall();
		GameAPP.PlaySound(44, 0.5f, 1f);
		this.anim.SetTrigger("losePaper");
		base.ChangeStatus((ZombieStatus)((uint)5));
	}

	// Token: 0x0600207B RID: 8315 RVA: 0x000AC23C File Offset: 0x000AA43C
	[Token(Token = "0x600207B")]
	[Address(RVA = "0x5ACEE0", Offset = "0x5AB4E0", VA = "0x1805ACEE0", Slot = "76")]
	protected virtual void AnimShoot()
	{
		Towards towards = this.towards;
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		Transform shoot2 = this.shoot;
		Bullet bullet;
		bullet.Damage = 300;
		bullet.shootByZombie = true;
	}

	// Token: 0x0600207C RID: 8316 RVA: 0x000AC280 File Offset: 0x000AA480
	[Token(Token = "0x600207C")]
	[Address(RVA = "0x5ACDB0", Offset = "0x5AB3B0", VA = "0x1805ACDB0")]
	public void Angry()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(45, 47), 0.5f, 1f);
		GameObject gameObject = this.head_default;
		int num = 0;
		if (gameObject != num)
		{
			GameObject gameObject2 = this.head_angry;
			int num2 = 0;
			if (gameObject2 != num2)
			{
				GameObject gameObject3 = this.head_default;
				int num3 = 0;
				gameObject3.SetActive(num3 != 0);
				this.head_angry.SetActive(true);
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x0600207D RID: 8317 RVA: 0x000AC2F0 File Offset: 0x000AA4F0
	[Token(Token = "0x600207D")]
	[Address(RVA = "0x58B3E0", Offset = "0x5899E0", VA = "0x18058B3E0", Slot = "66")]
	protected override void SecondArmorBroken()
	{
	}

	// Token: 0x0600207E RID: 8318 RVA: 0x000AC300 File Offset: 0x000AA500
	[Token(Token = "0x600207E")]
	[Address(RVA = "0x5AD130", Offset = "0x5AB730", VA = "0x1805AD130", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x0600207F RID: 8319 RVA: 0x000AC340 File Offset: 0x000AA540
	[Token(Token = "0x600207F")]
	[Address(RVA = "0x5AD100", Offset = "0x5AB700", VA = "0x1805AD100", Slot = "30")]
	protected override void BodyTakeDamage(int theDamage)
	{
		base.BodyTakeDamage(theDamage);
	}

	// Token: 0x06002080 RID: 8320 RVA: 0x000AC358 File Offset: 0x000AA558
	[Token(Token = "0x6002080")]
	[Address(RVA = "0x5AD2D0", Offset = "0x5AB8D0", VA = "0x1805AD2D0", Slot = "12")]
	public override void TakeDamage(int theDamage, IDamageMaker damageFrom, DamageType theDamageType, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x06002081 RID: 8321 RVA: 0x000AC368 File Offset: 0x000AA568
	[Token(Token = "0x6002081")]
	[Address(RVA = "0x5AD1D0", Offset = "0x5AB7D0", VA = "0x1805AD1D0", Slot = "26")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x06002082 RID: 8322 RVA: 0x000AC378 File Offset: 0x000AA578
	[Token(Token = "0x6002082")]
	[Address(RVA = "0x5AD300", Offset = "0x5AB900", VA = "0x1805AD300")]
	public GatlingPaperZombie_a()
	{
	}

	// Token: 0x04001154 RID: 4436
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4001154")]
	public GameObject head_default;

	// Token: 0x04001155 RID: 4437
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4001155")]
	public GameObject head_angry;
}
