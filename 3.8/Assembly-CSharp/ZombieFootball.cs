using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200072D RID: 1837
[Token(Token = "0x200072D")]
public class ZombieFootball : ArmorZombie
{
	// Token: 0x0600255A RID: 9562 RVA: 0x000C4C94 File Offset: 0x000C2E94
	[Token(Token = "0x600255A")]
	[Address(RVA = "0x5D3180", Offset = "0x5D1780", VA = "0x1805D3180", Slot = "61")]
	protected override void FirstArmorBroken()
	{
		int num = this.theFirstArmorMaxHealth;
		num += num;
		GameObject theFirstArmor = this.theFirstArmor;
		this.theFirstArmorBroken = (int)((ulong)1L);
		SpriteRenderer component = theFirstArmor.GetComponent<SpriteRenderer>();
		Sprite sprite = GameAPP.spritePrefab[20];
		component.sprite = sprite;
		sprite += sprite;
		GameObject theFirstArmor2 = this.theFirstArmor;
		this.theFirstArmorBroken = (int)((ulong)2L);
		SpriteRenderer component2 = theFirstArmor2.GetComponent<SpriteRenderer>();
		Sprite sprite2 = GameAPP.spritePrefab[21];
		component2.sprite = sprite2;
	}

	// Token: 0x0600255B RID: 9563 RVA: 0x000C4D14 File Offset: 0x000C2F14
	[Token(Token = "0x600255B")]
	[Address(RVA = "0x5D3310", Offset = "0x5D1910", VA = "0x1805D3310", Slot = "62")]
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

	// Token: 0x0600255C RID: 9564 RVA: 0x000C4E30 File Offset: 0x000C3030
	[Token(Token = "0x600255C")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
	}

	// Token: 0x0600255D RID: 9565 RVA: 0x000C4E40 File Offset: 0x000C3040
	[Token(Token = "0x600255D")]
	[Address(RVA = "0x55BE80", Offset = "0x55A480", VA = "0x18055BE80")]
	public ZombieFootball()
	{
	}
}
