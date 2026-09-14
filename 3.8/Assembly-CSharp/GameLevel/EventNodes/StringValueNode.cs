using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BD7 RID: 3031
	[Token(Token = "0x2000BD7")]
	[Serializable]
	public class StringValueNode : EventNodeBase
	{
		// Token: 0x06003F0E RID: 16142 RVA: 0x0014DC44 File Offset: 0x0014BE44
		[Token(Token = "0x6003F0E")]
		[Address(RVA = "0x807410", Offset = "0x805A10", VA = "0x180807410", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			return null;
		}

		// Token: 0x06003F0F RID: 16143 RVA: 0x0014DC54 File Offset: 0x0014BE54
		[Token(Token = "0x6003F0F")]
		[Address(RVA = "0x807450", Offset = "0x805A50", VA = "0x180807450", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			PortDefinition portDefinition = new PortDefinition(this.value_PortName, (PortType)((uint)5), (PortDirection)((uint)1));
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003F10 RID: 16144 RVA: 0x0014DC8C File Offset: 0x0014BE8C
		[Token(Token = "0x6003F10")]
		[Address(RVA = "0xA10430", Offset = "0xA0EA30", VA = "0x180A10430", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003F11 RID: 16145 RVA: 0x0014DCC4 File Offset: 0x0014BEC4
		[Token(Token = "0x6003F11")]
		[Address(RVA = "0x807540", Offset = "0x805B40", VA = "0x180807540", Slot = "10")]
		public override int ShowEditorUI(RuntimeNodeUI ui)
		{
			GameObject inputFieldPrefab = ui.inputFieldPrefab;
			RectTransform valueEditContainer = ui.valueEditContainer;
			TMP_InputField component = global::UnityEngine.Object.Instantiate<GameObject>(inputFieldPrefab, valueEditContainer).GetComponent<TMP_InputField>();
			int num = 0;
			if (component != num)
			{
				string text = this.value;
				component.text = text;
				int num2 = 0;
				component.contentType = (TMP_InputField.ContentType)num2;
				component.lineType = (TMP_InputField.LineType)((uint)2);
				UnityAction<string> unityAction;
				component.m_OnValueChanged.AddListener(unityAction);
			}
			return 1;
		}

		// Token: 0x06003F12 RID: 16146 RVA: 0x0014DD34 File Offset: 0x0014BF34
		[Token(Token = "0x6003F12")]
		[Address(RVA = "0x807740", Offset = "0x805D40", VA = "0x180807740")]
		public StringValueNode()
		{
		}

		// Token: 0x04003007 RID: 12295
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4003007")]
		public string value = "默认文本";

		// Token: 0x04003008 RID: 12296
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4003008")]
		public string value_PortName = "值";
	}
}
