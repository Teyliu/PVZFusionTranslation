using System;
using System.Collections.Generic;
using System.Threading;
using Cpp2IlInjected;
using Cysharp.Threading.Tasks;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BEE RID: 3054
	[Token(Token = "0x2000BEE")]
	[Serializable]
	public class WaitNode : EventNodeBase
	{
		// Token: 0x06003F86 RID: 16262 RVA: 0x0014D6D4 File Offset: 0x0014B8D4
		[Token(Token = "0x6003F86")]
		[Address(RVA = "0x8721A0", Offset = "0x8707A0", VA = "0x1808721A0", Slot = "4")]
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
			PortDefinition portDefinition2 = new PortDefinition(this.duration_PortName, (PortType)((uint)3), (PortDirection)num3);
			num3 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003F87 RID: 16263 RVA: 0x0014D734 File Offset: 0x0014B934
		[Token(Token = "0x6003F87")]
		[Address(RVA = "0x872310", Offset = "0x870910", VA = "0x180872310", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.output_PortName, (PortType)num, (PortDirection)((uint)1));
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003F88 RID: 16264 RVA: 0x0014D76C File Offset: 0x0014B96C
		[Token(Token = "0x6003F88")]
		[Address(RVA = "0x872400", Offset = "0x870A00", VA = "0x180872400", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.duration_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.durationSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.durationSourcePort = sourcePortName;
			string text2 = this.output_PortName;
			string nodeId2 = this.nodeId;
			List<EventNodeBase> connectedNodes = graph.GetConnectedNodes(nodeId2, text2);
			this.outputTargets = connectedNodes;
			throw new NullReferenceException();
		}

		// Token: 0x06003F89 RID: 16265 RVA: 0x0014D7EC File Offset: 0x0014B9EC
		[Token(Token = "0x6003F89")]
		[Address(RVA = "0x871FD0", Offset = "0x8705D0", VA = "0x180871FD0", Slot = "6")]
		public override void Execute()
		{
			if (this.durationSourceNode != (ulong)0L)
			{
			}
			EventNodeDebug.Log(string.Format("[WaitNode] 开始等待 {0} 秒", "[WaitNode] 开始等待 {0} 秒"));
			Board instance = Board.Instance;
			int num = 0;
			if (!(instance != num))
			{
				int gbufferAlbedoIndex = 0.GBufferAlbedoIndex;
			}
			CancellationToken cancellationTokenOnDestroy = instance.GetCancellationTokenOnDestroy();
			EventNodeManager instance2 = EventNodeManager.Instance;
			string text = this.output_PortName;
			string nodeId = this.nodeId;
			instance2.StartWaitTask(nodeId, text, 1f, cancellationTokenOnDestroy);
		}

		// Token: 0x06003F8A RID: 16266 RVA: 0x0014D86C File Offset: 0x0014BA6C
		[Token(Token = "0x6003F8A")]
		[Address(RVA = "0x872500", Offset = "0x870B00", VA = "0x180872500")]
		public WaitNode()
		{
			List<EventNodeBase> list = new List();
			this.outputTargets = list;
			base..ctor();
		}

		// Token: 0x0400304D RID: 12365
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400304D")]
		public string trigger_PortName = "触发";

		// Token: 0x0400304E RID: 12366
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400304E")]
		public string duration_PortName = "等待时间";

		// Token: 0x0400304F RID: 12367
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400304F")]
		public string output_PortName = "触发";

		// Token: 0x04003050 RID: 12368
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4003050")]
		[NonSerialized]
		private EventNodeBase durationSourceNode;

		// Token: 0x04003051 RID: 12369
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4003051")]
		[NonSerialized]
		private string durationSourcePort;

		// Token: 0x04003052 RID: 12370
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4003052")]
		[NonSerialized]
		private List<EventNodeBase> outputTargets;
	}
}
