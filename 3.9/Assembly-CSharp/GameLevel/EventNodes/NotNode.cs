using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BF0 RID: 3056
	[Token(Token = "0x2000BF0")]
	[Serializable]
	public class NotNode : EventNodeBase
	{
		// Token: 0x06003F91 RID: 16273 RVA: 0x0014DAF8 File Offset: 0x0014BCF8
		[Token(Token = "0x6003F91")]
		[Address(RVA = "0x863F20", Offset = "0x862520", VA = "0x180863F20", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.input_PortName, (PortType)((uint)6), (PortDirection)num);
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003F92 RID: 16274 RVA: 0x0014DB30 File Offset: 0x0014BD30
		[Token(Token = "0x6003F92")]
		[Address(RVA = "0x864010", Offset = "0x862610", VA = "0x180864010", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			PortDefinition portDefinition = new PortDefinition(this.output_PortName, (PortType)((uint)6), (PortDirection)((uint)1));
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003F93 RID: 16275 RVA: 0x0014DB68 File Offset: 0x0014BD68
		[Token(Token = "0x6003F93")]
		[Address(RVA = "0x864100", Offset = "0x862700", VA = "0x180864100", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.input_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.inputSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.inputSourcePort = sourcePortName;
		}

		// Token: 0x06003F94 RID: 16276 RVA: 0x0014DBC8 File Offset: 0x0014BDC8
		[Token(Token = "0x6003F94")]
		[Address(RVA = "0xAA6300", Offset = "0xAA4900", VA = "0x180AA6300", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			bool flag;
			flag += flag;
			int num = 0;
			bool flag2 = num == 0;
			string text = string.Format("[NotNode] {0} → {1}", num, num);
			EventNodeDebug.Log(text);
			throw new NullReferenceException();
		}

		// Token: 0x06003F95 RID: 16277 RVA: 0x0014DC1C File Offset: 0x0014BE1C
		[Token(Token = "0x6003F95")]
		[Address(RVA = "0x8641C0", Offset = "0x8627C0", VA = "0x1808641C0")]
		public NotNode()
		{
		}

		// Token: 0x0400305B RID: 12379
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400305B")]
		public string input_PortName = "输入";

		// Token: 0x0400305C RID: 12380
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400305C")]
		public string output_PortName = "输出";

		// Token: 0x0400305D RID: 12381
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400305D")]
		[NonSerialized]
		private EventNodeBase inputSourceNode;

		// Token: 0x0400305E RID: 12382
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400305E")]
		[NonSerialized]
		private string inputSourcePort;
	}
}
