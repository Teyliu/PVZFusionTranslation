using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BCC RID: 3020
	[Token(Token = "0x2000BCC")]
	[Serializable]
	public class ShowMultipleChoiceMenuNode : EventNodeBase
	{
		// Token: 0x06003EDB RID: 16091 RVA: 0x0014C7F0 File Offset: 0x0014A9F0
		[Token(Token = "0x6003EDB")]
		[Address(RVA = "0x805CA0", Offset = "0x8042A0", VA = "0x180805CA0", Slot = "4")]
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

		// Token: 0x06003EDC RID: 16092 RVA: 0x0014C8D8 File Offset: 0x0014AAD8
		[Token(Token = "0x6003EDC")]
		[Address(RVA = "0x805FE0", Offset = "0x8045E0", VA = "0x180805FE0", Slot = "5")]
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

		// Token: 0x06003EDD RID: 16093 RVA: 0x0014C934 File Offset: 0x0014AB34
		[Token(Token = "0x6003EDD")]
		[Address(RVA = "0x806150", Offset = "0x804750", VA = "0x180806150", Slot = "7")]
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

		// Token: 0x06003EDE RID: 16094 RVA: 0x0014CAE0 File Offset: 0x0014ACE0
		[Token(Token = "0x6003EDE")]
		[Address(RVA = "0x805960", Offset = "0x803F60", VA = "0x180805960", Slot = "6")]
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

		// Token: 0x06003EDF RID: 16095 RVA: 0x0014CB98 File Offset: 0x0014AD98
		[Token(Token = "0x6003EDF")]
		[Address(RVA = "0x806840", Offset = "0x804E40", VA = "0x180806840")]
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

		// Token: 0x06003EE0 RID: 16096 RVA: 0x0014CC04 File Offset: 0x0014AE04
		[Token(Token = "0x6003EE0")]
		[Address(RVA = "0x806460", Offset = "0x804A60", VA = "0x180806460")]
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

		// Token: 0x06003EE1 RID: 16097 RVA: 0x0014CC70 File Offset: 0x0014AE70
		[Token(Token = "0x6003EE1")]
		[Address(RVA = "0x806650", Offset = "0x804C50", VA = "0x180806650")]
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

		// Token: 0x06003EE2 RID: 16098 RVA: 0x0014CCDC File Offset: 0x0014AEDC
		[Token(Token = "0x6003EE2")]
		[Address(RVA = "0x806AA0", Offset = "0x8050A0", VA = "0x180806AA0")]
		public ShowMultipleChoiceMenuNode()
		{
		}

		// Token: 0x04002FBD RID: 12221
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002FBD")]
		public bool refreshable;

		// Token: 0x04002FBE RID: 12222
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4002FBE")]
		public int refreshCount = (int)((ulong)3L);

		// Token: 0x04002FBF RID: 12223
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002FBF")]
		public bool cancelable = true;

		// Token: 0x04002FC0 RID: 12224
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x4002FC0")]
		public int windowCount = (int)((ulong)3L);

		// Token: 0x04002FC1 RID: 12225
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002FC1")]
		public string trigger_PortName = "触发";

		// Token: 0x04002FC2 RID: 12226
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002FC2")]
		public string options_PortName = "选项列表";

		// Token: 0x04002FC3 RID: 12227
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002FC3")]
		public string refreshable_PortName = "可刷新";

		// Token: 0x04002FC4 RID: 12228
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002FC4")]
		public string refreshCount_PortName = "刷新次数";

		// Token: 0x04002FC5 RID: 12229
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002FC5")]
		public string cancelable_PortName = "可取消";

		// Token: 0x04002FC6 RID: 12230
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002FC6")]
		public string windowCount_PortName = "窗口数量";

		// Token: 0x04002FC7 RID: 12231
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002FC7")]
		public string actionOnExit_PortName = "退出时触发";

		// Token: 0x04002FC8 RID: 12232
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002FC8")]
		public string actionOnRefresh_PortName = "刷新时触发";

		// Token: 0x04002FC9 RID: 12233
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4002FC9")]
		[NonSerialized]
		private EventNodeBase optionsSourceNode;

		// Token: 0x04002FCA RID: 12234
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4002FCA")]
		[NonSerialized]
		private string optionsSourcePort;

		// Token: 0x04002FCB RID: 12235
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4002FCB")]
		[NonSerialized]
		private EventNodeBase refreshableSourceNode;

		// Token: 0x04002FCC RID: 12236
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4002FCC")]
		[NonSerialized]
		private string refreshableSourcePort;

		// Token: 0x04002FCD RID: 12237
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4002FCD")]
		[NonSerialized]
		private EventNodeBase refreshCountSourceNode;

		// Token: 0x04002FCE RID: 12238
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x4002FCE")]
		[NonSerialized]
		private string refreshCountSourcePort;

		// Token: 0x04002FCF RID: 12239
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x4002FCF")]
		[NonSerialized]
		private EventNodeBase cancelableSourceNode;

		// Token: 0x04002FD0 RID: 12240
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x4002FD0")]
		[NonSerialized]
		private string cancelableSourcePort;

		// Token: 0x04002FD1 RID: 12241
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x4002FD1")]
		[NonSerialized]
		private EventNodeBase windowCountSourceNode;

		// Token: 0x04002FD2 RID: 12242
		[FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x4002FD2")]
		[NonSerialized]
		private string windowCountSourcePort;

		// Token: 0x04002FD3 RID: 12243
		[FieldOffset(Offset = "0xD0")]
		[Token(Token = "0x4002FD3")]
		[NonSerialized]
		private EventNodeGraph cachedGraph;
	}
}
