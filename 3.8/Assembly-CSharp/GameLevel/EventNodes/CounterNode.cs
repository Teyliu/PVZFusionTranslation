using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BDA RID: 3034
	[Token(Token = "0x2000BDA")]
	[Serializable]
	public class CounterNode : EventNodeBase
	{
		// Token: 0x06003F20 RID: 16160 RVA: 0x0014E014 File Offset: 0x0014C214
		[Token(Token = "0x6003F20")]
		[Address(RVA = "0x7F1890", Offset = "0x7EFE90", VA = "0x1807F1890", Slot = "4")]
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

		// Token: 0x06003F21 RID: 16161 RVA: 0x0014E074 File Offset: 0x0014C274
		[Token(Token = "0x6003F21")]
		[Address(RVA = "0x7F1A00", Offset = "0x7F0000", VA = "0x1807F1A00", Slot = "5")]
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

		// Token: 0x06003F22 RID: 16162 RVA: 0x0014E0CC File Offset: 0x0014C2CC
		[Token(Token = "0x6003F22")]
		[Address(RVA = "0x7F1B70", Offset = "0x7F0170", VA = "0x1807F1B70", Slot = "7")]
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

		// Token: 0x06003F23 RID: 16163 RVA: 0x0014E150 File Offset: 0x0014C350
		[Token(Token = "0x6003F23")]
		[Address(RVA = "0x7F15F0", Offset = "0x7EFBF0", VA = "0x1807F15F0", Slot = "6")]
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

		// Token: 0x06003F24 RID: 16164 RVA: 0x0014E1F8 File Offset: 0x0014C3F8
		[Token(Token = "0x6003F24")]
		[Address(RVA = "0x941050", Offset = "0x93F650", VA = "0x180941050", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003F25 RID: 16165 RVA: 0x0014E23C File Offset: 0x0014C43C
		[Token(Token = "0x6003F25")]
		[Address(RVA = "0x7F1C60", Offset = "0x7F0260", VA = "0x1807F1C60")]
		public void Reset()
		{
			int num = this.startValue;
			this.currentCount = num;
			this.initialized = false;
			EventNodeDebug.Log(string.Format("[CounterNode] 计数器重置，起始值: {0}", num));
		}

		// Token: 0x06003F26 RID: 16166 RVA: 0x0014E270 File Offset: 0x0014C470
		[Token(Token = "0x6003F26")]
		[Address(RVA = "0x7F1D00", Offset = "0x7F0300", VA = "0x1807F1D00")]
		public CounterNode()
		{
			List<EventNodeBase> list = new List();
			this.onCountTargets = list;
			base..ctor();
		}

		// Token: 0x0400300D RID: 12301
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400300D")]
		public string trigger_PortName = "触发";

		// Token: 0x0400300E RID: 12302
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400300E")]
		public string shouldReset_PortName = "是否重置";

		// Token: 0x0400300F RID: 12303
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400300F")]
		public string count_PortName = "计数";

		// Token: 0x04003010 RID: 12304
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4003010")]
		public string onCount_PortName = "计数完成";

		// Token: 0x04003011 RID: 12305
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4003011")]
		public int startValue;

		// Token: 0x04003012 RID: 12306
		[FieldOffset(Offset = "0x54")]
		[Token(Token = "0x4003012")]
		[NonSerialized]
		private int currentCount;

		// Token: 0x04003013 RID: 12307
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4003013")]
		[NonSerialized]
		private bool initialized;

		// Token: 0x04003014 RID: 12308
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4003014")]
		[NonSerialized]
		private List<EventNodeBase> onCountTargets;

		// Token: 0x04003015 RID: 12309
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4003015")]
		[NonSerialized]
		private EventNodeBase shouldResetSourceNode;

		// Token: 0x04003016 RID: 12310
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4003016")]
		[NonSerialized]
		private string shouldResetSourcePort;
	}
}
