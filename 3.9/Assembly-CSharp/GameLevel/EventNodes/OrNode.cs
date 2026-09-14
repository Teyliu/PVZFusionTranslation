using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BF2 RID: 3058
	[Token(Token = "0x2000BF2")]
	[Serializable]
	public class OrNode : EventNodeBase
	{
		// Token: 0x06003F9B RID: 16283 RVA: 0x0014DE44 File Offset: 0x0014C044
		[Token(Token = "0x6003F9B")]
		[Address(RVA = "0x866690", Offset = "0x864C90", VA = "0x180866690", Slot = "4")]
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

		// Token: 0x06003F9C RID: 16284 RVA: 0x0014DEA0 File Offset: 0x0014C0A0
		[Token(Token = "0x6003F9C")]
		[Address(RVA = "0x866800", Offset = "0x864E00", VA = "0x180866800", Slot = "5")]
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

		// Token: 0x06003F9D RID: 16285 RVA: 0x0014DED8 File Offset: 0x0014C0D8
		[Token(Token = "0x6003F9D")]
		[Address(RVA = "0x8668F0", Offset = "0x864EF0", VA = "0x1808668F0", Slot = "7")]
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

		// Token: 0x06003F9E RID: 16286 RVA: 0x0014DF88 File Offset: 0x0014C188
		[Token(Token = "0x6003F9E")]
		[Address(RVA = "0xAAA570", Offset = "0xAA8B70", VA = "0x180AAA570", Slot = "9")]
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

		// Token: 0x06003F9F RID: 16287 RVA: 0x0014E00C File Offset: 0x0014C20C
		[Token(Token = "0x6003F9F")]
		[Address(RVA = "0x866A40", Offset = "0x865040", VA = "0x180866A40")]
		public OrNode()
		{
		}

		// Token: 0x04003066 RID: 12390
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4003066")]
		public string a_PortName = "条件A";

		// Token: 0x04003067 RID: 12391
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4003067")]
		public string b_PortName = "条件B";

		// Token: 0x04003068 RID: 12392
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4003068")]
		public string output_PortName = "结果";

		// Token: 0x04003069 RID: 12393
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4003069")]
		[NonSerialized]
		private EventNodeBase aSourceNode;

		// Token: 0x0400306A RID: 12394
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400306A")]
		[NonSerialized]
		private string aSourcePort;

		// Token: 0x0400306B RID: 12395
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x400306B")]
		[NonSerialized]
		private EventNodeBase bSourceNode;

		// Token: 0x0400306C RID: 12396
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x400306C")]
		[NonSerialized]
		private string bSourcePort;
	}
}
