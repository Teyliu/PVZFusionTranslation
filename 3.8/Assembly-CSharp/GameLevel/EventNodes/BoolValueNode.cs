using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BD9 RID: 3033
	[Token(Token = "0x2000BD9")]
	[Serializable]
	public class BoolValueNode : EventNodeBase
	{
		// Token: 0x06003F1A RID: 16154 RVA: 0x0014DEC8 File Offset: 0x0014C0C8
		[Token(Token = "0x6003F1A")]
		[Address(RVA = "0x7EEF50", Offset = "0x7ED550", VA = "0x1807EEF50", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			return null;
		}

		// Token: 0x06003F1B RID: 16155 RVA: 0x0014DED8 File Offset: 0x0014C0D8
		[Token(Token = "0x6003F1B")]
		[Address(RVA = "0x7EEF90", Offset = "0x7ED590", VA = "0x1807EEF90", Slot = "5")]
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

		// Token: 0x06003F1C RID: 16156 RVA: 0x0014DF10 File Offset: 0x0014C110
		[Token(Token = "0x6003F1C")]
		[Address(RVA = "0x9321E0", Offset = "0x9307E0", VA = "0x1809321E0", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003F1D RID: 16157 RVA: 0x0014DF4C File Offset: 0x0014C14C
		[Token(Token = "0x6003F1D")]
		[Address(RVA = "0x7EF080", Offset = "0x7ED680", VA = "0x1807EF080", Slot = "10")]
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

		// Token: 0x06003F1E RID: 16158 RVA: 0x0014DFCC File Offset: 0x0014C1CC
		[Token(Token = "0x6003F1E")]
		[Address(RVA = "0x7EF2D0", Offset = "0x7ED8D0", VA = "0x1807EF2D0")]
		public BoolValueNode()
		{
		}

		// Token: 0x0400300B RID: 12299
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400300B")]
		public bool value;

		// Token: 0x0400300C RID: 12300
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400300C")]
		public string value_PortName = "值";
	}
}
