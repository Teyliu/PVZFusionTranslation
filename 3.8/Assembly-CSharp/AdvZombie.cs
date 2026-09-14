using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200061D RID: 1565
[Token(Token = "0x200061D")]
public class AdvZombie : Zombie
{
	// Token: 0x06001D99 RID: 7577 RVA: 0x0009F48C File Offset: 0x0009D68C
	[Token(Token = "0x6001D99")]
	[Address(RVA = "0x519E30", Offset = "0x518430", VA = "0x180519E30", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x06001D9A RID: 7578 RVA: 0x0009F4CC File Offset: 0x0009D6CC
	[Token(Token = "0x6001D9A")]
	[Address(RVA = "0x519ED0", Offset = "0x5184D0", VA = "0x180519ED0")]
	public AdvZombie()
	{
	}
}
