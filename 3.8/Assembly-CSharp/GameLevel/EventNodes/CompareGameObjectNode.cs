using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B8F RID: 2959
	[Token(Token = "0x2000B8F")]
	[Serializable]
	public class CompareGameObjectNode : EventNodeBase
	{
		// Token: 0x06003DA6 RID: 15782 RVA: 0x00145C4C File Offset: 0x00143E4C
		[Token(Token = "0x6003DA6")]
		[Address(RVA = "0x7F0360", Offset = "0x7EE960", VA = "0x1807F0360", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[2];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.gameObjectA_PortName, (PortType)((uint)13), (PortDirection)num);
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			int num2;
			PortDefinition portDefinition2 = new PortDefinition(this.gameObjectB_PortName, (PortType)((uint)13), (PortDirection)num2);
			num2 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003DA7 RID: 15783 RVA: 0x00145CA8 File Offset: 0x00143EA8
		[Token(Token = "0x6003DA7")]
		[Address(RVA = "0x7F04D0", Offset = "0x7EEAD0", VA = "0x1807F04D0", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			PortDefinition portDefinition = new PortDefinition(this.equal_PortName, (PortType)((uint)6), (PortDirection)((uint)1));
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003DA8 RID: 15784 RVA: 0x00145CE0 File Offset: 0x00143EE0
		[Token(Token = "0x6003DA8")]
		[Address(RVA = "0x7F05C0", Offset = "0x7EEBC0", VA = "0x1807F05C0", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.gameObjectA_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.gameObjectASourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.gameObjectASourcePort = sourcePortName;
			string text2 = this.gameObjectB_PortName;
			string nodeId2 = this.nodeId;
			List<SourcePortInfo> sourceNodes2 = graph.GetSourceNodes(nodeId2, text2);
			int num3 = 0;
			EventNodeBase sourceNode2 = sourceNodes2[num3].sourceNode;
			this.gameObjectBSourceNode = sourceNode2;
			int num4 = 0;
			string sourcePortName2 = sourceNodes2[num4].sourcePortName;
			this.gameObjectBSourcePort = sourcePortName2;
		}

		// Token: 0x06003DA9 RID: 15785 RVA: 0x00145D90 File Offset: 0x00143F90
		[Token(Token = "0x6003DA9")]
		[Address(RVA = "0x936A70", Offset = "0x935070", VA = "0x180936A70", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			Type typeFromHandle = typeof(Type);
			Type typeFromHandle2 = typeof(bool);
			if (typeFromHandle.Equals(typeFromHandle2))
			{
				if (this.gameObjectASourceNode != (ulong)0L)
				{
				}
				int num = 0;
				if (this.gameObjectBSourceNode != (ulong)0L)
				{
				}
				int num2 = 0;
				bool flag = num == num2;
				int num3 = 0;
				if (num != num3)
				{
				}
				int num4 = 0;
				if (num2 != num4)
				{
				}
				string text;
				EventNodeDebug.Log(string.Format("[CompareGameObjectNode] {0} == {1} → {2}", "null", "null", text));
			}
			throw new NullReferenceException();
		}

		// Token: 0x06003DAA RID: 15786 RVA: 0x00145E3C File Offset: 0x0014403C
		[Token(Token = "0x6003DAA")]
		[Address(RVA = "0x7F0710", Offset = "0x7EED10", VA = "0x1807F0710")]
		public CompareGameObjectNode()
		{
		}

		// Token: 0x04002E63 RID: 11875
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002E63")]
		public string gameObjectA_PortName = "对象A";

		// Token: 0x04002E64 RID: 11876
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002E64")]
		public string gameObjectB_PortName = "对象B";

		// Token: 0x04002E65 RID: 11877
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002E65")]
		public string equal_PortName = "相同";

		// Token: 0x04002E66 RID: 11878
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002E66")]
		[NonSerialized]
		private EventNodeBase gameObjectASourceNode;

		// Token: 0x04002E67 RID: 11879
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002E67")]
		[NonSerialized]
		private string gameObjectASourcePort;

		// Token: 0x04002E68 RID: 11880
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002E68")]
		[NonSerialized]
		private EventNodeBase gameObjectBSourceNode;

		// Token: 0x04002E69 RID: 11881
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002E69")]
		[NonSerialized]
		private string gameObjectBSourcePort;
	}
}
