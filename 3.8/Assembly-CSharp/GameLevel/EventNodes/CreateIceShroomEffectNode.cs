using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B74 RID: 2932
	[Token(Token = "0x2000B74")]
	[Serializable]
	public class CreateIceShroomEffectNode : EventNodeBase
	{
		// Token: 0x06003D19 RID: 15641 RVA: 0x00142694 File Offset: 0x00140894
		[Token(Token = "0x6003D19")]
		[Address(RVA = "0x7BF920", Offset = "0x7BDF20", VA = "0x1807BF920", Slot = "4")]
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
			PortDefinition portDefinition2 = new PortDefinition(this.duration_PortName, (PortType)((uint)3), (PortDirection)num3);
			num3 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003D1A RID: 15642 RVA: 0x001426F4 File Offset: 0x001408F4
		[Token(Token = "0x6003D1A")]
		[Address(RVA = "0x7BFA90", Offset = "0x7BE090", VA = "0x1807BFA90", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			return null;
		}

		// Token: 0x06003D1B RID: 15643 RVA: 0x00142704 File Offset: 0x00140904
		[Token(Token = "0x6003D1B")]
		[Address(RVA = "0x7BFAD0", Offset = "0x7BE0D0", VA = "0x1807BFAD0", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.duration_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.durationSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.durationSourcePort = sourcePortName;
		}

		// Token: 0x06003D1C RID: 15644 RVA: 0x00142764 File Offset: 0x00140964
		[Token(Token = "0x6003D1C")]
		[Address(RVA = "0x7BF7A0", Offset = "0x7BDDA0", VA = "0x1807BF7A0", Slot = "6")]
		public override void Execute()
		{
			if (this.durationSourceNode != (ulong)0L)
			{
			}
			BoardAction boardAction = Board.Instance.boardAction;
			string text;
			EventNodeDebug.Log(text);
		}

		// Token: 0x06003D1D RID: 15645 RVA: 0x00142794 File Offset: 0x00140994
		[Token(Token = "0x6003D1D")]
		[Address(RVA = "0x7BFB90", Offset = "0x7BE190", VA = "0x1807BFB90")]
		public CreateIceShroomEffectNode()
		{
		}

		// Token: 0x04002DA2 RID: 11682
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002DA2")]
		public string trigger_PortName = "触发";

		// Token: 0x04002DA3 RID: 11683
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002DA3")]
		public string duration_PortName = "冻结时间";

		// Token: 0x04002DA4 RID: 11684
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002DA4")]
		[NonSerialized]
		private EventNodeBase durationSourceNode;

		// Token: 0x04002DA5 RID: 11685
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002DA5")]
		[NonSerialized]
		private string durationSourcePort;
	}
}
