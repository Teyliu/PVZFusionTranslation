using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BBA RID: 3002
	[Token(Token = "0x2000BBA")]
	[Serializable]
	public class GivePlantShieldNode : EventNodeBase
	{
		// Token: 0x06003E7E RID: 15998 RVA: 0x001481B4 File Offset: 0x001463B4
		[Token(Token = "0x6003E7E")]
		[Address(RVA = "0x845FA0", Offset = "0x8445A0", VA = "0x180845FA0", Slot = "4")]
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

		// Token: 0x06003E7F RID: 15999 RVA: 0x00148234 File Offset: 0x00146434
		[Token(Token = "0x6003E7F")]
		[Address(RVA = "0x846180", Offset = "0x844780", VA = "0x180846180", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			return null;
		}

		// Token: 0x06003E80 RID: 16000 RVA: 0x00148244 File Offset: 0x00146444
		[Token(Token = "0x6003E80")]
		[Address(RVA = "0x8461C0", Offset = "0x8447C0", VA = "0x1808461C0", Slot = "7")]
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

		// Token: 0x06003E81 RID: 16001 RVA: 0x001482F4 File Offset: 0x001464F4
		[Token(Token = "0x6003E81")]
		[Address(RVA = "0x845D90", Offset = "0x844390", VA = "0x180845D90", Slot = "6")]
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

		// Token: 0x06003E82 RID: 16002 RVA: 0x00148358 File Offset: 0x00146558
		[Token(Token = "0x6003E82")]
		[Address(RVA = "0x846310", Offset = "0x844910", VA = "0x180846310")]
		public GivePlantShieldNode()
		{
		}

		// Token: 0x04002F38 RID: 12088
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002F38")]
		public string trigger_PortName = "触发";

		// Token: 0x04002F39 RID: 12089
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002F39")]
		public string plant_PortName = "植物";

		// Token: 0x04002F3A RID: 12090
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002F3A")]
		public string shieldAmount_PortName = "护盾值";

		// Token: 0x04002F3B RID: 12091
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002F3B")]
		[NonSerialized]
		private EventNodeBase plantSourceNode;

		// Token: 0x04002F3C RID: 12092
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002F3C")]
		[NonSerialized]
		private string plantSourcePort;

		// Token: 0x04002F3D RID: 12093
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002F3D")]
		[NonSerialized]
		private EventNodeBase shieldAmountSourceNode;

		// Token: 0x04002F3E RID: 12094
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002F3E")]
		[NonSerialized]
		private string shieldAmountSourcePort;
	}
}
