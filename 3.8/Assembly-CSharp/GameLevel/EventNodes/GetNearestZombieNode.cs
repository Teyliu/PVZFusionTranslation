using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B7C RID: 2940
	[Token(Token = "0x2000B7C")]
	[Serializable]
	public class GetNearestZombieNode : EventNodeBase
	{
		// Token: 0x06003D41 RID: 15681 RVA: 0x001435D4 File Offset: 0x001417D4
		[Token(Token = "0x6003D41")]
		[Address(RVA = "0x7C8940", Offset = "0x7C6F40", VA = "0x1807C8940", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[2];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.row_PortName, (PortType)((uint)1), (PortDirection)num);
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			int num2;
			PortDefinition portDefinition2 = new PortDefinition(this.column_PortName, (PortType)((uint)1), (PortDirection)num2);
			num2 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003D42 RID: 15682 RVA: 0x00143630 File Offset: 0x00141830
		[Token(Token = "0x6003D42")]
		[Address(RVA = "0x7C8AB0", Offset = "0x7C70B0", VA = "0x1807C8AB0", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			PortDefinition portDefinition = new PortDefinition(this.zombie_PortName, (PortType)((uint)12), (PortDirection)((uint)1));
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003D43 RID: 15683 RVA: 0x00143668 File Offset: 0x00141868
		[Token(Token = "0x6003D43")]
		[Address(RVA = "0x7C8BA0", Offset = "0x7C71A0", VA = "0x1807C8BA0", Slot = "7")]
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
			string text2 = this.column_PortName;
			string nodeId2 = this.nodeId;
			List<SourcePortInfo> sourceNodes2 = graph.GetSourceNodes(nodeId2, text2);
			int num3 = 0;
			EventNodeBase sourceNode2 = sourceNodes2[num3].sourceNode;
			this.columnSourceNode = sourceNode2;
			int num4 = 0;
			string sourcePortName2 = sourceNodes2[num4].sourcePortName;
			this.columnSourcePort = sourcePortName2;
		}

		// Token: 0x06003D44 RID: 15684 RVA: 0x00143718 File Offset: 0x00141918
		[Token(Token = "0x6003D44")]
		[Address(RVA = "0x9AFDB0", Offset = "0x9AE3B0", VA = "0x1809AFDB0", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			int num;
			if (this.rowSourceNode != (ulong)0L)
			{
				num += 20;
				num += num;
			}
			int num2 = 0;
			EventNodeBase eventNodeBase;
			if (this.columnSourceNode != (ulong)0L)
			{
				eventNodeBase = this.columnSourceNode;
				num += 20;
				num += num;
			}
			int num3 = 0;
			float boxXFromColumn = Mouse.Instance.GetBoxXFromColumn(num3);
			float landY = Mouse.Instance.GetLandY(boxXFromColumn, num2);
			Board instance = Board.Instance;
			if (eventNodeBase == 0)
			{
			}
			int num4 = 0;
			Zombie zombie;
			if (!(zombie != num4))
			{
				int num5;
				int num6;
				EventNodeDebug.Log(string.Format("[GetNearestZombieNode] 未找到僵尸: 行{0}, 列{1}", num5, num6));
				return defaultValue;
			}
			string text;
			EventNodeDebug.Log(text);
			throw new NullReferenceException();
		}

		// Token: 0x06003D45 RID: 15685 RVA: 0x001437D0 File Offset: 0x001419D0
		[Token(Token = "0x6003D45")]
		[Address(RVA = "0x7C8CF0", Offset = "0x7C72F0", VA = "0x1807C8CF0")]
		public GetNearestZombieNode()
		{
		}

		// Token: 0x04002DDB RID: 11739
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002DDB")]
		public string row_PortName = "行";

		// Token: 0x04002DDC RID: 11740
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002DDC")]
		public string column_PortName = "列";

		// Token: 0x04002DDD RID: 11741
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002DDD")]
		public string zombie_PortName = "僵尸";

		// Token: 0x04002DDE RID: 11742
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002DDE")]
		[NonSerialized]
		private EventNodeBase rowSourceNode;

		// Token: 0x04002DDF RID: 11743
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002DDF")]
		[NonSerialized]
		private string rowSourcePort;

		// Token: 0x04002DE0 RID: 11744
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002DE0")]
		[NonSerialized]
		private EventNodeBase columnSourceNode;

		// Token: 0x04002DE1 RID: 11745
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002DE1")]
		[NonSerialized]
		private string columnSourcePort;
	}
}
