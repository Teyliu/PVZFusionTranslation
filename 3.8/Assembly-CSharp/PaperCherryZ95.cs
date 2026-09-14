using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006AB RID: 1707
[Token(Token = "0x20006AB")]
public class PaperCherryZ95 : PaperZombie
{
	// Token: 0x0600213F RID: 8511 RVA: 0x000AF914 File Offset: 0x000ADB14
	[Token(Token = "0x600213F")]
	[Address(RVA = "0x562F10", Offset = "0x561510", VA = "0x180562F10", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.theStatus = (ZombieStatus)((ulong)4L);
	}

	// Token: 0x06002140 RID: 8512 RVA: 0x000AF930 File Offset: 0x000ADB30
	[Token(Token = "0x6002140")]
	[Address(RVA = "0x562BB0", Offset = "0x5611B0", VA = "0x180562BB0", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		Sprite sprite = GameAPP.spritePrefab[38];
		component.sprite = sprite;
	}

	// Token: 0x06002141 RID: 8513 RVA: 0x000AF960 File Offset: 0x000ADB60
	[Token(Token = "0x6002141")]
	[Address(RVA = "0x543F00", Offset = "0x542500", VA = "0x180543F00", Slot = "12")]
	public override void TakeDamage(int theDamage, IDamageMaker damageFrom, DamageType theDamageType, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x06002142 RID: 8514 RVA: 0x000AF970 File Offset: 0x000ADB70
	[Token(Token = "0x6002142")]
	[Address(RVA = "0x543C10", Offset = "0x542210", VA = "0x180543C10", Slot = "29")]
	protected override void BodyTakeDamage(int theDamage)
	{
		base.BodyTakeDamage(theDamage);
	}

	// Token: 0x06002143 RID: 8515 RVA: 0x000AF988 File Offset: 0x000ADB88
	[Token(Token = "0x6002143")]
	[Address(RVA = "0x543CF0", Offset = "0x5422F0", VA = "0x180543CF0", Slot = "25")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x06002144 RID: 8516 RVA: 0x000AF998 File Offset: 0x000ADB98
	[Token(Token = "0x6002144")]
	[Address(RVA = "0x562C60", Offset = "0x561260", VA = "0x180562C60", Slot = "64")]
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

	// Token: 0x06002145 RID: 8517 RVA: 0x000AFA14 File Offset: 0x000ADC14
	[Token(Token = "0x6002145")]
	[Address(RVA = "0x562F30", Offset = "0x561530", VA = "0x180562F30", Slot = "16")]
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

	// Token: 0x06002146 RID: 8518 RVA: 0x000AFA6C File Offset: 0x000ADC6C
	[Token(Token = "0x6002146")]
	[Address(RVA = "0x563080", Offset = "0x561680", VA = "0x180563080")]
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

	// Token: 0x06002147 RID: 8519 RVA: 0x000AFAC0 File Offset: 0x000ADCC0
	[Token(Token = "0x6002147")]
	[Address(RVA = "0x5628F0", Offset = "0x560EF0", VA = "0x1805628F0", Slot = "76")]
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

	// Token: 0x06002148 RID: 8520 RVA: 0x000AFB1C File Offset: 0x000ADD1C
	[Token(Token = "0x6002148")]
	[Address(RVA = "0x562AD0", Offset = "0x5610D0", VA = "0x180562AD0", Slot = "56")]
	public override void Buttered(float time = 4f, bool sprite = false)
	{
		if (!Lawnf.TravelDebuff((TravelDebuff)((uint)1)))
		{
			base.Buttered(time, true);
		}
	}

	// Token: 0x06002149 RID: 8521 RVA: 0x000AFB3C File Offset: 0x000ADD3C
	[Token(Token = "0x6002149")]
	[Address(RVA = "0x562E50", Offset = "0x561450", VA = "0x180562E50", Slot = "51")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		if (!Lawnf.TravelDebuff((TravelDebuff)((uint)1)))
		{
			int num = 0;
			base.SetFreeze(time, num);
		}
	}

	// Token: 0x0600214A RID: 8522 RVA: 0x000AFB60 File Offset: 0x000ADD60
	[Token(Token = "0x600214A")]
	[Address(RVA = "0x562EA0", Offset = "0x5614A0", VA = "0x180562EA0", Slot = "49")]
	public override void SetJalaed()
	{
		if (!Lawnf.TravelDebuff((TravelDebuff)((uint)1)))
		{
			base.SetJalaed();
			return;
		}
	}

	// Token: 0x0600214B RID: 8523 RVA: 0x000AFB80 File Offset: 0x000ADD80
	[Token(Token = "0x600214B")]
	[Address(RVA = "0x562ED0", Offset = "0x5614D0", VA = "0x180562ED0", Slot = "52")]
	public override void SetPoison(float time = 10f)
	{
		if (!Lawnf.TravelDebuff((TravelDebuff)((uint)1)))
		{
			base.SetPoison(time);
		}
	}

	// Token: 0x0600214C RID: 8524 RVA: 0x000AFBA0 File Offset: 0x000ADDA0
	[Token(Token = "0x600214C")]
	[Address(RVA = "0x5628C0", Offset = "0x560EC0", VA = "0x1805628C0", Slot = "53")]
	public override void AddPoisonLevel()
	{
		if (!Lawnf.TravelDebuff((TravelDebuff)((uint)1)))
		{
			base.AddPoisonLevel();
			return;
		}
	}

	// Token: 0x0600214D RID: 8525 RVA: 0x000AFBC0 File Offset: 0x000ADDC0
	[Token(Token = "0x600214D")]
	[Address(RVA = "0x562DE0", Offset = "0x5613E0", VA = "0x180562DE0", Slot = "54")]
	public override void SetCold(float time, int coldLevel = 0, bool freeze = false)
	{
		if (!Lawnf.TravelDebuff((TravelDebuff)((uint)1)))
		{
			base.SetCold(time, coldLevel, freeze);
		}
	}

	// Token: 0x0600214E RID: 8526 RVA: 0x000AFBE0 File Offset: 0x000ADDE0
	[Token(Token = "0x600214E")]
	[Address(RVA = "0x562B20", Offset = "0x561120", VA = "0x180562B20", Slot = "13")]
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

	// Token: 0x0600214F RID: 8527 RVA: 0x000AFC1C File Offset: 0x000ADE1C
	[Token(Token = "0x600214F")]
	[Address(RVA = "0x563170", Offset = "0x561770", VA = "0x180563170")]
	public PaperCherryZ95()
	{
	}

	// Token: 0x040010FD RID: 4349
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x40010FD")]
	public float theZombieAttackInterval = 0.75f;

	// Token: 0x040010FE RID: 4350
	[FieldOffset(Offset = "0x25C")]
	[Token(Token = "0x40010FE")]
	private float theZombieAttackCountDown;
}
