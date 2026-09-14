using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000C00 RID: 3072
	[Token(Token = "0x2000C00")]
	[Serializable]
	public class RemovePlantTypeNode : EventNodeBase
	{
		// Token: 0x06003FE5 RID: 16357 RVA: 0x0014FC3C File Offset: 0x0014DE3C
		[Token(Token = "0x6003FE5")]
		[Address(RVA = "0x86B0C0", Offset = "0x8696C0", VA = "0x18086B0C0", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[2];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.list_PortName, (PortType)((uint)16), (PortDirection)num);
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			int num2;
			PortDefinition portDefinition2 = new PortDefinition(this.plantType_PortName, (PortType)((uint)9), (PortDirection)num2);
			num2 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003FE6 RID: 16358 RVA: 0x0014FC98 File Offset: 0x0014DE98
		[Token(Token = "0x6003FE6")]
		[Address(RVA = "0x86B230", Offset = "0x869830", VA = "0x18086B230", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[2];
			PortDefinition portDefinition = new PortDefinition(this.resultList_PortName, (PortType)((uint)16), (PortDirection)((uint)1));
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			PortDefinition portDefinition2 = new PortDefinition(this.success_PortName, (PortType)((uint)6), (PortDirection)((uint)1));
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003FE7 RID: 16359 RVA: 0x0014FCEC File Offset: 0x0014DEEC
		[Token(Token = "0x6003FE7")]
		[Address(RVA = "0x86B3A0", Offset = "0x8699A0", VA = "0x18086B3A0", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.list_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.listSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.listSourcePort = sourcePortName;
			string text2 = this.plantType_PortName;
			string nodeId2 = this.nodeId;
			List<SourcePortInfo> sourceNodes2 = graph.GetSourceNodes(nodeId2, text2);
			int num3 = 0;
			EventNodeBase sourceNode2 = sourceNodes2[num3].sourceNode;
			this.plantTypeSourceNode = sourceNode2;
			int num4 = 0;
			string sourcePortName2 = sourceNodes2[num4].sourcePortName;
			this.plantTypeSourcePort = sourcePortName2;
			List<PlantType> list = new List();
			this.resultList = list;
			throw new NullReferenceException();
		}

		// Token: 0x06003FE8 RID: 16360 RVA: 0x0014FDAC File Offset: 0x0014DFAC
		[Token(Token = "0x6003FE8")]
		[Address(RVA = "0xAB5140", Offset = "0xAB3740", VA = "0x180AB5140", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			if (this.listSourceNode != (ulong)0L)
			{
			}
			int num = 0;
			if (this.plantTypeSourceNode != (ulong)0L)
			{
			}
			if (num != 0)
			{
				this.resultList._size = (int)((ulong)0L);
				this.resultList.AddRange(num);
				List<PlantType> list = this.resultList;
				bool flag;
				this.lastSuccess = flag;
				object[] array = new object[4];
				PlantType plantType;
				if (plantType != PlantType.Peashooter)
				{
				}
				array[0] = plantType;
				if (!this.lastSuccess)
				{
				}
				if ("失败" != 0)
				{
				}
				array[1] = "失败";
				int num2;
				if (num2 != 0)
				{
				}
				array[2] = num2;
				int size = this.resultList._size;
				if (size != 0)
				{
				}
				array[3] = size;
				EventNodeDebug.Log(string.Format("[RemovePlantTypeNode] 删除 {0}，{1}，列表大小: {2} → {3}", array));
			}
			string nodeId = this.nodeId;
			string text = "[RemovePlantTypeNode] 输入列表为 null，节点ID: " + nodeId;
			EventNodeDebug.LogWarning(text);
			List<PlantType> list2 = this.resultList;
			this.lastSuccess = false;
			list2._size = (int)((ulong)0L);
			if (text == 0)
			{
				if (text == 0)
				{
				}
				bool flag2 = this.lastSuccess;
			}
			List<PlantType> list3 = this.resultList;
			throw new NullReferenceException();
		}

		// Token: 0x06003FE9 RID: 16361 RVA: 0x0014FEE8 File Offset: 0x0014E0E8
		[Token(Token = "0x6003FE9")]
		[Address(RVA = "0x86B530", Offset = "0x869B30", VA = "0x18086B530")]
		public RemovePlantTypeNode()
		{
		}

		// Token: 0x040030CB RID: 12491
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40030CB")]
		public string list_PortName = "植物类型列表";

		// Token: 0x040030CC RID: 12492
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40030CC")]
		public string plantType_PortName = "要删除的类型";

		// Token: 0x040030CD RID: 12493
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40030CD")]
		public string resultList_PortName = "结果列表";

		// Token: 0x040030CE RID: 12494
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40030CE")]
		public string success_PortName = "是否成功";

		// Token: 0x040030CF RID: 12495
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40030CF")]
		[NonSerialized]
		private EventNodeBase listSourceNode;

		// Token: 0x040030D0 RID: 12496
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40030D0")]
		[NonSerialized]
		private string listSourcePort;

		// Token: 0x040030D1 RID: 12497
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40030D1")]
		[NonSerialized]
		private EventNodeBase plantTypeSourceNode;

		// Token: 0x040030D2 RID: 12498
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x40030D2")]
		[NonSerialized]
		private string plantTypeSourcePort;

		// Token: 0x040030D3 RID: 12499
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x40030D3")]
		[NonSerialized]
		private List<PlantType> resultList;

		// Token: 0x040030D4 RID: 12500
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x40030D4")]
		[NonSerialized]
		private bool lastSuccess;
	}
}
