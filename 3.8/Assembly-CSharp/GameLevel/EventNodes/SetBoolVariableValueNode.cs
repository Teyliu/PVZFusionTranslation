using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BAA RID: 2986
	[Token(Token = "0x2000BAA")]
	[Serializable]
	public class SetBoolVariableValueNode : EventNodeBase
	{
		// Token: 0x06003E2A RID: 15914 RVA: 0x00147F80 File Offset: 0x00146180
		[Token(Token = "0x6003E2A")]
		[Address(RVA = "0x803FA0", Offset = "0x8025A0", VA = "0x180803FA0", Slot = "4")]
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

		// Token: 0x06003E2B RID: 15915 RVA: 0x00148000 File Offset: 0x00146200
		[Token(Token = "0x6003E2B")]
		[Address(RVA = "0x804180", Offset = "0x802780", VA = "0x180804180", Slot = "5")]
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

		// Token: 0x06003E2C RID: 15916 RVA: 0x00148058 File Offset: 0x00146258
		[Token(Token = "0x6003E2C")]
		[Address(RVA = "0x8042F0", Offset = "0x8028F0", VA = "0x1808042F0", Slot = "7")]
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

		// Token: 0x06003E2D RID: 15917 RVA: 0x00148120 File Offset: 0x00146320
		[Token(Token = "0x6003E2D")]
		[Address(RVA = "0x803C50", Offset = "0x802250", VA = "0x180803C50", Slot = "6")]
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

		// Token: 0x06003E2E RID: 15918 RVA: 0x001481DC File Offset: 0x001463DC
		[Token(Token = "0x6003E2E")]
		[Address(RVA = "0xA06ED0", Offset = "0xA054D0", VA = "0x180A06ED0", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003E2F RID: 15919 RVA: 0x00148214 File Offset: 0x00146414
		[Token(Token = "0x6003E2F")]
		[Address(RVA = "0x8044D0", Offset = "0x802AD0", VA = "0x1808044D0")]
		public SetBoolVariableValueNode()
		{
			List<EventNodeBase> list = new List();
			this.onCompleteTargets = list;
			base..ctor();
		}

		// Token: 0x04002EC8 RID: 11976
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002EC8")]
		public string trigger_PortName = "触发";

		// Token: 0x04002EC9 RID: 11977
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002EC9")]
		public string variable_PortName = "变量";

		// Token: 0x04002ECA RID: 11978
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002ECA")]
		public string value_PortName = "新值";

		// Token: 0x04002ECB RID: 11979
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002ECB")]
		public string variableOut_PortName = "变量";

		// Token: 0x04002ECC RID: 11980
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002ECC")]
		public string onComplete_PortName = "完成";

		// Token: 0x04002ECD RID: 11981
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002ECD")]
		[NonSerialized]
		private BoolVariableNode variableNode;

		// Token: 0x04002ECE RID: 11982
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002ECE")]
		[NonSerialized]
		private EventNodeBase valueSourceNode;

		// Token: 0x04002ECF RID: 11983
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002ECF")]
		[NonSerialized]
		private string valueSourcePort;

		// Token: 0x04002ED0 RID: 11984
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002ED0")]
		[NonSerialized]
		private List<EventNodeBase> onCompleteTargets;
	}
}
