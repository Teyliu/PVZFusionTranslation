using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000761 RID: 1889
[Token(Token = "0x2000761")]
public class GardenBox : MonoBehaviour
{
	// Token: 0x06002659 RID: 9817 RVA: 0x000CC620 File Offset: 0x000CA820
	[Token(Token = "0x6002659")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public GardenBox()
	{
	}

	// Token: 0x040013E8 RID: 5096
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40013E8")]
	public int column;

	// Token: 0x040013E9 RID: 5097
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40013E9")]
	public int row;
}
