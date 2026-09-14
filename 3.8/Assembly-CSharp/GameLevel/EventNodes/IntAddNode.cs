using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BBF RID: 3007
	[Token(Token = "0x2000BBF")]
	[Serializable]
	public class IntAddNode : EventNodeBase
	{
		// Token: 0x06003E99 RID: 16025 RVA: 0x0014ACB8 File Offset: 0x00148EB8
		[Token(Token = "0x6003E99")]
		[Address(RVA = "0x7F74D0", Offset = "0x7F5AD0", VA = "0x1807F74D0", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[2];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.a_PortName, (PortType)((uint)1), (PortDirection)num);
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			int num2;
			PortDefinition portDefinition2 = new PortDefinition(this.b_PortName, (PortType)((uint)1), (PortDirection)num2);
			num2 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003E9A RID: 16026 RVA: 0x0014AD14 File Offset: 0x00148F14
		[Token(Token = "0x6003E9A")]
		[Address(RVA = "0x7F7640", Offset = "0x7F5C40", VA = "0x1807F7640", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			PortDefinition portDefinition = new PortDefinition(this.result_PortName, (PortType)((uint)1), (PortDirection)((uint)1));
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003E9B RID: 16027 RVA: 0x0014AD4C File Offset: 0x00148F4C
		[Token(Token = "0x6003E9B")]
		[Address(RVA = "0x7F7730", Offset = "0x7F5D30", VA = "0x1807F7730", Slot = "7")]
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

		// Token: 0x06003E9C RID: 16028 RVA: 0x0014ADFC File Offset: 0x00148FFC
		[Token(Token = "0x6003E9C")]
		[Address(RVA = "0x9C23E0", Offset = "0x9C09E0", VA = "0x1809C23E0", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			int num;
			if (this.aSourceNode != (ulong)0L)
			{
				num += 20;
				num += num;
			}
			if (this.bSourceNode != (ulong)0L)
			{
				num += 20;
				num += num;
			}
			int num2;
			int num3;
			int num4;
			EventNodeDebug.Log(string.Format("[IntAddNode] {0} + {1} = {2}", num2, num3, num4));
			throw new NullReferenceException();
		}

		// Token: 0x06003E9D RID: 16029 RVA: 0x0014AE74 File Offset: 0x00149074
		[Token(Token = "0x6003E9D")]
		[Address(RVA = "0x7F7880", Offset = "0x7F5E80", VA = "0x1807F7880")]
		public IntAddNode()
		{
		}

		// Token: 0x04002F61 RID: 12129
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002F61")]
		public string a_PortName = "A";

		// Token: 0x04002F62 RID: 12130
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002F62")]
		public string b_PortName = "B";

		// Token: 0x04002F63 RID: 12131
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002F63")]
		public string result_PortName = "和";

		// Token: 0x04002F64 RID: 12132
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002F64")]
		[NonSerialized]
		private EventNodeBase aSourceNode;

		// Token: 0x04002F65 RID: 12133
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002F65")]
		[NonSerialized]
		private string aSourcePort;

		// Token: 0x04002F66 RID: 12134
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002F66")]
		[NonSerialized]
		private EventNodeBase bSourceNode;

		// Token: 0x04002F67 RID: 12135
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002F67")]
		[NonSerialized]
		private string bSourcePort;
	}
}
