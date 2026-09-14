using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000C30 RID: 3120
	[Token(Token = "0x2000C30")]
	[Serializable]
	public class VariableAsset
	{
		// Token: 0x06004112 RID: 16658 RVA: 0x001571AC File Offset: 0x001553AC
		[Token(Token = "0x6004112")]
		[Address(RVA = "0x88F2F0", Offset = "0x88D8F0", VA = "0x18088F2F0")]
		public void RegisterNode(string nodeId)
		{
			if (!this.referencedNodeIds.Contains(nodeId))
			{
				List<string> list = this.referencedNodeIds;
			}
		}

		// Token: 0x06004113 RID: 16659 RVA: 0x001571D8 File Offset: 0x001553D8
		[Token(Token = "0x6004113")]
		[Address(RVA = "0x88F370", Offset = "0x88D970", VA = "0x18088F370")]
		public void UnregisterNode(string nodeId)
		{
			bool flag = this.referencedNodeIds.Remove(nodeId);
		}

		// Token: 0x06004114 RID: 16660 RVA: 0x001571F8 File Offset: 0x001553F8
		[Token(Token = "0x6004114")]
		[Address(RVA = "0x88F3D0", Offset = "0x88D9D0", VA = "0x18088F3D0")]
		public VariableAsset()
		{
			List<string> list = new List();
			this.referencedNodeIds = list;
			base..ctor();
		}

		// Token: 0x040031ED RID: 12781
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40031ED")]
		public string name = "新的变量";

		// Token: 0x040031EE RID: 12782
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40031EE")]
		public List<string> referencedNodeIds;
	}
}
