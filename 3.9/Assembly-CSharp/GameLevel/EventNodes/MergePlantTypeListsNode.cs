using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BFE RID: 3070
	[Token(Token = "0x2000BFE")]
	[Serializable]
	public class MergePlantTypeListsNode : EventNodeBase
	{
		// Token: 0x06003FDB RID: 16347 RVA: 0x0014F828 File Offset: 0x0014DA28
		[Token(Token = "0x6003FDB")]
		[Address(RVA = "0x861560", Offset = "0x85FB60", VA = "0x180861560", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[2];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.listA_PortName, (PortType)((uint)16), (PortDirection)num);
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			int num2;
			PortDefinition portDefinition2 = new PortDefinition(this.listB_PortName, (PortType)((uint)16), (PortDirection)num2);
			num2 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003FDC RID: 16348 RVA: 0x0014F884 File Offset: 0x0014DA84
		[Token(Token = "0x6003FDC")]
		[Address(RVA = "0x8616D0", Offset = "0x85FCD0", VA = "0x1808616D0", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[2];
			PortDefinition portDefinition = new PortDefinition(this.mergedList_PortName, (PortType)((uint)16), (PortDirection)((uint)1));
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			PortDefinition portDefinition2 = new PortDefinition(this.count_PortName, (PortType)((uint)1), (PortDirection)((uint)1));
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003FDD RID: 16349 RVA: 0x0014F8D8 File Offset: 0x0014DAD8
		[Token(Token = "0x6003FDD")]
		[Address(RVA = "0x861840", Offset = "0x85FE40", VA = "0x180861840", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.listA_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.listASourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.listASourcePort = sourcePortName;
			string text2 = this.listB_PortName;
			string nodeId2 = this.nodeId;
			List<SourcePortInfo> sourceNodes2 = graph.GetSourceNodes(nodeId2, text2);
			int num3 = 0;
			EventNodeBase sourceNode2 = sourceNodes2[num3].sourceNode;
			this.listBSourceNode = sourceNode2;
			int num4 = 0;
			string sourcePortName2 = sourceNodes2[num4].sourcePortName;
			this.listBSourcePort = sourcePortName2;
			List<PlantType> list = new List();
			this.mergedList = list;
			throw new NullReferenceException();
		}

		// Token: 0x06003FDE RID: 16350 RVA: 0x0014F998 File Offset: 0x0014DB98
		[Token(Token = "0x6003FDE")]
		[Address(RVA = "0xA95DE0", Offset = "0xA943E0", VA = "0x180A95DE0", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			if (this.listASourceNode != (ulong)0L)
			{
			}
			int num = 0;
			if (this.listBSourceNode != (ulong)0L)
			{
			}
			int num2 = 0;
			this.mergedList._size = (int)((ulong)0L);
			if (num != 0)
			{
				this.mergedList.AddRange(num);
			}
			if (num2 != 0)
			{
				this.mergedList.AddRange(num2);
			}
			if (num != 0)
			{
			}
			if (num2 != 0)
			{
			}
			int size = this.mergedList._size;
			int num3;
			int num4;
			EventNodeDebug.Log(string.Format("[MergePlantTypeListsNode] 合并植物类型列表，列表A数量: {0}，列表B数量: {1}，合并后数量: {2}", num3, num4, num4));
			string text = this.mergedList_PortName;
			if (!string.Equals(portName, text))
			{
				string text2 = this.count_PortName;
				if (!string.Equals(portName, text2))
				{
				}
				int size2 = this.mergedList._size;
			}
			List<PlantType> list = this.mergedList;
			throw new NullReferenceException();
		}

		// Token: 0x06003FDF RID: 16351 RVA: 0x0014FA78 File Offset: 0x0014DC78
		[Token(Token = "0x6003FDF")]
		[Address(RVA = "0x8619D0", Offset = "0x85FFD0", VA = "0x1808619D0")]
		public MergePlantTypeListsNode()
		{
		}

		// Token: 0x040030BE RID: 12478
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40030BE")]
		public string listA_PortName = "列表A";

		// Token: 0x040030BF RID: 12479
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40030BF")]
		public string listB_PortName = "列表B";

		// Token: 0x040030C0 RID: 12480
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40030C0")]
		public string mergedList_PortName = "合并列表";

		// Token: 0x040030C1 RID: 12481
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40030C1")]
		public string count_PortName = "列表长度";

		// Token: 0x040030C2 RID: 12482
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40030C2")]
		[NonSerialized]
		private EventNodeBase listASourceNode;

		// Token: 0x040030C3 RID: 12483
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40030C3")]
		[NonSerialized]
		private string listASourcePort;

		// Token: 0x040030C4 RID: 12484
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40030C4")]
		[NonSerialized]
		private EventNodeBase listBSourceNode;

		// Token: 0x040030C5 RID: 12485
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x40030C5")]
		[NonSerialized]
		private string listBSourcePort;

		// Token: 0x040030C6 RID: 12486
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x40030C6")]
		[NonSerialized]
		private List<PlantType> mergedList;
	}
}
