using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B73 RID: 2931
	[Token(Token = "0x2000B73")]
	[Serializable]
	public class DamageZombieNode : EventNodeBase
	{
		// Token: 0x06003D14 RID: 15636 RVA: 0x001424C0 File Offset: 0x001406C0
		[Token(Token = "0x6003D14")]
		[Address(RVA = "0x7C30F0", Offset = "0x7C16F0", VA = "0x1807C30F0", Slot = "4")]
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
			PortDefinition portDefinition2 = new PortDefinition(this.zombie_PortName, (PortType)((uint)12), (PortDirection)num3);
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

		// Token: 0x06003D15 RID: 15637 RVA: 0x00142540 File Offset: 0x00140740
		[Token(Token = "0x6003D15")]
		[Address(RVA = "0x7C32D0", Offset = "0x7C18D0", VA = "0x1807C32D0", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			return null;
		}

		// Token: 0x06003D16 RID: 15638 RVA: 0x00142550 File Offset: 0x00140750
		[Token(Token = "0x6003D16")]
		[Address(RVA = "0x7C3310", Offset = "0x7C1910", VA = "0x1807C3310", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.zombie_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.zombieSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.zombieSourcePort = sourcePortName;
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

		// Token: 0x06003D17 RID: 15639 RVA: 0x00142600 File Offset: 0x00140800
		[Token(Token = "0x6003D17")]
		[Address(RVA = "0x7C2EE0", Offset = "0x7C14E0", VA = "0x1807C2EE0", Slot = "6")]
		public override void Execute()
		{
			int num = 0;
			if (this.zombieSourceNode != num)
			{
			}
			if (this.damageSourceNode != num)
			{
			}
			int num2 = 0;
			if (!(num != num2))
			{
				string nodeId = this.nodeId;
				EventNodeDebug.LogWarning("[DamageZombieNode] 僵尸对象为空，无法造成伤害，节点ID: " + nodeId);
				return;
			}
			int num3;
			EventNodeDebug.Log(string.Format("[DamageZombieNode] 对僵尸造成 {0} 点伤害", num3));
		}

		// Token: 0x06003D18 RID: 15640 RVA: 0x00142660 File Offset: 0x00140860
		[Token(Token = "0x6003D18")]
		[Address(RVA = "0x7C3460", Offset = "0x7C1A60", VA = "0x1807C3460")]
		public DamageZombieNode()
		{
		}

		// Token: 0x04002D9B RID: 11675
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002D9B")]
		public string trigger_PortName = "触发";

		// Token: 0x04002D9C RID: 11676
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002D9C")]
		public string zombie_PortName = "僵尸";

		// Token: 0x04002D9D RID: 11677
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002D9D")]
		public string damage_PortName = "伤害值";

		// Token: 0x04002D9E RID: 11678
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002D9E")]
		[NonSerialized]
		private EventNodeBase zombieSourceNode;

		// Token: 0x04002D9F RID: 11679
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002D9F")]
		[NonSerialized]
		private string zombieSourcePort;

		// Token: 0x04002DA0 RID: 11680
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002DA0")]
		[NonSerialized]
		private EventNodeBase damageSourceNode;

		// Token: 0x04002DA1 RID: 11681
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002DA1")]
		[NonSerialized]
		private string damageSourcePort;
	}
}
