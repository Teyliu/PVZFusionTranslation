using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B6C RID: 2924
	[Token(Token = "0x2000B6C")]
	[Serializable]
	public class HealPlantNode : EventNodeBase
	{
		// Token: 0x06003CED RID: 15597 RVA: 0x001412CC File Offset: 0x0013F4CC
		[Token(Token = "0x6003CED")]
		[Address(RVA = "0x7CA410", Offset = "0x7C8A10", VA = "0x1807CA410", Slot = "4")]
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
			PortDefinition portDefinition3 = new PortDefinition(this.healAmount_PortName, (PortType)((uint)3), (PortDirection)num4);
			num4 = 0;
			if (portDefinition3 != 0)
			{
			}
			array[2] = portDefinition3;
			return array;
		}

		// Token: 0x06003CEE RID: 15598 RVA: 0x0014134C File Offset: 0x0013F54C
		[Token(Token = "0x6003CEE")]
		[Address(RVA = "0x7CA5F0", Offset = "0x7C8BF0", VA = "0x1807CA5F0", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			return null;
		}

		// Token: 0x06003CEF RID: 15599 RVA: 0x0014135C File Offset: 0x0013F55C
		[Token(Token = "0x6003CEF")]
		[Address(RVA = "0x7CA630", Offset = "0x7C8C30", VA = "0x1807CA630", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.plant_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.plantSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.plantSourcePort = sourcePortName;
			string text2 = this.healAmount_PortName;
			string nodeId2 = this.nodeId;
			List<SourcePortInfo> sourceNodes2 = graph.GetSourceNodes(nodeId2, text2);
			int num3 = 0;
			EventNodeBase sourceNode2 = sourceNodes2[num3].sourceNode;
			this.healAmountSourceNode = sourceNode2;
			int num4 = 0;
			string sourcePortName2 = sourceNodes2[num4].sourcePortName;
			this.healAmountSourcePort = sourcePortName2;
			string text3 = this.onHealed_PortName;
			string nodeId3 = this.nodeId;
			List<EventNodeBase> connectedNodes = graph.GetConnectedNodes(nodeId3, text3);
			this.onHealedTargets = connectedNodes;
			throw new NullReferenceException();
		}

		// Token: 0x06003CF0 RID: 15600 RVA: 0x00141430 File Offset: 0x0013F630
		[Token(Token = "0x6003CF0")]
		[Address(RVA = "0x7CA200", Offset = "0x7C8800", VA = "0x1807CA200", Slot = "6")]
		public override void Execute()
		{
			if (this.plantSourceNode != (ulong)0L)
			{
			}
			int num = 0;
			if (this.healAmountSourceNode != (ulong)0L)
			{
			}
			int num2 = 0;
			if (!(num != num2))
			{
				string nodeId = this.nodeId;
				EventNodeDebug.LogWarning("[HealPlantNode] 植物对象为空，无法回血，节点ID: " + nodeId);
				return;
			}
			string text;
			EventNodeDebug.Log(text);
			throw new NullReferenceException();
		}

		// Token: 0x06003CF1 RID: 15601 RVA: 0x00141488 File Offset: 0x0013F688
		[Token(Token = "0x6003CF1")]
		[Address(RVA = "0x7CA7A0", Offset = "0x7C8DA0", VA = "0x1807CA7A0")]
		public HealPlantNode()
		{
			List<EventNodeBase> list = new List();
			this.onHealedTargets = list;
			base..ctor();
		}

		// Token: 0x04002D56 RID: 11606
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002D56")]
		public string trigger_PortName = "触发";

		// Token: 0x04002D57 RID: 11607
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002D57")]
		public string plant_PortName = "植物";

		// Token: 0x04002D58 RID: 11608
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002D58")]
		public string healAmount_PortName = "回血量";

		// Token: 0x04002D59 RID: 11609
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002D59")]
		public string onHealed_PortName = "回血成功";

		// Token: 0x04002D5A RID: 11610
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002D5A")]
		[NonSerialized]
		private EventNodeBase plantSourceNode;

		// Token: 0x04002D5B RID: 11611
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002D5B")]
		[NonSerialized]
		private string plantSourcePort;

		// Token: 0x04002D5C RID: 11612
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002D5C")]
		[NonSerialized]
		private EventNodeBase healAmountSourceNode;

		// Token: 0x04002D5D RID: 11613
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002D5D")]
		[NonSerialized]
		private string healAmountSourcePort;

		// Token: 0x04002D5E RID: 11614
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002D5E")]
		[NonSerialized]
		private List<EventNodeBase> onHealedTargets;
	}
}
