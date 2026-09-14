using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B64 RID: 2916
	[Token(Token = "0x2000B64")]
	[Serializable]
	public class GetTravelBuffNode : EventNodeBase
	{
		// Token: 0x06003CC7 RID: 15559 RVA: 0x0013FB84 File Offset: 0x0013DD84
		[Token(Token = "0x6003CC7")]
		[Address(RVA = "0x7C9550", Offset = "0x7C7B50", VA = "0x1807C9550", Slot = "4")]
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

		// Token: 0x06003CC8 RID: 15560 RVA: 0x0013FBC0 File Offset: 0x0013DDC0
		[Token(Token = "0x6003CC8")]
		[Address(RVA = "0x7C9630", Offset = "0x7C7C30", VA = "0x1807C9630", Slot = "5")]
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

		// Token: 0x06003CC9 RID: 15561 RVA: 0x0013FBF8 File Offset: 0x0013DDF8
		[Token(Token = "0x6003CC9")]
		[Address(RVA = "0x7C91C0", Offset = "0x7C77C0", VA = "0x1807C91C0", Slot = "6")]
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
				if (obj != 0)
				{
					TravelMgr instance = TravelMgr.Instance;
					InGameText instance2 = InGameText.Instance;
					TravelMgr instance3 = TravelMgr.Instance;
					string text = instance3.GetText(instance3);
					string text2 = "获得词条：" + text;
					throw new InvalidCastException();
				}
				if (obj == 0)
				{
					if (obj == 0)
					{
						return;
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
				int num = 0;
				instance8.ShowText(text6, 5f, num != 0);
				string text7 = this.onSuccess_PortName;
				base.TriggerConnectedNodes(text7);
			}
		}

		// Token: 0x06003CCA RID: 15562 RVA: 0x0013FD28 File Offset: 0x0013DF28
		[Token(Token = "0x6003CCA")]
		[Address(RVA = "0x7C9720", Offset = "0x7C7D20", VA = "0x1807C9720", Slot = "10")]
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

		// Token: 0x06003CCB RID: 15563 RVA: 0x0013FDF8 File Offset: 0x0013DFF8
		[Token(Token = "0x6003CCB")]
		[Address(RVA = "0x7C99B0", Offset = "0x7C7FB0", VA = "0x1807C99B0")]
		public GetTravelBuffNode()
		{
		}

		// Token: 0x04002D04 RID: 11524
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002D04")]
		[SerializeReference]
		public object buff;

		// Token: 0x04002D05 RID: 11525
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002D05")]
		public string trigger_PortName = "触发";

		// Token: 0x04002D06 RID: 11526
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002D06")]
		public string onSuccess_PortName = "成功";
	}
}
