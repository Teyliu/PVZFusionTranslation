using System;
using Cpp2IlInjected;
using GameLevel;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020009D3 RID: 2515
[Token(Token = "0x20009D3")]
public class CustomMenu_page2 : CustomMenu_page
{
	// Token: 0x060033A8 RID: 13224 RVA: 0x00112774 File Offset: 0x00110974
	[Token(Token = "0x60033A8")]
	[Address(RVA = "0x7022A0", Offset = "0x7008A0", VA = "0x1807022A0", Slot = "6")]
	public override void OnExport()
	{
		this.UpdateToggles();
		this.UpdateInputs();
	}

	// Token: 0x060033A9 RID: 13225 RVA: 0x00112790 File Offset: 0x00110990
	[Token(Token = "0x60033A9")]
	[Address(RVA = "0x701AD0", Offset = "0x7000D0", VA = "0x180701AD0", Slot = "4")]
	public override void LoadOriginalSettings()
	{
		Toggle toggle = this.superRandom;
		bool isSuperRandom = CustomMenu._levelData.boardTag.isSuperRandom;
		toggle.isOn = isSuperRandom;
		Toggle toggle2 = this.isColumn;
		bool flag = CustomMenu._levelData.boardTag.isColumn;
		toggle2.isOn = flag;
		Toggle toggle3 = this.isConvey;
		bool flag2 = CustomMenu._levelData.boardTag.isConvey;
		toggle3.isOn = flag2;
		Toggle toggle4 = this.isSeedRain;
		bool flag3 = CustomMenu._levelData.boardTag.isSeedRain;
		toggle4.isOn = flag3;
		Toggle toggle5 = this.isDream;
		bool isScaredyDream = CustomMenu._levelData.boardTag.isScaredyDream;
		toggle5.isOn = isScaredyDream;
		Toggle toggle6 = this.fastZombie;
		bool flag4 = CustomMenu._levelData.boardTag.fastZombie;
		toggle6.isOn = flag4;
		Toggle toggle7 = this.disableMower;
		bool flag5 = CustomMenu._levelData.boardTag.disableMower;
		toggle7.isOn = flag5;
		Toggle toggle8 = this.isIndestructible;
		bool flag6 = CustomMenu._levelData.boardTag.isIndestructible;
		toggle8.isOn = flag6;
		Toggle toggle9 = this.enableAllTravelPlant;
		bool flag7 = CustomMenu._levelData.boardTag.enableAllTravelPlant;
		toggle9.isOn = flag7;
		Toggle toggle10 = this.disableNormalSun;
		bool flag8 = CustomMenu._levelData.boardTag.disableNormalSun;
		toggle10.isOn = flag8;
		Toggle toggle11 = this.disableSummonZombie;
		bool flag9 = CustomMenu._levelData.boardTag.disableSummonZombie;
		toggle11.isOn = flag9;
		Toggle toggle12 = this.disableSelectCard;
		bool flag10 = CustomMenu._levelData.boardTag.disableSelectCard;
		toggle12.isOn = flag10;
		Toggle toggle13 = this.isIZ;
		bool flag11 = CustomMenu._levelData.boardTag.isIZ;
		toggle13.isOn = flag11;
		Toggle toggle14 = this.disableInInterlude;
		bool flag12 = CustomMenu._levelData.boardTag.disableInInterlude;
		toggle14.isOn = flag12;
		Toggle toggle15 = this.oppsiteBuff;
		bool flag13 = CustomMenu._levelData.boardTag.oppsiteBuff;
		toggle15.isOn = flag13;
		Toggle toggle16 = this.isRandomMix2;
		bool flag14 = CustomMenu._levelData.boardTag.isRandomMix2;
		toggle16.isOn = flag14;
		Toggle toggle17 = this.isScaryPot;
		bool flag15 = CustomMenu._levelData.boardTag.isScaryPot;
		toggle17.isOn = flag15;
		Toggle toggle18 = this.allScaryPotShow;
		bool flag16 = CustomMenu._levelData.boardTag.allScaryPotShow;
		toggle18.isOn = flag16;
		Toggle toggle19 = this.isShooting;
		bool flag17 = CustomMenu._levelData.boardTag.isShooting;
		toggle19.isOn = flag17;
		SerializedLevelData levelData = this.menu.levelData;
		Toggle toggle20 = this.smallZombie;
		bool flag18 = levelData.boardTag.smallZombie;
		toggle20.isOn = flag18;
		SerializedLevelData levelData2 = this.menu.levelData;
		Toggle toggle21 = this.isTowerDefence;
		bool flag19 = levelData2.boardTag.isTowerDefence;
		toggle21.isOn = flag19;
		SerializedLevelData levelData3 = this.menu.levelData;
		Toggle toggle22 = this.rhythmGame;
		bool flag20 = levelData3.boardTag.rhythmGame;
		toggle22.isOn = flag20;
		this.LoadInputFields();
	}

