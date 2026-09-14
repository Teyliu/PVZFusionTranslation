using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x020007C5 RID: 1989
[Token(Token = "0x20007C5")]
public class AdvantureMenu2 : BaseMenu
{
	// Token: 0x0600283C RID: 10300 RVA: 0x000DAA98 File Offset: 0x000D8C98
	[Token(Token = "0x600283C")]
	[Address(RVA = "0x61CE80", Offset = "0x61B480", VA = "0x18061CE80", Slot = "6")]
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

	// Token: 0x0600283D RID: 10301 RVA: 0x000DAB18 File Offset: 0x000D8D18
	[Token(Token = "0x600283D")]
	[Address(RVA = "0x61CC40", Offset = "0x61B240", VA = "0x18061CC40")]
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

	// Token: 0x0600283E RID: 10302 RVA: 0x000DABC0 File Offset: 0x000D8DC0
	[Token(Token = "0x600283E")]
	[Address(RVA = "0x603FF0", Offset = "0x6025F0", VA = "0x180603FF0")]
	public AdvantureMenu2()
	{
	}

	// Token: 0x04001699 RID: 5785
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001699")]
	public TextMeshProUGUI difficulty;
}
