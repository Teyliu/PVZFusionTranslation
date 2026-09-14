using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BC5 RID: 3013
	[Token(Token = "0x2000BC5")]
	[Serializable]
	public class CreateZombieExplodeNode : EventNodeBase
	{
		// Token: 0x06003EB2 RID: 16050 RVA: 0x00149294 File Offset: 0x00147494
		[Token(Token = "0x6003EB2")]
		[Address(RVA = "0x83D720", Offset = "0x83BD20", VA = "0x18083D720", Slot = "4")]
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
			PortDefinition portDefinition2 = new PortDefinition(this.row_PortName, (PortType)((uint)1), (PortDirection)num3);
			num3 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			int num4;
			PortDefinition portDefinition3 = new PortDefinition(this.column_PortName, (PortType)((uint)1), (PortDirection)num4);
			num4 = 0;
			if (portDefinition3 != 0)
			{
			}
			array[2] = portDefinition3;
			return array;
		}

		// Token: 0x06003EB3 RID: 16051 RVA: 0x00149314 File Offset: 0x00147514
		[Token(Token = "0x6003EB3")]
		[Address(RVA = "0x83D900", Offset = "0x83BF00", VA = "0x18083D900", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			return null;
		}

		// Token: 0x06003EB4 RID: 16052 RVA: 0x00149324 File Offset: 0x00147524
		[Token(Token = "0x6003EB4")]
		[Address(RVA = "0x83D940", Offset = "0x83BF40", VA = "0x18083D940", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.column_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.columnSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.columnSourcePort = sourcePortName;
			string text2 = this.row_PortName;
			string nodeId2 = this.nodeId;
			List<SourcePortInfo> sourceNodes2 = graph.GetSourceNodes(nodeId2, text2);
			int num3 = 0;
			EventNodeBase sourceNode2 = sourceNodes2[num3].sourceNode;
			this.rowSourceNode = sourceNode2;
			int num4 = 0;
			string sourcePortName2 = sourceNodes2[num4].sourcePortName;
			this.rowSourcePort = sourcePortName2;
		}

		// Token: 0x06003EB5 RID: 16053 RVA: 0x001493D4 File Offset: 0x001475D4
		[Token(Token = "0x6003EB5")]
		[Address(RVA = "0x83D4D0", Offset = "0x83BAD0", VA = "0x18083D4D0", Slot = "6")]
		public override void Execute()
		{
			if (this.columnSourceNode != (ulong)0L)
			{
			}
			int num = 0;
			if (this.rowSourceNode != (ulong)0L)
			{
			}
			int num2 = 0;
			float boxXFromColumn = Mouse.Instance.GetBoxXFromColumn(num);
			float landY = Mouse.Instance.GetLandY(boxXFromColumn, num2);
			int num3;
			int num4;
			EventNodeDebug.Log(string.Format("[CreateZombieExplodeNode] 在 ({0}, {1}) 创建了小丑爆炸", num3, num4));
		}

		// Token: 0x06003EB6 RID: 16054 RVA: 0x00149430 File Offset: 0x00147630
		[Token(Token = "0x6003EB6")]
		[Address(RVA = "0x83DA90", Offset = "0x83C090", VA = "0x18083DA90")]
		public CreateZombieExplodeNode()
		{
		}

		// Token: 0x04002F75 RID: 12149
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002F75")]
		public string trigger_PortName = "触发";

		// Token: 0x04002F76 RID: 12150
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002F76")]
		public string column_PortName = "列";

		// Token: 0x04002F77 RID: 12151
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002F77")]
		public string row_PortName = "行";

		// Token: 0x04002F78 RID: 12152
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002F78")]
		[NonSerialized]
		private EventNodeBase columnSourceNode;

		// Token: 0x04002F79 RID: 12153
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002F79")]
		[NonSerialized]
		private string columnSourcePort;

		// Token: 0x04002F7A RID: 12154
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002F7A")]
		[NonSerialized]
		private EventNodeBase rowSourceNode;

		// Token: 0x04002F7B RID: 12155
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002F7B")]
		[NonSerialized]
		private string rowSourcePort;
	}
}
