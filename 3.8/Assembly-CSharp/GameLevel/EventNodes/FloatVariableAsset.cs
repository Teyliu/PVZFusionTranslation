using System;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BF0 RID: 3056
	[Token(Token = "0x2000BF0")]
	[Serializable]
	public class FloatVariableAsset : VariableAsset
	{
		// Token: 0x06003FC5 RID: 16325 RVA: 0x00152008 File Offset: 0x00150208
		[Token(Token = "0x6003FC5")]
		[Address(RVA = "0x80B9C0", Offset = "0x809FC0", VA = "0x18080B9C0")]
		public FloatVariableAsset()
		{
		}

		// Token: 0x0400307D RID: 12413
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400307D")]
		public float value;
	}
}
