using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000201 RID: 513
[Token(Token = "0x2000201")]
public class ElementBuffCard : SpecialCard
{
	// Token: 0x060008B0 RID: 2224 RVA: 0x0002C9F4 File Offset: 0x0002ABF4
	[Token(Token = "0x60008B0")]
	[Address(RVA = "0x8F66D0", Offset = "0x8F4CD0", VA = "0x1808F66D0", Slot = "10")]
	public override void ClickedEvent()
	{
		bool flag = Lawnf.UnlockRandomTravelBuff(this.board);
		global::UnityEngine.Object.Destroy(base.gameObject);
		GameAPP.PlaySound(125, 0.5f, 1f);
	}

	// Token: 0x060008B1 RID: 2225 RVA: 0x0002CA2C File Offset: 0x0002AC2C
	[Token(Token = "0x60008B1")]
	[Address(RVA = "0x8DF910", Offset = "0x8DDF10", VA = "0x1808DF910")]
	public ElementBuffCard()
	{
		this.d = 1f;
		base..ctor();
	}
}
