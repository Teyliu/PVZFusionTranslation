using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BC1 RID: 3009
	[Token(Token = "0x2000BC1")]
	[Serializable]
	public class IntMultiplyNode : EventNodeBase
	{
		// Token: 0x06003EA3 RID: 16035 RVA: 0x0014B09C File Offset: 0x0014929C
		[Token(Token = "0x6003EA3")]
		[Address(RVA = "0x7F81C0", Offset = "0x7F67C0", VA = "0x1807F81C0", Slot = "4")]
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

		// Token: 0x06003EA4 RID: 16036 RVA: 0x0014B0F8 File Offset: 0x001492F8
		[Token(Token = "0x6003EA4")]
		[Address(RVA = "0x7F8330", Offset = "0x7F6930", VA = "0x1807F8330", Slot = "5")]
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

		// Token: 0x06003EA5 RID: 16037 RVA: 0x0014B130 File Offset: 0x00149330
		[Token(Token = "0x6003EA5")]
		[Address(RVA = "0x7F8420", Offset = "0x7F6A20", VA = "0x1807F8420", Slot = "7")]
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

		// Token: 0x06003EA6 RID: 16038 RVA: 0x0014B1E0 File Offset: 0x001493E0
		[Token(Token = "0x6003EA6")]
		[Address(RVA = "0x9C5470", Offset = "0x9C3A70", VA = "0x1809C5470", Slot = "9")]
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
			int num2 = 0;
			if (this.bSourceNode != (ulong)0L)
			{
				num += 20;
				num += num;
			}
			int num3 = 0 * num2;
			int num4;
			int num5;
			string text = string.Format("[IntMultiplyNode] {0} × {1} = {2}", num4, num5, num5);
			EventNodeDebug.Log(text);
			throw new NullReferenceException();
		}

		// Token: 0x06003EA7 RID: 16039 RVA: 0x0014B25C File Offset: 0x0014945C
		[Token(Token = "0x6003EA7")]
		[Address(RVA = "0x7F8570", Offset = "0x7F6B70", VA = "0x1807F8570")]
		public IntMultiplyNode()
		{
		}

		// Token: 0x04002F6F RID: 12143
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002F6F")]
		public string a_PortName = "A";

		// Token: 0x04002F70 RID: 12144
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002F70")]
		public string b_PortName = "B";

		// Token: 0x04002F71 RID: 12145
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002F71")]
		public string result_PortName = "积";

		// Token: 0x04002F72 RID: 12146
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002F72")]
		[NonSerialized]
		private EventNodeBase aSourceNode;

		// Token: 0x04002F73 RID: 12147
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002F73")]
		[NonSerialized]
		private string aSourcePort;

		// Token: 0x04002F74 RID: 12148
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002F74")]
		[NonSerialized]
		private EventNodeBase bSourceNode;

		// Token: 0x04002F75 RID: 12149
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002F75")]
		[NonSerialized]
		private string bSourcePort;
	}
}
