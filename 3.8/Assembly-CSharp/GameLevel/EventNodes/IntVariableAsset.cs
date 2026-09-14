using System;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BEF RID: 3055
	[Token(Token = "0x2000BEF")]
	[Serializable]
	public class IntVariableAsset : VariableAsset
	{
		// Token: 0x06003FC4 RID: 16324 RVA: 0x00151FF4 File Offset: 0x001501F4
		[Token(Token = "0x6003FC4")]
		[Address(RVA = "0x80B9C0", Offset = "0x809FC0", VA = "0x18080B9C0")]
		public IntVariableAsset()
		{
		}

		// Token: 0x0400307C RID: 12412
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400307C")]
		public int value;
	}
}
