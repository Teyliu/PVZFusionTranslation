using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B8E RID: 2958
	[Token(Token = "0x2000B8E")]
	[Serializable]
	public class CompareZombieTypeNode : EventNodeBase
	{
		// Token: 0x06003DA1 RID: 15777 RVA: 0x00145A44 File Offset: 0x00143C44
		[Token(Token = "0x6003DA1")]
		[Address(RVA = "0x7F11A0", Offset = "0x7EF7A0", VA = "0x1807F11A0", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[2];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.zombieTypeA_PortName, (PortType)((uint)10), (PortDirection)num);
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			int num2;
			PortDefinition portDefinition2 = new PortDefinition(this.zombieTypeB_PortName, (PortType)((uint)10), (PortDirection)num2);
			num2 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003DA2 RID: 15778 RVA: 0x00145AA0 File Offset: 0x00143CA0
		[Token(Token = "0x6003DA2")]
		[Address(RVA = "0x7F1310", Offset = "0x7EF910", VA = "0x1807F1310", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			PortDefinition portDefinition = new PortDefinition(this.equal_PortName, (PortType)((uint)6), (PortDirection)((uint)1));
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003DA3 RID: 15779 RVA: 0x00145AD8 File Offset: 0x00143CD8
		[Token(Token = "0x6003DA3")]
		[Address(RVA = "0x7F1400", Offset = "0x7EFA00", VA = "0x1807F1400", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.zombieTypeA_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.zombieTypeASourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.zombieTypeASourcePort = sourcePortName;
			string text2 = this.zombieTypeB_PortName;
			string nodeId2 = this.nodeId;
			List<SourcePortInfo> sourceNodes2 = graph.GetSourceNodes(nodeId2, text2);
			int num3 = 0;
			EventNodeBase sourceNode2 = sourceNodes2[num3].sourceNode;
			this.zombieTypeBSourceNode = sourceNode2;
			int num4 = 0;
			string sourcePortName2 = sourceNodes2[num4].sourcePortName;
			this.zombieTypeBSourcePort = sourcePortName2;
		}

		// Token: 0x06003DA4 RID: 15780 RVA: 0x00145B88 File Offset: 0x00143D88
		[Token(Token = "0x6003DA4")]
		[Address(RVA = "0x939930", Offset = "0x937F30", VA = "0x180939930", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			Type typeFromHandle = typeof(Type);
			Type typeFromHandle2 = typeof(bool);
			if (typeFromHandle.Equals(typeFromHandle2))
			{
				if (this.zombieTypeASourceNode != (ulong)0L)
				{
				}
				int num = 0;
				if (this.zombieTypeBSourceNode != (ulong)0L)
				{
				}
				int num2 = 0;
				bool flag = num == num2;
				ZombieType zombieType;
				ZombieType zombieType2;
				string text = string.Format("[CompareZombieTypeNode] {0} == {1} → {2}", zombieType, zombieType2, zombieType2);
				EventNodeDebug.Log(text);
			}
			throw new InvalidCastException();
		}

		// Token: 0x06003DA5 RID: 15781 RVA: 0x00145C18 File Offset: 0x00143E18
		[Token(Token = "0x6003DA5")]
		[Address(RVA = "0x7F1550", Offset = "0x7EFB50", VA = "0x1807F1550")]
		public CompareZombieTypeNode()
		{
		}

		// Token: 0x04002E5C RID: 11868
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002E5C")]
		public string zombieTypeA_PortName = "僵尸类型A";

		// Token: 0x04002E5D RID: 11869
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002E5D")]
		public string zombieTypeB_PortName = "僵尸类型B";

		// Token: 0x04002E5E RID: 11870
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002E5E")]
		public string equal_PortName = "相同";

		// Token: 0x04002E5F RID: 11871
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002E5F")]
		[NonSerialized]
		private EventNodeBase zombieTypeASourceNode;

		// Token: 0x04002E60 RID: 11872
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002E60")]
		[NonSerialized]
		private string zombieTypeASourcePort;

		// Token: 0x04002E61 RID: 11873
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002E61")]
		[NonSerialized]
		private EventNodeBase zombieTypeBSourceNode;

		// Token: 0x04002E62 RID: 11874
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002E62")]
		[NonSerialized]
		private string zombieTypeBSourcePort;
	}
}
