using System;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B80 RID: 2944
	[Token(Token = "0x2000B80")]
	[Serializable]
	public class NodeConnection
	{
		// Token: 0x06003D48 RID: 15688 RVA: 0x0013F858 File Offset: 0x0013DA58
		[Token(Token = "0x6003D48")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public NodeConnection()
		{
		}

		// Token: 0x06003D49 RID: 15689 RVA: 0x0013F86C File Offset: 0x0013DA6C
		[Token(Token = "0x6003D49")]
		[Address(RVA = "0x82F430", Offset = "0x82DA30", VA = "0x18082F430")]
		public NodeConnection(string sourceNode, string sourcePort, string targetNode, string targetPort)
		{
			int num = 0;
			base.FieldGetter(num, sourcePort, targetNode);
			this.sourceNodeId = sourceNode;
			this.sourcePortName = sourcePort;
			this.targetNodeId = targetNode;
			this.targetPortName = 0;
		}

		// Token: 0x04002DDF RID: 11743
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002DDF")]
		public string sourceNodeId;

		// Token: 0x04002DE0 RID: 11744
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002DE0")]
		public string sourcePortName;

		// Token: 0x04002DE1 RID: 11745
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002DE1")]
		public string targetNodeId;

		// Token: 0x04002DE2 RID: 11746
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002DE2")]
		public string targetPortName;
	}
}
