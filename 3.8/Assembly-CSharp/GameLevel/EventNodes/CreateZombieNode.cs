using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B6B RID: 2923
	[Token(Token = "0x2000B6B")]
	[Serializable]
	public class CreateZombieNode : EventNodeBase
	{
		// Token: 0x06003CE7 RID: 15591 RVA: 0x00140E78 File Offset: 0x0013F078
		[Token(Token = "0x6003CE7")]
		[Address(RVA = "0x7C1DB0", Offset = "0x7C03B0", VA = "0x1807C1DB0", Slot = "4")]
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
			PortDefinition portDefinition2 = new PortDefinition(this.zombieType_PortName, (PortType)((uint)10), (PortDirection)num3);
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
			PortDefinition portDefinition5 = new PortDefinition(this.isMindControlled_PortName, (PortType)((uint)6), (PortDirection)num6);
			num6 = 0;
			if (portDefinition5 != 0)
			{
			}
			array[4] = portDefinition5;
			return array;
		}

		// Token: 0x06003CE8 RID: 15592 RVA: 0x00140F40 File Offset: 0x0013F140
		[Token(Token = "0x6003CE8")]
		[Address(RVA = "0x7C2080", Offset = "0x7C0680", VA = "0x1807C2080", Slot = "5")]
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
			PortDefinition portDefinition2 = new PortDefinition(this.zombie_PortName, (PortType)((uint)12), (PortDirection)((uint)1));
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003CE9 RID: 15593 RVA: 0x00140F98 File Offset: 0x0013F198
		[Token(Token = "0x6003CE9")]
		[Address(RVA = "0x7C21F0", Offset = "0x7C07F0", VA = "0x1807C21F0", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.row_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.rowSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.rowSourcePort = sourcePortName;
			string text2 = this.zombieType_PortName;
			string nodeId2 = this.nodeId;
			List<SourcePortInfo> sourceNodes2 = graph.GetSourceNodes(nodeId2, text2);
			int num3 = 0;
			EventNodeBase sourceNode2 = sourceNodes2[num3].sourceNode;
			this.zombieTypeSourceNode = sourceNode2;
			int num4 = 0;
			string sourcePortName2 = sourceNodes2[num4].sourcePortName;
			this.zombieTypeSourcePort = sourcePortName2;
			string text3 = this.isMindControlled_PortName;
			string nodeId3 = this.nodeId;
			List<SourcePortInfo> sourceNodes3 = graph.GetSourceNodes(nodeId3, text3);
			int num5 = 0;
			EventNodeBase sourceNode3 = sourceNodes3[num5].sourceNode;
			this.isMindControlledSourceNode = sourceNode3;
			int num6 = 0;
			string sourcePortName3 = sourceNodes3[num6].sourcePortName;
			this.isMindControlledSourcePort = sourcePortName3;
			string text4 = this.column_PortName;
			string nodeId4 = this.nodeId;
			List<SourcePortInfo> sourceNodes4 = graph.GetSourceNodes(nodeId4, text4);
			int num7 = 0;
			EventNodeBase sourceNode4 = sourceNodes4[num7].sourceNode;
			this.columnSourceNode = sourceNode4;
			int num8 = 0;
			string sourcePortName4 = sourceNodes4[num8].sourcePortName;
			this.columnSourcePort = sourcePortName4;
			string text5 = this.onCreated_PortName;
			string nodeId5 = this.nodeId;
			List<EventNodeBase> connectedNodes = graph.GetConnectedNodes(nodeId5, text5);
			this.onCreatedTargets = connectedNodes;
			throw new NullReferenceException();
		}

		// Token: 0x06003CEA RID: 15594 RVA: 0x00141110 File Offset: 0x0013F310
		[Token(Token = "0x6003CEA")]
		[Address(RVA = "0x941F30", Offset = "0x940530", VA = "0x180941F30", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003CEB RID: 15595 RVA: 0x00141158 File Offset: 0x0013F358
		[Token(Token = "0x6003CEB")]
		[Address(RVA = "0x7C17D0", Offset = "0x7BFDD0", VA = "0x1807C17D0", Slot = "6")]
		public override void Execute()
		{
			int num2;
			ZombieType zombieType;
			do
			{
				int num = 0;
				if (this.rowSourceNode != num)
				{
					num += 20;
					num += num;
				}
				num2 = 0;
				if (this.zombieTypeSourceNode != (ulong)0L)
				{
					num += 20;
					num += num;
				}
				if (this.isMindControlledSourceNode != (ulong)0L)
				{
					num += 20;
					num += num;
				}
				if (this.columnSourceNode != (ulong)0L)
				{
					num += 20;
					num += num;
				}
				float boxXFromColumn = Mouse.Instance.GetBoxXFromColumn(num2);
				if (num2 == 0)
				{
					ulong num3;
					Zombie zombie = CreateZombie.Instance.SetZombie(num2, (ZombieType)num2, boxXFromColumn, num3 != 0UL);
					this.createdZombie = zombie;
				}
				ulong num4;
				Zombie zombie2 = CreateZombie.Instance.SetZombieWithMindControl(num2, (ZombieType)num2, boxXFromColumn, num4 != 0UL);
				this.createdZombie = zombie2;
				int num5;
				int num6;
				EventNodeDebug.Log(string.Format("[CreateZombieNode] 在行 {0}，列 {1} 创建了魅惑僵尸：{2}", num5, num6, zombieType));
				Zombie zombie3 = this.createdZombie;
				int num7 = 0;
				if (!(zombie3 != num7))
				{
					break;
				}
				List<EventNodeBase> list = this.onCreatedTargets;
				bool flag;
				if (flag)
				{
				}
			}
			while (num2 != 0);
			ZombieType zombieType2;
			int num8;
			EventNodeDebug.LogWarning(string.Format("[CreateZombieNode] 创建僵尸失败，类型：{0}，行：{1}，节点ID: {2}", zombieType2, num8, zombieType));
		}

		// Token: 0x06003CEC RID: 15596 RVA: 0x0014125C File Offset: 0x0013F45C
		[Token(Token = "0x6003CEC")]
		[Address(RVA = "0x7C2480", Offset = "0x7C0A80", VA = "0x1807C2480")]
		public CreateZombieNode()
		{
			List<EventNodeBase> list = new List();
			this.onCreatedTargets = list;
			base..ctor();
		}

		// Token: 0x04002D45 RID: 11589
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002D45")]
		public string trigger_PortName = "触发";

		// Token: 0x04002D46 RID: 11590
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002D46")]
		public string row_PortName = "行";

		// Token: 0x04002D47 RID: 11591
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002D47")]
		public string zombieType_PortName = "僵尸类型";

		// Token: 0x04002D48 RID: 11592
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002D48")]
		public string isMindControlled_PortName = "是否魅惑";

		// Token: 0x04002D49 RID: 11593
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002D49")]
		public string column_PortName = "列";

		// Token: 0x04002D4A RID: 11594
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002D4A")]
		public string onCreated_PortName = "创建成功";

		// Token: 0x04002D4B RID: 11595
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002D4B")]
		public string zombie_PortName = "僵尸";

		// Token: 0x04002D4C RID: 11596
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002D4C")]
		[NonSerialized]
		private EventNodeBase rowSourceNode;

		// Token: 0x04002D4D RID: 11597
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002D4D")]
		[NonSerialized]
		private string rowSourcePort;

		// Token: 0x04002D4E RID: 11598
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002D4E")]
		[NonSerialized]
		private EventNodeBase zombieTypeSourceNode;

		// Token: 0x04002D4F RID: 11599
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4002D4F")]
		[NonSerialized]
		private string zombieTypeSourcePort;

		// Token: 0x04002D50 RID: 11600
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4002D50")]
		[NonSerialized]
		private EventNodeBase isMindControlledSourceNode;

		// Token: 0x04002D51 RID: 11601
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4002D51")]
		[NonSerialized]
		private string isMindControlledSourcePort;

		// Token: 0x04002D52 RID: 11602
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4002D52")]
		[NonSerialized]
		private EventNodeBase columnSourceNode;

		// Token: 0x04002D53 RID: 11603
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4002D53")]
		[NonSerialized]
		private string columnSourcePort;

		// Token: 0x04002D54 RID: 11604
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x4002D54")]
		[NonSerialized]
		private List<EventNodeBase> onCreatedTargets;

		// Token: 0x04002D55 RID: 11605
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x4002D55")]
		private Zombie createdZombie;
	}
}
