using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BAF RID: 2991
	[Token(Token = "0x2000BAF")]
	[Serializable]
	public class DamagePlantNode : EventNodeBase
	{
		// Token: 0x06003E43 RID: 15939 RVA: 0x0014676C File Offset: 0x0014496C
		[Token(Token = "0x6003E43")]
		[Address(RVA = "0x83EB90", Offset = "0x83D190", VA = "0x18083EB90", Slot = "4")]
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

		// Token: 0x06003E44 RID: 15940 RVA: 0x001467EC File Offset: 0x001449EC
		[Token(Token = "0x6003E44")]
		[Address(RVA = "0x83ED70", Offset = "0x83D370", VA = "0x18083ED70", Slot = "5")]
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

		// Token: 0x06003E45 RID: 15941 RVA: 0x00146824 File Offset: 0x00144A24
		[Token(Token = "0x6003E45")]
		[Address(RVA = "0x83EE60", Offset = "0x83D460", VA = "0x18083EE60", Slot = "7")]
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

		// Token: 0x06003E46 RID: 15942 RVA: 0x00146900 File Offset: 0x00144B00
		[Token(Token = "0x6003E46")]
		[Address(RVA = "0x83E970", Offset = "0x83CF70", VA = "0x18083E970", Slot = "6")]
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

		// Token: 0x06003E47 RID: 15943 RVA: 0x00146964 File Offset: 0x00144B64
		[Token(Token = "0x6003E47")]
		[Address(RVA = "0x83EFE0", Offset = "0x83D5E0", VA = "0x18083EFE0")]
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

		// Token: 0x06003E48 RID: 15944 RVA: 0x001469B0 File Offset: 0x00144BB0
		[Token(Token = "0x6003E48")]
		[Address(RVA = "0x83F120", Offset = "0x83D720", VA = "0x18083F120")]
		public DamagePlantNode()
		{
			List<EventNodeBase> list = new List();
			this.onCompletedTargets = list;
			base..ctor();
		}

		// Token: 0x04002ED3 RID: 11987
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002ED3")]
		public string trigger_PortName = "触发";

		// Token: 0x04002ED4 RID: 11988
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002ED4")]
		public string plant_PortName = "植物";

		// Token: 0x04002ED5 RID: 11989
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002ED5")]
		public string damage_PortName = "伤害值";

		// Token: 0x04002ED6 RID: 11990
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002ED6")]
		public string onCompleted_PortName = "伤害完成";

		// Token: 0x04002ED7 RID: 11991
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002ED7")]
		[NonSerialized]
		private EventNodeBase plantSourceNode;

		// Token: 0x04002ED8 RID: 11992
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002ED8")]
		[NonSerialized]
		private string plantSourcePort;

		// Token: 0x04002ED9 RID: 11993
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002ED9")]
		[NonSerialized]
		private EventNodeBase damageSourceNode;

		// Token: 0x04002EDA RID: 11994
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002EDA")]
		[NonSerialized]
		private string damageSourcePort;

		// Token: 0x04002EDB RID: 11995
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002EDB")]
		[NonSerialized]
		private List<EventNodeBase> onCompletedTargets;

		// Token: 0x04002EDC RID: 11996
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002EDC")]
		[NonSerialized]
		private EventNodeGraph cachedGraph;
	}
}
