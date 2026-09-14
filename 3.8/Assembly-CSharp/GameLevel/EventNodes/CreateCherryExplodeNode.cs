using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B77 RID: 2935
	[Token(Token = "0x2000B77")]
	[Serializable]
	public class CreateCherryExplodeNode : EventNodeBase
	{
		// Token: 0x06003D28 RID: 15656 RVA: 0x00142CAC File Offset: 0x00140EAC
		[Token(Token = "0x6003D28")]
		[Address(RVA = "0x7BD400", Offset = "0x7BBA00", VA = "0x1807BD400", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[4];
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
			int num5;
			PortDefinition portDefinition4 = new PortDefinition(this.damage_PortName, (PortType)((uint)1), (PortDirection)num5);
			num5 = 0;
			if (portDefinition4 != 0)
			{
			}
			array[3] = portDefinition4;
			return array;
		}

		// Token: 0x06003D29 RID: 15657 RVA: 0x00142D50 File Offset: 0x00140F50
		[Token(Token = "0x6003D29")]
		[Address(RVA = "0x7BD650", Offset = "0x7BBC50", VA = "0x1807BD650", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			return null;
		}

		// Token: 0x06003D2A RID: 15658 RVA: 0x00142D60 File Offset: 0x00140F60
		[Token(Token = "0x6003D2A")]
		[Address(RVA = "0x7BD690", Offset = "0x7BBC90", VA = "0x1807BD690", Slot = "7")]
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
			string text3 = this.damage_PortName;
			string nodeId3 = this.nodeId;
			List<SourcePortInfo> sourceNodes3 = graph.GetSourceNodes(nodeId3, text3);
			int num5 = 0;
			EventNodeBase sourceNode3 = sourceNodes3[num5].sourceNode;
			this.damageSourceNode = sourceNode3;
			int num6 = 0;
			string sourcePortName3 = sourceNodes3[num6].sourcePortName;
			this.damageSourcePort = sourcePortName3;
		}

		// Token: 0x06003D2B RID: 15659 RVA: 0x00142E64 File Offset: 0x00141064
		[Token(Token = "0x6003D2B")]
		[Address(RVA = "0x7BD120", Offset = "0x7BB720", VA = "0x1807BD120", Slot = "6")]
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
			if (this.damageSourceNode != (ulong)0L)
			{
			}
			float boxXFromColumn = Mouse.Instance.GetBoxXFromColumn(num);
			float landY = Mouse.Instance.GetLandY(boxXFromColumn, num2);
			BoardAction boardAction = Board.Instance.boardAction;
			int num3;
			int num4;
			int num5;
			EventNodeDebug.Log(string.Format("[CreateCherryExplodeNode] 创建樱桃爆炸，位置: ({0}, {1})，伤害: {2}", num3, num4, num5));
		}

		// Token: 0x06003D2C RID: 15660 RVA: 0x00142EE0 File Offset: 0x001410E0
		[Token(Token = "0x6003D2C")]
		[Address(RVA = "0x7BD860", Offset = "0x7BBE60", VA = "0x1807BD860")]
		public CreateCherryExplodeNode()
		{
		}

		// Token: 0x04002DBA RID: 11706
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002DBA")]
		public string trigger_PortName = "触发";

		// Token: 0x04002DBB RID: 11707
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002DBB")]
		public string column_PortName = "列";

		// Token: 0x04002DBC RID: 11708
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002DBC")]
		public string row_PortName = "行";

		// Token: 0x04002DBD RID: 11709
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002DBD")]
		public string damage_PortName = "伤害值";

		// Token: 0x04002DBE RID: 11710
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002DBE")]
		[NonSerialized]
		private EventNodeBase columnSourceNode;

		// Token: 0x04002DBF RID: 11711
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002DBF")]
		[NonSerialized]
		private string columnSourcePort;

		// Token: 0x04002DC0 RID: 11712
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002DC0")]
		[NonSerialized]
		private EventNodeBase rowSourceNode;

		// Token: 0x04002DC1 RID: 11713
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002DC1")]
		[NonSerialized]
		private string rowSourcePort;

		// Token: 0x04002DC2 RID: 11714
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002DC2")]
		[NonSerialized]
		private EventNodeBase damageSourceNode;

		// Token: 0x04002DC3 RID: 11715
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002DC3")]
		[NonSerialized]
		private string damageSourcePort;
	}
}
