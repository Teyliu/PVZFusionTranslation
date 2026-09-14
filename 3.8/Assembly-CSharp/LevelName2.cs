using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020009AE RID: 2478
[Token(Token = "0x20009AE")]
public class LevelName2 : MonoBehaviour
{
	// Token: 0x060032CD RID: 13005 RVA: 0x0010DC10 File Offset: 0x0010BE10
	[Token(Token = "0x60032CD")]
	[Address(RVA = "0x703310", Offset = "0x701910", VA = "0x180703310")]
	private void Awake()
	{
		LevelName2.Instance = this;
	}

	// Token: 0x060032CE RID: 13006 RVA: 0x0010DC24 File Offset: 0x0010BE24
	[Token(Token = "0x60032CE")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public LevelName2()
	{
	}

	// Token: 0x0400247F RID: 9343
	[Token(Token = "0x400247F")]
	public static LevelName2 Instance;
}
