using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BAB RID: 2987
	[Token(Token = "0x2000BAB")]
	[Serializable]
	public class BranchNode : EventNodeBase
	{
		// Token: 0x06003E30 RID: 15920 RVA: 0x0014826C File Offset: 0x0014646C
		[Token(Token = "0x6003E30")]
		[Address(RVA = "0x7EF870", Offset = "0x7EDE70", VA = "0x1807EF870", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[2];
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
			PortDefinition portDefinition2 = new PortDefinition(this.condition_PortName, (PortType)((uint)6), (PortDirection)num3);
			num3 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003E31 RID: 15921 RVA: 0x001482CC File Offset: 0x001464CC
		[Token(Token = "0x6003E31")]
		[Address(RVA = "0x7EF9E0", Offset = "0x7EDFE0", VA = "0x1807EF9E0", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[2];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.then_PortName, (PortType)num, (PortDirection)((uint)1));
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			int num2;
			PortDefinition portDefinition2 = new PortDefinition(this.else_PortName, (PortType)num2, (PortDirection)((uint)1));
			num2 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003E32 RID: 15922 RVA: 0x00148328 File Offset: 0x00146528
		[Token(Token = "0x6003E32")]
		[Address(RVA = "0x7EFB50", Offset = "0x7EE150", VA = "0x1807EFB50", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.condition_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.conditionSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.conditionSourcePort = sourcePortName;
			string text2 = this.then_PortName;
			string nodeId2 = this.nodeId;
			List<EventNodeBase> connectedNodes = graph.GetConnectedNodes(nodeId2, text2);
			this.thenTargets = connectedNodes;
			string text3 = this.else_PortName;
			string nodeId3 = this.nodeId;
			List<EventNodeBase> connectedNodes2 = graph.GetConnectedNodes(nodeId3, text3);
			this.elseTargets = connectedNodes2;
			throw new NullReferenceException();
		}

		// Token: 0x06003E33 RID: 15923 RVA: 0x001483CC File Offset: 0x001465CC
		[Token(Token = "0x6003E33")]
		[Address(RVA = "0x7EF6D0", Offset = "0x7EDCD0", VA = "0x1807EF6D0", Slot = "6")]
		public override void Execute()
		{
			ulong num2;
			do
			{
				int num = 0;
				if (this.conditionSourceNode == num)
				{
				}
				num += 20;
				num += num;
				bool flag;
				if (flag)
				{
				}
			}
			while (num2 != (ulong)0L);
		}

		// Token: 0x06003E34 RID: 15924 RVA: 0x00148404 File Offset: 0x00146604
		[Token(Token = "0x6003E34")]
		[Address(RVA = "0x7EFC70", Offset = "0x7EE270", VA = "0x1807EFC70")]
		public BranchNode()
		{
			List<EventNodeBase> list = new List();
			this.thenTargets = list;
			List<EventNodeBase> list2 = new List();
			this.elseTargets = list2;
			base..ctor();
		}

		// Token: 0x04002ED1 RID: 11985
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002ED1")]
		public string trigger_PortName = "触发";

		// Token: 0x04002ED2 RID: 11986
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002ED2")]
		public string condition_PortName = "条件";

		// Token: 0x04002ED3 RID: 11987
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002ED3")]
		public string then_PortName = "真（触发）";

		// Token: 0x04002ED4 RID: 11988
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002ED4")]
		public string else_PortName = "假（停止）";

		// Token: 0x04002ED5 RID: 11989
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002ED5")]
		[NonSerialized]
		private EventNodeBase conditionSourceNode;

		// Token: 0x04002ED6 RID: 11990
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002ED6")]
		[NonSerialized]
		private string conditionSourcePort;

		// Token: 0x04002ED7 RID: 11991
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002ED7")]
		[NonSerialized]
		private List<EventNodeBase> thenTargets;

		// Token: 0x04002ED8 RID: 11992
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002ED8")]
		[NonSerialized]
		private List<EventNodeBase> elseTargets;
	}
}
