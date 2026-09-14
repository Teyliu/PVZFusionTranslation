using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BAA RID: 2986
	[Token(Token = "0x2000BAA")]
	[Serializable]
	public class MovePlantNode : EventNodeBase
	{
		// Token: 0x06003E27 RID: 15911 RVA: 0x0014569C File Offset: 0x0014389C
		[Token(Token = "0x6003E27")]
		[Address(RVA = "0x8471E0", Offset = "0x8457E0", VA = "0x1808471E0", Slot = "4")]
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

		// Token: 0x06003E28 RID: 15912 RVA: 0x00145764 File Offset: 0x00143964
		[Token(Token = "0x6003E28")]
		[Address(RVA = "0x8474B0", Offset = "0x845AB0", VA = "0x1808474B0", Slot = "5")]
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

		// Token: 0x06003E29 RID: 15913 RVA: 0x001457BC File Offset: 0x001439BC
		[Token(Token = "0x6003E29")]
		[Address(RVA = "0x847620", Offset = "0x845C20", VA = "0x180847620", Slot = "7")]
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

		// Token: 0x06003E2A RID: 15914 RVA: 0x00145990 File Offset: 0x00143B90
		[Token(Token = "0x6003E2A")]
		[Address(RVA = "0xA00AB0", Offset = "0x9FF0B0", VA = "0x180A00AB0", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003E2B RID: 15915 RVA: 0x001459D8 File Offset: 0x00143BD8
		[Token(Token = "0x6003E2B")]
		[Address(RVA = "0x846C80", Offset = "0x845280", VA = "0x180846C80", Slot = "6")]
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

		// Token: 0x06003E2C RID: 15916 RVA: 0x00145ADC File Offset: 0x00143CDC
		[Token(Token = "0x6003E2C")]
		[Address(RVA = "0x847A30", Offset = "0x846030", VA = "0x180847A30")]
		public MovePlantNode()
		{
			List<EventNodeBase> list = new List();
			this.onMovedTargets = list;
			base..ctor();
		}

		// Token: 0x04002E93 RID: 11923
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002E93")]
		public string trigger_PortName = "触发";

		// Token: 0x04002E94 RID: 11924
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002E94")]
		public string plant_PortName = "植物";

		// Token: 0x04002E95 RID: 11925
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002E95")]
		public string column_PortName = "列";

		// Token: 0x04002E96 RID: 11926
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002E96")]
		public string row_PortName = "行";

		// Token: 0x04002E97 RID: 11927
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002E97")]
		public string force_PortName = "强制";

		// Token: 0x04002E98 RID: 11928
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002E98")]
		public string onMoved_PortName = "移动成功";

		// Token: 0x04002E99 RID: 11929
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002E99")]
		public string movedPlant_PortName = "植物";

		// Token: 0x04002E9A RID: 11930
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002E9A")]
		[NonSerialized]
		private EventNodeBase plantSourceNode;

		// Token: 0x04002E9B RID: 11931
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002E9B")]
		[NonSerialized]
		private string plantSourcePort;

		// Token: 0x04002E9C RID: 11932
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002E9C")]
		[NonSerialized]
		private EventNodeBase columnSourceNode;

		// Token: 0x04002E9D RID: 11933
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4002E9D")]
		[NonSerialized]
		private string columnSourcePort;

		// Token: 0x04002E9E RID: 11934
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4002E9E")]
		[NonSerialized]
		private EventNodeBase rowSourceNode;

		// Token: 0x04002E9F RID: 11935
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4002E9F")]
		[NonSerialized]
		private string rowSourcePort;

		// Token: 0x04002EA0 RID: 11936
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4002EA0")]
		[NonSerialized]
		private EventNodeBase forceSourceNode;

		// Token: 0x04002EA1 RID: 11937
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4002EA1")]
		[NonSerialized]
		private string forceSourcePort;

		// Token: 0x04002EA2 RID: 11938
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x4002EA2")]
		[NonSerialized]
		private List<EventNodeBase> onMovedTargets;

		// Token: 0x04002EA3 RID: 11939
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x4002EA3")]
		private Plant movedPlant;
	}
}
