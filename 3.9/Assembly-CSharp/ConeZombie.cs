using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000678 RID: 1656
[Token(Token = "0x2000678")]
public class ConeZombie : ArmorZombie
{
	// Token: 0x06001F71 RID: 8049 RVA: 0x000A71D8 File Offset: 0x000A53D8
	[Token(Token = "0x6001F71")]
	[Address(RVA = "0x59C000", Offset = "0x59A600", VA = "0x18059C000", Slot = "63")]
	protected override void FirstArmorBroken()
	{
		int num = this.theFirstArmorMaxHealth;
		num += num;
		GameObject theFirstArmor = this.theFirstArmor;
		this.theFirstArmorBroken = (int)((ulong)1L);
		SpriteRenderer component = theFirstArmor.GetComponent<SpriteRenderer>();
		Sprite sprite = GameAPP.spritePrefab[1];
		component.sprite = sprite;
		GameObject theFirstArmor2 = this.theFirstArmor;
		this.theFirstArmorBroken = (int)((ulong)2L);
		SpriteRenderer component2 = theFirstArmor2.GetComponent<SpriteRenderer>();
		Sprite sprite2 = GameAPP.spritePrefab[2];
		component2.sprite = sprite2;
	}

	// Token: 0x06001F72 RID: 8050 RVA: 0x000A7254 File Offset: 0x000A5454
	[Token(Token = "0x6001F72")]
	[Address(RVA = "0x59C180", Offset = "0x59A780", VA = "0x18059C180", Slot = "64")]
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

	// Token: 0x06001F73 RID: 8051 RVA: 0x000A7370 File Offset: 0x000A5570
	[Token(Token = "0x6001F73")]
	[Address(RVA = "0x59C5A0", Offset = "0x59ABA0", VA = "0x18059C5A0")]
	public ConeZombie()
	{
	}
}
