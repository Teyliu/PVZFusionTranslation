using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BAF RID: 2991
	[Token(Token = "0x2000BAF")]
	[Serializable]
	public class AndNode : EventNodeBase
	{
		// Token: 0x06003E45 RID: 15941 RVA: 0x001489D8 File Offset: 0x00146BD8
		[Token(Token = "0x6003E45")]
		[Address(RVA = "0x7EEB00", Offset = "0x7ED100", VA = "0x1807EEB00", Slot = "4")]
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

		// Token: 0x06003E46 RID: 15942 RVA: 0x00148A34 File Offset: 0x00146C34
		[Token(Token = "0x6003E46")]
		[Address(RVA = "0x7EEC70", Offset = "0x7ED270", VA = "0x1807EEC70", Slot = "5")]
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

		// Token: 0x06003E47 RID: 15943 RVA: 0x00148A6C File Offset: 0x00146C6C
		[Token(Token = "0x6003E47")]
		[Address(RVA = "0x7EED60", Offset = "0x7ED360", VA = "0x1807EED60", Slot = "7")]
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

		// Token: 0x06003E48 RID: 15944 RVA: 0x00148B1C File Offset: 0x00146D1C
		[Token(Token = "0x6003E48")]
		[Address(RVA = "0x8BBC30", Offset = "0x8BA230", VA = "0x1808BBC30", Slot = "9")]
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

		// Token: 0x06003E49 RID: 15945 RVA: 0x00148BA0 File Offset: 0x00146DA0
		[Token(Token = "0x6003E49")]
		[Address(RVA = "0x7EEEB0", Offset = "0x7ED4B0", VA = "0x1807EEEB0")]
		public AndNode()
		{
		}

		// Token: 0x04002EEB RID: 12011
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002EEB")]
		public string a_PortName = "条件A";

		// Token: 0x04002EEC RID: 12012
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002EEC")]
		public string b_PortName = "条件B";

		// Token: 0x04002EED RID: 12013
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002EED")]
		public string output_PortName = "结果";

		// Token: 0x04002EEE RID: 12014
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002EEE")]
		[NonSerialized]
		private EventNodeBase aSourceNode;

		// Token: 0x04002EEF RID: 12015
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002EEF")]
		[NonSerialized]
		private string aSourcePort;

		// Token: 0x04002EF0 RID: 12016
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002EF0")]
		[NonSerialized]
		private EventNodeBase bSourceNode;

		// Token: 0x04002EF1 RID: 12017
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002EF1")]
		[NonSerialized]
		private string bSourcePort;
	}
}
