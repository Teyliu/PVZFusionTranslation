using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200066C RID: 1644
[Token(Token = "0x200066C")]
public class BucketZombie : ArmorZombie
{
	// Token: 0x06001F27 RID: 7975 RVA: 0x000A5780 File Offset: 0x000A3980
	[Token(Token = "0x6001F27")]
	[Address(RVA = "0x58B530", Offset = "0x589B30", VA = "0x18058B530", Slot = "63")]
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

	// Token: 0x06001F28 RID: 7976 RVA: 0x000A57FC File Offset: 0x000A39FC
	[Token(Token = "0x6001F28")]
	[Address(RVA = "0x58B6B0", Offset = "0x589CB0", VA = "0x18058B6B0", Slot = "64")]
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

	// Token: 0x06001F29 RID: 7977 RVA: 0x000A5918 File Offset: 0x000A3B18
	[Token(Token = "0x6001F29")]
	[Address(RVA = "0x586E30", Offset = "0x585430", VA = "0x180586E30")]
	public BucketZombie()
	{
	}
}
