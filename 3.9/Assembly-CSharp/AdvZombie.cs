using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000652 RID: 1618
[Token(Token = "0x2000652")]
public class AdvZombie : Zombie
{
	// Token: 0x06001E98 RID: 7832 RVA: 0x000A3A9C File Offset: 0x000A1C9C
	[Token(Token = "0x6001E98")]
	[Address(RVA = "0x5862B0", Offset = "0x5848B0", VA = "0x1805862B0", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x06001E99 RID: 7833 RVA: 0x000A3ADC File Offset: 0x000A1CDC
	[Token(Token = "0x6001E99")]
	[Address(RVA = "0x586350", Offset = "0x584950", VA = "0x180586350")]
	public AdvZombie()
	{
	}
}
