using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B88 RID: 2952
	[Token(Token = "0x2000B88")]
	[Serializable]
	public class PlaySoundNode : EventNodeBase
	{
		// Token: 0x06003D7F RID: 15743 RVA: 0x00144E38 File Offset: 0x00143038
		[Token(Token = "0x6003D7F")]
		[Address(RVA = "0x800FD0", Offset = "0x7FF5D0", VA = "0x180800FD0", Slot = "4")]
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
			PortDefinition portDefinition2 = new PortDefinition(this.soundId_PortName, (PortType)((uint)1), (PortDirection)num3);
			num3 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003D80 RID: 15744 RVA: 0x00144E98 File Offset: 0x00143098
		[Token(Token = "0x6003D80")]
		[Address(RVA = "0x801140", Offset = "0x7FF740", VA = "0x180801140", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			return null;
		}

		// Token: 0x06003D81 RID: 15745 RVA: 0x00144EA8 File Offset: 0x001430A8
		[Token(Token = "0x6003D81")]
		[Address(RVA = "0x801180", Offset = "0x7FF780", VA = "0x180801180", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.soundId_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.soundIdSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.soundIdSourcePort = sourcePortName;
		}

		// Token: 0x06003D82 RID: 15746 RVA: 0x00144F08 File Offset: 0x00143108
		[Token(Token = "0x6003D82")]
		[Address(RVA = "0x800E90", Offset = "0x7FF490", VA = "0x180800E90", Slot = "6")]
		public override void Execute()
		{
			if (this.soundIdSourceNode != (ulong)0L)
			{
			}
			int num = this.soundId;
			EventNodeDebug.Log(string.Format("[PlaySoundNode] 播放音效，音效ID: {0}", "[PlaySoundNode] 播放音效，音效ID: {0}"));
			GameAPP.PlaySound(num, 0.5f, 1f);
		}

		// Token: 0x06003D83 RID: 15747 RVA: 0x00144F4C File Offset: 0x0014314C
		[Token(Token = "0x6003D83")]
		[Address(RVA = "0x801240", Offset = "0x7FF840", VA = "0x180801240")]
		public PlaySoundNode()
		{
		}

		// Token: 0x04002E34 RID: 11828
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002E34")]
		public int soundId;

		// Token: 0x04002E35 RID: 11829
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002E35")]
		public string trigger_PortName = "触发";

		// Token: 0x04002E36 RID: 11830
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002E36")]
		public string soundId_PortName = "音效ID";

		// Token: 0x04002E37 RID: 11831
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002E37")]
		[NonSerialized]
		private EventNodeBase soundIdSourceNode;

		// Token: 0x04002E38 RID: 11832
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002E38")]
		[NonSerialized]
		private string soundIdSourcePort;
	}
}
