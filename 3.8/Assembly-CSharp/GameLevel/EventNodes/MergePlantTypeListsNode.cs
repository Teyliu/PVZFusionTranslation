using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BBC RID: 3004
	[Token(Token = "0x2000BBC")]
	[Serializable]
	public class MergePlantTypeListsNode : EventNodeBase
	{
		// Token: 0x06003E8A RID: 16010 RVA: 0x0014A5B8 File Offset: 0x001487B8
		[Token(Token = "0x6003E8A")]
		[Address(RVA = "0x7F9BB0", Offset = "0x7F81B0", VA = "0x1807F9BB0", Slot = "4")]
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

		// Token: 0x06003E8B RID: 16011 RVA: 0x0014A614 File Offset: 0x00148814
		[Token(Token = "0x6003E8B")]
		[Address(RVA = "0x7F9D20", Offset = "0x7F8320", VA = "0x1807F9D20", Slot = "5")]
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

		// Token: 0x06003E8C RID: 16012 RVA: 0x0014A668 File Offset: 0x00148868
		[Token(Token = "0x6003E8C")]
		[Address(RVA = "0x7F9E90", Offset = "0x7F8490", VA = "0x1807F9E90", Slot = "7")]
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

		// Token: 0x06003E8D RID: 16013 RVA: 0x0014A728 File Offset: 0x00148928
		[Token(Token = "0x6003E8D")]
		[Address(RVA = "0x9E4610", Offset = "0x9E2C10", VA = "0x1809E4610", Slot = "9")]
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

		// Token: 0x06003E8E RID: 16014 RVA: 0x0014A808 File Offset: 0x00148A08
		[Token(Token = "0x6003E8E")]
		[Address(RVA = "0x7FA020", Offset = "0x7F8620", VA = "0x1807FA020")]
		public MergePlantTypeListsNode()
		{
		}

		// Token: 0x04002F4A RID: 12106
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002F4A")]
		public string listA_PortName = "列表A";

		// Token: 0x04002F4B RID: 12107
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002F4B")]
		public string listB_PortName = "列表B";

		// Token: 0x04002F4C RID: 12108
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002F4C")]
		public string mergedList_PortName = "合并列表";

		// Token: 0x04002F4D RID: 12109
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002F4D")]
		public string count_PortName = "列表长度";

		// Token: 0x04002F4E RID: 12110
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002F4E")]
		[NonSerialized]
		private EventNodeBase listASourceNode;

		// Token: 0x04002F4F RID: 12111
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002F4F")]
		[NonSerialized]
		private string listASourcePort;

		// Token: 0x04002F50 RID: 12112
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002F50")]
		[NonSerialized]
		private EventNodeBase listBSourceNode;

		// Token: 0x04002F51 RID: 12113
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002F51")]
		[NonSerialized]
		private string listBSourcePort;

		// Token: 0x04002F52 RID: 12114
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002F52")]
		[NonSerialized]
		private List<PlantType> mergedList;
	}
}
