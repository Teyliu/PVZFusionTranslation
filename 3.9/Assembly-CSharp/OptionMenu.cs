using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000829 RID: 2089
[Token(Token = "0x2000829")]
public class OptionMenu : BaseMenu
{
	// Token: 0x06002AB3 RID: 10931 RVA: 0x000E74D0 File Offset: 0x000E56D0
	[Token(Token = "0x6002AB3")]
	[Address(RVA = "0x6A3DB0", Offset = "0x6A23B0", VA = "0x1806A3DB0")]
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
		GameConfig config16 = GameAPP.config;
		Toggle toggle17 = this.disableScreenShake;
		bool flag17 = config16.disableScreenShake;
		toggle17.isOn = flag17;
		GameConfig config17 = GameAPP.config;
		Toggle toggle18 = this.damagePop;
		bool flag18 = config17.damagePop;
		toggle18.isOn = flag18;
	}

	// Token: 0x06002AB4 RID: 10932 RVA: 0x000E772C File Offset: 0x000E592C
	[Token(Token = "0x6002AB4")]
	[Address(RVA = "0x6A41F0", Offset = "0x6A27F0", VA = "0x1806A41F0")]
	private void Update()
	{
		GameConfig config = GameAPP.config;
		bool isOn = this.damagePop.m_IsOn;
		config.damagePop = isOn;
		Toggle toggle = this.strongUltiZombieInRandom;
		GameConfig config2 = GameAPP.config;
		bool isOn2 = toggle.m_IsOn;
		config2.strongUltiZombieInRandom = isOn2;
		Toggle toggle2 = this.leaderInRandom;
		GameConfig config3 = GameAPP.config;
		bool isOn3 = toggle2.m_IsOn;
		config3.leaderInRandom = isOn3;
		Toggle toggle3 = this.levelZombieInRandom;
		GameConfig config4 = GameAPP.config;
		bool isOn4 = toggle3.m_IsOn;
		config4.levelZombieInRandom = isOn4;
		Toggle toggle4 = this.enableBossHealthSlider;
		GameConfig config5 = GameAPP.config;
		bool isOn5 = toggle4.m_IsOn;
		config5.enableBossHealthSlider = isOn5;
		Toggle toggle5 = this.autoEnterGame;
		GameConfig config6 = GameAPP.config;
		bool isOn6 = toggle5.m_IsOn;
		config6.autoEnterGame = isOn6;
		Toggle toggle6 = this.easyTravel;
		GameConfig config7 = GameAPP.config;
		bool isOn7 = toggle6.m_IsOn;
		config7.easyTravel = isOn7;
		Toggle toggle7 = this.realEndless;
		GameConfig config8 = GameAPP.config;
		bool isOn8 = toggle7.m_IsOn;
		config8.realEndless = isOn8;
		Toggle toggle8 = this.disableBoardStatistics;
		GameConfig config9 = GameAPP.config;
		bool isOn9 = toggle8.m_IsOn;
		config9.disableBoardStatistics = isOn9;
		Toggle toggle9 = this.shootingWithoutGlove;
		GameConfig config10 = GameAPP.config;
		bool isOn10 = toggle9.m_IsOn;
		config10.shootingWithoutGlove = isOn10;
		Toggle toggle10 = this.disablelevelTutor;
		GameConfig config11 = GameAPP.config;
		bool isOn11 = toggle10.m_IsOn;
		config11.disablelevelTutor = isOn11;
		Toggle toggle11 = this.wheatColor;
		GameConfig config12 = GameAPP.config;
		bool isOn12 = toggle11.m_IsOn;
		config12.wheatColor = isOn12;
		Toggle toggle12 = this.disablePreSelectInAdv;
		GameConfig config13 = GameAPP.config;
		bool isOn13 = toggle12.m_IsOn;
		config13.disablePreSelectInAdv = isOn13;
		Toggle toggle13 = this.distablexplodeFlash;
		GameConfig config14 = GameAPP.config;
		bool isOn14 = toggle13.m_IsOn;
		config14.distablexplodeFlash = isOn14;
		Toggle toggle14 = this.disableSolarStarEffect;
		GameConfig config15 = GameAPP.config;
		bool isOn15 = toggle14.m_IsOn;
		config15.disableSolarStarEffect = isOn15;
		Toggle toggle15 = this.disableHealthToData;
		GameConfig config16 = GameAPP.config;
		bool isOn16 = toggle15.m_IsOn;
		config16.disableHealthToData = isOn16;
		Toggle toggle16 = this.showBulletDamage;
		GameConfig config17 = GameAPP.config;
		bool isOn17 = toggle16.m_IsOn;
		config17.showBulletDamage = isOn17;
		Toggle toggle17 = this.disableScreenShake;
		GameConfig config18 = GameAPP.config;
		bool isOn18 = toggle17.m_IsOn;
		config18.disableScreenShake = isOn18;
	}

	// Token: 0x06002AB5 RID: 10933 RVA: 0x000E7988 File Offset: 0x000E5B88
	[Token(Token = "0x6002AB5")]
	[Address(RVA = "0x6A3B70", Offset = "0x6A2170", VA = "0x1806A3B70", Slot = "8")]
	public override void OnExit()
	{
		SaveInfo.Instance.SavePlayerData();
	}

	// Token: 0x06002AB6 RID: 10934 RVA: 0x000E79A8 File Offset: 0x000E5BA8
	[Token(Token = "0x6002AB6")]
	[Address(RVA = "0x6A3BC0", Offset = "0x6A21C0", VA = "0x1806A3BC0")]
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

	// Token: 0x06002AB7 RID: 10935 RVA: 0x000E7A30 File Offset: 0x000E5C30
	[Token(Token = "0x6002AB7")]
	[Address(RVA = "0x667800", Offset = "0x665E00", VA = "0x180667800")]
	public OptionMenu()
	{
	}

	// Token: 0x040018AD RID: 6317
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40018AD")]
	public Toggle strongUltiZombieInRandom;

	// Token: 0x040018AE RID: 6318
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40018AE")]
	public Toggle leaderInRandom;

	// Token: 0x040018AF RID: 6319
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40018AF")]
	public Toggle levelZombieInRandom;

	// Token: 0x040018B0 RID: 6320
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40018B0")]
	public Toggle enableBossHealthSlider;

	// Token: 0x040018B1 RID: 6321
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40018B1")]
	public Toggle autoEnterGame;

	// Token: 0x040018B2 RID: 6322
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40018B2")]
	public Toggle easyTravel;

	// Token: 0x040018B3 RID: 6323
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40018B3")]
	public Toggle realEndless;

	// Token: 0x040018B4 RID: 6324
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40018B4")]
	public Toggle disableBoardStatistics;

	// Token: 0x040018B5 RID: 6325
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40018B5")]
	public Toggle shootingWithoutGlove;

	// Token: 0x040018B6 RID: 6326
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40018B6")]
	public Toggle disablelevelTutor;

	// Token: 0x040018B7 RID: 6327
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40018B7")]
	public Toggle wheatColor;

	// Token: 0x040018B8 RID: 6328
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40018B8")]
	public Toggle disablePreSelectInAdv;

	// Token: 0x040018B9 RID: 6329
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40018B9")]
	public Toggle distablexplodeFlash;

	// Token: 0x040018BA RID: 6330
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40018BA")]
	public Toggle disableSolarStarEffect;

	// Token: 0x040018BB RID: 6331
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40018BB")]
	public Toggle disableHealthToData;

	// Token: 0x040018BC RID: 6332
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40018BC")]
	public Toggle showBulletDamage;

	// Token: 0x040018BD RID: 6333
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40018BD")]
	public Toggle disableScreenShake;

	// Token: 0x040018BE RID: 6334
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40018BE")]
	public Toggle damagePop;
}
