using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200030A RID: 778
[Token(Token = "0x200030A")]
public class ChomperAttackRange : MonoBehaviour
{
	// Token: 0x06000E36 RID: 3638 RVA: 0x00051A5C File Offset: 0x0004FC5C
	[Token(Token = "0x6000E36")]
	[Address(RVA = "0x4459D0", Offset = "0x443FD0", VA = "0x1804459D0")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		Chomper chomper = this.chomper;
		throw new NullReferenceException();
	}

	// Token: 0x06000E37 RID: 3639 RVA: 0x00051A78 File Offset: 0x0004FC78
	[Token(Token = "0x6000E37")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public ChomperAttackRange()
	{
	}

	// Token: 0x04000B19 RID: 2841
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B19")]
	public Chomper chomper;
}
