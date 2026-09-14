using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BB8 RID: 3000
	[Token(Token = "0x2000BB8")]
	[Serializable]
	public class CreateDoomShroomEffectNode : EventNodeBase
	{
		// Token: 0x06003E74 RID: 15988 RVA: 0x00147C14 File Offset: 0x00145E14
		[Token(Token = "0x6003E74")]
		[Address(RVA = "0x83A6C0", Offset = "0x838CC0", VA = "0x18083A6C0", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[5];
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
			PortDefinition portDefinition2 = new PortDefinition(this.column_PortName, (PortType)((uint)1), (PortDirection)num3);
			num3 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			int num4;
			PortDefinition portDefinition3 = new PortDefinition(this.row_PortName, (PortType)((uint)1), (PortDirection)num4);
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
			int num6;
			PortDefinition portDefinition5 = new PortDefinition(this.setPit_PortName, (PortType)((uint)6), (PortDirection)num6);
			num6 = 0;
			if (portDefinition5 != 0)
			{
			}
			array[4] = portDefinition5;
			return array;
		}

		// Token: 0x06003E75 RID: 15989 RVA: 0x00147CDC File Offset: 0x00145EDC
		[Token(Token = "0x6003E75")]
		[Address(RVA = "0x83A990", Offset = "0x838F90", VA = "0x18083A990", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			return null;
		}

		// Token: 0x06003E76 RID: 15990 RVA: 0x00147CEC File Offset: 0x00145EEC
		[Token(Token = "0x6003E76")]
		[Address(RVA = "0x83A9D0", Offset = "0x838FD0", VA = "0x18083A9D0", Slot = "7")]
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
			string text4 = this.setPit_PortName;
			string nodeId4 = this.nodeId;
			List<SourcePortInfo> sourceNodes4 = graph.GetSourceNodes(nodeId4, text4);
			int num7 = 0;
			EventNodeBase sourceNode4 = sourceNodes4[num7].sourceNode;
			this.setPitSourceNode = sourceNode4;
			int num8 = 0;
			string sourcePortName4 = sourceNodes4[num8].sourcePortName;
			this.setPitSourcePort = sourcePortName4;
		}

		// Token: 0x06003E77 RID: 15991 RVA: 0x00147E40 File Offset: 0x00146040
		[Token(Token = "0x6003E77")]
		[Address(RVA = "0x83A250", Offset = "0x838850", VA = "0x18083A250", Slot = "6")]
		public override void Execute()
		{
			if (this.columnSourceNode != (ulong)0L)
			{
			}
			if (this.rowSourceNode != (ulong)0L)
			{
			}
			if (this.damageSourceNode != (ulong)0L)
			{
			}
			if (this.setPitSourceNode != (ulong)0L)
			{
			}
			uint num;
			bool flag = num != (uint)0;
			BoardAction boardAction = Board.Instance.boardAction;
			object[] array = new object[4];
			int num2;
			if (num2 != 0)
			{
			}
			array[0] = num2;
			int num3;
			if (num3 != 0)
			{
			}
			array[1] = num3;
			int num4;
			if (num4 != 0)
			{
			}
			array[2] = num4;
			if (num4 != 0)
			{
			}
			array[3] = num4;
			EventNodeDebug.Log(string.Format("[CreateDoomShroomEffectNode] 创建毁灭菇效果，位置: ({0}, {1})，伤害: {2}，创建弹坑: {3}", array));
		}

		// Token: 0x06003E78 RID: 15992 RVA: 0x00147EF4 File Offset: 0x001460F4
		[Token(Token = "0x6003E78")]
		[Address(RVA = "0x83AC20", Offset = "0x839220", VA = "0x18083AC20")]
		public CreateDoomShroomEffectNode()
		{
		}

		// Token: 0x04002F21 RID: 12065
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002F21")]
		public string trigger_PortName = "触发";

		// Token: 0x04002F22 RID: 12066
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002F22")]
		public string column_PortName = "列";

		// Token: 0x04002F23 RID: 12067
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002F23")]
		public string row_PortName = "行";

		// Token: 0x04002F24 RID: 12068
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002F24")]
		public string damage_PortName = "伤害值";

		// Token: 0x04002F25 RID: 12069
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002F25")]
		public string setPit_PortName = "创建弹坑";

		// Token: 0x04002F26 RID: 12070
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002F26")]
		[NonSerialized]
		private EventNodeBase columnSourceNode;

		// Token: 0x04002F27 RID: 12071
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002F27")]
		[NonSerialized]
		private string columnSourcePort;

		// Token: 0x04002F28 RID: 12072
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002F28")]
		[NonSerialized]
		private EventNodeBase rowSourceNode;

		// Token: 0x04002F29 RID: 12073
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002F29")]
		[NonSerialized]
		private string rowSourcePort;

		// Token: 0x04002F2A RID: 12074
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002F2A")]
		[NonSerialized]
		private EventNodeBase damageSourceNode;

		// Token: 0x04002F2B RID: 12075
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4002F2B")]
		[NonSerialized]
		private string damageSourcePort;

		// Token: 0x04002F2C RID: 12076
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4002F2C")]
		[NonSerialized]
		private EventNodeBase setPitSourceNode;

		// Token: 0x04002F2D RID: 12077
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4002F2D")]
		[NonSerialized]
		private string setPitSourcePort;
	}
}
