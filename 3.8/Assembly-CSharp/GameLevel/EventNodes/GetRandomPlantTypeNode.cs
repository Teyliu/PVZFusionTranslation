using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BBD RID: 3005
	[Token(Token = "0x2000BBD")]
	[Serializable]
	public class GetRandomPlantTypeNode : EventNodeBase
	{
		// Token: 0x06003E8F RID: 16015 RVA: 0x0014A848 File Offset: 0x00148A48
		[Token(Token = "0x6003E8F")]
		[Address(RVA = "0x7F66F0", Offset = "0x7F4CF0", VA = "0x1807F66F0", Slot = "4")]
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

		// Token: 0x06003E90 RID: 16016 RVA: 0x0014A884 File Offset: 0x00148A84
		[Token(Token = "0x6003E90")]
		[Address(RVA = "0x7F67E0", Offset = "0x7F4DE0", VA = "0x1807F67E0", Slot = "5")]
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

		// Token: 0x06003E91 RID: 16017 RVA: 0x0014A8BC File Offset: 0x00148ABC
		[Token(Token = "0x6003E91")]
		[Address(RVA = "0x7F68D0", Offset = "0x7F4ED0", VA = "0x1807F68D0", Slot = "7")]
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

		// Token: 0x06003E92 RID: 16018 RVA: 0x0014A91C File Offset: 0x00148B1C
		[Token(Token = "0x6003E92")]
		[Address(RVA = "0x9B2CC0", Offset = "0x9B12C0", VA = "0x1809B2CC0", Slot = "9")]
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

		// Token: 0x06003E93 RID: 16019 RVA: 0x0014A9A0 File Offset: 0x00148BA0
		[Token(Token = "0x6003E93")]
		[Address(RVA = "0x7F6990", Offset = "0x7F4F90", VA = "0x1807F6990")]
		public GetRandomPlantTypeNode()
		{
		}

		// Token: 0x04002F53 RID: 12115
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002F53")]
		public string list_PortName = "植物类型列表";

		// Token: 0x04002F54 RID: 12116
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002F54")]
		public string result_PortName = "随机植物类型";

		// Token: 0x04002F55 RID: 12117
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002F55")]
		[NonSerialized]
		private EventNodeBase listSourceNode;

		// Token: 0x04002F56 RID: 12118
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002F56")]
		[NonSerialized]
		private string listSourcePort;
	}
}
