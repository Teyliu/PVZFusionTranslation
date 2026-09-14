using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B91 RID: 2961
	[Token(Token = "0x2000B91")]
	[Serializable]
	public class FloatToIntNode : EventNodeBase
	{
		// Token: 0x06003DB0 RID: 15792 RVA: 0x00145FCC File Offset: 0x001441CC
		[Token(Token = "0x6003DB0")]
		[Address(RVA = "0x7F40D0", Offset = "0x7F26D0", VA = "0x1807F40D0", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.float_PortName, (PortType)((uint)3), (PortDirection)num);
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003DB1 RID: 15793 RVA: 0x00146004 File Offset: 0x00144204
		[Token(Token = "0x6003DB1")]
		[Address(RVA = "0x7F41C0", Offset = "0x7F27C0", VA = "0x1807F41C0", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			PortDefinition portDefinition = new PortDefinition(this.int_PortName, (PortType)((uint)1), (PortDirection)((uint)1));
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003DB2 RID: 15794 RVA: 0x0014603C File Offset: 0x0014423C
		[Token(Token = "0x6003DB2")]
		[Address(RVA = "0x7F42B0", Offset = "0x7F28B0", VA = "0x1807F42B0", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.float_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.floatSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.floatSourcePort = sourcePortName;
		}

		// Token: 0x06003DB3 RID: 15795 RVA: 0x0014609C File Offset: 0x0014429C
		[Token(Token = "0x6003DB3")]
		[Address(RVA = "0x9A72A0", Offset = "0x9A58A0", VA = "0x1809A72A0", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			Type typeFromHandle = typeof(Type);
			Type typeFromHandle2 = typeof(int);
			bool flag = typeFromHandle.Equals(typeFromHandle2);
			if (flag)
			{
				if (this.floatSourceNode != (ulong)0L)
				{
				}
			}
			throw new InvalidCastException();
		}

		// Token: 0x06003DB4 RID: 15796 RVA: 0x001460FC File Offset: 0x001442FC
		[Token(Token = "0x6003DB4")]
		[Address(RVA = "0x7F4370", Offset = "0x7F2970", VA = "0x1807F4370")]
		public FloatToIntNode()
		{
		}

		// Token: 0x04002E6E RID: 11886
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002E6E")]
		public string float_PortName = "浮点数";

		// Token: 0x04002E6F RID: 11887
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002E6F")]
		public string int_PortName = "整数";

		// Token: 0x04002E70 RID: 11888
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002E70")]
		[NonSerialized]
		private EventNodeBase floatSourceNode;

		// Token: 0x04002E71 RID: 11889
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002E71")]
		[NonSerialized]
		private string floatSourcePort;
	}
}
