using System;
using Cpp2IlInjected;
using GameLevel;
using TMPro;
using UnityEngine.UI;

// Token: 0x02000A0D RID: 2573
[Token(Token = "0x2000A0D")]
public class CustomMenuPage_superRandom : CustomMenu_page
{
	// Token: 0x060034D5 RID: 13525 RVA: 0x00117190 File Offset: 0x00115390
	[Token(Token = "0x60034D5")]
	[Address(RVA = "0x765E80", Offset = "0x764480", VA = "0x180765E80", Slot = "4")]
	public override void LoadOriginalSettings()
	{
		Toggle toggle = this.applyRandomData;
		bool flag = CustomMenu._levelData.boardConfig.applyRandomData;
		toggle.isOn = flag;
		CustomMenu menu = this.menu;
		TMP_InputField tmp_InputField = this.plantModifyMin;
		BoardConfig boardConfig = menu.levelData.boardConfig;
		string text;
		tmp_InputField.text = text;
		CustomMenu menu2 = this.menu;
		TMP_InputField tmp_InputField2 = this.plantModifyMax;
		BoardConfig boardConfig2 = menu2.levelData.boardConfig;
		string text2;
		tmp_InputField2.text = text2;
		CustomMenu menu3 = this.menu;
		TMP_InputField tmp_InputField3 = this.plantSpeedMin;
		BoardConfig boardConfig3 = menu3.levelData.boardConfig;
		string text3;
		tmp_InputField3.text = text3;
		CustomMenu menu4 = this.menu;
		TMP_InputField tmp_InputField4 = this.plantSpeedMax;
		BoardConfig boardConfig4 = menu4.levelData.boardConfig;
		string text4;
		tmp_InputField4.text = text4;
		CustomMenu menu5 = this.menu;
		TMP_InputField tmp_InputField5 = this.plantSpeedAvg;
		BoardConfig boardConfig5 = menu5.levelData.boardConfig;
		string text5;
		tmp_InputField5.text = text5;
		CustomMenu menu6 = this.menu;
		TMP_InputField tmp_InputField6 = this.zombieModifyMin;
		BoardConfig boardConfig6 = menu6.levelData.boardConfig;
		string text6;
		tmp_InputField6.text = text6;
		CustomMenu menu7 = this.menu;
		TMP_InputField tmp_InputField7 = this.zombieModifyMax;
		BoardConfig boardConfig7 = menu7.levelData.boardConfig;
		string text7;
		tmp_InputField7.text = text7;
		CustomMenu menu8 = this.menu;
		TMP_InputField tmp_InputField8 = this.zombieModifyAvg;
		BoardConfig boardConfig8 = menu8.levelData.boardConfig;
		string text8;
		tmp_InputField8.text = text8;
		CustomMenu menu9 = this.menu;
		TMP_InputField tmp_InputField9 = this.zombieSpeedMin;
		BoardConfig boardConfig9 = menu9.levelData.boardConfig;
		string text9;
		tmp_InputField9.text = text9;
		CustomMenu menu10 = this.menu;
		TMP_InputField tmp_InputField10 = this.zombieSpeedMax;
		BoardConfig boardConfig10 = menu10.levelData.boardConfig;
		string text10;
		tmp_InputField10.text = text10;
		CustomMenu menu11 = this.menu;
		TMP_InputField tmp_InputField11 = this.zombieSpeedAvg;
		BoardConfig boardConfig11 = menu11.levelData.boardConfig;
		string text11;
		tmp_InputField11.text = text11;
		CustomMenu menu12 = this.menu;
		TMP_InputField tmp_InputField12 = this.zombieScaleMin;
		BoardConfig boardConfig12 = menu12.levelData.boardConfig;
		string text12;
		tmp_InputField12.text = text12;
		CustomMenu menu13 = this.menu;
		TMP_InputField tmp_InputField13 = this.zombieScaleMax;
		BoardConfig boardConfig13 = menu13.levelData.boardConfig;
		string text13;
		tmp_InputField13.text = text13;
		CustomMenu menu14 = this.menu;
		TMP_InputField tmp_InputField14 = this.zombieScaleAvg;
		BoardConfig boardConfig14 = menu14.levelData.boardConfig;
		string text14;
		tmp_InputField14.text = text14;
	}

