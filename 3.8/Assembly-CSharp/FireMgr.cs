using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002E5 RID: 741
[Token(Token = "0x20002E5")]
public class FireMgr : MonoBehaviour
{
	// Token: 0x06000D4E RID: 3406 RVA: 0x0004CF10 File Offset: 0x0004B110
	[Token(Token = "0x6000D4E")]
	[Address(RVA = "0x3E0FB0", Offset = "0x3DF5B0", VA = "0x1803E0FB0")]
	private void Die()
	{
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06000D4F RID: 3407 RVA: 0x0004CF28 File Offset: 0x0004B128
	[Token(Token = "0x6000D4F")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public FireMgr()
	{
	}
}
