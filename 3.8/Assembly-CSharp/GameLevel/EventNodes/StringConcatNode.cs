using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BB9 RID: 3001
	[Token(Token = "0x2000BB9")]
	[Serializable]
	public class StringConcatNode : EventNodeBase
	{
		// Token: 0x06003E7B RID: 15995 RVA: 0x00149FC0 File Offset: 0x001481C0
		[Token(Token = "0x6003E7B")]
		[Address(RVA = "0x806FC0", Offset = "0x8055C0", VA = "0x180806FC0", Slot = "4")]
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

		// Token: 0x06003E7C RID: 15996 RVA: 0x0014A01C File Offset: 0x0014821C
		[Token(Token = "0x6003E7C")]
		[Address(RVA = "0x807130", Offset = "0x805730", VA = "0x180807130", Slot = "5")]
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

		// Token: 0x06003E7D RID: 15997 RVA: 0x0014A054 File Offset: 0x00148254
		[Token(Token = "0x6003E7D")]
		[Address(RVA = "0x807220", Offset = "0x805820", VA = "0x180807220", Slot = "7")]
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

		// Token: 0x06003E7E RID: 15998 RVA: 0x0014A104 File Offset: 0x00148304
		[Token(Token = "0x6003E7E")]
		[Address(RVA = "0xA0F1B0", Offset = "0xA0D7B0", VA = "0x180A0F1B0", Slot = "9")]
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

		// Token: 0x06003E7F RID: 15999 RVA: 0x0014A1A4 File Offset: 0x001483A4
		[Token(Token = "0x6003E7F")]
		[Address(RVA = "0x807370", Offset = "0x805970", VA = "0x180807370")]
		public StringConcatNode()
		{
		}

		// Token: 0x04002F35 RID: 12085
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002F35")]
		public string a_PortName = "A";

		// Token: 0x04002F36 RID: 12086
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002F36")]
		public string b_PortName = "B";

		// Token: 0x04002F37 RID: 12087
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002F37")]
		public string result_PortName = "结果";

		// Token: 0x04002F38 RID: 12088
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002F38")]
		[NonSerialized]
		private EventNodeBase aSourceNode;

		// Token: 0x04002F39 RID: 12089
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002F39")]
		[NonSerialized]
		private string aSourcePort;

		// Token: 0x04002F3A RID: 12090
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002F3A")]
		[NonSerialized]
		private EventNodeBase bSourceNode;

		// Token: 0x04002F3B RID: 12091
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002F3B")]
		[NonSerialized]
		private string bSourcePort;
	}
}
