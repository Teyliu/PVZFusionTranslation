using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BFF RID: 3071
	[Token(Token = "0x2000BFF")]
	[Serializable]
	public class GetRandomPlantTypeNode : EventNodeBase
	{
		// Token: 0x06003FE0 RID: 16352 RVA: 0x0014FAB8 File Offset: 0x0014DCB8
		[Token(Token = "0x6003FE0")]
		[Address(RVA = "0x85E2A0", Offset = "0x85C8A0", VA = "0x18085E2A0", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.list_PortName, (PortType)((uint)16), (PortDirection)num);
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003FE1 RID: 16353 RVA: 0x0014FAF4 File Offset: 0x0014DCF4
		[Token(Token = "0x6003FE1")]
		[Address(RVA = "0x85E390", Offset = "0x85C990", VA = "0x18085E390", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			PortDefinition portDefinition = new PortDefinition(this.result_PortName, (PortType)((uint)9), (PortDirection)((uint)1));
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003FE2 RID: 16354 RVA: 0x0014FB2C File Offset: 0x0014DD2C
		[Token(Token = "0x6003FE2")]
		[Address(RVA = "0x85E480", Offset = "0x85CA80", VA = "0x18085E480", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.list_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.listSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.listSourcePort = sourcePortName;
		}

		// Token: 0x06003FE3 RID: 16355 RVA: 0x0014FB8C File Offset: 0x0014DD8C
		[Token(Token = "0x6003FE3")]
		[Address(RVA = "0xA5C620", Offset = "0xA5AC20", VA = "0x180A5C620", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			if (this.listSourceNode != (ulong)0L)
			{
				List<PlantType> list;
				list += list;
				if (list != 0)
				{
					int size = list._size;
					PlantType plantType;
					string text = string.Format("[GetRandomPlantTypeNode] 从 {0} 个植物类型中随机选择: {1}", plantType, plantType);
					EventNodeDebug.Log(text);
				}
			}
			string nodeId = this.nodeId;
			EventNodeDebug.LogWarning("[GetRandomPlantTypeNode] 列表为空，返回默认值 Nothing，节点ID: " + nodeId);
			throw new NullReferenceException();
		}

		// Token: 0x06003FE4 RID: 16356 RVA: 0x0014FC10 File Offset: 0x0014DE10
		[Token(Token = "0x6003FE4")]
		[Address(RVA = "0x85E540", Offset = "0x85CB40", VA = "0x18085E540")]
		public GetRandomPlantTypeNode()
		{
		}

		// Token: 0x040030C7 RID: 12487
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40030C7")]
		public string list_PortName = "植物类型列表";

		// Token: 0x040030C8 RID: 12488
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40030C8")]
		public string result_PortName = "随机植物类型";

		// Token: 0x040030C9 RID: 12489
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40030C9")]
		[NonSerialized]
		private EventNodeBase listSourceNode;

		// Token: 0x040030CA RID: 12490
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40030CA")]
		[NonSerialized]
		private string listSourcePort;
	}
}
