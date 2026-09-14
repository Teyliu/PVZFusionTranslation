using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000671 RID: 1649
[Token(Token = "0x2000671")]
public class Charred : MonoBehaviour
{
	// Token: 0x06001F57 RID: 8023 RVA: 0x000A6B08 File Offset: 0x000A4D08
	[Token(Token = "0x6001F57")]
	[Address(RVA = "0x58F2E0", Offset = "0x58D8E0", VA = "0x18058F2E0")]
	public void Die()
	{
		global::UnityEngine.Object.Destroy(base.gameObject, 0.2f);
	}

	// Token: 0x06001F58 RID: 8024 RVA: 0x000A6B28 File Offset: 0x000A4D28
	[Token(Token = "0x6001F58")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public Charred()
	{
	}
}
