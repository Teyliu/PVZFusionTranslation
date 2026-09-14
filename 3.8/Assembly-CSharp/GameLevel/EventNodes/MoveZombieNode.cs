using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B69 RID: 2921
	[Token(Token = "0x2000B69")]
	[Serializable]
	public class MoveZombieNode : EventNodeBase
	{
		// Token: 0x06003CDC RID: 15580 RVA: 0x001408BC File Offset: 0x0013EABC
		[Token(Token = "0x6003CDC")]
		[Address(RVA = "0x7CBD30", Offset = "0x7CA330", VA = "0x1807CBD30", Slot = "4")]
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

		// Token: 0x06003CDD RID: 15581 RVA: 0x00140960 File Offset: 0x0013EB60
		[Token(Token = "0x6003CDD")]
		[Address(RVA = "0x7CBF80", Offset = "0x7CA580", VA = "0x1807CBF80", Slot = "5")]
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

		// Token: 0x06003CDE RID: 15582 RVA: 0x001409B8 File Offset: 0x0013EBB8
		[Token(Token = "0x6003CDE")]
		[Address(RVA = "0x7CC0F0", Offset = "0x7CA6F0", VA = "0x1807CC0F0", Slot = "7")]
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

		// Token: 0x06003CDF RID: 15583 RVA: 0x00140B38 File Offset: 0x0013ED38
		[Token(Token = "0x6003CDF")]
		[Address(RVA = "0x9EAE00", Offset = "0x9E9400", VA = "0x1809EAE00", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003CE0 RID: 15584 RVA: 0x00140B80 File Offset: 0x0013ED80
		[Token(Token = "0x6003CE0")]
		[Address(RVA = "0x7CB860", Offset = "0x7C9E60", VA = "0x1807CB860", Slot = "6")]
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

		// Token: 0x06003CE1 RID: 15585 RVA: 0x00140C64 File Offset: 0x0013EE64
		[Token(Token = "0x6003CE1")]
		[Address(RVA = "0x7CC470", Offset = "0x7CAA70", VA = "0x1807CC470")]
		public MoveZombieNode()
		{
			List<EventNodeBase> list = new List();
			this.onMovedTargets = list;
			base..ctor();
		}

		// Token: 0x04002D30 RID: 11568
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002D30")]
		public string trigger_PortName = "触发";

		// Token: 0x04002D31 RID: 11569
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002D31")]
		public string zombie_PortName = "僵尸";

		// Token: 0x04002D32 RID: 11570
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002D32")]
		public string column_PortName = "目标列";

		// Token: 0x04002D33 RID: 11571
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002D33")]
		public string row_PortName = "目标行";

		// Token: 0x04002D34 RID: 11572
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002D34")]
		public string onMoved_PortName = "移动成功";

		// Token: 0x04002D35 RID: 11573
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002D35")]
		public string movedZombie_PortName = "僵尸";

		// Token: 0x04002D36 RID: 11574
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002D36")]
		[NonSerialized]
		private EventNodeBase zombieSourceNode;

		// Token: 0x04002D37 RID: 11575
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002D37")]
		[NonSerialized]
		private string zombieSourcePort;

		// Token: 0x04002D38 RID: 11576
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002D38")]
		[NonSerialized]
		private EventNodeBase columnSourceNode;

		// Token: 0x04002D39 RID: 11577
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002D39")]
		[NonSerialized]
		private string columnSourcePort;

		// Token: 0x04002D3A RID: 11578
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4002D3A")]
		[NonSerialized]
		private EventNodeBase rowSourceNode;

		// Token: 0x04002D3B RID: 11579
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4002D3B")]
		[NonSerialized]
		private string rowSourcePort;

		// Token: 0x04002D3C RID: 11580
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4002D3C")]
		[NonSerialized]
		private List<EventNodeBase> onMovedTargets;

		// Token: 0x04002D3D RID: 11581
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4002D3D")]
		private Zombie movedZombie;
	}
}
