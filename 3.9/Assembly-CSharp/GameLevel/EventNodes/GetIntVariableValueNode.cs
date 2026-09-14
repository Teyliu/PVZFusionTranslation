using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BE5 RID: 3045
	[Token(Token = "0x2000BE5")]
	[Serializable]
	public class GetIntVariableValueNode : EventNodeBase
	{
		// Token: 0x06003F56 RID: 16214 RVA: 0x0014C5C4 File Offset: 0x0014A7C4
		[Token(Token = "0x6003F56")]
		[Address(RVA = "0x85DB30", Offset = "0x85C130", VA = "0x18085DB30", Slot = "4")]
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

		// Token: 0x06003F57 RID: 16215 RVA: 0x0014C5FC File Offset: 0x0014A7FC
		[Token(Token = "0x6003F57")]
		[Address(RVA = "0x85DC20", Offset = "0x85C220", VA = "0x18085DC20", Slot = "5")]
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

		// Token: 0x06003F58 RID: 16216 RVA: 0x0014C634 File Offset: 0x0014A834
		[Token(Token = "0x6003F58")]
		[Address(RVA = "0x85DD10", Offset = "0x85C310", VA = "0x18085DD10", Slot = "7")]
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

		// Token: 0x06003F59 RID: 16217 RVA: 0x0014C694 File Offset: 0x0014A894
		[Token(Token = "0x6003F59")]
		[Address(RVA = "0xA588B0", Offset = "0xA56EB0", VA = "0x180A588B0", Slot = "9")]
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

		// Token: 0x06003F5A RID: 16218 RVA: 0x0014C6F8 File Offset: 0x0014A8F8
		[Token(Token = "0x6003F5A")]
		[Address(RVA = "0x85DDD0", Offset = "0x85C3D0", VA = "0x18085DDD0")]
		public GetIntVariableValueNode()
		{
		}

		// Token: 0x0400301C RID: 12316
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400301C")]
		public string variable_PortName = "变量";

		// Token: 0x0400301D RID: 12317
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400301D")]
		public string value_PortName = "值";

		// Token: 0x0400301E RID: 12318
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400301E")]
		[NonSerialized]
		private EventNodeBase variableSourceNode;

		// Token: 0x0400301F RID: 12319
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400301F")]
		[NonSerialized]
		private string variableSourcePort;
	}
}
