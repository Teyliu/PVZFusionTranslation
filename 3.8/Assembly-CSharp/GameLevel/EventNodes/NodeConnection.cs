using System;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B3E RID: 2878
	[Token(Token = "0x2000B3E")]
	[Serializable]
	public class NodeConnection
	{
		// Token: 0x06003BF7 RID: 15351 RVA: 0x0013A5B0 File Offset: 0x001387B0
		[Token(Token = "0x6003BF7")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public NodeConnection()
		{
		}

		// Token: 0x06003BF8 RID: 15352 RVA: 0x0013A5C4 File Offset: 0x001387C4
		[Token(Token = "0x6003BF8")]
		[Address(RVA = "0x7B3AF0", Offset = "0x7B20F0", VA = "0x1807B3AF0")]
		public NodeConnection(string sourceNode, string sourcePort, string targetNode, string targetPort)
		{
			int num = 0;
			base.FieldGetter(num, sourcePort, targetNode);
			this.sourceNodeId = sourceNode;
			this.sourcePortName = sourcePort;
			this.targetNodeId = targetNode;
			this.targetPortName = 0;
		}

		// Token: 0x04002C6B RID: 11371
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002C6B")]
		public string sourceNodeId;

		// Token: 0x04002C6C RID: 11372
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002C6C")]
		public string sourcePortName;

		// Token: 0x04002C6D RID: 11373
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002C6D")]
		public string targetNodeId;

		// Token: 0x04002C6E RID: 11374
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002C6E")]
		public string targetPortName;
	}
}
