using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BF1 RID: 3057
	[Token(Token = "0x2000BF1")]
	[Serializable]
	public class AndNode : EventNodeBase
	{
		// Token: 0x06003F96 RID: 16278 RVA: 0x0014DC48 File Offset: 0x0014BE48
		[Token(Token = "0x6003F96")]
		[Address(RVA = "0x8565D0", Offset = "0x854BD0", VA = "0x1808565D0", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[2];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.a_PortName, (PortType)((uint)6), (PortDirection)num);
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			int num2;
			PortDefinition portDefinition2 = new PortDefinition(this.b_PortName, (PortType)((uint)6), (PortDirection)num2);
			num2 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003F97 RID: 16279 RVA: 0x0014DCA4 File Offset: 0x0014BEA4
		[Token(Token = "0x6003F97")]
		[Address(RVA = "0x856740", Offset = "0x854D40", VA = "0x180856740", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			PortDefinition portDefinition = new PortDefinition(this.output_PortName, (PortType)((uint)6), (PortDirection)((uint)1));
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003F98 RID: 16280 RVA: 0x0014DCDC File Offset: 0x0014BEDC
		[Token(Token = "0x6003F98")]
		[Address(RVA = "0x856830", Offset = "0x854E30", VA = "0x180856830", Slot = "7")]
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

		// Token: 0x06003F99 RID: 16281 RVA: 0x0014DD8C File Offset: 0x0014BF8C
		[Token(Token = "0x6003F99")]
		[Address(RVA = "0x95BC20", Offset = "0x95A220", VA = "0x18095BC20", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			if (this.aSourceNode != (ulong)0L)
			{
				bool flag;
				flag += flag;
			}
			int num = 0;
			bool flag2 = num != 0;
			if (this.bSourceNode != (ulong)0L)
			{
				num += 20;
				num += num;
			}
			int num2 = 0;
			bool flag3 = num2 != 0;
			string text = string.Format("[AndNode] {0} AND {1} → {2}", num2, num2, num2);
			EventNodeDebug.Log(text);
			throw new NullReferenceException();
		}

		// Token: 0x06003F9A RID: 16282 RVA: 0x0014DE10 File Offset: 0x0014C010
		[Token(Token = "0x6003F9A")]
		[Address(RVA = "0x856980", Offset = "0x854F80", VA = "0x180856980")]
		public AndNode()
		{
		}

		// Token: 0x0400305F RID: 12383
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400305F")]
		public string a_PortName = "条件A";

		// Token: 0x04003060 RID: 12384
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4003060")]
		public string b_PortName = "条件B";

		// Token: 0x04003061 RID: 12385
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4003061")]
		public string output_PortName = "结果";

		// Token: 0x04003062 RID: 12386
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4003062")]
		[NonSerialized]
		private EventNodeBase aSourceNode;

		// Token: 0x04003063 RID: 12387
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4003063")]
		[NonSerialized]
		private string aSourcePort;

		// Token: 0x04003064 RID: 12388
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4003064")]
		[NonSerialized]
		private EventNodeBase bSourceNode;

		// Token: 0x04003065 RID: 12389
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4003065")]
		[NonSerialized]
		private string bSourcePort;
	}
}
