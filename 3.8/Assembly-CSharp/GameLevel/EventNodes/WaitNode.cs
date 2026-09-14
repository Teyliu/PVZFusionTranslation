using System;
using System.Collections.Generic;
using System.Threading;
using Cpp2IlInjected;
using Cysharp.Threading.Tasks;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BAC RID: 2988
	[Token(Token = "0x2000BAC")]
	[Serializable]
	public class WaitNode : EventNodeBase
	{
		// Token: 0x06003E35 RID: 15925 RVA: 0x00148460 File Offset: 0x00146660
		[Token(Token = "0x6003E35")]
		[Address(RVA = "0x80A7B0", Offset = "0x808DB0", VA = "0x18080A7B0", Slot = "4")]
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

		// Token: 0x06003E36 RID: 15926 RVA: 0x001484C0 File Offset: 0x001466C0
		[Token(Token = "0x6003E36")]
		[Address(RVA = "0x80A920", Offset = "0x808F20", VA = "0x18080A920", Slot = "5")]
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

		// Token: 0x06003E37 RID: 15927 RVA: 0x001484F8 File Offset: 0x001466F8
		[Token(Token = "0x6003E37")]
		[Address(RVA = "0x80AA10", Offset = "0x809010", VA = "0x18080AA10", Slot = "7")]
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

		// Token: 0x06003E38 RID: 15928 RVA: 0x00148578 File Offset: 0x00146778
		[Token(Token = "0x6003E38")]
		[Address(RVA = "0x80A5E0", Offset = "0x808BE0", VA = "0x18080A5E0", Slot = "6")]
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
				CancellationToken none = CancellationToken.None;
			}
			CancellationToken cancellationTokenOnDestroy = instance.GetCancellationTokenOnDestroy();
			EventNodeManager instance2 = EventNodeManager.Instance;
			string text = this.output_PortName;
			string nodeId = this.nodeId;
			instance2.StartWaitTask(nodeId, text, 1f, cancellationTokenOnDestroy);
		}

		// Token: 0x06003E39 RID: 15929 RVA: 0x001485FC File Offset: 0x001467FC
		[Token(Token = "0x6003E39")]
		[Address(RVA = "0x80AB10", Offset = "0x809110", VA = "0x18080AB10")]
		public WaitNode()
		{
			List<EventNodeBase> list = new List();
			this.outputTargets = list;
			base..ctor();
		}

		// Token: 0x04002ED9 RID: 11993
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002ED9")]
		public string trigger_PortName = "触发";

		// Token: 0x04002EDA RID: 11994
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002EDA")]
		public string duration_PortName = "等待时间";

		// Token: 0x04002EDB RID: 11995
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002EDB")]
		public string output_PortName = "触发";

		// Token: 0x04002EDC RID: 11996
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002EDC")]
		[NonSerialized]
		private EventNodeBase durationSourceNode;

		// Token: 0x04002EDD RID: 11997
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002EDD")]
		[NonSerialized]
		private string durationSourcePort;

		// Token: 0x04002EDE RID: 11998
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002EDE")]
		[NonSerialized]
		private List<EventNodeBase> outputTargets;
	}
}
