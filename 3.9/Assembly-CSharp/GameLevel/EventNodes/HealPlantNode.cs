using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BAE RID: 2990
	[Token(Token = "0x2000BAE")]
	[Serializable]
	public class HealPlantNode : EventNodeBase
	{
		// Token: 0x06003E3E RID: 15934 RVA: 0x0014655C File Offset: 0x0014475C
		[Token(Token = "0x6003E3E")]
		[Address(RVA = "0x846770", Offset = "0x844D70", VA = "0x180846770", Slot = "4")]
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
			PortDefinition portDefinition3 = new PortDefinition(this.healAmount_PortName, (PortType)((uint)3), (PortDirection)num4);
			num4 = 0;
			if (portDefinition3 != 0)
			{
			}
			array[2] = portDefinition3;
			return array;
		}

		// Token: 0x06003E3F RID: 15935 RVA: 0x001465DC File Offset: 0x001447DC
		[Token(Token = "0x6003E3F")]
		[Address(RVA = "0x846950", Offset = "0x844F50", VA = "0x180846950", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			return null;
		}

		// Token: 0x06003E40 RID: 15936 RVA: 0x001465EC File Offset: 0x001447EC
		[Token(Token = "0x6003E40")]
		[Address(RVA = "0x846990", Offset = "0x844F90", VA = "0x180846990", Slot = "7")]
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
			string text2 = this.healAmount_PortName;
			string nodeId2 = this.nodeId;
			List<SourcePortInfo> sourceNodes2 = graph.GetSourceNodes(nodeId2, text2);
			int num3 = 0;
			EventNodeBase sourceNode2 = sourceNodes2[num3].sourceNode;
			this.healAmountSourceNode = sourceNode2;
			int num4 = 0;
			string sourcePortName2 = sourceNodes2[num4].sourcePortName;
			this.healAmountSourcePort = sourcePortName2;
			string text3 = this.onHealed_PortName;
			string nodeId3 = this.nodeId;
			List<EventNodeBase> connectedNodes = graph.GetConnectedNodes(nodeId3, text3);
			this.onHealedTargets = connectedNodes;
			throw new NullReferenceException();
		}

		// Token: 0x06003E41 RID: 15937 RVA: 0x001466C0 File Offset: 0x001448C0
		[Token(Token = "0x6003E41")]
		[Address(RVA = "0x846560", Offset = "0x844B60", VA = "0x180846560", Slot = "6")]
		public override void Execute()
		{
			if (this.plantSourceNode != (ulong)0L)
			{
			}
			int num = 0;
			if (this.healAmountSourceNode != (ulong)0L)
			{
			}
			int num2 = 0;
			if (!(num != num2))
			{
				string nodeId = this.nodeId;
				EventNodeDebug.LogWarning("[HealPlantNode] 植物对象为空，无法回血，节点ID: " + nodeId);
				return;
			}
			bool flag;
			EventNodeDebug.Log(string.Format("[HealPlantNode] 为植物回血 {0} 点", flag));
			throw new NullReferenceException();
		}

		// Token: 0x06003E42 RID: 15938 RVA: 0x00146720 File Offset: 0x00144920
		[Token(Token = "0x6003E42")]
		[Address(RVA = "0x846B00", Offset = "0x845100", VA = "0x180846B00")]
		public HealPlantNode()
		{
			List<EventNodeBase> list = new List();
			this.onHealedTargets = list;
			base..ctor();
		}

		// Token: 0x04002ECA RID: 11978
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002ECA")]
		public string trigger_PortName = "触发";

		// Token: 0x04002ECB RID: 11979
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002ECB")]
		public string plant_PortName = "植物";

		// Token: 0x04002ECC RID: 11980
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002ECC")]
		public string healAmount_PortName = "回血量";

		// Token: 0x04002ECD RID: 11981
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002ECD")]
		public string onHealed_PortName = "回血成功";

		// Token: 0x04002ECE RID: 11982
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002ECE")]
		[NonSerialized]
		private EventNodeBase plantSourceNode;

		// Token: 0x04002ECF RID: 11983
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002ECF")]
		[NonSerialized]
		private string plantSourcePort;

		// Token: 0x04002ED0 RID: 11984
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002ED0")]
		[NonSerialized]
		private EventNodeBase healAmountSourceNode;

		// Token: 0x04002ED1 RID: 11985
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002ED1")]
		[NonSerialized]
		private string healAmountSourcePort;

		// Token: 0x04002ED2 RID: 11986
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002ED2")]
		[NonSerialized]
		private List<EventNodeBase> onHealedTargets;
	}
}
