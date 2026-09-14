using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000459 RID: 1113
[Token(Token = "0x2000459")]
public class SunPot : MoneyPot
{
	// Token: 0x06001481 RID: 5249 RVA: 0x00071F8C File Offset: 0x0007018C
	[Token(Token = "0x6001481")]
	[Address(RVA = "0x4C7EA0", Offset = "0x4C64A0", VA = "0x1804C7EA0", Slot = "69")]
	protected override void Produce()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.5f, 1f);
		CreateItem instance = CreateItem.Instance;
	}

	// Token: 0x06001482 RID: 5250 RVA: 0x00071FC0 File Offset: 0x000701C0
	[Token(Token = "0x6001482")]
	[Address(RVA = "0x472EF0", Offset = "0x4714F0", VA = "0x180472EF0")]
	public SunPot()
	{
	}
}
