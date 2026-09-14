using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;

// Token: 0x020007F6 RID: 2038
[Token(Token = "0x20007F6")]
public class AdvantureAwardButton : TheButton
{
	// Token: 0x0600293F RID: 10559 RVA: 0x000DED94 File Offset: 0x000DCF94
	[Token(Token = "0x600293F")]
	[Address(RVA = "0x67D400", Offset = "0x67BA00", VA = "0x18067D400")]
	private void Awake()
	{
		TextMeshProUGUI component = base.GetComponent<TextMeshProUGUI>();
		this.textMesh = component;
	}

	// Token: 0x06002940 RID: 10560 RVA: 0x000DEDB0 File Offset: 0x000DCFB0
	[Token(Token = "0x6002940")]
	[Address(RVA = "0x67D450", Offset = "0x67BA50", VA = "0x18067D450")]
	public void UpdateText()
	{
		Dictionary<AdvantureLevel, ILevelStrategy> levelStrategies = AdvantureConfig._levelStrategies;
		AdvantureLevel advantureLevel = this.level;
		ILevelStrategy levelStrategy = levelStrategies[advantureLevel];
		int num = 0;
		TextMeshProUGUI textMeshProUGUI = this.textMesh;
		uint num2;
		if (num < (int)num2)
		{
			num += num;
			num++;
		}
		string text;
		textMeshProUGUI.text = text;
		TextMeshProUGUI textMeshProUGUI2 = this.textMesh;
		TextMeshProUGUI textMeshProUGUI3;
		if (this.result != MissionResult.First)
		{
			string text2 = textMeshProUGUI2.text;
			string text3;
			textMeshProUGUI2.text = text3;
			textMeshProUGUI3 = this.textMesh;
			string text4 = textMeshProUGUI3.text;
			textMeshProUGUI3 += textMeshProUGUI3;
		}
		string text5 = textMeshProUGUI3.text;
		string text6;
		textMeshProUGUI3.text = text6;
		TextMeshProUGUI textMeshProUGUI4 = this.textMesh;
		string text7 = textMeshProUGUI4.text;
		string text8;
		textMeshProUGUI4.text = text8;
		string text9 = this.textMesh.text + "——————————————————————————————";
		throw new NullReferenceException();
	}

	// Token: 0x06002941 RID: 10561 RVA: 0x000DEE7C File Offset: 0x000DD07C
	[Token(Token = "0x6002941")]
	[Address(RVA = "0x67D810", Offset = "0x67BE10", VA = "0x18067D810")]
	public AdvantureAwardButton()
	{
		this.grave = true;
		this.clickOffset = (ulong)1065353216L;
		this.clickOffset.y = -1f;
		this._interactable = true;
		base..ctor();
	}

	// Token: 0x04001753 RID: 5971
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001753")]
	public AdvantureLevel level;

	// Token: 0x04001754 RID: 5972
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4001754")]
	public MissionResult result;

	// Token: 0x04001755 RID: 5973
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001755")]
	private TextMeshProUGUI textMesh;
}
