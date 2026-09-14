using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000892 RID: 2194
[Token(Token = "0x2000892")]
public class SynergyDisplay : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	// Token: 0x06002CD4 RID: 11476 RVA: 0x000F4418 File Offset: 0x000F2618
	[Token(Token = "0x6002CD4")]
	[Address(RVA = "0x6DEF60", Offset = "0x6DD560", VA = "0x1806DEF60")]
	private void Start()
	{
		List<SynergyType> activeSynergies = SynergyManager.Instance.GetActiveSynergies(true);
		GameObject gameObject = base.gameObject;
		int num = 0;
		gameObject.SetActive(num != 0);
	}

	// Token: 0x06002CD5 RID: 11477 RVA: 0x000F4484 File Offset: 0x000F2684
	[Token(Token = "0x6002CD5")]
	[Address(RVA = "0x6DF080", Offset = "0x6DD680", VA = "0x1806DF080")]
	public void UpdateText()
	{
		TextMeshProUGUI textMeshProUGUI = this.text;
		string text = SynergyDisplay.GetText("#F8FFA7");
		textMeshProUGUI.text = text;
		TextMeshProUGUI textMeshProUGUI2 = this.text;
		RectTransform rectTransform = this.content;
		float preferredHeight = textMeshProUGUI2.preferredHeight;
	}

	// Token: 0x06002CD6 RID: 11478 RVA: 0x000F44C8 File Offset: 0x000F26C8
	[Token(Token = "0x6002CD6")]
	[Address(RVA = "0x6DE670", Offset = "0x6DCC70", VA = "0x1806DE670")]
	public static string GetText(string color = "black")
	{
		string text11;
		ulong num7;
		do
		{
			int num = 0;
			SynergyManager instance = SynergyManager.Instance;
			int num2 = 0;
			List<SynergyType> activeSynergies = instance.GetActiveSynergies(num2 != 0);
			SynergyDisplay.<>c__DisplayClass7_0 CS$<>8__locals1;
			CS$<>8__locals1.currentActive = activeSynergies;
			List<SynergyType> allSynergyTypes = SynergyManager.Instance.GetAllSynergyTypes();
			Func<SynergyType, bool> func = delegate(SynergyType a)
			{
				List<SynergyType> currentActive = CS$<>8__locals1.currentActive;
				bool flag2;
				return flag2;
			};
			IOrderedEnumerable<SynergyType> orderedEnumerable = Enumerable.OrderByDescending<SynergyType, bool>(allSynergyTypes, func);
			Func<SynergyType, int> <>9__7_ = SynergyDisplay.<>c.<>9__7_1;
			if (<>9__7_ == 0)
			{
				Func<SynergyType, int> func2;
				SynergyDisplay.<>c.<>9__7_1 = func2;
			}
			List<SynergyType> list = Enumerable.ToList<SynergyType>(Enumerable.ThenByDescending<SynergyType, int>(orderedEnumerable, <>9__7_));
			bool flag;
			if (flag)
			{
				int i = SynergyManager.Instance.GetPlantsBySynergy((SynergyType)num)._size;
				while (i == 0)
				{
				}
				int maxCount = TravelMgr.SynergysData[num].GetMaxCount();
				SynergyLevelData data = TravelMgr.SynergysData[num].GetData();
				string text2;
				string text = "" + text2 + "\n";
				string text8;
				string text9;
				if (data != 0)
				{
					List<SynergyLevelData> allData = TravelMgr.SynergysData[num].GetAllData();
					int num3 = 0;
					int num4 = 0;
					SynergyLevelData synergyLevelData = allData[num3];
					string text4;
					if (num3 == 0)
					{
						int <ActiveCount>k__BackingField = allData[num3].<ActiveCount>k__BackingField;
						string text3 = string.Format("{0}", <ActiveCount>k__BackingField);
						string text5;
						text4 = text5 + text3;
						int size = allData._size;
						if (num3 != size)
						{
							string text6 = text4 + "/";
						}
						num3++;
					}
					while (num4 != 0)
					{
					}
					SynergyLevelData synergyLevelData2 = allData[num3];
					while (i >= synergyLevelData2.<ActiveCount>k__BackingField)
					{
					}
					string text7 = text4 + "</color>";
					uint num5;
					if (num5 == (uint)0)
					{
						text8 = text7 + "</color>";
					}
					text9 = text8 + "\n\n";
				}
				int num6;
				string text10 = string.Format("{0}/{1}\n\n", text9, num6);
				text11 = text8 + text10;
			}
		}
		while (num7 != (ulong)0L);
		return text11;
	}

	// Token: 0x06002CD7 RID: 11479 RVA: 0x000F46E0 File Offset: 0x000F28E0
	[Token(Token = "0x6002CD7")]
	[Address(RVA = "0x6DEE50", Offset = "0x6DD450", VA = "0x1806DEE50", Slot = "4")]
	public void OnPointerClick(PointerEventData eventData)
	{
		bool flag = this.hide;
		GameObject gameObject = this.rightButton;
		bool flag2 = !flag;
		this.hide = flag2;
		if (flag)
		{
			int num = 0;
			gameObject.SetActive(num != 0);
			this.leftButton.SetActive(true);
			Transform transform = base.transform;
		}
		gameObject.SetActive(true);
		GameObject gameObject2 = this.leftButton;
		int num2 = 0;
		gameObject2.SetActive(num2 != 0);
		Transform transform2 = base.transform;
	}

	// Token: 0x06002CD8 RID: 11480 RVA: 0x000F4754 File Offset: 0x000F2954
	[Token(Token = "0x6002CD8")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public SynergyDisplay()
	{
	}

	// Token: 0x04001ABF RID: 6847
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001ABF")]
	public RectTransform content;

	// Token: 0x04001AC0 RID: 6848
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001AC0")]
	public TextMeshProUGUI text;

	// Token: 0x04001AC1 RID: 6849
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001AC1")]
	public bool hide;

	// Token: 0x04001AC2 RID: 6850
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001AC2")]
	public GameObject rightButton;

	// Token: 0x04001AC3 RID: 6851
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001AC3")]
	public GameObject leftButton;
}
