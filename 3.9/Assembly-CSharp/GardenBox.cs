using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200079A RID: 1946
[Token(Token = "0x200079A")]
public class GardenBox : MonoBehaviour
{
	// Token: 0x06002780 RID: 10112 RVA: 0x000D1650 File Offset: 0x000CF850
	[Token(Token = "0x6002780")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public GardenBox()
	{
	}

	// Token: 0x040014C0 RID: 5312
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40014C0")]
	public int column;

	// Token: 0x040014C1 RID: 5313
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40014C1")]
	public int row;
}
