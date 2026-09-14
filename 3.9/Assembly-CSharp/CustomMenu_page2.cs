using System;
using Cpp2IlInjected;
using GameLevel;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000A0F RID: 2575
[Token(Token = "0x2000A0F")]
public class CustomMenu_page2 : CustomMenu_page
{
	// Token: 0x060034DC RID: 13532 RVA: 0x001176E8 File Offset: 0x001158E8
	[Token(Token = "0x60034DC")]
	[Address(RVA = "0x7677B0", Offset = "0x765DB0", VA = "0x1807677B0", Slot = "6")]
	public override void OnExport()
	{
		this.UpdateToggles();
		this.UpdateInputs();
	}

	// Token: 0x060034DD RID: 13533 RVA: 0x00117704 File Offset: 0x00115904
	[Token(Token = "0x60034DD")]
	[Address(RVA = "0x766FE0", Offset = "0x7655E0", VA = "0x180766FE0", Slot = "4")]
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

	// Token: 0x060034DE RID: 13534 RVA: 0x00117A20 File Offset: 0x00115C20
	[Token(Token = "0x60034DE")]
	[Address(RVA = "0x767C90", Offset = "0x766290", VA = "0x180767C90")]
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

	// Token: 0x060034DF RID: 13535 RVA: 0x00117D2C File Offset: 0x00115F2C
	[Token(Token = "0x60034DF")]
	[Address(RVA = "0x766BC0", Offset = "0x7651C0", VA = "0x180766BC0")]
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

	// Token: 0x060034E0 RID: 13536 RVA: 0x00117E28 File Offset: 0x00116028
	[Token(Token = "0x60034E0")]
	[Address(RVA = "0x7677D0", Offset = "0x765DD0", VA = "0x1807677D0")]
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

	// Token: 0x060034E1 RID: 13537 RVA: 0x00117F4C File Offset: 0x0011614C
	[Token(Token = "0x60034E1")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public CustomMenu_page2()
	{
	}

	// Token: 0x0400263E RID: 9790
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400263E")]
	[Header("开关选项")]
	public Toggle superRandom;

	// Token: 0x0400263F RID: 9791
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400263F")]
	public Toggle isColumn;

	// Token: 0x04002640 RID: 9792
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002640")]
	public Toggle isConvey;

	// Token: 0x04002641 RID: 9793
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4002641")]
	public Toggle isSeedRain;

	// Token: 0x04002642 RID: 9794
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4002642")]
	public Toggle isDream;

	// Token: 0x04002643 RID: 9795
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4002643")]
	public Toggle fastZombie;

	// Token: 0x04002644 RID: 9796
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4002644")]
	public Toggle disableMower;

	// Token: 0x04002645 RID: 9797
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4002645")]
	public Toggle isIndestructible;

	// Token: 0x04002646 RID: 9798
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4002646")]
	public Toggle enableAllTravelPlant;

	// Token: 0x04002647 RID: 9799
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4002647")]
	public Toggle disableNormalSun;

	// Token: 0x04002648 RID: 9800
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4002648")]
	public Toggle disableSummonZombie;

	// Token: 0x04002649 RID: 9801
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4002649")]
	public Toggle disableSelectCard;

	// Token: 0x0400264A RID: 9802
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400264A")]
	public Toggle isIZ;

	// Token: 0x0400264B RID: 9803
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400264B")]
	public Toggle disableInInterlude;

	// Token: 0x0400264C RID: 9804
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400264C")]
	public Toggle oppsiteBuff;

	// Token: 0x0400264D RID: 9805
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400264D")]
	public Toggle isRandomMix2;

	// Token: 0x0400264E RID: 9806
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400264E")]
	public Toggle isScaryPot;

	// Token: 0x0400264F RID: 9807
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400264F")]
	public Toggle allScaryPotShow;

	// Token: 0x04002650 RID: 9808
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4002650")]
	public Toggle isShooting;

	// Token: 0x04002651 RID: 9809
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4002651")]
	public Toggle smallZombie;

	// Token: 0x04002652 RID: 9810
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4002652")]
	public Toggle isTowerDefence;

	// Token: 0x04002653 RID: 9811
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4002653")]
	public Toggle rhythmGame;

	// Token: 0x04002654 RID: 9812
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4002654")]
	[Header("输入选项")]
	public TMP_InputField zombieHealth;

	// Token: 0x04002655 RID: 9813
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4002655")]
	public TMP_InputField zombieSpeed;

	// Token: 0x04002656 RID: 9814
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4002656")]
	public TMP_InputField gloveSpeed;

	// Token: 0x04002657 RID: 9815
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4002657")]
	public TMP_InputField convayInterval;

	// Token: 0x04002658 RID: 9816
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4002658")]
	public TMP_InputField firstWaveArrivedTimer;

	// Token: 0x04002659 RID: 9817
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4002659")]
	public TMP_InputField waveInterval;

	// Token: 0x0400265A RID: 9818
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x400265A")]
	public TMP_InputField startTip;

	// Token: 0x0400265B RID: 9819
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x400265B")]
	public TMP_InputField redLineColumn;
}
