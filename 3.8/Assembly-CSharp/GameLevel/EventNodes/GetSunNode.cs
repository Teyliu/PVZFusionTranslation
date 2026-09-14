using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B71 RID: 2929
	[Token(Token = "0x2000B71")]
	[Serializable]
	public class GetSunNode : EventNodeBase
	{
		// Token: 0x06003D0A RID: 15626 RVA: 0x00142138 File Offset: 0x00140338
		[Token(Token = "0x6003D0A")]
		[Address(RVA = "0x7C8ED0", Offset = "0x7C74D0", VA = "0x1807C8ED0", Slot = "4")]
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
			PortDefinition portDefinition2 = new PortDefinition(this.sunAmount_PortName, (PortType)((uint)1), (PortDirection)num3);
			num3 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003D0B RID: 15627 RVA: 0x00142198 File Offset: 0x00140398
		[Token(Token = "0x6003D0B")]
		[Address(RVA = "0x7C9040", Offset = "0x7C7640", VA = "0x1807C9040", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			return null;
		}

		// Token: 0x06003D0C RID: 15628 RVA: 0x001421A8 File Offset: 0x001403A8
		[Token(Token = "0x6003D0C")]
		[Address(RVA = "0x7C9080", Offset = "0x7C7680", VA = "0x1807C9080", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.sunAmount_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.sunAmountSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.sunAmountSourcePort = sourcePortName;
		}

		// Token: 0x06003D0D RID: 15629 RVA: 0x00142208 File Offset: 0x00140408
		[Token(Token = "0x6003D0D")]
		[Address(RVA = "0x7C8D90", Offset = "0x7C7390", VA = "0x1807C8D90", Slot = "6")]
		public override void Execute()
		{
			if (this.sunAmountSourceNode != (ulong)0L)
			{
			}
			Board instance = Board.Instance;
			int num;
			EventNodeDebug.Log(string.Format("[GetSunNode] 获得了 {0} 阳光", num));
		}

		// Token: 0x06003D0E RID: 15630 RVA: 0x00142240 File Offset: 0x00140440
		[Token(Token = "0x6003D0E")]
		[Address(RVA = "0x7C9140", Offset = "0x7C7740", VA = "0x1807C9140")]
		public GetSunNode()
		{
		}

		// Token: 0x04002D8F RID: 11663
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002D8F")]
		public string trigger_PortName = "触发";

		// Token: 0x04002D90 RID: 11664
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002D90")]
		public string sunAmount_PortName = "阳光数量";

		// Token: 0x04002D91 RID: 11665
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002D91")]
		[NonSerialized]
		private EventNodeBase sunAmountSourceNode;

		// Token: 0x04002D92 RID: 11666
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002D92")]
		[NonSerialized]
		private string sunAmountSourcePort;
	}
}
