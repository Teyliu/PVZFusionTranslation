using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B82 RID: 2946
	[Token(Token = "0x2000B82")]
	[Serializable]
	public class CreateIceBlockNode : EventNodeBase
	{
		// Token: 0x06003D5C RID: 15708 RVA: 0x00143D7C File Offset: 0x00141F7C
		[Token(Token = "0x6003D5C")]
		[Address(RVA = "0x7BF270", Offset = "0x7BD870", VA = "0x1807BF270", Slot = "4")]
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

		// Token: 0x06003D5D RID: 15709 RVA: 0x00143E20 File Offset: 0x00142020
		[Token(Token = "0x6003D5D")]
		[Address(RVA = "0x7BF4C0", Offset = "0x7BDAC0", VA = "0x1807BF4C0", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			return null;
		}

		// Token: 0x06003D5E RID: 15710 RVA: 0x00143E30 File Offset: 0x00142030
		[Token(Token = "0x6003D5E")]
		[Address(RVA = "0x7BF500", Offset = "0x7BDB00", VA = "0x1807BF500", Slot = "7")]
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

		// Token: 0x06003D5F RID: 15711 RVA: 0x00143F34 File Offset: 0x00142134
		[Token(Token = "0x6003D5F")]
		[Address(RVA = "0x7BEF40", Offset = "0x7BD540", VA = "0x1807BEF40", Slot = "6")]
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

		// Token: 0x06003D60 RID: 15712 RVA: 0x00143FB4 File Offset: 0x001421B4
		[Token(Token = "0x6003D60")]
		[Address(RVA = "0x7BF6D0", Offset = "0x7BDCD0", VA = "0x1807BF6D0")]
		public CreateIceBlockNode()
		{
		}

		// Token: 0x04002DF7 RID: 11767
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002DF7")]
		public string trigger_PortName = "触发";

		// Token: 0x04002DF8 RID: 11768
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002DF8")]
		public string column_PortName = "列";

		// Token: 0x04002DF9 RID: 11769
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002DF9")]
		public string row_PortName = "行";

		// Token: 0x04002DFA RID: 11770
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002DFA")]
		public string plantType_PortName = "冻住的植物";

		// Token: 0x04002DFB RID: 11771
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002DFB")]
		[NonSerialized]
		private EventNodeBase columnSourceNode;

		// Token: 0x04002DFC RID: 11772
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002DFC")]
		[NonSerialized]
		private string columnSourcePort;

		// Token: 0x04002DFD RID: 11773
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002DFD")]
		[NonSerialized]
		private EventNodeBase rowSourceNode;

		// Token: 0x04002DFE RID: 11774
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002DFE")]
		[NonSerialized]
		private string rowSourcePort;

		// Token: 0x04002DFF RID: 11775
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002DFF")]
		[NonSerialized]
		private EventNodeBase plantTypeSourceNode;

		// Token: 0x04002E00 RID: 11776
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002E00")]
		[NonSerialized]
		private string plantTypeSourcePort;
	}
}
