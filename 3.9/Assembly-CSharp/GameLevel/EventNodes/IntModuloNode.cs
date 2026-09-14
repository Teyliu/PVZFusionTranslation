using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000C05 RID: 3077
	[Token(Token = "0x2000C05")]
	[Serializable]
	public class IntModuloNode : EventNodeBase
	{
		// Token: 0x06003FFE RID: 16382 RVA: 0x001506F4 File Offset: 0x0014E8F4
		[Token(Token = "0x6003FFE")]
		[Address(RVA = "0x85F940", Offset = "0x85DF40", VA = "0x18085F940", Slot = "4")]
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

		// Token: 0x06003FFF RID: 16383 RVA: 0x00150750 File Offset: 0x0014E950
		[Token(Token = "0x6003FFF")]
		[Address(RVA = "0x85FAB0", Offset = "0x85E0B0", VA = "0x18085FAB0", Slot = "5")]
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

		// Token: 0x06004000 RID: 16384 RVA: 0x00150788 File Offset: 0x0014E988
		[Token(Token = "0x6004000")]
		[Address(RVA = "0x85FBA0", Offset = "0x85E1A0", VA = "0x18085FBA0", Slot = "7")]
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

		// Token: 0x06004001 RID: 16385 RVA: 0x00150838 File Offset: 0x0014EA38
		[Token(Token = "0x6004001")]
		[Address(RVA = "0xA6E270", Offset = "0xA6C870", VA = "0x180A6E270", Slot = "9")]
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

		// Token: 0x06004002 RID: 16386 RVA: 0x001508BC File Offset: 0x0014EABC
		[Token(Token = "0x6004002")]
		[Address(RVA = "0x85FCF0", Offset = "0x85E2F0", VA = "0x18085FCF0")]
		public IntModuloNode()
		{
		}

		// Token: 0x040030F1 RID: 12529
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40030F1")]
		public string a_PortName = "被除数";

		// Token: 0x040030F2 RID: 12530
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40030F2")]
		public string b_PortName = "除数";

		// Token: 0x040030F3 RID: 12531
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40030F3")]
		public string result_PortName = "余数";

		// Token: 0x040030F4 RID: 12532
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40030F4")]
		[NonSerialized]
		private EventNodeBase aSourceNode;

		// Token: 0x040030F5 RID: 12533
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40030F5")]
		[NonSerialized]
		private string aSourcePort;

		// Token: 0x040030F6 RID: 12534
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40030F6")]
		[NonSerialized]
		private EventNodeBase bSourceNode;

		// Token: 0x040030F7 RID: 12535
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40030F7")]
		[NonSerialized]
		private string bSourcePort;
	}
}
