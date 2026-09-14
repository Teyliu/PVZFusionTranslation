using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BCE RID: 3022
	[Token(Token = "0x2000BCE")]
	[Serializable]
	public class CompareIntNode : EventNodeBase
	{
		// Token: 0x06003EE8 RID: 16104 RVA: 0x0014A87C File Offset: 0x00148A7C
		[Token(Token = "0x6003EE8")]
		[Address(RVA = "0x858280", Offset = "0x856880", VA = "0x180858280", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[2];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.valueA_PortName, (PortType)((uint)1), (PortDirection)num);
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			int num2;
			PortDefinition portDefinition2 = new PortDefinition(this.valueB_PortName, (PortType)((uint)1), (PortDirection)num2);
			num2 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003EE9 RID: 16105 RVA: 0x0014A8D8 File Offset: 0x00148AD8
		[Token(Token = "0x6003EE9")]
		[Address(RVA = "0x8583F0", Offset = "0x8569F0", VA = "0x1808583F0", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[3];
			PortDefinition portDefinition = new PortDefinition(this.greater_PortName, (PortType)((uint)6), (PortDirection)((uint)1));
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			PortDefinition portDefinition2 = new PortDefinition(this.less_PortName, (PortType)((uint)6), (PortDirection)((uint)1));
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			PortDefinition portDefinition3 = new PortDefinition(this.equal_PortName, (PortType)((uint)6), (PortDirection)((uint)1));
			if (portDefinition3 != 0)
			{
			}
			array[2] = portDefinition3;
			return array;
		}

		// Token: 0x06003EEA RID: 16106 RVA: 0x0014A94C File Offset: 0x00148B4C
		[Token(Token = "0x6003EEA")]
		[Address(RVA = "0x8585E0", Offset = "0x856BE0", VA = "0x1808585E0", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.valueA_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.valueASourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.valueASourcePort = sourcePortName;
			string text2 = this.valueB_PortName;
			string nodeId2 = this.nodeId;
			List<SourcePortInfo> sourceNodes2 = graph.GetSourceNodes(nodeId2, text2);
			int num3 = 0;
			EventNodeBase sourceNode2 = sourceNodes2[num3].sourceNode;
			this.valueBSourceNode = sourceNode2;
			int num4 = 0;
			string sourcePortName2 = sourceNodes2[num4].sourcePortName;
			this.valueBSourcePort = sourcePortName2;
		}

		// Token: 0x06003EEB RID: 16107 RVA: 0x0014A9FC File Offset: 0x00148BFC
		[Token(Token = "0x6003EEB")]
		[Address(RVA = "0x9F67E0", Offset = "0x9F4DE0", VA = "0x1809F67E0", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			int num = 0;
			if (this.valueASourceNode != num)
			{
			}
			if (this.valueBSourceNode != num)
			{
			}
			Type typeFromHandle = typeof(bool);
			Type type;
			bool flag = type.Equals(typeFromHandle);
			if (!flag || flag || flag || !flag)
			{
			}
			throw new NullReferenceException();
		}

		// Token: 0x06003EEC RID: 16108 RVA: 0x0014AA64 File Offset: 0x00148C64
		[Token(Token = "0x6003EEC")]
		[Address(RVA = "0x858730", Offset = "0x856D30", VA = "0x180858730")]
		public CompareIntNode()
		{
		}

		// Token: 0x04002FC0 RID: 12224
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002FC0")]
		public string valueA_PortName = "值A";

		// Token: 0x04002FC1 RID: 12225
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002FC1")]
		public string valueB_PortName = "值B";

		// Token: 0x04002FC2 RID: 12226
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002FC2")]
		public string greater_PortName = "大于";

		// Token: 0x04002FC3 RID: 12227
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002FC3")]
		public string less_PortName = "小于";

		// Token: 0x04002FC4 RID: 12228
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002FC4")]
		public string equal_PortName = "等于";

		// Token: 0x04002FC5 RID: 12229
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002FC5")]
		[NonSerialized]
		private EventNodeBase valueASourceNode;

		// Token: 0x04002FC6 RID: 12230
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002FC6")]
		[NonSerialized]
		private string valueASourcePort;

		// Token: 0x04002FC7 RID: 12231
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002FC7")]
		[NonSerialized]
		private EventNodeBase valueBSourceNode;

		// Token: 0x04002FC8 RID: 12232
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002FC8")]
		[NonSerialized]
		private string valueBSourcePort;
	}
}
