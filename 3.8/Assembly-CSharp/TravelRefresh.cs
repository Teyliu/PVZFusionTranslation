using System;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x02000603 RID: 1539
[Token(Token = "0x2000603")]
public class TravelRefresh : UIButton
{
	// Token: 0x06001D16 RID: 7446 RVA: 0x0009B93C File Offset: 0x00099B3C
	[Token(Token = "0x6001D16")]
	[Address(RVA = "0x523F70", Offset = "0x522570", VA = "0x180523F70")]
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

	// Token: 0x06001D17 RID: 7447 RVA: 0x0009B98C File Offset: 0x00099B8C
	[Token(Token = "0x6001D17")]
	[Address(RVA = "0x524240", Offset = "0x522840", VA = "0x180524240")]
	public void SetRefrashTimes(int value)
	{
		this.refreshTimes = value;
		this.UpdateText();
	}

	// Token: 0x06001D18 RID: 7448 RVA: 0x0009B9A8 File Offset: 0x00099BA8
	[Token(Token = "0x6001D18")]
	[Address(RVA = "0x524040", Offset = "0x522640", VA = "0x180524040")]
	public void ModifyRefrashTimes(int value)
	{
		this.UpdateText();
	}

	// Token: 0x06001D19 RID: 7449 RVA: 0x0009B9BC File Offset: 0x00099BBC
	[Token(Token = "0x6001D19")]
	[Address(RVA = "0x524250", Offset = "0x522850", VA = "0x180524250")]
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

	// Token: 0x06001D1A RID: 7450 RVA: 0x0009BA10 File Offset: 0x00099C10
	[Token(Token = "0x6001D1A")]
	[Address(RVA = "0x524050", Offset = "0x522650", VA = "0x180524050", Slot = "9")]
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
		int num4 = 0;
		instance.ShowText("刷新次数不足", 1f, num4 != 0);
	}

	// Token: 0x06001D1B RID: 7451 RVA: 0x0009BAB4 File Offset: 0x00099CB4
	[Token(Token = "0x6001D1B")]
	[Address(RVA = "0x524330", Offset = "0x522930", VA = "0x180524330")]
	public TravelRefresh()
	{
	}

	// Token: 0x04000F96 RID: 3990
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000F96")]
	private int refreshTimes = (int)((ulong)4L);

	// Token: 0x04000F97 RID: 3991
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000F97")]
	public TextMeshProUGUI text;

	// Token: 0x04000F98 RID: 3992
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000F98")]
	public TextMeshProUGUI text_shadow;
}
