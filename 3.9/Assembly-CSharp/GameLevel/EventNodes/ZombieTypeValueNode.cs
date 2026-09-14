using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace GameLevel.EventNodes
{
	// Token: 0x02000C16 RID: 3094
	[Token(Token = "0x2000C16")]
	[Serializable]
	public class ZombieTypeValueNode : EventNodeBase
	{
		// Token: 0x06004056 RID: 16470 RVA: 0x00152C74 File Offset: 0x00150E74
		[Token(Token = "0x6004056")]
		[Address(RVA = "0x872E70", Offset = "0x871470", VA = "0x180872E70", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			return null;
		}

		// Token: 0x06004057 RID: 16471 RVA: 0x00152C84 File Offset: 0x00150E84
		[Token(Token = "0x6004057")]
		[Address(RVA = "0x872EB0", Offset = "0x8714B0", VA = "0x180872EB0", Slot = "5")]
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

		// Token: 0x06004058 RID: 16472 RVA: 0x00152CBC File Offset: 0x00150EBC
		[Token(Token = "0x6004058")]
		[Address(RVA = "0xB353B0", Offset = "0xB339B0", VA = "0x180B353B0", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06004059 RID: 16473 RVA: 0x00152CF8 File Offset: 0x00150EF8
		[Token(Token = "0x6004059")]
		[Address(RVA = "0x872FA0", Offset = "0x8715A0", VA = "0x180872FA0", Slot = "10")]
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

		// Token: 0x0600405A RID: 16474 RVA: 0x00152D80 File Offset: 0x00150F80
		[Token(Token = "0x600405A")]
		[Address(RVA = "0x873140", Offset = "0x871740", VA = "0x180873140")]
		public ZombieTypeValueNode()
		{
		}

		// Token: 0x04003174 RID: 12660
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4003174")]
		public ZombieType value;

		// Token: 0x04003175 RID: 12661
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4003175")]
		public string value_PortName = "僵尸类型";
	}
}
