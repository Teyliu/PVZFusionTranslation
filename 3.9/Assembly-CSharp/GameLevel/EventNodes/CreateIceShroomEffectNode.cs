using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BB6 RID: 2998
	[Token(Token = "0x2000BB6")]
	[Serializable]
	public class CreateIceShroomEffectNode : EventNodeBase
	{
		// Token: 0x06003E6A RID: 15978 RVA: 0x00147928 File Offset: 0x00145B28
		[Token(Token = "0x6003E6A")]
		[Address(RVA = "0x83BC80", Offset = "0x83A280", VA = "0x18083BC80", Slot = "4")]
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

		// Token: 0x06003E6B RID: 15979 RVA: 0x00147988 File Offset: 0x00145B88
		[Token(Token = "0x6003E6B")]
		[Address(RVA = "0x83BDF0", Offset = "0x83A3F0", VA = "0x18083BDF0", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			return null;
		}

		// Token: 0x06003E6C RID: 15980 RVA: 0x00147998 File Offset: 0x00145B98
		[Token(Token = "0x6003E6C")]
		[Address(RVA = "0x83BE30", Offset = "0x83A430", VA = "0x18083BE30", Slot = "7")]
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

		// Token: 0x06003E6D RID: 15981 RVA: 0x001479F8 File Offset: 0x00145BF8
		[Token(Token = "0x6003E6D")]
		[Address(RVA = "0x83BAF0", Offset = "0x83A0F0", VA = "0x18083BAF0", Slot = "6")]
		public override void Execute()
		{
			if (this.durationSourceNode != (ulong)0L)
			{
			}
			BoardAction boardAction = Board.Instance.boardAction;
			string text;
			EventNodeDebug.Log(text);
		}

		// Token: 0x06003E6E RID: 15982 RVA: 0x00147A28 File Offset: 0x00145C28
		[Token(Token = "0x6003E6E")]
		[Address(RVA = "0x83BEF0", Offset = "0x83A4F0", VA = "0x18083BEF0")]
		public CreateIceShroomEffectNode()
		{
		}

		// Token: 0x04002F16 RID: 12054
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002F16")]
		public string trigger_PortName = "触发";

		// Token: 0x04002F17 RID: 12055
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002F17")]
		public string duration_PortName = "冻结时间";

		// Token: 0x04002F18 RID: 12056
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002F18")]
		[NonSerialized]
		private EventNodeBase durationSourceNode;

		// Token: 0x04002F19 RID: 12057
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002F19")]
		[NonSerialized]
		private string durationSourcePort;
	}
}
