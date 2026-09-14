using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x020007FE RID: 2046
[Token(Token = "0x20007FE")]
public class AdvantureMenu2 : BaseMenu
{
	// Token: 0x0600296B RID: 10603 RVA: 0x000DFA54 File Offset: 0x000DDC54
	[Token(Token = "0x600296B")]
	[Address(RVA = "0x680740", Offset = "0x67ED40", VA = "0x180680740", Slot = "6")]
	protected override void Awake()
	{
		base.GetCol();
		Animator component = base.GetComponent<Animator>();
		this.anim = component;
		TextMeshProUGUI textMeshProUGUI = this.difficulty;
		int gameDifficulty = AdvantureConfig.data.gameDifficulty;
		string text = string.Format("难度阶数：{0}", gameDifficulty);
		textMeshProUGUI.text = text;
		if (AdvantureConfig.data.hardMode)
		{
			TextMeshProUGUI textMeshProUGUI2 = this.difficulty;
			string text2 = textMeshProUGUI2.text + "+2";
			textMeshProUGUI2.text = text2;
		}
	}

	// Token: 0x0600296C RID: 10604 RVA: 0x000DFAD4 File Offset: 0x000DDCD4
	[Token(Token = "0x600296C")]
	[Address(RVA = "0x680500", Offset = "0x67EB00", VA = "0x180680500")]
	public void AdjustDifficulty(int value)
	{
		AdvantureData data = AdvantureConfig.data;
		if (AdvantureConfig.data.gameDifficulty < 0)
		{
			AdvantureConfig.data.gameDifficulty = (int)((ulong)0L);
		}
		if (AdvantureConfig.data.gameDifficulty > 10)
		{
			AdvantureConfig.data.gameDifficulty = (int)((ulong)10L);
		}
		TextMeshProUGUI textMeshProUGUI = this.difficulty;
		int gameDifficulty = AdvantureConfig.data.gameDifficulty;
		string text = string.Format("难度阶数：{0}", gameDifficulty);
		textMeshProUGUI.text = text;
		if (AdvantureConfig.data.hardMode)
		{
			TextMeshProUGUI textMeshProUGUI2 = this.difficulty;
			string text2 = textMeshProUGUI2.text + "+2";
			textMeshProUGUI2.text = text2;
		}
	}

	// Token: 0x0600296D RID: 10605 RVA: 0x000DFB7C File Offset: 0x000DDD7C
	[Token(Token = "0x600296D")]
	[Address(RVA = "0x667800", Offset = "0x665E00", VA = "0x180667800")]
	public AdvantureMenu2()
	{
	}

	// Token: 0x04001775 RID: 6005
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001775")]
	public TextMeshProUGUI difficulty;
}
