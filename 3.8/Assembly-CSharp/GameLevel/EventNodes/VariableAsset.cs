using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BEE RID: 3054
	[Token(Token = "0x2000BEE")]
	[Serializable]
	public class VariableAsset
	{
		// Token: 0x06003FC1 RID: 16321 RVA: 0x00151F7C File Offset: 0x0015017C
		[Token(Token = "0x6003FC1")]
		[Address(RVA = "0x8258C0", Offset = "0x823EC0", VA = "0x1808258C0")]
		public void RegisterNode(string nodeId)
		{
			if (!this.referencedNodeIds.Contains(nodeId))
			{
				List<string> list = this.referencedNodeIds;
			}
		}

		// Token: 0x06003FC2 RID: 16322 RVA: 0x00151FA8 File Offset: 0x001501A8
		[Token(Token = "0x6003FC2")]
		[Address(RVA = "0x825940", Offset = "0x823F40", VA = "0x180825940")]
		public void UnregisterNode(string nodeId)
		{
			bool flag = this.referencedNodeIds.Remove(nodeId);
		}

		// Token: 0x06003FC3 RID: 16323 RVA: 0x00151FC8 File Offset: 0x001501C8
		[Token(Token = "0x6003FC3")]
		[Address(RVA = "0x8259A0", Offset = "0x823FA0", VA = "0x1808259A0")]
		public VariableAsset()
		{
			List<string> list = new List();
			this.referencedNodeIds = list;
			base..ctor();
		}

		// Token: 0x0400307A RID: 12410
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400307A")]
		public string name = "新的变量";

		// Token: 0x0400307B RID: 12411
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400307B")]
		public List<string> referencedNodeIds;
	}
}
