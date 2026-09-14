using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x020007EE RID: 2030
[Token(Token = "0x20007EE")]
public class OptionMenu : BaseMenu
{
	// Token: 0x0600297D RID: 10621 RVA: 0x000E23CC File Offset: 0x000E05CC
	[Token(Token = "0x600297D")]
	[Address(RVA = "0x63F7E0", Offset = "0x63DDE0", VA = "0x18063F7E0")]
	private void Start()
	{
		Toggle toggle = this.strongUltiZombieInRandom;
		bool flag = GameAPP.config.strongUltiZombieInRandom;
		toggle.isOn = flag;
		GameConfig config = GameAPP.config;
		Toggle toggle2 = this.leaderInRandom;
		bool flag2 = config.leaderInRandom;
		toggle2.isOn = flag2;
		GameConfig config2 = GameAPP.config;
		Toggle toggle3 = this.levelZombieInRandom;
		bool flag3 = config2.levelZombieInRandom;
		toggle3.isOn = flag3;
		GameConfig config3 = GameAPP.config;
		Toggle toggle4 = this.enableBossHealthSlider;
		bool flag4 = config3.enableBossHealthSlider;
		toggle4.isOn = flag4;
		GameConfig config4 = GameAPP.config;
		Toggle toggle5 = this.autoEnterGame;
		bool flag5 = config4.autoEnterGame;
		toggle5.isOn = flag5;
		GameConfig config5 = GameAPP.config;
		Toggle toggle6 = this.easyTravel;
		bool flag6 = config5.easyTravel;
		toggle6.isOn = flag6;
		GameConfig config6 = GameAPP.config;
		Toggle toggle7 = this.realEndless;
		bool flag7 = config6.realEndless;
		toggle7.isOn = flag7;
		GameConfig config7 = GameAPP.config;
		Toggle toggle8 = this.disableBoardStatistics;
		bool flag8 = config7.disableBoardStatistics;
		toggle8.isOn = flag8;
		GameConfig config8 = GameAPP.config;
		Toggle toggle9 = this.shootingWithoutGlove;
		bool flag9 = config8.shootingWithoutGlove;
		toggle9.isOn = flag9;
		GameConfig config9 = GameAPP.config;
		Toggle toggle10 = this.disablelevelTutor;
		bool flag10 = config9.disablelevelTutor;
		toggle10.isOn = flag10;
		GameConfig config10 = GameAPP.config;
		Toggle toggle11 = this.wheatColor;
		bool flag11 = config10.wheatColor;
		toggle11.isOn = flag11;
		GameConfig config11 = GameAPP.config;
		Toggle toggle12 = this.disablePreSelectInAdv;
		bool flag12 = config11.disablePreSelectInAdv;
		toggle12.isOn = flag12;
		GameConfig config12 = GameAPP.config;
		Toggle toggle13 = this.distablexplodeFlash;
		bool flag13 = config12.distablexplodeFlash;
		toggle13.isOn = flag13;
		GameConfig config13 = GameAPP.config;
		Toggle toggle14 = this.disableSolarStarEffect;
		bool flag14 = config13.disableSolarStarEffect;
		toggle14.isOn = flag14;
		GameConfig config14 = GameAPP.config;
		Toggle toggle15 = this.disableHealthToData;
		bool flag15 = config14.disableHealthToData;
		toggle15.isOn = flag15;
		GameConfig config15 = GameAPP.config;
		Toggle toggle16 = this.showBulletDamage;
		bool flag16 = config15.showBulletDamage;
		toggle16.isOn = flag16;
	}

	// Token: 0x0600297E RID: 10622 RVA: 0x000E25E4 File Offset: 0x000E07E4
	[Token(Token = "0x600297E")]
	[Address(RVA = "0x63FBB0", Offset = "0x63E1B0", VA = "0x18063FBB0")]
	private void Update()
	{
		GameConfig config = GameAPP.config;
		bool isOn = this.strongUltiZombieInRandom.m_IsOn;
		config.strongUltiZombieInRandom = isOn;
		Toggle toggle = this.leaderInRandom;
		GameConfig config2 = GameAPP.config;
		bool isOn2 = toggle.m_IsOn;
		config2.leaderInRandom = isOn2;
		Toggle toggle2 = this.levelZombieInRandom;
		GameConfig config3 = GameAPP.config;
		bool isOn3 = toggle2.m_IsOn;
		config3.levelZombieInRandom = isOn3;
		Toggle toggle3 = this.enableBossHealthSlider;
		GameConfig config4 = GameAPP.config;
		bool isOn4 = toggle3.m_IsOn;
		config4.enableBossHealthSlider = isOn4;
		Toggle toggle4 = this.autoEnterGame;
		GameConfig config5 = GameAPP.config;
		bool isOn5 = toggle4.m_IsOn;
		config5.autoEnterGame = isOn5;
		Toggle toggle5 = this.easyTravel;
		GameConfig config6 = GameAPP.config;
		bool isOn6 = toggle5.m_IsOn;
		config6.easyTravel = isOn6;
		Toggle toggle6 = this.realEndless;
		GameConfig config7 = GameAPP.config;
		bool isOn7 = toggle6.m_IsOn;
		config7.realEndless = isOn7;
		Toggle toggle7 = this.disableBoardStatistics;
		GameConfig config8 = GameAPP.config;
		bool isOn8 = toggle7.m_IsOn;
		config8.disableBoardStatistics = isOn8;
		Toggle toggle8 = this.shootingWithoutGlove;
		GameConfig config9 = GameAPP.config;
		bool isOn9 = toggle8.m_IsOn;
		config9.shootingWithoutGlove = isOn9;
		Toggle toggle9 = this.disablelevelTutor;
		GameConfig config10 = GameAPP.config;
		bool isOn10 = toggle9.m_IsOn;
		config10.disablelevelTutor = isOn10;
		Toggle toggle10 = this.wheatColor;
		GameConfig config11 = GameAPP.config;
		bool isOn11 = toggle10.m_IsOn;
		config11.wheatColor = isOn11;
		Toggle toggle11 = this.disablePreSelectInAdv;
		GameConfig config12 = GameAPP.config;
		bool isOn12 = toggle11.m_IsOn;
		config12.disablePreSelectInAdv = isOn12;
		Toggle toggle12 = this.distablexplodeFlash;
		GameConfig config13 = GameAPP.config;
		bool isOn13 = toggle12.m_IsOn;
		config13.distablexplodeFlash = isOn13;
		Toggle toggle13 = this.disableSolarStarEffect;
		GameConfig config14 = GameAPP.config;
		bool isOn14 = toggle13.m_IsOn;
		config14.disableSolarStarEffect = isOn14;
		Toggle toggle14 = this.disableHealthToData;
		GameConfig config15 = GameAPP.config;
		bool isOn15 = toggle14.m_IsOn;
		config15.disableHealthToData = isOn15;
		Toggle toggle15 = this.showBulletDamage;
		GameConfig config16 = GameAPP.config;
		bool isOn16 = toggle15.m_IsOn;
		config16.showBulletDamage = isOn16;
	}

