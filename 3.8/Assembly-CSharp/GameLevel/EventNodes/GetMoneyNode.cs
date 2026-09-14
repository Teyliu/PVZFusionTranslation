using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B79 RID: 2937
	[Token(Token = "0x2000B79")]
	[Serializable]
	public class GetMoneyNode : EventNodeBase
	{
		// Token: 0x06003D32 RID: 15666 RVA: 0x001430F8 File Offset: 0x001412F8
		[Token(Token = "0x6003D32")]
		[Address(RVA = "0x7C8650", Offset = "0x7C6C50", VA = "0x1807C8650", Slot = "4")]
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
			PortDefinition portDefinition2 = new PortDefinition(this.moneyAmount_PortName, (PortType)((uint)1), (PortDirection)num3);
			num3 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003D33 RID: 15667 RVA: 0x00143158 File Offset: 0x00141358
		[Token(Token = "0x6003D33")]
		[Address(RVA = "0x7C87C0", Offset = "0x7C6DC0", VA = "0x1807C87C0", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			return null;
		}

		// Token: 0x06003D34 RID: 15668 RVA: 0x00143168 File Offset: 0x00141368
		[Token(Token = "0x6003D34")]
		[Address(RVA = "0x7C8800", Offset = "0x7C6E00", VA = "0x1807C8800", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.moneyAmount_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.moneyAmountSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.moneyAmountSourcePort = sourcePortName;
		}

		// Token: 0x06003D35 RID: 15669 RVA: 0x001431C8 File Offset: 0x001413C8
		[Token(Token = "0x6003D35")]
		[Address(RVA = "0x7C8520", Offset = "0x7C6B20", VA = "0x1807C8520", Slot = "6")]
		public override void Execute()
		{
			if (this.moneyAmountSourceNode != (ulong)0L)
			{
			}
			Board instance = Board.Instance;
			int num;
			EventNodeDebug.Log(string.Format("[GetMoneyNode] 获得了 {0} 金币", num));
		}

		// Token: 0x06003D36 RID: 15670 RVA: 0x00143200 File Offset: 0x00141400
		[Token(Token = "0x6003D36")]
		[Address(RVA = "0x7C88C0", Offset = "0x7C6EC0", VA = "0x1807C88C0")]
		public GetMoneyNode()
		{
		}

		// Token: 0x04002DCB RID: 11723
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002DCB")]
		public string trigger_PortName = "触发";

		// Token: 0x04002DCC RID: 11724
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002DCC")]
		public string moneyAmount_PortName = "金币数量";

		// Token: 0x04002DCD RID: 11725
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002DCD")]
		[NonSerialized]
		private EventNodeBase moneyAmountSourceNode;

		// Token: 0x04002DCE RID: 11726
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002DCE")]
		[NonSerialized]
		private string moneyAmountSourcePort;
	}
}
