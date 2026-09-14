using System;
using Cpp2IlInjected;

// Token: 0x020007B5 RID: 1973
[Token(Token = "0x20007B5")]
[Serializable]
public struct JigSawData
{
	// Token: 0x0400165F RID: 5727
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400165F")]
	public int theColumn;

	// Token: 0x04001660 RID: 5728
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4001660")]
	public int theRow;

	// Token: 0x04001661 RID: 5729
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001661")]
	public JigsawType jigsawType;
}
