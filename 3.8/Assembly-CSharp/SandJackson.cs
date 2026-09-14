using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006C1 RID: 1729
[Token(Token = "0x20006C1")]
public class SandJackson : ZombieJackson
{
	// Token: 0x060021FD RID: 8701 RVA: 0x000B2B48 File Offset: 0x000B0D48
	[Token(Token = "0x60021FD")]
	[Address(RVA = "0x56D2D0", Offset = "0x56B8D0", VA = "0x18056D2D0", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x060021FE RID: 8702 RVA: 0x000B2B88 File Offset: 0x000B0D88
	[Token(Token = "0x60021FE")]
	[Address(RVA = "0x56D370", Offset = "0x56B970", VA = "0x18056D370", Slot = "74")]
	protected override ZombieType GetZombieType()
	{
		return ZombieType.StoneDancer;
	}

	// Token: 0x060021FF RID: 8703 RVA: 0x000B2B98 File Offset: 0x000B0D98
	[Token(Token = "0x60021FF")]
	[Address(RVA = "0x56AF90", Offset = "0x569590", VA = "0x18056AF90")]
	public SandJackson()
	{
	}
}
