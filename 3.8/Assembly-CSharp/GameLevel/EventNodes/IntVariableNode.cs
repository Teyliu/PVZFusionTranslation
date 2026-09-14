using System;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BA2 RID: 2978
	[Token(Token = "0x2000BA2")]
	[Serializable]
	public class IntVariableNode : VariableNode
	{
		// Token: 0x06003E00 RID: 15872 RVA: 0x00147240 File Offset: 0x00145440
		[Token(Token = "0x6003E00")]
		[Address(RVA = "0x7F9150", Offset = "0x7F7750", VA = "0x1807F9150", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			PortDefinition portDefinition = new PortDefinition(this.variable_PortName, (PortType)((uint)2), (PortDirection)((uint)1));
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003E01 RID: 15873 RVA: 0x00147278 File Offset: 0x00145478
		[Token(Token = "0x6003E01")]
		[Address(RVA = "0x932810", Offset = "0x930E10", VA = "0x180932810", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06003E02 RID: 15874 RVA: 0x001472A8 File Offset: 0x001454A8
		// (set) Token: 0x06003E03 RID: 15875 RVA: 0x00147308 File Offset: 0x00145508
		[Token(Token = "0x170004A8")]
		public int Value
		{
			[Token(Token = "0x6003E02")]
			[Address(RVA = "0x7F9290", Offset = "0x7F7890", VA = "0x1807F9290")]
			get
			{
				string nodeId = this.nodeId;
				EventNodeDebug.LogWarning("[IntVariableNode] 变量Asset未设置，返回0，节点ID: " + nodeId);
				return 0;
			}
			[Token(Token = "0x6003E03")]
			[Address(RVA = "0x7F93F0", Offset = "0x7F79F0", VA = "0x1807F93F0")]
			set
			{
				VariableAsset asset = this.asset;
			}
		}

		// Token: 0x06003E04 RID: 15876 RVA: 0x00147334 File Offset: 0x00145534
		[Token(Token = "0x6003E04")]
		[Address(RVA = "0x7F9240", Offset = "0x7F7840", VA = "0x1807F9240")]
		public IntVariableNode()
		{
		}

		// Token: 0x04002EA7 RID: 11943
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002EA7")]
		public string variable_PortName = "变量";
	}
}