	// Token: 0x0600297F RID: 10623 RVA: 0x000E27FC File Offset: 0x000E09FC
	[Token(Token = "0x600297F")]
	[Address(RVA = "0x63F5A0", Offset = "0x63DBA0", VA = "0x18063F5A0", Slot = "8")]
	public override void OnExit()
	{
		SaveInfo.Instance.SavePlayerData();
	}

	// Token: 0x06002980 RID: 10624 RVA: 0x000E281C File Offset: 0x000E0A1C
	[Token(Token = "0x6002980")]
	[Address(RVA = "0x63F5F0", Offset = "0x63DBF0", VA = "0x18063F5F0")]
	public void OnLockAlmanacMenu()
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		int num2 = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)68), canvasUp, num2 != 0);
		ConfirmMenu menu;
		if (baseMenu == 0)
		{
			menu = num;
		}
		menu = baseMenu;
		menu.SetTitle("你真的要全部解锁吗？\n这可能会影响游戏体验");
		UnityEvent clickEvent = menu.activeButton.clickEvent;
		UnityAction unityAction = delegate
		{
			InGameText instance = InGameText.Instance;
			int num3 = 0;
			int num4 = 0;
			instance.ShowText("已解锁全部图鉴", 3f, num4 != 0);
			PlantType[] enumValues = global::Core.Lawnf.GetEnumValues<PlantType>();
			if (num3 < enumValues.Length)
			{
				HashSet<PlantType> meetPlant_runTime = GameAPP.config.meetPlant_runTime;
				num3++;
			}
			SaveInfo.Instance.SavePlayerData();
			ConfirmMenu menu2 = menu;
			throw new NullReferenceException();
		};
		clickEvent.AddListener(unityAction);
	}

	// Token: 0x06002981 RID: 10625 RVA: 0x000E28A4 File Offset: 0x000E0AA4
	[Token(Token = "0x6002981")]
	[Address(RVA = "0x603FF0", Offset = "0x6025F0", VA = "0x180603FF0")]
	public OptionMenu()
	{
	}

	// Token: 0x040017C4 RID: 6084
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40017C4")]
	public Toggle strongUltiZombieInRandom;

	// Token: 0x040017C5 RID: 6085
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40017C5")]
	public Toggle leaderInRandom;

	// Token: 0x040017C6 RID: 6086
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40017C6")]
	public Toggle levelZombieInRandom;

	// Token: 0x040017C7 RID: 6087
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40017C7")]
	public Toggle enableBossHealthSlider;

	// Token: 0x040017C8 RID: 6088
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40017C8")]
	public Toggle autoEnterGame;

	// Token: 0x040017C9 RID: 6089
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40017C9")]
	public Toggle easyTravel;

	// Token: 0x040017CA RID: 6090
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40017CA")]
	public Toggle realEndless;

	// Token: 0x040017CB RID: 6091
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40017CB")]
	public Toggle disableBoardStatistics;

	// Token: 0x040017CC RID: 6092
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40017CC")]
	public Toggle shootingWithoutGlove;

	// Token: 0x040017CD RID: 6093
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40017CD")]
	public Toggle disablelevelTutor;

	// Token: 0x040017CE RID: 6094
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40017CE")]
	public Toggle wheatColor;

	// Token: 0x040017CF RID: 6095
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40017CF")]
	public Toggle disablePreSelectInAdv;

	// Token: 0x040017D0 RID: 6096
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40017D0")]
	public Toggle distablexplodeFlash;

	// Token: 0x040017D1 RID: 6097
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40017D1")]
	public Toggle disableSolarStarEffect;

	// Token: 0x040017D2 RID: 6098
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40017D2")]
	public Toggle disableHealthToData;

	// Token: 0x040017D3 RID: 6099
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40017D3")]
	public Toggle showBulletDamage;
}
