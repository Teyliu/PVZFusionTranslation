using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002F3 RID: 755
[Token(Token = "0x20002F3")]
public class FireMgr : MonoBehaviour
{
	// Token: 0x06000D91 RID: 3473 RVA: 0x0004DB84 File Offset: 0x0004BD84
	[Token(Token = "0x6000D91")]
	[Address(RVA = "0x42F8C0", Offset = "0x42DEC0", VA = "0x18042F8C0")]
	private void Die()
	{
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06000D92 RID: 3474 RVA: 0x0004DB9C File Offset: 0x0004BD9C
	[Token(Token = "0x6000D92")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public FireMgr()
	{
	}
}
