using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BD1 RID: 3025
	[Token(Token = "0x2000BD1")]
	[Serializable]
	public class CompareGameObjectNode : EventNodeBase
	{
		// Token: 0x06003EF7 RID: 16119 RVA: 0x0014AEC0 File Offset: 0x001490C0
		[Token(Token = "0x6003EF7")]
		[Address(RVA = "0x857E30", Offset = "0x856430", VA = "0x180857E30", Slot = "4")]
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

		// Token: 0x06003EF8 RID: 16120 RVA: 0x0014AF1C File Offset: 0x0014911C
		[Token(Token = "0x6003EF8")]
		[Address(RVA = "0x857FA0", Offset = "0x8565A0", VA = "0x180857FA0", Slot = "5")]
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

		// Token: 0x06003EF9 RID: 16121 RVA: 0x0014AF54 File Offset: 0x00149154
		[Token(Token = "0x6003EF9")]
		[Address(RVA = "0x858090", Offset = "0x856690", VA = "0x180858090", Slot = "7")]
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

		// Token: 0x06003EFA RID: 16122 RVA: 0x0014B004 File Offset: 0x00149204
		[Token(Token = "0x6003EFA")]
		[Address(RVA = "0x9F5660", Offset = "0x9F3C60", VA = "0x1809F5660", Slot = "9")]
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

		// Token: 0x06003EFB RID: 16123 RVA: 0x0014B0B0 File Offset: 0x001492B0
		[Token(Token = "0x6003EFB")]
		[Address(RVA = "0x8581E0", Offset = "0x8567E0", VA = "0x1808581E0")]
		public CompareGameObjectNode()
		{
		}

		// Token: 0x04002FD7 RID: 12247
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002FD7")]
		public string gameObjectA_PortName = "对象A";

		// Token: 0x04002FD8 RID: 12248
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002FD8")]
		public string gameObjectB_PortName = "对象B";

		// Token: 0x04002FD9 RID: 12249
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002FD9")]
		public string equal_PortName = "相同";

		// Token: 0x04002FDA RID: 12250
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002FDA")]
		[NonSerialized]
		private EventNodeBase gameObjectASourceNode;

		// Token: 0x04002FDB RID: 12251
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002FDB")]
		[NonSerialized]
		private string gameObjectASourcePort;

		// Token: 0x04002FDC RID: 12252
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002FDC")]
		[NonSerialized]
		private EventNodeBase gameObjectBSourceNode;

		// Token: 0x04002FDD RID: 12253
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002FDD")]
		[NonSerialized]
		private string gameObjectBSourcePort;
	}
}
