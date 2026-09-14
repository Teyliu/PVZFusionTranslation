using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BCB RID: 3019
	[Token(Token = "0x2000BCB")]
	[Serializable]
	public class GetTravelEntryNode : EventNodeBase
	{
		// Token: 0x06003ED5 RID: 16085 RVA: 0x0014A20C File Offset: 0x0014840C
		[Token(Token = "0x6003ED5")]
		[Address(RVA = "0x85E9D0", Offset = "0x85CFD0", VA = "0x18085E9D0", Slot = "4")]
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

		// Token: 0x06003ED6 RID: 16086 RVA: 0x0014A24C File Offset: 0x0014844C
		[Token(Token = "0x6003ED6")]
		[Address(RVA = "0x85EAB0", Offset = "0x85D0B0", VA = "0x18085EAB0", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			return null;
		}

		// Token: 0x06003ED7 RID: 16087 RVA: 0x0014A25C File Offset: 0x0014845C
		[Token(Token = "0x6003ED7")]
		[Address(RVA = "0x85E740", Offset = "0x85CD40", VA = "0x18085E740", Slot = "6")]
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
			}
		}

		// Token: 0x06003ED8 RID: 16088 RVA: 0x0014A338 File Offset: 0x00148538
		[Token(Token = "0x6003ED8")]
		[Address(RVA = "0x85EAF0", Offset = "0x85D0F0", VA = "0x18085EAF0", Slot = "10")]
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

		// Token: 0x06003ED9 RID: 16089 RVA: 0x0014A3D4 File Offset: 0x001485D4
		[Token(Token = "0x6003ED9")]
		[Address(RVA = "0x85F040", Offset = "0x85D640", VA = "0x18085F040")]
		public GetTravelEntryNode()
		{
		}

		// Token: 0x04002FAD RID: 12205
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002FAD")]
		public BuffType buffType = (BuffType)((ulong)1L);

		// Token: 0x04002FAE RID: 12206
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4002FAE")]
		public int entryIndex;

		// Token: 0x04002FAF RID: 12207
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002FAF")]
		public string trigger_PortName = "触发";
	}
}
