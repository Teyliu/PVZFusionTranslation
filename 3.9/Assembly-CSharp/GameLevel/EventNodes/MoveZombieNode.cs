using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BAB RID: 2987
	[Token(Token = "0x2000BAB")]
	[Serializable]
	public class MoveZombieNode : EventNodeBase
	{
		// Token: 0x06003E2D RID: 15917 RVA: 0x00145B4C File Offset: 0x00143D4C
		[Token(Token = "0x6003E2D")]
		[Address(RVA = "0x848090", Offset = "0x846690", VA = "0x180848090", Slot = "4")]
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
			PortDefinition portDefinition2 = new PortDefinition(this.zombie_PortName, (PortType)((uint)12), (PortDirection)num3);
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
			return array;
		}

		// Token: 0x06003E2E RID: 15918 RVA: 0x00145BF0 File Offset: 0x00143DF0
		[Token(Token = "0x6003E2E")]
		[Address(RVA = "0x8482E0", Offset = "0x8468E0", VA = "0x1808482E0", Slot = "5")]
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
			PortDefinition portDefinition2 = new PortDefinition(this.movedZombie_PortName, (PortType)((uint)12), (PortDirection)((uint)1));
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003E2F RID: 15919 RVA: 0x00145C48 File Offset: 0x00143E48
		[Token(Token = "0x6003E2F")]
		[Address(RVA = "0x848450", Offset = "0x846A50", VA = "0x180848450", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			int num7;
			do
			{
				string text = this.zombie_PortName;
				string nodeId = this.nodeId;
				List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
				int num = 0;
				EventNodeBase sourceNode = sourceNodes[num].sourceNode;
				this.zombieSourceNode = sourceNode;
				int num2 = 0;
				string sourcePortName = sourceNodes[num2].sourcePortName;
				this.zombieSourcePort = sourcePortName;
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
				List<EventNodeBase> list = this.onMovedTargets;
				int size = list._size;
				num7 = 0;
				list._size = num7;
				if (size > 0)
				{
				}
				string text4 = this.onMoved_PortName;
				string nodeId4 = this.nodeId;
				List<EventNodeBase> connectedNodes = graph.GetConnectedNodes(nodeId4, text4);
				bool flag;
				if (flag)
				{
					List<EventNodeBase> list2 = this.onMovedTargets;
					int num8 = list2._size + 1;
					list2._size = num8;
				}
			}
			while (num7 != 0);
		}

		// Token: 0x06003E30 RID: 15920 RVA: 0x00145DC8 File Offset: 0x00143FC8
		[Token(Token = "0x6003E30")]
		[Address(RVA = "0xA9C640", Offset = "0xA9AC40", VA = "0x180A9C640", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003E31 RID: 15921 RVA: 0x00145E10 File Offset: 0x00144010
		[Token(Token = "0x6003E31")]
		[Address(RVA = "0x847BC0", Offset = "0x8461C0", VA = "0x180847BC0", Slot = "6")]
		public override void Execute()
		{
			bool flag;
			ulong num7;
			do
			{
				int num = 0;
				if (this.zombieSourceNode != num)
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
				int num3 = 0;
				if (this.rowSourceNode != (ulong)0L)
				{
					num += 20;
					num += num;
				}
				int num4 = 0;
				int num5 = 0;
				if (num2 == num5)
				{
					goto IL_00AF;
				}
				float boxXFromColumn = Mouse.Instance.GetBoxXFromColumn(num3);
				ulong num6;
				flag = Mouse.Instance.MoveZombie(num2, boxXFromColumn, num4, num6 != 0UL);
				this.movedZombie = num2;
				if (!flag)
				{
				}
				List<EventNodeBase> list = this.onMovedTargets;
				bool flag2;
				if (flag2)
				{
				}
			}
			while (num7 != (ulong)0L);
			bool flag3;
			flag = flag3;
			int num8;
			EventNodeDebug.Log(string.Format("[MoveZombieNode] 成功移动僵尸 {0} 到 ({1}, {2})", flag, flag3, num8));
			IL_00AF:
			string nodeId = this.nodeId;
			EventNodeDebug.LogWarning("[MoveZombieNode] 僵尸对象为 null，无法移动，节点ID: " + nodeId);
		}

		// Token: 0x06003E32 RID: 15922 RVA: 0x00145EF4 File Offset: 0x001440F4
		[Token(Token = "0x6003E32")]
		[Address(RVA = "0x8487D0", Offset = "0x846DD0", VA = "0x1808487D0")]
		public MoveZombieNode()
		{
			List<EventNodeBase> list = new List();
			this.onMovedTargets = list;
			base..ctor();
		}

		// Token: 0x04002EA4 RID: 11940
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002EA4")]
		public string trigger_PortName = "触发";

		// Token: 0x04002EA5 RID: 11941
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002EA5")]
		public string zombie_PortName = "僵尸";

		// Token: 0x04002EA6 RID: 11942
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002EA6")]
		public string column_PortName = "目标列";

		// Token: 0x04002EA7 RID: 11943
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002EA7")]
		public string row_PortName = "目标行";

		// Token: 0x04002EA8 RID: 11944
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002EA8")]
		public string onMoved_PortName = "移动成功";

		// Token: 0x04002EA9 RID: 11945
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002EA9")]
		public string movedZombie_PortName = "僵尸";

		// Token: 0x04002EAA RID: 11946
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002EAA")]
		[NonSerialized]
		private EventNodeBase zombieSourceNode;

		// Token: 0x04002EAB RID: 11947
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002EAB")]
		[NonSerialized]
		private string zombieSourcePort;

		// Token: 0x04002EAC RID: 11948
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002EAC")]
		[NonSerialized]
		private EventNodeBase columnSourceNode;

		// Token: 0x04002EAD RID: 11949
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002EAD")]
		[NonSerialized]
		private string columnSourcePort;

		// Token: 0x04002EAE RID: 11950
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4002EAE")]
		[NonSerialized]
		private EventNodeBase rowSourceNode;

		// Token: 0x04002EAF RID: 11951
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4002EAF")]
		[NonSerialized]
		private string rowSourcePort;

		// Token: 0x04002EB0 RID: 11952
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4002EB0")]
		[NonSerialized]
		private List<EventNodeBase> onMovedTargets;

		// Token: 0x04002EB1 RID: 11953
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4002EB1")]
		private Zombie movedZombie;
	}
}
