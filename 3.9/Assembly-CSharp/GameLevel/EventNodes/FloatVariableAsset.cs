using System;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000C32 RID: 3122
	[Token(Token = "0x2000C32")]
	[Serializable]
	public class FloatVariableAsset : VariableAsset
	{
		// Token: 0x06004116 RID: 16662 RVA: 0x00157238 File Offset: 0x00155438
		[Token(Token = "0x6004116")]
		[Address(RVA = "0x87E670", Offset = "0x87CC70", VA = "0x18087E670")]
		public FloatVariableAsset()
		{
		}

		// Token: 0x040031F0 RID: 12784
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40031F0")]
		public float value;
	}
}
