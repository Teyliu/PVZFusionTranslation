using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BC3 RID: 3011
	[Token(Token = "0x2000BC3")]
	[Serializable]
	public class IntModuloNode : EventNodeBase
	{
		// Token: 0x06003EAD RID: 16045 RVA: 0x0014B488 File Offset: 0x00149688
		[Token(Token = "0x6003EAD")]
		[Address(RVA = "0x7F7D70", Offset = "0x7F6370", VA = "0x1807F7D70", Slot = "4")]
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

		// Token: 0x06003EAE RID: 16046 RVA: 0x0014B4E4 File Offset: 0x001496E4
		[Token(Token = "0x6003EAE")]
		[Address(RVA = "0x7F7EE0", Offset = "0x7F64E0", VA = "0x1807F7EE0", Slot = "5")]
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

		// Token: 0x06003EAF RID: 16047 RVA: 0x0014B51C File Offset: 0x0014971C
		[Token(Token = "0x6003EAF")]
		[Address(RVA = "0x7F7FD0", Offset = "0x7F65D0", VA = "0x1807F7FD0", Slot = "7")]
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

		// Token: 0x06003EB0 RID: 16048 RVA: 0x0014B5CC File Offset: 0x001497CC
		[Token(Token = "0x6003EB0")]
		[Address(RVA = "0x9C42F0", Offset = "0x9C28F0", VA = "0x1809C42F0", Slot = "9")]
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
				string text = this.bSourcePort;
				num += 20;
				num += num;
				if (num != 0)
				{
					int num2;
					EventNodeDebug.Log(string.Format("[IntModuloNode] {0} % {1} = {2}", num2, num2, num2));
				}
			}
			string text2;
			EventNodeDebug.LogWarning(text2);
			throw new NullReferenceException();
		}

		// Token: 0x06003EB1 RID: 16049 RVA: 0x0014B650 File Offset: 0x00149850
		[Token(Token = "0x6003EB1")]
		[Address(RVA = "0x7F8120", Offset = "0x7F6720", VA = "0x1807F8120")]
		public IntModuloNode()
		{
		}

		// Token: 0x04002F7D RID: 12157
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002F7D")]
		public string a_PortName = "被除数";

		// Token: 0x04002F7E RID: 12158
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002F7E")]
		public string b_PortName = "除数";

		// Token: 0x04002F7F RID: 12159
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002F7F")]
		public string result_PortName = "余数";

		// Token: 0x04002F80 RID: 12160
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002F80")]
		[NonSerialized]
		private EventNodeBase aSourceNode;

		// Token: 0x04002F81 RID: 12161
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002F81")]
		[NonSerialized]
		private string aSourcePort;

		// Token: 0x04002F82 RID: 12162
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002F82")]
		[NonSerialized]
		private EventNodeBase bSourceNode;

		// Token: 0x04002F83 RID: 12163
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002F83")]
		[NonSerialized]
		private string bSourcePort;
	}
}
