using System;
using System.Collections.Generic;
using System.Threading;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BF3 RID: 3059
	[Token(Token = "0x2000BF3")]
	[Serializable]
	public class ToggleCycleNode : EventNodeBase
	{
		// Token: 0x06003FA0 RID: 16288 RVA: 0x0014E040 File Offset: 0x0014C240
		[Token(Token = "0x6003FA0")]
		[Address(RVA = "0x86FAE0", Offset = "0x86E0E0", VA = "0x18086FAE0", Slot = "4")]
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

		// Token: 0x06003FA1 RID: 16289 RVA: 0x0014E0A0 File Offset: 0x0014C2A0
		[Token(Token = "0x6003FA1")]
		[Address(RVA = "0x86FC50", Offset = "0x86E250", VA = "0x18086FC50", Slot = "5")]
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

		// Token: 0x06003FA2 RID: 16290 RVA: 0x0014E11C File Offset: 0x0014C31C
		[Token(Token = "0x6003FA2")]
		[Address(RVA = "0x86FE30", Offset = "0x86E430", VA = "0x18086FE30", Slot = "7")]
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

		// Token: 0x06003FA3 RID: 16291 RVA: 0x0014E1E4 File Offset: 0x0014C3E4
		[Token(Token = "0x6003FA3")]
		[Address(RVA = "0x86F5C0", Offset = "0x86DBC0", VA = "0x18086F5C0", Slot = "6")]
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

		// Token: 0x06003FA4 RID: 16292 RVA: 0x0014E2B8 File Offset: 0x0014C4B8
		[Token(Token = "0x6003FA4")]
		[Address(RVA = "0x86FF70", Offset = "0x86E570", VA = "0x18086FF70")]
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

		// Token: 0x0400306D RID: 12397
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400306D")]
		public string trigger_PortName = "触发";

		// Token: 0x0400306E RID: 12398
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400306E")]
		public string interval_PortName = "周期间隔";

		// Token: 0x0400306F RID: 12399
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400306F")]
		public string cycle_PortName = "周期事件";

		// Token: 0x04003070 RID: 12400
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4003070")]
		public string onEnable_PortName = "切换开始时";

		// Token: 0x04003071 RID: 12401
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4003071")]
		public string onDisable_PortName = "切换关闭时";

		// Token: 0x04003072 RID: 12402
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4003072")]
		[NonSerialized]
		private EventNodeBase intervalSourceNode;

		// Token: 0x04003073 RID: 12403
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4003073")]
		[NonSerialized]
		private string intervalSourcePort;

		// Token: 0x04003074 RID: 12404
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4003074")]
		[NonSerialized]
		private List<EventNodeBase> cycleTargets;

		// Token: 0x04003075 RID: 12405
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4003075")]
		[NonSerialized]
		private List<EventNodeBase> onEnableTargets;

		// Token: 0x04003076 RID: 12406
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4003076")]
		[NonSerialized]
		private List<EventNodeBase> onDisableTargets;

		// Token: 0x04003077 RID: 12407
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4003077")]
		[NonSerialized]
		private bool isEnabled;

		// Token: 0x04003078 RID: 12408
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4003078")]
		[NonSerialized]
		private CancellationTokenSource cancellationTokenSource;
	}
}
