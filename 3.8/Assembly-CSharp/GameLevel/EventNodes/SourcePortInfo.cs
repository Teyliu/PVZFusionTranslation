using System;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B3F RID: 2879
	[Token(Token = "0x2000B3F")]
	[Serializable]
	public class SourcePortInfo
	{
		// Token: 0x06003BF9 RID: 15353 RVA: 0x0013A5F8 File Offset: 0x001387F8
		[Token(Token = "0x6003BF9")]
		[Address(RVA = "0x7B66C0", Offset = "0x7B4CC0", VA = "0x1807B66C0")]
		public SourcePortInfo(EventNodeBase node, string port)
		{
			this.sourceNode = node;
			this.sourcePortName = port;
		}

		// Token: 0x04002C6F RID: 11375
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002C6F")]
		public EventNodeBase sourceNode;

		// Token: 0x04002C70 RID: 11376
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002C70")]
		public string sourcePortName;
	}
}
