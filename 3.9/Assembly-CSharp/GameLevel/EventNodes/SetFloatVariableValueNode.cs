using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BEA RID: 3050
	[Token(Token = "0x2000BEA")]
	[Serializable]
	public class SetFloatVariableValueNode : EventNodeBase
	{
		// Token: 0x06003F70 RID: 16240 RVA: 0x0014CDB4 File Offset: 0x0014AFB4
		[Token(Token = "0x6003F70")]
		[Address(RVA = "0x86C310", Offset = "0x86A910", VA = "0x18086C310", Slot = "4")]
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
			PortDefinition portDefinition2 = new PortDefinition(this.variable_PortName, (PortType)((uint)4), (PortDirection)num3);
			num3 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			int num4;
			PortDefinition portDefinition3 = new PortDefinition(this.value_PortName, (PortType)((uint)3), (PortDirection)num4);
			num4 = 0;
			if (portDefinition3 != 0)
			{
			}
			array[2] = portDefinition3;
			return array;
		}

		// Token: 0x06003F71 RID: 16241 RVA: 0x0014CE34 File Offset: 0x0014B034
		[Token(Token = "0x6003F71")]
		[Address(RVA = "0x86C4F0", Offset = "0x86AAF0", VA = "0x18086C4F0", Slot = "5")]
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
			PortDefinition portDefinition2 = new PortDefinition(this.variableOut_PortName, (PortType)((uint)4), (PortDirection)((uint)1));
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003F72 RID: 16242 RVA: 0x0014CE8C File Offset: 0x0014B08C
		[Token(Token = "0x6003F72")]
		[Address(RVA = "0x86C660", Offset = "0x86AC60", VA = "0x18086C660", Slot = "7")]
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

		// Token: 0x06003F73 RID: 16243 RVA: 0x0014CF54 File Offset: 0x0014B154
		[Token(Token = "0x6003F73")]
		[Address(RVA = "0x86BFB0", Offset = "0x86A5B0", VA = "0x18086BFB0", Slot = "6")]
		public override void Execute()
		{
			ulong num3;
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
				FloatVariableNode floatVariableNode = this.variableNode;
				string name = floatVariableNode.asset.GetType().Name;
				string nodeId = floatVariableNode.nodeId;
				EventNodeDebug.LogError("[FloatVariableNode] Asset类型错误：期望FloatVariableAsset，实际是" + name + "，无法设置值，节点ID: " + nodeId);
				float num2;
				EventNodeDebug.Log(string.Format("[SetFloatVariableValueNode] 设置变量值为: {0}", num2));
				List<EventNodeBase> list = this.onCompleteTargets;
				bool flag;
				if (flag)
				{
				}
			}
			while (num3 != (ulong)0L);
			string nodeId2 = this.nodeId;
			EventNodeDebug.LogWarning("[SetFloatVariableValueNode] 变量节点未连接，节点ID: " + nodeId2);
		}

		// Token: 0x06003F74 RID: 16244 RVA: 0x0014D004 File Offset: 0x0014B204
		[Token(Token = "0x6003F74")]
		[Address(RVA = "0xAB9AC0", Offset = "0xAB80C0", VA = "0x180AB9AC0", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003F75 RID: 16245 RVA: 0x0014D03C File Offset: 0x0014B23C
		[Token(Token = "0x6003F75")]
		[Address(RVA = "0x86C840", Offset = "0x86AE40", VA = "0x18086C840")]
		public SetFloatVariableValueNode()
		{
			List<EventNodeBase> list = new List();
			this.onCompleteTargets = list;
			base..ctor();
		}

		// Token: 0x0400302F RID: 12335
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400302F")]
		public string trigger_PortName = "触发";

		// Token: 0x04003030 RID: 12336
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4003030")]
		public string variable_PortName = "变量";

		// Token: 0x04003031 RID: 12337
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4003031")]
		public string value_PortName = "新值";

		// Token: 0x04003032 RID: 12338
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4003032")]
		public string variableOut_PortName = "变量";

		// Token: 0x04003033 RID: 12339
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4003033")]
		public string onComplete_PortName = "完成";

		// Token: 0x04003034 RID: 12340
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4003034")]
		[NonSerialized]
		private FloatVariableNode variableNode;

		// Token: 0x04003035 RID: 12341
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4003035")]
		[NonSerialized]
		private EventNodeBase valueSourceNode;

		// Token: 0x04003036 RID: 12342
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4003036")]
		[NonSerialized]
		private string valueSourcePort;

		// Token: 0x04003037 RID: 12343
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4003037")]
		[NonSerialized]
		private List<EventNodeBase> onCompleteTargets;
	}
}
