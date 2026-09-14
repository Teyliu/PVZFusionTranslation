using System;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BF1 RID: 3057
	[Token(Token = "0x2000BF1")]
	[Serializable]
	public class BoolVariableAsset : VariableAsset
	{
		// Token: 0x06003FC6 RID: 16326 RVA: 0x0015201C File Offset: 0x0015021C
		[Token(Token = "0x6003FC6")]
		[Address(RVA = "0x80B9C0", Offset = "0x809FC0", VA = "0x18080B9C0")]
		public BoolVariableAsset()
		{
		}

		// Token: 0x0400307E RID: 12414
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400307E")]
		public bool value;
	}
}
