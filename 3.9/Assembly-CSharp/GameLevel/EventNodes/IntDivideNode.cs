using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000C04 RID: 3076
	[Token(Token = "0x2000C04")]
	[Serializable]
	public class IntDivideNode : EventNodeBase
	{
		// Token: 0x06003FF9 RID: 16377 RVA: 0x00150500 File Offset: 0x0014E700
		[Token(Token = "0x6003FF9")]
		[Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "4")]
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

		// Token: 0x06003FFA RID: 16378 RVA: 0x0015055C File Offset: 0x0014E75C
		[Token(Token = "0x6003FFA")]
		[Address(RVA = "0x85F660", Offset = "0x85DC60", VA = "0x18085F660", Slot = "5")]
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

		// Token: 0x06003FFB RID: 16379 RVA: 0x00150594 File Offset: 0x0014E794
		[Token(Token = "0x6003FFB")]
		[Address(RVA = "0x85F750", Offset = "0x85DD50", VA = "0x18085F750", Slot = "7")]
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

		// Token: 0x06003FFC RID: 16380 RVA: 0x00150644 File Offset: 0x0014E844
		[Token(Token = "0x6003FFC")]
		[Address(RVA = "0xA6D0F0", Offset = "0xA6B6F0", VA = "0x180A6D0F0", Slot = "9")]
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
				if (num != 0)
				{
					int num2;
					int num3;
					EventNodeDebug.Log(string.Format("[IntDivideNode] {0} ÷ {1} = {2}", num2, num2, num3));
				}
			}
			string text;
			EventNodeDebug.LogWarning(text);
			throw new NullReferenceException();
		}

		// Token: 0x06003FFD RID: 16381 RVA: 0x001506C0 File Offset: 0x0014E8C0
		[Token(Token = "0x6003FFD")]
		[Address(RVA = "0x85F8A0", Offset = "0x85DEA0", VA = "0x18085F8A0")]
		public IntDivideNode()
		{
		}

		// Token: 0x040030EA RID: 12522
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40030EA")]
		public string a_PortName = "被除数";

		// Token: 0x040030EB RID: 12523
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40030EB")]
		public string b_PortName = "除数";

		// Token: 0x040030EC RID: 12524
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40030EC")]
		public string result_PortName = "商";

		// Token: 0x040030ED RID: 12525
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40030ED")]
		[NonSerialized]
		private EventNodeBase aSourceNode;

		// Token: 0x040030EE RID: 12526
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40030EE")]
		[NonSerialized]
		private string aSourcePort;

		// Token: 0x040030EF RID: 12527
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40030EF")]
		[NonSerialized]
		private EventNodeBase bSourceNode;

		// Token: 0x040030F0 RID: 12528
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40030F0")]
		[NonSerialized]
		private string bSourcePort;
	}
}
