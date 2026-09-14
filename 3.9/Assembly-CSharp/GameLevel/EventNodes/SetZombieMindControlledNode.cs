using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BBD RID: 3005
	[Token(Token = "0x2000BBD")]
	[Serializable]
	public class SetZombieMindControlledNode : EventNodeBase
	{
		// Token: 0x06003E8D RID: 16013 RVA: 0x00148718 File Offset: 0x00146918
		[Token(Token = "0x6003E8D")]
		[Address(RVA = "0x8500B0", Offset = "0x84E6B0", VA = "0x1808500B0", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[2];
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
			return array;
		}

		// Token: 0x06003E8E RID: 16014 RVA: 0x00148778 File Offset: 0x00146978
		[Token(Token = "0x6003E8E")]
		[Address(RVA = "0x850220", Offset = "0x84E820", VA = "0x180850220", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			return null;
		}

		// Token: 0x06003E8F RID: 16015 RVA: 0x00148788 File Offset: 0x00146988
		[Token(Token = "0x6003E8F")]
		[Address(RVA = "0x850260", Offset = "0x84E860", VA = "0x180850260", Slot = "7")]
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
		}

		// Token: 0x06003E90 RID: 16016 RVA: 0x001487E8 File Offset: 0x001469E8
		[Token(Token = "0x6003E90")]
		[Address(RVA = "0x84FF50", Offset = "0x84E550", VA = "0x18084FF50", Slot = "6")]
		public override void Execute()
		{
			if (this.zombieSourceNode != (ulong)0L)
			{
			}
			int num = 0;
			int num2 = 0;
			if (!(num != num2))
			{
				string nodeId = this.nodeId;
				EventNodeDebug.LogWarning("[SetZombieMindControlledNode] 僵尸对象为空，无法魅惑，节点ID: " + nodeId);
				return;
			}
			EventNodeDebug.Log("[SetZombieMindControlledNode] 僵尸被魅惑");
		}

		// Token: 0x06003E91 RID: 16017 RVA: 0x0014883C File Offset: 0x00146A3C
		[Token(Token = "0x6003E91")]
		[Address(RVA = "0x850320", Offset = "0x84E920", VA = "0x180850320")]
		public SetZombieMindControlledNode()
		{
		}

		// Token: 0x04002F4B RID: 12107
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002F4B")]
		public string trigger_PortName = "触发";

		// Token: 0x04002F4C RID: 12108
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002F4C")]
		public string zombie_PortName = "僵尸";

		// Token: 0x04002F4D RID: 12109
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002F4D")]
		[NonSerialized]
		private EventNodeBase zombieSourceNode;

		// Token: 0x04002F4E RID: 12110
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002F4E")]
		[NonSerialized]
		private string zombieSourcePort;
	}
}
