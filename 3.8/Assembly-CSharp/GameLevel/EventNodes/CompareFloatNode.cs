using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B8B RID: 2955
	[Token(Token = "0x2000B8B")]
	[Serializable]
	public class CompareFloatNode : EventNodeBase
	{
		// Token: 0x06003D92 RID: 15762 RVA: 0x001453D0 File Offset: 0x001435D0
		[Token(Token = "0x6003D92")]
		[Address(RVA = "0x7EFDC0", Offset = "0x7EE3C0", VA = "0x1807EFDC0", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[2];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.valueA_PortName, (PortType)((uint)3), (PortDirection)num);
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			int num2;
			PortDefinition portDefinition2 = new PortDefinition(this.valueB_PortName, (PortType)((uint)3), (PortDirection)num2);
			num2 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003D93 RID: 15763 RVA: 0x0014542C File Offset: 0x0014362C
		[Token(Token = "0x6003D93")]
		[Address(RVA = "0x7EFF30", Offset = "0x7EE530", VA = "0x1807EFF30", Slot = "5")]
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

		// Token: 0x06003D94 RID: 15764 RVA: 0x001454A0 File Offset: 0x001436A0
		[Token(Token = "0x6003D94")]
		[Address(RVA = "0x7F0120", Offset = "0x7EE720", VA = "0x1807F0120", Slot = "7")]
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

		// Token: 0x06003D95 RID: 15765 RVA: 0x00145550 File Offset: 0x00143750
		[Token(Token = "0x6003D95")]
		[Address(RVA = "0x935C20", Offset = "0x934220", VA = "0x180935C20", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			if (this.valueASourceNode != (ulong)0L)
			{
			}
			if (this.valueBSourceNode != (ulong)0L)
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

		// Token: 0x06003D96 RID: 15766 RVA: 0x001455BC File Offset: 0x001437BC
		[Token(Token = "0x6003D96")]
		[Address(RVA = "0x7F0270", Offset = "0x7EE870", VA = "0x1807F0270")]
		public CompareFloatNode()
		{
		}

		// Token: 0x04002E43 RID: 11843
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002E43")]
		public string valueA_PortName = "值A";

		// Token: 0x04002E44 RID: 11844
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002E44")]
		public string valueB_PortName = "值B";

		// Token: 0x04002E45 RID: 11845
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002E45")]
		public string greater_PortName = "大于";

		// Token: 0x04002E46 RID: 11846
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002E46")]
		public string less_PortName = "小于";

		// Token: 0x04002E47 RID: 11847
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002E47")]
		public string equal_PortName = "等于";

		// Token: 0x04002E48 RID: 11848
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002E48")]
		[NonSerialized]
		private EventNodeBase valueASourceNode;

		// Token: 0x04002E49 RID: 11849
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002E49")]
		[NonSerialized]
		private string valueASourcePort;

		// Token: 0x04002E4A RID: 11850
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002E4A")]
		[NonSerialized]
		private EventNodeBase valueBSourceNode;

		// Token: 0x04002E4B RID: 11851
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002E4B")]
		[NonSerialized]
		private string valueBSourcePort;
	}
}
