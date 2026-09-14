using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002FA RID: 762
[Token(Token = "0x20002FA")]
public class ChomperAttackRange : MonoBehaviour
{
	// Token: 0x06000DEE RID: 3566 RVA: 0x00050B54 File Offset: 0x0004ED54
	[Token(Token = "0x6000DEE")]
	[Address(RVA = "0x401710", Offset = "0x3FFD10", VA = "0x180401710")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		Chomper chomper = this.chomper;
		throw new NullReferenceException();
	}

	// Token: 0x06000DEF RID: 3567 RVA: 0x00050B70 File Offset: 0x0004ED70
	[Token(Token = "0x6000DEF")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public ChomperAttackRange()
	{
	}

	// Token: 0x04000AC8 RID: 2760
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000AC8")]
	public Chomper chomper;
}
