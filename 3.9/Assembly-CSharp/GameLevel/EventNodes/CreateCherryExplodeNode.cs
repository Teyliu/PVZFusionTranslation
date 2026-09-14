using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BB9 RID: 3001
	[Token(Token = "0x2000BB9")]
	[Serializable]
	public class CreateCherryExplodeNode : EventNodeBase
	{
		// Token: 0x06003E79 RID: 15993 RVA: 0x00147F40 File Offset: 0x00146140
		[Token(Token = "0x6003E79")]
		[Address(RVA = "0x839750", Offset = "0x837D50", VA = "0x180839750", Slot = "4")]
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

		// Token: 0x06003E7A RID: 15994 RVA: 0x00147FE4 File Offset: 0x001461E4
		[Token(Token = "0x6003E7A")]
		[Address(RVA = "0x8399A0", Offset = "0x837FA0", VA = "0x1808399A0", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			return null;
		}

		// Token: 0x06003E7B RID: 15995 RVA: 0x00147FF4 File Offset: 0x001461F4
		[Token(Token = "0x6003E7B")]
		[Address(RVA = "0x8399E0", Offset = "0x837FE0", VA = "0x1808399E0", Slot = "7")]
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

		// Token: 0x06003E7C RID: 15996 RVA: 0x001480F8 File Offset: 0x001462F8
		[Token(Token = "0x6003E7C")]
		[Address(RVA = "0x839470", Offset = "0x837A70", VA = "0x180839470", Slot = "6")]
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

		// Token: 0x06003E7D RID: 15997 RVA: 0x00148174 File Offset: 0x00146374
		[Token(Token = "0x6003E7D")]
		[Address(RVA = "0x839BB0", Offset = "0x8381B0", VA = "0x180839BB0")]
		public CreateCherryExplodeNode()
		{
		}

		// Token: 0x04002F2E RID: 12078
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002F2E")]
		public string trigger_PortName = "触发";

		// Token: 0x04002F2F RID: 12079
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002F2F")]
		public string column_PortName = "列";

		// Token: 0x04002F30 RID: 12080
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002F30")]
		public string row_PortName = "行";

		// Token: 0x04002F31 RID: 12081
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002F31")]
		public string damage_PortName = "伤害值";

		// Token: 0x04002F32 RID: 12082
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002F32")]
		[NonSerialized]
		private EventNodeBase columnSourceNode;

		// Token: 0x04002F33 RID: 12083
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002F33")]
		[NonSerialized]
		private string columnSourcePort;

		// Token: 0x04002F34 RID: 12084
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002F34")]
		[NonSerialized]
		private EventNodeBase rowSourceNode;

		// Token: 0x04002F35 RID: 12085
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002F35")]
		[NonSerialized]
		private string rowSourcePort;

		// Token: 0x04002F36 RID: 12086
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002F36")]
		[NonSerialized]
		private EventNodeBase damageSourceNode;

		// Token: 0x04002F37 RID: 12087
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002F37")]
		[NonSerialized]
		private string damageSourcePort;
	}
}
