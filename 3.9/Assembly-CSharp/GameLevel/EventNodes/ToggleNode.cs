using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BF4 RID: 3060
	[Token(Token = "0x2000BF4")]
	[Serializable]
	public class ToggleNode : EventNodeBase
	{
		// Token: 0x06003FA5 RID: 16293 RVA: 0x0014E32C File Offset: 0x0014C52C
		[Token(Token = "0x6003FA5")]
		[Address(RVA = "0x8702B0", Offset = "0x86E8B0", VA = "0x1808702B0", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			int num;
			int num2;
			PortDefinition portDefinition = new PortDefinition(this.trigger_PortName, (PortType)num, (PortDirection)num2);
			num2 = 0;
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003FA6 RID: 16294 RVA: 0x0014E368 File Offset: 0x0014C568
		[Token(Token = "0x6003FA6")]
		[Address(RVA = "0x870390", Offset = "0x86E990", VA = "0x180870390", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[2];
			PortDefinition portDefinition = new PortDefinition(this.state_PortName, (PortType)((uint)6), (PortDirection)((uint)1));
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			int num;
			PortDefinition portDefinition2 = new PortDefinition(this.onChanged_PortName, (PortType)num, (PortDirection)((uint)1));
			num = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003FA7 RID: 16295 RVA: 0x0014E3C0 File Offset: 0x0014C5C0
		[Token(Token = "0x6003FA7")]
		[Address(RVA = "0x869800", Offset = "0x867E00", VA = "0x180869800", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.onChanged_PortName;
			string nodeId = this.nodeId;
			List<EventNodeBase> connectedNodes = graph.GetConnectedNodes(nodeId, text);
			this.onChangedTargets = connectedNodes;
			throw new NullReferenceException();
		}

		// Token: 0x06003FA8 RID: 16296 RVA: 0x0014E3F0 File Offset: 0x0014C5F0
		[Token(Token = "0x6003FA8")]
		[Address(RVA = "0x870110", Offset = "0x86E710", VA = "0x180870110", Slot = "6")]
		public override void Execute()
		{
			ulong num2;
			do
			{
				int num = 0;
				bool flag = (this.currentState ? 1 : 0) == num;
				this.currentState = flag;
				EventNodeDebug.Log(string.Format("[ToggleNode] 状态切换，当前值: {0}", flag));
				List<EventNodeBase> list = this.onChangedTargets;
				bool flag2;
				if (flag2)
				{
				}
			}
			while (num2 != (ulong)0L);
		}

		// Token: 0x06003FA9 RID: 16297 RVA: 0x0014E43C File Offset: 0x0014C63C
		[Token(Token = "0x6003FA9")]
		[Address(RVA = "0xAAFB60", Offset = "0xAAE160", VA = "0x180AAFB60", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003FAA RID: 16298 RVA: 0x0014E478 File Offset: 0x0014C678
		[Token(Token = "0x6003FAA")]
		[Address(RVA = "0x870500", Offset = "0x86EB00", VA = "0x180870500")]
		public ToggleNode()
		{
			List<EventNodeBase> list = new List();
			this.onChangedTargets = list;
			base..ctor();
		}

		// Token: 0x04003079 RID: 12409
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4003079")]
		public string trigger_PortName = "触发";

		// Token: 0x0400307A RID: 12410
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400307A")]
		public string state_PortName = "状态";

		// Token: 0x0400307B RID: 12411
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400307B")]
		public string onChanged_PortName = "状态改变时";

		// Token: 0x0400307C RID: 12412
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400307C")]
		[NonSerialized]
		private bool currentState;

		// Token: 0x0400307D RID: 12413
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400307D")]
		[NonSerialized]
		private List<EventNodeBase> onChangedTargets;
	}
}
