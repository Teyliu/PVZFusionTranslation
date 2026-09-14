using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine.Events;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BCD RID: 3021
	[Token(Token = "0x2000BCD")]
	[Serializable]
	public class AddMultipleChoiceOptionNode : EventNodeBase
	{
		// Token: 0x06003EE3 RID: 16099 RVA: 0x0014CD60 File Offset: 0x0014AF60
		[Token(Token = "0x6003EE3")]
		[Address(RVA = "0x7EC830", Offset = "0x7EAE30", VA = "0x1807EC830", Slot = "4")]
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

		// Token: 0x06003EE4 RID: 16100 RVA: 0x0014CE28 File Offset: 0x0014B028
		[Token(Token = "0x6003EE4")]
		[Address(RVA = "0x7ECB00", Offset = "0x7EB100", VA = "0x1807ECB00", Slot = "5")]
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

		// Token: 0x06003EE5 RID: 16101 RVA: 0x0014CE80 File Offset: 0x0014B080
		[Token(Token = "0x6003EE5")]
		[Address(RVA = "0x7ECC70", Offset = "0x7EB270", VA = "0x1807ECC70", Slot = "7")]
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

		// Token: 0x06003EE6 RID: 16102 RVA: 0x0014D02C File Offset: 0x0014B22C
		[Token(Token = "0x6003EE6")]
		[Address(RVA = "0x8B68D0", Offset = "0x8B4ED0", VA = "0x1808B68D0", Slot = "9")]
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

		// Token: 0x06003EE7 RID: 16103 RVA: 0x0014D118 File Offset: 0x0014B318
		[Token(Token = "0x6003EE7")]
		[Address(RVA = "0x7ECF80", Offset = "0x7EB580", VA = "0x1807ECF80")]
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

		// Token: 0x06003EE8 RID: 16104 RVA: 0x0014D184 File Offset: 0x0014B384
		[Token(Token = "0x6003EE8")]
		[Address(RVA = "0x7ED170", Offset = "0x7EB770", VA = "0x1807ED170")]
		public AddMultipleChoiceOptionNode()
		{
		}

		// Token: 0x04002FD4 RID: 12244
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002FD4")]
		public string title = "选项";

		// Token: 0x04002FD5 RID: 12245
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002FD5")]
		public string description = "选项描述";

		// Token: 0x04002FD6 RID: 12246
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002FD6")]
		public PlantType plantType = (PlantType)((ulong)254L);

		// Token: 0x04002FD7 RID: 12247
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Token(Token = "0x4002FD7")]
		public ZombieType zombieType = (ZombieType)((ulong)4294967295L);

		// Token: 0x04002FD8 RID: 12248
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002FD8")]
		public string list_PortName = "选项列表";

		// Token: 0x04002FD9 RID: 12249
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002FD9")]
		public string title_PortName = "标题";

		// Token: 0x04002FDA RID: 12250
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002FDA")]
		public string description_PortName = "描述";

		// Token: 0x04002FDB RID: 12251
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002FDB")]
		public string plantType_PortName = "植物类型";

		// Token: 0x04002FDC RID: 12252
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002FDC")]
		public string zombieType_PortName = "僵尸类型";

		// Token: 0x04002FDD RID: 12253
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002FDD")]
		public string optionSelected_PortName = "选项被点击";

		// Token: 0x04002FDE RID: 12254
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002FDE")]
		[NonSerialized]
		private EventNodeBase listSourceNode;

		// Token: 0x04002FDF RID: 12255
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4002FDF")]
		[NonSerialized]
		private string listSourcePort;

		// Token: 0x04002FE0 RID: 12256
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4002FE0")]
		[NonSerialized]
		private EventNodeBase titleSourceNode;

		// Token: 0x04002FE1 RID: 12257
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4002FE1")]
		[NonSerialized]
		private string titleSourcePort;

		// Token: 0x04002FE2 RID: 12258
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4002FE2")]
		[NonSerialized]
		private EventNodeBase descriptionSourceNode;

		// Token: 0x04002FE3 RID: 12259
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4002FE3")]
		[NonSerialized]
		private string descriptionSourcePort;

		// Token: 0x04002FE4 RID: 12260
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x4002FE4")]
		[NonSerialized]
		private EventNodeBase plantTypeSourceNode;

		// Token: 0x04002FE5 RID: 12261
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x4002FE5")]
		[NonSerialized]
		private string plantTypeSourcePort;

		// Token: 0x04002FE6 RID: 12262
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x4002FE6")]
		[NonSerialized]
		private EventNodeBase zombieTypeSourceNode;

		// Token: 0x04002FE7 RID: 12263
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x4002FE7")]
		[NonSerialized]
		private string zombieTypeSourcePort;

		// Token: 0x04002FE8 RID: 12264
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x4002FE8")]
		[NonSerialized]
		private EventNodeGraph cachedGraph;
	}
}
