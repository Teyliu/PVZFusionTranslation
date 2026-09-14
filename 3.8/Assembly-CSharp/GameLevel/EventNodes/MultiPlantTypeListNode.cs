using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BDE RID: 3038
	[Token(Token = "0x2000BDE")]
	[Serializable]
	public class MultiPlantTypeListNode : EventNodeBase
	{
		// Token: 0x06003F31 RID: 16177 RVA: 0x0014E524 File Offset: 0x0014C724
		[Token(Token = "0x6003F31")]
		[Address(RVA = "0x7FBD60", Offset = "0x7FA360", VA = "0x1807FBD60", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			return null;
		}

		// Token: 0x06003F32 RID: 16178 RVA: 0x0014E534 File Offset: 0x0014C734
		[Token(Token = "0x6003F32")]
		[Address(RVA = "0x7FBDA0", Offset = "0x7FA3A0", VA = "0x1807FBDA0", Slot = "5")]
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

		// Token: 0x06003F33 RID: 16179 RVA: 0x0014E56C File Offset: 0x0014C76C
		[Token(Token = "0x6003F33")]
		[Address(RVA = "0x9EC250", Offset = "0x9EA850", VA = "0x1809EC250", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003F34 RID: 16180 RVA: 0x0014E5C4 File Offset: 0x0014C7C4
		[Token(Token = "0x6003F34")]
		[Address(RVA = "0x7FBE90", Offset = "0x7FA490", VA = "0x1807FBE90", Slot = "10")]
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
					}
				}
				while (num2 != (ulong)0L);
				InGameText instance = InGameText.Instance;
				int num3 = 0;
				instance.ShowText("对于基础植物，可以使用鼠标中键点击植物\n让他不要跳转到融合界面", 7f, num3 != 0);
			};
			theEvent_up.AddListener(unityAction);
			return 1;
		}

		// Token: 0x06003F35 RID: 16181 RVA: 0x0014E658 File Offset: 0x0014C858
		[Token(Token = "0x6003F35")]
		[Address(RVA = "0x7FC080", Offset = "0x7FA680", VA = "0x1807FC080")]
		public MultiPlantTypeListNode()
		{
			List<PlantType> list = new List();
			this.plantTypes = list;
			base..ctor();
		}

		// Token: 0x0400301E RID: 12318
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400301E")]
		public string plantTypeList_PortName = "植物类型列表";

		// Token: 0x0400301F RID: 12319
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400301F")]
		public List<PlantType> plantTypes;
	}
}
