using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BEC RID: 3052
	[Token(Token = "0x2000BEC")]
	[Serializable]
	public class SetBoolVariableValueNode : EventNodeBase
	{
		// Token: 0x06003F7B RID: 16251 RVA: 0x0014D1F4 File Offset: 0x0014B3F4
		[Token(Token = "0x6003F7B")]
		[Address(RVA = "0x86B950", Offset = "0x869F50", VA = "0x18086B950", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[3];
			int num;
			int num2;
			PortDefinition portDefinition = new PortDefinition(this.trigger_PortName, (PortType)num, (PortDirection)num2);
			num2 = 0;
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			int num3;
			PortDefinition portDefinition2 = new PortDefinition(this.variable_PortName, (PortType)((uint)7), (PortDirection)num3);
			num3 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			int num4;
			PortDefinition portDefinition3 = new PortDefinition(this.value_PortName, (PortType)((uint)6), (PortDirection)num4);
			num4 = 0;
			if (portDefinition3 != 0)
			{
			}
			array[2] = portDefinition3;
			return array;
		}

		// Token: 0x06003F7C RID: 16252 RVA: 0x0014D274 File Offset: 0x0014B474
		[Token(Token = "0x6003F7C")]
		[Address(RVA = "0x86BB30", Offset = "0x86A130", VA = "0x18086BB30", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[2];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.onComplete_PortName, (PortType)num, (PortDirection)((uint)1));
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			PortDefinition portDefinition2 = new PortDefinition(this.variableOut_PortName, (PortType)((uint)7), (PortDirection)((uint)1));
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003F7D RID: 16253 RVA: 0x0014D2CC File Offset: 0x0014B4CC
		[Token(Token = "0x6003F7D")]
		[Address(RVA = "0x86BCA0", Offset = "0x86A2A0", VA = "0x18086BCA0", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.variable_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			int num2 = 0;
			if (sourceNode == 0)
			{
				this.variableNode = num2;
			}
			this.variableNode = sourceNode;
			string text2 = this.value_PortName;
			string nodeId2 = this.nodeId;
			List<SourcePortInfo> sourceNodes2 = graph.GetSourceNodes(nodeId2, text2);
			int num3 = 0;
			EventNodeBase sourceNode2 = sourceNodes2[num3].sourceNode;
			this.valueSourceNode = sourceNode2;
			int num4 = 0;
			string sourcePortName = sourceNodes2[num4].sourcePortName;
			this.valueSourcePort = sourcePortName;
			string text3 = this.onComplete_PortName;
			string nodeId3 = this.nodeId;
			List<EventNodeBase> connectedNodes = graph.GetConnectedNodes(nodeId3, text3);
			this.onCompleteTargets = connectedNodes;
			throw new NullReferenceException();
		}

		// Token: 0x06003F7E RID: 16254 RVA: 0x0014D394 File Offset: 0x0014B594
		[Token(Token = "0x6003F7E")]
		[Address(RVA = "0x86B600", Offset = "0x869C00", VA = "0x18086B600", Slot = "6")]
		public override void Execute()
		{
			ulong num2;
			do
			{
				int num = 0;
				if (this.variableNode == num)
				{
					break;
				}
				if (this.valueSourceNode != num)
				{
					num += 20;
					num += num;
				}
				bool flag = 0 != 0;
				BoolVariableNode boolVariableNode = this.variableNode;
				string name = boolVariableNode.asset.GetType().Name;
				string nodeId = boolVariableNode.nodeId;
				string text = "[BoolVariableNode] Asset类型错误：期望BoolVariableAsset，实际是" + name + "，无法设置值，节点ID: " + nodeId;
				EventNodeDebug.LogError(text);
				EventNodeDebug.Log(string.Format("[SetBoolVariableValueNode] 设置变量值为: {0}", text));
				List<EventNodeBase> list = this.onCompleteTargets;
				bool flag2;
				if (flag2)
				{
				}
			}
			while (num2 != (ulong)0L);
			string nodeId2 = this.nodeId;
			EventNodeDebug.LogWarning("[SetBoolVariableValueNode] 变量节点未连接，节点ID: " + nodeId2);
		}

		// Token: 0x06003F7F RID: 16255 RVA: 0x0014D450 File Offset: 0x0014B650
		[Token(Token = "0x6003F7F")]
		[Address(RVA = "0xAB9AC0", Offset = "0xAB80C0", VA = "0x180AB9AC0", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003F80 RID: 16256 RVA: 0x0014D488 File Offset: 0x0014B688
		[Token(Token = "0x6003F80")]
		[Address(RVA = "0x86BE80", Offset = "0x86A480", VA = "0x18086BE80")]
		public SetBoolVariableValueNode()
		{
			List<EventNodeBase> list = new List();
			this.onCompleteTargets = list;
			base..ctor();
		}

		// Token: 0x0400303C RID: 12348
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400303C")]
		public string trigger_PortName = "触发";

		// Token: 0x0400303D RID: 12349
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400303D")]
		public string variable_PortName = "变量";

		// Token: 0x0400303E RID: 12350
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400303E")]
		public string value_PortName = "新值";

		// Token: 0x0400303F RID: 12351
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400303F")]
		public string variableOut_PortName = "变量";

		// Token: 0x04003040 RID: 12352
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4003040")]
		public string onComplete_PortName = "完成";

		// Token: 0x04003041 RID: 12353
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4003041")]
		[NonSerialized]
		private BoolVariableNode variableNode;

		// Token: 0x04003042 RID: 12354
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4003042")]
		[NonSerialized]
		private EventNodeBase valueSourceNode;

		// Token: 0x04003043 RID: 12355
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4003043")]
		[NonSerialized]
		private string valueSourcePort;

		// Token: 0x04003044 RID: 12356
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4003044")]
		[NonSerialized]
		private List<EventNodeBase> onCompleteTargets;
	}
}
