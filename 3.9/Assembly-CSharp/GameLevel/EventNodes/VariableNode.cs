using System;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BE3 RID: 3043
	[Token(Token = "0x2000BE3")]
	public class VariableNode : EventNodeBase
	{
		// Token: 0x06003F4E RID: 16206 RVA: 0x0014C47C File Offset: 0x0014A67C
		[Token(Token = "0x6003F4E")]
		[Address(RVA = "0x871F40", Offset = "0x870540", VA = "0x180871F40", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			return null;
		}

		// Token: 0x06003F4F RID: 16207 RVA: 0x0014C48C File Offset: 0x0014A68C
		[Token(Token = "0x6003F4F")]
		[Address(RVA = "0x871F80", Offset = "0x870580", VA = "0x180871F80", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			return null;
		}

		// Token: 0x06003F50 RID: 16208 RVA: 0x0014C49C File Offset: 0x0014A69C
		[Token(Token = "0x6003F50")]
		[Address(RVA = "0x871FC0", Offset = "0x8705C0", VA = "0x180871FC0")]
		public VariableNode()
		{
		}

		// Token: 0x0400301A RID: 12314
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400301A")]
		[SerializeReference]
		public VariableAsset asset;
	}
}
