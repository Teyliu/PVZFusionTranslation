using System;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B97 RID: 2967
	[Token(Token = "0x2000B97")]
	[Serializable]
	public class OnPlantCreateNode : EventNodeBase
	{
		// Token: 0x06003DCD RID: 15821 RVA: 0x00146780 File Offset: 0x00144980
		[Token(Token = "0x6003DCD")]
		[Address(RVA = "0x7FDC00", Offset = "0x7FC200", VA = "0x1807FDC00", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			return null;
		}

		// Token: 0x06003DCE RID: 15822 RVA: 0x00146790 File Offset: 0x00144990
		[Token(Token = "0x6003DCE")]
		[Address(RVA = "0x7FDC40", Offset = "0x7FC240", VA = "0x1807FDC40", Slot = "5")]
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

		// Token: 0x06003DCF RID: 15823 RVA: 0x001467E8 File Offset: 0x001449E8
		[Token(Token = "0x6003DCF")]
		[Address(RVA = "0x74FFB0", Offset = "0x74E5B0", VA = "0x18074FFB0")]
		public void SetPlant(Plant plant)
		{
			this.currentPlant = plant;
		}

		// Token: 0x06003DD0 RID: 15824 RVA: 0x001467FC File Offset: 0x001449FC
		[Token(Token = "0x6003DD0")]
		[Address(RVA = "0x9F7C30", Offset = "0x9F6230", VA = "0x1809F7C30", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003DD1 RID: 15825 RVA: 0x00146844 File Offset: 0x00144A44
		[Token(Token = "0x6003DD1")]
		[Address(RVA = "0x7FDB40", Offset = "0x7FC140", VA = "0x1807FDB40", Slot = "6")]
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

		// Token: 0x06003DD2 RID: 15826 RVA: 0x0014688C File Offset: 0x00144A8C
		[Token(Token = "0x6003DD2")]
		[Address(RVA = "0x7FDDB0", Offset = "0x7FC3B0", VA = "0x1807FDDB0")]
		public OnPlantCreateNode()
		{
		}

		// Token: 0x04002E84 RID: 11908
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002E84")]
		public string trigger_PortName = "触发";

		// Token: 0x04002E85 RID: 11909
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002E85")]
		public string plant_PortName = "植物";

		// Token: 0x04002E86 RID: 11910
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002E86")]
		private Plant currentPlant;
	}
}
