using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BFD RID: 3069
	[Token(Token = "0x2000BFD")]
	[Serializable]
	public class RandomFloatNode : EventNodeBase
	{
		// Token: 0x06003FD6 RID: 16342 RVA: 0x0014F638 File Offset: 0x0014D838
		[Token(Token = "0x6003FD6")]
		[Address(RVA = "0x869930", Offset = "0x867F30", VA = "0x180869930", Slot = "4")]
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

		// Token: 0x06003FD7 RID: 16343 RVA: 0x0014F694 File Offset: 0x0014D894
		[Token(Token = "0x6003FD7")]
		[Address(RVA = "0x869AA0", Offset = "0x8680A0", VA = "0x180869AA0", Slot = "5")]
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

		// Token: 0x06003FD8 RID: 16344 RVA: 0x0014F6CC File Offset: 0x0014D8CC
		[Token(Token = "0x6003FD8")]
		[Address(RVA = "0x869B90", Offset = "0x868190", VA = "0x180869B90", Slot = "7")]
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

		// Token: 0x06003FD9 RID: 16345 RVA: 0x0014F77C File Offset: 0x0014D97C
		[Token(Token = "0x6003FD9")]
		[Address(RVA = "0xAB0190", Offset = "0xAAE790", VA = "0x180AB0190", Slot = "9")]
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

		// Token: 0x06003FDA RID: 16346 RVA: 0x0014F7F4 File Offset: 0x0014D9F4
		[Token(Token = "0x6003FDA")]
		[Address(RVA = "0x869CE0", Offset = "0x8682E0", VA = "0x180869CE0")]
		public RandomFloatNode()
		{
		}

		// Token: 0x040030B7 RID: 12471
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40030B7")]
		public string min_PortName = "最小值";

		// Token: 0x040030B8 RID: 12472
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40030B8")]
		public string max_PortName = "最大值";

		// Token: 0x040030B9 RID: 12473
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40030B9")]
		public string result_PortName = "随机浮点数";

		// Token: 0x040030BA RID: 12474
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40030BA")]
		[NonSerialized]
		private EventNodeBase minSourceNode;

		// Token: 0x040030BB RID: 12475
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40030BB")]
		[NonSerialized]
		private string minSourcePort;

		// Token: 0x040030BC RID: 12476
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40030BC")]
		[NonSerialized]
		private EventNodeBase maxSourceNode;

		// Token: 0x040030BD RID: 12477
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40030BD")]
		[NonSerialized]
		private string maxSourcePort;
	}
}
