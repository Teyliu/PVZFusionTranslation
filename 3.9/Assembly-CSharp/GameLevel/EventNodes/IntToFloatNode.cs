using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BD2 RID: 3026
	[Token(Token = "0x2000BD2")]
	[Serializable]
	public class IntToFloatNode : EventNodeBase
	{
		// Token: 0x06003EFC RID: 16124 RVA: 0x0014B0E4 File Offset: 0x001492E4
		[Token(Token = "0x6003EFC")]
		[Address(RVA = "0x860630", Offset = "0x85EC30", VA = "0x180860630", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.int_PortName, (PortType)((uint)1), (PortDirection)num);
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003EFD RID: 16125 RVA: 0x0014B11C File Offset: 0x0014931C
		[Token(Token = "0x6003EFD")]
		[Address(RVA = "0x860720", Offset = "0x85ED20", VA = "0x180860720", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			PortDefinition portDefinition = new PortDefinition(this.float_PortName, (PortType)((uint)3), (PortDirection)((uint)1));
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003EFE RID: 16126 RVA: 0x0014B154 File Offset: 0x00149354
		[Token(Token = "0x6003EFE")]
		[Address(RVA = "0x860810", Offset = "0x85EE10", VA = "0x180860810", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.int_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.intSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.intSourcePort = sourcePortName;
		}

		// Token: 0x06003EFF RID: 16127 RVA: 0x0014B1B4 File Offset: 0x001493B4
		[Token(Token = "0x6003EFF")]
		[Address(RVA = "0xA70F10", Offset = "0xA6F510", VA = "0x180A70F10", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			Type typeFromHandle = typeof(Type);
			Type typeFromHandle2 = typeof(float);
			if (typeFromHandle.Equals(typeFromHandle2))
			{
				if (this.intSourceNode != (ulong)0L)
				{
				}
			}
			throw new InvalidCastException();
		}

		// Token: 0x06003F00 RID: 16128 RVA: 0x0014B214 File Offset: 0x00149414
		[Token(Token = "0x6003F00")]
		[Address(RVA = "0x8608D0", Offset = "0x85EED0", VA = "0x1808608D0")]
		public IntToFloatNode()
		{
		}

		// Token: 0x04002FDE RID: 12254
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002FDE")]
		public string int_PortName = "整数";

		// Token: 0x04002FDF RID: 12255
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002FDF")]
		public string float_PortName = "浮点数";

		// Token: 0x04002FE0 RID: 12256
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002FE0")]
		[NonSerialized]
		private EventNodeBase intSourceNode;

		// Token: 0x04002FE1 RID: 12257
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002FE1")]
		[NonSerialized]
		private string intSourcePort;
	}
}
