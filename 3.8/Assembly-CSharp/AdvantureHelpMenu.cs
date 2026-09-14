using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x020007DA RID: 2010
[Token(Token = "0x20007DA")]
public class AdvantureHelpMenu : BaseMenu
{
	// Token: 0x060028F3 RID: 10483 RVA: 0x000DED54 File Offset: 0x000DCF54
	[Token(Token = "0x60028F3")]
	[Address(RVA = "0x61C460", Offset = "0x61AA60", VA = "0x18061C460", Slot = "6")]
	protected override void Awake()
	{
		base.GetCol();
		Animator component = base.GetComponent<Animator>();
		this.anim = component;
		this.InitText();
	}

	// Token: 0x060028F4 RID: 10484 RVA: 0x000DED7C File Offset: 0x000DCF7C
	[Token(Token = "0x60028F4")]
	[Address(RVA = "0x61C4D0", Offset = "0x61AAD0", VA = "0x18061C4D0")]
	private void InitText()
	{
		int count;
		int num;
		TextMeshProUGUI textMeshProUGUI2;
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
			textMeshProUGUI2 = this.sampleText;
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
		global::UnityEngine.Object.Destroy(textMeshProUGUI2.gameObject);
		RectTransform rectTransform = this.contant;
		int num4 = count + 1;
	}

	// Token: 0x060028F5 RID: 10485 RVA: 0x000DEF18 File Offset: 0x000DD118
	[Token(Token = "0x60028F5")]
	[Address(RVA = "0x603FF0", Offset = "0x6025F0", VA = "0x180603FF0")]
	public AdvantureHelpMenu()
	{
	}

	// Token: 0x04001739 RID: 5945
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001739")]
	public TextMeshProUGUI sampleText;

	// Token: 0x0400173A RID: 5946
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400173A")]
	public RectTransform contant;
}
