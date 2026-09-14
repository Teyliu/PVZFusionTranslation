using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BCE RID: 3022
	[Token(Token = "0x2000BCE")]
	[Serializable]
	public class MergeMultipleChoiceOptionListsNode : EventNodeBase
	{
		// Token: 0x06003EEA RID: 16106 RVA: 0x0014D220 File Offset: 0x0014B420
		[Token(Token = "0x6003EEA")]
		[Address(RVA = "0x7F9730", Offset = "0x7F7D30", VA = "0x1807F9730", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[2];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.list1_PortName, (PortType)((uint)13), (PortDirection)num);
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			int num2;
			PortDefinition portDefinition2 = new PortDefinition(this.list2_PortName, (PortType)((uint)13), (PortDirection)num2);
			num2 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003EEB RID: 16107 RVA: 0x0014D27C File Offset: 0x0014B47C
		[Token(Token = "0x6003EEB")]
		[Address(RVA = "0x7F98A0", Offset = "0x7F7EA0", VA = "0x1807F98A0", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			PortDefinition portDefinition = new PortDefinition("合并列表", (PortType)((uint)13), (PortDirection)((uint)1));
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003EEC RID: 16108 RVA: 0x0014D2B4 File Offset: 0x0014B4B4
		[Token(Token = "0x6003EEC")]
		[Address(RVA = "0x7F9990", Offset = "0x7F7F90", VA = "0x1807F9990", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.list1_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.list1SourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.list1SourcePort = sourcePortName;
			string text2 = this.list2_PortName;
			string nodeId2 = this.nodeId;
			List<SourcePortInfo> sourceNodes2 = graph.GetSourceNodes(nodeId2, text2);
			int num3 = 0;
			EventNodeBase sourceNode2 = sourceNodes2[num3].sourceNode;
			this.list2SourceNode = sourceNode2;
			int num4 = 0;
			string sourcePortName2 = sourceNodes2[num4].sourcePortName;
			this.list2SourcePort = sourcePortName2;
		}

		// Token: 0x06003EED RID: 16109 RVA: 0x0014D364 File Offset: 0x0014B564
		[Token(Token = "0x6003EED")]
		[Address(RVA = "0x7F9500", Offset = "0x7F7B00", VA = "0x1807F9500", Slot = "6")]
		public override void Execute()
		{
			if (this.list1SourceNode != (ulong)0L)
			{
			}
			List<MultipleChoiceOptionData> list = new List();
			if (this.list2SourceNode != (ulong)0L)
			{
				list += list;
			}
			List<MultipleChoiceOptionData> list2 = new List();
			List<MultipleChoiceOptionData> list3 = new List();
			this.mergedList = list3;
			if (list != 0)
			{
				this.mergedList.AddRange(list);
			}
			if (list2 != 0)
			{
				this.mergedList.AddRange(list2);
			}
			int size = this.mergedList._size;
			EventNodeDebug.Log(string.Format("[MergeMultipleChoiceOptionListsNode] 合并列表，总数: {0}", size));
		}

		// Token: 0x06003EEE RID: 16110 RVA: 0x0014D3E8 File Offset: 0x0014B5E8
		[Token(Token = "0x6003EEE")]
		[Address(RVA = "0x9E4030", Offset = "0x9E2630", VA = "0x1809E4030", Slot = "9")]
		public override T GetPortValue<T>(string portName, [Optional] T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003EEF RID: 16111 RVA: 0x0014D428 File Offset: 0x0014B628
		[Token(Token = "0x6003EEF")]
		[Address(RVA = "0x7F9AE0", Offset = "0x7F80E0", VA = "0x1807F9AE0")]
		public MergeMultipleChoiceOptionListsNode()
		{
			List<MultipleChoiceOptionData> list = new List();
			this.mergedList = list;
			base..ctor();
		}

		// Token: 0x04002FE9 RID: 12265
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002FE9")]
		public string list1_PortName = "列表1";

		// Token: 0x04002FEA RID: 12266
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002FEA")]
		public string list2_PortName = "列表2";

		// Token: 0x04002FEB RID: 12267
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002FEB")]
		[NonSerialized]
		private EventNodeBase list1SourceNode;

		// Token: 0x04002FEC RID: 12268
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002FEC")]
		[NonSerialized]
		private string list1SourcePort;

		// Token: 0x04002FED RID: 12269
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002FED")]
		[NonSerialized]
		private EventNodeBase list2SourceNode;

		// Token: 0x04002FEE RID: 12270
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002FEE")]
		[NonSerialized]
		private string list2SourcePort;

		// Token: 0x04002FEF RID: 12271
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002FEF")]
		private List<MultipleChoiceOptionData> mergedList;
	}
}
