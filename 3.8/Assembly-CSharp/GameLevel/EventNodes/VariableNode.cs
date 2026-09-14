using System;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BA1 RID: 2977
	[Token(Token = "0x2000BA1")]
	public class VariableNode : EventNodeBase
	{
		// Token: 0x06003DFD RID: 15869 RVA: 0x0014720C File Offset: 0x0014540C
		[Token(Token = "0x6003DFD")]
		[Address(RVA = "0x80A550", Offset = "0x808B50", VA = "0x18080A550", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			return null;
		}

		// Token: 0x06003DFE RID: 15870 RVA: 0x0014721C File Offset: 0x0014541C
		[Token(Token = "0x6003DFE")]
		[Address(RVA = "0x80A590", Offset = "0x808B90", VA = "0x18080A590", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			return null;
		}

		// Token: 0x06003DFF RID: 15871 RVA: 0x0014722C File Offset: 0x0014542C
		[Token(Token = "0x6003DFF")]
		[Address(RVA = "0x80A5D0", Offset = "0x808BD0", VA = "0x18080A5D0")]
		public VariableNode()
		{
		}

		// Token: 0x04002EA6 RID: 11942
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002EA6")]
		[SerializeReference]
		public VariableAsset asset;
	}
}
