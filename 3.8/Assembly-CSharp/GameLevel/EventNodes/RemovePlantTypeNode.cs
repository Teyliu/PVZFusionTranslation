using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BBE RID: 3006
	[Token(Token = "0x2000BBE")]
	[Serializable]
	public class RemovePlantTypeNode : EventNodeBase
	{
		// Token: 0x06003E94 RID: 16020 RVA: 0x0014A9CC File Offset: 0x00148BCC
		[Token(Token = "0x6003E94")]
		[Address(RVA = "0x803710", Offset = "0x801D10", VA = "0x180803710", Slot = "4")]
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

		// Token: 0x06003E95 RID: 16021 RVA: 0x0014AA28 File Offset: 0x00148C28
		[Token(Token = "0x6003E95")]
		[Address(RVA = "0x803880", Offset = "0x801E80", VA = "0x180803880", Slot = "5")]
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

		// Token: 0x06003E96 RID: 16022 RVA: 0x0014AA7C File Offset: 0x00148C7C
		[Token(Token = "0x6003E96")]
		[Address(RVA = "0x8039F0", Offset = "0x801FF0", VA = "0x1808039F0", Slot = "7")]
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

		// Token: 0x06003E97 RID: 16023 RVA: 0x0014AB3C File Offset: 0x00148D3C
		[Token(Token = "0x6003E97")]
		[Address(RVA = "0xA024E0", Offset = "0xA00AE0", VA = "0x180A024E0", Slot = "9")]
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

		// Token: 0x06003E98 RID: 16024 RVA: 0x0014AC78 File Offset: 0x00148E78
		[Token(Token = "0x6003E98")]
		[Address(RVA = "0x803B80", Offset = "0x802180", VA = "0x180803B80")]
		public RemovePlantTypeNode()
		{
		}

		// Token: 0x04002F57 RID: 12119
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002F57")]
		public string list_PortName = "植物类型列表";

		// Token: 0x04002F58 RID: 12120
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002F58")]
		public string plantType_PortName = "要删除的类型";

		// Token: 0x04002F59 RID: 12121
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002F59")]
		public string resultList_PortName = "结果列表";

		// Token: 0x04002F5A RID: 12122
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002F5A")]
		public string success_PortName = "是否成功";

		// Token: 0x04002F5B RID: 12123
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002F5B")]
		[NonSerialized]
		private EventNodeBase listSourceNode;

		// Token: 0x04002F5C RID: 12124
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002F5C")]
		[NonSerialized]
		private string listSourcePort;

		// Token: 0x04002F5D RID: 12125
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002F5D")]
		[NonSerialized]
		private EventNodeBase plantTypeSourceNode;

		// Token: 0x04002F5E RID: 12126
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002F5E")]
		[NonSerialized]
		private string plantTypeSourcePort;

		// Token: 0x04002F5F RID: 12127
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002F5F")]
		[NonSerialized]
		private List<PlantType> resultList;

		// Token: 0x04002F60 RID: 12128
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002F60")]
		[NonSerialized]
		private bool lastSuccess;
	}
}
