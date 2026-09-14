using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B8C RID: 2956
	[Token(Token = "0x2000B8C")]
	[Serializable]
	public class CompareIntNode : EventNodeBase
	{
		// Token: 0x06003D97 RID: 15767 RVA: 0x00145608 File Offset: 0x00143808
		[Token(Token = "0x6003D97")]
		[Address(RVA = "0x7F07B0", Offset = "0x7EEDB0", VA = "0x1807F07B0", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[2];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.valueA_PortName, (PortType)((uint)1), (PortDirection)num);
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			int num2;
			PortDefinition portDefinition2 = new PortDefinition(this.valueB_PortName, (PortType)((uint)1), (PortDirection)num2);
			num2 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003D98 RID: 15768 RVA: 0x00145664 File Offset: 0x00143864
		[Token(Token = "0x6003D98")]
		[Address(RVA = "0x7F0920", Offset = "0x7EEF20", VA = "0x1807F0920", Slot = "5")]
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

		// Token: 0x06003D99 RID: 15769 RVA: 0x001456D8 File Offset: 0x001438D8
		[Token(Token = "0x6003D99")]
		[Address(RVA = "0x7F0B10", Offset = "0x7EF110", VA = "0x1807F0B10", Slot = "7")]
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

		// Token: 0x06003D9A RID: 15770 RVA: 0x00145788 File Offset: 0x00143988
		[Token(Token = "0x6003D9A")]
		[Address(RVA = "0x937BF0", Offset = "0x9361F0", VA = "0x180937BF0", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			int num = 0;
			if (this.valueASourceNode != num)
			{
			}
			if (this.valueBSourceNode != num)
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

		// Token: 0x06003D9B RID: 15771 RVA: 0x001457F0 File Offset: 0x001439F0
		[Token(Token = "0x6003D9B")]
		[Address(RVA = "0x7F0C60", Offset = "0x7EF260", VA = "0x1807F0C60")]
		public CompareIntNode()
		{
		}

		// Token: 0x04002E4C RID: 11852
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002E4C")]
		public string valueA_PortName = "值A";

		// Token: 0x04002E4D RID: 11853
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002E4D")]
		public string valueB_PortName = "值B";

		// Token: 0x04002E4E RID: 11854
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002E4E")]
		public string greater_PortName = "大于";

		// Token: 0x04002E4F RID: 11855
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002E4F")]
		public string less_PortName = "小于";

		// Token: 0x04002E50 RID: 11856
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002E50")]
		public string equal_PortName = "等于";

		// Token: 0x04002E51 RID: 11857
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002E51")]
		[NonSerialized]
		private EventNodeBase valueASourceNode;

		// Token: 0x04002E52 RID: 11858
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002E52")]
		[NonSerialized]
		private string valueASourcePort;

		// Token: 0x04002E53 RID: 11859
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002E53")]
		[NonSerialized]
		private EventNodeBase valueBSourceNode;

		// Token: 0x04002E54 RID: 11860
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002E54")]
		[NonSerialized]
		private string valueBSourcePort;
	}
}
