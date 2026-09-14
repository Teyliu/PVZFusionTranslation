using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000642 RID: 1602
[Token(Token = "0x2000642")]
public class ConeZombie : ArmorZombie
{
	// Token: 0x06001E6F RID: 7791 RVA: 0x000A2A8C File Offset: 0x000A0C8C
	[Token(Token = "0x6001E6F")]
	[Address(RVA = "0x539A30", Offset = "0x538030", VA = "0x180539A30", Slot = "61")]
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

	// Token: 0x06001E70 RID: 7792 RVA: 0x000A2B08 File Offset: 0x000A0D08
	[Token(Token = "0x6001E70")]
	[Address(RVA = "0x539BB0", Offset = "0x5381B0", VA = "0x180539BB0", Slot = "62")]
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

	// Token: 0x06001E71 RID: 7793 RVA: 0x000A2C24 File Offset: 0x000A0E24
	[Token(Token = "0x6001E71")]
	[Address(RVA = "0x5302B0", Offset = "0x52E8B0", VA = "0x1805302B0")]
	public ConeZombie()
	{
	}
}
