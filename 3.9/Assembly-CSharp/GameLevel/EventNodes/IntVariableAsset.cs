using System;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000C31 RID: 3121
	[Token(Token = "0x2000C31")]
	[Serializable]
	public class IntVariableAsset : VariableAsset
	{
		// Token: 0x06004115 RID: 16661 RVA: 0x00157224 File Offset: 0x00155424
		[Token(Token = "0x6004115")]
		[Address(RVA = "0x87E670", Offset = "0x87CC70", VA = "0x18087E670")]
		public IntVariableAsset()
		{
		}

		// Token: 0x040031EF RID: 12783
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40031EF")]
		public int value;
	}
}
