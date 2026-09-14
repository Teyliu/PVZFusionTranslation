using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BB5 RID: 2997
	[Token(Token = "0x2000BB5")]
	[Serializable]
	public class DamageZombieNode : EventNodeBase
	{
		// Token: 0x06003E65 RID: 15973 RVA: 0x00147754 File Offset: 0x00145954
		[Token(Token = "0x6003E65")]
		[Address(RVA = "0x83F450", Offset = "0x83DA50", VA = "0x18083F450", Slot = "4")]
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

		// Token: 0x06003E66 RID: 15974 RVA: 0x001477D4 File Offset: 0x001459D4
		[Token(Token = "0x6003E66")]
		[Address(RVA = "0x83F630", Offset = "0x83DC30", VA = "0x18083F630", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			return null;
		}

		// Token: 0x06003E67 RID: 15975 RVA: 0x001477E4 File Offset: 0x001459E4
		[Token(Token = "0x6003E67")]
		[Address(RVA = "0x83F670", Offset = "0x83DC70", VA = "0x18083F670", Slot = "7")]
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

		// Token: 0x06003E68 RID: 15976 RVA: 0x00147894 File Offset: 0x00145A94
		[Token(Token = "0x6003E68")]
		[Address(RVA = "0x83F240", Offset = "0x83D840", VA = "0x18083F240", Slot = "6")]
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

		// Token: 0x06003E69 RID: 15977 RVA: 0x001478F4 File Offset: 0x00145AF4
		[Token(Token = "0x6003E69")]
		[Address(RVA = "0x83F7C0", Offset = "0x83DDC0", VA = "0x18083F7C0")]
		public DamageZombieNode()
		{
		}

		// Token: 0x04002F0F RID: 12047
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002F0F")]
		public string trigger_PortName = "触发";

		// Token: 0x04002F10 RID: 12048
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002F10")]
		public string zombie_PortName = "僵尸";

		// Token: 0x04002F11 RID: 12049
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002F11")]
		public string damage_PortName = "伤害值";

		// Token: 0x04002F12 RID: 12050
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002F12")]
		[NonSerialized]
		private EventNodeBase zombieSourceNode;

		// Token: 0x04002F13 RID: 12051
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002F13")]
		[NonSerialized]
		private string zombieSourcePort;

		// Token: 0x04002F14 RID: 12052
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002F14")]
		[NonSerialized]
		private EventNodeBase damageSourceNode;

		// Token: 0x04002F15 RID: 12053
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002F15")]
		[NonSerialized]
		private string damageSourcePort;
	}
}
