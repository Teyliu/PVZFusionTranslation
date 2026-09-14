using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BC4 RID: 3012
	[Token(Token = "0x2000BC4")]
	[Serializable]
	public class CreateIceBlockNode : EventNodeBase
	{
		// Token: 0x06003EAD RID: 16045 RVA: 0x0014901C File Offset: 0x0014721C
		[Token(Token = "0x6003EAD")]
		[Address(RVA = "0x83B5C0", Offset = "0x839BC0", VA = "0x18083B5C0", Slot = "4")]
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
			PortDefinition portDefinition4 = new PortDefinition(this.plantType_PortName, (PortType)((uint)9), (PortDirection)num5);
			num5 = 0;
			if (portDefinition4 != 0)
			{
			}
			array[3] = portDefinition4;
			return array;
		}

		// Token: 0x06003EAE RID: 16046 RVA: 0x001490C0 File Offset: 0x001472C0
		[Token(Token = "0x6003EAE")]
		[Address(RVA = "0x83B810", Offset = "0x839E10", VA = "0x18083B810", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			return null;
		}

		// Token: 0x06003EAF RID: 16047 RVA: 0x001490D0 File Offset: 0x001472D0
		[Token(Token = "0x6003EAF")]
		[Address(RVA = "0x83B850", Offset = "0x839E50", VA = "0x18083B850", Slot = "7")]
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
			string text3 = this.plantType_PortName;
			string nodeId3 = this.nodeId;
			List<SourcePortInfo> sourceNodes3 = graph.GetSourceNodes(nodeId3, text3);
			int num5 = 0;
			EventNodeBase sourceNode3 = sourceNodes3[num5].sourceNode;
			this.plantTypeSourceNode = sourceNode3;
			int num6 = 0;
			string sourcePortName3 = sourceNodes3[num6].sourcePortName;
			this.plantTypeSourcePort = sourcePortName3;
		}

		// Token: 0x06003EB0 RID: 16048 RVA: 0x001491D4 File Offset: 0x001473D4
		[Token(Token = "0x6003EB0")]
		[Address(RVA = "0x83B290", Offset = "0x839890", VA = "0x18083B290", Slot = "6")]
		public override void Execute()
		{
			if (this.columnSourceNode != (ulong)0L)
			{
			}
			if (this.rowSourceNode != (ulong)0L)
			{
			}
			if (this.plantTypeSourceNode != (ulong)0L)
			{
			}
			GridItem gridItem;
			if (gridItem == 0)
			{
			}
			int num = 0;
			if (!(gridItem != num))
			{
				string nodeId = this.nodeId;
				int num2;
				int num3;
				EventNodeDebug.LogWarning(string.Format("[CreateIceBlockNode] 创建冰块失败在 ({0}, {1})，节点ID: {2}", num2, num3, nodeId));
				return;
			}
			int num4;
			int num5;
			EventNodeDebug.Log(string.Format("[CreateIceBlockNode] 在 ({0}, {1}) 创建了冰块，冻住的植物: {2}", num4, num5, num5));
			throw new NullReferenceException();
		}

		// Token: 0x06003EB1 RID: 16049 RVA: 0x00149254 File Offset: 0x00147454
		[Token(Token = "0x6003EB1")]
		[Address(RVA = "0x83BA20", Offset = "0x83A020", VA = "0x18083BA20")]
		public CreateIceBlockNode()
		{
		}

		// Token: 0x04002F6B RID: 12139
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002F6B")]
		public string trigger_PortName = "触发";

		// Token: 0x04002F6C RID: 12140
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002F6C")]
		public string column_PortName = "列";

		// Token: 0x04002F6D RID: 12141
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002F6D")]
		public string row_PortName = "行";

		// Token: 0x04002F6E RID: 12142
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002F6E")]
		public string plantType_PortName = "冻住的植物";

		// Token: 0x04002F6F RID: 12143
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002F6F")]
		[NonSerialized]
		private EventNodeBase columnSourceNode;

		// Token: 0x04002F70 RID: 12144
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002F70")]
		[NonSerialized]
		private string columnSourcePort;

		// Token: 0x04002F71 RID: 12145
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002F71")]
		[NonSerialized]
		private EventNodeBase rowSourceNode;

		// Token: 0x04002F72 RID: 12146
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002F72")]
		[NonSerialized]
		private string rowSourcePort;

		// Token: 0x04002F73 RID: 12147
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002F73")]
		[NonSerialized]
		private EventNodeBase plantTypeSourceNode;

		// Token: 0x04002F74 RID: 12148
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002F74")]
		[NonSerialized]
		private string plantTypeSourcePort;
	}
}
