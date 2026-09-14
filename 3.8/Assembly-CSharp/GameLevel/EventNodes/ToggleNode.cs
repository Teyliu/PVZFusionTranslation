using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BB2 RID: 2994
	[Token(Token = "0x2000BB2")]
	[Serializable]
	public class ToggleNode : EventNodeBase
	{
		// Token: 0x06003E54 RID: 15956 RVA: 0x001490BC File Offset: 0x001472BC
		[Token(Token = "0x6003E54")]
		[Address(RVA = "0x808900", Offset = "0x806F00", VA = "0x180808900", Slot = "4")]
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

		// Token: 0x06003E55 RID: 15957 RVA: 0x001490F8 File Offset: 0x001472F8
		[Token(Token = "0x6003E55")]
		[Address(RVA = "0x8089E0", Offset = "0x806FE0", VA = "0x1808089E0", Slot = "5")]
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

		// Token: 0x06003E56 RID: 15958 RVA: 0x00149150 File Offset: 0x00147350
		[Token(Token = "0x6003E56")]
		[Address(RVA = "0x801E50", Offset = "0x800450", VA = "0x180801E50", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.onChanged_PortName;
			string nodeId = this.nodeId;
			List<EventNodeBase> connectedNodes = graph.GetConnectedNodes(nodeId, text);
			this.onChangedTargets = connectedNodes;
			throw new NullReferenceException();
		}

		// Token: 0x06003E57 RID: 15959 RVA: 0x00149180 File Offset: 0x00147380
		[Token(Token = "0x6003E57")]
		[Address(RVA = "0x808760", Offset = "0x806D60", VA = "0x180808760", Slot = "6")]
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

		// Token: 0x06003E58 RID: 15960 RVA: 0x001491CC File Offset: 0x001473CC
		[Token(Token = "0x6003E58")]
		[Address(RVA = "0x9FE320", Offset = "0x9FC920", VA = "0x1809FE320", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003E59 RID: 15961 RVA: 0x00149208 File Offset: 0x00147408
		[Token(Token = "0x6003E59")]
		[Address(RVA = "0x808B50", Offset = "0x807150", VA = "0x180808B50")]
		public ToggleNode()
		{
			List<EventNodeBase> list = new List();
			this.onChangedTargets = list;
			base..ctor();
		}

		// Token: 0x04002F05 RID: 12037
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002F05")]
		public string trigger_PortName = "触发";

		// Token: 0x04002F06 RID: 12038
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002F06")]
		public string state_PortName = "状态";

		// Token: 0x04002F07 RID: 12039
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002F07")]
		public string onChanged_PortName = "状态改变时";

		// Token: 0x04002F08 RID: 12040
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002F08")]
		[NonSerialized]
		private bool currentState;

		// Token: 0x04002F09 RID: 12041
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002F09")]
		[NonSerialized]
		private List<EventNodeBase> onChangedTargets;
	}
}
