using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BF5 RID: 3061
	[Token(Token = "0x2000BF5")]
	[Serializable]
	public class PulseNode : EventNodeBase
	{
		// Token: 0x06003FAB RID: 16299 RVA: 0x0014E4BC File Offset: 0x0014C6BC
		[Token(Token = "0x6003FAB")]
		[Address(RVA = "0x8695B0", Offset = "0x867BB0", VA = "0x1808695B0", Slot = "4")]
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

		// Token: 0x06003FAC RID: 16300 RVA: 0x0014E4F8 File Offset: 0x0014C6F8
		[Token(Token = "0x6003FAC")]
		[Address(RVA = "0x869690", Offset = "0x867C90", VA = "0x180869690", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[2];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.onPulse_PortName, (PortType)num, (PortDirection)((uint)1));
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			PortDefinition portDefinition2 = new PortDefinition(this.state_PortName, (PortType)((uint)6), (PortDirection)((uint)1));
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003FAD RID: 16301 RVA: 0x0014E550 File Offset: 0x0014C750
		[Token(Token = "0x6003FAD")]
		[Address(RVA = "0x869800", Offset = "0x867E00", VA = "0x180869800", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.onPulse_PortName;
			string nodeId = this.nodeId;
			List<EventNodeBase> connectedNodes = graph.GetConnectedNodes(nodeId, text);
			this.onPulseTargets = connectedNodes;
			throw new NullReferenceException();
		}

		// Token: 0x06003FAE RID: 16302 RVA: 0x0014E580 File Offset: 0x0014C780
		[Token(Token = "0x6003FAE")]
		[Address(RVA = "0x8693A0", Offset = "0x8679A0", VA = "0x1808693A0", Slot = "6")]
		public override void Execute()
		{
			ulong num;
			do
			{
				this.currentState = true;
				bool flag;
				EventNodeDebug.Log(string.Format("[PulseNode] 脉冲触发，状态变为: {0}", flag));
				List<EventNodeBase> list = this.onPulseTargets;
				bool flag2;
				if (flag2)
				{
				}
			}
			while (num != (ulong)0L);
			bool flag3;
			EventNodeDebug.Log(string.Format("[PulseNode] 脉冲自动重置，状态变为: {0}", flag3));
		}

		// Token: 0x06003FAF RID: 16303 RVA: 0x0014E5DC File Offset: 0x0014C7DC
		[Token(Token = "0x6003FAF")]
		[Address(RVA = "0xAAFB60", Offset = "0xAAE160", VA = "0x180AAFB60", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003FB0 RID: 16304 RVA: 0x0014E618 File Offset: 0x0014C818
		[Token(Token = "0x6003FB0")]
		[Address(RVA = "0x869840", Offset = "0x867E40", VA = "0x180869840")]
		public PulseNode()
		{
			List<EventNodeBase> list = new List();
			this.onPulseTargets = list;
			base..ctor();
		}

		// Token: 0x0400307E RID: 12414
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400307E")]
		public string trigger_PortName = "触发";

		// Token: 0x0400307F RID: 12415
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400307F")]
		public string state_PortName = "状态";

		// Token: 0x04003080 RID: 12416
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4003080")]
		public string onPulse_PortName = "脉冲触发时";

		// Token: 0x04003081 RID: 12417
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4003081")]
		[NonSerialized]
		private bool currentState;

		// Token: 0x04003082 RID: 12418
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4003082")]
		[NonSerialized]
		private List<EventNodeBase> onPulseTargets;
	}
}
