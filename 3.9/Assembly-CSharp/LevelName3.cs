using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020009EB RID: 2539
[Token(Token = "0x20009EB")]
public class LevelName3 : MonoBehaviour
{
	// Token: 0x06003403 RID: 13315 RVA: 0x00112C50 File Offset: 0x00110E50
	[Token(Token = "0x6003403")]
	[Address(RVA = "0x768880", Offset = "0x766E80", VA = "0x180768880")]
	private void Awake()
	{
		LevelName3.Instance = this;
	}

	// Token: 0x06003404 RID: 13316 RVA: 0x00112C64 File Offset: 0x00110E64
	[Token(Token = "0x6003404")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public LevelName3()
	{
	}

	// Token: 0x04002592 RID: 9618
	[Token(Token = "0x4002592")]
	public static LevelName3 Instance;
}
