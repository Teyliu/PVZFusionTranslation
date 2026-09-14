using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine.Events;

namespace GameLevel.EventNodes
{
	// Token: 0x02000C0F RID: 3087
	[Token(Token = "0x2000C0F")]
	[Serializable]
	public class AddMultipleChoiceOptionNode : EventNodeBase
	{
		// Token: 0x06004034 RID: 16436 RVA: 0x00151FCC File Offset: 0x001501CC
		[Token(Token = "0x6004034")]
		[Address(RVA = "0x854300", Offset = "0x852900", VA = "0x180854300", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[5];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.list_PortName, (PortType)((uint)13), (PortDirection)num);
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			int num2;
			PortDefinition portDefinition2 = new PortDefinition(this.title_PortName, (PortType)((uint)5), (PortDirection)num2);
			num2 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			int num3;
			PortDefinition portDefinition3 = new PortDefinition(this.description_PortName, (PortType)((uint)5), (PortDirection)num3);
			num3 = 0;
			if (portDefinition3 != 0)
			{
			}
			array[2] = portDefinition3;
			int num4;
			PortDefinition portDefinition4 = new PortDefinition(this.plantType_PortName, (PortType)((uint)9), (PortDirection)num4);
			num4 = 0;
			if (portDefinition4 != 0)
			{
			}
			array[3] = portDefinition4;
			int num5;
			PortDefinition portDefinition5 = new PortDefinition(this.zombieType_PortName, (PortType)((uint)10), (PortDirection)num5);
			num5 = 0;
			if (portDefinition5 != 0)
			{
			}
			array[4] = portDefinition5;
			return array;
		}

