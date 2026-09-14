using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000C10 RID: 3088
	[Token(Token = "0x2000C10")]
	[Serializable]
	public class MergeMultipleChoiceOptionListsNode : EventNodeBase
	{
		// Token: 0x0600403B RID: 16443 RVA: 0x0015248C File Offset: 0x0015068C
		[Token(Token = "0x600403B")]
		[Address(RVA = "0x861130", Offset = "0x85F730", VA = "0x180861130", Slot = "4")]
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

		// Token: 0x0600403C RID: 16444 RVA: 0x001524E8 File Offset: 0x001506E8
		[Token(Token = "0x600403C")]
		[Address(RVA = "0x8612A0", Offset = "0x85F8A0", VA = "0x1808612A0", Slot = "5")]
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

		// Token: 0x0600403D RID: 16445 RVA: 0x00152520 File Offset: 0x00150720
		[Token(Token = "0x600403D")]
		[Address(RVA = "0x861390", Offset = "0x85F990", VA = "0x180861390", Slot = "7")]
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

		// Token: 0x0600403E RID: 16446 RVA: 0x001525D0 File Offset: 0x001507D0
		[Token(Token = "0x600403E")]
		[Address(RVA = "0x8610D0", Offset = "0x85F6D0", VA = "0x1808610D0", Slot = "6")]
		public override void Execute()
		{
			EventNodeDebug.Log("[MergeMultipleChoiceOptionListsNode] Execute被调用（此节点无需Execute）");
		}

		// Token: 0x0600403F RID: 16447 RVA: 0x001525E8 File Offset: 0x001507E8
		[Token(Token = "0x600403F")]
		[Address(RVA = "0xA94AD0", Offset = "0xA930D0", VA = "0x180A94AD0", Slot = "9")]
		public override T GetPortValue<T>(string portName, [Optional] T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			if (this.list1SourceNode != (ulong)0L)
			{
				List<MultipleChoiceOptionData> list;
				list += list;
			}
			List<MultipleChoiceOptionData> list2 = new List();
			if (this.list2SourceNode != (ulong)0L)
			{
				list2 += list2;
			}
			List<MultipleChoiceOptionData> list3 = new List();
			List<MultipleChoiceOptionData> list4 = new List();
			if (list2 != 0)
			{
				list4.AddRange(list2);
			}
			if (list3 != 0)
			{
				list4.AddRange(list3);
			}
			if (list2 != 0)
			{
			}
			if (list3 != 0)
			{
			}
			int size = list4._size;
			int num;
			int num2;
			EventNodeDebug.Log(string.Format("[MergeMultipleChoiceOptionListsNode] 合并列表，list1.Count={0}, list2.Count={1}, merged.Count={2}", num, num2, num2));
			throw new NullReferenceException();
		}

		// Token: 0x06004040 RID: 16448 RVA: 0x0015268C File Offset: 0x0015088C
		[Token(Token = "0x6004040")]
		[Address(RVA = "0x8614E0", Offset = "0x85FAE0", VA = "0x1808614E0")]
		public MergeMultipleChoiceOptionListsNode()
		{
		}

		// Token: 0x0400315D RID: 12637
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400315D")]
		public string list1_PortName = "列表1";

		// Token: 0x0400315E RID: 12638
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400315E")]
		public string list2_PortName = "列表2";

		// Token: 0x0400315F RID: 12639
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400315F")]
		[NonSerialized]
		private EventNodeBase list1SourceNode;

		// Token: 0x04003160 RID: 12640
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4003160")]
		[NonSerialized]
		private string list1SourcePort;

		// Token: 0x04003161 RID: 12641
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4003161")]
		[NonSerialized]
		private EventNodeBase list2SourceNode;

		// Token: 0x04003162 RID: 12642
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4003162")]
		[NonSerialized]
		private string list2SourcePort;
	}
}
