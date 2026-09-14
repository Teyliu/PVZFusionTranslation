using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000C03 RID: 3075
	[Token(Token = "0x2000C03")]
	[Serializable]
	public class IntMultiplyNode : EventNodeBase
	{
		// Token: 0x06003FF4 RID: 16372 RVA: 0x0015030C File Offset: 0x0014E50C
		[Token(Token = "0x6003FF4")]
		[Address(RVA = "0x85FD90", Offset = "0x85E390", VA = "0x18085FD90", Slot = "4")]
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

		// Token: 0x06003FF5 RID: 16373 RVA: 0x00150368 File Offset: 0x0014E568
		[Token(Token = "0x6003FF5")]
		[Address(RVA = "0x85FF00", Offset = "0x85E500", VA = "0x18085FF00", Slot = "5")]
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

		// Token: 0x06003FF6 RID: 16374 RVA: 0x001503A0 File Offset: 0x0014E5A0
		[Token(Token = "0x6003FF6")]
		[Address(RVA = "0x85FFF0", Offset = "0x85E5F0", VA = "0x18085FFF0", Slot = "7")]
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

		// Token: 0x06003FF7 RID: 16375 RVA: 0x00150450 File Offset: 0x0014E650
		[Token(Token = "0x6003FF7")]
		[Address(RVA = "0xA6F3F0", Offset = "0xA6D9F0", VA = "0x180A6F3F0", Slot = "9")]
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
			int num3 = 0 * num2;
			int num4;
			int num5;
			string text = string.Format("[IntMultiplyNode] {0} × {1} = {2}", num4, num5, num5);
			EventNodeDebug.Log(text);
			throw new NullReferenceException();
		}

		// Token: 0x06003FF8 RID: 16376 RVA: 0x001504CC File Offset: 0x0014E6CC
		[Token(Token = "0x6003FF8")]
		[Address(RVA = "0x860140", Offset = "0x85E740", VA = "0x180860140")]
		public IntMultiplyNode()
		{
		}

		// Token: 0x040030E3 RID: 12515
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40030E3")]
		public string a_PortName = "A";

		// Token: 0x040030E4 RID: 12516
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40030E4")]
		public string b_PortName = "B";

		// Token: 0x040030E5 RID: 12517
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40030E5")]
		public string result_PortName = "积";

		// Token: 0x040030E6 RID: 12518
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40030E6")]
		[NonSerialized]
		private EventNodeBase aSourceNode;

		// Token: 0x040030E7 RID: 12519
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40030E7")]
		[NonSerialized]
		private string aSourcePort;

		// Token: 0x040030E8 RID: 12520
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40030E8")]
		[NonSerialized]
		private EventNodeBase bSourceNode;

		// Token: 0x040030E9 RID: 12521
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40030E9")]
		[NonSerialized]
		private string bSourcePort;
	}
}
