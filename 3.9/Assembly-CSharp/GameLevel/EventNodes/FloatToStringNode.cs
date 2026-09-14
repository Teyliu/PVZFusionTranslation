using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BD4 RID: 3028
	[Token(Token = "0x2000BD4")]
	[Serializable]
	public class FloatToStringNode : EventNodeBase
	{
		// Token: 0x06003F06 RID: 16134 RVA: 0x0014B39C File Offset: 0x0014959C
		[Token(Token = "0x6003F06")]
		[Address(RVA = "0x85BFA0", Offset = "0x85A5A0", VA = "0x18085BFA0", Slot = "4")]
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

		// Token: 0x06003F07 RID: 16135 RVA: 0x0014B3F8 File Offset: 0x001495F8
		[Token(Token = "0x6003F07")]
		[Address(RVA = "0x85C110", Offset = "0x85A710", VA = "0x18085C110", Slot = "5")]
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

		// Token: 0x06003F08 RID: 16136 RVA: 0x0014B430 File Offset: 0x00149630
		[Token(Token = "0x6003F08")]
		[Address(RVA = "0x85C200", Offset = "0x85A800", VA = "0x18085C200", Slot = "7")]
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

		// Token: 0x06003F09 RID: 16137 RVA: 0x0014B4E0 File Offset: 0x001496E0
		[Token(Token = "0x6003F09")]
		[Address(RVA = "0xA51200", Offset = "0xA4F800", VA = "0x180A51200", Slot = "9")]
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

		// Token: 0x06003F0A RID: 16138 RVA: 0x0014B54C File Offset: 0x0014974C
		[Token(Token = "0x6003F0A")]
		[Address(RVA = "0x85C350", Offset = "0x85A950", VA = "0x18085C350")]
		public FloatToStringNode()
		{
		}

		// Token: 0x04002FE6 RID: 12262
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002FE6")]
		public string value_PortName = "数值";

		// Token: 0x04002FE7 RID: 12263
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002FE7")]
		public string decimals_PortName = "小数位数";

		// Token: 0x04002FE8 RID: 12264
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002FE8")]
		public string result_PortName = "字符串";

		// Token: 0x04002FE9 RID: 12265
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002FE9")]
		[NonSerialized]
		private EventNodeBase valueSourceNode;

		// Token: 0x04002FEA RID: 12266
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002FEA")]
		[NonSerialized]
		private string valueSourcePort;

		// Token: 0x04002FEB RID: 12267
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002FEB")]
		[NonSerialized]
		private EventNodeBase decimalsSourceNode;

		// Token: 0x04002FEC RID: 12268
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002FEC")]
		[NonSerialized]
		private string decimalsSourcePort;
	}
}
