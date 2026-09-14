using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006A4 RID: 1700
[Token(Token = "0x20006A4")]
public class NewYearSnowZombie : ConeZombie
{
	// Token: 0x06002116 RID: 8470 RVA: 0x000AEE6C File Offset: 0x000AD06C
	[Token(Token = "0x6002116")]
	[Address(RVA = "0x5616A0", Offset = "0x55FCA0", VA = "0x1805616A0", Slot = "61")]
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

	// Token: 0x06002117 RID: 8471 RVA: 0x000AEF60 File Offset: 0x000AD160
	[Token(Token = "0x6002117")]
	[Address(RVA = "0x561600", Offset = "0x55FC00", VA = "0x180561600", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x06002118 RID: 8472 RVA: 0x000AEFA0 File Offset: 0x000AD1A0
	[Token(Token = "0x6002118")]
	[Address(RVA = "0x55BE80", Offset = "0x55A480", VA = "0x18055BE80")]
	public NewYearSnowZombie()
	{
	}
}
