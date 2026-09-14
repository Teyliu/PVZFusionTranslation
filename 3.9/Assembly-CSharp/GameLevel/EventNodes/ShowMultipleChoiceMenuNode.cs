using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel.EventNodes
{
	// Token: 0x02000C0E RID: 3086
	[Token(Token = "0x2000C0E")]
	[Serializable]
	public class ShowMultipleChoiceMenuNode : EventNodeBase
	{
		// Token: 0x0600402C RID: 16428 RVA: 0x00151A5C File Offset: 0x0014FC5C
		[Token(Token = "0x600402C")]
		[Address(RVA = "0x86D650", Offset = "0x86BC50", VA = "0x18086D650", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[6];
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
			PortDefinition portDefinition2 = new PortDefinition(this.options_PortName, (PortType)((uint)13), (PortDirection)num3);
			num3 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			int num4;
			PortDefinition portDefinition3 = new PortDefinition(this.refreshable_PortName, (PortType)((uint)6), (PortDirection)num4);
			num4 = 0;
			if (portDefinition3 != 0)
			{
			}
			array[2] = portDefinition3;
			int num5;
			PortDefinition portDefinition4 = new PortDefinition(this.refreshCount_PortName, (PortType)((uint)1), (PortDirection)num5);
			num5 = 0;
			if (portDefinition4 != 0)
			{
			}
			array[3] = portDefinition4;
			int num6;
			PortDefinition portDefinition5 = new PortDefinition(this.cancelable_PortName, (PortType)((uint)6), (PortDirection)num6);
			num6 = 0;
			if (portDefinition5 != 0)
			{
			}
			array[4] = portDefinition5;
			int num7;
			PortDefinition portDefinition6 = new PortDefinition(this.windowCount_PortName, (PortType)((uint)1), (PortDirection)num7);
			num7 = 0;
			if (portDefinition6 != 0)
			{
			}
			array[5] = portDefinition6;
			return array;
		}

		// Token: 0x0600402D RID: 16429 RVA: 0x00151B44 File Offset: 0x0014FD44
		[Token(Token = "0x600402D")]
		[Address(RVA = "0x86D990", Offset = "0x86BF90", VA = "0x18086D990", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[2];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.actionOnExit_PortName, (PortType)num, (PortDirection)((uint)1));
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			int num2;
			PortDefinition portDefinition2 = new PortDefinition(this.actionOnRefresh_PortName, (PortType)num2, (PortDirection)((uint)1));
			num2 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x0600402E RID: 16430 RVA: 0x00151BA0 File Offset: 0x0014FDA0
		[Token(Token = "0x600402E")]
		[Address(RVA = "0x86DB00", Offset = "0x86C100", VA = "0x18086DB00", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			this.cachedGraph = graph;
			string text = this.options_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.optionsSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.optionsSourcePort = sourcePortName;
			string text2 = this.refreshable_PortName;
			string nodeId2 = this.nodeId;
			List<SourcePortInfo> sourceNodes2 = graph.GetSourceNodes(nodeId2, text2);
			int num3 = 0;
			EventNodeBase sourceNode2 = sourceNodes2[num3].sourceNode;
			this.refreshableSourceNode = sourceNode2;
			int num4 = 0;
			string sourcePortName2 = sourceNodes2[num4].sourcePortName;
			this.refreshableSourcePort = sourcePortName2;
			string text3 = this.refreshCount_PortName;
			string nodeId3 = this.nodeId;
			List<SourcePortInfo> sourceNodes3 = graph.GetSourceNodes(nodeId3, text3);
			int num5 = 0;
			EventNodeBase sourceNode3 = sourceNodes3[num5].sourceNode;
			this.refreshCountSourceNode = sourceNode3;
			int num6 = 0;
			string sourcePortName3 = sourceNodes3[num6].sourcePortName;
			this.refreshCountSourcePort = sourcePortName3;
			string text4 = this.cancelable_PortName;
			string nodeId4 = this.nodeId;
			List<SourcePortInfo> sourceNodes4 = graph.GetSourceNodes(nodeId4, text4);
			int num7 = 0;
			EventNodeBase sourceNode4 = sourceNodes4[num7].sourceNode;
			this.cancelableSourceNode = sourceNode4;
			int num8 = 0;
			string sourcePortName4 = sourceNodes4[num8].sourcePortName;
			this.cancelableSourcePort = sourcePortName4;
			string text5 = this.windowCount_PortName;
			string nodeId5 = this.nodeId;
			List<SourcePortInfo> sourceNodes5 = graph.GetSourceNodes(nodeId5, text5);
			int num9 = 0;
			EventNodeBase sourceNode5 = sourceNodes5[num9].sourceNode;
			this.windowCountSourceNode = sourceNode5;
			int num10 = 0;
			string sourcePortName5 = sourceNodes5[num10].sourcePortName;
			this.windowCountSourcePort = sourcePortName5;
		}

		// Token: 0x0600402F RID: 16431 RVA: 0x00151D4C File Offset: 0x0014FF4C
		[Token(Token = "0x600402F")]
		[Address(RVA = "0x86D310", Offset = "0x86B910", VA = "0x18086D310", Slot = "6")]
		public override void Execute()
		{
			if (this.optionsSourceNode != (ulong)0L)
			{
			}
			List<MultipleChoiceOptionData> list = new List();
			if (this.refreshableSourceNode != (ulong)0L)
			{
				list += list;
			}
			bool flag = this.refreshable;
			if (this.refreshCountSourceNode != (ulong)0L)
			{
				list += list;
			}
			int num = this.refreshCount;
			if (this.cancelableSourceNode != (ulong)0L)
			{
				list += list;
			}
			bool flag2 = this.cancelable;
			int num2;
			if (this.windowCountSourceNode != (ulong)0L)
			{
				num2 = this.windowCount;
				list += list;
			}
			int num3 = this.windowCount;
			int size = list._size;
			num2 = size;
			EventNodeDebug.Log(string.Format("[ShowMultipleChoiceMenuNode] 显示多选菜单，选项数量: {0}, 窗口数量: {1}", num2, num2));
			this.ShowMenu(list, flag, num, flag2, num3);
		}

		// Token: 0x06004030 RID: 16432 RVA: 0x00151E04 File Offset: 0x00150004
		[Token(Token = "0x6004030")]
		[Address(RVA = "0x86E1F0", Offset = "0x86C7F0", VA = "0x18086E1F0")]
		private void ShowMenu(List<MultipleChoiceOptionData> options, bool refreshable, int refreshCountValue, bool cancelable, int windowCountValue)
		{
			UIResourcesLoader uimanager = GameAPP.UIManager;
			Transform canvasUp = GameAPP.canvasUp;
			int num = 0;
			BaseMenu baseMenu = uimanager.Push((UIType)((uint)80), canvasUp, num != 0);
			if (baseMenu == 0)
			{
			}
			int num2 = 0;
			if (baseMenu != num2)
			{
				if (options != 0)
				{
				}
				Action action = new Action(this.OnMenuExit);
				Action action2 = new Action(this.OnMenuRefresh);
			}
		}

		// Token: 0x06004031 RID: 16433 RVA: 0x00151E70 File Offset: 0x00150070
		[Token(Token = "0x6004031")]
		[Address(RVA = "0x86DE10", Offset = "0x86C410", VA = "0x18086DE10")]
		private void OnMenuExit()
		{
			ulong num;
			do
			{
				string text = this.actionOnExit_PortName;
				EventNodeDebug.Log("[ShowMultipleChoiceMenuNode] 菜单退出，触发输出端口: " + text);
				if (this.cachedGraph == (ulong)0L)
				{
					break;
				}
				string text2 = this.actionOnExit_PortName;
				string nodeId = this.nodeId;
				List<EventNodeBase> connectedNodes = this.cachedGraph.GetConnectedNodes(nodeId, text2);
				bool flag;
				if (flag)
				{
					string text3;
					EventNodeDebug.Log(text3);
				}
			}
			while (num != (ulong)0L);
		}

		// Token: 0x06004032 RID: 16434 RVA: 0x00151EDC File Offset: 0x001500DC
		[Token(Token = "0x6004032")]
		[Address(RVA = "0x86E000", Offset = "0x86C600", VA = "0x18086E000")]
		private void OnMenuRefresh()
		{
			ulong num;
			do
			{
				string text = this.actionOnRefresh_PortName;
				EventNodeDebug.Log("[ShowMultipleChoiceMenuNode] 菜单刷新，触发输出端口: " + text);
				if (this.cachedGraph == (ulong)0L)
				{
					break;
				}
				string text2 = this.actionOnRefresh_PortName;
				string nodeId = this.nodeId;
				List<EventNodeBase> connectedNodes = this.cachedGraph.GetConnectedNodes(nodeId, text2);
				bool flag;
				if (flag)
				{
					string text3;
					EventNodeDebug.Log(text3);
				}
			}
			while (num != (ulong)0L);
		}

		// Token: 0x06004033 RID: 16435 RVA: 0x00151F48 File Offset: 0x00150148
		[Token(Token = "0x6004033")]
		[Address(RVA = "0x86E450", Offset = "0x86CA50", VA = "0x18086E450")]
		public ShowMultipleChoiceMenuNode()
		{
		}

		// Token: 0x04003131 RID: 12593
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4003131")]
		public bool refreshable;

		// Token: 0x04003132 RID: 12594
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4003132")]
		public int refreshCount = (int)((ulong)3L);

		// Token: 0x04003133 RID: 12595
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4003133")]
		public bool cancelable = true;

		// Token: 0x04003134 RID: 12596
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x4003134")]
		public int windowCount = (int)((ulong)3L);

		// Token: 0x04003135 RID: 12597
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4003135")]
		public string trigger_PortName = "触发";

		// Token: 0x04003136 RID: 12598
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4003136")]
		public string options_PortName = "选项列表";

		// Token: 0x04003137 RID: 12599
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4003137")]
		public string refreshable_PortName = "可刷新";

		// Token: 0x04003138 RID: 12600
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4003138")]
		public string refreshCount_PortName = "刷新次数";

		// Token: 0x04003139 RID: 12601
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4003139")]
		public string cancelable_PortName = "可取消";

		// Token: 0x0400313A RID: 12602
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x400313A")]
		public string windowCount_PortName = "窗口数量";

		// Token: 0x0400313B RID: 12603
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x400313B")]
		public string actionOnExit_PortName = "退出时触发";

		// Token: 0x0400313C RID: 12604
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x400313C")]
		public string actionOnRefresh_PortName = "刷新时触发";

		// Token: 0x0400313D RID: 12605
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x400313D")]
		[NonSerialized]
		private EventNodeBase optionsSourceNode;

		// Token: 0x0400313E RID: 12606
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x400313E")]
		[NonSerialized]
		private string optionsSourcePort;

		// Token: 0x0400313F RID: 12607
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x400313F")]
		[NonSerialized]
		private EventNodeBase refreshableSourceNode;

		// Token: 0x04003140 RID: 12608
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4003140")]
		[NonSerialized]
		private string refreshableSourcePort;

		// Token: 0x04003141 RID: 12609
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4003141")]
		[NonSerialized]
		private EventNodeBase refreshCountSourceNode;

		// Token: 0x04003142 RID: 12610
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x4003142")]
		[NonSerialized]
		private string refreshCountSourcePort;

		// Token: 0x04003143 RID: 12611
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x4003143")]
		[NonSerialized]
		private EventNodeBase cancelableSourceNode;

		// Token: 0x04003144 RID: 12612
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x4003144")]
		[NonSerialized]
		private string cancelableSourcePort;

		// Token: 0x04003145 RID: 12613
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x4003145")]
		[NonSerialized]
		private EventNodeBase windowCountSourceNode;

		// Token: 0x04003146 RID: 12614
		[FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x4003146")]
		[NonSerialized]
		private string windowCountSourcePort;

		// Token: 0x04003147 RID: 12615
		[FieldOffset(Offset = "0xD0")]
		[Token(Token = "0x4003147")]
		[NonSerialized]
		private EventNodeGraph cachedGraph;
	}
}
