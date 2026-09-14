using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace GameLevel.EventNodes
{
	// Token: 0x02000C1A RID: 3098
	[Token(Token = "0x2000C1A")]
	[Serializable]
	public class FloatValueNode : EventNodeBase
	{
		// Token: 0x06004065 RID: 16485 RVA: 0x00152FE4 File Offset: 0x001511E4
		[Token(Token = "0x6004065")]
		[Address(RVA = "0x85C3F0", Offset = "0x85A9F0", VA = "0x18085C3F0", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			return null;
		}

		// Token: 0x06004066 RID: 16486 RVA: 0x00152FF4 File Offset: 0x001511F4
		[Token(Token = "0x6004066")]
		[Address(RVA = "0x85C430", Offset = "0x85AA30", VA = "0x18085C430", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			PortDefinition portDefinition = new PortDefinition(this.value_PortName, (PortType)((uint)3), (PortDirection)((uint)1));
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06004067 RID: 16487 RVA: 0x0015302C File Offset: 0x0015122C
		[Token(Token = "0x6004067")]
		[Address(RVA = "0xA52190", Offset = "0xA50790", VA = "0x180A52190", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06004068 RID: 16488 RVA: 0x00153068 File Offset: 0x00151268
		[Token(Token = "0x6004068")]
		[Address(RVA = "0x85C520", Offset = "0x85AB20", VA = "0x18085C520", Slot = "10")]
		public override int ShowEditorUI(RuntimeNodeUI ui)
		{
			GameObject inputFieldPrefab = ui.inputFieldPrefab;
			RectTransform valueEditContainer = ui.valueEditContainer;
			TMP_InputField component = global::UnityEngine.Object.Instantiate<GameObject>(inputFieldPrefab, valueEditContainer).GetComponent<TMP_InputField>();
			int num = 0;
			if (component != num)
			{
				string text;
				component.text = text;
				component.contentType = (TMP_InputField.ContentType)((uint)3);
				UnityAction<string> unityAction;
				component.m_OnValueChanged.AddListener(unityAction);
			}
			return 1;
		}

		// Token: 0x06004069 RID: 16489 RVA: 0x001530C4 File Offset: 0x001512C4
		[Token(Token = "0x6004069")]
		[Address(RVA = "0x85C750", Offset = "0x85AD50", VA = "0x18085C750")]
		public FloatValueNode()
		{
		}

		// Token: 0x0400317C RID: 12668
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400317C")]
		public float value = 3f;

		// Token: 0x0400317D RID: 12669
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400317D")]
		public string value_PortName = "值";
	}
}
