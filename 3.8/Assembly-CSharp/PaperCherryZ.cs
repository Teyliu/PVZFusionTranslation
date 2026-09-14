using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006AA RID: 1706
[Token(Token = "0x20006AA")]
public class PaperCherryZ : ArmorZombie
{
	// Token: 0x06002136 RID: 8502 RVA: 0x000AF60C File Offset: 0x000AD80C
	[Token(Token = "0x6002136")]
	[Address(RVA = "0x5634B0", Offset = "0x561AB0", VA = "0x1805634B0", Slot = "64")]
	protected override void SecondArmorBroken()
	{
		int num = this.theSecondArmorMaxHealth;
		num += num;
		GameObject theSecondArmor = this.theSecondArmor;
		this.theSecondArmorBroken = (int)((ulong)1L);
		SpriteRenderer component = theSecondArmor.GetComponent<SpriteRenderer>();
		Sprite sprite = GameAPP.spritePrefab[10];
		component.sprite = sprite;
		sprite += sprite;
		GameObject theSecondArmor2 = this.theSecondArmor;
		this.theSecondArmorBroken = (int)((ulong)2L);
		SpriteRenderer component2 = theSecondArmor2.GetComponent<SpriteRenderer>();
		Sprite sprite2 = GameAPP.spritePrefab[11];
		component2.sprite = sprite2;
	}

	// Token: 0x06002137 RID: 8503 RVA: 0x000AF68C File Offset: 0x000AD88C
	[Token(Token = "0x6002137")]
	[Address(RVA = "0x563630", Offset = "0x561C30", VA = "0x180563630", Slot = "34")]
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

	// Token: 0x06002138 RID: 8504 RVA: 0x000AF774 File Offset: 0x000AD974
	[Token(Token = "0x6002138")]
	[Address(RVA = "0x563410", Offset = "0x561A10", VA = "0x180563410", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		Sprite sprite = GameAPP.spritePrefab[5];
		component.sprite = sprite;
	}

	// Token: 0x06002139 RID: 8505 RVA: 0x000AF7A4 File Offset: 0x000AD9A4
	[Token(Token = "0x6002139")]
	[Address(RVA = "0x563190", Offset = "0x561790", VA = "0x180563190")]
	public void AngrySound()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(45, 47), 0.5f, 1f);
		base.ChangeStatus((ZombieStatus)((uint)6));
	}

	// Token: 0x0600213A RID: 8506 RVA: 0x000AF7D4 File Offset: 0x000AD9D4
	[Token(Token = "0x600213A")]
	[Address(RVA = "0x563A10", Offset = "0x562010", VA = "0x180563A10", Slot = "16")]
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

	// Token: 0x0600213B RID: 8507 RVA: 0x000AF82C File Offset: 0x000ADA2C
	[Token(Token = "0x600213B")]
	[Address(RVA = "0x563B30", Offset = "0x562130", VA = "0x180563B30")]
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

	// Token: 0x0600213C RID: 8508 RVA: 0x000AF87C File Offset: 0x000ADA7C
	[Token(Token = "0x600213C")]
	[Address(RVA = "0x563230", Offset = "0x561830", VA = "0x180563230", Slot = "74")]
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

	// Token: 0x0600213D RID: 8509 RVA: 0x000AF8DC File Offset: 0x000ADADC
	[Token(Token = "0x600213D")]
	[Address(RVA = "0x563220", Offset = "0x561820", VA = "0x180563220")]
	private void Angry()
	{
		base.ChangeStatus((ZombieStatus)((uint)6));
	}

	// Token: 0x0600213E RID: 8510 RVA: 0x000AF8F4 File Offset: 0x000ADAF4
	[Token(Token = "0x600213E")]
	[Address(RVA = "0x563170", Offset = "0x561770", VA = "0x180563170")]
	public PaperCherryZ()
	{
	}

	// Token: 0x040010FB RID: 4347
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x40010FB")]
	public float theZombieAttackInterval = 0.75f;

	// Token: 0x040010FC RID: 4348
	[FieldOffset(Offset = "0x25C")]
	[Token(Token = "0x40010FC")]
	private float theZombieAttackCountDown;
}
