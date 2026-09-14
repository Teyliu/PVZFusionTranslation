using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B8D RID: 2957
	[Token(Token = "0x2000B8D")]
	[Serializable]
	public class ComparePlantTypeNode : EventNodeBase
	{
		// Token: 0x06003D9C RID: 15772 RVA: 0x0014583C File Offset: 0x00143A3C
		[Token(Token = "0x6003D9C")]
		[Address(RVA = "0x7F0D50", Offset = "0x7EF350", VA = "0x1807F0D50", Slot = "4")]
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

		// Token: 0x06003D9D RID: 15773 RVA: 0x00145898 File Offset: 0x00143A98
		[Token(Token = "0x6003D9D")]
		[Address(RVA = "0x7F0EC0", Offset = "0x7EF4C0", VA = "0x1807F0EC0", Slot = "5")]
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

		// Token: 0x06003D9E RID: 15774 RVA: 0x001458D0 File Offset: 0x00143AD0
		[Token(Token = "0x6003D9E")]
		[Address(RVA = "0x7F0FB0", Offset = "0x7EF5B0", VA = "0x1807F0FB0", Slot = "7")]
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

		// Token: 0x06003D9F RID: 15775 RVA: 0x00145980 File Offset: 0x00143B80
		[Token(Token = "0x6003D9F")]
		[Address(RVA = "0x938A40", Offset = "0x937040", VA = "0x180938A40", Slot = "9")]
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

		// Token: 0x06003DA0 RID: 15776 RVA: 0x00145A10 File Offset: 0x00143C10
		[Token(Token = "0x6003DA0")]
		[Address(RVA = "0x7F1100", Offset = "0x7EF700", VA = "0x1807F1100")]
		public ComparePlantTypeNode()
		{
		}

		// Token: 0x04002E55 RID: 11861
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002E55")]
		public string plantTypeA_PortName = "植物类型A";

		// Token: 0x04002E56 RID: 11862
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002E56")]
		public string plantTypeB_PortName = "植物类型B";

		// Token: 0x04002E57 RID: 11863
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002E57")]
		public string equal_PortName = "相同";

		// Token: 0x04002E58 RID: 11864
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002E58")]
		[NonSerialized]
		private EventNodeBase plantTypeASourceNode;

		// Token: 0x04002E59 RID: 11865
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002E59")]
		[NonSerialized]
		private string plantTypeASourcePort;

		// Token: 0x04002E5A RID: 11866
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002E5A")]
		[NonSerialized]
		private EventNodeBase plantTypeBSourceNode;

		// Token: 0x04002E5B RID: 11867
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002E5B")]
		[NonSerialized]
		private string plantTypeBSourcePort;
	}
}