		// Token: 0x06004035 RID: 16437 RVA: 0x00152094 File Offset: 0x00150294
		[Token(Token = "0x6004035")]
		[Address(RVA = "0x8545D0", Offset = "0x852BD0", VA = "0x1808545D0", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[2];
			PortDefinition portDefinition = new PortDefinition(this.list_PortName, (PortType)((uint)13), (PortDirection)((uint)1));
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			int num;
			PortDefinition portDefinition2 = new PortDefinition(this.optionSelected_PortName, (PortType)num, (PortDirection)((uint)1));
			num = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06004036 RID: 16438 RVA: 0x001520EC File Offset: 0x001502EC
		[Token(Token = "0x6004036")]
		[Address(RVA = "0x854740", Offset = "0x852D40", VA = "0x180854740", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			this.cachedGraph = graph;
			string text = this.list_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.listSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.listSourcePort = sourcePortName;
			string text2 = this.title_PortName;
			string nodeId2 = this.nodeId;
			List<SourcePortInfo> sourceNodes2 = graph.GetSourceNodes(nodeId2, text2);
			int num3 = 0;
			EventNodeBase sourceNode2 = sourceNodes2[num3].sourceNode;
			this.titleSourceNode = sourceNode2;
			int num4 = 0;
			string sourcePortName2 = sourceNodes2[num4].sourcePortName;
			this.titleSourcePort = sourcePortName2;
			string text3 = this.description_PortName;
			string nodeId3 = this.nodeId;
			List<SourcePortInfo> sourceNodes3 = graph.GetSourceNodes(nodeId3, text3);
			int num5 = 0;
			EventNodeBase sourceNode3 = sourceNodes3[num5].sourceNode;
			this.descriptionSourceNode = sourceNode3;
			int num6 = 0;
			string sourcePortName3 = sourceNodes3[num6].sourcePortName;
			this.descriptionSourcePort = sourcePortName3;
			string text4 = this.plantType_PortName;
			string nodeId4 = this.nodeId;
			List<SourcePortInfo> sourceNodes4 = graph.GetSourceNodes(nodeId4, text4);
			int num7 = 0;
			EventNodeBase sourceNode4 = sourceNodes4[num7].sourceNode;
			this.plantTypeSourceNode = sourceNode4;
			int num8 = 0;
			string sourcePortName4 = sourceNodes4[num8].sourcePortName;
			this.plantTypeSourcePort = sourcePortName4;
			string text5 = this.zombieType_PortName;
			string nodeId5 = this.nodeId;
			List<SourcePortInfo> sourceNodes5 = graph.GetSourceNodes(nodeId5, text5);
			int num9 = 0;
			EventNodeBase sourceNode5 = sourceNodes5[num9].sourceNode;
			this.zombieTypeSourceNode = sourceNode5;
			int num10 = 0;
			string sourcePortName5 = sourceNodes5[num10].sourcePortName;
			this.zombieTypeSourcePort = sourcePortName5;
		}

		// Token: 0x06004037 RID: 16439 RVA: 0x00152298 File Offset: 0x00150498
		[Token(Token = "0x6004037")]
		[Address(RVA = "0x9568C0", Offset = "0x954EC0", VA = "0x1809568C0", Slot = "9")]
		public override T GetPortValue<T>(string portName, [Optional] T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			if (this.listSourceNode != (ulong)0L)
			{
				ZombieType zombieType;
				zombieType += (int)zombieType;
			}
			List<MultipleChoiceOptionData> list = new List();
			if (this.titleSourceNode != (ulong)0L)
			{
				list += list;
			}
			string text = this.title;
			if (this.descriptionSourceNode != (ulong)0L)
			{
				list += list;
			}
			string text2 = this.description;
			if (this.plantTypeSourceNode != (ulong)0L)
			{
				PlantType plantType = this.plantType;
			}
			PlantType plantType2 = this.plantType;
			if (this.zombieTypeSourceNode != (ulong)0L)
			{
				ZombieType zombieType2 = this.zombieType;
			}
			ZombieType zombieType3 = this.zombieType;
			List<MultipleChoiceOptionData> list2 = new List();
			if (list != 0)
			{
				list2.AddRange(list);
			}
			UnityAction unityAction;
			MultipleChoiceOptionData multipleChoiceOptionData = new MultipleChoiceOptionData(text, text2, unityAction, plantType2, zombieType3);
			int size = list2._size;
			EventNodeDebug.Log(string.Format("[AddMultipleChoiceOptionNode] 构建选项列表: {0}, 总数: {1}", text, size));
			throw new NullReferenceException();
		}

		// Token: 0x06004038 RID: 16440 RVA: 0x00152384 File Offset: 0x00150584
		[Token(Token = "0x6004038")]
		[Address(RVA = "0x854A50", Offset = "0x853050", VA = "0x180854A50")]
		private void OnOptionClicked()
		{
			ulong num;
			do
			{
				string text = this.optionSelected_PortName;
				EventNodeDebug.Log("[AddMultipleChoiceOptionNode] 选项被点击，触发输出端口: " + text);
				if (this.cachedGraph == (ulong)0L)
				{
					break;
				}
				string text2 = this.optionSelected_PortName;
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

		// Token: 0x06004039 RID: 16441 RVA: 0x001523F0 File Offset: 0x001505F0
		[Token(Token = "0x6004039")]
		[Address(RVA = "0x854C40", Offset = "0x853240", VA = "0x180854C40")]
		public AddMultipleChoiceOptionNode()
		{
		}

		// Token: 0x04003148 RID: 12616
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4003148")]
		public string title = "选项";

		// Token: 0x04003149 RID: 12617
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4003149")]
		public string description = "选项描述";

		// Token: 0x0400314A RID: 12618
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400314A")]
		public PlantType plantType = (PlantType)((ulong)254L);

		// Token: 0x0400314B RID: 12619
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Token(Token = "0x400314B")]
		public ZombieType zombieType = (ZombieType)((ulong)4294967295L);

		// Token: 0x0400314C RID: 12620
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400314C")]
		public string list_PortName = "选项列表";

		// Token: 0x0400314D RID: 12621
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400314D")]
		public string title_PortName = "标题";

		// Token: 0x0400314E RID: 12622
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Token(Token = "0x400314E")]
		public string description_PortName = "描述";

		// Token: 0x0400314F RID: 12623
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Token(Token = "0x400314F")]
		public string plantType_PortName = "植物类型";

		// Token: 0x04003150 RID: 12624
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4003150")]
		public string zombieType_PortName = "僵尸类型";

		// Token: 0x04003151 RID: 12625
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4003151")]
		public string optionSelected_PortName = "选项被点击";

		// Token: 0x04003152 RID: 12626
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4003152")]
		[NonSerialized]
		private EventNodeBase listSourceNode;

		// Token: 0x04003153 RID: 12627
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4003153")]
		[NonSerialized]
		private string listSourcePort;

		// Token: 0x04003154 RID: 12628
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4003154")]
		[NonSerialized]
		private EventNodeBase titleSourceNode;

		// Token: 0x04003155 RID: 12629
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4003155")]
		[NonSerialized]
		private string titleSourcePort;

		// Token: 0x04003156 RID: 12630
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4003156")]
		[NonSerialized]
		private EventNodeBase descriptionSourceNode;

		// Token: 0x04003157 RID: 12631
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4003157")]
		[NonSerialized]
		private string descriptionSourcePort;

		// Token: 0x04003158 RID: 12632
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x4003158")]
		[NonSerialized]
		private EventNodeBase plantTypeSourceNode;

		// Token: 0x04003159 RID: 12633
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x4003159")]
		[NonSerialized]
		private string plantTypeSourcePort;

		// Token: 0x0400315A RID: 12634
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x400315A")]
		[NonSerialized]
		private EventNodeBase zombieTypeSourceNode;

		// Token: 0x0400315B RID: 12635
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x400315B")]
		[NonSerialized]
		private string zombieTypeSourcePort;

		// Token: 0x0400315C RID: 12636
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x400315C")]
		[NonSerialized]
		private EventNodeGraph cachedGraph;
	}
}
