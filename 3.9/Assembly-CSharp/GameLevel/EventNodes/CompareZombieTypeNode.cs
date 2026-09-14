using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BD0 RID: 3024
	[Token(Token = "0x2000BD0")]
	[Serializable]
	public class CompareZombieTypeNode : EventNodeBase
	{
		// Token: 0x06003EF2 RID: 16114 RVA: 0x0014ACB8 File Offset: 0x00148EB8
		[Token(Token = "0x6003EF2")]
		[Address(RVA = "0x858C70", Offset = "0x857270", VA = "0x180858C70", Slot = "4")]
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

		// Token: 0x06003EF3 RID: 16115 RVA: 0x0014AD14 File Offset: 0x00148F14
		[Token(Token = "0x6003EF3")]
		[Address(RVA = "0x858DE0", Offset = "0x8573E0", VA = "0x180858DE0", Slot = "5")]
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

		// Token: 0x06003EF4 RID: 16116 RVA: 0x0014AD4C File Offset: 0x00148F4C
		[Token(Token = "0x6003EF4")]
		[Address(RVA = "0x858ED0", Offset = "0x8574D0", VA = "0x180858ED0", Slot = "7")]
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

		// Token: 0x06003EF5 RID: 16117 RVA: 0x0014ADFC File Offset: 0x00148FFC
		[Token(Token = "0x6003EF5")]
		[Address(RVA = "0x9F8520", Offset = "0x9F6B20", VA = "0x1809F8520", Slot = "9")]
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

		// Token: 0x06003EF6 RID: 16118 RVA: 0x0014AE8C File Offset: 0x0014908C
		[Token(Token = "0x6003EF6")]
		[Address(RVA = "0x859020", Offset = "0x857620", VA = "0x180859020")]
		public CompareZombieTypeNode()
		{
		}

		// Token: 0x04002FD0 RID: 12240
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002FD0")]
		public string zombieTypeA_PortName = "僵尸类型A";

		// Token: 0x04002FD1 RID: 12241
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002FD1")]
		public string zombieTypeB_PortName = "僵尸类型B";

		// Token: 0x04002FD2 RID: 12242
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002FD2")]
		public string equal_PortName = "相同";

		// Token: 0x04002FD3 RID: 12243
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002FD3")]
		[NonSerialized]
		private EventNodeBase zombieTypeASourceNode;

		// Token: 0x04002FD4 RID: 12244
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002FD4")]
		[NonSerialized]
		private string zombieTypeASourcePort;

		// Token: 0x04002FD5 RID: 12245
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002FD5")]
		[NonSerialized]
		private EventNodeBase zombieTypeBSourceNode;

		// Token: 0x04002FD6 RID: 12246
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002FD6")]
		[NonSerialized]
		private string zombieTypeBSourcePort;
	}
}
