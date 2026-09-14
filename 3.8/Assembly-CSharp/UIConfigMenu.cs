using System;
using Core;
using Cpp2IlInjected;
using TMPro;
using UI;
using UnityEngine;

// Token: 0x02000805 RID: 2053
[Token(Token = "0x2000805")]
public class UIConfigMenu : BaseMenu
{
	// Token: 0x060029DD RID: 10717 RVA: 0x000E4FE8 File Offset: 0x000E31E8
	[Token(Token = "0x60029DD")]
	[Address(RVA = "0x64AA20", Offset = "0x649020", VA = "0x18064AA20")]
	private void Start()
	{
		UIConfig uiconfig = GameAPP.config.UIConfig;
		string text;
		this.leftButtonOffsetX.text = text;
		string text2;
		this.leftButtonOffsetY.text = text2;
		string text3;
		this.leftButtonScale.text = text3;
		string text4;
		this.seedBankOffsetX.text = text4;
		string text5;
		this.seedBankOffsetY.text = text5;
		string text6;
		this.conveyOffsetX.text = text6;
		string text7;
		this.conveyOffsetY.text = text7;
		string text8;
		this.bottomOffsetX.text = text8;
		string text9;
		this.bottomOffsetY.text = text9;
		string text10;
		this.bottomOffsetInGameX.text = text10;
		string text11;
		this.bottomOffsetInGameY.text = text11;
		string text12;
		this.toolOffsetX.text = text12;
		string text13;
		this.toolOffsetY.text = text13;
	}

	// Token: 0x060029DE RID: 10718 RVA: 0x000E50B0 File Offset: 0x000E32B0
	[Token(Token = "0x60029DE")]
	[Address(RVA = "0x64ADA0", Offset = "0x6493A0", VA = "0x18064ADA0")]
	private void Update()
	{
		GameConfig config = GameAPP.config;
		TMP_InputField tmp_InputField = this.leftButtonOffsetX;
		UIConfig uiconfig = config.UIConfig;
		string text = tmp_InputField.m_Text;
		bool flag;
		if (flag)
		{
		}
		string text2 = this.leftButtonOffsetY.m_Text;
		bool flag2;
		if (flag2)
		{
		}
		string text3 = this.leftButtonScale.m_Text;
		bool flag3;
		if (flag3)
		{
		}
		TMP_InputField tmp_InputField2 = this.seedBankOffsetX;
		TMP_InputField tmp_InputField3 = this.seedBankOffsetY;
		string text4 = tmp_InputField2.m_Text;
		bool flag4;
		if (flag4)
		{
		}
		string text5 = tmp_InputField3.m_Text;
		bool flag5;
		if (flag5)
		{
		}
		TMP_InputField tmp_InputField4 = this.conveyOffsetX;
		TMP_InputField tmp_InputField5 = this.conveyOffsetY;
		string text6 = tmp_InputField4.m_Text;
		bool flag6;
		if (flag6)
		{
		}
		string text7 = tmp_InputField5.m_Text;
		bool flag7;
		if (flag7)
		{
		}
		TMP_InputField tmp_InputField6 = this.bottomOffsetX;
		TMP_InputField tmp_InputField7 = this.bottomOffsetY;
		string text8 = tmp_InputField6.m_Text;
		bool flag8;
		if (flag8)
		{
		}
		string text9 = tmp_InputField7.m_Text;
		bool flag9;
		if (flag9)
		{
		}
		TMP_InputField tmp_InputField8 = this.bottomOffsetInGameX;
		TMP_InputField tmp_InputField9 = this.bottomOffsetInGameY;
		string text10 = tmp_InputField8.m_Text;
		bool flag10;
		if (flag10)
		{
		}
		string text11 = tmp_InputField9.m_Text;
		bool flag11;
		if (flag11)
		{
		}
		TMP_InputField tmp_InputField10 = this.toolOffsetX;
		TMP_InputField tmp_InputField11 = this.toolOffsetY;
		string text12 = tmp_InputField10.m_Text;
		bool flag12;
		if (flag12)
		{
		}
		string text13 = tmp_InputField11.m_Text;
		bool flag13;
		if (flag13)
		{
		}
	}

	// Token: 0x060029DF RID: 10719 RVA: 0x000E51E4 File Offset: 0x000E33E4
	[Token(Token = "0x60029DF")]
	[Address(RVA = "0x64AD10", Offset = "0x649310", VA = "0x18064AD10")]
	private void UpdateVector2(Vector2 config, TMP_InputField inputX, TMP_InputField inputY)
	{
		ulong num;
		if (float.TryParse(inputX.m_Text, (float)num))
		{
			config.x = (float)num;
		}
		ulong num2;
		if (float.TryParse(inputY.m_Text, (float)num2))
		{
			config.y = (float)num2;
		}
	}

	// Token: 0x060029E0 RID: 10720 RVA: 0x000E5224 File Offset: 0x000E3424
	[Token(Token = "0x60029E0")]
	[Address(RVA = "0x64A990", Offset = "0x648F90", VA = "0x18064A990", Slot = "8")]
	public override void OnExit()
	{
		SaveInfo.Instance.SavePlayerData();
		InGameText instance = InGameText.Instance;
		int num = 0;
		instance.ShowText("重新进入关卡后更新", 3f, num != 0);
	}

	// Token: 0x060029E1 RID: 10721 RVA: 0x000E525C File Offset: 0x000E345C
	[Token(Token = "0x60029E1")]
	[Address(RVA = "0x603FF0", Offset = "0x6025F0", VA = "0x180603FF0")]
	public UIConfigMenu()
	{
	}

	// Token: 0x04001818 RID: 6168
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001818")]
	[Header("左侧按钮设置")]
	public TMP_InputField leftButtonOffsetX;

	// Token: 0x04001819 RID: 6169
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001819")]
	public TMP_InputField leftButtonOffsetY;

	// Token: 0x0400181A RID: 6170
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400181A")]
	public TMP_InputField leftButtonScale;

	// Token: 0x0400181B RID: 6171
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400181B")]
	[Header("卡槽偏移")]
	public TMP_InputField seedBankOffsetX;

	// Token: 0x0400181C RID: 6172
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400181C")]
	public TMP_InputField seedBankOffsetY;

	// Token: 0x0400181D RID: 6173
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400181D")]
	[Header("传送带偏移")]
	public TMP_InputField conveyOffsetX;

	// Token: 0x0400181E RID: 6174
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400181E")]
	public TMP_InputField conveyOffsetY;

	// Token: 0x0400181F RID: 6175
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400181F")]
	[Header("底部偏移")]
	public TMP_InputField bottomOffsetX;

	// Token: 0x04001820 RID: 6176
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001820")]
	public TMP_InputField bottomOffsetY;

	// Token: 0x04001821 RID: 6177
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001821")]
	[Header("游戏内底部偏移")]
	public TMP_InputField bottomOffsetInGameX;

	// Token: 0x04001822 RID: 6178
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4001822")]
	public TMP_InputField bottomOffsetInGameY;

	// Token: 0x04001823 RID: 6179
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4001823")]
	[Header("工具栏偏移")]
	public TMP_InputField toolOffsetX;

	// Token: 0x04001824 RID: 6180
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4001824")]
	public TMP_InputField toolOffsetY;
}
