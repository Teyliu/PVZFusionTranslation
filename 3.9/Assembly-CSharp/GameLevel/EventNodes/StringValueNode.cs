using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace GameLevel.EventNodes
{
	// Token: 0x02000C19 RID: 3097
	[Token(Token = "0x2000C19")]
	[Serializable]
	public class StringValueNode : EventNodeBase
	{
		// Token: 0x0600405F RID: 16479 RVA: 0x00152E9C File Offset: 0x0015109C
		[Token(Token = "0x600405F")]
		[Address(RVA = "0x86EDC0", Offset = "0x86D3C0", VA = "0x18086EDC0", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			return null;
		}

		// Token: 0x06004060 RID: 16480 RVA: 0x00152EAC File Offset: 0x001510AC
		[Token(Token = "0x6004060")]
		[Address(RVA = "0x86EE00", Offset = "0x86D400", VA = "0x18086EE00", Slot = "5")]
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

		// Token: 0x06004061 RID: 16481 RVA: 0x00152EE4 File Offset: 0x001510E4
		[Token(Token = "0x6004061")]
		[Address(RVA = "0xAC29E0", Offset = "0xAC0FE0", VA = "0x180AC29E0", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06004062 RID: 16482 RVA: 0x00152F1C File Offset: 0x0015111C
		[Token(Token = "0x6004062")]
		[Address(RVA = "0x86EEF0", Offset = "0x86D4F0", VA = "0x18086EEF0", Slot = "10")]
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

		// Token: 0x06004063 RID: 16483 RVA: 0x00152F8C File Offset: 0x0015118C
		[Token(Token = "0x6004063")]
		[Address(RVA = "0x86F0F0", Offset = "0x86D6F0", VA = "0x18086F0F0")]
		public StringValueNode()
		{
		}

		// Token: 0x0400317A RID: 12666
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400317A")]
		public string value = "默认文本";

		// Token: 0x0400317B RID: 12667
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400317B")]
		public string value_PortName = "值";
	}
}
