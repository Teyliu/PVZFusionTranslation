using System;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B3D RID: 2877
	[Token(Token = "0x2000B3D")]
	[Serializable]
	public class PortDefinition
	{
		// Token: 0x06003BF6 RID: 15350 RVA: 0x0013A584 File Offset: 0x00138784
		[Token(Token = "0x6003BF6")]
		[Address(RVA = "0x7B4880", Offset = "0x7B2E80", VA = "0x1807B4880")]
		public PortDefinition(string name, PortType type, PortDirection dir)
		{
			this.portName = name;
			this.portType = type;
			this.direction = dir;
		}

		// Token: 0x04002C68 RID: 11368
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002C68")]
		public string portName;

		// Token: 0x04002C69 RID: 11369
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002C69")]
		public PortType portType;

		// Token: 0x04002C6A RID: 11370
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4002C6A")]
		public PortDirection direction;
	}
}