	// Token: 0x060033AA RID: 13226 RVA: 0x00112AAC File Offset: 0x00110CAC
	[Token(Token = "0x60033AA")]
	[Address(RVA = "0x702780", Offset = "0x700D80", VA = "0x180702780")]
	private void UpdateToggles()
	{
		SerializedLevelData levelData = CustomMenu._levelData;
		bool isOn = this.superRandom.m_IsOn;
		levelData.boardTag.isSuperRandom = isOn;
		SerializedLevelData levelData2 = CustomMenu._levelData;
		bool isOn2 = this.isColumn.m_IsOn;
		levelData2.boardTag.isColumn = isOn2;
		SerializedLevelData levelData3 = CustomMenu._levelData;
		bool isOn3 = this.isConvey.m_IsOn;
		levelData3.boardTag.isConvey = isOn3;
		SerializedLevelData levelData4 = CustomMenu._levelData;
		bool isOn4 = this.isSeedRain.m_IsOn;
		levelData4.boardTag.isSeedRain = isOn4;
		SerializedLevelData levelData5 = CustomMenu._levelData;
		bool isOn5 = this.isDream.m_IsOn;
		levelData5.boardTag.isScaredyDream = isOn5;
		SerializedLevelData levelData6 = CustomMenu._levelData;
		bool isOn6 = this.fastZombie.m_IsOn;
		levelData6.boardTag.fastZombie = isOn6;
		SerializedLevelData levelData7 = CustomMenu._levelData;
		bool isOn7 = this.disableMower.m_IsOn;
		levelData7.boardTag.disableMower = isOn7;
		SerializedLevelData levelData8 = CustomMenu._levelData;
		bool isOn8 = this.isIndestructible.m_IsOn;
		levelData8.boardTag.isIndestructible = isOn8;
		SerializedLevelData levelData9 = CustomMenu._levelData;
		bool isOn9 = this.enableAllTravelPlant.m_IsOn;
		levelData9.boardTag.enableAllTravelPlant = isOn9;
		SerializedLevelData levelData10 = CustomMenu._levelData;
		bool isOn10 = this.disableNormalSun.m_IsOn;
		levelData10.boardTag.disableNormalSun = isOn10;
		SerializedLevelData levelData11 = CustomMenu._levelData;
		bool isOn11 = this.disableSummonZombie.m_IsOn;
		levelData11.boardTag.disableSummonZombie = isOn11;
		SerializedLevelData levelData12 = CustomMenu._levelData;
		bool isOn12 = this.disableSelectCard.m_IsOn;
		levelData12.boardTag.disableSelectCard = isOn12;
		SerializedLevelData levelData13 = CustomMenu._levelData;
		bool isOn13 = this.isIZ.m_IsOn;
		levelData13.boardTag.isIZ = isOn13;
		SerializedLevelData levelData14 = CustomMenu._levelData;
		bool isOn14 = this.disableInInterlude.m_IsOn;
		levelData14.boardTag.disableInInterlude = isOn14;
		SerializedLevelData levelData15 = CustomMenu._levelData;
		bool isOn15 = this.oppsiteBuff.m_IsOn;
		levelData15.boardTag.oppsiteBuff = isOn15;
		SerializedLevelData levelData16 = CustomMenu._levelData;
		bool isOn16 = this.isRandomMix2.m_IsOn;
		levelData16.boardTag.isRandomMix2 = isOn16;
		SerializedLevelData levelData17 = CustomMenu._levelData;
		bool isOn17 = this.isScaryPot.m_IsOn;
		levelData17.boardTag.isScaryPot = isOn17;
		SerializedLevelData levelData18 = CustomMenu._levelData;
		bool isOn18 = this.allScaryPotShow.m_IsOn;
		levelData18.boardTag.allScaryPotShow = isOn18;
		SerializedLevelData levelData19 = CustomMenu._levelData;
		bool isOn19 = this.isShooting.m_IsOn;
		levelData19.boardTag.isShooting = isOn19;
		SerializedLevelData levelData20 = this.menu.levelData;
		bool isOn20 = this.smallZombie.m_IsOn;
		levelData20.boardTag.smallZombie = isOn20;
		SerializedLevelData levelData21 = this.menu.levelData;
		bool isOn21 = this.isTowerDefence.m_IsOn;
		levelData21.boardTag.isTowerDefence = isOn21;
		SerializedLevelData levelData22 = this.menu.levelData;
		bool isOn22 = this.rhythmGame.m_IsOn;
		levelData22.boardTag.rhythmGame = isOn22;
	}

