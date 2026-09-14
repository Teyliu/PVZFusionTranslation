using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BB7 RID: 2999
	[Token(Token = "0x2000BB7")]
	[Serializable]
	public class MultiplyNode : EventNodeBase
	{
		// Token: 0x06003E71 RID: 15985 RVA: 0x00149BF4 File Offset: 0x00147DF4
		[Token(Token = "0x6003E71")]
		[Address(RVA = "0x7FC120", Offset = "0x7FA720", VA = "0x1807FC120", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[2];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.a_PortName, (PortType)((uint)3), (PortDirection)num);
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			int num2;
			PortDefinition portDefinition2 = new PortDefinition(this.b_PortName, (PortType)((uint)3), (PortDirection)num2);
			num2 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003E72 RID: 15986 RVA: 0x00149C50 File Offset: 0x00147E50
		[Token(Token = "0x6003E72")]
		[Address(RVA = "0x7FC290", Offset = "0x7FA890", VA = "0x1807FC290", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			PortDefinition portDefinition = new PortDefinition(this.result_PortName, (PortType)((uint)3), (PortDirection)((uint)1));
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003E73 RID: 15987 RVA: 0x00149C88 File Offset: 0x00147E88
		[Token(Token = "0x6003E73")]
		[Address(RVA = "0x7FC380", Offset = "0x7FA980", VA = "0x1807FC380", Slot = "7")]
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

		// Token: 0x06003E74 RID: 15988 RVA: 0x00149D38 File Offset: 0x00147F38
		[Token(Token = "0x6003E74")]
		[Address(RVA = "0x9EC950", Offset = "0x9EAF50", VA = "0x1809EC950", Slot = "9")]
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
			float num;
			string text = string.Format("[MultiplyNode] {0} × {1} = {2}", num, num, num);
			EventNodeDebug.Log(text);
			throw new NullReferenceException();
		}

		// Token: 0x06003E75 RID: 15989 RVA: 0x00149D9C File Offset: 0x00147F9C
		[Token(Token = "0x6003E75")]
		[Address(RVA = "0x7FC4D0", Offset = "0x7FAAD0", VA = "0x1807FC4D0")]
		public MultiplyNode()
		{
		}

		// Token: 0x04002F27 RID: 12071
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002F27")]
		public string a_PortName = "A";

		// Token: 0x04002F28 RID: 12072
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002F28")]
		public string b_PortName = "B";

		// Token: 0x04002F29 RID: 12073
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002F29")]
		public string result_PortName = "积";

		// Token: 0x04002F2A RID: 12074
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002F2A")]
		[NonSerialized]
		private EventNodeBase aSourceNode;

		// Token: 0x04002F2B RID: 12075
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002F2B")]
		[NonSerialized]
		private string aSourcePort;

		// Token: 0x04002F2C RID: 12076
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002F2C")]
		[NonSerialized]
		private EventNodeBase bSourceNode;

		// Token: 0x04002F2D RID: 12077
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002F2D")]
		[NonSerialized]
		private string bSourcePort;
	}
}
