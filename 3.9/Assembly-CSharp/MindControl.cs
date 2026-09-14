using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002F6 RID: 758
[Token(Token = "0x20002F6")]
public class MindControl : MonoBehaviour
{
	// Token: 0x06000D99 RID: 3481 RVA: 0x0004DCA4 File Offset: 0x0004BEA4
	[Token(Token = "0x6000D99")]
	[Address(RVA = "0x448F10", Offset = "0x447510", VA = "0x180448F10")]
	private void Die()
	{
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06000D9A RID: 3482 RVA: 0x0004DCBC File Offset: 0x0004BEBC
	[Token(Token = "0x6000D9A")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public MindControl()
	{
	}
}
