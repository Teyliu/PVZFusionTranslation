using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BB5 RID: 2997
	[Token(Token = "0x2000BB5")]
	[Serializable]
	public class AddNode : EventNodeBase
	{
		// Token: 0x06003E67 RID: 15975 RVA: 0x00149840 File Offset: 0x00147A40
		[Token(Token = "0x6003E67")]
		[Address(RVA = "0x7ED2E0", Offset = "0x7EB8E0", VA = "0x1807ED2E0", Slot = "4")]
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

		// Token: 0x06003E68 RID: 15976 RVA: 0x0014989C File Offset: 0x00147A9C
		[Token(Token = "0x6003E68")]
		[Address(RVA = "0x7ED450", Offset = "0x7EBA50", VA = "0x1807ED450", Slot = "5")]
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

		// Token: 0x06003E69 RID: 15977 RVA: 0x001498D4 File Offset: 0x00147AD4
		[Token(Token = "0x6003E69")]
		[Address(RVA = "0x7ED540", Offset = "0x7EBB40", VA = "0x1807ED540", Slot = "7")]
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

		// Token: 0x06003E6A RID: 15978 RVA: 0x00149984 File Offset: 0x00147B84
		[Token(Token = "0x6003E6A")]
		[Address(RVA = "0x8B8390", Offset = "0x8B6990", VA = "0x1808B8390", Slot = "9")]
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

		// Token: 0x06003E6B RID: 15979 RVA: 0x001499E8 File Offset: 0x00147BE8
		[Token(Token = "0x6003E6B")]
		[Address(RVA = "0x7ED690", Offset = "0x7EBC90", VA = "0x1807ED690")]
		public AddNode()
		{
		}

		// Token: 0x04002F19 RID: 12057
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002F19")]
		public string a_PortName = "A";

		// Token: 0x04002F1A RID: 12058
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002F1A")]
		public string b_PortName = "B";

		// Token: 0x04002F1B RID: 12059
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002F1B")]
		public string result_PortName = "结果";

		// Token: 0x04002F1C RID: 12060
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002F1C")]
		[NonSerialized]
		private EventNodeBase aSourceNode;

		// Token: 0x04002F1D RID: 12061
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002F1D")]
		[NonSerialized]
		private string aSourcePort;

		// Token: 0x04002F1E RID: 12062
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002F1E")]
		[NonSerialized]
		private EventNodeBase bSourceNode;

		// Token: 0x04002F1F RID: 12063
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002F1F")]
		[NonSerialized]
		private string bSourcePort;
	}
}
