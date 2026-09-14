using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BD8 RID: 3032
	[Token(Token = "0x2000BD8")]
	[Serializable]
	public class FloatValueNode : EventNodeBase
	{
		// Token: 0x06003F14 RID: 16148 RVA: 0x0014DD8C File Offset: 0x0014BF8C
		[Token(Token = "0x6003F14")]
		[Address(RVA = "0x7F4840", Offset = "0x7F2E40", VA = "0x1807F4840", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			return null;
		}

		// Token: 0x06003F15 RID: 16149 RVA: 0x0014DD9C File Offset: 0x0014BF9C
		[Token(Token = "0x6003F15")]
		[Address(RVA = "0x7F4880", Offset = "0x7F2E80", VA = "0x1807F4880", Slot = "5")]
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

		// Token: 0x06003F16 RID: 16150 RVA: 0x0014DDD4 File Offset: 0x0014BFD4
		[Token(Token = "0x6003F16")]
		[Address(RVA = "0x9A8BD0", Offset = "0x9A71D0", VA = "0x1809A8BD0", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003F17 RID: 16151 RVA: 0x0014DE10 File Offset: 0x0014C010
		[Token(Token = "0x6003F17")]
		[Address(RVA = "0x7F4970", Offset = "0x7F2F70", VA = "0x1807F4970", Slot = "10")]
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

		// Token: 0x06003F18 RID: 16152 RVA: 0x0014DE6C File Offset: 0x0014C06C
		[Token(Token = "0x6003F18")]
		[Address(RVA = "0x7F4BA0", Offset = "0x7F31A0", VA = "0x1807F4BA0")]
		public FloatValueNode()
		{
		}

		// Token: 0x04003009 RID: 12297
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4003009")]
		public float value = 3f;

		// Token: 0x0400300A RID: 12298
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400300A")]
		public string value_PortName = "值";
	}
}
