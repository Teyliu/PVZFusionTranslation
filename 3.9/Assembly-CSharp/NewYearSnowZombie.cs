using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006DB RID: 1755
[Token(Token = "0x20006DB")]
public class NewYearSnowZombie : ConeZombie
{
	// Token: 0x0600222D RID: 8749 RVA: 0x000B3B18 File Offset: 0x000B1D18
	[Token(Token = "0x600222D")]
	[Address(RVA = "0x5C4490", Offset = "0x5C2A90", VA = "0x1805C4490", Slot = "63")]
	protected override void FirstArmorBroken()
	{
		GameObject theFirstArmor = this.theFirstArmor;
		bool flag;
		if (!flag)
		{
			ulong num;
			theFirstArmor.GetComponent<SpriteRenderer>().enabled = num != 0UL;
			Transform transform = this.theFirstArmor.transform;
			int num2 = 0;
			GameObject gameObject = transform.GetChild(num2).gameObject;
			int num3 = 0;
			SpriteRenderer spriteRenderer;
			spriteRenderer.enabled = num3 != 0;
			Transform transform2 = this.theFirstArmor.transform;
			int num4 = 0;
			GameObject gameObject2 = transform2.GetChild(num4).gameObject;
			int num5 = 0;
			gameObject2.SetActive(num5 != 0);
			uint num6;
			ulong num7;
			this.theFirstArmor.transform.GetChild((int)num6).gameObject.SetActive(num7 != 0UL);
			return;
		}
		SpriteRenderer component = theFirstArmor.GetComponent<SpriteRenderer>();
		int num8 = 0;
		component.enabled = num8 != 0;
		Transform transform3 = this.theFirstArmor.transform;
		int num9 = 0;
		ulong num10;
		transform3.GetChild(num9).gameObject.SetActive(num10 != 0UL);
		uint num11;
		GameObject gameObject3 = this.theFirstArmor.transform.GetChild((int)num11).gameObject;
		throw new NullReferenceException();
	}

	// Token: 0x0600222E RID: 8750 RVA: 0x000B3C0C File Offset: 0x000B1E0C
	[Token(Token = "0x600222E")]
	[Address(RVA = "0x5C43F0", Offset = "0x5C29F0", VA = "0x1805C43F0", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x0600222F RID: 8751 RVA: 0x000B3C4C File Offset: 0x000B1E4C
	[Token(Token = "0x600222F")]
	[Address(RVA = "0x58B130", Offset = "0x589730", VA = "0x18058B130")]
	public NewYearSnowZombie()
	{
	}
}
