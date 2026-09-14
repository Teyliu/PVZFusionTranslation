using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BCD RID: 3021
	[Token(Token = "0x2000BCD")]
	[Serializable]
	public class CompareFloatNode : EventNodeBase
	{
		// Token: 0x06003EE3 RID: 16099 RVA: 0x0014A644 File Offset: 0x00148844
		[Token(Token = "0x6003EE3")]
		[Address(RVA = "0x857890", Offset = "0x855E90", VA = "0x180857890", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[2];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.valueA_PortName, (PortType)((uint)3), (PortDirection)num);
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			int num2;
			PortDefinition portDefinition2 = new PortDefinition(this.valueB_PortName, (PortType)((uint)3), (PortDirection)num2);
			num2 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003EE4 RID: 16100 RVA: 0x0014A6A0 File Offset: 0x001488A0
		[Token(Token = "0x6003EE4")]
		[Address(RVA = "0x857A00", Offset = "0x856000", VA = "0x180857A00", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[3];
			PortDefinition portDefinition = new PortDefinition(this.greater_PortName, (PortType)((uint)6), (PortDirection)((uint)1));
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			PortDefinition portDefinition2 = new PortDefinition(this.less_PortName, (PortType)((uint)6), (PortDirection)((uint)1));
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			PortDefinition portDefinition3 = new PortDefinition(this.equal_PortName, (PortType)((uint)6), (PortDirection)((uint)1));
			if (portDefinition3 != 0)
			{
			}
			array[2] = portDefinition3;
			return array;
		}

		// Token: 0x06003EE5 RID: 16101 RVA: 0x0014A714 File Offset: 0x00148914
		[Token(Token = "0x6003EE5")]
		[Address(RVA = "0x857BF0", Offset = "0x8561F0", VA = "0x180857BF0", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.valueA_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.valueASourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.valueASourcePort = sourcePortName;
			string text2 = this.valueB_PortName;
			string nodeId2 = this.nodeId;
			List<SourcePortInfo> sourceNodes2 = graph.GetSourceNodes(nodeId2, text2);
			int num3 = 0;
			EventNodeBase sourceNode2 = sourceNodes2[num3].sourceNode;
			this.valueBSourceNode = sourceNode2;
			int num4 = 0;
			string sourcePortName2 = sourceNodes2[num4].sourcePortName;
			this.valueBSourcePort = sourcePortName2;
		}

		// Token: 0x06003EE6 RID: 16102 RVA: 0x0014A7C4 File Offset: 0x001489C4
		[Token(Token = "0x6003EE6")]
		[Address(RVA = "0x9F4810", Offset = "0x9F2E10", VA = "0x1809F4810", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			if (this.valueASourceNode != (ulong)0L)
			{
			}
			if (this.valueBSourceNode != (ulong)0L)
			{
			}
			Type typeFromHandle = typeof(bool);
			Type type;
			bool flag = type.Equals(typeFromHandle);
			if (!flag || flag || flag || !flag)
			{
			}
			throw new NullReferenceException();
		}

		// Token: 0x06003EE7 RID: 16103 RVA: 0x0014A830 File Offset: 0x00148A30
		[Token(Token = "0x6003EE7")]
		[Address(RVA = "0x857D40", Offset = "0x856340", VA = "0x180857D40")]
		public CompareFloatNode()
		{
		}

		// Token: 0x04002FB7 RID: 12215
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002FB7")]
		public string valueA_PortName = "值A";

		// Token: 0x04002FB8 RID: 12216
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002FB8")]
		public string valueB_PortName = "值B";

		// Token: 0x04002FB9 RID: 12217
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002FB9")]
		public string greater_PortName = "大于";

		// Token: 0x04002FBA RID: 12218
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002FBA")]
		public string less_PortName = "小于";

		// Token: 0x04002FBB RID: 12219
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002FBB")]
		public string equal_PortName = "等于";

		// Token: 0x04002FBC RID: 12220
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002FBC")]
		[NonSerialized]
		private EventNodeBase valueASourceNode;

		// Token: 0x04002FBD RID: 12221
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002FBD")]
		[NonSerialized]
		private string valueASourcePort;

		// Token: 0x04002FBE RID: 12222
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002FBE")]
		[NonSerialized]
		private EventNodeBase valueBSourceNode;

		// Token: 0x04002FBF RID: 12223
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002FBF")]
		[NonSerialized]
		private string valueBSourcePort;
	}
}
