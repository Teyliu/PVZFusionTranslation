using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B7B RID: 2939
	[Token(Token = "0x2000B7B")]
	[Serializable]
	public class SetZombieMindControlledNode : EventNodeBase
	{
		// Token: 0x06003D3C RID: 15676 RVA: 0x00143484 File Offset: 0x00141684
		[Token(Token = "0x6003D3C")]
		[Address(RVA = "0x7D3D50", Offset = "0x7D2350", VA = "0x1807D3D50", Slot = "4")]
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

		// Token: 0x06003D3D RID: 15677 RVA: 0x001434E4 File Offset: 0x001416E4
		[Token(Token = "0x6003D3D")]
		[Address(RVA = "0x7D3EC0", Offset = "0x7D24C0", VA = "0x1807D3EC0", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			return null;
		}

		// Token: 0x06003D3E RID: 15678 RVA: 0x001434F4 File Offset: 0x001416F4
		[Token(Token = "0x6003D3E")]
		[Address(RVA = "0x7D3F00", Offset = "0x7D2500", VA = "0x1807D3F00", Slot = "7")]
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

		// Token: 0x06003D3F RID: 15679 RVA: 0x00143554 File Offset: 0x00141754
		[Token(Token = "0x6003D3F")]
		[Address(RVA = "0x7D3BF0", Offset = "0x7D21F0", VA = "0x1807D3BF0", Slot = "6")]
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

		// Token: 0x06003D40 RID: 15680 RVA: 0x001435A8 File Offset: 0x001417A8
		[Token(Token = "0x6003D40")]
		[Address(RVA = "0x7D3FC0", Offset = "0x7D25C0", VA = "0x1807D3FC0")]
		public SetZombieMindControlledNode()
		{
		}

		// Token: 0x04002DD7 RID: 11735
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002DD7")]
		public string trigger_PortName = "触发";

		// Token: 0x04002DD8 RID: 11736
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002DD8")]
		public string zombie_PortName = "僵尸";

		// Token: 0x04002DD9 RID: 11737
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002DD9")]
		[NonSerialized]
		private EventNodeBase zombieSourceNode;

		// Token: 0x04002DDA RID: 11738
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002DDA")]
		[NonSerialized]
		private string zombieSourcePort;
	}
}
