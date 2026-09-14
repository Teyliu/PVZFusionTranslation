using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B78 RID: 2936
	[Token(Token = "0x2000B78")]
	[Serializable]
	public class GivePlantShieldNode : EventNodeBase
	{
		// Token: 0x06003D2D RID: 15661 RVA: 0x00142F20 File Offset: 0x00141120
		[Token(Token = "0x6003D2D")]
		[Address(RVA = "0x7C9C40", Offset = "0x7C8240", VA = "0x1807C9C40", Slot = "4")]
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
			PortDefinition portDefinition2 = new PortDefinition(this.plant_PortName, (PortType)((uint)11), (PortDirection)num3);
			num3 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			int num4;
			PortDefinition portDefinition3 = new PortDefinition(this.shieldAmount_PortName, (PortType)((uint)3), (PortDirection)num4);
			num4 = 0;
			if (portDefinition3 != 0)
			{
			}
			array[2] = portDefinition3;
			return array;
		}

		// Token: 0x06003D2E RID: 15662 RVA: 0x00142FA0 File Offset: 0x001411A0
		[Token(Token = "0x6003D2E")]
		[Address(RVA = "0x7C9E20", Offset = "0x7C8420", VA = "0x1807C9E20", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			return null;
		}

		// Token: 0x06003D2F RID: 15663 RVA: 0x00142FB0 File Offset: 0x001411B0
		[Token(Token = "0x6003D2F")]
		[Address(RVA = "0x7C9E60", Offset = "0x7C8460", VA = "0x1807C9E60", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.plant_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.plantSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.plantSourcePort = sourcePortName;
			string text2 = this.shieldAmount_PortName;
			string nodeId2 = this.nodeId;
			List<SourcePortInfo> sourceNodes2 = graph.GetSourceNodes(nodeId2, text2);
			int num3 = 0;
			EventNodeBase sourceNode2 = sourceNodes2[num3].sourceNode;
			this.shieldAmountSourceNode = sourceNode2;
			int num4 = 0;
			string sourcePortName2 = sourceNodes2[num4].sourcePortName;
			this.shieldAmountSourcePort = sourcePortName2;
		}

		// Token: 0x06003D30 RID: 15664 RVA: 0x00143060 File Offset: 0x00141260
		[Token(Token = "0x6003D30")]
		[Address(RVA = "0x7C9A30", Offset = "0x7C8030", VA = "0x1807C9A30", Slot = "6")]
		public override void Execute()
		{
			if (this.plantSourceNode != (ulong)0L)
			{
			}
			int num = 0;
			if (this.shieldAmountSourceNode != (ulong)0L)
			{
			}
			int num2 = 0;
			string text;
			if (!(num != num2))
			{
				string nodeId = this.nodeId;
				text = "[GivePlantShieldNode] 植物对象为空，无法增加护盾，节点ID: " + nodeId;
				EventNodeDebug.LogWarning(text);
				return;
			}
			EventNodeDebug.Log(string.Format("[GivePlantShieldNode] 给植物增加 {0} 护盾值", text));
			throw new NullReferenceException();
		}

		// Token: 0x06003D31 RID: 15665 RVA: 0x001430C4 File Offset: 0x001412C4
		[Token(Token = "0x6003D31")]
		[Address(RVA = "0x7C9FB0", Offset = "0x7C85B0", VA = "0x1807C9FB0")]
		public GivePlantShieldNode()
		{
		}

		// Token: 0x04002DC4 RID: 11716
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002DC4")]
		public string trigger_PortName = "触发";

		// Token: 0x04002DC5 RID: 11717
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002DC5")]
		public string plant_PortName = "植物";

		// Token: 0x04002DC6 RID: 11718
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002DC6")]
		public string shieldAmount_PortName = "护盾值";

		// Token: 0x04002DC7 RID: 11719
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002DC7")]
		[NonSerialized]
		private EventNodeBase plantSourceNode;

		// Token: 0x04002DC8 RID: 11720
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002DC8")]
		[NonSerialized]
		private string plantSourcePort;

		// Token: 0x04002DC9 RID: 11721
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002DC9")]
		[NonSerialized]
		private EventNodeBase shieldAmountSourceNode;

		// Token: 0x04002DCA RID: 11722
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002DCA")]
		[NonSerialized]
		private string shieldAmountSourcePort;
	}
}
