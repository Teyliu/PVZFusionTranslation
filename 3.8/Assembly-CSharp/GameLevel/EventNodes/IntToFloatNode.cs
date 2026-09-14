using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B90 RID: 2960
	[Token(Token = "0x2000B90")]
	[Serializable]
	public class IntToFloatNode : EventNodeBase
	{
		// Token: 0x06003DAB RID: 15787 RVA: 0x00145E70 File Offset: 0x00144070
		[Token(Token = "0x6003DAB")]
		[Address(RVA = "0x7F8A60", Offset = "0x7F7060", VA = "0x1807F8A60", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.int_PortName, (PortType)((uint)1), (PortDirection)num);
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003DAC RID: 15788 RVA: 0x00145EA8 File Offset: 0x001440A8
		[Token(Token = "0x6003DAC")]
		[Address(RVA = "0x7F8B50", Offset = "0x7F7150", VA = "0x1807F8B50", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			PortDefinition portDefinition = new PortDefinition(this.float_PortName, (PortType)((uint)3), (PortDirection)((uint)1));
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003DAD RID: 15789 RVA: 0x00145EE0 File Offset: 0x001440E0
		[Token(Token = "0x6003DAD")]
		[Address(RVA = "0x7F8C40", Offset = "0x7F7240", VA = "0x1807F8C40", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.int_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.intSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.intSourcePort = sourcePortName;
		}

		// Token: 0x06003DAE RID: 15790 RVA: 0x00145F40 File Offset: 0x00144140
		[Token(Token = "0x6003DAE")]
		[Address(RVA = "0x9C6F90", Offset = "0x9C5590", VA = "0x1809C6F90", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			Type typeFromHandle = typeof(Type);
			Type typeFromHandle2 = typeof(float);
			if (typeFromHandle.Equals(typeFromHandle2))
			{
				if (this.intSourceNode != (ulong)0L)
				{
				}
			}
			throw new InvalidCastException();
		}

		// Token: 0x06003DAF RID: 15791 RVA: 0x00145FA0 File Offset: 0x001441A0
		[Token(Token = "0x6003DAF")]
		[Address(RVA = "0x7F8D00", Offset = "0x7F7300", VA = "0x1807F8D00")]
		public IntToFloatNode()
		{
		}

		// Token: 0x04002E6A RID: 11882
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002E6A")]
		public string int_PortName = "整数";

		// Token: 0x04002E6B RID: 11883
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002E6B")]
		public string float_PortName = "浮点数";

		// Token: 0x04002E6C RID: 11884
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002E6C")]
		[NonSerialized]
		private EventNodeBase intSourceNode;

		// Token: 0x04002E6D RID: 11885
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002E6D")]
		[NonSerialized]
		private string intSourcePort;
	}
}
