using System;
using System.Collections.Generic;
using System.Threading;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BB1 RID: 2993
	[Token(Token = "0x2000BB1")]
	[Serializable]
	public class ToggleCycleNode : EventNodeBase
	{
		// Token: 0x06003E4F RID: 15951 RVA: 0x00148DD0 File Offset: 0x00146FD0
		[Token(Token = "0x6003E4F")]
		[Address(RVA = "0x808130", Offset = "0x806730", VA = "0x180808130", Slot = "4")]
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
			PortDefinition portDefinition2 = new PortDefinition(this.interval_PortName, (PortType)((uint)3), (PortDirection)num3);
			num3 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003E50 RID: 15952 RVA: 0x00148E30 File Offset: 0x00147030
		[Token(Token = "0x6003E50")]
		[Address(RVA = "0x8082A0", Offset = "0x8068A0", VA = "0x1808082A0", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[3];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.cycle_PortName, (PortType)num, (PortDirection)((uint)1));
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			int num2;
			PortDefinition portDefinition2 = new PortDefinition(this.onEnable_PortName, (PortType)num2, (PortDirection)((uint)1));
			num2 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			int num3;
			PortDefinition portDefinition3 = new PortDefinition(this.onDisable_PortName, (PortType)num3, (PortDirection)((uint)1));
			num3 = 0;
			if (portDefinition3 != 0)
			{
			}
			array[2] = portDefinition3;
			return array;
		}

		// Token: 0x06003E51 RID: 15953 RVA: 0x00148EAC File Offset: 0x001470AC
		[Token(Token = "0x6003E51")]
		[Address(RVA = "0x808480", Offset = "0x806A80", VA = "0x180808480", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.interval_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.intervalSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.intervalSourcePort = sourcePortName;
			string text2 = this.cycle_PortName;
			string nodeId2 = this.nodeId;
			List<EventNodeBase> connectedNodes = graph.GetConnectedNodes(nodeId2, text2);
			this.cycleTargets = connectedNodes;
			string text3 = this.onEnable_PortName;
			string nodeId3 = this.nodeId;
			List<EventNodeBase> connectedNodes2 = graph.GetConnectedNodes(nodeId3, text3);
			this.onEnableTargets = connectedNodes2;
			string text4 = this.onDisable_PortName;
			string nodeId4 = this.nodeId;
			List<EventNodeBase> connectedNodes3 = graph.GetConnectedNodes(nodeId4, text4);
			this.onDisableTargets = connectedNodes3;
			throw new NullReferenceException();
		}

		// Token: 0x06003E52 RID: 15954 RVA: 0x00148F74 File Offset: 0x00147174
		[Token(Token = "0x6003E52")]
		[Address(RVA = "0x807C10", Offset = "0x806210", VA = "0x180807C10", Slot = "6")]
		public override void Execute()
		{
			for (;;)
			{
				int num = 0;
				if (this.intervalSourceNode != num)
				{
					num += 20;
					num += num;
				}
				bool flag = this.isEnabled;
				bool flag2 = !flag;
				this.isEnabled = flag2;
				if (flag)
				{
					break;
				}
				bool flag3;
				string text = string.Format("[ToggleCycleNode] 切换到开启状态，周期间隔: {0}秒", flag3);
				EventNodeDebug.Log(text);
				bool flag4;
				if (flag4)
				{
				}
				ulong num2;
				if (num2 == (ulong)0L)
				{
					goto Block_3;
				}
			}
			EventNodeDebug.Log("[ToggleCycleNode] 切换到关闭状态");
			List<EventNodeBase> list = this.onDisableTargets;
			bool flag5;
			if (flag5)
			{
			}
			ulong num3;
			if (num3 == (ulong)0L)
			{
				return;
			}
			throw new NullReferenceException();
			Block_3:
			Board instance = Board.Instance;
			int num4 = 0;
			if (!(instance != num4))
			{
				CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
			}
			CancellationToken cancellationToken;
			CancellationTokenSource cancellationTokenSource2 = CancellationTokenSource.CreateLinkedTokenSource(new CancellationToken[] { cancellationToken });
			EventNodeManager instance2 = EventNodeManager.Instance;
			throw new NullReferenceException();
		}

		// Token: 0x06003E53 RID: 15955 RVA: 0x00149048 File Offset: 0x00147248
		[Token(Token = "0x6003E53")]
		[Address(RVA = "0x8085C0", Offset = "0x806BC0", VA = "0x1808085C0")]
		public ToggleCycleNode()
		{
			List<EventNodeBase> list = new List();
			this.cycleTargets = list;
			List<EventNodeBase> list2 = new List();
			this.onEnableTargets = list2;
			List<EventNodeBase> list3 = new List();
			this.onDisableTargets = list3;
			base..ctor();
		}

		// Token: 0x04002EF9 RID: 12025
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002EF9")]
		public string trigger_PortName = "触发";

		// Token: 0x04002EFA RID: 12026
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002EFA")]
		public string interval_PortName = "周期间隔";

		// Token: 0x04002EFB RID: 12027
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002EFB")]
		public string cycle_PortName = "周期事件";

		// Token: 0x04002EFC RID: 12028
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002EFC")]
		public string onEnable_PortName = "切换开始时";

		// Token: 0x04002EFD RID: 12029
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002EFD")]
		public string onDisable_PortName = "切换关闭时";

		// Token: 0x04002EFE RID: 12030
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002EFE")]
		[NonSerialized]
		private EventNodeBase intervalSourceNode;

		// Token: 0x04002EFF RID: 12031
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002EFF")]
		[NonSerialized]
		private string intervalSourcePort;

		// Token: 0x04002F00 RID: 12032
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002F00")]
		[NonSerialized]
		private List<EventNodeBase> cycleTargets;

		// Token: 0x04002F01 RID: 12033
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002F01")]
		[NonSerialized]
		private List<EventNodeBase> onEnableTargets;

		// Token: 0x04002F02 RID: 12034
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002F02")]
		[NonSerialized]
		private List<EventNodeBase> onDisableTargets;

		// Token: 0x04002F03 RID: 12035
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4002F03")]
		[NonSerialized]
		private bool isEnabled;

		// Token: 0x04002F04 RID: 12036
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4002F04")]
		[NonSerialized]
		private CancellationTokenSource cancellationTokenSource;
	}
}
