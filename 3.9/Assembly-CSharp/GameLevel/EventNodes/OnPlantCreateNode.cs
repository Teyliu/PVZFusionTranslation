using System;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BD9 RID: 3033
	[Token(Token = "0x2000BD9")]
	[Serializable]
	public class OnPlantCreateNode : EventNodeBase
	{
		// Token: 0x06003F1E RID: 16158 RVA: 0x0014B9F0 File Offset: 0x00149BF0
		[Token(Token = "0x6003F1E")]
		[Address(RVA = "0x8655B0", Offset = "0x863BB0", VA = "0x1808655B0", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			return null;
		}

		// Token: 0x06003F1F RID: 16159 RVA: 0x0014BA00 File Offset: 0x00149C00
		[Token(Token = "0x6003F1F")]
		[Address(RVA = "0x8655F0", Offset = "0x863BF0", VA = "0x1808655F0", Slot = "5")]
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

		// Token: 0x06003F20 RID: 16160 RVA: 0x0014BA58 File Offset: 0x00149C58
		[Token(Token = "0x6003F20")]
		[Address(RVA = "0x7B6970", Offset = "0x7B4F70", VA = "0x1807B6970")]
		public void SetPlant(Plant plant)
		{
			this.currentPlant = plant;
		}

		// Token: 0x06003F21 RID: 16161 RVA: 0x0014BA6C File Offset: 0x00149C6C
		[Token(Token = "0x6003F21")]
		[Address(RVA = "0xAA9470", Offset = "0xAA7A70", VA = "0x180AA9470", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003F22 RID: 16162 RVA: 0x0014BAB4 File Offset: 0x00149CB4
		[Token(Token = "0x6003F22")]
		[Address(RVA = "0x8654F0", Offset = "0x863AF0", VA = "0x1808654F0", Slot = "6")]
		public override void Execute()
		{
			Plant plant = this.currentPlant;
			int num = 0;
			if (!(plant == num))
			{
				string text = this.trigger_PortName;
				base.TriggerConnectedNodes(text);
				return;
			}
			string nodeId = this.nodeId;
			EventNodeDebug.LogWarning("[OnPlantCreateNode] currentPlant 为 null，无法触发植物种植事件，节点ID: " + nodeId);
		}

		// Token: 0x06003F23 RID: 16163 RVA: 0x0014BAFC File Offset: 0x00149CFC
		[Token(Token = "0x6003F23")]
		[Address(RVA = "0x865760", Offset = "0x863D60", VA = "0x180865760")]
		public OnPlantCreateNode()
		{
		}

		// Token: 0x04002FF8 RID: 12280
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002FF8")]
		public string trigger_PortName = "触发";

		// Token: 0x04002FF9 RID: 12281
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002FF9")]
		public string plant_PortName = "植物";

		// Token: 0x04002FFA RID: 12282
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002FFA")]
		private Plant currentPlant;
	}
}
