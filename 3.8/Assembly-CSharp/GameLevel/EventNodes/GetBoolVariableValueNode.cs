using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BA9 RID: 2985
	[Token(Token = "0x2000BA9")]
	[Serializable]
	public class GetBoolVariableValueNode : EventNodeBase
	{
		// Token: 0x06003E25 RID: 15909 RVA: 0x00147E20 File Offset: 0x00146020
		[Token(Token = "0x6003E25")]
		[Address(RVA = "0x7F5940", Offset = "0x7F3F40", VA = "0x1807F5940", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.variable_PortName, (PortType)((uint)7), (PortDirection)num);
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003E26 RID: 15910 RVA: 0x00147E58 File Offset: 0x00146058
		[Token(Token = "0x6003E26")]
		[Address(RVA = "0x7F5A30", Offset = "0x7F4030", VA = "0x1807F5A30", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			PortDefinition portDefinition = new PortDefinition(this.value_PortName, (PortType)((uint)6), (PortDirection)((uint)1));
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003E27 RID: 15911 RVA: 0x00147E90 File Offset: 0x00146090
		[Token(Token = "0x6003E27")]
		[Address(RVA = "0x7F5B20", Offset = "0x7F4120", VA = "0x1807F5B20", Slot = "7")]
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

		// Token: 0x06003E28 RID: 15912 RVA: 0x00147EF0 File Offset: 0x001460F0
		[Token(Token = "0x6003E28")]
		[Address(RVA = "0x9ADD70", Offset = "0x9AC370", VA = "0x1809ADD70", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			if (this.variableSourceNode != (ulong)0L)
			{
				BoolVariableNode boolVariableNode;
				boolVariableNode += boolVariableNode;
				if (boolVariableNode != 0)
				{
					bool value = boolVariableNode.Value;
				}
			}
			string nodeId = this.nodeId;
			EventNodeDebug.LogWarning("[GetBoolVariableValueNode] 变量节点未连接或获取失败，返回默认值，节点ID: " + nodeId);
			return defaultValue;
		}

		// Token: 0x06003E29 RID: 15913 RVA: 0x00147F54 File Offset: 0x00146154
		[Token(Token = "0x6003E29")]
		[Address(RVA = "0x7F5BE0", Offset = "0x7F41E0", VA = "0x1807F5BE0")]
		public GetBoolVariableValueNode()
		{
		}

		// Token: 0x04002EC4 RID: 11972
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002EC4")]
		public string variable_PortName = "变量";

		// Token: 0x04002EC5 RID: 11973
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002EC5")]
		public string value_PortName = "值";

		// Token: 0x04002EC6 RID: 11974
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002EC6")]
		[NonSerialized]
		private EventNodeBase variableSourceNode;

		// Token: 0x04002EC7 RID: 11975
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002EC7")]
		[NonSerialized]
		private string variableSourcePort;
	}
}
