using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BFB RID: 3067
	[Token(Token = "0x2000BFB")]
	[Serializable]
	public class StringConcatNode : EventNodeBase
	{
		// Token: 0x06003FCC RID: 16332 RVA: 0x0014F230 File Offset: 0x0014D430
		[Token(Token = "0x6003FCC")]
		[Address(RVA = "0x86E970", Offset = "0x86CF70", VA = "0x18086E970", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[2];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.a_PortName, (PortType)((uint)5), (PortDirection)num);
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			int num2;
			PortDefinition portDefinition2 = new PortDefinition(this.b_PortName, (PortType)((uint)5), (PortDirection)num2);
			num2 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003FCD RID: 16333 RVA: 0x0014F28C File Offset: 0x0014D48C
		[Token(Token = "0x6003FCD")]
		[Address(RVA = "0x86EAE0", Offset = "0x86D0E0", VA = "0x18086EAE0", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			PortDefinition portDefinition = new PortDefinition(this.result_PortName, (PortType)((uint)5), (PortDirection)((uint)1));
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003FCE RID: 16334 RVA: 0x0014F2C4 File Offset: 0x0014D4C4
		[Token(Token = "0x6003FCE")]
		[Address(RVA = "0x86EBD0", Offset = "0x86D1D0", VA = "0x18086EBD0", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.a_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.aSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.aSourcePort = sourcePortName;
			string text2 = this.b_PortName;
			string nodeId2 = this.nodeId;
			List<SourcePortInfo> sourceNodes2 = graph.GetSourceNodes(nodeId2, text2);
			int num3 = 0;
			EventNodeBase sourceNode2 = sourceNodes2[num3].sourceNode;
			this.bSourceNode = sourceNode2;
			int num4 = 0;
			string sourcePortName2 = sourceNodes2[num4].sourcePortName;
			this.bSourcePort = sourcePortName2;
		}

		// Token: 0x06003FCF RID: 16335 RVA: 0x0014F374 File Offset: 0x0014D574
		[Token(Token = "0x6003FCF")]
		[Address(RVA = "0xAC12C0", Offset = "0xABF8C0", VA = "0x180AC12C0", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			if (this.aSourceNode != (ulong)0L)
			{
			}
			if (this.bSourceNode != (ulong)0L)
			{
			}
			string text;
			EventNodeDebug.Log(string.Concat(new string[] { "[StringConcatNode] \"", "", "\" + \"", null, "\" = \"", text, "\"" }));
			throw new NullReferenceException();
		}

		// Token: 0x06003FD0 RID: 16336 RVA: 0x0014F414 File Offset: 0x0014D614
		[Token(Token = "0x6003FD0")]
		[Address(RVA = "0x86ED20", Offset = "0x86D320", VA = "0x18086ED20")]
		public StringConcatNode()
		{
		}

		// Token: 0x040030A9 RID: 12457
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40030A9")]
		public string a_PortName = "A";

		// Token: 0x040030AA RID: 12458
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40030AA")]
		public string b_PortName = "B";

		// Token: 0x040030AB RID: 12459
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40030AB")]
		public string result_PortName = "结果";

		// Token: 0x040030AC RID: 12460
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40030AC")]
		[NonSerialized]
		private EventNodeBase aSourceNode;

		// Token: 0x040030AD RID: 12461
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40030AD")]
		[NonSerialized]
		private string aSourcePort;

		// Token: 0x040030AE RID: 12462
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40030AE")]
		[NonSerialized]
		private EventNodeBase bSourceNode;

		// Token: 0x040030AF RID: 12463
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40030AF")]
		[NonSerialized]
		private string bSourcePort;
	}
}
