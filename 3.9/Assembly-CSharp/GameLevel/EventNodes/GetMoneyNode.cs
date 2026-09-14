using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BBB RID: 3003
	[Token(Token = "0x2000BBB")]
	[Serializable]
	public class GetMoneyNode : EventNodeBase
	{
		// Token: 0x06003E83 RID: 16003 RVA: 0x0014838C File Offset: 0x0014658C
		[Token(Token = "0x6003E83")]
		[Address(RVA = "0x8449B0", Offset = "0x842FB0", VA = "0x1808449B0", Slot = "4")]
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

		// Token: 0x06003E84 RID: 16004 RVA: 0x001483EC File Offset: 0x001465EC
		[Token(Token = "0x6003E84")]
		[Address(RVA = "0x844B20", Offset = "0x843120", VA = "0x180844B20", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			return null;
		}

		// Token: 0x06003E85 RID: 16005 RVA: 0x001483FC File Offset: 0x001465FC
		[Token(Token = "0x6003E85")]
		[Address(RVA = "0x844B60", Offset = "0x843160", VA = "0x180844B60", Slot = "7")]
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

		// Token: 0x06003E86 RID: 16006 RVA: 0x0014845C File Offset: 0x0014665C
		[Token(Token = "0x6003E86")]
		[Address(RVA = "0x844880", Offset = "0x842E80", VA = "0x180844880", Slot = "6")]
		public override void Execute()
		{
			if (this.moneyAmountSourceNode != (ulong)0L)
			{
			}
			Board instance = Board.Instance;
			int num;
			EventNodeDebug.Log(string.Format("[GetMoneyNode] 获得了 {0} 金币", num));
		}

		// Token: 0x06003E87 RID: 16007 RVA: 0x00148494 File Offset: 0x00146694
		[Token(Token = "0x6003E87")]
		[Address(RVA = "0x844C20", Offset = "0x843220", VA = "0x180844C20")]
		public GetMoneyNode()
		{
		}

		// Token: 0x04002F3F RID: 12095
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002F3F")]
		public string trigger_PortName = "触发";

		// Token: 0x04002F40 RID: 12096
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002F40")]
		public string moneyAmount_PortName = "金币数量";

		// Token: 0x04002F41 RID: 12097
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002F41")]
		[NonSerialized]
		private EventNodeBase moneyAmountSourceNode;

		// Token: 0x04002F42 RID: 12098
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002F42")]
		[NonSerialized]
		private string moneyAmountSourcePort;
	}
}
