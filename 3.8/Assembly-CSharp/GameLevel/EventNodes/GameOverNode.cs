using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B7E RID: 2942
	[Token(Token = "0x2000B7E")]
	[Serializable]
	public class GameOverNode : EventNodeBase
	{
		// Token: 0x06003D49 RID: 15689 RVA: 0x00143840 File Offset: 0x00141A40
		[Token(Token = "0x6003D49")]
		[Address(RVA = "0x7C8030", Offset = "0x7C6630", VA = "0x1807C8030", Slot = "4")]
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

		// Token: 0x06003D4A RID: 15690 RVA: 0x001438A0 File Offset: 0x00141AA0
		[Token(Token = "0x6003D4A")]
		[Address(RVA = "0x7C81A0", Offset = "0x7C67A0", VA = "0x1807C81A0", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			return null;
		}

		// Token: 0x06003D4B RID: 15691 RVA: 0x001438B0 File Offset: 0x00141AB0
		[Token(Token = "0x6003D4B")]
		[Address(RVA = "0x7C81E0", Offset = "0x7C67E0", VA = "0x1807C81E0", Slot = "7")]
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

		// Token: 0x06003D4C RID: 15692 RVA: 0x00143910 File Offset: 0x00141B10
		[Token(Token = "0x6003D4C")]
		[Address(RVA = "0x7C7F40", Offset = "0x7C6540", VA = "0x1807C7F40", Slot = "6")]
		public override void Execute()
		{
			if (this.reasonSourceNode != (ulong)0L)
			{
			}
			EventNodeDebug.Log("[GameOverNode] 游戏结束，原因: " + "");
			UIMgr.EnterLoseMenu("");
		}

		// Token: 0x06003D4D RID: 15693 RVA: 0x00143948 File Offset: 0x00141B48
		[Token(Token = "0x6003D4D")]
		[Address(RVA = "0x7C82A0", Offset = "0x7C68A0", VA = "0x1807C82A0")]
		public GameOverNode()
		{
		}

		// Token: 0x04002DE4 RID: 11748
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002DE4")]
		public string trigger_PortName = "触发";

		// Token: 0x04002DE5 RID: 11749
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002DE5")]
		public string reason_PortName = "失败原因";

		// Token: 0x04002DE6 RID: 11750
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002DE6")]
		[NonSerialized]
		private EventNodeBase reasonSourceNode;

		// Token: 0x04002DE7 RID: 11751
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002DE7")]
		[NonSerialized]
		private string reasonSourcePort;
	}
}
