using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BE9 RID: 3049
	[Token(Token = "0x2000BE9")]
	[Serializable]
	public class GetFloatVariableValueNode : EventNodeBase
	{
		// Token: 0x06003F6B RID: 16235 RVA: 0x0014CC4C File Offset: 0x0014AE4C
		[Token(Token = "0x6003F6B")]
		[Address(RVA = "0x85D810", Offset = "0x85BE10", VA = "0x18085D810", Slot = "4")]
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

		// Token: 0x06003F6C RID: 16236 RVA: 0x0014CC84 File Offset: 0x0014AE84
		[Token(Token = "0x6003F6C")]
		[Address(RVA = "0x85D900", Offset = "0x85BF00", VA = "0x18085D900", Slot = "5")]
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

		// Token: 0x06003F6D RID: 16237 RVA: 0x0014CCC0 File Offset: 0x0014AEC0
		[Token(Token = "0x6003F6D")]
		[Address(RVA = "0x85D9F0", Offset = "0x85BFF0", VA = "0x18085D9F0", Slot = "7")]
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

		// Token: 0x06003F6E RID: 16238 RVA: 0x0014CD20 File Offset: 0x0014AF20
		[Token(Token = "0x6003F6E")]
		[Address(RVA = "0xA57DF0", Offset = "0xA563F0", VA = "0x180A57DF0", Slot = "9")]
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

		// Token: 0x06003F6F RID: 16239 RVA: 0x0014CD88 File Offset: 0x0014AF88
		[Token(Token = "0x6003F6F")]
		[Address(RVA = "0x85DAB0", Offset = "0x85C0B0", VA = "0x18085DAB0")]
		public GetFloatVariableValueNode()
		{
		}

		// Token: 0x0400302B RID: 12331
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400302B")]
		public string variable_PortName = "变量";

		// Token: 0x0400302C RID: 12332
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400302C")]
		public string value_PortName = "值";

		// Token: 0x0400302D RID: 12333
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400302D")]
		[NonSerialized]
		private EventNodeBase variableSourceNode;

		// Token: 0x0400302E RID: 12334
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400302E")]
		[NonSerialized]
		private string variableSourcePort;
	}
}
