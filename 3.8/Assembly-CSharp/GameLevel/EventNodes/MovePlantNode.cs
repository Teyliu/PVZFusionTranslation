using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B68 RID: 2920
	[Token(Token = "0x2000B68")]
	[Serializable]
	public class MovePlantNode : EventNodeBase
	{
		// Token: 0x06003CD6 RID: 15574 RVA: 0x0014040C File Offset: 0x0013E60C
		[Token(Token = "0x6003CD6")]
		[Address(RVA = "0x7CAE80", Offset = "0x7C9480", VA = "0x1807CAE80", Slot = "4")]
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
			PortDefinition portDefinition2 = new PortDefinition(this.plant_PortName, (PortType)((uint)11), (PortDirection)num3);
			num3 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			int num4;
			PortDefinition portDefinition3 = new PortDefinition(this.row_PortName, (PortType)((uint)1), (PortDirection)num4);
			num4 = 0;
			if (portDefinition3 != 0)
			{
			}
			array[2] = portDefinition3;
			int num5;
			PortDefinition portDefinition4 = new PortDefinition(this.column_PortName, (PortType)((uint)1), (PortDirection)num5);
			num5 = 0;
			if (portDefinition4 != 0)
			{
			}
			array[3] = portDefinition4;
			int num6;
			PortDefinition portDefinition5 = new PortDefinition(this.force_PortName, (PortType)((uint)6), (PortDirection)num6);
			num6 = 0;
			if (portDefinition5 != 0)
			{
			}
			array[4] = portDefinition5;
			return array;
		}

		// Token: 0x06003CD7 RID: 15575 RVA: 0x001404D4 File Offset: 0x0013E6D4
		[Token(Token = "0x6003CD7")]
		[Address(RVA = "0x7CB150", Offset = "0x7C9750", VA = "0x1807CB150", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[2];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.onMoved_PortName, (PortType)num, (PortDirection)((uint)1));
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			PortDefinition portDefinition2 = new PortDefinition(this.movedPlant_PortName, (PortType)((uint)11), (PortDirection)((uint)1));
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003CD8 RID: 15576 RVA: 0x0014052C File Offset: 0x0013E72C
		[Token(Token = "0x6003CD8")]
		[Address(RVA = "0x7CB2C0", Offset = "0x7C98C0", VA = "0x1807CB2C0", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			int num9;
			do
			{
				string text = this.plant_PortName;
				string nodeId = this.nodeId;
				List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
				int num = 0;
				EventNodeBase sourceNode = sourceNodes[num].sourceNode;
				this.plantSourceNode = sourceNode;
				int num2 = 0;
				string sourcePortName = sourceNodes[num2].sourcePortName;
				this.plantSourcePort = sourcePortName;
				string text2 = this.column_PortName;
				string nodeId2 = this.nodeId;
				List<SourcePortInfo> sourceNodes2 = graph.GetSourceNodes(nodeId2, text2);
				int num3 = 0;
				EventNodeBase sourceNode2 = sourceNodes2[num3].sourceNode;
				this.columnSourceNode = sourceNode2;
				int num4 = 0;
				string sourcePortName2 = sourceNodes2[num4].sourcePortName;
				this.columnSourcePort = sourcePortName2;
				string text3 = this.row_PortName;
				string nodeId3 = this.nodeId;
				List<SourcePortInfo> sourceNodes3 = graph.GetSourceNodes(nodeId3, text3);
				int num5 = 0;
				EventNodeBase sourceNode3 = sourceNodes3[num5].sourceNode;
				this.rowSourceNode = sourceNode3;
				int num6 = 0;
				string sourcePortName3 = sourceNodes3[num6].sourcePortName;
				this.rowSourcePort = sourcePortName3;
				string text4 = this.force_PortName;
				string nodeId4 = this.nodeId;
				List<SourcePortInfo> sourceNodes4 = graph.GetSourceNodes(nodeId4, text4);
				int num7 = 0;
				EventNodeBase sourceNode4 = sourceNodes4[num7].sourceNode;
				this.forceSourceNode = sourceNode4;
				int num8 = 0;
				string sourcePortName4 = sourceNodes4[num8].sourcePortName;
				this.forceSourcePort = sourcePortName4;
				List<EventNodeBase> list = this.onMovedTargets;
				int size = list._size;
				num9 = 0;
				list._size = num9;
				if (size > 0)
				{
				}
				string text5 = this.onMoved_PortName;
				string nodeId5 = this.nodeId;
				List<EventNodeBase> connectedNodes = graph.GetConnectedNodes(nodeId5, text5);
				bool flag;
				if (flag)
				{
					List<EventNodeBase> list2 = this.onMovedTargets;
					int num10 = list2._size + 1;
					list2._size = num10;
				}
			}
			while (num9 != 0);
		}

		// Token: 0x06003CD9 RID: 15577 RVA: 0x00140700 File Offset: 0x0013E900
		[Token(Token = "0x6003CD9")]
		[Address(RVA = "0x941F30", Offset = "0x940530", VA = "0x180941F30", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003CDA RID: 15578 RVA: 0x00140748 File Offset: 0x0013E948
		[Token(Token = "0x6003CDA")]
		[Address(RVA = "0x7CA920", Offset = "0x7C8F20", VA = "0x1807CA920", Slot = "6")]
		public override void Execute()
		{
			ulong num6;
			do
			{
				int num = 0;
				if (this.plantSourceNode != num)
				{
					num += 20;
					num += num;
				}
				int num2 = 0;
				if (this.columnSourceNode != (ulong)0L)
				{
					num += 20;
					num += num;
				}
				if (this.rowSourceNode != (ulong)0L)
				{
					num += 20;
					num += num;
				}
				int num3;
				if (this.forceSourceNode == (ulong)0L)
				{
					num3 = 0;
				}
				EventNodeBase eventNodeBase = this.forceSourceNode;
				num3 += 20;
				num3 += num3;
				bool flag = num3 != 0;
				int num4 = 0;
				if (num2 == num4)
				{
					goto IL_00D6;
				}
				CreatePlant instance = CreatePlant.Instance;
				Plant plant;
				this.movedPlant = plant;
				Plant plant2 = this.movedPlant;
				int num5 = 0;
				if (!(plant2 != num5))
				{
				}
				List<EventNodeBase> list = this.onMovedTargets;
				bool flag2;
				if (flag2)
				{
				}
			}
			while (num6 != (ulong)0L);
			PlantType plantType;
			int num7;
			EventNodeDebug.Log(string.Format("[MovePlantNode] 成功移动植物 {0} 到 ({1}, {2})", plantType, plantType, num7));
			IL_00D6:
			string nodeId = this.nodeId;
			EventNodeDebug.LogWarning("[MovePlantNode] 植物对象为 null，无法移动，节点ID: " + nodeId);
		}

		// Token: 0x06003CDB RID: 15579 RVA: 0x0014084C File Offset: 0x0013EA4C
		[Token(Token = "0x6003CDB")]
		[Address(RVA = "0x7CB6D0", Offset = "0x7C9CD0", VA = "0x1807CB6D0")]
		public MovePlantNode()
		{
			List<EventNodeBase> list = new List();
			this.onMovedTargets = list;
			base..ctor();
		}

		// Token: 0x04002D1F RID: 11551
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002D1F")]
		public string trigger_PortName = "触发";

		// Token: 0x04002D20 RID: 11552
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002D20")]
		public string plant_PortName = "植物";

		// Token: 0x04002D21 RID: 11553
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002D21")]
		public string column_PortName = "列";

		// Token: 0x04002D22 RID: 11554
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002D22")]
		public string row_PortName = "行";

		// Token: 0x04002D23 RID: 11555
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002D23")]
		public string force_PortName = "强制";

		// Token: 0x04002D24 RID: 11556
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002D24")]
		public string onMoved_PortName = "移动成功";

		// Token: 0x04002D25 RID: 11557
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002D25")]
		public string movedPlant_PortName = "植物";

		// Token: 0x04002D26 RID: 11558
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002D26")]
		[NonSerialized]
		private EventNodeBase plantSourceNode;

		// Token: 0x04002D27 RID: 11559
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002D27")]
		[NonSerialized]
		private string plantSourcePort;

		// Token: 0x04002D28 RID: 11560
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002D28")]
		[NonSerialized]
		private EventNodeBase columnSourceNode;

		// Token: 0x04002D29 RID: 11561
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4002D29")]
		[NonSerialized]
		private string columnSourcePort;

		// Token: 0x04002D2A RID: 11562
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4002D2A")]
		[NonSerialized]
		private EventNodeBase rowSourceNode;

		// Token: 0x04002D2B RID: 11563
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4002D2B")]
		[NonSerialized]
		private string rowSourcePort;

		// Token: 0x04002D2C RID: 11564
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4002D2C")]
		[NonSerialized]
		private EventNodeBase forceSourceNode;

		// Token: 0x04002D2D RID: 11565
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4002D2D")]
		[NonSerialized]
		private string forceSourcePort;

		// Token: 0x04002D2E RID: 11566
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x4002D2E")]
		[NonSerialized]
		private List<EventNodeBase> onMovedTargets;

		// Token: 0x04002D2F RID: 11567
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x4002D2F")]
		private Plant movedPlant;
	}
}
