using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BEB RID: 3051
	[Token(Token = "0x2000BEB")]
	[Serializable]
	public class GetBoolVariableValueNode : EventNodeBase
	{
		// Token: 0x06003F76 RID: 16246 RVA: 0x0014D094 File Offset: 0x0014B294
		[Token(Token = "0x6003F76")]
		[Address(RVA = "0x85D4F0", Offset = "0x85BAF0", VA = "0x18085D4F0", Slot = "4")]
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

		// Token: 0x06003F77 RID: 16247 RVA: 0x0014D0CC File Offset: 0x0014B2CC
		[Token(Token = "0x6003F77")]
		[Address(RVA = "0x85D5E0", Offset = "0x85BBE0", VA = "0x18085D5E0", Slot = "5")]
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

		// Token: 0x06003F78 RID: 16248 RVA: 0x0014D104 File Offset: 0x0014B304
		[Token(Token = "0x6003F78")]
		[Address(RVA = "0x85D6D0", Offset = "0x85BCD0", VA = "0x18085D6D0", Slot = "7")]
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

		// Token: 0x06003F79 RID: 16249 RVA: 0x0014D164 File Offset: 0x0014B364
		[Token(Token = "0x6003F79")]
		[Address(RVA = "0xA57330", Offset = "0xA55930", VA = "0x180A57330", Slot = "9")]
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

		// Token: 0x06003F7A RID: 16250 RVA: 0x0014D1C8 File Offset: 0x0014B3C8
		[Token(Token = "0x6003F7A")]
		[Address(RVA = "0x85D790", Offset = "0x85BD90", VA = "0x18085D790")]
		public GetBoolVariableValueNode()
		{
		}

		// Token: 0x04003038 RID: 12344
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4003038")]
		public string variable_PortName = "变量";

		// Token: 0x04003039 RID: 12345
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4003039")]
		public string value_PortName = "值";

		// Token: 0x0400303A RID: 12346
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400303A")]
		[NonSerialized]
		private EventNodeBase variableSourceNode;

		// Token: 0x0400303B RID: 12347
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400303B")]
		[NonSerialized]
		private string variableSourcePort;
	}
}
