using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B84 RID: 2948
	[Token(Token = "0x2000B84")]
	[Serializable]
	public class DeleteCardByTypeNode : EventNodeBase
	{
		// Token: 0x06003D66 RID: 15718 RVA: 0x001441C4 File Offset: 0x001423C4
		[Token(Token = "0x6003D66")]
		[Address(RVA = "0x7F2FE0", Offset = "0x7F15E0", VA = "0x1807F2FE0", Slot = "4")]
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
			PortDefinition portDefinition2 = new PortDefinition(this.plantType_PortName, (PortType)((uint)9), (PortDirection)num3);
			num3 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003D67 RID: 15719 RVA: 0x00144224 File Offset: 0x00142424
		[Token(Token = "0x6003D67")]
		[Address(RVA = "0x7F3150", Offset = "0x7F1750", VA = "0x1807F3150", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.completed_PortName, (PortType)num, (PortDirection)((uint)1));
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003D68 RID: 15720 RVA: 0x0014425C File Offset: 0x0014245C
		[Token(Token = "0x6003D68")]
		[Address(RVA = "0x7F3240", Offset = "0x7F1840", VA = "0x1807F3240", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			this.cachedGraph = graph;
			string text = this.plantType_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.plantTypeSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.plantTypeSourcePort = sourcePortName;
		}

		// Token: 0x06003D69 RID: 15721 RVA: 0x001442C0 File Offset: 0x001424C0
		[Token(Token = "0x6003D69")]
		[Address(RVA = "0x7F2CE0", Offset = "0x7F12E0", VA = "0x1807F2CE0", Slot = "6")]
		public override void Execute()
		{
			if (this.plantTypeSourceNode != (ulong)0L)
			{
				PlantType plantType = this.plantType;
			}
			PlantType plantType2 = this.plantType;
			EventNodeDebug.Log(string.Format("[DeleteCardByTypeNode] 开始删除卡槽上的植物卡牌: {0}", "[DeleteCardByTypeNode] 删除了卡牌: {0}"));
			CardSlotManager cardSlotManager = InGameUI.Instance._cardSlotManager;
			if (cardSlotManager != 0)
			{
				int num = 0;
				int activeCardCount = cardSlotManager.ActiveCardCount;
				CardUI cardAtIndex = cardSlotManager.GetCardAtIndex(activeCardCount);
				int num2 = 0;
				ulong num3;
				if (cardAtIndex != num2 && cardAtIndex.thePlantType == plantType2 && cardSlotManager.RemoveCard(cardAtIndex, num3 != 0UL))
				{
					PlantType thePlantType = cardAtIndex.thePlantType;
					num++;
					EventNodeDebug.Log(string.Format("[DeleteCardByTypeNode] 删除了卡牌: {0}", thePlantType));
				}
				int num4;
				EventNodeDebug.Log(string.Format("[DeleteCardByTypeNode] 删除完成，共删除了 {0} 张卡牌", num4));
				this.TriggerCompletedPort();
				return;
			}
			string nodeId = this.nodeId;
			EventNodeDebug.LogWarning("[DeleteCardByTypeNode] 卡槽管理器不存在，节点ID: " + nodeId);
			this.TriggerCompletedPort();
		}

		// Token: 0x06003D6A RID: 15722 RVA: 0x001443A0 File Offset: 0x001425A0
		[Token(Token = "0x6003D6A")]
		[Address(RVA = "0x7F3310", Offset = "0x7F1910", VA = "0x1807F3310")]
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
				string text = this.completed_PortName;
				string nodeId = this.nodeId;
				List<EventNodeBase> connectedNodes = this.cachedGraph.GetConnectedNodes(nodeId, text);
				bool flag;
				if (flag)
				{
					string text2;
					EventNodeDebug.Log(text2);
				}
			}
			while (num2 != (ulong)0L);
		}

		// Token: 0x06003D6B RID: 15723 RVA: 0x001443F4 File Offset: 0x001425F4
		[Token(Token = "0x6003D6B")]
		[Address(RVA = "0x7F34B0", Offset = "0x7F1AB0", VA = "0x1807F34B0")]
		public DeleteCardByTypeNode()
		{
		}

		// Token: 0x04002E08 RID: 11784
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002E08")]
		public PlantType plantType;

		// Token: 0x04002E09 RID: 11785
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002E09")]
		public string trigger_PortName = "触发";

		// Token: 0x04002E0A RID: 11786
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002E0A")]
		public string plantType_PortName = "植物类型";

		// Token: 0x04002E0B RID: 11787
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002E0B")]
		public string completed_PortName = "完成";

		// Token: 0x04002E0C RID: 11788
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002E0C")]
		[NonSerialized]
		private EventNodeBase plantTypeSourceNode;

		// Token: 0x04002E0D RID: 11789
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002E0D")]
		[NonSerialized]
		private string plantTypeSourcePort;

		// Token: 0x04002E0E RID: 11790
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002E0E")]
		[NonSerialized]
		private EventNodeGraph cachedGraph;
	}
}
