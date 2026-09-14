using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006A5 RID: 1701
[Token(Token = "0x20006A5")]
public class GatlingFootballZombie : Zombie
{
	// Token: 0x06002070 RID: 8304 RVA: 0x000ABFA4 File Offset: 0x000AA1A4
	[Token(Token = "0x6002070")]
	[Address(RVA = "0x588A00", Offset = "0x587000", VA = "0x180588A00", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 0.1f;
	}

	// Token: 0x06002071 RID: 8305 RVA: 0x000ABFC4 File Offset: 0x000AA1C4
	[Token(Token = "0x6002071")]
	[Address(RVA = "0x5ACA90", Offset = "0x5AB090", VA = "0x1805ACA90", Slot = "24")]
	protected override void AttributeEvent()
	{
		base.ZombieUpdate();
		float theSpeed = this.theSpeed;
		if (0 > (int)theSpeed || theSpeed > 1f)
		{
		}
		this.anim.SetTrigger("shoot");
	}

	// Token: 0x06002072 RID: 8306 RVA: 0x000AC004 File Offset: 0x000AA204
	[Token(Token = "0x6002072")]
	[Address(RVA = "0x5AC8C0", Offset = "0x5AAEC0", VA = "0x1805AC8C0", Slot = "76")]
	protected virtual void AnimShoot()
	{
		Transform shoot = this.shoot;
		int num = 0;
		if (!(shoot == num))
		{
			Transform shoot2 = this.shoot;
			CreateBullet instance = CreateBullet.Instance;
			int num2 = 0;
			Bullet bullet;
			bullet.Damage = num2;
			bullet.shootByZombie = true;
		}
	}

	// Token: 0x06002073 RID: 8307 RVA: 0x000AC050 File Offset: 0x000AA250
	[Token(Token = "0x6002073")]
	[Address(RVA = "0x5ACB40", Offset = "0x5AB140", VA = "0x1805ACB40", Slot = "63")]
	protected override void FirstArmorBroken()
	{
		bool flag;
		if (!flag)
		{
			SpriteRenderer component = this.theFirstArmor.GetComponent<SpriteRenderer>();
			int num = 0;
			component.enabled = num != 0;
			Transform transform = this.theFirstArmor.transform;
			int num2 = 0;
			GameObject gameObject = transform.GetChild(num2).gameObject;
			int num3 = 0;
			gameObject.SetActive(num3 != 0);
			uint num4;
			ulong num5;
			this.theFirstArmor.transform.GetChild((int)num4).gameObject.SetActive(num5 != 0UL);
			return;
		}
		SpriteRenderer component2 = this.theFirstArmor.GetComponent<SpriteRenderer>();
		int num6 = 0;
		component2.enabled = num6 != 0;
		Transform transform2 = this.theFirstArmor.transform;
		int num7 = 0;
		ulong num8;
		transform2.GetChild(num7).gameObject.SetActive(num8 != 0UL);
		uint num9;
		GameObject gameObject2 = this.theFirstArmor.transform.GetChild((int)num9).gameObject;
		throw new NullReferenceException();
	}

	// Token: 0x06002074 RID: 8308 RVA: 0x000AC11C File Offset: 0x000AA31C
	[Token(Token = "0x6002074")]
	[Address(RVA = "0x588740", Offset = "0x586D40", VA = "0x180588740", Slot = "65")]
	protected override int FirstArmorTakeDamage(int theDamage)
	{
		int theFirstArmorHealth = this.theFirstArmorHealth;
		int num = 0;
		this.theFirstArmorHealth = num;
		this.theFirstArmorType = (Zombie.FirstArmorType)num;
		this.theFirstArmor = num;
		return theDamage;
	}

	// Token: 0x06002075 RID: 8309 RVA: 0x000AC158 File Offset: 0x000AA358
	[Token(Token = "0x6002075")]
	[Address(RVA = "0x5AC870", Offset = "0x5AAE70", VA = "0x1805AC870")]
	public GatlingFootballZombie()
	{
	}
}
