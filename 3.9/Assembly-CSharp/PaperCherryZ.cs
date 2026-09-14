using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006E1 RID: 1761
[Token(Token = "0x20006E1")]
public class PaperCherryZ : ArmorZombie
{
	// Token: 0x0600224D RID: 8781 RVA: 0x000B42B8 File Offset: 0x000B24B8
	[Token(Token = "0x600224D")]
	[Address(RVA = "0x5C59D0", Offset = "0x5C3FD0", VA = "0x1805C59D0", Slot = "66")]
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

	// Token: 0x0600224E RID: 8782 RVA: 0x000B4334 File Offset: 0x000B2534
	[Token(Token = "0x600224E")]
	[Address(RVA = "0x5C5B50", Offset = "0x5C4150", VA = "0x1805C5B50", Slot = "35")]
	protected override void SecondArmorFall()
	{
		int num;
		do
		{
			num = 0;
			IEnumerator enumerator = base.transform.GetEnumerator();
			if (enumerator != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				enumerator += enumerator;
				string text;
				while (text == 0)
				{
				}
				GameObject gameObject;
				ulong num2;
				gameObject.SetActive(num2 != 0UL);
				GameObject gameObject2;
				ParticleSystemRenderer component = gameObject2.GetComponent<ParticleSystemRenderer>();
				int theZombieRow = this.theZombieRow;
				string text2 = string.Format("zombie{0}", component);
				component.sortingLayerName = text2;
				GameObject gameObject3;
				ParticleSystemRenderer component2 = gameObject3.GetComponent<ParticleSystemRenderer>();
				int num3 = this.sortingGroup.sortingOrder + 1;
				component2.sortingOrder = num3;
			}
			if (enumerator != 0)
			{
			}
		}
		while (num != 0);
		uint num4;
		GameAPP.PlaySound((int)num4, 0.5f, 1f);
	}

	// Token: 0x0600224F RID: 8783 RVA: 0x000B441C File Offset: 0x000B261C
	[Token(Token = "0x600224F")]
	[Address(RVA = "0x5C5930", Offset = "0x5C3F30", VA = "0x1805C5930", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		Sprite sprite = GameAPP.spritePrefab[5];
		component.sprite = sprite;
	}

	// Token: 0x06002250 RID: 8784 RVA: 0x000B444C File Offset: 0x000B264C
	[Token(Token = "0x6002250")]
	[Address(RVA = "0x5C56B0", Offset = "0x5C3CB0", VA = "0x1805C56B0")]
	public void AngrySound()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(45, 47), 0.5f, 1f);
		base.ChangeStatus((ZombieStatus)((uint)6));
	}

	// Token: 0x06002251 RID: 8785 RVA: 0x000B447C File Offset: 0x000B267C
	[Token(Token = "0x6002251")]
	[Address(RVA = "0x5C5F30", Offset = "0x5C4530", VA = "0x1805C5F30", Slot = "17")]
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

	// Token: 0x06002252 RID: 8786 RVA: 0x000B44D4 File Offset: 0x000B26D4
	[Token(Token = "0x6002252")]
	[Address(RVA = "0x5C6050", Offset = "0x5C4650", VA = "0x1805C6050")]
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
		}
	}

	// Token: 0x06002253 RID: 8787 RVA: 0x000B4524 File Offset: 0x000B2724
	[Token(Token = "0x6002253")]
	[Address(RVA = "0x5C5750", Offset = "0x5C3D50", VA = "0x1805C5750", Slot = "76")]
	public virtual Bullet AnimShoot()
	{
		Transform transform = base.transform.Find("Zombie_head");
		int num = 0;
		Transform transform2 = transform.GetChild(num).transform;
		Vector3 vector;
		float z = vector.z;
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		bullet.Damage = 300;
		bullet.shootByZombie = true;
		return bullet;
	}

	// Token: 0x06002254 RID: 8788 RVA: 0x000B4584 File Offset: 0x000B2784
	[Token(Token = "0x6002254")]
	[Address(RVA = "0x5C5740", Offset = "0x5C3D40", VA = "0x1805C5740")]
	private void Angry()
	{
		base.ChangeStatus((ZombieStatus)((uint)6));
	}

	// Token: 0x06002255 RID: 8789 RVA: 0x000B459C File Offset: 0x000B279C
	[Token(Token = "0x6002255")]
	[Address(RVA = "0x5C6100", Offset = "0x5C4700", VA = "0x1805C6100")]
	public PaperCherryZ()
	{
	}

	// Token: 0x040011C8 RID: 4552
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x40011C8")]
	public float theZombieAttackInterval = 0.75f;

	// Token: 0x040011C9 RID: 4553
	[FieldOffset(Offset = "0x27C")]
	[Token(Token = "0x40011C9")]
	private float theZombieAttackCountDown;
}
