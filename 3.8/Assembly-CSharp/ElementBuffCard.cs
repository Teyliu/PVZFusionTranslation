using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001FA RID: 506
[Token(Token = "0x20001FA")]
public class ElementBuffCard : SpecialCard
{
	// Token: 0x06000896 RID: 2198 RVA: 0x0002C9C8 File Offset: 0x0002ABC8
	[Token(Token = "0x6000896")]
	[Address(RVA = "0x867980", Offset = "0x865F80", VA = "0x180867980", Slot = "10")]
	public override void ClickedEvent()
	{
		bool flag = Lawnf.UnlockRandomTravelBuff(this.board);
		global::UnityEngine.Object.Destroy(base.gameObject);
		GameAPP.PlaySound(125, 0.5f, 1f);
	}

	// Token: 0x06000897 RID: 2199 RVA: 0x0002CA00 File Offset: 0x0002AC00
	[Token(Token = "0x6000897")]
	[Address(RVA = "0x8516E0", Offset = "0x84FCE0", VA = "0x1808516E0")]
	public ElementBuffCard()
	{
		this.d = 1f;
		base..ctor();
	}
}
