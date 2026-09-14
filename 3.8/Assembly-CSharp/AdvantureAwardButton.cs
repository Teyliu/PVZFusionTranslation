using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;

// Token: 0x020007BD RID: 1981
[Token(Token = "0x20007BD")]
public class AdvantureAwardButton : TheButton
{
	// Token: 0x06002810 RID: 10256 RVA: 0x000D9DD8 File Offset: 0x000D7FD8
	[Token(Token = "0x6002810")]
	[Address(RVA = "0x619B60", Offset = "0x618160", VA = "0x180619B60")]
	private void Awake()
	{
		TextMeshProUGUI component = base.GetComponent<TextMeshProUGUI>();
		this.textMesh = component;
	}

	// Token: 0x06002811 RID: 10257 RVA: 0x000D9DF4 File Offset: 0x000D7FF4
	[Token(Token = "0x6002811")]
	[Address(RVA = "0x619BB0", Offset = "0x6181B0", VA = "0x180619BB0")]
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

	// Token: 0x06002812 RID: 10258 RVA: 0x000D9EC0 File Offset: 0x000D80C0
	[Token(Token = "0x6002812")]
	[Address(RVA = "0x619F70", Offset = "0x618570", VA = "0x180619F70")]
	public AdvantureAwardButton()
	{
		this.grave = true;
		this.clickOffset = (ulong)1065353216L;
		this.clickOffset.y = -1f;
		this._interactable = true;
		base..ctor();
	}

	// Token: 0x04001677 RID: 5751
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001677")]
	public AdvantureLevel level;

	// Token: 0x04001678 RID: 5752
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4001678")]
	public MissionResult result;

	// Token: 0x04001679 RID: 5753
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001679")]
	private TextMeshProUGUI textMesh;
}
