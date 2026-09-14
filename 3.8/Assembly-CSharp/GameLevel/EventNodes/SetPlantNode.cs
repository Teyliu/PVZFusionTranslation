using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B67 RID: 2919
	[Token(Token = "0x2000B67")]
	[Serializable]
	public class SetPlantNode : EventNodeBase
	{
		// Token: 0x06003CD0 RID: 15568 RVA: 0x0013FF68 File Offset: 0x0013E168
		[Token(Token = "0x6003CD0")]
		[Address(RVA = "0x7D3290", Offset = "0x7D1890", VA = "0x1807D3290", Slot = "4")]
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

		// Token: 0x06003CD1 RID: 15569 RVA: 0x00140030 File Offset: 0x0013E230
		[Token(Token = "0x6003CD1")]
		[Address(RVA = "0x7D3560", Offset = "0x7D1B60", VA = "0x1807D3560", Slot = "5")]
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

		// Token: 0x06003CD2 RID: 15570 RVA: 0x001400AC File Offset: 0x0013E2AC
		[Token(Token = "0x6003CD2")]
		[Address(RVA = "0x7D3740", Offset = "0x7D1D40", VA = "0x1807D3740", Slot = "7")]
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

		// Token: 0x06003CD3 RID: 15571 RVA: 0x00140248 File Offset: 0x0013E448
		[Token(Token = "0x6003CD3")]
		[Address(RVA = "0xA073E0", Offset = "0xA059E0", VA = "0x180A073E0", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003CD4 RID: 15572 RVA: 0x00140290 File Offset: 0x0013E490
		[Token(Token = "0x6003CD4")]
		[Address(RVA = "0x7D2CE0", Offset = "0x7D12E0", VA = "0x1807D2CE0", Slot = "6")]
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

		// Token: 0x06003CD5 RID: 15573 RVA: 0x00140384 File Offset: 0x0013E584
		[Token(Token = "0x6003CD5")]
		[Address(RVA = "0x7D3A00", Offset = "0x7D2000", VA = "0x1807D3A00")]
		public SetPlantNode()
		{
			List<EventNodeBase> list = new List();
			this.onCreatedTargets = list;
			List<EventNodeBase> list2 = new List();
			this.onCreateFailedTargets = list2;
			base..ctor();
		}

		// Token: 0x04002D0C RID: 11532
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002D0C")]
		public string trigger_PortName = "触发";

		// Token: 0x04002D0D RID: 11533
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002D0D")]
		public string column_PortName = "列";

		// Token: 0x04002D0E RID: 11534
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002D0E")]
		public string row_PortName = "行";

		// Token: 0x04002D0F RID: 11535
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002D0F")]
		public string plantType_PortName = "植物编号";

		// Token: 0x04002D10 RID: 11536
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002D10")]
		public string forcePlant_PortName = "强制种植";

		// Token: 0x04002D11 RID: 11537
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002D11")]
		public string onCreated_PortName = "创建成功";

		// Token: 0x04002D12 RID: 11538
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002D12")]
		public string onCreateFailed_PortName = "创建失败";

		// Token: 0x04002D13 RID: 11539
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002D13")]
		public string plant_PortName = "植物";

		// Token: 0x04002D14 RID: 11540
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002D14")]
		[NonSerialized]
		private EventNodeBase columnSourceNode;

		// Token: 0x04002D15 RID: 11541
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002D15")]
		[NonSerialized]
		private string columnSourcePort;

		// Token: 0x04002D16 RID: 11542
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4002D16")]
		[NonSerialized]
		private EventNodeBase rowSourceNode;

		// Token: 0x04002D17 RID: 11543
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4002D17")]
		[NonSerialized]
		private string rowSourcePort;

		// Token: 0x04002D18 RID: 11544
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4002D18")]
		[NonSerialized]
		private EventNodeBase plantTypeSourceNode;

		// Token: 0x04002D19 RID: 11545
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4002D19")]
		[NonSerialized]
		private string plantTypeSourcePort;

		// Token: 0x04002D1A RID: 11546
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4002D1A")]
		[NonSerialized]
		private EventNodeBase forcePlantSourceNode;

		// Token: 0x04002D1B RID: 11547
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x4002D1B")]
		[NonSerialized]
		private string forcePlantSourcePort;

		// Token: 0x04002D1C RID: 11548
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x4002D1C")]
		[NonSerialized]
		private List<EventNodeBase> onCreatedTargets;

		// Token: 0x04002D1D RID: 11549
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x4002D1D")]
		[NonSerialized]
		private List<EventNodeBase> onCreateFailedTargets;

		// Token: 0x04002D1E RID: 11550
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x4002D1E")]
		private Plant createdPlant;
	}
}
