using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BA5 RID: 2981
	[Token(Token = "0x2000BA5")]
	[Serializable]
	public class ShowTextNode : EventNodeBase
	{
		// Token: 0x06003E13 RID: 15891 RVA: 0x00144C44 File Offset: 0x00142E44
		[Token(Token = "0x6003E13")]
		[Address(RVA = "0x850540", Offset = "0x84EB40", VA = "0x180850540", Slot = "4")]
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

		// Token: 0x06003E14 RID: 15892 RVA: 0x00144CC4 File Offset: 0x00142EC4
		[Token(Token = "0x6003E14")]
		[Address(RVA = "0x850720", Offset = "0x84ED20", VA = "0x180850720", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			return null;
		}

		// Token: 0x06003E15 RID: 15893 RVA: 0x00144CD4 File Offset: 0x00142ED4
		[Token(Token = "0x6003E15")]
		[Address(RVA = "0x850760", Offset = "0x84ED60", VA = "0x180850760", Slot = "7")]
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

		// Token: 0x06003E16 RID: 15894 RVA: 0x00144D84 File Offset: 0x00142F84
		[Token(Token = "0x6003E16")]
		[Address(RVA = "0x8503A0", Offset = "0x84E9A0", VA = "0x1808503A0", Slot = "6")]
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
		}

		// Token: 0x06003E17 RID: 15895 RVA: 0x00144DDC File Offset: 0x00142FDC
		[Token(Token = "0x6003E17")]
		[Address(RVA = "0x8508B0", Offset = "0x84EEB0", VA = "0x1808508B0")]
		public ShowTextNode()
		{
		}

		// Token: 0x04002E6F RID: 11887
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002E6F")]
		public string displayText = "示例文本";

		// Token: 0x04002E70 RID: 11888
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002E70")]
		public float duration = 3f;

		// Token: 0x04002E71 RID: 11889
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002E71")]
		public string trigger_PortName = "触发";

		// Token: 0x04002E72 RID: 11890
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002E72")]
		public string text_PortName = "文本";

		// Token: 0x04002E73 RID: 11891
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002E73")]
		public string duration_PortName = "持续时间";

		// Token: 0x04002E74 RID: 11892
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002E74")]
		[NonSerialized]
		private EventNodeBase textSourceNode;

		// Token: 0x04002E75 RID: 11893
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002E75")]
		[NonSerialized]
		private string textSourcePort;

		// Token: 0x04002E76 RID: 11894
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002E76")]
		[NonSerialized]
		private EventNodeBase durationSourceNode;

		// Token: 0x04002E77 RID: 11895
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002E77")]
		[NonSerialized]
		private string durationSourcePort;
	}
}
