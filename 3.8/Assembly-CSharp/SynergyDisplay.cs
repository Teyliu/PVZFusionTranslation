using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000856 RID: 2134
[Token(Token = "0x2000856")]
public class SynergyDisplay : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	// Token: 0x06002BA2 RID: 11170 RVA: 0x000EF7C0 File Offset: 0x000ED9C0
	[Token(Token = "0x6002BA2")]
	[Address(RVA = "0x67A220", Offset = "0x678820", VA = "0x18067A220")]
	private void Start()
	{
		List<SynergyType> activeSynergies = SynergyManager.Instance.GetActiveSynergies(true);
		GameObject gameObject = base.gameObject;
		int num = 0;
		gameObject.SetActive(num != 0);
	}

	// Token: 0x06002BA3 RID: 11171 RVA: 0x000EF82C File Offset: 0x000EDA2C
	[Token(Token = "0x6002BA3")]
	[Address(RVA = "0x67A340", Offset = "0x678940", VA = "0x18067A340")]
	public void UpdateText()
	{
		TextMeshProUGUI textMeshProUGUI = this.text;
		string text = SynergyDisplay.GetText("#F8FFA7");
		textMeshProUGUI.text = text;
		TextMeshProUGUI textMeshProUGUI2 = this.text;
		RectTransform rectTransform = this.content;
		float preferredHeight = textMeshProUGUI2.preferredHeight;
	}

	// Token: 0x06002BA4 RID: 11172 RVA: 0x000EF870 File Offset: 0x000EDA70
	[Token(Token = "0x6002BA4")]
	[Address(RVA = "0x679930", Offset = "0x677F30", VA = "0x180679930")]
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

	// Token: 0x06002BA5 RID: 11173 RVA: 0x000EFA88 File Offset: 0x000EDC88
	[Token(Token = "0x6002BA5")]
	[Address(RVA = "0x67A110", Offset = "0x678710", VA = "0x18067A110", Slot = "4")]
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

	// Token: 0x06002BA6 RID: 11174 RVA: 0x000EFAFC File Offset: 0x000EDCFC
	[Token(Token = "0x6002BA6")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public SynergyDisplay()
	{
	}

	// Token: 0x040019D1 RID: 6609
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40019D1")]
	public RectTransform content;

	// Token: 0x040019D2 RID: 6610
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40019D2")]
	public TextMeshProUGUI text;

	// Token: 0x040019D3 RID: 6611
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40019D3")]
	public bool hide;

	// Token: 0x040019D4 RID: 6612
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40019D4")]
	public GameObject rightButton;

	// Token: 0x040019D5 RID: 6613
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40019D5")]
	public GameObject leftButton;
}
