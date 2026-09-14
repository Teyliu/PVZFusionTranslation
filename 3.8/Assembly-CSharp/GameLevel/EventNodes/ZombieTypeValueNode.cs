using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BD4 RID: 3028
	[Token(Token = "0x2000BD4")]
	[Serializable]
	public class ZombieTypeValueNode : EventNodeBase
	{
		// Token: 0x06003F05 RID: 16133 RVA: 0x0014DA1C File Offset: 0x0014BC1C
		[Token(Token = "0x6003F05")]
		[Address(RVA = "0x80B480", Offset = "0x809A80", VA = "0x18080B480", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			return null;
		}

		// Token: 0x06003F06 RID: 16134 RVA: 0x0014DA2C File Offset: 0x0014BC2C
		[Token(Token = "0x6003F06")]
		[Address(RVA = "0x80B4C0", Offset = "0x809AC0", VA = "0x18080B4C0", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			PortDefinition portDefinition = new PortDefinition(this.value_PortName, (PortType)((uint)10), (PortDirection)((uint)1));
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003F07 RID: 16135 RVA: 0x0014DA64 File Offset: 0x0014BC64
		[Token(Token = "0x6003F07")]
		[Address(RVA = "0xA5D5A0", Offset = "0xA5BBA0", VA = "0x180A5D5A0", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003F08 RID: 16136 RVA: 0x0014DAA0 File Offset: 0x0014BCA0
		[Token(Token = "0x6003F08")]
		[Address(RVA = "0x80B5B0", Offset = "0x809BB0", VA = "0x18080B5B0", Slot = "10")]
		public override int ShowEditorUI(RuntimeNodeUI ui)
		{
			TheButton buttonPrefab = ui.buttonPrefab;
			RectTransform valueEditContainer = ui.valueEditContainer;
			TheButton theButton = global::UnityEngine.Object.Instantiate<TheButton>(buttonPrefab, valueEditContainer);
			TheButton button = theButton;
			TextMeshProUGUI componentInChildren = button.GetComponentInChildren<TextMeshProUGUI>();
			string name = Lawnf.GetName(this.value);
			componentInChildren.text = name;
			UnityEvent theEvent_up = button.theEvent_up;
			UnityAction unityAction = delegate
			{
				UIResourcesLoader uimanager = GameAPP.UIManager;
				Transform canvasUp = GameAPP.canvasUp;
				int num = 0;
				int num2 = 0;
				BaseMenu baseMenu = uimanager.Push((UIType)((uint)57), canvasUp, num2 != 0);
				AlmanacZombieMenu menu;
				if (baseMenu == 0)
				{
					menu = num;
				}
				menu = baseMenu;
				UnityAction<ZombieType> unityAction2;
				menu.onClickZombieCard.AddListener(unityAction2);
			};
			theEvent_up.AddListener(unityAction);
			return 1;
		}

		// Token: 0x06003F09 RID: 16137 RVA: 0x0014DB28 File Offset: 0x0014BD28
		[Token(Token = "0x6003F09")]
		[Address(RVA = "0x80B750", Offset = "0x809D50", VA = "0x18080B750")]
		public ZombieTypeValueNode()
		{
		}

		// Token: 0x04003001 RID: 12289
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4003001")]
		public ZombieType value;

		// Token: 0x04003002 RID: 12290
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4003002")]
		public string value_PortName = "僵尸类型";
	}
}
