using System;
using Cpp2IlInjected;

// Token: 0x020007EE RID: 2030
[Token(Token = "0x20007EE")]
[Serializable]
public struct JigSawData
{
	// Token: 0x0400173B RID: 5947
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400173B")]
	public int theColumn;

	// Token: 0x0400173C RID: 5948
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400173C")]
	public int theRow;

	// Token: 0x0400173D RID: 5949
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400173D")]
	public JigsawType jigsawType;
}
