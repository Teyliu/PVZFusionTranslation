using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BC2 RID: 3010
	[Token(Token = "0x2000BC2")]
	[Serializable]
	public class CreateLadderNode : EventNodeBase
	{
		// Token: 0x06003EA3 RID: 16035 RVA: 0x00148CAC File Offset: 0x00146EAC
		[Token(Token = "0x6003EA3")]
		[Address(RVA = "0x83C6D0", Offset = "0x83ACD0", VA = "0x18083C6D0", Slot = "4")]
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

		// Token: 0x06003EA4 RID: 16036 RVA: 0x00148D2C File Offset: 0x00146F2C
		[Token(Token = "0x6003EA4")]
		[Address(RVA = "0x83C8B0", Offset = "0x83AEB0", VA = "0x18083C8B0", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			return null;
		}

		// Token: 0x06003EA5 RID: 16037 RVA: 0x00148D3C File Offset: 0x00146F3C
		[Token(Token = "0x6003EA5")]
		[Address(RVA = "0x83C8F0", Offset = "0x83AEF0", VA = "0x18083C8F0", Slot = "7")]
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

		// Token: 0x06003EA6 RID: 16038 RVA: 0x00148DEC File Offset: 0x00146FEC
		[Token(Token = "0x6003EA6")]
		[Address(RVA = "0x83C560", Offset = "0x83AB60", VA = "0x18083C560", Slot = "6")]
		public override void Execute()
		{
			if (this.columnSourceNode != (ulong)0L)
			{
			}
			if (this.rowSourceNode != (ulong)0L)
			{
			}
			int num;
			int num2;
			EventNodeDebug.Log(string.Format("[CreateLadderNode] 在 ({0}, {1}) 创建了梯子", num, num2));
		}

		// Token: 0x06003EA7 RID: 16039 RVA: 0x00148E28 File Offset: 0x00147028
		[Token(Token = "0x6003EA7")]
		[Address(RVA = "0x83CA40", Offset = "0x83B040", VA = "0x18083CA40")]
		public CreateLadderNode()
		{
		}

		// Token: 0x04002F5D RID: 12125
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002F5D")]
		public string trigger_PortName = "触发";

		// Token: 0x04002F5E RID: 12126
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002F5E")]
		public string column_PortName = "列";

		// Token: 0x04002F5F RID: 12127
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002F5F")]
		public string row_PortName = "行";

		// Token: 0x04002F60 RID: 12128
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002F60")]
		[NonSerialized]
		private EventNodeBase columnSourceNode;

		// Token: 0x04002F61 RID: 12129
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002F61")]
		[NonSerialized]
		private string columnSourcePort;

		// Token: 0x04002F62 RID: 12130
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002F62")]
		[NonSerialized]
		private EventNodeBase rowSourceNode;

		// Token: 0x04002F63 RID: 12131
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002F63")]
		[NonSerialized]
		private string rowSourcePort;
	}
}
