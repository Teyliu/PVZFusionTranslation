using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BC3 RID: 3011
	[Token(Token = "0x2000BC3")]
	[Serializable]
	public class CreateCraterNode : EventNodeBase
	{
		// Token: 0x06003EA8 RID: 16040 RVA: 0x00148E5C File Offset: 0x0014705C
		[Token(Token = "0x6003EA8")]
		[Address(RVA = "0x839E40", Offset = "0x838440", VA = "0x180839E40", Slot = "4")]
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

		// Token: 0x06003EA9 RID: 16041 RVA: 0x00148EDC File Offset: 0x001470DC
		[Token(Token = "0x6003EA9")]
		[Address(RVA = "0x83A020", Offset = "0x838620", VA = "0x18083A020", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			return null;
		}

		// Token: 0x06003EAA RID: 16042 RVA: 0x00148EEC File Offset: 0x001470EC
		[Token(Token = "0x6003EAA")]
		[Address(RVA = "0x83A060", Offset = "0x838660", VA = "0x18083A060", Slot = "7")]
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

		// Token: 0x06003EAB RID: 16043 RVA: 0x00148F9C File Offset: 0x0014719C
		[Token(Token = "0x6003EAB")]
		[Address(RVA = "0x839C80", Offset = "0x838280", VA = "0x180839C80", Slot = "6")]
		public override void Execute()
		{
			if (this.columnSourceNode != (ulong)0L)
			{
			}
			if (this.rowSourceNode != (ulong)0L)
			{
			}
			Board instance = Board.Instance;
			int num;
			int num2;
			EventNodeDebug.Log(string.Format("[CreateCraterNode] 在 ({0}, {1}) 创建了弹坑", num, num2));
		}

		// Token: 0x06003EAC RID: 16044 RVA: 0x00148FE8 File Offset: 0x001471E8
		[Token(Token = "0x6003EAC")]
		[Address(RVA = "0x83A1B0", Offset = "0x8387B0", VA = "0x18083A1B0")]
		public CreateCraterNode()
		{
		}

		// Token: 0x04002F64 RID: 12132
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002F64")]
		public string trigger_PortName = "触发";

		// Token: 0x04002F65 RID: 12133
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002F65")]
		public string column_PortName = "列";

		// Token: 0x04002F66 RID: 12134
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002F66")]
		public string row_PortName = "行";

		// Token: 0x04002F67 RID: 12135
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002F67")]
		[NonSerialized]
		private EventNodeBase columnSourceNode;

		// Token: 0x04002F68 RID: 12136
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002F68")]
		[NonSerialized]
		private string columnSourcePort;

		// Token: 0x04002F69 RID: 12137
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002F69")]
		[NonSerialized]
		private EventNodeBase rowSourceNode;

		// Token: 0x04002F6A RID: 12138
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002F6A")]
		[NonSerialized]
		private string rowSourcePort;
	}
}
