using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BC2 RID: 3010
	[Token(Token = "0x2000BC2")]
	[Serializable]
	public class IntDivideNode : EventNodeBase
	{
		// Token: 0x06003EA8 RID: 16040 RVA: 0x0014B290 File Offset: 0x00149490
		[Token(Token = "0x6003EA8")]
		[Address(RVA = "0x7F7920", Offset = "0x7F5F20", VA = "0x1807F7920", Slot = "4")]
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

		// Token: 0x06003EA9 RID: 16041 RVA: 0x0014B2EC File Offset: 0x001494EC
		[Token(Token = "0x6003EA9")]
		[Address(RVA = "0x7F7A90", Offset = "0x7F6090", VA = "0x1807F7A90", Slot = "5")]
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

		// Token: 0x06003EAA RID: 16042 RVA: 0x0014B328 File Offset: 0x00149528
		[Token(Token = "0x6003EAA")]
		[Address(RVA = "0x7F7B80", Offset = "0x7F6180", VA = "0x1807F7B80", Slot = "7")]
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

		// Token: 0x06003EAB RID: 16043 RVA: 0x0014B3D8 File Offset: 0x001495D8
		[Token(Token = "0x6003EAB")]
		[Address(RVA = "0x9C3170", Offset = "0x9C1770", VA = "0x1809C3170", Slot = "9")]
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
				if (num != 0)
				{
					int num2;
					int num3;
					EventNodeDebug.Log(string.Format("[IntDivideNode] {0} ÷ {1} = {2}", num2, num2, num3));
				}
			}
			string text;
			EventNodeDebug.LogWarning(text);
			throw new NullReferenceException();
		}

		// Token: 0x06003EAC RID: 16044 RVA: 0x0014B454 File Offset: 0x00149654
		[Token(Token = "0x6003EAC")]
		[Address(RVA = "0x7F7CD0", Offset = "0x7F62D0", VA = "0x1807F7CD0")]
		public IntDivideNode()
		{
		}

		// Token: 0x04002F76 RID: 12150
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002F76")]
		public string a_PortName = "被除数";

		// Token: 0x04002F77 RID: 12151
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002F77")]
		public string b_PortName = "除数";

		// Token: 0x04002F78 RID: 12152
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002F78")]
		public string result_PortName = "商";

		// Token: 0x04002F79 RID: 12153
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002F79")]
		[NonSerialized]
		private EventNodeBase aSourceNode;

		// Token: 0x04002F7A RID: 12154
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002F7A")]
		[NonSerialized]
		private string aSourcePort;

		// Token: 0x04002F7B RID: 12155
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002F7B")]
		[NonSerialized]
		private EventNodeBase bSourceNode;

		// Token: 0x04002F7C RID: 12156
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002F7C")]
		[NonSerialized]
		private string bSourcePort;
	}
}
