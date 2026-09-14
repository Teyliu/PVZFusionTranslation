using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BDB RID: 3035
	[Token(Token = "0x2000BDB")]
	[Serializable]
	public class SinglePlantTypeListNode : EventNodeBase
	{
		// Token: 0x06003F27 RID: 16167 RVA: 0x0014E2BC File Offset: 0x0014C4BC
		[Token(Token = "0x6003F27")]
		[Address(RVA = "0x806C20", Offset = "0x805220", VA = "0x180806C20", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			return null;
		}

		// Token: 0x06003F28 RID: 16168 RVA: 0x0014E2CC File Offset: 0x0014C4CC
		[Token(Token = "0x6003F28")]
		[Address(RVA = "0x806C60", Offset = "0x805260", VA = "0x180806C60", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			PortDefinition portDefinition = new PortDefinition(this.plantTypeList_PortName, (PortType)((uint)16), (PortDirection)((uint)1));
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003F29 RID: 16169 RVA: 0x0014E304 File Offset: 0x0014C504
		[Token(Token = "0x6003F29")]
		[Address(RVA = "0x806D50", Offset = "0x805350", VA = "0x180806D50", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			List<PlantType> list = new List();
			this.cachedList = list;
		}

		// Token: 0x06003F2A RID: 16170 RVA: 0x0014E320 File Offset: 0x0014C520
		[Token(Token = "0x6003F2A")]
		[Address(RVA = "0xA09190", Offset = "0xA07790", VA = "0x180A09190", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003F2B RID: 16171 RVA: 0x0014E370 File Offset: 0x0014C570
		[Token(Token = "0x6003F2B")]
		[Address(RVA = "0x806DC0", Offset = "0x8053C0", VA = "0x180806DC0", Slot = "10")]
		public override int ShowEditorUI(RuntimeNodeUI ui)
		{
			TheButton buttonPrefab = ui.buttonPrefab;
			RectTransform valueEditContainer = ui.valueEditContainer;
			TheButton theButton = global::UnityEngine.Object.Instantiate<TheButton>(buttonPrefab, valueEditContainer);
			TheButton button = theButton;
			TextMeshProUGUI componentInChildren = button.GetComponentInChildren<TextMeshProUGUI>();
			string name = Lawnf.GetName(this.plantType);
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

		// Token: 0x06003F2C RID: 16172 RVA: 0x0014E3F8 File Offset: 0x0014C5F8
		[Token(Token = "0x6003F2C")]
		[Address(RVA = "0x806F60", Offset = "0x805560", VA = "0x180806F60")]
		public SinglePlantTypeListNode()
		{
		}

		// Token: 0x04003017 RID: 12311
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4003017")]
		public PlantType plantType = (PlantType)((ulong)4294967295L);

		// Token: 0x04003018 RID: 12312
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4003018")]
		public string plantTypeList_PortName = "植物类型列表";

		// Token: 0x04003019 RID: 12313
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4003019")]
		[NonSerialized]
		private List<PlantType> cachedList;
	}
}
