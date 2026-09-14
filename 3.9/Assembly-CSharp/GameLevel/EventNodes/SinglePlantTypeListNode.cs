using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace GameLevel.EventNodes
{
	// Token: 0x02000C1D RID: 3101
	[Token(Token = "0x2000C1D")]
	[Serializable]
	public class SinglePlantTypeListNode : EventNodeBase
	{
		// Token: 0x06004078 RID: 16504 RVA: 0x00153514 File Offset: 0x00151714
		[Token(Token = "0x6004078")]
		[Address(RVA = "0x86E5D0", Offset = "0x86CBD0", VA = "0x18086E5D0", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			return null;
		}

		// Token: 0x06004079 RID: 16505 RVA: 0x00153524 File Offset: 0x00151724
		[Token(Token = "0x6004079")]
		[Address(RVA = "0x86E610", Offset = "0x86CC10", VA = "0x18086E610", Slot = "5")]
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

		// Token: 0x0600407A RID: 16506 RVA: 0x0015355C File Offset: 0x0015175C
		[Token(Token = "0x600407A")]
		[Address(RVA = "0x86E700", Offset = "0x86CD00", VA = "0x18086E700", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			List<PlantType> list = new List();
			this.cachedList = list;
		}

		// Token: 0x0600407B RID: 16507 RVA: 0x00153578 File Offset: 0x00151778
		[Token(Token = "0x600407B")]
		[Address(RVA = "0xABBD80", Offset = "0xABA380", VA = "0x180ABBD80", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x0600407C RID: 16508 RVA: 0x001535C8 File Offset: 0x001517C8
		[Token(Token = "0x600407C")]
		[Address(RVA = "0x86E770", Offset = "0x86CD70", VA = "0x18086E770", Slot = "10")]
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

		// Token: 0x0600407D RID: 16509 RVA: 0x00153650 File Offset: 0x00151850
		[Token(Token = "0x600407D")]
		[Address(RVA = "0x86E910", Offset = "0x86CF10", VA = "0x18086E910")]
		public SinglePlantTypeListNode()
		{
		}

		// Token: 0x0400318A RID: 12682
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400318A")]
		public PlantType plantType = (PlantType)((ulong)4294967295L);

		// Token: 0x0400318B RID: 12683
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400318B")]
		public string plantTypeList_PortName = "植物类型列表";

		// Token: 0x0400318C RID: 12684
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400318C")]
		[NonSerialized]
		private List<PlantType> cachedList;
	}
}
