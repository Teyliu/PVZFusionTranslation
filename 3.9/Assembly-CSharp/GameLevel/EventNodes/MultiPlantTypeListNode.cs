using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace GameLevel.EventNodes
{
	// Token: 0x02000C20 RID: 3104
	[Token(Token = "0x2000C20")]
	[Serializable]
	public class MultiPlantTypeListNode : EventNodeBase
	{
		// Token: 0x06004082 RID: 16514 RVA: 0x0015377C File Offset: 0x0015197C
		[Token(Token = "0x6004082")]
		[Address(RVA = "0x863710", Offset = "0x861D10", VA = "0x180863710", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			return null;
		}

		// Token: 0x06004083 RID: 16515 RVA: 0x0015378C File Offset: 0x0015198C
		[Token(Token = "0x6004083")]
		[Address(RVA = "0x863750", Offset = "0x861D50", VA = "0x180863750", Slot = "5")]
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

		// Token: 0x06004084 RID: 16516 RVA: 0x001537C4 File Offset: 0x001519C4
		[Token(Token = "0x6004084")]
		[Address(RVA = "0xA9DA90", Offset = "0xA9C090", VA = "0x180A9DA90", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06004085 RID: 16517 RVA: 0x0015381C File Offset: 0x00151A1C
		[Token(Token = "0x6004085")]
		[Address(RVA = "0x863840", Offset = "0x861E40", VA = "0x180863840", Slot = "10")]
		public override int ShowEditorUI(RuntimeNodeUI ui)
		{
			TheButton buttonPrefab = ui.buttonPrefab;
			RectTransform valueEditContainer = ui.valueEditContainer;
			TheButton theButton = global::UnityEngine.Object.Instantiate<TheButton>(buttonPrefab, valueEditContainer);
			TheButton button = theButton;
			TextMeshProUGUI componentInChildren = button.GetComponentInChildren<TextMeshProUGUI>();
			int size = this.plantTypes._size;
			string text = string.Format("{0}种类型", componentInChildren);
			componentInChildren.text = text;
			UnityEvent theEvent_up = button.theEvent_up;
			UnityAction unityAction = delegate
			{
				ulong num2;
				do
				{
					UIResourcesLoader uimanager = GameAPP.UIManager;
					int num = 0;
					Transform canvasUp = GameAPP.canvasUp;
					List<AlmanacCardUI> childs = global::Core.Lawnf.GetChilds<AlmanacCardUI>(uimanager.Push((UIType)((uint)56), canvasUp, num != 0).transform);
					bool flag;
					if (flag)
					{
						List<PlantType> list = this.plantTypes;
						bool flag2;
						while (!flag2)
						{
						}
						GameObject gameObject;
						if (!gameObject.activeInHierarchy)
						{
							continue;
						}
					}
				}
				while (num2 != (ulong)0L);
				InGameText instance = InGameText.Instance;
			};
			theEvent_up.AddListener(unityAction);
			return 1;
		}

		// Token: 0x06004086 RID: 16518 RVA: 0x001538B0 File Offset: 0x00151AB0
		[Token(Token = "0x6004086")]
		[Address(RVA = "0x863A30", Offset = "0x862030", VA = "0x180863A30")]
		public MultiPlantTypeListNode()
		{
			List<PlantType> list = new List();
			this.plantTypes = list;
			base..ctor();
		}

		// Token: 0x04003191 RID: 12689
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4003191")]
		public string plantTypeList_PortName = "植物类型列表";

		// Token: 0x04003192 RID: 12690
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4003192")]
		public List<PlantType> plantTypes;
	}
}
