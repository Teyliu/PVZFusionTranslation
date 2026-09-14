using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000239 RID: 569
[Token(Token = "0x2000239")]
public class TreasurePoint : MonoBehaviour
{
	// Token: 0x06000A06 RID: 2566 RVA: 0x0003683C File Offset: 0x00034A3C
	[Token(Token = "0x6000A06")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public TreasurePoint()
	{
	}

	// Token: 0x04000555 RID: 1365
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000555")]
	public int theColumn;

	// Token: 0x04000556 RID: 1366
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000556")]
	public int theRow;
}
