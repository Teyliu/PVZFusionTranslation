using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BA4 RID: 2980
	[Token(Token = "0x2000BA4")]
	[Serializable]
	public class SetIntVariableValueNode : EventNodeBase
	{
		// Token: 0x06003E0A RID: 15882 RVA: 0x001474B4 File Offset: 0x001456B4
		[Token(Token = "0x6003E0A")]
		[Address(RVA = "0x805300", Offset = "0x803900", VA = "0x180805300", Slot = "4")]
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

		// Token: 0x06003E0B RID: 15883 RVA: 0x00147534 File Offset: 0x00145734
		[Token(Token = "0x6003E0B")]
		[Address(RVA = "0x8054E0", Offset = "0x803AE0", VA = "0x1808054E0", Slot = "5")]
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

		// Token: 0x06003E0C RID: 15884 RVA: 0x0014758C File Offset: 0x0014578C
		[Token(Token = "0x6003E0C")]
		[Address(RVA = "0x805650", Offset = "0x803C50", VA = "0x180805650", Slot = "7")]
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

		// Token: 0x06003E0D RID: 15885 RVA: 0x00147654 File Offset: 0x00145854
		[Token(Token = "0x6003E0D")]
		[Address(RVA = "0x804FC0", Offset = "0x8035C0", VA = "0x180804FC0", Slot = "6")]
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

		// Token: 0x06003E0E RID: 15886 RVA: 0x00147704 File Offset: 0x00145904
		[Token(Token = "0x6003E0E")]
		[Address(RVA = "0xA06ED0", Offset = "0xA054D0", VA = "0x180A06ED0", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003E0F RID: 15887 RVA: 0x0014773C File Offset: 0x0014593C
		[Token(Token = "0x6003E0F")]
		[Address(RVA = "0x805830", Offset = "0x803E30", VA = "0x180805830")]
		public SetIntVariableValueNode()
		{
			List<EventNodeBase> list = new List();
			this.onCompleteTargets = list;
			base..ctor();
		}

		// Token: 0x04002EAC RID: 11948
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002EAC")]
		public string trigger_PortName = "触发";

		// Token: 0x04002EAD RID: 11949
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002EAD")]
		public string variable_PortName = "变量";

		// Token: 0x04002EAE RID: 11950
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002EAE")]
		public string value_PortName = "新值";

		// Token: 0x04002EAF RID: 11951
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002EAF")]
		public string variableOut_PortName = "变量";

		// Token: 0x04002EB0 RID: 11952
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002EB0")]
		public string onComplete_PortName = "完成";

		// Token: 0x04002EB1 RID: 11953
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002EB1")]
		[NonSerialized]
		private IntVariableNode variableNode;

		// Token: 0x04002EB2 RID: 11954
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002EB2")]
		[NonSerialized]
		private EventNodeBase valueSourceNode;

		// Token: 0x04002EB3 RID: 11955
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002EB3")]
		[NonSerialized]
		private string valueSourcePort;

		// Token: 0x04002EB4 RID: 11956
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002EB4")]
		[NonSerialized]
		private List<EventNodeBase> onCompleteTargets;
	}
}