	// Token: 0x060033AB RID: 13227 RVA: 0x00112DB8 File Offset: 0x00110FB8
	[Token(Token = "0x60033AB")]
	[Address(RVA = "0x7016B0", Offset = "0x6FFCB0", VA = "0x1807016B0")]
	private void LoadInputFields()
	{
		TMP_InputField tmp_InputField = this.zombieHealth;
		BoardConfig boardConfig = CustomMenu._levelData.boardConfig;
		string text;
		tmp_InputField.text = text;
		TMP_InputField tmp_InputField2 = this.zombieSpeed;
		BoardConfig boardConfig2 = CustomMenu._levelData.boardConfig;
		string text2;
		tmp_InputField2.text = text2;
		TMP_InputField tmp_InputField3 = this.gloveSpeed;
		BoardConfig boardConfig3 = CustomMenu._levelData.boardConfig;
		string text3;
		tmp_InputField3.text = text3;
		TMP_InputField tmp_InputField4 = this.convayInterval;
		BoardConfig boardConfig4 = CustomMenu._levelData.boardConfig;
		string text4;
		tmp_InputField4.text = text4;
		TMP_InputField tmp_InputField5 = this.firstWaveArrivedTimer;
		BoardConfig boardConfig5 = CustomMenu._levelData.boardConfig;
		string text5;
		tmp_InputField5.text = text5;
		TMP_InputField tmp_InputField6 = this.waveInterval;
		BoardConfig boardConfig6 = CustomMenu._levelData.boardConfig;
		string text6;
		tmp_InputField6.text = text6;
		TMP_InputField tmp_InputField7 = this.startTip;
		string text7 = CustomMenu._levelData.boardConfig.startTip;
		tmp_InputField7.text = text7;
		TMP_InputField tmp_InputField8 = this.redLineColumn;
		BoardConfig boardConfig7 = CustomMenu._levelData.boardConfig;
		string text8;
		tmp_InputField8.text = text8;
	}

	// Token: 0x060033AC RID: 13228 RVA: 0x00112EB4 File Offset: 0x001110B4
	[Token(Token = "0x60033AC")]
	[Address(RVA = "0x7022C0", Offset = "0x7008C0", VA = "0x1807022C0")]
	private void UpdateInputs()
	{
		TMP_InputField tmp_InputField = this.zombieHealth;
		string text = tmp_InputField.m_Text;
		bool flag;
		if (flag)
		{
			BoardConfig boardConfig = CustomMenu._levelData.boardConfig;
		}
		string text2 = this.zombieSpeed.m_Text;
		bool flag2;
		if (flag2)
		{
			BoardConfig boardConfig2 = CustomMenu._levelData.boardConfig;
		}
		string text3 = this.gloveSpeed.m_Text;
		bool flag3;
		if (flag3)
		{
			int num = 0;
			CustomMenu._levelData.boardConfig.gloveSpeed = (float)num;
		}
		string text4 = this.convayInterval.m_Text;
		bool flag4;
		if (flag4)
		{
			BoardConfig boardConfig3 = CustomMenu._levelData.boardConfig;
		}
		string text5 = this.firstWaveArrivedTimer.m_Text;
		bool flag5;
		if (flag5)
		{
			BoardConfig boardConfig4 = CustomMenu._levelData.boardConfig;
		}
		string text6 = this.waveInterval.m_Text;
		bool flag6;
		if (flag6)
		{
			BoardConfig boardConfig5 = CustomMenu._levelData.boardConfig;
		}
		string text7 = this.redLineColumn.m_Text;
		bool flag7;
		if (flag7)
		{
			CustomMenu._levelData.boardConfig.redLineColumn = typeof(CustomMenu).TypeHandle;
		}
		SerializedLevelData levelData = CustomMenu._levelData;
		TMP_InputField tmp_InputField2 = this.startTip;
		BoardConfig boardConfig6 = levelData.boardConfig;
		string text8 = tmp_InputField2.m_Text;
		boardConfig6.startTip = text8;
	}

