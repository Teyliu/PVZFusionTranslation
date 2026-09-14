using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B6A RID: 2922
	[Token(Token = "0x2000B6A")]
	[Serializable]
	public class CreateGraveNode : EventNodeBase
	{
		// Token: 0x06003CE2 RID: 15586 RVA: 0x00140CC8 File Offset: 0x0013EEC8
		[Token(Token = "0x6003CE2")]
		[Address(RVA = "0x7BEB30", Offset = "0x7BD130", VA = "0x1807BEB30", Slot = "4")]
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

		// Token: 0x06003CE3 RID: 15587 RVA: 0x00140D48 File Offset: 0x0013EF48
		[Token(Token = "0x6003CE3")]
		[Address(RVA = "0x7BED10", Offset = "0x7BD310", VA = "0x1807BED10", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			return null;
		}

		// Token: 0x06003CE4 RID: 15588 RVA: 0x00140D58 File Offset: 0x0013EF58
		[Token(Token = "0x6003CE4")]
		[Address(RVA = "0x7BED50", Offset = "0x7BD350", VA = "0x1807BED50", Slot = "7")]
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

		// Token: 0x06003CE5 RID: 15589 RVA: 0x00140E08 File Offset: 0x0013F008
		[Token(Token = "0x6003CE5")]
		[Address(RVA = "0x7BE9C0", Offset = "0x7BCFC0", VA = "0x1807BE9C0", Slot = "6")]
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
			EventNodeDebug.Log(string.Format("[CreateGraveNode] 在 ({0}, {1}) 创建了墓碑", num, num2));
		}

		// Token: 0x06003CE6 RID: 15590 RVA: 0x00140E44 File Offset: 0x0013F044
		[Token(Token = "0x6003CE6")]
		[Address(RVA = "0x7BEEA0", Offset = "0x7BD4A0", VA = "0x1807BEEA0")]
		public CreateGraveNode()
		{
		}

		// Token: 0x04002D3E RID: 11582
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002D3E")]
		public string trigger_PortName = "触发";

		// Token: 0x04002D3F RID: 11583
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002D3F")]
		public string column_PortName = "列";

		// Token: 0x04002D40 RID: 11584
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002D40")]
		public string row_PortName = "行";

		// Token: 0x04002D41 RID: 11585
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002D41")]
		[NonSerialized]
		private EventNodeBase columnSourceNode;

		// Token: 0x04002D42 RID: 11586
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002D42")]
		[NonSerialized]
		private string columnSourcePort;

		// Token: 0x04002D43 RID: 11587
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002D43")]
		[NonSerialized]
		private EventNodeBase rowSourceNode;

		// Token: 0x04002D44 RID: 11588
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002D44")]
		[NonSerialized]
		private string rowSourcePort;
	}
}
