using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000713 RID: 1811
[Token(Token = "0x2000713")]
public class SuperDoorZombie : DoorZombie
{
	// Token: 0x060023AA RID: 9130 RVA: 0x000B9D9C File Offset: 0x000B7F9C
	[Token(Token = "0x60023AA")]
	[Address(RVA = "0x5D8200", Offset = "0x5D6800", VA = "0x1805D8200", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 0.5f;
	}

	// Token: 0x060023AB RID: 9131 RVA: 0x000B9DBC File Offset: 0x000B7FBC
	[Token(Token = "0x60023AB")]
	[Address(RVA = "0x5D8220", Offset = "0x5D6820", VA = "0x1805D8220", Slot = "63")]
	protected override void FirstArmorBroken()
	{
		int num = this.theFirstArmorMaxHealth;
		num += num;
		GameObject theFirstArmor = this.theFirstArmor;
		this.theFirstArmorBroken = (int)((ulong)1L);
		SpriteRenderer component = theFirstArmor.GetComponent<SpriteRenderer>();
		Sprite sprite = GameAPP.spritePrefab[3];
		component.sprite = sprite;
		GameObject theFirstArmor2 = this.theFirstArmor;
		this.theFirstArmorBroken = (int)((ulong)2L);
		SpriteRenderer component2 = theFirstArmor2.GetComponent<SpriteRenderer>();
		Sprite sprite2 = GameAPP.spritePrefab[4];
		component2.sprite = sprite2;
	}

	// Token: 0x060023AC RID: 9132 RVA: 0x000B9E38 File Offset: 0x000B8038
	[Token(Token = "0x60023AC")]
	[Address(RVA = "0x5D83A0", Offset = "0x5D69A0", VA = "0x1805D83A0", Slot = "64")]
	protected override void FirstArmorFall()
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
				GameObject gameObject4;
				ParticleSystem.MainModule main = gameObject4.GetComponent<ParticleSystem>().main;
				List<Transform> plane = this.board.plane;
				int theZombieRow2 = this.theZombieRow;
				Transform transform = plane[theZombieRow2];
			}
			if (enumerator != 0)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x060023AD RID: 9133 RVA: 0x000B9F54 File Offset: 0x000B8154
	[Token(Token = "0x60023AD")]
	[Address(RVA = "0x5D81A0", Offset = "0x5D67A0", VA = "0x1805D81A0", Slot = "24")]
	protected override void AttributeEvent()
	{
		base.ZombieUpdate();
		Animator anim = this.anim;
		this.attributeCountDown = 1.5f;
		anim.SetTrigger("shoot");
	}

	// Token: 0x060023AE RID: 9134 RVA: 0x000B9F8C File Offset: 0x000B818C
	[Token(Token = "0x60023AE")]
	[Address(RVA = "0x5D7FF0", Offset = "0x5D65F0", VA = "0x1805D7FF0")]
	private void AnimShoot()
	{
		Transform transform = base.transform.Find("Shoot");
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		bullet.Damage = 80;
	}

	// Token: 0x060023AF RID: 9135 RVA: 0x000B9FC8 File Offset: 0x000B81C8
	[Token(Token = "0x60023AF")]
	[Address(RVA = "0x58B130", Offset = "0x589730", VA = "0x18058B130")]
	public SuperDoorZombie()
	{
	}
}
