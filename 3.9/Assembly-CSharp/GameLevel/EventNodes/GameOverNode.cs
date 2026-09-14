using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BC0 RID: 3008
	[Token(Token = "0x2000BC0")]
	[Serializable]
	public class GameOverNode : EventNodeBase
	{
		// Token: 0x06003E9A RID: 16026 RVA: 0x00148AE0 File Offset: 0x00146CE0
		[Token(Token = "0x6003E9A")]
		[Address(RVA = "0x844390", Offset = "0x842990", VA = "0x180844390", Slot = "4")]
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
			PortDefinition portDefinition2 = new PortDefinition(this.reason_PortName, (PortType)((uint)5), (PortDirection)num3);
			num3 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003E9B RID: 16027 RVA: 0x00148B40 File Offset: 0x00146D40
		[Token(Token = "0x6003E9B")]
		[Address(RVA = "0x844500", Offset = "0x842B00", VA = "0x180844500", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			return null;
		}

		// Token: 0x06003E9C RID: 16028 RVA: 0x00148B50 File Offset: 0x00146D50
		[Token(Token = "0x6003E9C")]
		[Address(RVA = "0x844540", Offset = "0x842B40", VA = "0x180844540", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.reason_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.reasonSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.reasonSourcePort = sourcePortName;
		}

		// Token: 0x06003E9D RID: 16029 RVA: 0x00148BB0 File Offset: 0x00146DB0
		[Token(Token = "0x6003E9D")]
		[Address(RVA = "0x8442A0", Offset = "0x8428A0", VA = "0x1808442A0", Slot = "6")]
		public override void Execute()
		{
			if (this.reasonSourceNode != (ulong)0L)
			{
			}
			EventNodeDebug.Log("[GameOverNode] 游戏结束，原因: " + "");
			UIMgr.EnterLoseMenu("");
		}

		// Token: 0x06003E9E RID: 16030 RVA: 0x00148BE8 File Offset: 0x00146DE8
		[Token(Token = "0x6003E9E")]
		[Address(RVA = "0x844600", Offset = "0x842C00", VA = "0x180844600")]
		public GameOverNode()
		{
		}

		// Token: 0x04002F58 RID: 12120
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002F58")]
		public string trigger_PortName = "触发";

		// Token: 0x04002F59 RID: 12121
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002F59")]
		public string reason_PortName = "失败原因";

		// Token: 0x04002F5A RID: 12122
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002F5A")]
		[NonSerialized]
		private EventNodeBase reasonSourceNode;

		// Token: 0x04002F5B RID: 12123
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002F5B")]
		[NonSerialized]
		private string reasonSourcePort;
	}
}
