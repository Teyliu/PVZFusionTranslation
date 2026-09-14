using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BF7 RID: 3063
	[Token(Token = "0x2000BF7")]
	[Serializable]
	public class AddNode : EventNodeBase
	{
		// Token: 0x06003FB8 RID: 16312 RVA: 0x0014EAB0 File Offset: 0x0014CCB0
		[Token(Token = "0x6003FB8")]
		[Address(RVA = "0x854DB0", Offset = "0x8533B0", VA = "0x180854DB0", Slot = "4")]
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

		// Token: 0x06003FB9 RID: 16313 RVA: 0x0014EB0C File Offset: 0x0014CD0C
		[Token(Token = "0x6003FB9")]
		[Address(RVA = "0x854F20", Offset = "0x853520", VA = "0x180854F20", Slot = "5")]
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

		// Token: 0x06003FBA RID: 16314 RVA: 0x0014EB44 File Offset: 0x0014CD44
		[Token(Token = "0x6003FBA")]
		[Address(RVA = "0x855010", Offset = "0x853610", VA = "0x180855010", Slot = "7")]
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

		// Token: 0x06003FBB RID: 16315 RVA: 0x0014EBF4 File Offset: 0x0014CDF4
		[Token(Token = "0x6003FBB")]
		[Address(RVA = "0x958380", Offset = "0x956980", VA = "0x180958380", Slot = "9")]
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
			string text = string.Format("[AddNode] {0} + {1} = {2}", num, num, num);
			EventNodeDebug.Log(text);
			throw new NullReferenceException();
		}

		// Token: 0x06003FBC RID: 16316 RVA: 0x0014EC58 File Offset: 0x0014CE58
		[Token(Token = "0x6003FBC")]
		[Address(RVA = "0x855160", Offset = "0x853760", VA = "0x180855160")]
		public AddNode()
		{
		}

		// Token: 0x0400308D RID: 12429
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400308D")]
		public string a_PortName = "A";

		// Token: 0x0400308E RID: 12430
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400308E")]
		public string b_PortName = "B";

		// Token: 0x0400308F RID: 12431
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400308F")]
		public string result_PortName = "结果";

		// Token: 0x04003090 RID: 12432
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4003090")]
		[NonSerialized]
		private EventNodeBase aSourceNode;

		// Token: 0x04003091 RID: 12433
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4003091")]
		[NonSerialized]
		private string aSourcePort;

		// Token: 0x04003092 RID: 12434
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4003092")]
		[NonSerialized]
		private EventNodeBase bSourceNode;

		// Token: 0x04003093 RID: 12435
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4003093")]
		[NonSerialized]
		private string bSourcePort;
	}
}
