using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BE6 RID: 3046
	[Token(Token = "0x2000BE6")]
	[Serializable]
	public class SetIntVariableValueNode : EventNodeBase
	{
		// Token: 0x06003F5B RID: 16219 RVA: 0x0014C724 File Offset: 0x0014A924
		[Token(Token = "0x6003F5B")]
		[Address(RVA = "0x86CCB0", Offset = "0x86B2B0", VA = "0x18086CCB0", Slot = "4")]
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
			PortDefinition portDefinition2 = new PortDefinition(this.variable_PortName, (PortType)((uint)2), (PortDirection)num3);
			num3 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			int num4;
			PortDefinition portDefinition3 = new PortDefinition(this.value_PortName, (PortType)((uint)1), (PortDirection)num4);
			num4 = 0;
			if (portDefinition3 != 0)
			{
			}
			array[2] = portDefinition3;
			return array;
		}

		// Token: 0x06003F5C RID: 16220 RVA: 0x0014C7A4 File Offset: 0x0014A9A4
		[Token(Token = "0x6003F5C")]
		[Address(RVA = "0x86CE90", Offset = "0x86B490", VA = "0x18086CE90", Slot = "5")]
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
			PortDefinition portDefinition2 = new PortDefinition(this.variableOut_PortName, (PortType)((uint)2), (PortDirection)((uint)1));
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003F5D RID: 16221 RVA: 0x0014C7FC File Offset: 0x0014A9FC
		[Token(Token = "0x6003F5D")]
		[Address(RVA = "0x86D000", Offset = "0x86B600", VA = "0x18086D000", Slot = "7")]
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

		// Token: 0x06003F5E RID: 16222 RVA: 0x0014C8C4 File Offset: 0x0014AAC4
		[Token(Token = "0x6003F5E")]
		[Address(RVA = "0x86C970", Offset = "0x86AF70", VA = "0x18086C970", Slot = "6")]
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
				IntVariableNode intVariableNode = this.variableNode;
				string name = intVariableNode.asset.GetType().Name;
				string nodeId = intVariableNode.nodeId;
				EventNodeDebug.LogError("[IntVariableNode] Asset类型错误：期望IntVariableAsset，实际是" + name + "，无法设置值，节点ID: " + nodeId);
				int num2;
				EventNodeDebug.Log(string.Format("[SetIntVariableValueNode] 设置变量值为: {0}", num2));
				List<EventNodeBase> list = this.onCompleteTargets;
				bool flag;
				if (flag)
				{
				}
			}
			while (num3 != (ulong)0L);
			string nodeId2 = this.nodeId;
			EventNodeDebug.LogWarning("[SetIntVariableValueNode] 变量节点未连接，节点ID: " + nodeId2);
		}

		// Token: 0x06003F5F RID: 16223 RVA: 0x0014C974 File Offset: 0x0014AB74
		[Token(Token = "0x6003F5F")]
		[Address(RVA = "0xAB9AC0", Offset = "0xAB80C0", VA = "0x180AB9AC0", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003F60 RID: 16224 RVA: 0x0014C9AC File Offset: 0x0014ABAC
		[Token(Token = "0x6003F60")]
		[Address(RVA = "0x86D1E0", Offset = "0x86B7E0", VA = "0x18086D1E0")]
		public SetIntVariableValueNode()
		{
			List<EventNodeBase> list = new List();
			this.onCompleteTargets = list;
			base..ctor();
		}

		// Token: 0x04003020 RID: 12320
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4003020")]
		public string trigger_PortName = "触发";

		// Token: 0x04003021 RID: 12321
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4003021")]
		public string variable_PortName = "变量";

		// Token: 0x04003022 RID: 12322
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4003022")]
		public string value_PortName = "新值";

		// Token: 0x04003023 RID: 12323
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4003023")]
		public string variableOut_PortName = "变量";

		// Token: 0x04003024 RID: 12324
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4003024")]
		public string onComplete_PortName = "完成";

		// Token: 0x04003025 RID: 12325
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4003025")]
		[NonSerialized]
		private IntVariableNode variableNode;

		// Token: 0x04003026 RID: 12326
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4003026")]
		[NonSerialized]
		private EventNodeBase valueSourceNode;

		// Token: 0x04003027 RID: 12327
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4003027")]
		[NonSerialized]
		private string valueSourcePort;

		// Token: 0x04003028 RID: 12328
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4003028")]
		[NonSerialized]
		private List<EventNodeBase> onCompleteTargets;
	}
}
