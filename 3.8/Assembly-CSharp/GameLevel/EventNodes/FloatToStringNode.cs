using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B92 RID: 2962
	[Token(Token = "0x2000B92")]
	[Serializable]
	public class FloatToStringNode : EventNodeBase
	{
		// Token: 0x06003DB5 RID: 15797 RVA: 0x00146128 File Offset: 0x00144328
		[Token(Token = "0x6003DB5")]
		[Address(RVA = "0x7F43F0", Offset = "0x7F29F0", VA = "0x1807F43F0", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[2];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.value_PortName, (PortType)((uint)3), (PortDirection)num);
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			int num2;
			PortDefinition portDefinition2 = new PortDefinition(this.decimals_PortName, (PortType)((uint)1), (PortDirection)num2);
			num2 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003DB6 RID: 15798 RVA: 0x00146184 File Offset: 0x00144384
		[Token(Token = "0x6003DB6")]
		[Address(RVA = "0x7F4560", Offset = "0x7F2B60", VA = "0x1807F4560", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			PortDefinition portDefinition = new PortDefinition(this.result_PortName, (PortType)((uint)5), (PortDirection)((uint)1));
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003DB7 RID: 15799 RVA: 0x001461BC File Offset: 0x001443BC
		[Token(Token = "0x6003DB7")]
		[Address(RVA = "0x7F4650", Offset = "0x7F2C50", VA = "0x1807F4650", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.value_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.valueSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.valueSourcePort = sourcePortName;
			string text2 = this.decimals_PortName;
			string nodeId2 = this.nodeId;
			List<SourcePortInfo> sourceNodes2 = graph.GetSourceNodes(nodeId2, text2);
			int num3 = 0;
			EventNodeBase sourceNode2 = sourceNodes2[num3].sourceNode;
			this.decimalsSourceNode = sourceNode2;
			int num4 = 0;
			string sourcePortName2 = sourceNodes2[num4].sourcePortName;
			this.decimalsSourcePort = sourcePortName2;
		}

		// Token: 0x06003DB8 RID: 15800 RVA: 0x0014626C File Offset: 0x0014446C
		[Token(Token = "0x6003DB8")]
		[Address(RVA = "0x9A7C40", Offset = "0x9A6240", VA = "0x1809A7C40", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			if (this.valueSourceNode != (ulong)0L)
			{
			}
			if (this.decimalsSourceNode != (ulong)0L)
			{
			}
			int num;
			string text = string.Format("F{0}", num);
			string text2;
			int num2;
			EventNodeDebug.Log(string.Format("[FloatToStringNode] {0} → \"{1}\" (保留{2}位小数)", text2, text2, num2));
			throw new NullReferenceException();
		}

		// Token: 0x06003DB9 RID: 15801 RVA: 0x001462D8 File Offset: 0x001444D8
		[Token(Token = "0x6003DB9")]
		[Address(RVA = "0x7F47A0", Offset = "0x7F2DA0", VA = "0x1807F47A0")]
		public FloatToStringNode()
		{
		}

		// Token: 0x04002E72 RID: 11890
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002E72")]
		public string value_PortName = "数值";

		// Token: 0x04002E73 RID: 11891
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002E73")]
		public string decimals_PortName = "小数位数";

		// Token: 0x04002E74 RID: 11892
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002E74")]
		public string result_PortName = "字符串";

		// Token: 0x04002E75 RID: 11893
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002E75")]
		[NonSerialized]
		private EventNodeBase valueSourceNode;

		// Token: 0x04002E76 RID: 11894
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002E76")]
		[NonSerialized]
		private string valueSourcePort;

		// Token: 0x04002E77 RID: 11895
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002E77")]
		[NonSerialized]
		private EventNodeBase decimalsSourceNode;

		// Token: 0x04002E78 RID: 11896
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002E78")]
		[NonSerialized]
		private string decimalsSourcePort;
	}
}
