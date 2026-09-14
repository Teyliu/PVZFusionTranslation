using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BB7 RID: 2999
	[Token(Token = "0x2000BB7")]
	[Serializable]
	public class CreateJalapenoEffectNode : EventNodeBase
	{
		// Token: 0x06003E6F RID: 15983 RVA: 0x00147A54 File Offset: 0x00145C54
		[Token(Token = "0x6003E6F")]
		[Address(RVA = "0x83C150", Offset = "0x83A750", VA = "0x18083C150", Slot = "4")]
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

		// Token: 0x06003E70 RID: 15984 RVA: 0x00147AD4 File Offset: 0x00145CD4
		[Token(Token = "0x6003E70")]
		[Address(RVA = "0x83C330", Offset = "0x83A930", VA = "0x18083C330", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			return null;
		}

		// Token: 0x06003E71 RID: 15985 RVA: 0x00147AE4 File Offset: 0x00145CE4
		[Token(Token = "0x6003E71")]
		[Address(RVA = "0x83C370", Offset = "0x83A970", VA = "0x18083C370", Slot = "7")]
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

		// Token: 0x06003E72 RID: 15986 RVA: 0x00147B94 File Offset: 0x00145D94
		[Token(Token = "0x6003E72")]
		[Address(RVA = "0x83BF70", Offset = "0x83A570", VA = "0x18083BF70", Slot = "6")]
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

		// Token: 0x06003E73 RID: 15987 RVA: 0x00147BE0 File Offset: 0x00145DE0
		[Token(Token = "0x6003E73")]
		[Address(RVA = "0x83C4C0", Offset = "0x83AAC0", VA = "0x18083C4C0")]
		public CreateJalapenoEffectNode()
		{
		}

		// Token: 0x04002F1A RID: 12058
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002F1A")]
		public string trigger_PortName = "触发";

		// Token: 0x04002F1B RID: 12059
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002F1B")]
		public string row_PortName = "行";

		// Token: 0x04002F1C RID: 12060
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002F1C")]
		public string damage_PortName = "伤害值";

		// Token: 0x04002F1D RID: 12061
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002F1D")]
		[NonSerialized]
		private EventNodeBase rowSourceNode;

		// Token: 0x04002F1E RID: 12062
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002F1E")]
		[NonSerialized]
		private string rowSourcePort;

		// Token: 0x04002F1F RID: 12063
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002F1F")]
		[NonSerialized]
		private EventNodeBase damageSourceNode;

		// Token: 0x04002F20 RID: 12064
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002F20")]
		[NonSerialized]
		private string damageSourcePort;
	}
}
