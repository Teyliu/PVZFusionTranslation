using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BA6 RID: 2982
	[Token(Token = "0x2000BA6")]
	[Serializable]
	public class GetTravelBuffNode : EventNodeBase
	{
		// Token: 0x06003E18 RID: 15896 RVA: 0x00144E28 File Offset: 0x00143028
		[Token(Token = "0x6003E18")]
		[Address(RVA = "0x8458B0", Offset = "0x843EB0", VA = "0x1808458B0", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			int num;
			int num2;
			PortDefinition portDefinition = new PortDefinition(this.trigger_PortName, (PortType)num, (PortDirection)num2);
			num2 = 0;
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003E19 RID: 15897 RVA: 0x00144E64 File Offset: 0x00143064
		[Token(Token = "0x6003E19")]
		[Address(RVA = "0x845990", Offset = "0x843F90", VA = "0x180845990", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.onSuccess_PortName, (PortType)num, (PortDirection)((uint)1));
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003E1A RID: 15898 RVA: 0x00144E9C File Offset: 0x0014309C
		[Token(Token = "0x6003E1A")]
		[Address(RVA = "0x845520", Offset = "0x843B20", VA = "0x180845520", Slot = "6")]
		public override void Execute()
		{
			if (this.buff == (ulong)0L)
			{
				string nodeId = this.nodeId;
				EventNodeDebug.LogWarning("[GetTravelBuffNode] 词条未设置，节点ID:" + nodeId);
			}
			object obj = this.buff;
			if (obj != 0)
			{
				if (obj == 0)
				{
					if (obj == 0)
					{
						if (obj == 0)
						{
							return;
						}
						TravelMgr instance = TravelMgr.Instance;
						InGameText instance2 = InGameText.Instance;
						TravelMgr instance3 = TravelMgr.Instance;
						string text = instance3.GetText(instance3);
						string text2 = "获得词条：" + text;
					}
					TravelMgr instance4 = TravelMgr.Instance;
					InGameText instance5 = InGameText.Instance;
					TravelMgr instance6 = TravelMgr.Instance;
					string text3 = instance6.GetText(instance6);
					string text4 = "获得词条：" + text3;
				}
				TravelMgr instance7 = TravelMgr.Instance;
				InGameText instance8 = InGameText.Instance;
				TravelMgr instance9 = TravelMgr.Instance;
				string text5 = instance9.GetText(instance9);
				string text6 = "获得词条：" + text5;
				string text7 = this.onSuccess_PortName;
				base.TriggerConnectedNodes(text7);
			}
		}

		// Token: 0x06003E1B RID: 15899 RVA: 0x00144FB8 File Offset: 0x001431B8
		[Token(Token = "0x6003E1B")]
		[Address(RVA = "0x845A80", Offset = "0x844080", VA = "0x180845A80", Slot = "10")]
		public override int ShowEditorUI(RuntimeNodeUI ui)
		{
			GetTravelBuffNode.<>c__DisplayClass6_0 CS$<>8__locals1 = new GetTravelBuffNode.<>c__DisplayClass6_0();
			CS$<>8__locals1.<>4__this = this;
			RectTransform valueEditContainer = ui.valueEditContainer;
			GameObject dropdownPrefab = ui.dropdownPrefab;
			int num = 0;
			if (!(dropdownPrefab != num))
			{
				return 0;
			}
			TheButton theButton = global::UnityEngine.Object.Instantiate<TheButton>(ui.buttonPrefab, valueEditContainer);
			CS$<>8__locals1.button = theButton;
			if (this.buff != (ulong)0L)
			{
				TravelMgr instance = TravelMgr.Instance;
				object obj = this.buff;
				string text = instance.GetText(obj);
				TextMeshProUGUI componentInChildren = CS$<>8__locals1.button.GetComponentInChildren<TextMeshProUGUI>();
				string text2 = text.Before("：");
			}
			CS$<>8__locals1.button.GetComponentInChildren<TextMeshProUGUI>().text = "未设置";
			UnityEvent theEvent_up = CS$<>8__locals1.button.theEvent_up;
			UnityAction unityAction = delegate
			{
				int num4;
				do
				{
					GetTravelBuffNode.<>c__DisplayClass6_1 CS$<>8__locals2;
					CS$<>8__locals2.CS$<>8__locals1 = CS$<>8__locals1;
					UIResourcesLoader uimanager = GameAPP.UIManager;
					int num2 = 0;
					BaseMenu baseMenu = uimanager.Push((UIType)((uint)82), num2 != 0);
					if (baseMenu == 0)
					{
						int num3 = 0;
						CS$<>8__locals2.menu = num3;
					}
					num4 = 0;
					CS$<>8__locals2.menu = baseMenu;
					List<AlmanacCardUI> cards = CS$<>8__locals2.menu.cards;
					bool flag;
					if (flag)
					{
						if (CS$<>8__locals2.<>9__1 == 0)
						{
							Action<AlmanacCardUI> action;
							CS$<>8__locals2.<>9__1 = action;
						}
						Delegate @delegate;
						if (@delegate == 0)
						{
						}
						if (num4 == 0)
						{
							goto IL_007A;
						}
						if (num4 == 0)
						{
							goto IL_0074;
						}
					}
				}
				while (num4 != 0);
				return;
				IL_0074:
				throw new InvalidCastException();
				IL_007A:
				throw new InvalidCastException();
			};
			theEvent_up.AddListener(unityAction);
			throw new NullReferenceException();
		}

		// Token: 0x06003E1C RID: 15900 RVA: 0x00145088 File Offset: 0x00143288
		[Token(Token = "0x6003E1C")]
		[Address(RVA = "0x845D10", Offset = "0x844310", VA = "0x180845D10")]
		public GetTravelBuffNode()
		{
		}

		// Token: 0x04002E78 RID: 11896
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002E78")]
		[SerializeReference]
		public object buff;

		// Token: 0x04002E79 RID: 11897
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002E79")]
		public string trigger_PortName = "触发";

		// Token: 0x04002E7A RID: 11898
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002E7A")]
		public string onSuccess_PortName = "成功";
	}
}
