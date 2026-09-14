using System;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BDD RID: 3037
	[Token(Token = "0x2000BDD")]
	[Serializable]
	public class OnPlantDeathCompleteNode : EventNodeBase
	{
		// Token: 0x06003F36 RID: 16182 RVA: 0x0014BF3C File Offset: 0x0014A13C
		[Token(Token = "0x6003F36")]
		[Address(RVA = "0x865950", Offset = "0x863F50", VA = "0x180865950", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			return null;
		}

		// Token: 0x06003F37 RID: 16183 RVA: 0x0014BF4C File Offset: 0x0014A14C
		[Token(Token = "0x6003F37")]
		[Address(RVA = "0x865990", Offset = "0x863F90", VA = "0x180865990", Slot = "5")]
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

		// Token: 0x06003F38 RID: 16184 RVA: 0x0014BFC4 File Offset: 0x0014A1C4
		[Token(Token = "0x6003F38")]
		[Address(RVA = "0x865B70", Offset = "0x864170", VA = "0x180865B70")]
		public void SetPlantDeath(Plant plant, Plant.DieReason reason)
		{
			this.currentPlant = plant;
			this.dieReason = (int)reason;
		}

		// Token: 0x06003F39 RID: 16185 RVA: 0x0014BFE4 File Offset: 0x0014A1E4
		[Token(Token = "0x6003F39")]
		[Address(RVA = "0xAA9B30", Offset = "0xAA8130", VA = "0x180AA9B30", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003F3A RID: 16186 RVA: 0x0014C024 File Offset: 0x0014A224
		[Token(Token = "0x6003F3A")]
		[Address(RVA = "0x8657E0", Offset = "0x863DE0", VA = "0x1808657E0", Slot = "6")]
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

		// Token: 0x06003F3B RID: 16187 RVA: 0x0014C098 File Offset: 0x0014A298
		[Token(Token = "0x6003F3B")]
		[Address(RVA = "0x865BA0", Offset = "0x8641A0", VA = "0x180865BA0")]
		public OnPlantDeathCompleteNode()
		{
		}

		// Token: 0x04003004 RID: 12292
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4003004")]
		public string trigger_PortName = "触发";

		// Token: 0x04003005 RID: 12293
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4003005")]
		public string plant_PortName = "植物";

		// Token: 0x04003006 RID: 12294
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4003006")]
		public string dieReason_PortName = "死亡原因";

		// Token: 0x04003007 RID: 12295
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4003007")]
		private Plant currentPlant;

		// Token: 0x04003008 RID: 12296
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4003008")]
		private int dieReason;
	}
}
