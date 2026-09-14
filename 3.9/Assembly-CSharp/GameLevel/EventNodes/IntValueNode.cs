using System;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel.EventNodes
{
	// Token: 0x02000C12 RID: 3090
	[Token(Token = "0x2000C12")]
	[Serializable]
	public class IntValueNode : EventNodeBase
	{
		// Token: 0x06004047 RID: 16455 RVA: 0x00152920 File Offset: 0x00150B20
		[Token(Token = "0x6004047")]
		[Address(RVA = "0x860950", Offset = "0x85EF50", VA = "0x180860950", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			return null;
		}

		// Token: 0x06004048 RID: 16456 RVA: 0x00152930 File Offset: 0x00150B30
		[Token(Token = "0x6004048")]
		[Address(RVA = "0x860990", Offset = "0x85EF90", VA = "0x180860990", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			PortDefinition portDefinition = new PortDefinition(this.value_PortName, (PortType)((uint)1), (PortDirection)((uint)1));
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06004049 RID: 16457 RVA: 0x00152968 File Offset: 0x00150B68
		[Token(Token = "0x6004049")]
		[Address(RVA = "0xA718C0", Offset = "0xA6FEC0", VA = "0x180A718C0", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x0600404A RID: 16458 RVA: 0x001529A4 File Offset: 0x00150BA4
		[Token(Token = "0x600404A")]
		[Address(RVA = "0x860A80", Offset = "0x85F080", VA = "0x180860A80", Slot = "10")]
		public override int ShowEditorUI(RuntimeNodeUI ui)
		{
			GameObject inputFieldPrefab = ui.inputFieldPrefab;
			RectTransform valueEditContainer = ui.valueEditContainer;
			GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(inputFieldPrefab, valueEditContainer);
			bool flag;
			if (flag)
			{
			}
			return 1;
		}

		// Token: 0x0600404B RID: 16459 RVA: 0x001529D8 File Offset: 0x00150BD8
		[Token(Token = "0x600404B")]
		[Address(RVA = "0x860CC0", Offset = "0x85F2C0", VA = "0x180860CC0")]
		public IntValueNode()
		{
		}

		// Token: 0x0400316C RID: 12652
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400316C")]
		public int value = (int)((ulong)1L);

		// Token: 0x0400316D RID: 12653
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400316D")]
		public string value_PortName = "值";
	}
}
