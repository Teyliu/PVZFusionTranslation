using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000636 RID: 1590
[Token(Token = "0x2000636")]
public class BucketZombie : ArmorZombie
{
	// Token: 0x06001E25 RID: 7717 RVA: 0x000A1030 File Offset: 0x0009F230
	[Token(Token = "0x6001E25")]
	[Address(RVA = "0x534850", Offset = "0x532E50", VA = "0x180534850", Slot = "61")]
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

	// Token: 0x06001E26 RID: 7718 RVA: 0x000A10AC File Offset: 0x0009F2AC
	[Token(Token = "0x6001E26")]
	[Address(RVA = "0x5349D0", Offset = "0x532FD0", VA = "0x1805349D0", Slot = "62")]
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

	// Token: 0x06001E27 RID: 7719 RVA: 0x000A11C8 File Offset: 0x0009F3C8
	[Token(Token = "0x6001E27")]
	[Address(RVA = "0x5302B0", Offset = "0x52E8B0", VA = "0x1805302B0")]
	public BucketZombie()
	{
	}
}
