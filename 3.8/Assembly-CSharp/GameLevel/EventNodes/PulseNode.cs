using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BB3 RID: 2995
	[Token(Token = "0x2000BB3")]
	[Serializable]
	public class PulseNode : EventNodeBase
	{
		// Token: 0x06003E5A RID: 15962 RVA: 0x0014924C File Offset: 0x0014744C
		[Token(Token = "0x6003E5A")]
		[Address(RVA = "0x801C00", Offset = "0x800200", VA = "0x180801C00", Slot = "4")]
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

		// Token: 0x06003E5B RID: 15963 RVA: 0x00149288 File Offset: 0x00147488
		[Token(Token = "0x6003E5B")]
		[Address(RVA = "0x801CE0", Offset = "0x8002E0", VA = "0x180801CE0", Slot = "5")]
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

		// Token: 0x06003E5C RID: 15964 RVA: 0x001492E0 File Offset: 0x001474E0
		[Token(Token = "0x6003E5C")]
		[Address(RVA = "0x801E50", Offset = "0x800450", VA = "0x180801E50", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.onPulse_PortName;
			string nodeId = this.nodeId;
			List<EventNodeBase> connectedNodes = graph.GetConnectedNodes(nodeId, text);
			this.onPulseTargets = connectedNodes;
			throw new NullReferenceException();
		}

		// Token: 0x06003E5D RID: 15965 RVA: 0x00149310 File Offset: 0x00147510
		[Token(Token = "0x6003E5D")]
		[Address(RVA = "0x8019F0", Offset = "0x7FFFF0", VA = "0x1808019F0", Slot = "6")]
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

		// Token: 0x06003E5E RID: 15966 RVA: 0x0014936C File Offset: 0x0014756C
		[Token(Token = "0x6003E5E")]
		[Address(RVA = "0x9FE320", Offset = "0x9FC920", VA = "0x1809FE320", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003E5F RID: 15967 RVA: 0x001493A8 File Offset: 0x001475A8
		[Token(Token = "0x6003E5F")]
		[Address(RVA = "0x801E90", Offset = "0x800490", VA = "0x180801E90")]
		public PulseNode()
		{
			List<EventNodeBase> list = new List();
			this.onPulseTargets = list;
			base..ctor();
		}

		// Token: 0x04002F0A RID: 12042
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002F0A")]
		public string trigger_PortName = "触发";

		// Token: 0x04002F0B RID: 12043
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002F0B")]
		public string state_PortName = "状态";

		// Token: 0x04002F0C RID: 12044
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002F0C")]
		public string onPulse_PortName = "脉冲触发时";

		// Token: 0x04002F0D RID: 12045
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002F0D")]
		[NonSerialized]
		private bool currentState;

		// Token: 0x04002F0E RID: 12046
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002F0E")]
		[NonSerialized]
		private List<EventNodeBase> onPulseTargets;
	}
}
