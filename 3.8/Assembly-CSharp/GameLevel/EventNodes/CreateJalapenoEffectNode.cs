using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B75 RID: 2933
	[Token(Token = "0x2000B75")]
	[Serializable]
	public class CreateJalapenoEffectNode : EventNodeBase
	{
		// Token: 0x06003D1E RID: 15646 RVA: 0x001427C0 File Offset: 0x001409C0
		[Token(Token = "0x6003D1E")]
		[Address(RVA = "0x7BFDF0", Offset = "0x7BE3F0", VA = "0x1807BFDF0", Slot = "4")]
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
			PortDefinition portDefinition3 = new PortDefinition(this.damage_PortName, (PortType)((uint)1), (PortDirection)num4);
			num4 = 0;
			if (portDefinition3 != 0)
			{
			}
			array[2] = portDefinition3;
			return array;
		}

		// Token: 0x06003D1F RID: 15647 RVA: 0x00142840 File Offset: 0x00140A40
		[Token(Token = "0x6003D1F")]
		[Address(RVA = "0x7BFFD0", Offset = "0x7BE5D0", VA = "0x1807BFFD0", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			return null;
		}

		// Token: 0x06003D20 RID: 15648 RVA: 0x00142850 File Offset: 0x00140A50
		[Token(Token = "0x6003D20")]
		[Address(RVA = "0x7C0010", Offset = "0x7BE610", VA = "0x1807C0010", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.row_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.rowSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.rowSourcePort = sourcePortName;
			string text2 = this.damage_PortName;
			string nodeId2 = this.nodeId;
			List<SourcePortInfo> sourceNodes2 = graph.GetSourceNodes(nodeId2, text2);
			int num3 = 0;
			EventNodeBase sourceNode2 = sourceNodes2[num3].sourceNode;
			this.damageSourceNode = sourceNode2;
			int num4 = 0;
			string sourcePortName2 = sourceNodes2[num4].sourcePortName;
			this.damageSourcePort = sourcePortName2;
		}

		// Token: 0x06003D21 RID: 15649 RVA: 0x00142900 File Offset: 0x00140B00
		[Token(Token = "0x6003D21")]
		[Address(RVA = "0x7BFC10", Offset = "0x7BE210", VA = "0x1807BFC10", Slot = "6")]
		public override void Execute()
		{
			if (this.rowSourceNode != (ulong)0L)
			{
			}
			if (this.damageSourceNode != (ulong)0L)
			{
			}
			BoardAction boardAction = Board.Instance.boardAction;
			int num;
			int num2;
			EventNodeDebug.Log(string.Format("[CreateJalapenoEffectNode] 创建火爆辣椒效果，行: {0}，伤害: {1}", num, num2));
		}

		// Token: 0x06003D22 RID: 15650 RVA: 0x0014294C File Offset: 0x00140B4C
		[Token(Token = "0x6003D22")]
		[Address(RVA = "0x7C0160", Offset = "0x7BE760", VA = "0x1807C0160")]
		public CreateJalapenoEffectNode()
		{
		}

		// Token: 0x04002DA6 RID: 11686
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002DA6")]
		public string trigger_PortName = "触发";

		// Token: 0x04002DA7 RID: 11687
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002DA7")]
		public string row_PortName = "行";

		// Token: 0x04002DA8 RID: 11688
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002DA8")]
		public string damage_PortName = "伤害值";

		// Token: 0x04002DA9 RID: 11689
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002DA9")]
		[NonSerialized]
		private EventNodeBase rowSourceNode;

		// Token: 0x04002DAA RID: 11690
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002DAA")]
		[NonSerialized]
		private string rowSourcePort;

		// Token: 0x04002DAB RID: 11691
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002DAB")]
		[NonSerialized]
		private EventNodeBase damageSourceNode;

		// Token: 0x04002DAC RID: 11692
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002DAC")]
		[NonSerialized]
		private string damageSourcePort;
	}
}
