using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B81 RID: 2945
	[Token(Token = "0x2000B81")]
	[Serializable]
	public class CreateCraterNode : EventNodeBase
	{
		// Token: 0x06003D57 RID: 15703 RVA: 0x00143BBC File Offset: 0x00141DBC
		[Token(Token = "0x6003D57")]
		[Address(RVA = "0x7BDAF0", Offset = "0x7BC0F0", VA = "0x1807BDAF0", Slot = "4")]
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

		// Token: 0x06003D58 RID: 15704 RVA: 0x00143C3C File Offset: 0x00141E3C
		[Token(Token = "0x6003D58")]
		[Address(RVA = "0x7BDCD0", Offset = "0x7BC2D0", VA = "0x1807BDCD0", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			return null;
		}

		// Token: 0x06003D59 RID: 15705 RVA: 0x00143C4C File Offset: 0x00141E4C
		[Token(Token = "0x6003D59")]
		[Address(RVA = "0x7BDD10", Offset = "0x7BC310", VA = "0x1807BDD10", Slot = "7")]
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

		// Token: 0x06003D5A RID: 15706 RVA: 0x00143CFC File Offset: 0x00141EFC
		[Token(Token = "0x6003D5A")]
		[Address(RVA = "0x7BD930", Offset = "0x7BBF30", VA = "0x1807BD930", Slot = "6")]
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

		// Token: 0x06003D5B RID: 15707 RVA: 0x00143D48 File Offset: 0x00141F48
		[Token(Token = "0x6003D5B")]
		[Address(RVA = "0x7BDE60", Offset = "0x7BC460", VA = "0x1807BDE60")]
		public CreateCraterNode()
		{
		}

		// Token: 0x04002DF0 RID: 11760
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002DF0")]
		public string trigger_PortName = "触发";

		// Token: 0x04002DF1 RID: 11761
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002DF1")]
		public string column_PortName = "列";

		// Token: 0x04002DF2 RID: 11762
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002DF2")]
		public string row_PortName = "行";

		// Token: 0x04002DF3 RID: 11763
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002DF3")]
		[NonSerialized]
		private EventNodeBase columnSourceNode;

		// Token: 0x04002DF4 RID: 11764
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002DF4")]
		[NonSerialized]
		private string columnSourcePort;

		// Token: 0x04002DF5 RID: 11765
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002DF5")]
		[NonSerialized]
		private EventNodeBase rowSourceNode;

		// Token: 0x04002DF6 RID: 11766
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002DF6")]
		[NonSerialized]
		private string rowSourcePort;
	}
}
