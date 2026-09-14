using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200023F RID: 575
[Token(Token = "0x200023F")]
public class TreasurePoint : MonoBehaviour
{
	// Token: 0x06000A21 RID: 2593 RVA: 0x00036738 File Offset: 0x00034938
	[Token(Token = "0x6000A21")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public TreasurePoint()
	{
	}

	// Token: 0x04000560 RID: 1376
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000560")]
	public int theColumn;

	// Token: 0x04000561 RID: 1377
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000561")]
	public int theRow;
}
