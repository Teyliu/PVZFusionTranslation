using System;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B9B RID: 2971
	[Token(Token = "0x2000B9B")]
	[Serializable]
	public class OnPlantDeathCompleteNode : EventNodeBase
	{
		// Token: 0x06003DE5 RID: 15845 RVA: 0x00146CCC File Offset: 0x00144ECC
		[Token(Token = "0x6003DE5")]
		[Address(RVA = "0x7FDFA0", Offset = "0x7FC5A0", VA = "0x1807FDFA0", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			return null;
		}

		// Token: 0x06003DE6 RID: 15846 RVA: 0x00146CDC File Offset: 0x00144EDC
		[Token(Token = "0x6003DE6")]
		[Address(RVA = "0x7FDFE0", Offset = "0x7FC5E0", VA = "0x1807FDFE0", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[3];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.trigger_PortName, (PortType)num, (PortDirection)((uint)1));
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			PortDefinition portDefinition2 = new PortDefinition(this.plant_PortName, (PortType)((uint)11), (PortDirection)((uint)1));
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			PortDefinition portDefinition3 = new PortDefinition(this.dieReason_PortName, (PortType)((uint)1), (PortDirection)((uint)1));
			if (portDefinition3 != 0)
			{
			}
			array[2] = portDefinition3;
			return array;
		}

		// Token: 0x06003DE7 RID: 15847 RVA: 0x00146D54 File Offset: 0x00144F54
		[Token(Token = "0x6003DE7")]
		[Address(RVA = "0x7FE1C0", Offset = "0x7FC7C0", VA = "0x1807FE1C0")]
		public void SetPlantDeath(Plant plant, Plant.DieReason reason)
		{
			this.currentPlant = plant;
			this.dieReason = (int)reason;
		}

		// Token: 0x06003DE8 RID: 15848 RVA: 0x00146D74 File Offset: 0x00144F74
		[Token(Token = "0x6003DE8")]
		[Address(RVA = "0x9F82F0", Offset = "0x9F68F0", VA = "0x1809F82F0", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003DE9 RID: 15849 RVA: 0x00146DB4 File Offset: 0x00144FB4
		[Token(Token = "0x6003DE9")]
		[Address(RVA = "0x7FDE30", Offset = "0x7FC430", VA = "0x1807FDE30", Slot = "6")]
		public override void Execute()
		{
			Plant plant = this.currentPlant;
			int num = 0;
			if (!(plant == num))
			{
				PlantType thePlantType = this.currentPlant.thePlantType;
				int num2 = this.dieReason;
				EventNodeDebug.Log(string.Format("[OnPlantDeathCompleteNode] 触发植物死亡完成事件: {0}, 死亡原因: {1}", thePlantType, thePlantType));
				string text = this.trigger_PortName;
				base.TriggerConnectedNodes(text);
				return;
			}
			string nodeId = this.nodeId;
			EventNodeDebug.LogWarning("[OnPlantDeathCompleteNode] currentPlant 为 null，无法触发植物死亡完成事件，节点ID: " + nodeId);
		}

		// Token: 0x06003DEA RID: 15850 RVA: 0x00146E28 File Offset: 0x00145028
		[Token(Token = "0x6003DEA")]
		[Address(RVA = "0x7FE1F0", Offset = "0x7FC7F0", VA = "0x1807FE1F0")]
		public OnPlantDeathCompleteNode()
		{
		}

		// Token: 0x04002E90 RID: 11920
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002E90")]
		public string trigger_PortName = "触发";

		// Token: 0x04002E91 RID: 11921
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002E91")]
		public string plant_PortName = "植物";

		// Token: 0x04002E92 RID: 11922
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002E92")]
		public string dieReason_PortName = "死亡原因";

		// Token: 0x04002E93 RID: 11923
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002E93")]
		private Plant currentPlant;

		// Token: 0x04002E94 RID: 11924
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002E94")]
		private int dieReason;
	}
}
