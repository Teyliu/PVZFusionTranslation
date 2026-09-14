using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;

namespace GameLevel.EventNodes
{
	// Token: 0x02000C11 RID: 3089
	[Token(Token = "0x2000C11")]
	[Serializable]
	public class CreateInfoCardNode : EventNodeBase
	{
		// Token: 0x06004041 RID: 16449 RVA: 0x001526B8 File Offset: 0x001508B8
		[Token(Token = "0x6004041")]
		[Address(RVA = "0x859C00", Offset = "0x858200", VA = "0x180859C00", Slot = "4")]
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

		// Token: 0x06004042 RID: 16450 RVA: 0x00152738 File Offset: 0x00150938
		[Token(Token = "0x6004042")]
		[Address(RVA = "0x859DE0", Offset = "0x8583E0", VA = "0x180859DE0", Slot = "5")]
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

		// Token: 0x06004043 RID: 16451 RVA: 0x00152770 File Offset: 0x00150970
		[Token(Token = "0x6004043")]
		[Address(RVA = "0x859ED0", Offset = "0x8584D0", VA = "0x180859ED0", Slot = "7")]
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

		// Token: 0x06004044 RID: 16452 RVA: 0x00152828 File Offset: 0x00150A28
		[Token(Token = "0x6004044")]
		[Address(RVA = "0x8598F0", Offset = "0x857EF0", VA = "0x1808598F0", Slot = "6")]
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

		// Token: 0x06004045 RID: 16453 RVA: 0x001528C4 File Offset: 0x00150AC4
		[Token(Token = "0x6004045")]
		[Address(RVA = "0x85A040", Offset = "0x858640", VA = "0x18085A040")]
		public CreateInfoCardNode()
		{
		}

		// Token: 0x04003163 RID: 12643
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4003163")]
		public string trigger_PortName = "触发";

		// Token: 0x04003164 RID: 12644
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4003164")]
		public string bigTitle_PortName = "大标题";

		// Token: 0x04003165 RID: 12645
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4003165")]
		public string smallTitle_PortName = "小标题";

		// Token: 0x04003166 RID: 12646
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4003166")]
		public string onCardClicked_PortName = "点击卡牌时触发";

		// Token: 0x04003167 RID: 12647
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4003167")]
		[NonSerialized]
		private EventNodeBase bigTitleSourceNode;

		// Token: 0x04003168 RID: 12648
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4003168")]
		[NonSerialized]
		private string bigTitleSourcePort;

		// Token: 0x04003169 RID: 12649
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4003169")]
		[NonSerialized]
		private EventNodeBase smallTitleSourceNode;

		// Token: 0x0400316A RID: 12650
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x400316A")]
		[NonSerialized]
		private string smallTitleSourcePort;

		// Token: 0x0400316B RID: 12651
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x400316B")]
		[NonSerialized]
		private EventNodeGraph cachedGraph;
	}
}
