using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BFA RID: 3066
	[Token(Token = "0x2000BFA")]
	[Serializable]
	public class DivideNode : EventNodeBase
	{
		// Token: 0x06003FC7 RID: 16327 RVA: 0x0014F040 File Offset: 0x0014D240
		[Token(Token = "0x6003FC7")]
		[Address(RVA = "0x85B830", Offset = "0x859E30", VA = "0x18085B830", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[2];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.a_PortName, (PortType)((uint)3), (PortDirection)num);
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			int num2;
			PortDefinition portDefinition2 = new PortDefinition(this.b_PortName, (PortType)((uint)3), (PortDirection)num2);
			num2 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003FC8 RID: 16328 RVA: 0x0014F09C File Offset: 0x0014D29C
		[Token(Token = "0x6003FC8")]
		[Address(RVA = "0x85B9A0", Offset = "0x859FA0", VA = "0x18085B9A0", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			PortDefinition portDefinition = new PortDefinition(this.result_PortName, (PortType)((uint)3), (PortDirection)((uint)1));
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003FC9 RID: 16329 RVA: 0x0014F0D4 File Offset: 0x0014D2D4
		[Token(Token = "0x6003FC9")]
		[Address(RVA = "0x85BA90", Offset = "0x85A090", VA = "0x18085BA90", Slot = "7")]
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

		// Token: 0x06003FCA RID: 16330 RVA: 0x0014F184 File Offset: 0x0014D384
		[Token(Token = "0x6003FCA")]
		[Address(RVA = "0xA0A420", Offset = "0xA08A20", VA = "0x180A0A420", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			if (this.aSourceNode != (ulong)0L)
			{
			}
			if (this.bSourceNode != (ulong)0L)
			{
			}
			float num;
			float num2;
			EventNodeDebug.Log(string.Format("[DivideNode] {0} ÷ {1} = {2}", num, num, num2));
			string nodeId = this.nodeId;
			EventNodeDebug.LogWarning("[DivideNode] 除数为零！返回0，节点ID: " + nodeId);
			throw new NullReferenceException();
		}

		// Token: 0x06003FCB RID: 16331 RVA: 0x0014F1FC File Offset: 0x0014D3FC
		[Token(Token = "0x6003FCB")]
		[Address(RVA = "0x85BBE0", Offset = "0x85A1E0", VA = "0x18085BBE0")]
		public DivideNode()
		{
		}

		// Token: 0x040030A2 RID: 12450
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40030A2")]
		public string a_PortName = "被除数";

		// Token: 0x040030A3 RID: 12451
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40030A3")]
		public string b_PortName = "除数";

		// Token: 0x040030A4 RID: 12452
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40030A4")]
		public string result_PortName = "商";

		// Token: 0x040030A5 RID: 12453
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40030A5")]
		[NonSerialized]
		private EventNodeBase aSourceNode;

		// Token: 0x040030A6 RID: 12454
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40030A6")]
		[NonSerialized]
		private string aSourcePort;

		// Token: 0x040030A7 RID: 12455
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40030A7")]
		[NonSerialized]
		private EventNodeBase bSourceNode;

		// Token: 0x040030A8 RID: 12456
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40030A8")]
		[NonSerialized]
		private string bSourcePort;
	}
}
