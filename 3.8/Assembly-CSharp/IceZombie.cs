using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200067F RID: 1663
[Token(Token = "0x200067F")]
public class IceZombie : Zombie
{
	// Token: 0x06001FEA RID: 8170 RVA: 0x000A97B0 File Offset: 0x000A79B0
	[Token(Token = "0x6001FEA")]
	[Address(RVA = "0x51A5B0", Offset = "0x518BB0", VA = "0x18051A5B0", Slot = "61")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x06001FEB RID: 8171 RVA: 0x000A97C0 File Offset: 0x000A79C0
	[Token(Token = "0x6001FEB")]
	[Address(RVA = "0x54FF60", Offset = "0x54E560", VA = "0x18054FF60", Slot = "63")]
	protected override int FirstArmorTakeDamage(int theDamage)
	{
		int theFirstArmorHealth = this.theFirstArmorHealth;
		global::UnityEngine.Object.Destroy(this.theFirstArmor);
		int num = 0;
		this.theFirstArmorHealth = num;
		this.theFirstArmorType = (Zombie.FirstArmorType)num;
		this.theFirstArmor = num;
		return theDamage;
	}

	// Token: 0x06001FEC RID: 8172 RVA: 0x000A9800 File Offset: 0x000A7A00
	[Token(Token = "0x6001FEC")]
	[Address(RVA = "0x54FEC0", Offset = "0x54E4C0", VA = "0x18054FEC0", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x06001FED RID: 8173 RVA: 0x000A9840 File Offset: 0x000A7A40
	[Token(Token = "0x6001FED")]
	[Address(RVA = "0x550020", Offset = "0x54E620", VA = "0x180550020", Slot = "54")]
	public override void SetCold(float time, int coldLevel = 0, bool freeze = false)
	{
		if (coldLevel > 0)
		{
			base.SetCold(time, coldLevel, freeze);
			return;
		}
	}

	// Token: 0x06001FEE RID: 8174 RVA: 0x000A985C File Offset: 0x000A7A5C
	[Token(Token = "0x6001FEE")]
	[Address(RVA = "0x550040", Offset = "0x54E640", VA = "0x180550040", Slot = "51")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		if (theFreezeLevel > 0)
		{
			int num = 0;
			base.SetFreeze(time, num);
			return;
		}
	}

	// Token: 0x06001FEF RID: 8175 RVA: 0x000A9878 File Offset: 0x000A7A78
	[Token(Token = "0x6001FEF")]
	[Address(RVA = "0x550060", Offset = "0x54E660", VA = "0x180550060")]
	public IceZombie()
	{
	}
}
