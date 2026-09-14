using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200043A RID: 1082
[Token(Token = "0x200043A")]
public class SunPot : MoneyPot
{
	// Token: 0x060013F7 RID: 5111 RVA: 0x0006FCDC File Offset: 0x0006DEDC
	[Token(Token = "0x60013F7")]
	[Address(RVA = "0x470640", Offset = "0x46EC40", VA = "0x180470640", Slot = "70")]
	protected override void Produce()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.5f, 1f);
		CreateItem instance = CreateItem.Instance;
	}

	// Token: 0x060013F8 RID: 5112 RVA: 0x0006FD10 File Offset: 0x0006DF10
	[Token(Token = "0x60013F8")]
	[Address(RVA = "0x41C050", Offset = "0x41A650", VA = "0x18041C050")]
	public SunPot()
	{
	}
}
