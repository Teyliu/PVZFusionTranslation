using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BA9 RID: 2985
	[Token(Token = "0x2000BA9")]
	[Serializable]
	public class SetPlantNode : EventNodeBase
	{
		// Token: 0x06003E21 RID: 15905 RVA: 0x001451F8 File Offset: 0x001433F8
		[Token(Token = "0x6003E21")]
		[Address(RVA = "0x84F5F0", Offset = "0x84DBF0", VA = "0x18084F5F0", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[5];
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
			int num6;
			PortDefinition portDefinition5 = new PortDefinition(this.forcePlant_PortName, (PortType)((uint)6), (PortDirection)num6);
			num6 = 0;
			if (portDefinition5 != 0)
			{
			}
			array[4] = portDefinition5;
			return array;
		}

		// Token: 0x06003E22 RID: 15906 RVA: 0x001452C0 File Offset: 0x001434C0
		[Token(Token = "0x6003E22")]
		[Address(RVA = "0x84F8C0", Offset = "0x84DEC0", VA = "0x18084F8C0", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[3];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.onCreated_PortName, (PortType)num, (PortDirection)((uint)1));
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			PortDefinition portDefinition2 = new PortDefinition(this.plant_PortName, (PortType)((uint)11), (PortDirection)((uint)1));
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			int num2;
			PortDefinition portDefinition3 = new PortDefinition(this.onCreateFailed_PortName, (PortType)num2, (PortDirection)((uint)1));
			num2 = 0;
			if (portDefinition3 != 0)
			{
			}
			array[2] = portDefinition3;
			return array;
		}

		// Token: 0x06003E23 RID: 15907 RVA: 0x0014533C File Offset: 0x0014353C
		[Token(Token = "0x6003E23")]
		[Address(RVA = "0x84FAA0", Offset = "0x84E0A0", VA = "0x18084FAA0", Slot = "7")]
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
			string text4 = this.forcePlant_PortName;
			string nodeId4 = this.nodeId;
			List<SourcePortInfo> sourceNodes4 = graph.GetSourceNodes(nodeId4, text4);
			int num7 = 0;
			EventNodeBase sourceNode4 = sourceNodes4[num7].sourceNode;
			this.forcePlantSourceNode = sourceNode4;
			int num8 = 0;
			string sourcePortName4 = sourceNodes4[num8].sourcePortName;
			this.forcePlantSourcePort = sourcePortName4;
			string text5 = this.onCreated_PortName;
			string nodeId5 = this.nodeId;
			List<EventNodeBase> connectedNodes = graph.GetConnectedNodes(nodeId5, text5);
			this.onCreatedTargets = connectedNodes;
			string text6 = this.onCreateFailed_PortName;
			string nodeId6 = this.nodeId;
			List<EventNodeBase> connectedNodes2 = graph.GetConnectedNodes(nodeId6, text6);
			this.onCreateFailedTargets = connectedNodes2;
			throw new NullReferenceException();
		}

		// Token: 0x06003E24 RID: 15908 RVA: 0x001454D8 File Offset: 0x001436D8
		[Token(Token = "0x6003E24")]
		[Address(RVA = "0xAB9FD0", Offset = "0xAB85D0", VA = "0x180AB9FD0", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003E25 RID: 15909 RVA: 0x00145520 File Offset: 0x00143720
		[Token(Token = "0x6003E25")]
		[Address(RVA = "0x84F040", Offset = "0x84D640", VA = "0x18084F040", Slot = "6")]
		public override void Execute()
		{
			int num2;
			do
			{
				int num = 0;
				if (this.columnSourceNode != num)
				{
					num += 20;
					num += num;
				}
				num2 = 0;
				if (this.rowSourceNode != (ulong)0L)
				{
					num += 20;
					num += num;
				}
				if (this.plantTypeSourceNode != (ulong)0L)
				{
					num += 20;
					num += num;
				}
				if (this.forcePlantSourceNode == (ulong)0L)
				{
				}
				num2 += 20;
				num2 += num2;
				bool flag = num2 != 0;
				CreatePlant instance = CreatePlant.Instance;
				Plant plant;
				this.createdPlant = plant;
				Plant plant2 = this.createdPlant;
				int num3 = 0;
				if (!(plant2 != num3))
				{
					List<EventNodeBase> list = this.onCreateFailedTargets;
					bool flag2;
					if (flag2)
					{
					}
					if (num2 != 0)
					{
						goto IL_00DF;
					}
					int num4;
					int num5;
					string text = string.Format("[SetPlantNode] 创建植物失败 在 ({0}, {1})", num4, num5);
				}
				List<EventNodeBase> list2 = this.onCreatedTargets;
				bool flag3;
				if (flag3)
				{
				}
			}
			while (num2 != 0);
			PlantType plantType;
			int num6;
			int num7;
			EventNodeDebug.Log(string.Format("[SetPlantNode] 成功创建植物 {0} 在 ({1}, {2})", plantType, num6, num7));
			return;
			IL_00DF:
			throw new NullReferenceException();
		}

		// Token: 0x06003E26 RID: 15910 RVA: 0x00145614 File Offset: 0x00143814
		[Token(Token = "0x6003E26")]
		[Address(RVA = "0x84FD60", Offset = "0x84E360", VA = "0x18084FD60")]
		public SetPlantNode()
		{
			List<EventNodeBase> list = new List();
			this.onCreatedTargets = list;
			List<EventNodeBase> list2 = new List();
			this.onCreateFailedTargets = list2;
			base..ctor();
		}

		// Token: 0x04002E80 RID: 11904
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002E80")]
		public string trigger_PortName = "触发";

		// Token: 0x04002E81 RID: 11905
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002E81")]
		public string column_PortName = "列";

		// Token: 0x04002E82 RID: 11906
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002E82")]
		public string row_PortName = "行";

		// Token: 0x04002E83 RID: 11907
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002E83")]
		public string plantType_PortName = "植物编号";

		// Token: 0x04002E84 RID: 11908
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002E84")]
		public string forcePlant_PortName = "强制种植";

		// Token: 0x04002E85 RID: 11909
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002E85")]
		public string onCreated_PortName = "创建成功";

		// Token: 0x04002E86 RID: 11910
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002E86")]
		public string onCreateFailed_PortName = "创建失败";

		// Token: 0x04002E87 RID: 11911
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002E87")]
		public string plant_PortName = "植物";

		// Token: 0x04002E88 RID: 11912
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002E88")]
		[NonSerialized]
		private EventNodeBase columnSourceNode;

		// Token: 0x04002E89 RID: 11913
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002E89")]
		[NonSerialized]
		private string columnSourcePort;

		// Token: 0x04002E8A RID: 11914
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4002E8A")]
		[NonSerialized]
		private EventNodeBase rowSourceNode;

		// Token: 0x04002E8B RID: 11915
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4002E8B")]
		[NonSerialized]
		private string rowSourcePort;

		// Token: 0x04002E8C RID: 11916
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4002E8C")]
		[NonSerialized]
		private EventNodeBase plantTypeSourceNode;

		// Token: 0x04002E8D RID: 11917
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4002E8D")]
		[NonSerialized]
		private string plantTypeSourcePort;

		// Token: 0x04002E8E RID: 11918
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4002E8E")]
		[NonSerialized]
		private EventNodeBase forcePlantSourceNode;

		// Token: 0x04002E8F RID: 11919
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x4002E8F")]
		[NonSerialized]
		private string forcePlantSourcePort;

		// Token: 0x04002E90 RID: 11920
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x4002E90")]
		[NonSerialized]
		private List<EventNodeBase> onCreatedTargets;

		// Token: 0x04002E91 RID: 11921
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x4002E91")]
		[NonSerialized]
		private List<EventNodeBase> onCreateFailedTargets;

		// Token: 0x04002E92 RID: 11922
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x4002E92")]
		private Plant createdPlant;
	}
}
