using System;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BDE RID: 3038
	[Token(Token = "0x2000BDE")]
	[Serializable]
	public class OnPlantClickNode : EventNodeBase
	{
		// Token: 0x06003F3C RID: 16188 RVA: 0x0014C0CC File Offset: 0x0014A2CC
		[Token(Token = "0x6003F3C")]
		[Address(RVA = "0x8652C0", Offset = "0x8638C0", VA = "0x1808652C0", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			return null;
		}

		// Token: 0x06003F3D RID: 16189 RVA: 0x0014C0DC File Offset: 0x0014A2DC
		[Token(Token = "0x6003F3D")]
		[Address(RVA = "0x865300", Offset = "0x863900", VA = "0x180865300", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[2];
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
			return array;
		}

		// Token: 0x06003F3E RID: 16190 RVA: 0x0014C134 File Offset: 0x0014A334
		[Token(Token = "0x6003F3E")]
		[Address(RVA = "0x7B6970", Offset = "0x7B4F70", VA = "0x1807B6970")]
		public void SetPlant(Plant plant)
		{
			this.clickedPlant = plant;
		}

		// Token: 0x06003F3F RID: 16191 RVA: 0x0014C148 File Offset: 0x0014A348
		[Token(Token = "0x6003F3F")]
		[Address(RVA = "0xAA9470", Offset = "0xAA7A70", VA = "0x180AA9470", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003F40 RID: 16192 RVA: 0x0014C190 File Offset: 0x0014A390
		[Token(Token = "0x6003F40")]
		[Address(RVA = "0x865180", Offset = "0x863780", VA = "0x180865180", Slot = "6")]
		public override void Execute()
		{
			Plant plant = this.clickedPlant;
			int num = 0;
			if (!(plant == num))
			{
				PlantType thePlantType = this.clickedPlant.thePlantType;
				EventNodeDebug.Log(string.Format("[OnPlantClickNode] 触发植物点击事件: {0}", thePlantType));
				string text = this.trigger_PortName;
				base.TriggerConnectedNodes(text);
				return;
			}
			string nodeId = this.nodeId;
			EventNodeDebug.LogWarning("[OnPlantClickNode] clickedPlant 为 null，无法触发植物点击事件，节点ID: " + nodeId);
		}

		// Token: 0x06003F41 RID: 16193 RVA: 0x0014C1FC File Offset: 0x0014A3FC
		[Token(Token = "0x6003F41")]
		[Address(RVA = "0x865470", Offset = "0x863A70", VA = "0x180865470")]
		public OnPlantClickNode()
		{
		}

		// Token: 0x04003009 RID: 12297
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4003009")]
		public string trigger_PortName = "触发";

		// Token: 0x0400300A RID: 12298
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400300A")]
		public string plant_PortName = "植物";

		// Token: 0x0400300B RID: 12299
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400300B")]
		private Plant clickedPlant;
	}
}
