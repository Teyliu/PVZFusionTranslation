using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace GameLevel.EventNodes
{
	// Token: 0x02000C13 RID: 3091
	[Token(Token = "0x2000C13")]
	[Serializable]
	public class PlantTypeValueNode : EventNodeBase
	{
		// Token: 0x0600404D RID: 16461 RVA: 0x00152A30 File Offset: 0x00150C30
		[Token(Token = "0x600404D")]
		[Address(RVA = "0x868510", Offset = "0x866B10", VA = "0x180868510", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			return null;
		}

		// Token: 0x0600404E RID: 16462 RVA: 0x00152A40 File Offset: 0x00150C40
		[Token(Token = "0x600404E")]
		[Address(RVA = "0x868550", Offset = "0x866B50", VA = "0x180868550", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			PortDefinition portDefinition = new PortDefinition(this.value_PortName, (PortType)((uint)9), (PortDirection)((uint)1));
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x0600404F RID: 16463 RVA: 0x00152A78 File Offset: 0x00150C78
		[Token(Token = "0x600404F")]
		[Address(RVA = "0xAAD610", Offset = "0xAABC10", VA = "0x180AAD610", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06004050 RID: 16464 RVA: 0x00152AB4 File Offset: 0x00150CB4
		[Token(Token = "0x6004050")]
		[Address(RVA = "0x868640", Offset = "0x866C40", VA = "0x180868640", Slot = "10")]
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
				BaseMenu baseMenu = uimanager.Push((UIType)((uint)56), canvasUp, num2 != 0);
				AlmanacPlantMenu menu;
				if (baseMenu == 0)
				{
					menu = num;
				}
				menu = baseMenu;
				UnityAction<AlmanacCardUI> unityAction2;
				menu.onClickPlantCard.AddListener(unityAction2);
			};
			theEvent_up.AddListener(unityAction);
			return 1;
		}

		// Token: 0x06004051 RID: 16465 RVA: 0x00152B3C File Offset: 0x00150D3C
		[Token(Token = "0x6004051")]
		[Address(RVA = "0x8687E0", Offset = "0x866DE0", VA = "0x1808687E0")]
		public PlantTypeValueNode()
		{
		}

		// Token: 0x0400316E RID: 12654
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400316E")]
		public PlantType value = (PlantType)((ulong)4294967295L);

		// Token: 0x0400316F RID: 12655
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400316F")]
		public string value_PortName = "植物类型";
	}
}
