using System;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B9A RID: 2970
	[Token(Token = "0x2000B9A")]
	[Serializable]
	public class OnPlantDieNode : EventNodeBase
	{
		// Token: 0x06003DDF RID: 15839 RVA: 0x00146B70 File Offset: 0x00144D70
		[Token(Token = "0x6003DDF")]
		[Address(RVA = "0x7FE3D0", Offset = "0x7FC9D0", VA = "0x1807FE3D0", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			return null;
		}

		// Token: 0x06003DE0 RID: 15840 RVA: 0x00146B80 File Offset: 0x00144D80
		[Token(Token = "0x6003DE0")]
		[Address(RVA = "0x7FE410", Offset = "0x7FCA10", VA = "0x1807FE410", Slot = "5")]
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

		// Token: 0x06003DE1 RID: 15841 RVA: 0x00146BD8 File Offset: 0x00144DD8
		[Token(Token = "0x6003DE1")]
		[Address(RVA = "0x74FFB0", Offset = "0x74E5B0", VA = "0x18074FFB0")]
		public void SetPlant(Plant plant)
		{
			this.currentPlant = plant;
		}

		// Token: 0x06003DE2 RID: 15842 RVA: 0x00146BEC File Offset: 0x00144DEC
		[Token(Token = "0x6003DE2")]
		[Address(RVA = "0x9F7C30", Offset = "0x9F6230", VA = "0x1809F7C30", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003DE3 RID: 15843 RVA: 0x00146C34 File Offset: 0x00144E34
		[Token(Token = "0x6003DE3")]
		[Address(RVA = "0x7FE290", Offset = "0x7FC890", VA = "0x1807FE290", Slot = "6")]
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

		// Token: 0x06003DE4 RID: 15844 RVA: 0x00146CA0 File Offset: 0x00144EA0
		[Token(Token = "0x6003DE4")]
		[Address(RVA = "0x7FE580", Offset = "0x7FCB80", VA = "0x1807FE580")]
		public OnPlantDieNode()
		{
		}

		// Token: 0x04002E8D RID: 11917
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002E8D")]
		public string trigger_PortName = "触发";

		// Token: 0x04002E8E RID: 11918
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002E8E")]
		public string plant_PortName = "植物";

		// Token: 0x04002E8F RID: 11919
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002E8F")]
		private Plant currentPlant;
	}
}
