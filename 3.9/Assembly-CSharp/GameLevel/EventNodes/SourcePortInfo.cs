using System;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B81 RID: 2945
	[Token(Token = "0x2000B81")]
	[Serializable]
	public class SourcePortInfo
	{
		// Token: 0x06003D4A RID: 15690 RVA: 0x0013F8A0 File Offset: 0x0013DAA0
		[Token(Token = "0x6003D4A")]
		[Address(RVA = "0x832000", Offset = "0x830600", VA = "0x180832000")]
		public SourcePortInfo(EventNodeBase node, string port)
		{
			this.sourceNode = node;
			this.sourcePortName = port;
		}

		// Token: 0x04002DE3 RID: 11747
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002DE3")]
		public EventNodeBase sourceNode;

		// Token: 0x04002DE4 RID: 11748
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002DE4")]
		public string sourcePortName;
	}
}