	// Token: 0x060034D6 RID: 13526 RVA: 0x001173E0 File Offset: 0x001155E0
	[Token(Token = "0x60034D6")]
	[Address(RVA = "0x7663D0", Offset = "0x7649D0", VA = "0x1807663D0", Slot = "6")]
	public override void OnExport()
	{
		SerializedLevelData levelData = CustomMenu._levelData;
		Toggle toggle = this.applyRandomData;
		BoardConfig boardConfig = levelData.boardConfig;
		bool isOn = toggle.m_IsOn;
		boardConfig.applyRandomData = isOn;
		string text = this.plantModifyMin.m_Text;
		bool flag;
		if (flag)
		{
			string text2;
			this.plantModifyMin.text = text2;
			BoardConfig boardConfig2 = this.menu.levelData.boardConfig;
		}
		string text3 = this.plantModifyMax.m_Text;
		bool flag2;
		if (flag2)
		{
			string text4;
			this.plantModifyMax.text = text4;
			BoardConfig boardConfig3 = this.menu.levelData.boardConfig;
		}
		string text5 = this.plantSpeedMin.m_Text;
		bool flag3;
		if (flag3)
		{
			string text6;
			this.plantSpeedMin.text = text6;
			BoardConfig boardConfig4 = this.menu.levelData.boardConfig;
		}
		string text7 = this.plantSpeedMax.m_Text;
		bool flag4;
		if (flag4)
		{
			string text8;
			this.plantSpeedMax.text = text8;
			BoardConfig boardConfig5 = this.menu.levelData.boardConfig;
		}
		string text9 = this.plantSpeedAvg.m_Text;
		bool flag5;
		if (flag5)
		{
			BoardConfig boardConfig6 = this.menu.levelData.boardConfig;
		}
		string text10 = this.zombieModifyMin.m_Text;
		bool flag6;
		if (flag6)
		{
			string text11;
			this.zombieModifyMin.text = text11;
			BoardConfig boardConfig7 = this.menu.levelData.boardConfig;
		}
		string text12 = this.zombieModifyMax.m_Text;
		bool flag7;
		if (flag7)
		{
			string text13;
			this.zombieModifyMax.text = text13;
			BoardConfig boardConfig8 = this.menu.levelData.boardConfig;
		}
		string text14 = this.zombieModifyAvg.m_Text;
		bool flag8;
		if (flag8)
		{
			BoardConfig boardConfig9 = this.menu.levelData.boardConfig;
		}
		string text15 = this.zombieSpeedMin.m_Text;
		bool flag9;
		if (flag9)
		{
			string text16;
			this.zombieSpeedMin.text = text16;
			BoardConfig boardConfig10 = this.menu.levelData.boardConfig;
		}
		string text17 = this.zombieSpeedMax.m_Text;
		bool flag10;
		if (flag10)
		{
			string text18;
			this.zombieSpeedMax.text = text18;
			BoardConfig boardConfig11 = this.menu.levelData.boardConfig;
		}
		string text19 = this.zombieSpeedAvg.m_Text;
		bool flag11;
		if (flag11)
		{
			BoardConfig boardConfig12 = this.menu.levelData.boardConfig;
		}
		string text20 = this.zombieScaleMin.m_Text;
		bool flag12;
		if (flag12)
		{
			string text21;
			this.zombieScaleMin.text = text21;
			BoardConfig boardConfig13 = this.menu.levelData.boardConfig;
		}
		string text22 = this.zombieScaleMax.m_Text;
		bool flag13;
		if (flag13)
		{
			string text23;
			this.zombieScaleMax.text = text23;
			BoardConfig boardConfig14 = this.menu.levelData.boardConfig;
		}
		string text24 = this.zombieScaleAvg.m_Text;
		bool flag14;
		if (flag14)
		{
			BoardConfig boardConfig15 = this.menu.levelData.boardConfig;
		}
	}

	// Token: 0x060034D7 RID: 13527 RVA: 0x00117690 File Offset: 0x00115890
	[Token(Token = "0x60034D7")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public CustomMenuPage_superRandom()
	{
	}

	// Token: 0x0400262E RID: 9774
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400262E")]
	public Toggle applyRandomData;

	// Token: 0x0400262F RID: 9775
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400262F")]
	public TMP_InputField plantModifyMin;

	// Token: 0x04002630 RID: 9776
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002630")]
	public TMP_InputField plantModifyMax;

	// Token: 0x04002631 RID: 9777
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4002631")]
	public TMP_InputField plantSpeedMin;

	// Token: 0x04002632 RID: 9778
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4002632")]
	public TMP_InputField plantSpeedMax;

	// Token: 0x04002633 RID: 9779
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4002633")]
	public TMP_InputField plantSpeedAvg;

	// Token: 0x04002634 RID: 9780
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4002634")]
	public TMP_InputField zombieModifyMin;

	// Token: 0x04002635 RID: 9781
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4002635")]
	public TMP_InputField zombieModifyMax;

	// Token: 0x04002636 RID: 9782
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4002636")]
	public TMP_InputField zombieModifyAvg;

	// Token: 0x04002637 RID: 9783
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4002637")]
	public TMP_InputField zombieSpeedMin;

	// Token: 0x04002638 RID: 9784
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4002638")]
	public TMP_InputField zombieSpeedMax;

	// Token: 0x04002639 RID: 9785
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4002639")]
	public TMP_InputField zombieSpeedAvg;

	// Token: 0x0400263A RID: 9786
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400263A")]
	public TMP_InputField zombieScaleMin;

	// Token: 0x0400263B RID: 9787
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400263B")]
	public TMP_InputField zombieScaleMax;

	// Token: 0x0400263C RID: 9788
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400263C")]
	public TMP_InputField zombieScaleAvg;
}
