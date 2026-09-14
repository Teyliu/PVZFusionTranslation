using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BB8 RID: 3000
	[Token(Token = "0x2000BB8")]
	[Serializable]
	public class DivideNode : EventNodeBase
	{
		// Token: 0x06003E76 RID: 15990 RVA: 0x00149DD0 File Offset: 0x00147FD0
		[Token(Token = "0x6003E76")]
		[Address(RVA = "0x7F3C80", Offset = "0x7F2280", VA = "0x1807F3C80", Slot = "4")]
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

		// Token: 0x06003E77 RID: 15991 RVA: 0x00149E2C File Offset: 0x0014802C
		[Token(Token = "0x6003E77")]
		[Address(RVA = "0x7F3DF0", Offset = "0x7F23F0", VA = "0x1807F3DF0", Slot = "5")]
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

		// Token: 0x06003E78 RID: 15992 RVA: 0x00149E64 File Offset: 0x00148064
		[Token(Token = "0x6003E78")]
		[Address(RVA = "0x7F3EE0", Offset = "0x7F24E0", VA = "0x1807F3EE0", Slot = "7")]
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

		// Token: 0x06003E79 RID: 15993 RVA: 0x00149F14 File Offset: 0x00148114
		[Token(Token = "0x6003E79")]
		[Address(RVA = "0x947830", Offset = "0x945E30", VA = "0x180947830", Slot = "9")]
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
			EventNodeDebug.Log(string.Format("[DivideNode] {0} ÷ {1} = {2}", num, num, num2));
			string nodeId = this.nodeId;
			EventNodeDebug.LogWarning("[DivideNode] 除数为零！返回0，节点ID: " + nodeId);
			throw new NullReferenceException();
		}

		// Token: 0x06003E7A RID: 15994 RVA: 0x00149F8C File Offset: 0x0014818C
		[Token(Token = "0x6003E7A")]
		[Address(RVA = "0x7F4030", Offset = "0x7F2630", VA = "0x1807F4030")]
		public DivideNode()
		{
		}

		// Token: 0x04002F2E RID: 12078
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002F2E")]
		public string a_PortName = "被除数";

		// Token: 0x04002F2F RID: 12079
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002F2F")]
		public string b_PortName = "除数";

		// Token: 0x04002F30 RID: 12080
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002F30")]
		public string result_PortName = "商";

		// Token: 0x04002F31 RID: 12081
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002F31")]
		[NonSerialized]
		private EventNodeBase aSourceNode;

		// Token: 0x04002F32 RID: 12082
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002F32")]
		[NonSerialized]
		private string aSourcePort;

		// Token: 0x04002F33 RID: 12083
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002F33")]
		[NonSerialized]
		private EventNodeBase bSourceNode;

		// Token: 0x04002F34 RID: 12084
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002F34")]
		[NonSerialized]
		private string bSourcePort;
	}
}
