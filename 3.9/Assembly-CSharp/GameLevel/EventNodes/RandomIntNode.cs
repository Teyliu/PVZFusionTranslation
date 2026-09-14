using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BFC RID: 3068
	[Token(Token = "0x2000BFC")]
	[Serializable]
	public class RandomIntNode : EventNodeBase
	{
		// Token: 0x06003FD1 RID: 16337 RVA: 0x0014F448 File Offset: 0x0014D648
		[Token(Token = "0x6003FD1")]
		[Address(RVA = "0x869D80", Offset = "0x868380", VA = "0x180869D80", Slot = "4")]
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

		// Token: 0x06003FD2 RID: 16338 RVA: 0x0014F4A4 File Offset: 0x0014D6A4
		[Token(Token = "0x6003FD2")]
		[Address(RVA = "0x869EF0", Offset = "0x8684F0", VA = "0x180869EF0", Slot = "5")]
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

		// Token: 0x06003FD3 RID: 16339 RVA: 0x0014F4DC File Offset: 0x0014D6DC
		[Token(Token = "0x6003FD3")]
		[Address(RVA = "0x869FE0", Offset = "0x8685E0", VA = "0x180869FE0", Slot = "7")]
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

		// Token: 0x06003FD4 RID: 16340 RVA: 0x0014F58C File Offset: 0x0014D78C
		[Token(Token = "0x6003FD4")]
		[Address(RVA = "0xAB10F0", Offset = "0xAAF6F0", VA = "0x180AB10F0", Slot = "9")]
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

		// Token: 0x06003FD5 RID: 16341 RVA: 0x0014F604 File Offset: 0x0014D804
		[Token(Token = "0x6003FD5")]
		[Address(RVA = "0x86A130", Offset = "0x868730", VA = "0x18086A130")]
		public RandomIntNode()
		{
		}

		// Token: 0x040030B0 RID: 12464
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40030B0")]
		public string min_PortName = "最小值";

		// Token: 0x040030B1 RID: 12465
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40030B1")]
		public string max_PortName = "最大值";

		// Token: 0x040030B2 RID: 12466
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40030B2")]
		public string result_PortName = "随机整数";

		// Token: 0x040030B3 RID: 12467
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40030B3")]
		[NonSerialized]
		private EventNodeBase minSourceNode;

		// Token: 0x040030B4 RID: 12468
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40030B4")]
		[NonSerialized]
		private string minSourcePort;

		// Token: 0x040030B5 RID: 12469
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40030B5")]
		[NonSerialized]
		private EventNodeBase maxSourceNode;

		// Token: 0x040030B6 RID: 12470
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40030B6")]
		[NonSerialized]
		private string maxSourcePort;
	}
}
