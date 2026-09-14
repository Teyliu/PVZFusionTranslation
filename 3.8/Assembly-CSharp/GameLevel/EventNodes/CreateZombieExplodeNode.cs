using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B83 RID: 2947
	[Token(Token = "0x2000B83")]
	[Serializable]
	public class CreateZombieExplodeNode : EventNodeBase
	{
		// Token: 0x06003D61 RID: 15713 RVA: 0x00143FF4 File Offset: 0x001421F4
		[Token(Token = "0x6003D61")]
		[Address(RVA = "0x7C13C0", Offset = "0x7BF9C0", VA = "0x1807C13C0", Slot = "4")]
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

		// Token: 0x06003D62 RID: 15714 RVA: 0x00144074 File Offset: 0x00142274
		[Token(Token = "0x6003D62")]
		[Address(RVA = "0x7C15A0", Offset = "0x7BFBA0", VA = "0x1807C15A0", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			return null;
		}

		// Token: 0x06003D63 RID: 15715 RVA: 0x00144084 File Offset: 0x00142284
		[Token(Token = "0x6003D63")]
		[Address(RVA = "0x7C15E0", Offset = "0x7BFBE0", VA = "0x1807C15E0", Slot = "7")]
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

		// Token: 0x06003D64 RID: 15716 RVA: 0x00144134 File Offset: 0x00142334
		[Token(Token = "0x6003D64")]
		[Address(RVA = "0x7C1170", Offset = "0x7BF770", VA = "0x1807C1170", Slot = "6")]
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

		// Token: 0x06003D65 RID: 15717 RVA: 0x00144190 File Offset: 0x00142390
		[Token(Token = "0x6003D65")]
		[Address(RVA = "0x7C1730", Offset = "0x7BFD30", VA = "0x1807C1730")]
		public CreateZombieExplodeNode()
		{
		}

		// Token: 0x04002E01 RID: 11777
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002E01")]
		public string trigger_PortName = "触发";

		// Token: 0x04002E02 RID: 11778
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002E02")]
		public string column_PortName = "列";

		// Token: 0x04002E03 RID: 11779
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002E03")]
		public string row_PortName = "行";

		// Token: 0x04002E04 RID: 11780
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002E04")]
		[NonSerialized]
		private EventNodeBase columnSourceNode;

		// Token: 0x04002E05 RID: 11781
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002E05")]
		[NonSerialized]
		private string columnSourcePort;

		// Token: 0x04002E06 RID: 11782
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002E06")]
		[NonSerialized]
		private EventNodeBase rowSourceNode;

		// Token: 0x04002E07 RID: 11783
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002E07")]
		[NonSerialized]
		private string rowSourcePort;
	}
}
