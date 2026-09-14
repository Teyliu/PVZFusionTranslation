using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BC6 RID: 3014
	[Token(Token = "0x2000BC6")]
	[Serializable]
	public class DeleteCardByTypeNode : EventNodeBase
	{
		// Token: 0x06003EB7 RID: 16055 RVA: 0x00149464 File Offset: 0x00147664
		[Token(Token = "0x6003EB7")]
		[Address(RVA = "0x85AB90", Offset = "0x859190", VA = "0x18085AB90", Slot = "4")]
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

		// Token: 0x06003EB8 RID: 16056 RVA: 0x001494C4 File Offset: 0x001476C4
		[Token(Token = "0x6003EB8")]
		[Address(RVA = "0x85AD00", Offset = "0x859300", VA = "0x18085AD00", Slot = "5")]
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

		// Token: 0x06003EB9 RID: 16057 RVA: 0x001494FC File Offset: 0x001476FC
		[Token(Token = "0x6003EB9")]
		[Address(RVA = "0x85ADF0", Offset = "0x8593F0", VA = "0x18085ADF0", Slot = "7")]
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

		// Token: 0x06003EBA RID: 16058 RVA: 0x00149560 File Offset: 0x00147760
		[Token(Token = "0x6003EBA")]
		[Address(RVA = "0x85A7B0", Offset = "0x858DB0", VA = "0x18085A7B0", Slot = "6")]
		public override void Execute()
		{
			int num2;
			do
			{
				int num = 0;
				if (this.plantTypeSourceNode != num)
				{
					PlantType plantType = this.plantType;
					num += 20;
					num += num;
				}
				PlantType plantType2 = this.plantType;
				EventNodeDebug.Log(string.Format("[DeleteCardByTypeNode] 开始删除卡槽上的植物卡牌: {0}", num));
				CardSlotManager cardSlotManager = InGameUI.Instance._cardSlotManager;
				if (cardSlotManager == 0)
				{
					goto IL_00A2;
				}
				num2 = 0;
				List<CardUI> list = Enumerable.ToList<CardUI>(cardSlotManager.Cards);
				bool flag;
				if (flag)
				{
					GameObject gameObject;
					global::UnityEngine.Object.Destroy(gameObject);
					ulong num3;
					bool flag2 = cardSlotManager.RemoveCard(num, num3 != 0UL);
					num2++;
					EventNodeDebug.Log(string.Format("[DeleteCardByTypeNode] 删除了卡牌: {0}", flag2));
				}
			}
			while (num2 != 0);
			int num4;
			EventNodeDebug.Log(string.Format("[DeleteCardByTypeNode] 删除完成，共删除了 {0} 张卡牌", num4));
			int num5 = 0;
			return;
			IL_00A2:
			EventNodeDebug.LogWarning("[DeleteCardByTypeNode] 卡槽管理器不存在，节点ID: " + num5);
			throw new NullReferenceException();
		}

		// Token: 0x06003EBB RID: 16059 RVA: 0x0014962C File Offset: 0x0014782C
		[Token(Token = "0x6003EBB")]
		[Address(RVA = "0x85AEC0", Offset = "0x8594C0", VA = "0x18085AEC0")]
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

		// Token: 0x06003EBC RID: 16060 RVA: 0x00149680 File Offset: 0x00147880
		[Token(Token = "0x6003EBC")]
		[Address(RVA = "0x85B060", Offset = "0x859660", VA = "0x18085B060")]
		public DeleteCardByTypeNode()
		{
		}

		// Token: 0x04002F7C RID: 12156
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002F7C")]
		public PlantType plantType;

		// Token: 0x04002F7D RID: 12157
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002F7D")]
		public string trigger_PortName = "触发";

		// Token: 0x04002F7E RID: 12158
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002F7E")]
		public string plantType_PortName = "植物类型";

		// Token: 0x04002F7F RID: 12159
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002F7F")]
		public string completed_PortName = "完成";

		// Token: 0x04002F80 RID: 12160
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002F80")]
		[NonSerialized]
		private EventNodeBase plantTypeSourceNode;

		// Token: 0x04002F81 RID: 12161
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002F81")]
		[NonSerialized]
		private string plantTypeSourcePort;

		// Token: 0x04002F82 RID: 12162
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002F82")]
		[NonSerialized]
		private EventNodeGraph cachedGraph;
	}
}
