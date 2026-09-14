using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020009AF RID: 2479
[Token(Token = "0x20009AF")]
public class LevelName3 : MonoBehaviour
{
	// Token: 0x060032CF RID: 13007 RVA: 0x0010DC38 File Offset: 0x0010BE38
	[Token(Token = "0x60032CF")]
	[Address(RVA = "0x703370", Offset = "0x701970", VA = "0x180703370")]
	private void Awake()
	{
		LevelName3.Instance = this;
	}

	// Token: 0x060032D0 RID: 13008 RVA: 0x0010DC4C File Offset: 0x0010BE4C
	[Token(Token = "0x60032D0")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public LevelName3()
	{
	}

	// Token: 0x04002480 RID: 9344
	[Token(Token = "0x4002480")]
	public static LevelName3 Instance;
}
