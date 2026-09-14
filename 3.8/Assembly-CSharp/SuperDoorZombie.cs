using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006DB RID: 1755
[Token(Token = "0x20006DB")]
public class SuperDoorZombie : DoorZombie
{
	// Token: 0x06002290 RID: 8848 RVA: 0x000B5040 File Offset: 0x000B3240
	[Token(Token = "0x6002290")]
	[Address(RVA = "0x574C90", Offset = "0x573290", VA = "0x180574C90", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 0.5f;
	}

	// Token: 0x06002291 RID: 8849 RVA: 0x000B5060 File Offset: 0x000B3260
	[Token(Token = "0x6002291")]
	[Address(RVA = "0x574CB0", Offset = "0x5732B0", VA = "0x180574CB0", Slot = "61")]
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

	// Token: 0x06002292 RID: 8850 RVA: 0x000B50DC File Offset: 0x000B32DC
	[Token(Token = "0x6002292")]
	[Address(RVA = "0x574E30", Offset = "0x573430", VA = "0x180574E30", Slot = "62")]
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

	// Token: 0x06002293 RID: 8851 RVA: 0x000B51F8 File Offset: 0x000B33F8
	[Token(Token = "0x6002293")]
	[Address(RVA = "0x574C30", Offset = "0x573230", VA = "0x180574C30", Slot = "23")]
	protected override void AttributeEvent()
	{
		base.ZombieUpdate();
		Animator anim = this.anim;
		this.attributeCountDown = 1.5f;
		anim.SetTrigger("shoot");
	}

	// Token: 0x06002294 RID: 8852 RVA: 0x000B5230 File Offset: 0x000B3430
	[Token(Token = "0x6002294")]
	[Address(RVA = "0x574A80", Offset = "0x573080", VA = "0x180574A80")]
	private void AnimShoot()
	{
		Transform transform = base.transform.Find("Shoot");
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		bullet.Damage = 80;
	}

	// Token: 0x06002295 RID: 8853 RVA: 0x000B526C File Offset: 0x000B346C
	[Token(Token = "0x6002295")]
	[Address(RVA = "0x55BE80", Offset = "0x55A480", VA = "0x18055BE80")]
	public SuperDoorZombie()
	{
	}
}
