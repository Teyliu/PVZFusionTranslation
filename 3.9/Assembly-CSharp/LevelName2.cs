using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020009EA RID: 2538
[Token(Token = "0x20009EA")]
public class LevelName2 : MonoBehaviour
{
	// Token: 0x06003401 RID: 13313 RVA: 0x00112C28 File Offset: 0x00110E28
	[Token(Token = "0x6003401")]
	[Address(RVA = "0x768820", Offset = "0x766E20", VA = "0x180768820")]
	private void Awake()
	{
		LevelName2.Instance = this;
	}

	// Token: 0x06003402 RID: 13314 RVA: 0x00112C3C File Offset: 0x00110E3C
	[Token(Token = "0x6003402")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public LevelName2()
	{
	}

	// Token: 0x04002591 RID: 9617
	[Token(Token = "0x4002591")]
	public static LevelName2 Instance;
}
