using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x02000813 RID: 2067
[Token(Token = "0x2000813")]
public class AdvantureHelpMenu : BaseMenu
{
	// Token: 0x06002A22 RID: 10786 RVA: 0x000E3D1C File Offset: 0x000E1F1C
	[Token(Token = "0x6002A22")]
	[Address(RVA = "0x67FD20", Offset = "0x67E320", VA = "0x18067FD20", Slot = "6")]
	protected override void Awake()
	{
		base.GetCol();
		Animator component = base.GetComponent<Animator>();
		this.anim = component;
		this.InitText();
	}

	// Token: 0x06002A23 RID: 10787 RVA: 0x000E3D44 File Offset: 0x000E1F44
	[Token(Token = "0x6002A23")]
	[Address(RVA = "0x67FD90", Offset = "0x67E390", VA = "0x18067FD90")]
	private void InitText()
	{
		int count;
		int num;
		TextMeshProUGUI component2;
		int num3;
		do
		{
			TextMeshProUGUI textMeshProUGUI = this.sampleText;
			Transform parent = textMeshProUGUI.transform.parent;
			TextMeshProUGUI component = global::UnityEngine.Object.Instantiate<TextMeshProUGUI>(textMeshProUGUI, parent).GetComponent<TextMeshProUGUI>();
			component.text = "高阶僵尸有更高的基础属性加成\n每提升一阶（从2阶起），血量与攻击力均增加<color=red>100%</color>\n各难度下不同阶数僵尸的出现概率如下\n";
			string text = component.text + "——————————————————————————————";
			component.text = text;
			count = ZombieLevelDictionary.ZombieLevelConfigs.Count;
			num = 0;
			TextMeshProUGUI textMeshProUGUI2 = this.sampleText;
			if (num >= count)
			{
				goto IL_016C;
			}
			Transform parent2 = this.sampleText.transform.parent;
			component2 = global::UnityEngine.Object.Instantiate<TextMeshProUGUI>(textMeshProUGUI2, parent2).GetComponent<TextMeshProUGUI>();
			int num2;
			string text2 = string.Format("难度{0}：\n", num2);
			component2.text = text2;
			num3 = 0;
			Dictionary<int, int> zombieLevelProbabilitySmart = ZombieLevelDictionary.GetZombieLevelProbabilitySmart(num);
			bool flag;
			if (flag)
			{
				string text3 = component2.text;
				string text4 = string.Format("{0}阶：<color=red>{1}%</color> ", text3, text3);
				string text5 = text3 + text4;
				component2.text = text5;
				num3++;
				while (num3 != 6)
				{
				}
				string text6 = component2.text + "\n";
				component2.text = text6;
			}
		}
		while (num3 != 0);
		if (num3 < 6)
		{
			string text7 = component2.text + "\n";
			component2.text = text7;
		}
		string text8 = component2.text + "\n";
		component2.text = text8;
		string text9 = component2.text + "——————————————————————————————";
		component2.text = text9;
		num++;
		IL_016C:
		GameObject gameObject;
		global::UnityEngine.Object.Destroy(gameObject);
		int num4 = count + 1;
	}

	// Token: 0x06002A24 RID: 10788 RVA: 0x000E3ED4 File Offset: 0x000E20D4
	[Token(Token = "0x6002A24")]
	[Address(RVA = "0x667800", Offset = "0x665E00", VA = "0x180667800")]
	public AdvantureHelpMenu()
	{
	}

	// Token: 0x04001815 RID: 6165
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001815")]
	public TextMeshProUGUI sampleText;

	// Token: 0x04001816 RID: 6166
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001816")]
	public RectTransform contant;
}
