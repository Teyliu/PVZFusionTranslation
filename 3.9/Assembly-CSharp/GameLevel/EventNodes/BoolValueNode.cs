using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace GameLevel.EventNodes
{
	// Token: 0x02000C1B RID: 3099
	[Token(Token = "0x2000C1B")]
	[Serializable]
	public class BoolValueNode : EventNodeBase
	{
		// Token: 0x0600406B RID: 16491 RVA: 0x00153120 File Offset: 0x00151320
		[Token(Token = "0x600406B")]
		[Address(RVA = "0x856A20", Offset = "0x855020", VA = "0x180856A20", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			return null;
		}

		// Token: 0x0600406C RID: 16492 RVA: 0x00153130 File Offset: 0x00151330
		[Token(Token = "0x600406C")]
		[Address(RVA = "0x856A60", Offset = "0x855060", VA = "0x180856A60", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			PortDefinition portDefinition = new PortDefinition(this.value_PortName, (PortType)((uint)6), (PortDirection)((uint)1));
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x0600406D RID: 16493 RVA: 0x00153168 File Offset: 0x00151368
		[Token(Token = "0x600406D")]
		[Address(RVA = "0x9EDB90", Offset = "0x9EC190", VA = "0x1809EDB90", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x0600406E RID: 16494 RVA: 0x001531A4 File Offset: 0x001513A4
		[Token(Token = "0x600406E")]
		[Address(RVA = "0x856B50", Offset = "0x855150", VA = "0x180856B50", Slot = "10")]
		public override int ShowEditorUI(RuntimeNodeUI ui)
		{
			RectTransform valueEditContainer = ui.valueEditContainer;
			GameObject togglePrefab = ui.togglePrefab;
			int num = 0;
			if (!(togglePrefab != num))
			{
				return 0;
			}
			GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(ui.togglePrefab, valueEditContainer);
			bool flag;
			Toggle toggle;
			if (!flag)
			{
				toggle = gameObject.AddComponent<Toggle>();
			}
			bool flag2 = this.value;
			toggle.isOn = flag2;
			Toggle.ToggleEvent onValueChanged = toggle.onValueChanged;
			UnityAction<bool> unityAction = delegate(bool val)
			{
				this.value = val;
				EventNodeDebug.Log(string.Format("[BoolValueNode] 更新值: {0}", "[BoolValueNode] 更新值: {0}"));
			};
			onValueChanged.AddListener(unityAction);
			throw new NullReferenceException();
		}

		// Token: 0x0600406F RID: 16495 RVA: 0x00153224 File Offset: 0x00151424
		[Token(Token = "0x600406F")]
		[Address(RVA = "0x856DA0", Offset = "0x8553A0", VA = "0x180856DA0")]
		public BoolValueNode()
		{
		}

		// Token: 0x0400317E RID: 12670
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400317E")]
		public bool value;

		// Token: 0x0400317F RID: 12671
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400317F")]
		public string value_PortName = "值";
	}
}
