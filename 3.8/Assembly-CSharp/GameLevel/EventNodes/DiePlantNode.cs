using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B87 RID: 2951
	[Token(Token = "0x2000B87")]
	[Serializable]
	public class DiePlantNode : EventNodeBase
	{
		// Token: 0x06003D79 RID: 15737 RVA: 0x00144C30 File Offset: 0x00142E30
		[Token(Token = "0x6003D79")]
		[Address(RVA = "0x7F36E0", Offset = "0x7F1CE0", VA = "0x1807F36E0", Slot = "4")]
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
			PortDefinition portDefinition2 = new PortDefinition(this.plant_PortName, (PortType)((uint)11), (PortDirection)num3);
			num3 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003D7A RID: 15738 RVA: 0x00144C90 File Offset: 0x00142E90
		[Token(Token = "0x6003D7A")]
		[Address(RVA = "0x7F3850", Offset = "0x7F1E50", VA = "0x1807F3850", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.onCompleted_PortName, (PortType)num, (PortDirection)((uint)1));
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003D7B RID: 15739 RVA: 0x00144CC8 File Offset: 0x00142EC8
		[Token(Token = "0x6003D7B")]
		[Address(RVA = "0x7F3940", Offset = "0x7F1F40", VA = "0x1807F3940", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			this.cachedGraph = graph;
			string text = this.plant_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.plantSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.plantSourcePort = sourcePortName;
			string text2 = this.onCompleted_PortName;
			string nodeId2 = this.nodeId;
			List<EventNodeBase> connectedNodes = graph.GetConnectedNodes(nodeId2, text2);
			this.onCompletedTargets = connectedNodes;
			throw new NullReferenceException();
		}

		// Token: 0x06003D7C RID: 15740 RVA: 0x00144D50 File Offset: 0x00142F50
		[Token(Token = "0x6003D7C")]
		[Address(RVA = "0x7F3550", Offset = "0x7F1B50", VA = "0x1807F3550", Slot = "6")]
		public override void Execute()
		{
			if (this.plantSourceNode != (ulong)0L)
			{
			}
			int num = 0;
			int num2 = 0;
			if (!(num == num2))
			{
				EventNodeDebug.Log("[DiePlantNode] 成功令植物死亡");
				this.TriggerCompletedPort();
				return;
			}
			string nodeId = this.nodeId;
			EventNodeDebug.LogWarning("[DiePlantNode] 植物对象为 null，无法执行死亡，节点ID: " + nodeId);
		}

		// Token: 0x06003D7D RID: 15741 RVA: 0x00144DA8 File Offset: 0x00142FA8
		[Token(Token = "0x6003D7D")]
		[Address(RVA = "0x7F3A50", Offset = "0x7F2050", VA = "0x1807F3A50")]
		private void TriggerCompletedPort()
		{
			ulong num2;
			do
			{
				int num = 0;
				if (this.cachedGraph == num)
				{
					break;
				}
				string text = this.onCompleted_PortName;
				string nodeId = this.nodeId;
				List<EventNodeBase> connectedNodes = this.cachedGraph.GetConnectedNodes(nodeId, text);
				bool flag;
				if (flag)
				{
				}
			}
			while (num2 != (ulong)0L);
		}

		// Token: 0x06003D7E RID: 15742 RVA: 0x00144DF4 File Offset: 0x00142FF4
		[Token(Token = "0x6003D7E")]
		[Address(RVA = "0x7F3B90", Offset = "0x7F2190", VA = "0x1807F3B90")]
		public DiePlantNode()
		{
			List<EventNodeBase> list = new List();
			this.onCompletedTargets = list;
			base..ctor();
		}

		// Token: 0x04002E2D RID: 11821
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002E2D")]
		public string trigger_PortName = "触发";

		// Token: 0x04002E2E RID: 11822
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002E2E")]
		public string plant_PortName = "植物";

		// Token: 0x04002E2F RID: 11823
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002E2F")]
		public string onCompleted_PortName = "死亡完成";

		// Token: 0x04002E30 RID: 11824
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002E30")]
		[NonSerialized]
		private EventNodeBase plantSourceNode;

		// Token: 0x04002E31 RID: 11825
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002E31")]
		[NonSerialized]
		private string plantSourcePort;

		// Token: 0x04002E32 RID: 11826
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002E32")]
		[NonSerialized]
		private List<EventNodeBase> onCompletedTargets;

		// Token: 0x04002E33 RID: 11827
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002E33")]
		[NonSerialized]
		private EventNodeGraph cachedGraph;
	}
}
