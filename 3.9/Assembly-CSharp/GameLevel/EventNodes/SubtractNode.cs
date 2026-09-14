using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BF8 RID: 3064
	[Token(Token = "0x2000BF8")]
	[Serializable]
	public class SubtractNode : EventNodeBase
	{
		// Token: 0x06003FBD RID: 16317 RVA: 0x0014EC8C File Offset: 0x0014CE8C
		[Token(Token = "0x6003FBD")]
		[Address(RVA = "0x86F170", Offset = "0x86D770", VA = "0x18086F170", Slot = "4")]
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

		// Token: 0x06003FBE RID: 16318 RVA: 0x0014ECE8 File Offset: 0x0014CEE8
		[Token(Token = "0x6003FBE")]
		[Address(RVA = "0x86F2E0", Offset = "0x86D8E0", VA = "0x18086F2E0", Slot = "5")]
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

		// Token: 0x06003FBF RID: 16319 RVA: 0x0014ED20 File Offset: 0x0014CF20
		[Token(Token = "0x6003FBF")]
		[Address(RVA = "0x86F3D0", Offset = "0x86D9D0", VA = "0x18086F3D0", Slot = "7")]
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

		// Token: 0x06003FC0 RID: 16320 RVA: 0x0014EDD0 File Offset: 0x0014CFD0
		[Token(Token = "0x6003FC0")]
		[Address(RVA = "0xAC9570", Offset = "0xAC7B70", VA = "0x180AC9570", Slot = "9")]
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
			float num2;
			EventNodeDebug.Log(string.Format("[SubtractNode] {0} - {1} = {2}", num, num, num2));
			throw new NullReferenceException();
		}

		// Token: 0x06003FC1 RID: 16321 RVA: 0x0014EE30 File Offset: 0x0014D030
		[Token(Token = "0x6003FC1")]
		[Address(RVA = "0x86F520", Offset = "0x86DB20", VA = "0x18086F520")]
		public SubtractNode()
		{
		}

		// Token: 0x04003094 RID: 12436
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4003094")]
		public string a_PortName = "被减数";

		// Token: 0x04003095 RID: 12437
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4003095")]
		public string b_PortName = "减数";

		// Token: 0x04003096 RID: 12438
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4003096")]
		public string result_PortName = "差";

		// Token: 0x04003097 RID: 12439
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4003097")]
		[NonSerialized]
		private EventNodeBase aSourceNode;

		// Token: 0x04003098 RID: 12440
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4003098")]
		[NonSerialized]
		private string aSourcePort;

		// Token: 0x04003099 RID: 12441
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4003099")]
		[NonSerialized]
		private EventNodeBase bSourceNode;

		// Token: 0x0400309A RID: 12442
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x400309A")]
		[NonSerialized]
		private string bSourcePort;
	}
}
