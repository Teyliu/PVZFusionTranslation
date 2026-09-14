using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200066F RID: 1647
[Token(Token = "0x200066F")]
public class GatlingFootballZombie : Zombie
{
	// Token: 0x06001F6E RID: 8046 RVA: 0x000A76CC File Offset: 0x000A58CC
	[Token(Token = "0x6001F6E")]
	[Address(RVA = "0x531EB0", Offset = "0x5304B0", VA = "0x180531EB0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 0.1f;
	}

	// Token: 0x06001F6F RID: 8047 RVA: 0x000A76EC File Offset: 0x000A58EC
	[Token(Token = "0x6001F6F")]
	[Address(RVA = "0x54A410", Offset = "0x548A10", VA = "0x18054A410", Slot = "23")]
	protected override void AttributeEvent()
	{
		base.ZombieUpdate();
		float theSpeed = this.theSpeed;
		if (0 > (int)theSpeed || theSpeed > 1f)
		{
		}
		this.anim.SetTrigger("shoot");
	}

	// Token: 0x06001F70 RID: 8048 RVA: 0x000A772C File Offset: 0x000A592C
	[Token(Token = "0x6001F70")]
	[Address(RVA = "0x54A240", Offset = "0x548840", VA = "0x18054A240", Slot = "74")]
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

	// Token: 0x06001F71 RID: 8049 RVA: 0x000A7778 File Offset: 0x000A5978
	[Token(Token = "0x6001F71")]
	[Address(RVA = "0x54A4C0", Offset = "0x548AC0", VA = "0x18054A4C0", Slot = "61")]
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

	// Token: 0x06001F72 RID: 8050 RVA: 0x000A7844 File Offset: 0x000A5A44
	[Token(Token = "0x6001F72")]
	[Address(RVA = "0x531BF0", Offset = "0x5301F0", VA = "0x180531BF0", Slot = "63")]
	protected override int FirstArmorTakeDamage(int theDamage)
	{
		int theFirstArmorHealth = this.theFirstArmorHealth;
		int num = 0;
		this.theFirstArmorHealth = num;
		this.theFirstArmorType = (Zombie.FirstArmorType)num;
		this.theFirstArmor = num;
		return theDamage;
	}

	// Token: 0x06001F73 RID: 8051 RVA: 0x000A7880 File Offset: 0x000A5A80
	[Token(Token = "0x6001F73")]
	[Address(RVA = "0x54A1F0", Offset = "0x5487F0", VA = "0x18054A1F0")]
	public GatlingFootballZombie()
	{
	}
}
