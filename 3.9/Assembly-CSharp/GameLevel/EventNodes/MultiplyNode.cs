using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BF9 RID: 3065
	[Token(Token = "0x2000BF9")]
	[Serializable]
	public class MultiplyNode : EventNodeBase
	{
		// Token: 0x06003FC2 RID: 16322 RVA: 0x0014EE64 File Offset: 0x0014D064
		[Token(Token = "0x6003FC2")]
		[Address(RVA = "0x863AD0", Offset = "0x8620D0", VA = "0x180863AD0", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[2];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.a_PortName, (PortType)((uint)3), (PortDirection)num);
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			int num2;
			PortDefinition portDefinition2 = new PortDefinition(this.b_PortName, (PortType)((uint)3), (PortDirection)num2);
			num2 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003FC3 RID: 16323 RVA: 0x0014EEC0 File Offset: 0x0014D0C0
		[Token(Token = "0x6003FC3")]
		[Address(RVA = "0x863C40", Offset = "0x862240", VA = "0x180863C40", Slot = "5")]
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

		// Token: 0x06003FC4 RID: 16324 RVA: 0x0014EEF8 File Offset: 0x0014D0F8
		[Token(Token = "0x6003FC4")]
		[Address(RVA = "0x863D30", Offset = "0x862330", VA = "0x180863D30", Slot = "7")]
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

		// Token: 0x06003FC5 RID: 16325 RVA: 0x0014EFA8 File Offset: 0x0014D1A8
		[Token(Token = "0x6003FC5")]
		[Address(RVA = "0xA9E190", Offset = "0xA9C790", VA = "0x180A9E190", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			if (this.aSourceNode != (ulong)0L)
			{
			}
			if (this.bSourceNode != (ulong)0L)
			{
			}
			float num;
			string text = string.Format("[MultiplyNode] {0} × {1} = {2}", num, num, num);
			EventNodeDebug.Log(text);
			throw new NullReferenceException();
		}

		// Token: 0x06003FC6 RID: 16326 RVA: 0x0014F00C File Offset: 0x0014D20C
		[Token(Token = "0x6003FC6")]
		[Address(RVA = "0x863E80", Offset = "0x862480", VA = "0x180863E80")]
		public MultiplyNode()
		{
		}

		// Token: 0x0400309B RID: 12443
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400309B")]
		public string a_PortName = "A";

		// Token: 0x0400309C RID: 12444
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400309C")]
		public string b_PortName = "B";

		// Token: 0x0400309D RID: 12445
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400309D")]
		public string result_PortName = "积";

		// Token: 0x0400309E RID: 12446
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400309E")]
		[NonSerialized]
		private EventNodeBase aSourceNode;

		// Token: 0x0400309F RID: 12447
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400309F")]
		[NonSerialized]
		private string aSourcePort;

		// Token: 0x040030A0 RID: 12448
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40030A0")]
		[NonSerialized]
		private EventNodeBase bSourceNode;

		// Token: 0x040030A1 RID: 12449
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40030A1")]
		[NonSerialized]
		private string bSourcePort;
	}
}
