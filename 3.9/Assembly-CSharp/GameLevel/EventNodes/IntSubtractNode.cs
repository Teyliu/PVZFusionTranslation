using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000C02 RID: 3074
	[Token(Token = "0x2000C02")]
	[Serializable]
	public class IntSubtractNode : EventNodeBase
	{
		// Token: 0x06003FEF RID: 16367 RVA: 0x00150118 File Offset: 0x0014E318
		[Token(Token = "0x6003FEF")]
		[Address(RVA = "0x8601E0", Offset = "0x85E7E0", VA = "0x1808601E0", Slot = "4")]
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

		// Token: 0x06003FF0 RID: 16368 RVA: 0x00150174 File Offset: 0x0014E374
		[Token(Token = "0x6003FF0")]
		[Address(RVA = "0x860350", Offset = "0x85E950", VA = "0x180860350", Slot = "5")]
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

		// Token: 0x06003FF1 RID: 16369 RVA: 0x001501AC File Offset: 0x0014E3AC
		[Token(Token = "0x6003FF1")]
		[Address(RVA = "0x860440", Offset = "0x85EA40", VA = "0x180860440", Slot = "7")]
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

		// Token: 0x06003FF2 RID: 16370 RVA: 0x0015025C File Offset: 0x0014E45C
		[Token(Token = "0x6003FF2")]
		[Address(RVA = "0xA70180", Offset = "0xA6E780", VA = "0x180A70180", Slot = "9")]
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

		// Token: 0x06003FF3 RID: 16371 RVA: 0x001502D8 File Offset: 0x0014E4D8
		[Token(Token = "0x6003FF3")]
		[Address(RVA = "0x860590", Offset = "0x85EB90", VA = "0x180860590")]
		public IntSubtractNode()
		{
		}

		// Token: 0x040030DC RID: 12508
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40030DC")]
		public string a_PortName = "被减数";

		// Token: 0x040030DD RID: 12509
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40030DD")]
		public string b_PortName = "减数";

		// Token: 0x040030DE RID: 12510
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40030DE")]
		public string result_PortName = "差";

		// Token: 0x040030DF RID: 12511
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40030DF")]
		[NonSerialized]
		private EventNodeBase aSourceNode;

		// Token: 0x040030E0 RID: 12512
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40030E0")]
		[NonSerialized]
		private string aSourcePort;

		// Token: 0x040030E1 RID: 12513
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40030E1")]
		[NonSerialized]
		private EventNodeBase bSourceNode;

		// Token: 0x040030E2 RID: 12514
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40030E2")]
		[NonSerialized]
		private string bSourcePort;
	}
}
