using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BD3 RID: 3027
	[Token(Token = "0x2000BD3")]
	[Serializable]
	public class FloatToIntNode : EventNodeBase
	{
		// Token: 0x06003F01 RID: 16129 RVA: 0x0014B240 File Offset: 0x00149440
		[Token(Token = "0x6003F01")]
		[Address(RVA = "0x85BC80", Offset = "0x85A280", VA = "0x18085BC80", Slot = "4")]
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

		// Token: 0x06003F02 RID: 16130 RVA: 0x0014B278 File Offset: 0x00149478
		[Token(Token = "0x6003F02")]
		[Address(RVA = "0x85BD70", Offset = "0x85A370", VA = "0x18085BD70", Slot = "5")]
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

		// Token: 0x06003F03 RID: 16131 RVA: 0x0014B2B0 File Offset: 0x001494B0
		[Token(Token = "0x6003F03")]
		[Address(RVA = "0x85BE60", Offset = "0x85A460", VA = "0x18085BE60", Slot = "7")]
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

		// Token: 0x06003F04 RID: 16132 RVA: 0x0014B310 File Offset: 0x00149510
		[Token(Token = "0x6003F04")]
		[Address(RVA = "0xA50860", Offset = "0xA4EE60", VA = "0x180A50860", Slot = "9")]
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

		// Token: 0x06003F05 RID: 16133 RVA: 0x0014B370 File Offset: 0x00149570
		[Token(Token = "0x6003F05")]
		[Address(RVA = "0x85BF20", Offset = "0x85A520", VA = "0x18085BF20")]
		public FloatToIntNode()
		{
		}

		// Token: 0x04002FE2 RID: 12258
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002FE2")]
		public string float_PortName = "浮点数";

		// Token: 0x04002FE3 RID: 12259
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002FE3")]
		public string int_PortName = "整数";

		// Token: 0x04002FE4 RID: 12260
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002FE4")]
		[NonSerialized]
		private EventNodeBase floatSourceNode;

		// Token: 0x04002FE5 RID: 12261
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002FE5")]
		[NonSerialized]
		private string floatSourcePort;
	}
}
