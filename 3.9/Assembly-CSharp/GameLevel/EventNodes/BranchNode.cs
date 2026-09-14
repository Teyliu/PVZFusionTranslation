using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BED RID: 3053
	[Token(Token = "0x2000BED")]
	[Serializable]
	public class BranchNode : EventNodeBase
	{
		// Token: 0x06003F81 RID: 16257 RVA: 0x0014D4E0 File Offset: 0x0014B6E0
		[Token(Token = "0x6003F81")]
		[Address(RVA = "0x857340", Offset = "0x855940", VA = "0x180857340", Slot = "4")]
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

		// Token: 0x06003F82 RID: 16258 RVA: 0x0014D540 File Offset: 0x0014B740
		[Token(Token = "0x6003F82")]
		[Address(RVA = "0x8574B0", Offset = "0x855AB0", VA = "0x1808574B0", Slot = "5")]
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

		// Token: 0x06003F83 RID: 16259 RVA: 0x0014D59C File Offset: 0x0014B79C
		[Token(Token = "0x6003F83")]
		[Address(RVA = "0x857620", Offset = "0x855C20", VA = "0x180857620", Slot = "7")]
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

		// Token: 0x06003F84 RID: 16260 RVA: 0x0014D640 File Offset: 0x0014B840
		[Token(Token = "0x6003F84")]
		[Address(RVA = "0x8571A0", Offset = "0x8557A0", VA = "0x1808571A0", Slot = "6")]
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

		// Token: 0x06003F85 RID: 16261 RVA: 0x0014D678 File Offset: 0x0014B878
		[Token(Token = "0x6003F85")]
		[Address(RVA = "0x857740", Offset = "0x855D40", VA = "0x180857740")]
		public BranchNode()
		{
			List<EventNodeBase> list = new List();
			this.thenTargets = list;
			List<EventNodeBase> list2 = new List();
			this.elseTargets = list2;
			base..ctor();
		}

		// Token: 0x04003045 RID: 12357
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4003045")]
		public string trigger_PortName = "触发";

		// Token: 0x04003046 RID: 12358
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4003046")]
		public string condition_PortName = "条件";

		// Token: 0x04003047 RID: 12359
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4003047")]
		public string then_PortName = "真（触发）";

		// Token: 0x04003048 RID: 12360
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4003048")]
		public string else_PortName = "假（停止）";

		// Token: 0x04003049 RID: 12361
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4003049")]
		[NonSerialized]
		private EventNodeBase conditionSourceNode;

		// Token: 0x0400304A RID: 12362
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x400304A")]
		[NonSerialized]
		private string conditionSourcePort;

		// Token: 0x0400304B RID: 12363
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x400304B")]
		[NonSerialized]
		private List<EventNodeBase> thenTargets;

		// Token: 0x0400304C RID: 12364
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x400304C")]
		[NonSerialized]
		private List<EventNodeBase> elseTargets;
	}
}
