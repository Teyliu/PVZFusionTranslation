using System;
using Cpp2IlInjected;
using GameLevel;
using TMPro;
using UnityEngine.UI;

// Token: 0x020009D1 RID: 2513
[Token(Token = "0x20009D1")]
public class CustomMenuPage_superRandom : CustomMenu_page
{
	// Token: 0x060033A1 RID: 13217 RVA: 0x0011221C File Offset: 0x0011041C
	[Token(Token = "0x60033A1")]
	[Address(RVA = "0x700970", Offset = "0x6FEF70", VA = "0x180700970", Slot = "4")]
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

	// Token: 0x060033A2 RID: 13218 RVA: 0x0011246C File Offset: 0x0011066C
	[Token(Token = "0x60033A2")]
	[Address(RVA = "0x700EC0", Offset = "0x6FF4C0", VA = "0x180700EC0", Slot = "6")]
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

	// Token: 0x060033A3 RID: 13219 RVA: 0x0011271C File Offset: 0x0011091C
	[Token(Token = "0x60033A3")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public CustomMenuPage_superRandom()
	{
	}

	// Token: 0x0400251C RID: 9500
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400251C")]
	public Toggle applyRandomData;

	// Token: 0x0400251D RID: 9501
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400251D")]
	public TMP_InputField plantModifyMin;

	// Token: 0x0400251E RID: 9502
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400251E")]
	public TMP_InputField plantModifyMax;

	// Token: 0x0400251F RID: 9503
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400251F")]
	public TMP_InputField plantSpeedMin;

	// Token: 0x04002520 RID: 9504
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4002520")]
	public TMP_InputField plantSpeedMax;

	// Token: 0x04002521 RID: 9505
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4002521")]
	public TMP_InputField plantSpeedAvg;

	// Token: 0x04002522 RID: 9506
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4002522")]
	public TMP_InputField zombieModifyMin;

	// Token: 0x04002523 RID: 9507
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4002523")]
	public TMP_InputField zombieModifyMax;

	// Token: 0x04002524 RID: 9508
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4002524")]
	public TMP_InputField zombieModifyAvg;

	// Token: 0x04002525 RID: 9509
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4002525")]
	public TMP_InputField zombieSpeedMin;

	// Token: 0x04002526 RID: 9510
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4002526")]
	public TMP_InputField zombieSpeedMax;

	// Token: 0x04002527 RID: 9511
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4002527")]
	public TMP_InputField zombieSpeedAvg;

	// Token: 0x04002528 RID: 9512
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4002528")]
	public TMP_InputField zombieScaleMin;

	// Token: 0x04002529 RID: 9513
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4002529")]
	public TMP_InputField zombieScaleMax;

	// Token: 0x0400252A RID: 9514
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400252A")]
	public TMP_InputField zombieScaleAvg;
}
