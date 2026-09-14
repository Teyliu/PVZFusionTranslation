using System;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B9C RID: 2972
	[Token(Token = "0x2000B9C")]
	[Serializable]
	public class OnPlantClickNode : EventNodeBase
	{
		// Token: 0x06003DEB RID: 15851 RVA: 0x00146E5C File Offset: 0x0014505C
		[Token(Token = "0x6003DEB")]
		[Address(RVA = "0x7FD910", Offset = "0x7FBF10", VA = "0x1807FD910", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			return null;
		}

		// Token: 0x06003DEC RID: 15852 RVA: 0x00146E6C File Offset: 0x0014506C
		[Token(Token = "0x6003DEC")]
		[Address(RVA = "0x7FD950", Offset = "0x7FBF50", VA = "0x1807FD950", Slot = "5")]
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

		// Token: 0x06003DED RID: 15853 RVA: 0x00146EC4 File Offset: 0x001450C4
		[Token(Token = "0x6003DED")]
		[Address(RVA = "0x74FFB0", Offset = "0x74E5B0", VA = "0x18074FFB0")]
		public void SetPlant(Plant plant)
		{
			this.clickedPlant = plant;
		}

		// Token: 0x06003DEE RID: 15854 RVA: 0x00146ED8 File Offset: 0x001450D8
		[Token(Token = "0x6003DEE")]
		[Address(RVA = "0x9F7C30", Offset = "0x9F6230", VA = "0x1809F7C30", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003DEF RID: 15855 RVA: 0x00146F20 File Offset: 0x00145120
		[Token(Token = "0x6003DEF")]
		[Address(RVA = "0x7FD7D0", Offset = "0x7FBDD0", VA = "0x1807FD7D0", Slot = "6")]
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

		// Token: 0x06003DF0 RID: 15856 RVA: 0x00146F8C File Offset: 0x0014518C
		[Token(Token = "0x6003DF0")]
		[Address(RVA = "0x7FDAC0", Offset = "0x7FC0C0", VA = "0x1807FDAC0")]
		public OnPlantClickNode()
		{
		}

		// Token: 0x04002E95 RID: 11925
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002E95")]
		public string trigger_PortName = "触发";

		// Token: 0x04002E96 RID: 11926
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002E96")]
		public string plant_PortName = "植物";

		// Token: 0x04002E97 RID: 11927
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002E97")]
		private Plant clickedPlant;
	}
}
