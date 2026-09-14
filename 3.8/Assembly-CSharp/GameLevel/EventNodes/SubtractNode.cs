using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BB6 RID: 2998
	[Token(Token = "0x2000BB6")]
	[Serializable]
	public class SubtractNode : EventNodeBase
	{
		// Token: 0x06003E6C RID: 15980 RVA: 0x00149A1C File Offset: 0x00147C1C
		[Token(Token = "0x6003E6C")]
		[Address(RVA = "0x8077C0", Offset = "0x805DC0", VA = "0x1808077C0", Slot = "4")]
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

		// Token: 0x06003E6D RID: 15981 RVA: 0x00149A78 File Offset: 0x00147C78
		[Token(Token = "0x6003E6D")]
		[Address(RVA = "0x807930", Offset = "0x805F30", VA = "0x180807930", Slot = "5")]
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

		// Token: 0x06003E6E RID: 15982 RVA: 0x00149AB0 File Offset: 0x00147CB0
		[Token(Token = "0x6003E6E")]
		[Address(RVA = "0x807A20", Offset = "0x806020", VA = "0x180807A20", Slot = "7")]
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

		// Token: 0x06003E6F RID: 15983 RVA: 0x00149B60 File Offset: 0x00147D60
		[Token(Token = "0x6003E6F")]
		[Address(RVA = "0xA172F0", Offset = "0xA158F0", VA = "0x180A172F0", Slot = "9")]
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
			float num2;
			EventNodeDebug.Log(string.Format("[SubtractNode] {0} - {1} = {2}", num, num, num2));
			throw new NullReferenceException();
		}

		// Token: 0x06003E70 RID: 15984 RVA: 0x00149BC0 File Offset: 0x00147DC0
		[Token(Token = "0x6003E70")]
		[Address(RVA = "0x807B70", Offset = "0x806170", VA = "0x180807B70")]
		public SubtractNode()
		{
		}

		// Token: 0x04002F20 RID: 12064
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002F20")]
		public string a_PortName = "被减数";

		// Token: 0x04002F21 RID: 12065
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002F21")]
		public string b_PortName = "减数";

		// Token: 0x04002F22 RID: 12066
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002F22")]
		public string result_PortName = "差";

		// Token: 0x04002F23 RID: 12067
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002F23")]
		[NonSerialized]
		private EventNodeBase aSourceNode;

		// Token: 0x04002F24 RID: 12068
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002F24")]
		[NonSerialized]
		private string aSourcePort;

		// Token: 0x04002F25 RID: 12069
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002F25")]
		[NonSerialized]
		private EventNodeBase bSourceNode;

		// Token: 0x04002F26 RID: 12070
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002F26")]
		[NonSerialized]
		private string bSourcePort;
	}
}
