using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200067F RID: 1663
[Token(Token = "0x200067F")]
public class DolphinPaper : PaperZombie
{
	// Token: 0x06001F8B RID: 8075 RVA: 0x000A7B68 File Offset: 0x000A5D68
	[Token(Token = "0x6001F8B")]
	[Address(RVA = "0x58B3E0", Offset = "0x5899E0", VA = "0x18058B3E0", Slot = "66")]
	protected override void SecondArmorBroken()
	{
	}

	// Token: 0x06001F8C RID: 8076 RVA: 0x000A7B78 File Offset: 0x000A5D78
	[Token(Token = "0x6001F8C")]
	[Address(RVA = "0x59E190", Offset = "0x59C790", VA = "0x18059E190", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x06001F8D RID: 8077 RVA: 0x000A7BB8 File Offset: 0x000A5DB8
	[Token(Token = "0x6001F8D")]
	[Address(RVA = "0x59E100", Offset = "0x59C700", VA = "0x18059E100", Slot = "77")]
	protected override void Angry()
	{
		base.Angry();
		this.towards = (Towards)((ulong)1L);
		Transform transform = base.transform;
		this.uniqueSpeed = 4f;
	}

	// Token: 0x06001F8E RID: 8078 RVA: 0x000A7BF0 File Offset: 0x000A5DF0
	[Token(Token = "0x6001F8E")]
	[Address(RVA = "0x59E230", Offset = "0x59C830", VA = "0x18059E230", Slot = "20")]
	protected override void OverRangeDie()
	{
		Transform axis = this.axis;
		Transform axis2 = this.axis;
		float deadLeft = this.deadLeft;
	}

	// Token: 0x06001F8F RID: 8079 RVA: 0x000A7C88 File Offset: 0x000A5E88
	[Token(Token = "0x6001F8F")]
	[Address(RVA = "0x58B130", Offset = "0x589730", VA = "0x18058B130")]
	public DolphinPaper()
	{
	}
}
