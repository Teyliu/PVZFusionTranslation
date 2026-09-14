using System;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B7F RID: 2943
	[Token(Token = "0x2000B7F")]
	[Serializable]
	public class PortDefinition
	{
		// Token: 0x06003D47 RID: 15687 RVA: 0x0013F82C File Offset: 0x0013DA2C
		[Token(Token = "0x6003D47")]
		[Address(RVA = "0x8301C0", Offset = "0x82E7C0", VA = "0x1808301C0")]
		public PortDefinition(string name, PortType type, PortDirection dir)
		{
			this.portName = name;
			this.portType = type;
			this.direction = dir;
		}

		// Token: 0x04002DDC RID: 11740
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002DDC")]
		public string portName;

		// Token: 0x04002DDD RID: 11741
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002DDD")]
		public PortType portType;

		// Token: 0x04002DDE RID: 11742
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4002DDE")]
		public PortDirection direction;
	}
}
