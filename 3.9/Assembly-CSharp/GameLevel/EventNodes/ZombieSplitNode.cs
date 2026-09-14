using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000C0A RID: 3082
	[Token(Token = "0x2000C0A")]
	[Serializable]
	public class ZombieSplitNode : EventNodeBase
	{
		// Token: 0x0600401A RID: 16410 RVA: 0x001513FC File Offset: 0x0014F5FC
		[Token(Token = "0x600401A")]
		[Address(RVA = "0x872970", Offset = "0x870F70", VA = "0x180872970", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.zombie_PortName, (PortType)((uint)12), (PortDirection)num);
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x0600401B RID: 16411 RVA: 0x00151438 File Offset: 0x0014F638
		[Token(Token = "0x600401B")]
		[Address(RVA = "0x872A60", Offset = "0x871060", VA = "0x180872A60", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[4];
			PortDefinition portDefinition = new PortDefinition(this.row_PortName, (PortType)((uint)1), (PortDirection)((uint)1));
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			PortDefinition portDefinition2 = new PortDefinition(this.column_PortName, (PortType)((uint)1), (PortDirection)((uint)1));
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			PortDefinition portDefinition3 = new PortDefinition(this.zombieType_PortName, (PortType)((uint)10), (PortDirection)((uint)1));
			if (portDefinition3 != 0)
			{
			}
			array[2] = portDefinition3;
			PortDefinition portDefinition4 = new PortDefinition(this.isHypnotized_PortName, (PortType)((uint)6), (PortDirection)((uint)1));
			if (portDefinition4 != 0)
			{
			}
			array[3] = portDefinition4;
			return array;
		}

		// Token: 0x0600401C RID: 16412 RVA: 0x001514CC File Offset: 0x0014F6CC
		[Token(Token = "0x600401C")]
		[Address(RVA = "0x872CC0", Offset = "0x8712C0", VA = "0x180872CC0", Slot = "7")]
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
		}

		// Token: 0x0600401D RID: 16413 RVA: 0x0015152C File Offset: 0x0014F72C
		[Token(Token = "0x600401D")]
		[Address(RVA = "0xB2ABC0", Offset = "0xB291C0", VA = "0x180B2ABC0", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			if (this.zombieSourceNode != (ulong)0L)
			{
			}
			int num = 0;
			int num2 = 0;
			bool flag = num == num2;
			if (!flag)
			{
				if (!flag)
				{
					if (!flag)
					{
						if (!flag)
						{
							if (!flag)
							{
							}
							bool flag2;
							EventNodeDebug.Log(string.Format("[ZombieSplitNode] 获取是否被魅惑: {0}", flag2));
						}
						ZombieType zombieType;
						EventNodeDebug.Log(string.Format("[ZombieSplitNode] 获取僵尸类型: {0}", zombieType));
					}
					int num3;
					EventNodeDebug.Log(string.Format("[ZombieSplitNode] 获取行: {0}", num3));
				}
				int num4;
				string text = string.Format("[ZombieSplitNode] 获取列: {0}", num4);
				EventNodeDebug.Log(text);
			}
			string nodeId = this.nodeId;
			EventNodeDebug.LogWarning("[ZombieSplitNode] 僵尸对象为空，返回默认值，节点ID: " + nodeId);
			return defaultValue;
		}

		// Token: 0x0600401E RID: 16414 RVA: 0x001515F0 File Offset: 0x0014F7F0
		[Token(Token = "0x600401E")]
		[Address(RVA = "0x872D80", Offset = "0x871380", VA = "0x180872D80")]
		public ZombieSplitNode()
		{
		}

		// Token: 0x04003121 RID: 12577
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4003121")]
		public string zombie_PortName = "僵尸";

		// Token: 0x04003122 RID: 12578
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4003122")]
		public string column_PortName = "列";

		// Token: 0x04003123 RID: 12579
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4003123")]
		public string row_PortName = "行";

		// Token: 0x04003124 RID: 12580
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4003124")]
		public string zombieType_PortName = "僵尸类型";

		// Token: 0x04003125 RID: 12581
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4003125")]
		public string isHypnotized_PortName = "是否被魅惑";

		// Token: 0x04003126 RID: 12582
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4003126")]
		[NonSerialized]
		private EventNodeBase zombieSourceNode;

		// Token: 0x04003127 RID: 12583
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4003127")]
		[NonSerialized]
		private string zombieSourcePort;
	}
}
