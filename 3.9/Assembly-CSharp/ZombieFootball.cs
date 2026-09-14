using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000766 RID: 1894
[Token(Token = "0x2000766")]
public class ZombieFootball : ArmorZombie
{
	// Token: 0x0600267F RID: 9855 RVA: 0x000C9BBC File Offset: 0x000C7DBC
	[Token(Token = "0x600267F")]
	[Address(RVA = "0x6345A0", Offset = "0x632BA0", VA = "0x1806345A0", Slot = "63")]
	protected override void FirstArmorBroken()
	{
		int num = this.theFirstArmorMaxHealth;
		num += num;
		GameObject theFirstArmor = this.theFirstArmor;
		this.theFirstArmorBroken = (int)((ulong)1L);
		SpriteRenderer component = theFirstArmor.GetComponent<SpriteRenderer>();
		Sprite sprite = GameAPP.spritePrefab[20];
		component.sprite = sprite;
		GameObject theFirstArmor2 = this.theFirstArmor;
		this.theFirstArmorBroken = (int)((ulong)2L);
		SpriteRenderer component2 = theFirstArmor2.GetComponent<SpriteRenderer>();
		Sprite sprite2 = GameAPP.spritePrefab[21];
		component2.sprite = sprite2;
	}

	// Token: 0x06002680 RID: 9856 RVA: 0x000C9C38 File Offset: 0x000C7E38
	[Token(Token = "0x6002680")]
	[Address(RVA = "0x634730", Offset = "0x632D30", VA = "0x180634730", Slot = "64")]
	protected override void FirstArmorFall()
	{
		int num;
		do
		{
			num = 0;
			Transform transform = base.transform;
			int num2 = 0;
			IEnumerator enumerator = transform.GetEnumerator();
			if (num < num2)
			{
				num += num;
				num++;
			}
			num += num;
			num++;
			enumerator += enumerator;
			enumerator += enumerator;
			string text;
			while (text == 0)
			{
			}
			GameObject gameObject;
			ulong num3;
			gameObject.SetActive(num3 != 0UL);
			GameObject gameObject2;
			ParticleSystemRenderer component = gameObject2.GetComponent<ParticleSystemRenderer>();
			int theZombieRow = this.theZombieRow;
			string text2 = string.Format("zombie{0}", component);
			component.sortingLayerName = text2;
			GameObject gameObject3;
			ParticleSystemRenderer component2 = gameObject3.GetComponent<ParticleSystemRenderer>();
			int num4 = this.sortingGroup.sortingOrder + 1;
			component2.sortingOrder = num4;
			GameObject gameObject4;
			ParticleSystem.MainModule main = gameObject4.GetComponent<ParticleSystem>().main;
			List<Transform> plane = this.board.plane;
			int theZombieRow2 = this.theZombieRow;
			Transform transform2 = plane[theZombieRow2];
		}
		while (num != 0);
	}

	// Token: 0x06002681 RID: 9857 RVA: 0x000C9D54 File Offset: 0x000C7F54
	[Token(Token = "0x6002681")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
	}

	// Token: 0x06002682 RID: 9858 RVA: 0x000C9D64 File Offset: 0x000C7F64
	[Token(Token = "0x6002682")]
	[Address(RVA = "0x59C5A0", Offset = "0x59ABA0", VA = "0x18059C5A0")]
	public ZombieFootball()
	{
	}
}
