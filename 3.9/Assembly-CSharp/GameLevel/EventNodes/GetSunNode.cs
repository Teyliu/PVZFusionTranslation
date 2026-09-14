using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BB3 RID: 2995
	[Token(Token = "0x2000BB3")]
	[Serializable]
	public class GetSunNode : EventNodeBase
	{
		// Token: 0x06003E5B RID: 15963 RVA: 0x001473CC File Offset: 0x001455CC
		[Token(Token = "0x6003E5B")]
		[Address(RVA = "0x845230", Offset = "0x843830", VA = "0x180845230", Slot = "4")]
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

		// Token: 0x06003E5C RID: 15964 RVA: 0x0014742C File Offset: 0x0014562C
		[Token(Token = "0x6003E5C")]
		[Address(RVA = "0x8453A0", Offset = "0x8439A0", VA = "0x1808453A0", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			return null;
		}

		// Token: 0x06003E5D RID: 15965 RVA: 0x0014743C File Offset: 0x0014563C
		[Token(Token = "0x6003E5D")]
		[Address(RVA = "0x8453E0", Offset = "0x8439E0", VA = "0x1808453E0", Slot = "7")]
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

		// Token: 0x06003E5E RID: 15966 RVA: 0x0014749C File Offset: 0x0014569C
		[Token(Token = "0x6003E5E")]
		[Address(RVA = "0x8450F0", Offset = "0x8436F0", VA = "0x1808450F0", Slot = "6")]
		public override void Execute()
		{
			if (this.sunAmountSourceNode != (ulong)0L)
			{
			}
			Board instance = Board.Instance;
			int num;
			EventNodeDebug.Log(string.Format("[GetSunNode] 获得了 {0} 阳光", num));
		}

		// Token: 0x06003E5F RID: 15967 RVA: 0x001474D4 File Offset: 0x001456D4
		[Token(Token = "0x6003E5F")]
		[Address(RVA = "0x8454A0", Offset = "0x843AA0", VA = "0x1808454A0")]
		public GetSunNode()
		{
		}

		// Token: 0x04002F03 RID: 12035
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002F03")]
		public string trigger_PortName = "触发";

		// Token: 0x04002F04 RID: 12036
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002F04")]
		public string sunAmount_PortName = "阳光数量";

		// Token: 0x04002F05 RID: 12037
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002F05")]
		[NonSerialized]
		private EventNodeBase sunAmountSourceNode;

		// Token: 0x04002F06 RID: 12038
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002F06")]
		[NonSerialized]
		private string sunAmountSourcePort;
	}
}
