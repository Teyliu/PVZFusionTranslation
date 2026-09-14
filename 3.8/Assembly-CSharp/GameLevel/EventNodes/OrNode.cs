using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BB0 RID: 2992
	[Token(Token = "0x2000BB0")]
	[Serializable]
	public class OrNode : EventNodeBase
	{
		// Token: 0x06003E4A RID: 15946 RVA: 0x00148BD4 File Offset: 0x00146DD4
		[Token(Token = "0x6003E4A")]
		[Address(RVA = "0x7FECE0", Offset = "0x7FD2E0", VA = "0x1807FECE0", Slot = "4")]
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

		// Token: 0x06003E4B RID: 15947 RVA: 0x00148C30 File Offset: 0x00146E30
		[Token(Token = "0x6003E4B")]
		[Address(RVA = "0x7FEE50", Offset = "0x7FD450", VA = "0x1807FEE50", Slot = "5")]
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

		// Token: 0x06003E4C RID: 15948 RVA: 0x00148C68 File Offset: 0x00146E68
		[Token(Token = "0x6003E4C")]
		[Address(RVA = "0x7FEF40", Offset = "0x7FD540", VA = "0x1807FEF40", Slot = "7")]
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

		// Token: 0x06003E4D RID: 15949 RVA: 0x00148D18 File Offset: 0x00146F18
		[Token(Token = "0x6003E4D")]
		[Address(RVA = "0x9F8D30", Offset = "0x9F7330", VA = "0x1809F8D30", Slot = "9")]
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
			string text = string.Format("[OrNode] {0} OR {1} → {2}", num2, num2, num2);
			EventNodeDebug.Log(text);
			throw new NullReferenceException();
		}

		// Token: 0x06003E4E RID: 15950 RVA: 0x00148D9C File Offset: 0x00146F9C
		[Token(Token = "0x6003E4E")]
		[Address(RVA = "0x7FF090", Offset = "0x7FD690", VA = "0x1807FF090")]
		public OrNode()
		{
		}

		// Token: 0x04002EF2 RID: 12018
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002EF2")]
		public string a_PortName = "条件A";

		// Token: 0x04002EF3 RID: 12019
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002EF3")]
		public string b_PortName = "条件B";

		// Token: 0x04002EF4 RID: 12020
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002EF4")]
		public string output_PortName = "结果";

		// Token: 0x04002EF5 RID: 12021
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002EF5")]
		[NonSerialized]
		private EventNodeBase aSourceNode;

		// Token: 0x04002EF6 RID: 12022
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002EF6")]
		[NonSerialized]
		private string aSourcePort;

		// Token: 0x04002EF7 RID: 12023
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002EF7")]
		[NonSerialized]
		private EventNodeBase bSourceNode;

		// Token: 0x04002EF8 RID: 12024
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002EF8")]
		[NonSerialized]
		private string bSourcePort;
	}
}
