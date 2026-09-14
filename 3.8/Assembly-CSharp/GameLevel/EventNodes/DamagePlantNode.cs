using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B6D RID: 2925
	[Token(Token = "0x2000B6D")]
	[Serializable]
	public class DamagePlantNode : EventNodeBase
	{
		// Token: 0x06003CF2 RID: 15602 RVA: 0x001414D4 File Offset: 0x0013F6D4
		[Token(Token = "0x6003CF2")]
		[Address(RVA = "0x7C2830", Offset = "0x7C0E30", VA = "0x1807C2830", Slot = "4")]
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
			PortDefinition portDefinition2 = new PortDefinition(this.plant_PortName, (PortType)((uint)11), (PortDirection)num3);
			num3 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			int num4;
			PortDefinition portDefinition3 = new PortDefinition(this.damage_PortName, (PortType)((uint)1), (PortDirection)num4);
			num4 = 0;
			if (portDefinition3 != 0)
			{
			}
			array[2] = portDefinition3;
			return array;
		}

		// Token: 0x06003CF3 RID: 15603 RVA: 0x00141554 File Offset: 0x0013F754
		[Token(Token = "0x6003CF3")]
		[Address(RVA = "0x7C2A10", Offset = "0x7C1010", VA = "0x1807C2A10", Slot = "5")]
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

		// Token: 0x06003CF4 RID: 15604 RVA: 0x0014158C File Offset: 0x0013F78C
		[Token(Token = "0x6003CF4")]
		[Address(RVA = "0x7C2B00", Offset = "0x7C1100", VA = "0x1807C2B00", Slot = "7")]
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
			string text2 = this.damage_PortName;
			string nodeId2 = this.nodeId;
			List<SourcePortInfo> sourceNodes2 = graph.GetSourceNodes(nodeId2, text2);
			int num3 = 0;
			EventNodeBase sourceNode2 = sourceNodes2[num3].sourceNode;
			this.damageSourceNode = sourceNode2;
			int num4 = 0;
			string sourcePortName2 = sourceNodes2[num4].sourcePortName;
			this.damageSourcePort = sourcePortName2;
			string text3 = this.onCompleted_PortName;
			string nodeId3 = this.nodeId;
			List<EventNodeBase> connectedNodes = graph.GetConnectedNodes(nodeId3, text3);
			this.onCompletedTargets = connectedNodes;
			throw new NullReferenceException();
		}

		// Token: 0x06003CF5 RID: 15605 RVA: 0x00141668 File Offset: 0x0013F868
		[Token(Token = "0x6003CF5")]
		[Address(RVA = "0x7C2610", Offset = "0x7C0C10", VA = "0x1807C2610", Slot = "6")]
		public override void Execute()
		{
			int num = 0;
			if (this.plantSourceNode != num)
			{
			}
			if (this.damageSourceNode != num)
			{
			}
			int num2 = 0;
			if (!(num != num2))
			{
				string nodeId = this.nodeId;
				EventNodeDebug.LogWarning("[DamagePlantNode] 植物对象为空，无法造成伤害，节点ID: " + nodeId);
				return;
			}
			int num3;
			EventNodeDebug.Log(string.Format("[DamagePlantNode] 对植物造成 {0} 点伤害", num3));
			this.TriggerCompletedPort();
		}

		// Token: 0x06003CF6 RID: 15606 RVA: 0x001416CC File Offset: 0x0013F8CC
		[Token(Token = "0x6003CF6")]
		[Address(RVA = "0x7C2C80", Offset = "0x7C1280", VA = "0x1807C2C80")]
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

		// Token: 0x06003CF7 RID: 15607 RVA: 0x00141718 File Offset: 0x0013F918
		[Token(Token = "0x6003CF7")]
		[Address(RVA = "0x7C2DC0", Offset = "0x7C13C0", VA = "0x1807C2DC0")]
		public DamagePlantNode()
		{
			List<EventNodeBase> list = new List();
			this.onCompletedTargets = list;
			base..ctor();
		}

		// Token: 0x04002D5F RID: 11615
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002D5F")]
		public string trigger_PortName = "触发";

		// Token: 0x04002D60 RID: 11616
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002D60")]
		public string plant_PortName = "植物";

		// Token: 0x04002D61 RID: 11617
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002D61")]
		public string damage_PortName = "伤害值";

		// Token: 0x04002D62 RID: 11618
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002D62")]
		public string onCompleted_PortName = "伤害完成";

		// Token: 0x04002D63 RID: 11619
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002D63")]
		[NonSerialized]
		private EventNodeBase plantSourceNode;

		// Token: 0x04002D64 RID: 11620
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002D64")]
		[NonSerialized]
		private string plantSourcePort;

		// Token: 0x04002D65 RID: 11621
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002D65")]
		[NonSerialized]
		private EventNodeBase damageSourceNode;

		// Token: 0x04002D66 RID: 11622
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002D66")]
		[NonSerialized]
		private string damageSourcePort;

		// Token: 0x04002D67 RID: 11623
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002D67")]
		[NonSerialized]
		private List<EventNodeBase> onCompletedTargets;

		// Token: 0x04002D68 RID: 11624
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002D68")]
		[NonSerialized]
		private EventNodeGraph cachedGraph;
	}
}
