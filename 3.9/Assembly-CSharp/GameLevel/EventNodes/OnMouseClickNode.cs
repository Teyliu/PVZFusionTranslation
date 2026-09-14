using System;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BD5 RID: 3029
	[Token(Token = "0x2000BD5")]
	[Serializable]
	public class OnMouseClickNode : EventNodeBase
	{
		// Token: 0x06003F0B RID: 16139 RVA: 0x0014B580 File Offset: 0x00149780
		[Token(Token = "0x6003F0B")]
		[Address(RVA = "0x864D80", Offset = "0x863380", VA = "0x180864D80", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			return null;
		}

		// Token: 0x06003F0C RID: 16140 RVA: 0x0014B590 File Offset: 0x00149790
		[Token(Token = "0x6003F0C")]
		[Address(RVA = "0x864DC0", Offset = "0x8633C0", VA = "0x180864DC0", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[5];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.trigger_PortName, (PortType)num, (PortDirection)((uint)1));
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			PortDefinition portDefinition2 = new PortDefinition(this.row_PortName, (PortType)((uint)1), (PortDirection)((uint)1));
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			PortDefinition portDefinition3 = new PortDefinition(this.column_PortName, (PortType)((uint)1), (PortDirection)((uint)1));
			if (portDefinition3 != 0)
			{
			}
			array[2] = portDefinition3;
			PortDefinition portDefinition4 = new PortDefinition(this.item_PortName, (PortType)((uint)13), (PortDirection)((uint)1));
			if (portDefinition4 != 0)
			{
			}
			array[3] = portDefinition4;
			PortDefinition portDefinition5 = new PortDefinition(this.isLeftButton_PortName, (PortType)((uint)6), (PortDirection)((uint)1));
			if (portDefinition5 != 0)
			{
			}
			array[4] = portDefinition5;
			return array;
		}

		// Token: 0x06003F0D RID: 16141 RVA: 0x0014B648 File Offset: 0x00149848
		[Token(Token = "0x6003F0D")]
		[Address(RVA = "0x7F1610", Offset = "0x7EFC10", VA = "0x1807F1610")]
		public void SetClickData(MouseClickData data)
		{
			this.clickData = data;
		}

		// Token: 0x06003F0E RID: 16142 RVA: 0x0014B65C File Offset: 0x0014985C
		[Token(Token = "0x6003F0E")]
		[Address(RVA = "0xAA8330", Offset = "0xAA6930", VA = "0x180AA8330", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			if (this.clickData != (ulong)0L)
			{
				T portValue = base.GetPortValue(portName, defaultValue);
				bool isLeftButton = this.clickData.isLeftButton;
				bool flag;
				if (flag)
				{
				}
			}
			return defaultValue;
		}

		// Token: 0x06003F0F RID: 16143 RVA: 0x0014B6B8 File Offset: 0x001498B8
		[Token(Token = "0x6003F0F")]
		[Address(RVA = "0x864CF0", Offset = "0x8632F0", VA = "0x180864CF0", Slot = "6")]
		public override void Execute()
		{
			int num = 0;
			if (this.clickData != num)
			{
				string text = this.trigger_PortName;
				base.TriggerConnectedNodes(text);
				return;
			}
			string nodeId = this.nodeId;
			EventNodeDebug.LogWarning("[OnMouseClickNode] clickData 为 null，无法触发鼠标点击事件，节点ID: " + nodeId);
		}

		// Token: 0x06003F10 RID: 16144 RVA: 0x0014B6F8 File Offset: 0x001498F8
		[Token(Token = "0x6003F10")]
		[Address(RVA = "0x865090", Offset = "0x863690", VA = "0x180865090")]
		public OnMouseClickNode()
		{
		}

		// Token: 0x04002FED RID: 12269
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002FED")]
		public string trigger_PortName = "触发";

		// Token: 0x04002FEE RID: 12270
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002FEE")]
		public string row_PortName = "行";

		// Token: 0x04002FEF RID: 12271
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002FEF")]
		public string column_PortName = "列";

		// Token: 0x04002FF0 RID: 12272
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002FF0")]
		public string item_PortName = "手上的物品";

		// Token: 0x04002FF1 RID: 12273
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002FF1")]
		public string isLeftButton_PortName = "是左键";

		// Token: 0x04002FF2 RID: 12274
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002FF2")]
		private MouseClickData clickData;
	}
}
