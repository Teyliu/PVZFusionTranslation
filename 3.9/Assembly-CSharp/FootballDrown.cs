using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006A1 RID: 1697
[Token(Token = "0x20006A1")]
public class FootballDrown : DrownZombie
{
	// Token: 0x06002054 RID: 8276 RVA: 0x000AB474 File Offset: 0x000A9674
	[Token(Token = "0x6002054")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "34")]
	protected override void LoseHeadEvent()
	{
	}

	// Token: 0x06002055 RID: 8277 RVA: 0x000AB484 File Offset: 0x000A9684
	[Token(Token = "0x6002055")]
	[Address(RVA = "0x5AA530", Offset = "0x5A8B30", VA = "0x1805AA530", Slot = "63")]
	protected override void FirstArmorBroken()
	{
		bool flag;
		if (!flag)
		{
			SpriteRenderer component = this.theFirstArmor.GetComponent<SpriteRenderer>();
			int num = 0;
			component.enabled = num != 0;
			Transform transform = this.theFirstArmor.transform;
			int num2 = 0;
			GameObject gameObject = transform.GetChild(num2).gameObject;
			int num3 = 0;
			gameObject.SetActive(num3 != 0);
			uint num4;
			ulong num5;
			this.theFirstArmor.transform.GetChild((int)num4).gameObject.SetActive(num5 != 0UL);
			return;
		}
		SpriteRenderer component2 = this.theFirstArmor.GetComponent<SpriteRenderer>();
		int num6 = 0;
		component2.enabled = num6 != 0;
		Transform transform2 = this.theFirstArmor.transform;
		int num7 = 0;
		ulong num8;
		transform2.GetChild(num7).gameObject.SetActive(num8 != 0UL);
		uint num9;
		GameObject gameObject2 = this.theFirstArmor.transform.GetChild((int)num9).gameObject;
		throw new NullReferenceException();
	}

	// Token: 0x06002056 RID: 8278 RVA: 0x000AB550 File Offset: 0x000A9750
	[Token(Token = "0x6002056")]
	[Address(RVA = "0x588740", Offset = "0x586D40", VA = "0x180588740", Slot = "65")]
	protected override int FirstArmorTakeDamage(int theDamage)
	{
		int theFirstArmorHealth = this.theFirstArmorHealth;
		int num = 0;
		this.theFirstArmorHealth = num;
		this.theFirstArmorType = (Zombie.FirstArmorType)num;
		this.theFirstArmor = num;
		return theDamage;
	}

	// Token: 0x06002057 RID: 8279 RVA: 0x000AB58C File Offset: 0x000A978C
	[Token(Token = "0x6002057")]
	[Address(RVA = "0x5A3FB0", Offset = "0x5A25B0", VA = "0x1805A3FB0")]
	public FootballDrown()
	{
	}
}
