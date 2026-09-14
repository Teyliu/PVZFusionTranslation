using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000C01 RID: 3073
	[Token(Token = "0x2000C01")]
	[Serializable]
	public class IntAddNode : EventNodeBase
	{
		// Token: 0x06003FEA RID: 16362 RVA: 0x0014FF28 File Offset: 0x0014E128
		[Token(Token = "0x6003FEA")]
		[Address(RVA = "0x85F0A0", Offset = "0x85D6A0", VA = "0x18085F0A0", Slot = "4")]
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

		// Token: 0x06003FEB RID: 16363 RVA: 0x0014FF84 File Offset: 0x0014E184
		[Token(Token = "0x6003FEB")]
		[Address(RVA = "0x85F210", Offset = "0x85D810", VA = "0x18085F210", Slot = "5")]
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

		// Token: 0x06003FEC RID: 16364 RVA: 0x0014FFBC File Offset: 0x0014E1BC
		[Token(Token = "0x6003FEC")]
		[Address(RVA = "0x85F300", Offset = "0x85D900", VA = "0x18085F300", Slot = "7")]
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

		// Token: 0x06003FED RID: 16365 RVA: 0x0015006C File Offset: 0x0014E26C
		[Token(Token = "0x6003FED")]
		[Address(RVA = "0xA6C360", Offset = "0xA6A960", VA = "0x180A6C360", Slot = "9")]
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
			}
			int num2;
			int num3;
			int num4;
			EventNodeDebug.Log(string.Format("[IntAddNode] {0} + {1} = {2}", num2, num3, num4));
			throw new NullReferenceException();
		}

		// Token: 0x06003FEE RID: 16366 RVA: 0x001500E4 File Offset: 0x0014E2E4
		[Token(Token = "0x6003FEE")]
		[Address(RVA = "0x85F450", Offset = "0x85DA50", VA = "0x18085F450")]
		public IntAddNode()
		{
		}

		// Token: 0x040030D5 RID: 12501
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40030D5")]
		public string a_PortName = "A";

		// Token: 0x040030D6 RID: 12502
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40030D6")]
		public string b_PortName = "B";

		// Token: 0x040030D7 RID: 12503
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40030D7")]
		public string result_PortName = "和";

		// Token: 0x040030D8 RID: 12504
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40030D8")]
		[NonSerialized]
		private EventNodeBase aSourceNode;

		// Token: 0x040030D9 RID: 12505
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40030D9")]
		[NonSerialized]
		private string aSourcePort;

		// Token: 0x040030DA RID: 12506
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40030DA")]
		[NonSerialized]
		private EventNodeBase bSourceNode;

		// Token: 0x040030DB RID: 12507
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40030DB")]
		[NonSerialized]
		private string bSourcePort;
	}
}
