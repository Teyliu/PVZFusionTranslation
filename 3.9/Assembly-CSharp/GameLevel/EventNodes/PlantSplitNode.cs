using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000C09 RID: 3081
	[Token(Token = "0x2000C09")]
	[Serializable]
	public class PlantSplitNode : EventNodeBase
	{
		// Token: 0x06004015 RID: 16405 RVA: 0x001511C8 File Offset: 0x0014F3C8
		[Token(Token = "0x6004015")]
		[Address(RVA = "0x866AE0", Offset = "0x8650E0", VA = "0x180866AE0", Slot = "4")]
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

		// Token: 0x06004016 RID: 16406 RVA: 0x00151204 File Offset: 0x0014F404
		[Token(Token = "0x6004016")]
		[Address(RVA = "0x866BD0", Offset = "0x8651D0", VA = "0x180866BD0", Slot = "5")]
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

		// Token: 0x06004017 RID: 16407 RVA: 0x001512B8 File Offset: 0x0014F4B8
		[Token(Token = "0x6004017")]
		[Address(RVA = "0x866EA0", Offset = "0x8654A0", VA = "0x180866EA0", Slot = "7")]
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

		// Token: 0x06004018 RID: 16408 RVA: 0x00151318 File Offset: 0x0014F518
		[Token(Token = "0x6004018")]
		[Address(RVA = "0xAAB380", Offset = "0xAA9980", VA = "0x180AAB380", Slot = "9")]
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

		// Token: 0x06004019 RID: 16409 RVA: 0x001513A4 File Offset: 0x0014F5A4
		[Token(Token = "0x6004019")]
		[Address(RVA = "0x866F60", Offset = "0x865560", VA = "0x180866F60")]
		public PlantSplitNode()
		{
		}

		// Token: 0x04003119 RID: 12569
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4003119")]
		public string plant_PortName = "植物";

		// Token: 0x0400311A RID: 12570
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400311A")]
		public string column_PortName = "列";

		// Token: 0x0400311B RID: 12571
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400311B")]
		public string row_PortName = "行";

		// Token: 0x0400311C RID: 12572
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400311C")]
		public string plantType_PortName = "植物类型";

		// Token: 0x0400311D RID: 12573
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400311D")]
		public string health_PortName = "植物血量";

		// Token: 0x0400311E RID: 12574
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x400311E")]
		public string attributeCountdown_PortName = "属性倒计时";

		// Token: 0x0400311F RID: 12575
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x400311F")]
		[NonSerialized]
		private EventNodeBase plantSourceNode;

		// Token: 0x04003120 RID: 12576
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4003120")]
		[NonSerialized]
		private string plantSourcePort;
	}
}
