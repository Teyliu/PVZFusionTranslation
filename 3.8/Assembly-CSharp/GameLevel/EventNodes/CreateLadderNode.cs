using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B80 RID: 2944
	[Token(Token = "0x2000B80")]
	[Serializable]
	public class CreateLadderNode : EventNodeBase
	{
		// Token: 0x06003D52 RID: 15698 RVA: 0x00143A0C File Offset: 0x00141C0C
		[Token(Token = "0x6003D52")]
		[Address(RVA = "0x7C0370", Offset = "0x7BE970", VA = "0x1807C0370", Slot = "4")]
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

		// Token: 0x06003D53 RID: 15699 RVA: 0x00143A8C File Offset: 0x00141C8C
		[Token(Token = "0x6003D53")]
		[Address(RVA = "0x7C0550", Offset = "0x7BEB50", VA = "0x1807C0550", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			return null;
		}

		// Token: 0x06003D54 RID: 15700 RVA: 0x00143A9C File Offset: 0x00141C9C
		[Token(Token = "0x6003D54")]
		[Address(RVA = "0x7C0590", Offset = "0x7BEB90", VA = "0x1807C0590", Slot = "7")]
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

		// Token: 0x06003D55 RID: 15701 RVA: 0x00143B4C File Offset: 0x00141D4C
		[Token(Token = "0x6003D55")]
		[Address(RVA = "0x7C0200", Offset = "0x7BE800", VA = "0x1807C0200", Slot = "6")]
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

		// Token: 0x06003D56 RID: 15702 RVA: 0x00143B88 File Offset: 0x00141D88
		[Token(Token = "0x6003D56")]
		[Address(RVA = "0x7C06E0", Offset = "0x7BECE0", VA = "0x1807C06E0")]
		public CreateLadderNode()
		{
		}

		// Token: 0x04002DE9 RID: 11753
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002DE9")]
		public string trigger_PortName = "触发";

		// Token: 0x04002DEA RID: 11754
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002DEA")]
		public string column_PortName = "列";

		// Token: 0x04002DEB RID: 11755
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002DEB")]
		public string row_PortName = "行";

		// Token: 0x04002DEC RID: 11756
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002DEC")]
		[NonSerialized]
		private EventNodeBase columnSourceNode;

		// Token: 0x04002DED RID: 11757
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002DED")]
		[NonSerialized]
		private string columnSourcePort;

		// Token: 0x04002DEE RID: 11758
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002DEE")]
		[NonSerialized]
		private EventNodeBase rowSourceNode;

		// Token: 0x04002DEF RID: 11759
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002DEF")]
		[NonSerialized]
		private string rowSourcePort;
	}
}
