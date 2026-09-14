using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000A04 RID: 2564
[Token(Token = "0x2000A04")]
public class TextHelper : MonoBehaviour
{
	// Token: 0x060034B0 RID: 13488 RVA: 0x00119FD4 File Offset: 0x001181D4
	[Token(Token = "0x60034B0")]
	[Address(RVA = "0x740250", Offset = "0x73E850", VA = "0x180740250")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
		string name = base.name;
		string name2 = collision.name;
		Debug.Log("我是" + name + "碰到了" + name2);
	}

	// Token: 0x060034B1 RID: 13489 RVA: 0x0011A00C File Offset: 0x0011820C
	[Token(Token = "0x60034B1")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public TextHelper()
	{
	}
}
