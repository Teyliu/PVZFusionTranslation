using System;
using Core;
using Cpp2IlInjected;
using TMPro;
using UI;
using UnityEngine;

// Token: 0x02000840 RID: 2112
[Token(Token = "0x2000840")]
public class UIConfigMenu : BaseMenu
{
	// Token: 0x06002B13 RID: 11027 RVA: 0x000EA060 File Offset: 0x000E8260
	[Token(Token = "0x6002B13")]
	[Address(RVA = "0x6AEBF0", Offset = "0x6AD1F0", VA = "0x1806AEBF0")]
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

	// Token: 0x06002B14 RID: 11028 RVA: 0x000EA128 File Offset: 0x000E8328
	[Token(Token = "0x6002B14")]
	[Address(RVA = "0x6AEF70", Offset = "0x6AD570", VA = "0x1806AEF70")]
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

	// Token: 0x06002B15 RID: 11029 RVA: 0x000EA25C File Offset: 0x000E845C
	[Token(Token = "0x6002B15")]
	[Address(RVA = "0x6AEEE0", Offset = "0x6AD4E0", VA = "0x1806AEEE0")]
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

	// Token: 0x06002B16 RID: 11030 RVA: 0x000EA29C File Offset: 0x000E849C
	[Token(Token = "0x6002B16")]
	[Address(RVA = "0x6AEB50", Offset = "0x6AD150", VA = "0x1806AEB50", Slot = "8")]
	public override void OnExit()
	{
		SaveInfo.Instance.SavePlayerData();
		InGameText instance = InGameText.Instance;
	}

	// Token: 0x06002B17 RID: 11031 RVA: 0x000EA2C4 File Offset: 0x000E84C4
	[Token(Token = "0x6002B17")]
	[Address(RVA = "0x667800", Offset = "0x665E00", VA = "0x180667800")]
	public UIConfigMenu()
	{
	}

	// Token: 0x04001903 RID: 6403
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001903")]
	[Header("左侧按钮设置")]
	public TMP_InputField leftButtonOffsetX;

	// Token: 0x04001904 RID: 6404
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001904")]
	public TMP_InputField leftButtonOffsetY;

	// Token: 0x04001905 RID: 6405
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001905")]
	public TMP_InputField leftButtonScale;

	// Token: 0x04001906 RID: 6406
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001906")]
	[Header("卡槽偏移")]
	public TMP_InputField seedBankOffsetX;

	// Token: 0x04001907 RID: 6407
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001907")]
	public TMP_InputField seedBankOffsetY;

	// Token: 0x04001908 RID: 6408
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001908")]
	[Header("传送带偏移")]
	public TMP_InputField conveyOffsetX;

	// Token: 0x04001909 RID: 6409
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001909")]
	public TMP_InputField conveyOffsetY;

	// Token: 0x0400190A RID: 6410
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400190A")]
	[Header("底部偏移")]
	public TMP_InputField bottomOffsetX;

	// Token: 0x0400190B RID: 6411
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400190B")]
	public TMP_InputField bottomOffsetY;

	// Token: 0x0400190C RID: 6412
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400190C")]
	[Header("游戏内底部偏移")]
	public TMP_InputField bottomOffsetInGameX;

	// Token: 0x0400190D RID: 6413
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400190D")]
	public TMP_InputField bottomOffsetInGameY;

	// Token: 0x0400190E RID: 6414
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400190E")]
	[Header("工具栏偏移")]
	public TMP_InputField toolOffsetX;

	// Token: 0x0400190F RID: 6415
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400190F")]
	public TMP_InputField toolOffsetY;
}
