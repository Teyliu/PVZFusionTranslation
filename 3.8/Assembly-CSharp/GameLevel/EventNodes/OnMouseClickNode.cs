using System;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B93 RID: 2963
	[Token(Token = "0x2000B93")]
	[Serializable]
	public class OnMouseClickNode : EventNodeBase
	{
		// Token: 0x06003DBA RID: 15802 RVA: 0x00146310 File Offset: 0x00144510
		[Token(Token = "0x6003DBA")]
		[Address(RVA = "0x7FD3D0", Offset = "0x7FB9D0", VA = "0x1807FD3D0", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			return null;
		}

		// Token: 0x06003DBB RID: 15803 RVA: 0x00146320 File Offset: 0x00144520
		[Token(Token = "0x6003DBB")]
		[Address(RVA = "0x7FD410", Offset = "0x7FBA10", VA = "0x1807FD410", Slot = "5")]
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

		// Token: 0x06003DBC RID: 15804 RVA: 0x001463D8 File Offset: 0x001445D8
		[Token(Token = "0x6003DBC")]
		[Address(RVA = "0x78AFA0", Offset = "0x7895A0", VA = "0x18078AFA0")]
		public void SetClickData(MouseClickData data)
		{
			this.clickData = data;
		}

		// Token: 0x06003DBD RID: 15805 RVA: 0x001463EC File Offset: 0x001445EC
		[Token(Token = "0x6003DBD")]
		[Address(RVA = "0x9F6AF0", Offset = "0x9F50F0", VA = "0x1809F6AF0", Slot = "9")]
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

		// Token: 0x06003DBE RID: 15806 RVA: 0x00146448 File Offset: 0x00144648
		[Token(Token = "0x6003DBE")]
		[Address(RVA = "0x7FD340", Offset = "0x7FB940", VA = "0x1807FD340", Slot = "6")]
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

		// Token: 0x06003DBF RID: 15807 RVA: 0x00146488 File Offset: 0x00144688
		[Token(Token = "0x6003DBF")]
		[Address(RVA = "0x7FD6E0", Offset = "0x7FBCE0", VA = "0x1807FD6E0")]
		public OnMouseClickNode()
		{
		}

		// Token: 0x04002E79 RID: 11897
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002E79")]
		public string trigger_PortName = "触发";

		// Token: 0x04002E7A RID: 11898
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002E7A")]
		public string row_PortName = "行";

		// Token: 0x04002E7B RID: 11899
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002E7B")]
		public string column_PortName = "列";

		// Token: 0x04002E7C RID: 11900
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002E7C")]
		public string item_PortName = "手上的物品";

		// Token: 0x04002E7D RID: 11901
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002E7D")]
		public string isLeftButton_PortName = "是左键";

		// Token: 0x04002E7E RID: 11902
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002E7E")]
		private MouseClickData clickData;
	}
}
