using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BB2 RID: 2994
	[Token(Token = "0x2000BB2")]
	[Serializable]
	public class CreatePlantCardNode : EventNodeBase
	{
		// Token: 0x06003E55 RID: 15957 RVA: 0x00147070 File Offset: 0x00145270
		[Token(Token = "0x6003E55")]
		[Address(RVA = "0x83CDA0", Offset = "0x83B3A0", VA = "0x18083CDA0", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[4];
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
			PortDefinition portDefinition2 = new PortDefinition(this.row_PortName, (PortType)((uint)1), (PortDirection)num3);
			num3 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			int num4;
			PortDefinition portDefinition3 = new PortDefinition(this.column_PortName, (PortType)((uint)1), (PortDirection)num4);
			num4 = 0;
			if (portDefinition3 != 0)
			{
			}
			array[2] = portDefinition3;
			int num5;
			PortDefinition portDefinition4 = new PortDefinition(this.plantType_PortName, (PortType)((uint)9), (PortDirection)num5);
			num5 = 0;
			if (portDefinition4 != 0)
			{
			}
			array[3] = portDefinition4;
			return array;
		}

		// Token: 0x06003E56 RID: 15958 RVA: 0x00147114 File Offset: 0x00145314
		[Token(Token = "0x6003E56")]
		[Address(RVA = "0x83CFF0", Offset = "0x83B5F0", VA = "0x18083CFF0", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[2];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.onCreated_PortName, (PortType)num, (PortDirection)((uint)1));
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			PortDefinition portDefinition2 = new PortDefinition(this.outPlantType_PortName, (PortType)((uint)9), (PortDirection)((uint)1));
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003E57 RID: 15959 RVA: 0x0014716C File Offset: 0x0014536C
		[Token(Token = "0x6003E57")]
		[Address(RVA = "0x83D160", Offset = "0x83B760", VA = "0x18083D160", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.column_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.columnSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.columnSourcePort = sourcePortName;
			string text2 = this.row_PortName;
			string nodeId2 = this.nodeId;
			List<SourcePortInfo> sourceNodes2 = graph.GetSourceNodes(nodeId2, text2);
			int num3 = 0;
			EventNodeBase sourceNode2 = sourceNodes2[num3].sourceNode;
			this.rowSourceNode = sourceNode2;
			int num4 = 0;
			string sourcePortName2 = sourceNodes2[num4].sourcePortName;
			this.rowSourcePort = sourcePortName2;
			string text3 = this.plantType_PortName;
			string nodeId3 = this.nodeId;
			List<SourcePortInfo> sourceNodes3 = graph.GetSourceNodes(nodeId3, text3);
			int num5 = 0;
			EventNodeBase sourceNode3 = sourceNodes3[num5].sourceNode;
			this.plantTypeSourceNode = sourceNode3;
			int num6 = 0;
			string sourcePortName3 = sourceNodes3[num6].sourcePortName;
			this.plantTypeSourcePort = sourcePortName3;
			string text4 = this.onCreated_PortName;
			string nodeId4 = this.nodeId;
			List<EventNodeBase> connectedNodes = graph.GetConnectedNodes(nodeId4, text4);
			this.onCreatedTargets = connectedNodes;
			throw new NullReferenceException();
		}

		// Token: 0x06003E58 RID: 15960 RVA: 0x00147290 File Offset: 0x00145490
		[Token(Token = "0x6003E58")]
		[Address(RVA = "0x83CAE0", Offset = "0x83B0E0", VA = "0x18083CAE0", Slot = "6")]
		public override void Execute()
		{
			ulong num5;
			do
			{
				int num = 0;
				if (this.columnSourceNode != num)
				{
					num += 20;
					num += num;
				}
				int num2 = 0;
				if (this.rowSourceNode != (ulong)0L)
				{
					num += 20;
					num += num;
				}
				int num3 = 0;
				if (this.plantTypeSourceNode != (ulong)0L)
				{
					num += 20;
					num += num;
				}
				int num4 = 0;
				float boxXFromColumn = Lawnf.GetBoxXFromColumn(num2);
				float landY = Mouse.Instance.GetLandY(boxXFromColumn, num3);
				this.createdPlantType = (PlantType)num4;
				List<EventNodeBase> list = this.onCreatedTargets;
				bool flag;
				if (flag)
				{
				}
			}
			while (num5 != (ulong)0L);
		}

		// Token: 0x06003E59 RID: 15961 RVA: 0x0014731C File Offset: 0x0014551C
		[Token(Token = "0x6003E59")]
		[Address(RVA = "0xA00420", Offset = "0x9FEA20", VA = "0x180A00420", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003E5A RID: 15962 RVA: 0x00147358 File Offset: 0x00145558
		[Token(Token = "0x6003E5A")]
		[Address(RVA = "0x83D360", Offset = "0x83B960", VA = "0x18083D360")]
		public CreatePlantCardNode()
		{
			List<EventNodeBase> list = new List();
			this.onCreatedTargets = list;
			this.createdPlantType = (PlantType)((ulong)4294967295L);
			base..ctor();
		}

		// Token: 0x04002EF5 RID: 12021
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002EF5")]
		public string trigger_PortName = "触发";

		// Token: 0x04002EF6 RID: 12022
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002EF6")]
		public string column_PortName = "列";

		// Token: 0x04002EF7 RID: 12023
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002EF7")]
		public string row_PortName = "行";

		// Token: 0x04002EF8 RID: 12024
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002EF8")]
		public string plantType_PortName = "植物类型";

		// Token: 0x04002EF9 RID: 12025
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002EF9")]
		public string onCreated_PortName = "创建成功";

		// Token: 0x04002EFA RID: 12026
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002EFA")]
		public string outPlantType_PortName = "植物类型";

		// Token: 0x04002EFB RID: 12027
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002EFB")]
		[NonSerialized]
		private EventNodeBase columnSourceNode;

		// Token: 0x04002EFC RID: 12028
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002EFC")]
		[NonSerialized]
		private string columnSourcePort;

		// Token: 0x04002EFD RID: 12029
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002EFD")]
		[NonSerialized]
		private EventNodeBase rowSourceNode;

		// Token: 0x04002EFE RID: 12030
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002EFE")]
		[NonSerialized]
		private string rowSourcePort;

		// Token: 0x04002EFF RID: 12031
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4002EFF")]
		[NonSerialized]
		private EventNodeBase plantTypeSourceNode;

		// Token: 0x04002F00 RID: 12032
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4002F00")]
		[NonSerialized]
		private string plantTypeSourcePort;

		// Token: 0x04002F01 RID: 12033
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4002F01")]
		[NonSerialized]
		private List<EventNodeBase> onCreatedTargets;

		// Token: 0x04002F02 RID: 12034
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4002F02")]
		[NonSerialized]
		private PlantType createdPlantType;
	}
}
