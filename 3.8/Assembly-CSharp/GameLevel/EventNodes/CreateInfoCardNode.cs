using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BCF RID: 3023
	[Token(Token = "0x2000BCF")]
	[Serializable]
	public class CreateInfoCardNode : EventNodeBase
	{
		// Token: 0x06003EF0 RID: 16112 RVA: 0x0014D460 File Offset: 0x0014B660
		[Token(Token = "0x6003EF0")]
		[Address(RVA = "0x7F2130", Offset = "0x7F0730", VA = "0x1807F2130", Slot = "4")]
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
			PortDefinition portDefinition2 = new PortDefinition(this.bigTitle_PortName, (PortType)((uint)5), (PortDirection)num3);
			num3 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			int num4;
			PortDefinition portDefinition3 = new PortDefinition(this.smallTitle_PortName, (PortType)((uint)5), (PortDirection)num4);
			num4 = 0;
			if (portDefinition3 != 0)
			{
			}
			array[2] = portDefinition3;
			return array;
		}

		// Token: 0x06003EF1 RID: 16113 RVA: 0x0014D4E0 File Offset: 0x0014B6E0
		[Token(Token = "0x6003EF1")]
		[Address(RVA = "0x7F2310", Offset = "0x7F0910", VA = "0x1807F2310", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.onCardClicked_PortName, (PortType)num, (PortDirection)((uint)1));
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003EF2 RID: 16114 RVA: 0x0014D518 File Offset: 0x0014B718
		[Token(Token = "0x6003EF2")]
		[Address(RVA = "0x7F2400", Offset = "0x7F0A00", VA = "0x1807F2400", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			this.cachedGraph = graph;
			string text = this.bigTitle_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.bigTitleSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.bigTitleSourcePort = sourcePortName;
			string text2 = this.smallTitle_PortName;
			string nodeId2 = this.nodeId;
			List<SourcePortInfo> sourceNodes2 = graph.GetSourceNodes(nodeId2, text2);
			int num3 = 0;
			EventNodeBase sourceNode2 = sourceNodes2[num3].sourceNode;
			this.smallTitleSourceNode = sourceNode2;
			int num4 = 0;
			string sourcePortName2 = sourceNodes2[num4].sourcePortName;
			this.smallTitleSourcePort = sourcePortName2;
		}

		// Token: 0x06003EF3 RID: 16115 RVA: 0x0014D5D0 File Offset: 0x0014B7D0
		[Token(Token = "0x6003EF3")]
		[Address(RVA = "0x7F1E20", Offset = "0x7F0420", VA = "0x1807F1E20", Slot = "6")]
		public override void Execute()
		{
			if (this.bigTitleSourceNode != (ulong)0L)
			{
			}
			if (this.smallTitleSourceNode != (ulong)0L)
			{
			}
			int num = 0;
			EventNodeDebug.Log("[CreateInfoCardNode] 创建信息卡牌 - 大标题: " + "信息" + ", 小标题: " + "信息");
			InitBoard instance = InitBoard.Instance;
			CardUI cardUI;
			cardUI.theSeedCost = num;
			cardUI.GetComponentInChildren<TextMeshProUGUI>().text = "信息";
			cardUI.text.text = "信息";
			Action action = delegate
			{
				string text = this.onCardClicked_PortName;
				base.TriggerConnectedNodes(text);
			};
			Delegate @delegate;
			if (@delegate == 0)
			{
			}
			if (@delegate != 0 && @delegate != 0)
			{
				return;
			}
			throw new InvalidCastException();
		}

		// Token: 0x06003EF4 RID: 16116 RVA: 0x0014D66C File Offset: 0x0014B86C
		[Token(Token = "0x6003EF4")]
		[Address(RVA = "0x7F2570", Offset = "0x7F0B70", VA = "0x1807F2570")]
		public CreateInfoCardNode()
		{
		}

		// Token: 0x04002FF0 RID: 12272
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002FF0")]
		public string trigger_PortName = "触发";

		// Token: 0x04002FF1 RID: 12273
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002FF1")]
		public string bigTitle_PortName = "大标题";

		// Token: 0x04002FF2 RID: 12274
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002FF2")]
		public string smallTitle_PortName = "小标题";

		// Token: 0x04002FF3 RID: 12275
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002FF3")]
		public string onCardClicked_PortName = "点击卡牌时触发";

		// Token: 0x04002FF4 RID: 12276
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002FF4")]
		[NonSerialized]
		private EventNodeBase bigTitleSourceNode;

		// Token: 0x04002FF5 RID: 12277
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002FF5")]
		[NonSerialized]
		private string bigTitleSourcePort;

		// Token: 0x04002FF6 RID: 12278
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002FF6")]
		[NonSerialized]
		private EventNodeBase smallTitleSourceNode;

		// Token: 0x04002FF7 RID: 12279
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002FF7")]
		[NonSerialized]
		private string smallTitleSourcePort;

		// Token: 0x04002FF8 RID: 12280
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002FF8")]
		[NonSerialized]
		private EventNodeGraph cachedGraph;
	}
}
