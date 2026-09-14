using System;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000C33 RID: 3123
	[Token(Token = "0x2000C33")]
	[Serializable]
	public class BoolVariableAsset : VariableAsset
	{
		// Token: 0x06004117 RID: 16663 RVA: 0x0015724C File Offset: 0x0015544C
		[Token(Token = "0x6004117")]
		[Address(RVA = "0x87E670", Offset = "0x87CC70", VA = "0x18087E670")]
		public BoolVariableAsset()
		{
		}

		// Token: 0x040031F1 RID: 12785
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40031F1")]
		public bool value;
	}
}
