using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B76 RID: 2934
	[Token(Token = "0x2000B76")]
	[Serializable]
	public class CreateDoomShroomEffectNode : EventNodeBase
	{
		// Token: 0x06003D23 RID: 15651 RVA: 0x00142980 File Offset: 0x00140B80
		[Token(Token = "0x6003D23")]
		[Address(RVA = "0x7BE370", Offset = "0x7BC970", VA = "0x1807BE370", Slot = "4")]
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

		// Token: 0x06003D24 RID: 15652 RVA: 0x00142A48 File Offset: 0x00140C48
		[Token(Token = "0x6003D24")]
		[Address(RVA = "0x7BE640", Offset = "0x7BCC40", VA = "0x1807BE640", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			return null;
		}

		// Token: 0x06003D25 RID: 15653 RVA: 0x00142A58 File Offset: 0x00140C58
		[Token(Token = "0x6003D25")]
		[Address(RVA = "0x7BE680", Offset = "0x7BCC80", VA = "0x1807BE680", Slot = "7")]
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

		// Token: 0x06003D26 RID: 15654 RVA: 0x00142BAC File Offset: 0x00140DAC
		[Token(Token = "0x6003D26")]
		[Address(RVA = "0x7BDF00", Offset = "0x7BC500", VA = "0x1807BDF00", Slot = "6")]
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

		// Token: 0x06003D27 RID: 15655 RVA: 0x00142C60 File Offset: 0x00140E60
		[Token(Token = "0x6003D27")]
		[Address(RVA = "0x7BE8D0", Offset = "0x7BCED0", VA = "0x1807BE8D0")]
		public CreateDoomShroomEffectNode()
		{
		}

		// Token: 0x04002DAD RID: 11693
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002DAD")]
		public string trigger_PortName = "触发";

		// Token: 0x04002DAE RID: 11694
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002DAE")]
		public string column_PortName = "列";

		// Token: 0x04002DAF RID: 11695
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002DAF")]
		public string row_PortName = "行";

		// Token: 0x04002DB0 RID: 11696
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002DB0")]
		public string damage_PortName = "伤害值";

		// Token: 0x04002DB1 RID: 11697
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002DB1")]
		public string setPit_PortName = "创建弹坑";

		// Token: 0x04002DB2 RID: 11698
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002DB2")]
		[NonSerialized]
		private EventNodeBase columnSourceNode;

		// Token: 0x04002DB3 RID: 11699
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002DB3")]
		[NonSerialized]
		private string columnSourcePort;

		// Token: 0x04002DB4 RID: 11700
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002DB4")]
		[NonSerialized]
		private EventNodeBase rowSourceNode;

		// Token: 0x04002DB5 RID: 11701
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002DB5")]
		[NonSerialized]
		private string rowSourcePort;

		// Token: 0x04002DB6 RID: 11702
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002DB6")]
		[NonSerialized]
		private EventNodeBase damageSourceNode;

		// Token: 0x04002DB7 RID: 11703
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4002DB7")]
		[NonSerialized]
		private string damageSourcePort;

		// Token: 0x04002DB8 RID: 11704
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4002DB8")]
		[NonSerialized]
		private EventNodeBase setPitSourceNode;

		// Token: 0x04002DB9 RID: 11705
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4002DB9")]
		[NonSerialized]
		private string setPitSourcePort;
	}
}
