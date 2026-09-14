using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000670 RID: 1648
[Token(Token = "0x2000670")]
public class GatlingPaperZombie_a : Zombie
{
	// Token: 0x06001F74 RID: 8052 RVA: 0x000A7894 File Offset: 0x000A5A94
	[Token(Token = "0x6001F74")]
	[Address(RVA = "0x54AA50", Offset = "0x549050", VA = "0x18054AA50", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 1f;
		this.theStatus = (ZombieStatus)((ulong)4L);
	}

	// Token: 0x06001F75 RID: 8053 RVA: 0x000A78BC File Offset: 0x000A5ABC
	[Token(Token = "0x6001F75")]
	[Address(RVA = "0x54A9F0", Offset = "0x548FF0", VA = "0x18054A9F0", Slot = "23")]
	protected override void AttributeEvent()
	{
		this.anim.SetTrigger("shoot");
		this.attributeCountDown = 0.5f;
	}

	// Token: 0x06001F76 RID: 8054 RVA: 0x000A78EC File Offset: 0x000A5AEC
	[Token(Token = "0x6001F76")]
	[Address(RVA = "0x54AAA0", Offset = "0x5490A0", VA = "0x18054AAA0", Slot = "56")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
		base.Buttered(time, sprite);
	}

	// Token: 0x06001F77 RID: 8055 RVA: 0x000A7904 File Offset: 0x000A5B04
	[Token(Token = "0x6001F77")]
	[Address(RVA = "0x543EE0", Offset = "0x5424E0", VA = "0x180543EE0", Slot = "51")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		int num = 0;
		base.SetFreeze(time, num);
	}

	// Token: 0x06001F78 RID: 8056 RVA: 0x000A7920 File Offset: 0x000A5B20
	[Token(Token = "0x6001F78")]
	[Address(RVA = "0x54ABB0", Offset = "0x5491B0", VA = "0x18054ABB0", Slot = "34")]
	protected override void SecondArmorFall()
	{
		base.SecondArmorFall();
		GameAPP.PlaySound(44, 0.5f, 1f);
		this.anim.SetTrigger("losePaper");
		base.ChangeStatus((ZombieStatus)((uint)5));
	}

	// Token: 0x06001F79 RID: 8057 RVA: 0x000A7964 File Offset: 0x000A5B64
	[Token(Token = "0x6001F79")]
	[Address(RVA = "0x54A860", Offset = "0x548E60", VA = "0x18054A860", Slot = "74")]
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

	// Token: 0x06001F7A RID: 8058 RVA: 0x000A79A8 File Offset: 0x000A5BA8
	[Token(Token = "0x6001F7A")]
	[Address(RVA = "0x54A730", Offset = "0x548D30", VA = "0x18054A730")]
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

	// Token: 0x06001F7B RID: 8059 RVA: 0x000A7A18 File Offset: 0x000A5C18
	[Token(Token = "0x6001F7B")]
	[Address(RVA = "0x534700", Offset = "0x532D00", VA = "0x180534700", Slot = "64")]
	protected override void SecondArmorBroken()
	{
	}

	// Token: 0x06001F7C RID: 8060 RVA: 0x000A7A28 File Offset: 0x000A5C28
	[Token(Token = "0x6001F7C")]
	[Address(RVA = "0x54AAB0", Offset = "0x5490B0", VA = "0x18054AAB0", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x06001F7D RID: 8061 RVA: 0x000A7A68 File Offset: 0x000A5C68
	[Token(Token = "0x6001F7D")]
	[Address(RVA = "0x54AA80", Offset = "0x549080", VA = "0x18054AA80", Slot = "29")]
	protected override void BodyTakeDamage(int theDamage)
	{
		base.BodyTakeDamage(theDamage);
	}

	// Token: 0x06001F7E RID: 8062 RVA: 0x000A7A80 File Offset: 0x000A5C80
	[Token(Token = "0x6001F7E")]
	[Address(RVA = "0x54AC50", Offset = "0x549250", VA = "0x18054AC50", Slot = "12")]
	public override void TakeDamage(int theDamage, IDamageMaker damageFrom, DamageType theDamageType, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x06001F7F RID: 8063 RVA: 0x000A7A90 File Offset: 0x000A5C90
	[Token(Token = "0x6001F7F")]
	[Address(RVA = "0x54AB50", Offset = "0x549150", VA = "0x18054AB50", Slot = "25")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x06001F80 RID: 8064 RVA: 0x000A7AA0 File Offset: 0x000A5CA0
	[Token(Token = "0x6001F80")]
	[Address(RVA = "0x54AC80", Offset = "0x549280", VA = "0x18054AC80")]
	public GatlingPaperZombie_a()
	{
	}

	// Token: 0x04001087 RID: 4231
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x4001087")]
	public GameObject head_default;

	// Token: 0x04001088 RID: 4232
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x4001088")]
	public GameObject head_angry;
}
