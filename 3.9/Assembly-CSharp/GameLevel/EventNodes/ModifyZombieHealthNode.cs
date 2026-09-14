using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000C08 RID: 3080
	[Token(Token = "0x2000C08")]
	[Serializable]
	public class ModifyZombieHealthNode : EventNodeBase
	{
		// Token: 0x0600400F RID: 16399 RVA: 0x00150ED0 File Offset: 0x0014F0D0
		[Token(Token = "0x600400F")]
		[Address(RVA = "0x863120", Offset = "0x861720", VA = "0x180863120", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[3];
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
			PortDefinition portDefinition3 = new PortDefinition(this.ratio_PortName, (PortType)((uint)3), (PortDirection)num4);
			num4 = 0;
			if (portDefinition3 != 0)
			{
			}
			array[2] = portDefinition3;
			return array;
		}

		// Token: 0x06004010 RID: 16400 RVA: 0x00150F50 File Offset: 0x0014F150
		[Token(Token = "0x6004010")]
		[Address(RVA = "0x863300", Offset = "0x861900", VA = "0x180863300", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[2];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.onModified_PortName, (PortType)num, (PortDirection)((uint)1));
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			PortDefinition portDefinition2 = new PortDefinition(this.zombieOut_PortName, (PortType)((uint)12), (PortDirection)((uint)1));
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06004011 RID: 16401 RVA: 0x00150FA8 File Offset: 0x0014F1A8
		[Token(Token = "0x6004011")]
		[Address(RVA = "0x863470", Offset = "0x861A70", VA = "0x180863470", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
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
			string text2 = this.ratio_PortName;
			string nodeId2 = this.nodeId;
			List<SourcePortInfo> sourceNodes2 = graph.GetSourceNodes(nodeId2, text2);
			int num3 = 0;
			EventNodeBase sourceNode2 = sourceNodes2[num3].sourceNode;
			this.ratioSourceNode = sourceNode2;
			int num4 = 0;
			string sourcePortName2 = sourceNodes2[num4].sourcePortName;
			this.ratioSourcePort = sourcePortName2;
			string text3 = this.onModified_PortName;
			string nodeId3 = this.nodeId;
			List<EventNodeBase> connectedNodes = graph.GetConnectedNodes(nodeId3, text3);
			this.onModifiedTargets = connectedNodes;
			throw new NullReferenceException();
		}

		// Token: 0x06004012 RID: 16402 RVA: 0x0015107C File Offset: 0x0014F27C
		[Token(Token = "0x6004012")]
		[Address(RVA = "0xA98F30", Offset = "0xA97530", VA = "0x180A98F30", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06004013 RID: 16403 RVA: 0x001510C4 File Offset: 0x0014F2C4
		[Token(Token = "0x6004013")]
		[Address(RVA = "0x862DB0", Offset = "0x8613B0", VA = "0x180862DB0", Slot = "6")]
		public override void Execute()
		{
			ulong num4;
			do
			{
				int num = 0;
				if (this.zombieSourceNode != 0)
				{
					num += 20;
					num += num;
				}
				this.targetZombie = num;
				if (this.ratioSourceNode != 0)
				{
					string text = this.ratioSourcePort;
					num += 20;
					num += num;
				}
				Zombie zombie = this.targetZombie;
				int num2 = 0;
				bool flag = zombie != num2;
				if (!flag)
				{
					break;
				}
				float num3;
				Lawnf.SetZombieHealth(this.targetZombie, num3);
				EventNodeDebug.Log(string.Format("[ModifyZombieHealthNode] 修改僵尸血量倍率{0}", flag));
				List<EventNodeBase> list = this.onModifiedTargets;
				bool flag2;
				if (flag2)
				{
				}
			}
			while (num4 != (ulong)0L);
			string text2;
			EventNodeDebug.LogWarning(text2);
		}

		// Token: 0x06004014 RID: 16404 RVA: 0x00151170 File Offset: 0x0014F370
		[Token(Token = "0x6004014")]
		[Address(RVA = "0x8635E0", Offset = "0x861BE0", VA = "0x1808635E0")]
		public ModifyZombieHealthNode()
		{
			List<EventNodeBase> list = new List();
			this.onModifiedTargets = list;
			base..ctor();
		}

		// Token: 0x0400310E RID: 12558
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400310E")]
		public string trigger_PortName = "触发";

		// Token: 0x0400310F RID: 12559
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400310F")]
		public string zombie_PortName = "僵尸";

		// Token: 0x04003110 RID: 12560
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4003110")]
		public string ratio_PortName = "血量倍率";

		// Token: 0x04003111 RID: 12561
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4003111")]
		public string onModified_PortName = "修改成功";

		// Token: 0x04003112 RID: 12562
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4003112")]
		public string zombieOut_PortName = "僵尸";

		// Token: 0x04003113 RID: 12563
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4003113")]
		[NonSerialized]
		private EventNodeBase zombieSourceNode;

		// Token: 0x04003114 RID: 12564
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4003114")]
		[NonSerialized]
		private string zombieSourcePort;

		// Token: 0x04003115 RID: 12565
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4003115")]
		[NonSerialized]
		private EventNodeBase ratioSourceNode;

		// Token: 0x04003116 RID: 12566
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4003116")]
		[NonSerialized]
		private string ratioSourcePort;

		// Token: 0x04003117 RID: 12567
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4003117")]
		[NonSerialized]
		private List<EventNodeBase> onModifiedTargets;

		// Token: 0x04003118 RID: 12568
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4003118")]
		private Zombie targetZombie;
	}
}
