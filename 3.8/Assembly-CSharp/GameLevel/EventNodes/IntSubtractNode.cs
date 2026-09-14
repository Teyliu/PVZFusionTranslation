using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BC0 RID: 3008
	[Token(Token = "0x2000BC0")]
	[Serializable]
	public class IntSubtractNode : EventNodeBase
	{
		// Token: 0x06003E9E RID: 16030 RVA: 0x0014AEA8 File Offset: 0x001490A8
		[Token(Token = "0x6003E9E")]
		[Address(RVA = "0x7F8610", Offset = "0x7F6C10", VA = "0x1807F8610", Slot = "4")]
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

		// Token: 0x06003E9F RID: 16031 RVA: 0x0014AF04 File Offset: 0x00149104
		[Token(Token = "0x6003E9F")]
		[Address(RVA = "0x7F8780", Offset = "0x7F6D80", VA = "0x1807F8780", Slot = "5")]
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

		// Token: 0x06003EA0 RID: 16032 RVA: 0x0014AF3C File Offset: 0x0014913C
		[Token(Token = "0x6003EA0")]
		[Address(RVA = "0x7F8870", Offset = "0x7F6E70", VA = "0x1807F8870", Slot = "7")]
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

		// Token: 0x06003EA1 RID: 16033 RVA: 0x0014AFEC File Offset: 0x001491EC
		[Token(Token = "0x6003EA1")]
		[Address(RVA = "0x9C6200", Offset = "0x9C4800", VA = "0x1809C6200", Slot = "9")]
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
			int num3 = 0;
			num2 -= num3;
			int num4;
			int num5;
			int num6;
			EventNodeDebug.Log(string.Format("[IntSubtractNode] {0} - {1} = {2}", num4, num5, num6));
			throw new NullReferenceException();
		}

		// Token: 0x06003EA2 RID: 16034 RVA: 0x0014B068 File Offset: 0x00149268
		[Token(Token = "0x6003EA2")]
		[Address(RVA = "0x7F89C0", Offset = "0x7F6FC0", VA = "0x1807F89C0")]
		public IntSubtractNode()
		{
		}

		// Token: 0x04002F68 RID: 12136
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002F68")]
		public string a_PortName = "被减数";

		// Token: 0x04002F69 RID: 12137
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002F69")]
		public string b_PortName = "减数";

		// Token: 0x04002F6A RID: 12138
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002F6A")]
		public string result_PortName = "差";

		// Token: 0x04002F6B RID: 12139
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002F6B")]
		[NonSerialized]
		private EventNodeBase aSourceNode;

		// Token: 0x04002F6C RID: 12140
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002F6C")]
		[NonSerialized]
		private string aSourcePort;

		// Token: 0x04002F6D RID: 12141
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002F6D")]
		[NonSerialized]
		private EventNodeBase bSourceNode;

		// Token: 0x04002F6E RID: 12142
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002F6E")]
		[NonSerialized]
		private string bSourcePort;
	}
}
