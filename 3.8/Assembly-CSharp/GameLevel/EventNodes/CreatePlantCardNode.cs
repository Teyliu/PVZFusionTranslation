using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B70 RID: 2928
	[Token(Token = "0x2000B70")]
	[Serializable]
	public class CreatePlantCardNode : EventNodeBase
	{
		// Token: 0x06003D04 RID: 15620 RVA: 0x00141DDC File Offset: 0x0013FFDC
		[Token(Token = "0x6003D04")]
		[Address(RVA = "0x7C0A40", Offset = "0x7BF040", VA = "0x1807C0A40", Slot = "4")]
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

		// Token: 0x06003D05 RID: 15621 RVA: 0x00141E80 File Offset: 0x00140080
		[Token(Token = "0x6003D05")]
		[Address(RVA = "0x7C0C90", Offset = "0x7BF290", VA = "0x1807C0C90", Slot = "5")]
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

		// Token: 0x06003D06 RID: 15622 RVA: 0x00141ED8 File Offset: 0x001400D8
		[Token(Token = "0x6003D06")]
		[Address(RVA = "0x7C0E00", Offset = "0x7BF400", VA = "0x1807C0E00", Slot = "7")]
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

		// Token: 0x06003D07 RID: 15623 RVA: 0x00141FFC File Offset: 0x001401FC
		[Token(Token = "0x6003D07")]
		[Address(RVA = "0x7C0780", Offset = "0x7BED80", VA = "0x1807C0780", Slot = "6")]
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

		// Token: 0x06003D08 RID: 15624 RVA: 0x00142088 File Offset: 0x00140288
		[Token(Token = "0x6003D08")]
		[Address(RVA = "0x9418A0", Offset = "0x93FEA0", VA = "0x1809418A0", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003D09 RID: 15625 RVA: 0x001420C4 File Offset: 0x001402C4
		[Token(Token = "0x6003D09")]
		[Address(RVA = "0x7C1000", Offset = "0x7BF600", VA = "0x1807C1000")]
		public CreatePlantCardNode()
		{
			List<EventNodeBase> list = new List();
			this.onCreatedTargets = list;
			this.createdPlantType = (PlantType)((ulong)4294967295L);
			base..ctor();
		}

		// Token: 0x04002D81 RID: 11649
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002D81")]
		public string trigger_PortName = "触发";

		// Token: 0x04002D82 RID: 11650
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002D82")]
		public string column_PortName = "列";

		// Token: 0x04002D83 RID: 11651
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002D83")]
		public string row_PortName = "行";

		// Token: 0x04002D84 RID: 11652
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002D84")]
		public string plantType_PortName = "植物类型";

		// Token: 0x04002D85 RID: 11653
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002D85")]
		public string onCreated_PortName = "创建成功";

		// Token: 0x04002D86 RID: 11654
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002D86")]
		public string outPlantType_PortName = "植物类型";

		// Token: 0x04002D87 RID: 11655
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002D87")]
		[NonSerialized]
		private EventNodeBase columnSourceNode;

		// Token: 0x04002D88 RID: 11656
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002D88")]
		[NonSerialized]
		private string columnSourcePort;

		// Token: 0x04002D89 RID: 11657
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002D89")]
		[NonSerialized]
		private EventNodeBase rowSourceNode;

		// Token: 0x04002D8A RID: 11658
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002D8A")]
		[NonSerialized]
		private string rowSourcePort;

		// Token: 0x04002D8B RID: 11659
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4002D8B")]
		[NonSerialized]
		private EventNodeBase plantTypeSourceNode;

		// Token: 0x04002D8C RID: 11660
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4002D8C")]
		[NonSerialized]
		private string plantTypeSourcePort;

		// Token: 0x04002D8D RID: 11661
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4002D8D")]
		[NonSerialized]
		private List<EventNodeBase> onCreatedTargets;

		// Token: 0x04002D8E RID: 11662
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4002D8E")]
		[NonSerialized]
		private PlantType createdPlantType;
	}
}
