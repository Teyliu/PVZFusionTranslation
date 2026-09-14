using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BCF RID: 3023
	[Token(Token = "0x2000BCF")]
	[Serializable]
	public class ComparePlantTypeNode : EventNodeBase
	{
		// Token: 0x06003EED RID: 16109 RVA: 0x0014AAB0 File Offset: 0x00148CB0
		[Token(Token = "0x6003EED")]
		[Address(RVA = "0x858820", Offset = "0x856E20", VA = "0x180858820", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[2];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.plantTypeA_PortName, (PortType)((uint)9), (PortDirection)num);
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			int num2;
			PortDefinition portDefinition2 = new PortDefinition(this.plantTypeB_PortName, (PortType)((uint)9), (PortDirection)num2);
			num2 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003EEE RID: 16110 RVA: 0x0014AB0C File Offset: 0x00148D0C
		[Token(Token = "0x6003EEE")]
		[Address(RVA = "0x858990", Offset = "0x856F90", VA = "0x180858990", Slot = "5")]
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

		// Token: 0x06003EEF RID: 16111 RVA: 0x0014AB44 File Offset: 0x00148D44
		[Token(Token = "0x6003EEF")]
		[Address(RVA = "0x858A80", Offset = "0x857080", VA = "0x180858A80", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.plantTypeA_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.plantTypeASourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.plantTypeASourcePort = sourcePortName;
			string text2 = this.plantTypeB_PortName;
			string nodeId2 = this.nodeId;
			List<SourcePortInfo> sourceNodes2 = graph.GetSourceNodes(nodeId2, text2);
			int num3 = 0;
			EventNodeBase sourceNode2 = sourceNodes2[num3].sourceNode;
			this.plantTypeBSourceNode = sourceNode2;
			int num4 = 0;
			string sourcePortName2 = sourceNodes2[num4].sourcePortName;
			this.plantTypeBSourcePort = sourcePortName2;
		}

		// Token: 0x06003EF0 RID: 16112 RVA: 0x0014ABF4 File Offset: 0x00148DF4
		[Token(Token = "0x6003EF0")]
		[Address(RVA = "0x9F7630", Offset = "0x9F5C30", VA = "0x1809F7630", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			Type typeFromHandle = typeof(Type);
			Type typeFromHandle2 = typeof(bool);
			if (typeFromHandle.Equals(typeFromHandle2))
			{
				if (this.plantTypeASourceNode != (ulong)0L)
				{
				}
				int num = 0;
				if (this.plantTypeBSourceNode != (ulong)0L)
				{
				}
				int num2 = 0;
				bool flag = num == num2;
				PlantType plantType;
				PlantType plantType2;
				string text = string.Format("[ComparePlantTypeNode] {0} == {1} → {2}", plantType, plantType2, plantType2);
				EventNodeDebug.Log(text);
			}
			throw new InvalidCastException();
		}

		// Token: 0x06003EF1 RID: 16113 RVA: 0x0014AC84 File Offset: 0x00148E84
		[Token(Token = "0x6003EF1")]
		[Address(RVA = "0x858BD0", Offset = "0x8571D0", VA = "0x180858BD0")]
		public ComparePlantTypeNode()
		{
		}

		// Token: 0x04002FC9 RID: 12233
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002FC9")]
		public string plantTypeA_PortName = "植物类型A";

		// Token: 0x04002FCA RID: 12234
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002FCA")]
		public string plantTypeB_PortName = "植物类型B";

		// Token: 0x04002FCB RID: 12235
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002FCB")]
		public string equal_PortName = "相同";

		// Token: 0x04002FCC RID: 12236
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002FCC")]
		[NonSerialized]
		private EventNodeBase plantTypeASourceNode;

		// Token: 0x04002FCD RID: 12237
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002FCD")]
		[NonSerialized]
		private string plantTypeASourcePort;

		// Token: 0x04002FCE RID: 12238
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002FCE")]
		[NonSerialized]
		private EventNodeBase plantTypeBSourceNode;

		// Token: 0x04002FCF RID: 12239
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002FCF")]
		[NonSerialized]
		private string plantTypeBSourcePort;
	}
}
