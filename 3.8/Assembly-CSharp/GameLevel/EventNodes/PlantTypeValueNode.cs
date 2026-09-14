using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BD1 RID: 3025
	[Token(Token = "0x2000BD1")]
	[Serializable]
	public class PlantTypeValueNode : EventNodeBase
	{
		// Token: 0x06003EFC RID: 16124 RVA: 0x0014D7D8 File Offset: 0x0014B9D8
		[Token(Token = "0x6003EFC")]
		[Address(RVA = "0x800B60", Offset = "0x7FF160", VA = "0x180800B60", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			return null;
		}

		// Token: 0x06003EFD RID: 16125 RVA: 0x0014D7E8 File Offset: 0x0014B9E8
		[Token(Token = "0x6003EFD")]
		[Address(RVA = "0x800BA0", Offset = "0x7FF1A0", VA = "0x180800BA0", Slot = "5")]
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

		// Token: 0x06003EFE RID: 16126 RVA: 0x0014D820 File Offset: 0x0014BA20
		[Token(Token = "0x6003EFE")]
		[Address(RVA = "0x9FBDD0", Offset = "0x9FA3D0", VA = "0x1809FBDD0", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003EFF RID: 16127 RVA: 0x0014D85C File Offset: 0x0014BA5C
		[Token(Token = "0x6003EFF")]
		[Address(RVA = "0x800C90", Offset = "0x7FF290", VA = "0x180800C90", Slot = "10")]
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

		// Token: 0x06003F00 RID: 16128 RVA: 0x0014D8E4 File Offset: 0x0014BAE4
		[Token(Token = "0x6003F00")]
		[Address(RVA = "0x800E30", Offset = "0x7FF430", VA = "0x180800E30")]
		public PlantTypeValueNode()
		{
		}

		// Token: 0x04002FFB RID: 12283
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002FFB")]
		public PlantType value = (PlantType)((ulong)4294967295L);

		// Token: 0x04002FFC RID: 12284
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002FFC")]
		public string value_PortName = "植物类型";
	}
}
