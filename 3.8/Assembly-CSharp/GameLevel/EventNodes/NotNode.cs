using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BAE RID: 2990
	[Token(Token = "0x2000BAE")]
	[Serializable]
	public class NotNode : EventNodeBase
	{
		// Token: 0x06003E40 RID: 15936 RVA: 0x00148888 File Offset: 0x00146A88
		[Token(Token = "0x6003E40")]
		[Address(RVA = "0x7FC570", Offset = "0x7FAB70", VA = "0x1807FC570", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.input_PortName, (PortType)((uint)6), (PortDirection)num);
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003E41 RID: 15937 RVA: 0x001488C0 File Offset: 0x00146AC0
		[Token(Token = "0x6003E41")]
		[Address(RVA = "0x7FC660", Offset = "0x7FAC60", VA = "0x1807FC660", Slot = "5")]
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

		// Token: 0x06003E42 RID: 15938 RVA: 0x001488F8 File Offset: 0x00146AF8
		[Token(Token = "0x6003E42")]
		[Address(RVA = "0x7FC750", Offset = "0x7FAD50", VA = "0x1807FC750", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.input_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.inputSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.inputSourcePort = sourcePortName;
		}

		// Token: 0x06003E43 RID: 15939 RVA: 0x00148958 File Offset: 0x00146B58
		[Token(Token = "0x6003E43")]
		[Address(RVA = "0x9F4AC0", Offset = "0x9F30C0", VA = "0x1809F4AC0", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			bool flag;
			flag += flag;
			int num = 0;
			bool flag2 = num == 0;
			string text = string.Format("[NotNode] {0} → {1}", num, num);
			EventNodeDebug.Log(text);
			throw new NullReferenceException();
		}

		// Token: 0x06003E44 RID: 15940 RVA: 0x001489AC File Offset: 0x00146BAC
		[Token(Token = "0x6003E44")]
		[Address(RVA = "0x7FC810", Offset = "0x7FAE10", VA = "0x1807FC810")]
		public NotNode()
		{
		}

		// Token: 0x04002EE7 RID: 12007
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002EE7")]
		public string input_PortName = "输入";

		// Token: 0x04002EE8 RID: 12008
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002EE8")]
		public string output_PortName = "输出";

		// Token: 0x04002EE9 RID: 12009
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002EE9")]
		[NonSerialized]
		private EventNodeBase inputSourceNode;

		// Token: 0x04002EEA RID: 12010
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002EEA")]
		[NonSerialized]
		private string inputSourcePort;
	}
}
