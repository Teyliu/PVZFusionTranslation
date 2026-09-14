using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B63 RID: 2915
	[Token(Token = "0x2000B63")]
	[Serializable]
	public class ShowTextNode : EventNodeBase
	{
		// Token: 0x06003CC2 RID: 15554 RVA: 0x0013F994 File Offset: 0x0013DB94
		[Token(Token = "0x6003CC2")]
		[Address(RVA = "0x7D41E0", Offset = "0x7D27E0", VA = "0x1807D41E0", Slot = "4")]
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
			PortDefinition portDefinition2 = new PortDefinition(this.text_PortName, (PortType)((uint)5), (PortDirection)num3);
			num3 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			int num4;
			PortDefinition portDefinition3 = new PortDefinition(this.duration_PortName, (PortType)((uint)3), (PortDirection)num4);
			num4 = 0;
			if (portDefinition3 != 0)
			{
			}
			array[2] = portDefinition3;
			return array;
		}

		// Token: 0x06003CC3 RID: 15555 RVA: 0x0013FA14 File Offset: 0x0013DC14
		[Token(Token = "0x6003CC3")]
		[Address(RVA = "0x7D43C0", Offset = "0x7D29C0", VA = "0x1807D43C0", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			return null;
		}

		// Token: 0x06003CC4 RID: 15556 RVA: 0x0013FA24 File Offset: 0x0013DC24
		[Token(Token = "0x6003CC4")]
		[Address(RVA = "0x7D4400", Offset = "0x7D2A00", VA = "0x1807D4400", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.text_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.textSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.textSourcePort = sourcePortName;
			string text2 = this.duration_PortName;
			string nodeId2 = this.nodeId;
			List<SourcePortInfo> sourceNodes2 = graph.GetSourceNodes(nodeId2, text2);
			int num3 = 0;
			EventNodeBase sourceNode2 = sourceNodes2[num3].sourceNode;
			this.durationSourceNode = sourceNode2;
			int num4 = 0;
			string sourcePortName2 = sourceNodes2[num4].sourcePortName;
			this.durationSourcePort = sourcePortName2;
		}

		// Token: 0x06003CC5 RID: 15557 RVA: 0x0013FAD4 File Offset: 0x0013DCD4
		[Token(Token = "0x6003CC5")]
		[Address(RVA = "0x7D4040", Offset = "0x7D2640", VA = "0x1807D4040", Slot = "6")]
		public override void Execute()
		{
			if (this.textSourceNode != (ulong)0L)
			{
			}
			string text = this.displayText;
			float num = this.duration;
			if (this.durationSourceNode != (ulong)0L)
			{
			}
			EventNodeDebug.Log(string.Format("[ShowTextNode] 显示文本: {0}, 持续时间: {1}秒", text, "[ShowTextNode] 显示文本: {0}, 持续时间: {1}秒"));
			InGameText instance = InGameText.Instance;
			int num2 = 0;
			instance.ShowText(text, num, num2 != 0);
		}

		// Token: 0x06003CC6 RID: 15558 RVA: 0x0013FB38 File Offset: 0x0013DD38
		[Token(Token = "0x6003CC6")]
		[Address(RVA = "0x7D4550", Offset = "0x7D2B50", VA = "0x1807D4550")]
		public ShowTextNode()
		{
		}

		// Token: 0x04002CFB RID: 11515
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002CFB")]
		public string displayText = "示例文本";

		// Token: 0x04002CFC RID: 11516
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002CFC")]
		public float duration = 3f;

		// Token: 0x04002CFD RID: 11517
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002CFD")]
		public string trigger_PortName = "触发";

		// Token: 0x04002CFE RID: 11518
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002CFE")]
		public string text_PortName = "文本";

		// Token: 0x04002CFF RID: 11519
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002CFF")]
		public string duration_PortName = "持续时间";

		// Token: 0x04002D00 RID: 11520
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002D00")]
		[NonSerialized]
		private EventNodeBase textSourceNode;

		// Token: 0x04002D01 RID: 11521
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002D01")]
		[NonSerialized]
		private string textSourcePort;

		// Token: 0x04002D02 RID: 11522
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002D02")]
		[NonSerialized]
		private EventNodeBase durationSourceNode;

		// Token: 0x04002D03 RID: 11523
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002D03")]
		[NonSerialized]
		private string durationSourcePort;
	}
}
