using System;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BDC RID: 3036
	[Token(Token = "0x2000BDC")]
	[Serializable]
	public class OnPlantDieNode : EventNodeBase
	{
		// Token: 0x06003F30 RID: 16176 RVA: 0x0014BDE0 File Offset: 0x00149FE0
		[Token(Token = "0x6003F30")]
		[Address(RVA = "0x865D80", Offset = "0x864380", VA = "0x180865D80", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			return null;
		}

		// Token: 0x06003F31 RID: 16177 RVA: 0x0014BDF0 File Offset: 0x00149FF0
		[Token(Token = "0x6003F31")]
		[Address(RVA = "0x865DC0", Offset = "0x8643C0", VA = "0x180865DC0", Slot = "5")]
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

		// Token: 0x06003F32 RID: 16178 RVA: 0x0014BE48 File Offset: 0x0014A048
		[Token(Token = "0x6003F32")]
		[Address(RVA = "0x7B6970", Offset = "0x7B4F70", VA = "0x1807B6970")]
		public void SetPlant(Plant plant)
		{
			this.currentPlant = plant;
		}

		// Token: 0x06003F33 RID: 16179 RVA: 0x0014BE5C File Offset: 0x0014A05C
		[Token(Token = "0x6003F33")]
		[Address(RVA = "0xAA9470", Offset = "0xAA7A70", VA = "0x180AA9470", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003F34 RID: 16180 RVA: 0x0014BEA4 File Offset: 0x0014A0A4
		[Token(Token = "0x6003F34")]
		[Address(RVA = "0x865C40", Offset = "0x864240", VA = "0x180865C40", Slot = "6")]
		public override void Execute()
		{
			Plant plant = this.currentPlant;
			int num = 0;
			if (!(plant == num))
			{
				PlantType thePlantType = this.currentPlant.thePlantType;
				EventNodeDebug.Log(string.Format("[OnPlantDieNode] 触发植物死亡事件: {0}", thePlantType));
				string text = this.trigger_PortName;
				base.TriggerConnectedNodes(text);
				return;
			}
			string nodeId = this.nodeId;
			EventNodeDebug.LogWarning("[OnPlantDieNode] currentPlant 为 null，无法触发植物死亡事件，节点ID: " + nodeId);
		}

		// Token: 0x06003F35 RID: 16181 RVA: 0x0014BF10 File Offset: 0x0014A110
		[Token(Token = "0x6003F35")]
		[Address(RVA = "0x865F30", Offset = "0x864530", VA = "0x180865F30")]
		public OnPlantDieNode()
		{
		}

		// Token: 0x04003001 RID: 12289
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4003001")]
		public string trigger_PortName = "触发";

		// Token: 0x04003002 RID: 12290
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4003002")]
		public string plant_PortName = "植物";

		// Token: 0x04003003 RID: 12291
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4003003")]
		private Plant currentPlant;
	}
}
