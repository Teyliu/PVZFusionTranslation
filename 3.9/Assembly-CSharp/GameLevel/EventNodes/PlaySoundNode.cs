using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BCA RID: 3018
	[Token(Token = "0x2000BCA")]
	[Serializable]
	public class PlaySoundNode : EventNodeBase
	{
		// Token: 0x06003ED0 RID: 16080 RVA: 0x0014A0CC File Offset: 0x001482CC
		[Token(Token = "0x6003ED0")]
		[Address(RVA = "0x868980", Offset = "0x866F80", VA = "0x180868980", Slot = "4")]
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

		// Token: 0x06003ED1 RID: 16081 RVA: 0x0014A12C File Offset: 0x0014832C
		[Token(Token = "0x6003ED1")]
		[Address(RVA = "0x868AF0", Offset = "0x8670F0", VA = "0x180868AF0", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			return null;
		}

		// Token: 0x06003ED2 RID: 16082 RVA: 0x0014A13C File Offset: 0x0014833C
		[Token(Token = "0x6003ED2")]
		[Address(RVA = "0x868B30", Offset = "0x867130", VA = "0x180868B30", Slot = "7")]
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

		// Token: 0x06003ED3 RID: 16083 RVA: 0x0014A19C File Offset: 0x0014839C
		[Token(Token = "0x6003ED3")]
		[Address(RVA = "0x868840", Offset = "0x866E40", VA = "0x180868840", Slot = "6")]
		public override void Execute()
		{
			if (this.soundIdSourceNode != (ulong)0L)
			{
			}
			int num = this.soundId;
			EventNodeDebug.Log(string.Format("[PlaySoundNode] 播放音效，音效ID: {0}", "[PlaySoundNode] 播放音效，音效ID: {0}"));
			GameAPP.PlaySound(num, 0.5f, 1f);
		}

		// Token: 0x06003ED4 RID: 16084 RVA: 0x0014A1E0 File Offset: 0x001483E0
		[Token(Token = "0x6003ED4")]
		[Address(RVA = "0x868BF0", Offset = "0x8671F0", VA = "0x180868BF0")]
		public PlaySoundNode()
		{
		}

		// Token: 0x04002FA8 RID: 12200
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002FA8")]
		public int soundId;

		// Token: 0x04002FA9 RID: 12201
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002FA9")]
		public string trigger_PortName = "触发";

		// Token: 0x04002FAA RID: 12202
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002FAA")]
		public string soundId_PortName = "音效ID";

		// Token: 0x04002FAB RID: 12203
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002FAB")]
		[NonSerialized]
		private EventNodeBase soundIdSourceNode;

		// Token: 0x04002FAC RID: 12204
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002FAC")]
		[NonSerialized]
		private string soundIdSourcePort;
	}
}
