using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BA3 RID: 2979
	[Token(Token = "0x2000BA3")]
	[Serializable]
	public class GetIntVariableValueNode : EventNodeBase
	{
		// Token: 0x06003E05 RID: 15877 RVA: 0x00147354 File Offset: 0x00145554
		[Token(Token = "0x6003E05")]
		[Address(RVA = "0x7F5F80", Offset = "0x7F4580", VA = "0x1807F5F80", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.variable_PortName, (PortType)((uint)2), (PortDirection)num);
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003E06 RID: 15878 RVA: 0x0014738C File Offset: 0x0014558C
		[Token(Token = "0x6003E06")]
		[Address(RVA = "0x7F6070", Offset = "0x7F4670", VA = "0x1807F6070", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			PortDefinition portDefinition = new PortDefinition(this.value_PortName, (PortType)((uint)1), (PortDirection)((uint)1));
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003E07 RID: 15879 RVA: 0x001473C4 File Offset: 0x001455C4
		[Token(Token = "0x6003E07")]
		[Address(RVA = "0x7F6160", Offset = "0x7F4760", VA = "0x1807F6160", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.variable_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.variableSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.variableSourcePort = sourcePortName;
		}

		// Token: 0x06003E08 RID: 15880 RVA: 0x00147424 File Offset: 0x00145624
		[Token(Token = "0x6003E08")]
		[Address(RVA = "0x9AF2F0", Offset = "0x9AD8F0", VA = "0x1809AF2F0", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			if (this.variableSourceNode != (ulong)0L)
			{
				IntVariableNode intVariableNode;
				intVariableNode += intVariableNode;
				if (intVariableNode != 0)
				{
					int value = intVariableNode.Value;
				}
			}
			string nodeId = this.nodeId;
			EventNodeDebug.LogWarning("[GetIntVariableValueNode] 变量节点未连接或获取失败，返回默认值，节点ID: " + nodeId);
			return defaultValue;
		}

		// Token: 0x06003E09 RID: 15881 RVA: 0x00147488 File Offset: 0x00145688
		[Token(Token = "0x6003E09")]
		[Address(RVA = "0x7F6220", Offset = "0x7F4820", VA = "0x1807F6220")]
		public GetIntVariableValueNode()
		{
		}

		// Token: 0x04002EA8 RID: 11944
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002EA8")]
		public string variable_PortName = "变量";

		// Token: 0x04002EA9 RID: 11945
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002EA9")]
		public string value_PortName = "值";

		// Token: 0x04002EAA RID: 11946
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002EAA")]
		[NonSerialized]
		private EventNodeBase variableSourceNode;

		// Token: 0x04002EAB RID: 11947
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002EAB")]
		[NonSerialized]
		private string variableSourcePort;
	}
}
