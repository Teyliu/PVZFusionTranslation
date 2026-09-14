using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BA8 RID: 2984
	[Token(Token = "0x2000BA8")]
	[Serializable]
	public class SetFloatVariableValueNode : EventNodeBase
	{
		// Token: 0x06003E1F RID: 15903 RVA: 0x00147B40 File Offset: 0x00145D40
		[Token(Token = "0x6003E1F")]
		[Address(RVA = "0x804960", Offset = "0x802F60", VA = "0x180804960", Slot = "4")]
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

		// Token: 0x06003E20 RID: 15904 RVA: 0x00147BC0 File Offset: 0x00145DC0
		[Token(Token = "0x6003E20")]
		[Address(RVA = "0x804B40", Offset = "0x803140", VA = "0x180804B40", Slot = "5")]
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

		// Token: 0x06003E21 RID: 15905 RVA: 0x00147C18 File Offset: 0x00145E18
		[Token(Token = "0x6003E21")]
		[Address(RVA = "0x804CB0", Offset = "0x8032B0", VA = "0x180804CB0", Slot = "7")]
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

		// Token: 0x06003E22 RID: 15906 RVA: 0x00147CE0 File Offset: 0x00145EE0
		[Token(Token = "0x6003E22")]
		[Address(RVA = "0x804600", Offset = "0x802C00", VA = "0x180804600", Slot = "6")]
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

		// Token: 0x06003E23 RID: 15907 RVA: 0x00147D90 File Offset: 0x00145F90
		[Token(Token = "0x6003E23")]
		[Address(RVA = "0xA06ED0", Offset = "0xA054D0", VA = "0x180A06ED0", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003E24 RID: 15908 RVA: 0x00147DC8 File Offset: 0x00145FC8
		[Token(Token = "0x6003E24")]
		[Address(RVA = "0x804E90", Offset = "0x803490", VA = "0x180804E90")]
		public SetFloatVariableValueNode()
		{
			List<EventNodeBase> list = new List();
			this.onCompleteTargets = list;
			base..ctor();
		}

		// Token: 0x04002EBB RID: 11963
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002EBB")]
		public string trigger_PortName = "触发";

		// Token: 0x04002EBC RID: 11964
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002EBC")]
		public string variable_PortName = "变量";

		// Token: 0x04002EBD RID: 11965
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002EBD")]
		public string value_PortName = "新值";

		// Token: 0x04002EBE RID: 11966
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002EBE")]
		public string variableOut_PortName = "变量";

		// Token: 0x04002EBF RID: 11967
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002EBF")]
		public string onComplete_PortName = "完成";

		// Token: 0x04002EC0 RID: 11968
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002EC0")]
		[NonSerialized]
		private FloatVariableNode variableNode;

		// Token: 0x04002EC1 RID: 11969
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002EC1")]
		[NonSerialized]
		private EventNodeBase valueSourceNode;

		// Token: 0x04002EC2 RID: 11970
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002EC2")]
		[NonSerialized]
		private string valueSourcePort;

		// Token: 0x04002EC3 RID: 11971
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002EC3")]
		[NonSerialized]
		private List<EventNodeBase> onCompleteTargets;
	}
}
