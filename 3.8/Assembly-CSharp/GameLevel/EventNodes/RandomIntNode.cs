using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BBA RID: 3002
	[Token(Token = "0x2000BBA")]
	[Serializable]
	public class RandomIntNode : EventNodeBase
	{
		// Token: 0x06003E80 RID: 16000 RVA: 0x0014A1D8 File Offset: 0x001483D8
		[Token(Token = "0x6003E80")]
		[Address(RVA = "0x8023D0", Offset = "0x8009D0", VA = "0x1808023D0", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[2];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.min_PortName, (PortType)((uint)1), (PortDirection)num);
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			int num2;
			PortDefinition portDefinition2 = new PortDefinition(this.max_PortName, (PortType)((uint)1), (PortDirection)num2);
			num2 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003E81 RID: 16001 RVA: 0x0014A234 File Offset: 0x00148434
		[Token(Token = "0x6003E81")]
		[Address(RVA = "0x802540", Offset = "0x800B40", VA = "0x180802540", Slot = "5")]
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

		// Token: 0x06003E82 RID: 16002 RVA: 0x0014A26C File Offset: 0x0014846C
		[Token(Token = "0x6003E82")]
		[Address(RVA = "0x802630", Offset = "0x800C30", VA = "0x180802630", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.min_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.minSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.minSourcePort = sourcePortName;
			string text2 = this.max_PortName;
			string nodeId2 = this.nodeId;
			List<SourcePortInfo> sourceNodes2 = graph.GetSourceNodes(nodeId2, text2);
			int num3 = 0;
			EventNodeBase sourceNode2 = sourceNodes2[num3].sourceNode;
			this.maxSourceNode = sourceNode2;
			int num4 = 0;
			string sourcePortName2 = sourceNodes2[num4].sourcePortName;
			this.maxSourcePort = sourcePortName2;
		}

		// Token: 0x06003E83 RID: 16003 RVA: 0x0014A31C File Offset: 0x0014851C
		[Token(Token = "0x6003E83")]
		[Address(RVA = "0x9FF8B0", Offset = "0x9FDEB0", VA = "0x1809FF8B0", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			int num;
			if (this.minSourceNode != (ulong)0L)
			{
				num += 20;
				num += num;
			}
			if (this.maxSourceNode != (ulong)0L)
			{
				num += 20;
				num += num;
			}
			int num2;
			int num3;
			string text = string.Format("[RandomIntNode] 生成随机整数: {0} (范围: {1}-{2})", num, num2, num3);
			EventNodeDebug.Log(text);
			throw new NullReferenceException();
		}

		// Token: 0x06003E84 RID: 16004 RVA: 0x0014A394 File Offset: 0x00148594
		[Token(Token = "0x6003E84")]
		[Address(RVA = "0x802780", Offset = "0x800D80", VA = "0x180802780")]
		public RandomIntNode()
		{
		}

		// Token: 0x04002F3C RID: 12092
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002F3C")]
		public string min_PortName = "最小值";

		// Token: 0x04002F3D RID: 12093
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002F3D")]
		public string max_PortName = "最大值";

		// Token: 0x04002F3E RID: 12094
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002F3E")]
		public string result_PortName = "随机整数";

		// Token: 0x04002F3F RID: 12095
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002F3F")]
		[NonSerialized]
		private EventNodeBase minSourceNode;

		// Token: 0x04002F40 RID: 12096
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002F40")]
		[NonSerialized]
		private string minSourcePort;

		// Token: 0x04002F41 RID: 12097
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002F41")]
		[NonSerialized]
		private EventNodeBase maxSourceNode;

		// Token: 0x04002F42 RID: 12098
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002F42")]
		[NonSerialized]
		private string maxSourcePort;
	}
}
