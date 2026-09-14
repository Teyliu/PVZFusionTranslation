using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200066B RID: 1643
[Token(Token = "0x200066B")]
public class FootballDrown : DrownZombie
{
	// Token: 0x06001F53 RID: 8019 RVA: 0x000A6BC4 File Offset: 0x000A4DC4
	[Token(Token = "0x6001F53")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "33")]
	protected override void LoseHeadEvent()
	{
	}

	// Token: 0x06001F54 RID: 8020 RVA: 0x000A6BD4 File Offset: 0x000A4DD4
	[Token(Token = "0x6001F54")]
	[Address(RVA = "0x547EA0", Offset = "0x5464A0", VA = "0x180547EA0", Slot = "61")]
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

	// Token: 0x06001F55 RID: 8021 RVA: 0x000A6CA0 File Offset: 0x000A4EA0
	[Token(Token = "0x6001F55")]
	[Address(RVA = "0x531BF0", Offset = "0x5301F0", VA = "0x180531BF0", Slot = "63")]
	protected override int FirstArmorTakeDamage(int theDamage)
	{
		int theFirstArmorHealth = this.theFirstArmorHealth;
		int num = 0;
		this.theFirstArmorHealth = num;
		this.theFirstArmorType = (Zombie.FirstArmorType)num;
		this.theFirstArmor = num;
		return theDamage;
	}

	// Token: 0x06001F56 RID: 8022 RVA: 0x000A6CDC File Offset: 0x000A4EDC
	[Token(Token = "0x6001F56")]
	[Address(RVA = "0x548110", Offset = "0x546710", VA = "0x180548110")]
	public FootballDrown()
	{
	}
}
