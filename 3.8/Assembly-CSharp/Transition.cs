using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000882 RID: 2178
[Token(Token = "0x2000882")]
public class Transition : MonoBehaviour
{
	// Token: 0x06002C7B RID: 11387 RVA: 0x000F52EC File Offset: 0x000F34EC
	[Token(Token = "0x6002C7B")]
	[Address(RVA = "0x688210", Offset = "0x686810", VA = "0x180688210")]
	public void FadeCenter()
	{
		if (this.center != 0)
		{
		}
	}

	// Token: 0x06002C7C RID: 11388 RVA: 0x000F5304 File Offset: 0x000F3504
	[Token(Token = "0x6002C7C")]
	[Address(RVA = "0x688230", Offset = "0x686830", VA = "0x180688230")]
	public void FadeOver()
	{
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06002C7D RID: 11389 RVA: 0x000F531C File Offset: 0x000F351C
	[Token(Token = "0x6002C7D")]
	[Address(RVA = "0x688290", Offset = "0x686890", VA = "0x180688290")]
	public static Transition Set()
	{
		return global::UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("UI/Transition/Transition")).GetComponent<Transition>();
	}

	// Token: 0x06002C7E RID: 11390 RVA: 0x000F5344 File Offset: 0x000F3544
	[Token(Token = "0x6002C7E")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public Transition()
	{
	}

	// Token: 0x04001A99 RID: 6809
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001A99")]
	public Action center;
}
