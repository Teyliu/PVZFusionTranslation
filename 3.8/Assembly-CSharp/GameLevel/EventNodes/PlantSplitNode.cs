using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BC7 RID: 3015
	[Token(Token = "0x2000BC7")]
	[Serializable]
	public class PlantSplitNode : EventNodeBase
	{
		// Token: 0x06003EC4 RID: 16068 RVA: 0x0014BF5C File Offset: 0x0014A15C
		[Token(Token = "0x6003EC4")]
		[Address(RVA = "0x7FF130", Offset = "0x7FD730", VA = "0x1807FF130", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.plant_PortName, (PortType)((uint)11), (PortDirection)num);
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003EC5 RID: 16069 RVA: 0x0014BF98 File Offset: 0x0014A198
		[Token(Token = "0x6003EC5")]
		[Address(RVA = "0x7FF220", Offset = "0x7FD820", VA = "0x1807FF220", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[5];
			PortDefinition portDefinition = new PortDefinition(this.row_PortName, (PortType)((uint)1), (PortDirection)((uint)1));
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			PortDefinition portDefinition2 = new PortDefinition(this.column_PortName, (PortType)((uint)1), (PortDirection)((uint)1));
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			PortDefinition portDefinition3 = new PortDefinition(this.plantType_PortName, (PortType)((uint)9), (PortDirection)((uint)1));
			if (portDefinition3 != 0)
			{
			}
			array[2] = portDefinition3;
			PortDefinition portDefinition4 = new PortDefinition(this.health_PortName, (PortType)((uint)1), (PortDirection)((uint)1));
			if (portDefinition4 != 0)
			{
			}
			array[3] = portDefinition4;
			PortDefinition portDefinition5 = new PortDefinition(this.attributeCountdown_PortName, (PortType)((uint)3), (PortDirection)((uint)1));
			if (portDefinition5 != 0)
			{
			}
			array[4] = portDefinition5;
			return array;
		}

		// Token: 0x06003EC6 RID: 16070 RVA: 0x0014C04C File Offset: 0x0014A24C
		[Token(Token = "0x6003EC6")]
		[Address(RVA = "0x7FF4F0", Offset = "0x7FDAF0", VA = "0x1807FF4F0", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.plant_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.plantSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.plantSourcePort = sourcePortName;
		}

		// Token: 0x06003EC7 RID: 16071 RVA: 0x0014C0AC File Offset: 0x0014A2AC
		[Token(Token = "0x6003EC7")]
		[Address(RVA = "0x9F9B40", Offset = "0x9F8140", VA = "0x1809F9B40", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			if (this.plantSourceNode != 0)
			{
			}
			int num = 0;
			int num2 = 0;
			bool flag = num == num2;
			if (!flag && !flag && !flag && !flag)
			{
				Plant plant;
				if (!flag)
				{
					if (!flag)
					{
					}
					Dictionary<EffectType, BaseEffect> effects = plant.effects;
				}
				int thePlantHealth = plant.thePlantHealth;
			}
			string nodeId = this.nodeId;
			EventNodeDebug.LogWarning("[PlantSplitNode] 植物对象为空，返回默认值，节点ID: " + nodeId);
			return defaultValue;
		}

		// Token: 0x06003EC8 RID: 16072 RVA: 0x0014C138 File Offset: 0x0014A338
		[Token(Token = "0x6003EC8")]
		[Address(RVA = "0x7FF5B0", Offset = "0x7FDBB0", VA = "0x1807FF5B0")]
		public PlantSplitNode()
		{
		}

		// Token: 0x04002FA5 RID: 12197
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002FA5")]
		public string plant_PortName = "植物";

		// Token: 0x04002FA6 RID: 12198
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002FA6")]
		public string column_PortName = "列";

		// Token: 0x04002FA7 RID: 12199
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002FA7")]
		public string row_PortName = "行";

		// Token: 0x04002FA8 RID: 12200
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002FA8")]
		public string plantType_PortName = "植物类型";

		// Token: 0x04002FA9 RID: 12201
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002FA9")]
		public string health_PortName = "植物血量";

		// Token: 0x04002FAA RID: 12202
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002FAA")]
		public string attributeCountdown_PortName = "属性倒计时";

		// Token: 0x04002FAB RID: 12203
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002FAB")]
		[NonSerialized]
		private EventNodeBase plantSourceNode;

		// Token: 0x04002FAC RID: 12204
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002FAC")]
		[NonSerialized]
		private string plantSourcePort;
	}
}
