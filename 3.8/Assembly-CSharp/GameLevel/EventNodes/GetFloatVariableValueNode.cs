using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BA7 RID: 2983
	[Token(Token = "0x2000BA7")]
	[Serializable]
	public class GetFloatVariableValueNode : EventNodeBase
	{
		// Token: 0x06003E1A RID: 15898 RVA: 0x001479DC File Offset: 0x00145BDC
		[Token(Token = "0x6003E1A")]
		[Address(RVA = "0x7F5C60", Offset = "0x7F4260", VA = "0x1807F5C60", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.variable_PortName, (PortType)((uint)4), (PortDirection)num);
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003E1B RID: 15899 RVA: 0x00147A14 File Offset: 0x00145C14
		[Token(Token = "0x6003E1B")]
		[Address(RVA = "0x7F5D50", Offset = "0x7F4350", VA = "0x1807F5D50", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			PortDefinition portDefinition = new PortDefinition(this.value_PortName, (PortType)((uint)3), (PortDirection)((uint)1));
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003E1C RID: 15900 RVA: 0x00147A4C File Offset: 0x00145C4C
		[Token(Token = "0x6003E1C")]
		[Address(RVA = "0x7F5E40", Offset = "0x7F4440", VA = "0x1807F5E40", Slot = "7")]
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

		// Token: 0x06003E1D RID: 15901 RVA: 0x00147AAC File Offset: 0x00145CAC
		[Token(Token = "0x6003E1D")]
		[Address(RVA = "0x9AE830", Offset = "0x9ACE30", VA = "0x1809AE830", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			if (this.variableSourceNode != (ulong)0L)
			{
				FloatVariableNode floatVariableNode;
				floatVariableNode += floatVariableNode;
				if (floatVariableNode != 0)
				{
					float value = floatVariableNode.Value;
				}
			}
			string nodeId = this.nodeId;
			EventNodeDebug.LogWarning("[GetFloatVariableValueNode] 变量节点未连接或获取失败，返回默认值，节点ID: " + nodeId);
			return defaultValue;
		}

		// Token: 0x06003E1E RID: 15902 RVA: 0x00147B14 File Offset: 0x00145D14
		[Token(Token = "0x6003E1E")]
		[Address(RVA = "0x7F5F00", Offset = "0x7F4500", VA = "0x1807F5F00")]
		public GetFloatVariableValueNode()
		{
		}

		// Token: 0x04002EB7 RID: 11959
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002EB7")]
		public string variable_PortName = "变量";

		// Token: 0x04002EB8 RID: 11960
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002EB8")]
		public string value_PortName = "值";

		// Token: 0x04002EB9 RID: 11961
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002EB9")]
		[NonSerialized]
		private EventNodeBase variableSourceNode;

		// Token: 0x04002EBA RID: 11962
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002EBA")]
		[NonSerialized]
		private string variableSourcePort;
	}
}
