using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000C1C RID: 3100
	[Token(Token = "0x2000C1C")]
	[Serializable]
	public class CounterNode : EventNodeBase
	{
		// Token: 0x06004071 RID: 16497 RVA: 0x0015326C File Offset: 0x0015146C
		[Token(Token = "0x6004071")]
		[Address(RVA = "0x859360", Offset = "0x857960", VA = "0x180859360", Slot = "4")]
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
			PortDefinition portDefinition2 = new PortDefinition(this.shouldReset_PortName, (PortType)((uint)6), (PortDirection)num3);
			num3 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06004072 RID: 16498 RVA: 0x001532CC File Offset: 0x001514CC
		[Token(Token = "0x6004072")]
		[Address(RVA = "0x8594D0", Offset = "0x857AD0", VA = "0x1808594D0", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[2];
			PortDefinition portDefinition = new PortDefinition(this.count_PortName, (PortType)((uint)1), (PortDirection)((uint)1));
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			int num;
			PortDefinition portDefinition2 = new PortDefinition(this.onCount_PortName, (PortType)num, (PortDirection)((uint)1));
			num = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06004073 RID: 16499 RVA: 0x00153324 File Offset: 0x00151524
		[Token(Token = "0x6004073")]
		[Address(RVA = "0x859640", Offset = "0x857C40", VA = "0x180859640", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.onCount_PortName;
			string nodeId = this.nodeId;
			List<EventNodeBase> connectedNodes = graph.GetConnectedNodes(nodeId, text);
			this.onCountTargets = connectedNodes;
			string text2 = this.shouldReset_PortName;
			string nodeId2 = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId2, text2);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.shouldResetSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.shouldResetSourcePort = sourcePortName;
		}

		// Token: 0x06004074 RID: 16500 RVA: 0x001533A8 File Offset: 0x001515A8
		[Token(Token = "0x6004074")]
		[Address(RVA = "0x8590C0", Offset = "0x8576C0", VA = "0x1808590C0", Slot = "6")]
		public override void Execute()
		{
			ulong num6;
			do
			{
				int num = 0;
				if ((this.initialized ? 1 : 0) == num)
				{
					int num2 = this.startValue;
					this.currentCount = num2;
					this.initialized = true;
					EventNodeDebug.Log(string.Format("[CounterNode] 计数器初始化，起始值: {0}", num2));
				}
				if (this.shouldResetSourceNode != (ulong)0L)
				{
					num += 20;
					num += num;
					if (num != 0)
					{
						this.currentCount = (int)((ulong)0L);
					}
				}
				int num3 = this.currentCount;
				int num4 = num3 + 1;
				this.currentCount = num4;
				int num5 = num3 + 1;
				EventNodeDebug.Log(string.Format("[CounterNode] 计数器递增，当前值: {0}", num5));
				List<EventNodeBase> list = this.onCountTargets;
				bool flag;
				if (flag)
				{
				}
			}
			while (num6 != (ulong)0L);
		}

		// Token: 0x06004075 RID: 16501 RVA: 0x00153450 File Offset: 0x00151650
		[Token(Token = "0x6004075")]
		[Address(RVA = "0x9FFBD0", Offset = "0x9FE1D0", VA = "0x1809FFBD0", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06004076 RID: 16502 RVA: 0x00153494 File Offset: 0x00151694
		[Token(Token = "0x6004076")]
		[Address(RVA = "0x859730", Offset = "0x857D30", VA = "0x180859730")]
		public void Reset()
		{
			int num = this.startValue;
			this.currentCount = num;
			this.initialized = false;
			EventNodeDebug.Log(string.Format("[CounterNode] 计数器重置，起始值: {0}", num));
		}

		// Token: 0x06004077 RID: 16503 RVA: 0x001534C8 File Offset: 0x001516C8
		[Token(Token = "0x6004077")]
		[Address(RVA = "0x8597D0", Offset = "0x857DD0", VA = "0x1808597D0")]
		public CounterNode()
		{
			List<EventNodeBase> list = new List();
			this.onCountTargets = list;
			base..ctor();
		}

		// Token: 0x04003180 RID: 12672
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4003180")]
		public string trigger_PortName = "触发";

		// Token: 0x04003181 RID: 12673
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4003181")]
		public string shouldReset_PortName = "是否重置";

		// Token: 0x04003182 RID: 12674
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4003182")]
		public string count_PortName = "计数";

		// Token: 0x04003183 RID: 12675
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4003183")]
		public string onCount_PortName = "计数完成";

		// Token: 0x04003184 RID: 12676
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4003184")]
		public int startValue;

		// Token: 0x04003185 RID: 12677
		[FieldOffset(Offset = "0x54")]
		[Token(Token = "0x4003185")]
		[NonSerialized]
		private int currentCount;

		// Token: 0x04003186 RID: 12678
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4003186")]
		[NonSerialized]
		private bool initialized;

		// Token: 0x04003187 RID: 12679
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4003187")]
		[NonSerialized]
		private List<EventNodeBase> onCountTargets;

		// Token: 0x04003188 RID: 12680
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4003188")]
		[NonSerialized]
		private EventNodeBase shouldResetSourceNode;

		// Token: 0x04003189 RID: 12681
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4003189")]
		[NonSerialized]
		private string shouldResetSourcePort;
	}
}
