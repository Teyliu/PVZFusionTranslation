using System;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x02000638 RID: 1592
[Token(Token = "0x2000638")]
public class TravelRefresh : UIButton
{
	// Token: 0x06001E15 RID: 7701 RVA: 0x000A0430 File Offset: 0x0009E630
	[Token(Token = "0x6001E15")]
	[Address(RVA = "0x584000", Offset = "0x582600", VA = "0x180584000")]
	private void Awake()
	{
		bool flag;
		if (flag)
		{
		}
		int num = 0;
		if (TravelMgr.Instance.data.travelProcess == TravelProcess.Fast)
		{
			this.refreshTimes = num;
		}
		Board instance = Board.Instance;
		if (RogueManager.Instance.campType == CampType.Water)
		{
		}
		this.UpdateText();
	}

	// Token: 0x06001E16 RID: 7702 RVA: 0x000A0480 File Offset: 0x0009E680
	[Token(Token = "0x6001E16")]
	[Address(RVA = "0x5842E0", Offset = "0x5828E0", VA = "0x1805842E0")]
	public void SetRefrashTimes(int value)
	{
		this.refreshTimes = value;
		this.UpdateText();
	}

	// Token: 0x06001E17 RID: 7703 RVA: 0x000A049C File Offset: 0x0009E69C
	[Token(Token = "0x6001E17")]
	[Address(RVA = "0x5840D0", Offset = "0x5826D0", VA = "0x1805840D0")]
	public void ModifyRefrashTimes(int value)
	{
		this.UpdateText();
	}

	// Token: 0x06001E18 RID: 7704 RVA: 0x000A04B0 File Offset: 0x0009E6B0
	[Token(Token = "0x6001E18")]
	[Address(RVA = "0x5842F0", Offset = "0x5828F0", VA = "0x1805842F0")]
	private void UpdateText()
	{
		int num = this.refreshTimes;
		TextMeshProUGUI textMeshProUGUI = this.text;
		string text = string.Format("刷新({0})", num);
		textMeshProUGUI.text = text;
		TextMeshProUGUI textMeshProUGUI2 = this.text;
		TextMeshProUGUI textMeshProUGUI3 = this.text_shadow;
		string text2 = textMeshProUGUI2.text;
		textMeshProUGUI3.text = text2;
	}

	// Token: 0x06001E19 RID: 7705 RVA: 0x000A0504 File Offset: 0x0009E704
	[Token(Token = "0x6001E19")]
	[Address(RVA = "0x5840E0", Offset = "0x5826E0", VA = "0x1805840E0", Slot = "9")]
	protected override void OnMouseUpAsButton()
	{
		RectTransform rectTransform = this.rectTransform;
		if (this.refreshTimes > 0)
		{
			uint num;
			this.refreshTimes = (int)num;
			TextMeshProUGUI textMeshProUGUI = this.text;
			int num2;
			string text = string.Format("刷新({0})", num2);
			textMeshProUGUI.text = text;
			TextMeshProUGUI textMeshProUGUI2 = this.text;
			TextMeshProUGUI textMeshProUGUI3 = this.text_shadow;
			string text2 = textMeshProUGUI2.text;
			textMeshProUGUI3.text = text2;
			base.OnMouseUpAsButton();
			return;
		}
		uint num3;
		GameAPP.PlaySound((int)num3, 0.5f, 1f);
		InGameText instance = InGameText.Instance;
	}

	// Token: 0x06001E1A RID: 7706 RVA: 0x000A0590 File Offset: 0x0009E790
	[Token(Token = "0x6001E1A")]
	[Address(RVA = "0x5843D0", Offset = "0x5829D0", VA = "0x1805843D0")]
	public TravelRefresh()
	{
	}

	// Token: 0x0400105E RID: 4190
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400105E")]
	private int refreshTimes = (int)((ulong)4L);

	// Token: 0x0400105F RID: 4191
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400105F")]
	public TextMeshProUGUI text;

	// Token: 0x04001060 RID: 4192
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001060")]
	public TextMeshProUGUI text_shadow;
}