	// Token: 0x060033AD RID: 13229 RVA: 0x00112FD8 File Offset: 0x001111D8
	[Token(Token = "0x60033AD")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public CustomMenu_page2()
	{
	}

	// Token: 0x0400252C RID: 9516
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400252C")]
	[Header("开关选项")]
	public Toggle superRandom;

	// Token: 0x0400252D RID: 9517
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400252D")]
	public Toggle isColumn;

	// Token: 0x0400252E RID: 9518
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400252E")]
	public Toggle isConvey;

	// Token: 0x0400252F RID: 9519
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400252F")]
	public Toggle isSeedRain;

	// Token: 0x04002530 RID: 9520
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4002530")]
	public Toggle isDream;

	// Token: 0x04002531 RID: 9521
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4002531")]
	public Toggle fastZombie;

	// Token: 0x04002532 RID: 9522
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4002532")]
	public Toggle disableMower;

	// Token: 0x04002533 RID: 9523
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4002533")]
	public Toggle isIndestructible;

	// Token: 0x04002534 RID: 9524
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4002534")]
	public Toggle enableAllTravelPlant;

	// Token: 0x04002535 RID: 9525
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4002535")]
	public Toggle disableNormalSun;

	// Token: 0x04002536 RID: 9526
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4002536")]
	public Toggle disableSummonZombie;

	// Token: 0x04002537 RID: 9527
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4002537")]
	public Toggle disableSelectCard;

	// Token: 0x04002538 RID: 9528
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4002538")]
	public Toggle isIZ;

	// Token: 0x04002539 RID: 9529
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4002539")]
	public Toggle disableInInterlude;

	// Token: 0x0400253A RID: 9530
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400253A")]
	public Toggle oppsiteBuff;

	// Token: 0x0400253B RID: 9531
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400253B")]
	public Toggle isRandomMix2;

	// Token: 0x0400253C RID: 9532
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400253C")]
	public Toggle isScaryPot;

	// Token: 0x0400253D RID: 9533
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400253D")]
	public Toggle allScaryPotShow;

	// Token: 0x0400253E RID: 9534
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400253E")]
	public Toggle isShooting;

	// Token: 0x0400253F RID: 9535
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400253F")]
	public Toggle smallZombie;

	// Token: 0x04002540 RID: 9536
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4002540")]
	public Toggle isTowerDefence;

	// Token: 0x04002541 RID: 9537
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4002541")]
	public Toggle rhythmGame;

	// Token: 0x04002542 RID: 9538
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4002542")]
	[Header("输入选项")]
	public TMP_InputField zombieHealth;

	// Token: 0x04002543 RID: 9539
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4002543")]
	public TMP_InputField zombieSpeed;

	// Token: 0x04002544 RID: 9540
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4002544")]
	public TMP_InputField gloveSpeed;

	// Token: 0x04002545 RID: 9541
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4002545")]
	public TMP_InputField convayInterval;

	// Token: 0x04002546 RID: 9542
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4002546")]
	public TMP_InputField firstWaveArrivedTimer;

	// Token: 0x04002547 RID: 9543
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4002547")]
	public TMP_InputField waveInterval;

	// Token: 0x04002548 RID: 9544
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4002548")]
	public TMP_InputField startTip;

	// Token: 0x04002549 RID: 9545
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4002549")]
	public TMP_InputField redLineColumn;
}
