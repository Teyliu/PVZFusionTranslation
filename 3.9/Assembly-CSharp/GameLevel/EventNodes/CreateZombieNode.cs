using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BAD RID: 2989
	[Token(Token = "0x2000BAD")]
	[Serializable]
	public class CreateZombieNode : EventNodeBase
	{
		// Token: 0x06003E38 RID: 15928 RVA: 0x00146108 File Offset: 0x00144308
		[Token(Token = "0x6003E38")]
		[Address(RVA = "0x83E110", Offset = "0x83C710", VA = "0x18083E110", Slot = "4")]
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

		// Token: 0x06003E39 RID: 15929 RVA: 0x001461D0 File Offset: 0x001443D0
		[Token(Token = "0x6003E39")]
		[Address(RVA = "0x83E3E0", Offset = "0x83C9E0", VA = "0x18083E3E0", Slot = "5")]
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

		// Token: 0x06003E3A RID: 15930 RVA: 0x00146228 File Offset: 0x00144428
		[Token(Token = "0x6003E3A")]
		[Address(RVA = "0x83E550", Offset = "0x83CB50", VA = "0x18083E550", Slot = "7")]
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

		// Token: 0x06003E3B RID: 15931 RVA: 0x001463A0 File Offset: 0x001445A0
		[Token(Token = "0x6003E3B")]
		[Address(RVA = "0xA00AB0", Offset = "0x9FF0B0", VA = "0x180A00AB0", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003E3C RID: 15932 RVA: 0x001463E8 File Offset: 0x001445E8
		[Token(Token = "0x6003E3C")]
		[Address(RVA = "0x83DB30", Offset = "0x83C130", VA = "0x18083DB30", Slot = "6")]
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

		// Token: 0x06003E3D RID: 15933 RVA: 0x001464EC File Offset: 0x001446EC
		[Token(Token = "0x6003E3D")]
		[Address(RVA = "0x83E7E0", Offset = "0x83CDE0", VA = "0x18083E7E0")]
		public CreateZombieNode()
		{
			List<EventNodeBase> list = new List();
			this.onCreatedTargets = list;
			base..ctor();
		}

		// Token: 0x04002EB9 RID: 11961
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002EB9")]
		public string trigger_PortName = "触发";

		// Token: 0x04002EBA RID: 11962
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002EBA")]
		public string row_PortName = "行";

		// Token: 0x04002EBB RID: 11963
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002EBB")]
		public string zombieType_PortName = "僵尸类型";

		// Token: 0x04002EBC RID: 11964
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002EBC")]
		public string isMindControlled_PortName = "是否魅惑";

		// Token: 0x04002EBD RID: 11965
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002EBD")]
		public string column_PortName = "列";

		// Token: 0x04002EBE RID: 11966
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002EBE")]
		public string onCreated_PortName = "创建成功";

		// Token: 0x04002EBF RID: 11967
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002EBF")]
		public string zombie_PortName = "僵尸";

		// Token: 0x04002EC0 RID: 11968
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002EC0")]
		[NonSerialized]
		private EventNodeBase rowSourceNode;

		// Token: 0x04002EC1 RID: 11969
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002EC1")]
		[NonSerialized]
		private string rowSourcePort;

		// Token: 0x04002EC2 RID: 11970
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002EC2")]
		[NonSerialized]
		private EventNodeBase zombieTypeSourceNode;

		// Token: 0x04002EC3 RID: 11971
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4002EC3")]
		[NonSerialized]
		private string zombieTypeSourcePort;

		// Token: 0x04002EC4 RID: 11972
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4002EC4")]
		[NonSerialized]
		private EventNodeBase isMindControlledSourceNode;

		// Token: 0x04002EC5 RID: 11973
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4002EC5")]
		[NonSerialized]
		private string isMindControlledSourcePort;

		// Token: 0x04002EC6 RID: 11974
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4002EC6")]
		[NonSerialized]
		private EventNodeBase columnSourceNode;

		// Token: 0x04002EC7 RID: 11975
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4002EC7")]
		[NonSerialized]
		private string columnSourcePort;

		// Token: 0x04002EC8 RID: 11976
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x4002EC8")]
		[NonSerialized]
		private List<EventNodeBase> onCreatedTargets;

		// Token: 0x04002EC9 RID: 11977
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x4002EC9")]
		private Zombie createdZombie;
	}
}
