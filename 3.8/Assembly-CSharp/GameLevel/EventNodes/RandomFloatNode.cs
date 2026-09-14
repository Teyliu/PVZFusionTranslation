using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BBB RID: 3003
	[Token(Token = "0x2000BBB")]
	[Serializable]
	public class RandomFloatNode : EventNodeBase
	{
		// Token: 0x06003E85 RID: 16005 RVA: 0x0014A3C8 File Offset: 0x001485C8
		[Token(Token = "0x6003E85")]
		[Address(RVA = "0x801F80", Offset = "0x800580", VA = "0x180801F80", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[2];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.min_PortName, (PortType)((uint)3), (PortDirection)num);
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			int num2;
			PortDefinition portDefinition2 = new PortDefinition(this.max_PortName, (PortType)((uint)3), (PortDirection)num2);
			num2 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003E86 RID: 16006 RVA: 0x0014A424 File Offset: 0x00148624
		[Token(Token = "0x6003E86")]
		[Address(RVA = "0x8020F0", Offset = "0x8006F0", VA = "0x1808020F0", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			PortDefinition portDefinition = new PortDefinition(this.result_PortName, (PortType)((uint)3), (PortDirection)((uint)1));
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003E87 RID: 16007 RVA: 0x0014A45C File Offset: 0x0014865C
		[Token(Token = "0x6003E87")]
		[Address(RVA = "0x8021E0", Offset = "0x8007E0", VA = "0x1808021E0", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.min_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.minSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.minSourcePort = sourcePortName;
			string text2 = this.max_PortName;
			string nodeId2 = this.nodeId;
			List<SourcePortInfo> sourceNodes2 = graph.GetSourceNodes(nodeId2, text2);
			int num3 = 0;
			EventNodeBase sourceNode2 = sourceNodes2[num3].sourceNode;
			this.maxSourceNode = sourceNode2;
			int num4 = 0;
			string sourcePortName2 = sourceNodes2[num4].sourcePortName;
			this.maxSourcePort = sourcePortName2;
		}

		// Token: 0x06003E88 RID: 16008 RVA: 0x0014A50C File Offset: 0x0014870C
		[Token(Token = "0x6003E88")]
		[Address(RVA = "0x9FE950", Offset = "0x9FCF50", VA = "0x1809FE950", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			if (this.minSourceNode != (ulong)0L)
			{
			}
			int num = 0;
			EventNodeBase eventNodeBase;
			if (this.maxSourceNode != (ulong)0L)
			{
				eventNodeBase = this.maxSourceNode;
			}
			float num2 = global::UnityEngine.Random.Range((float)num, 100f);
			float num3;
			string text = string.Format("[RandomFloatNode] 生成随机浮点数: {0:F2} (范围: {1:F2}-{2:F2})", eventNodeBase, num3, num3);
			EventNodeDebug.Log(text);
			throw new NullReferenceException();
		}

		// Token: 0x06003E89 RID: 16009 RVA: 0x0014A584 File Offset: 0x00148784
		[Token(Token = "0x6003E89")]
		[Address(RVA = "0x802330", Offset = "0x800930", VA = "0x180802330")]
		public RandomFloatNode()
		{
		}

		// Token: 0x04002F43 RID: 12099
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002F43")]
		public string min_PortName = "最小值";

		// Token: 0x04002F44 RID: 12100
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002F44")]
		public string max_PortName = "最大值";

		// Token: 0x04002F45 RID: 12101
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002F45")]
		public string result_PortName = "随机浮点数";

		// Token: 0x04002F46 RID: 12102
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002F46")]
		[NonSerialized]
		private EventNodeBase minSourceNode;

		// Token: 0x04002F47 RID: 12103
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002F47")]
		[NonSerialized]
		private string minSourcePort;

		// Token: 0x04002F48 RID: 12104
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002F48")]
		[NonSerialized]
		private EventNodeBase maxSourceNode;

		// Token: 0x04002F49 RID: 12105
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002F49")]
		[NonSerialized]
		private string maxSourcePort;
	}
}
