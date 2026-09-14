using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002E8 RID: 744
[Token(Token = "0x20002E8")]
public class MindControl : MonoBehaviour
{
	// Token: 0x06000D56 RID: 3414 RVA: 0x0004D030 File Offset: 0x0004B230
	[Token(Token = "0x6000D56")]
	[Address(RVA = "0x3EA7D0", Offset = "0x3E8DD0", VA = "0x1803EA7D0")]
	private void Die()
	{
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06000D57 RID: 3415 RVA: 0x0004D048 File Offset: 0x0004B248
	[Token(Token = "0x6000D57")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public MindControl()
	{
	}
}
