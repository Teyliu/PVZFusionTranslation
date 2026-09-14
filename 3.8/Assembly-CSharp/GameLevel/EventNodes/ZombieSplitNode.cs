using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BC8 RID: 3016
	[Token(Token = "0x2000BC8")]
	[Serializable]
	public class ZombieSplitNode : EventNodeBase
	{
		// Token: 0x06003EC9 RID: 16073 RVA: 0x0014C190 File Offset: 0x0014A390
		[Token(Token = "0x6003EC9")]
		[Address(RVA = "0x80AF80", Offset = "0x809580", VA = "0x18080AF80", Slot = "4")]
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

		// Token: 0x06003ECA RID: 16074 RVA: 0x0014C1CC File Offset: 0x0014A3CC
		[Token(Token = "0x6003ECA")]
		[Address(RVA = "0x80B070", Offset = "0x809670", VA = "0x18080B070", Slot = "5")]
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

		// Token: 0x06003ECB RID: 16075 RVA: 0x0014C260 File Offset: 0x0014A460
		[Token(Token = "0x6003ECB")]
		[Address(RVA = "0x80B2D0", Offset = "0x8098D0", VA = "0x18080B2D0", Slot = "7")]
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

		// Token: 0x06003ECC RID: 16076 RVA: 0x0014C2C0 File Offset: 0x0014A4C0
		[Token(Token = "0x6003ECC")]
		[Address(RVA = "0xA5B880", Offset = "0xA59E80", VA = "0x180A5B880", Slot = "9")]
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

		// Token: 0x06003ECD RID: 16077 RVA: 0x0014C384 File Offset: 0x0014A584
		[Token(Token = "0x6003ECD")]
		[Address(RVA = "0x80B390", Offset = "0x809990", VA = "0x18080B390")]
		public ZombieSplitNode()
		{
		}

		// Token: 0x04002FAD RID: 12205
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002FAD")]
		public string zombie_PortName = "僵尸";

		// Token: 0x04002FAE RID: 12206
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002FAE")]
		public string column_PortName = "列";

		// Token: 0x04002FAF RID: 12207
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002FAF")]
		public string row_PortName = "行";

		// Token: 0x04002FB0 RID: 12208
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002FB0")]
		public string zombieType_PortName = "僵尸类型";

		// Token: 0x04002FB1 RID: 12209
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002FB1")]
		public string isHypnotized_PortName = "是否被魅惑";

		// Token: 0x04002FB2 RID: 12210
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002FB2")]
		[NonSerialized]
		private EventNodeBase zombieSourceNode;

		// Token: 0x04002FB3 RID: 12211
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002FB3")]
		[NonSerialized]
		private string zombieSourcePort;
	}
}
