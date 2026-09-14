using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B89 RID: 2953
	[Token(Token = "0x2000B89")]
	[Serializable]
	public class GetTravelEntryNode : EventNodeBase
	{
		// Token: 0x06003D84 RID: 15748 RVA: 0x00144F78 File Offset: 0x00143178
		[Token(Token = "0x6003D84")]
		[Address(RVA = "0x7F6E10", Offset = "0x7F5410", VA = "0x1807F6E10", Slot = "4")]
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

		// Token: 0x06003D85 RID: 15749 RVA: 0x00144FB4 File Offset: 0x001431B4
		[Token(Token = "0x6003D85")]
		[Address(RVA = "0x7F6EF0", Offset = "0x7F54F0", VA = "0x1807F6EF0", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			return null;
		}

		// Token: 0x06003D86 RID: 15750 RVA: 0x00144FC4 File Offset: 0x001431C4
		[Token(Token = "0x6003D86")]
		[Address(RVA = "0x7F6B90", Offset = "0x7F5190", VA = "0x1807F6B90", Slot = "6")]
		public override void Execute()
		{
			if (this.buffType == BuffType.AdvancedBuff)
			{
				TravelMgr instance = TravelMgr.Instance;
				InGameText instance2 = InGameText.Instance;
				TravelMgr instance3 = TravelMgr.Instance;
				int num = this.entryIndex;
				string text = instance3.GetText(instance3);
				string text2 = "获得词条：" + text;
				TravelMgr instance4 = TravelMgr.Instance;
				InGameText instance5 = InGameText.Instance;
				TravelMgr instance6 = TravelMgr.Instance;
				int num2 = this.entryIndex;
				string text3 = instance6.GetText(instance6);
				string text4 = "获得词条：" + text3;
				TravelMgr instance7 = TravelMgr.Instance;
				InGameText instance8 = InGameText.Instance;
				TravelMgr instance9 = TravelMgr.Instance;
				int num3 = this.entryIndex;
				string text5 = instance9.GetText(instance9);
				string text6 = "获得词条：" + text5;
				int num4 = 0;
				instance8.ShowText(text6, 5f, num4 != 0);
			}
		}

		// Token: 0x06003D87 RID: 15751 RVA: 0x001450B0 File Offset: 0x001432B0
		[Token(Token = "0x6003D87")]
		[Address(RVA = "0x7F6F30", Offset = "0x7F5530", VA = "0x1807F6F30", Slot = "10")]
		public override int ShowEditorUI(RuntimeNodeUI ui)
		{
			int num = 0;
			RectTransform valueEditContainer = ui.valueEditContainer;
			GameObject dropdownPrefab = ui.dropdownPrefab;
			int num2 = 0;
			if (!(dropdownPrefab != num2))
			{
				return 0;
			}
			if (global::UnityEngine.Object.Instantiate<GameObject>(ui.dropdownPrefab, valueEditContainer).TryGetComponent<TMP_Dropdown>(num))
			{
				List<TMP_Dropdown.OptionData> list;
				int size = list._size;
				list._size = num;
				if (size > 0)
				{
				}
				TMP_Dropdown.OptionData optionData = new TMP_Dropdown.OptionData("基础词条");
				TMP_Dropdown.OptionData optionData2 = new TMP_Dropdown.OptionData("强究词条");
				TMP_Dropdown.OptionData optionData3 = new TMP_Dropdown.OptionData("僵尸词条");
			}
			if (global::UnityEngine.Object.Instantiate<GameObject>(ui.inputFieldPrefab, valueEditContainer).TryGetComponent<TMP_InputField>(num))
			{
			}
			throw new NullReferenceException();
		}

		// Token: 0x06003D88 RID: 15752 RVA: 0x0014514C File Offset: 0x0014334C
		[Token(Token = "0x6003D88")]
		[Address(RVA = "0x7F7470", Offset = "0x7F5A70", VA = "0x1807F7470")]
		public GetTravelEntryNode()
		{
		}

		// Token: 0x04002E39 RID: 11833
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002E39")]
		public BuffType buffType = (BuffType)((ulong)1L);

		// Token: 0x04002E3A RID: 11834
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4002E3A")]
		public int entryIndex;

		// Token: 0x04002E3B RID: 11835
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002E3B")]
		public string trigger_PortName = "触发";
	}
}
