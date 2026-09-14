using System;
using Cpp2IlInjected;

// Token: 0x02000A39 RID: 2617
[Token(Token = "0x2000A39")]
public enum UIType
{
	// Token: 0x040028E6 RID: 10470
	[Token(Token = "0x40028E6")]
	MainMenu,
	// Token: 0x040028E7 RID: 10471
	[Token(Token = "0x40028E7")]
	MainMenu_travel,
	// Token: 0x040028E8 RID: 10472
	[Token(Token = "0x40028E8")]
	LoseMenu,
	// Token: 0x040028E9 RID: 10473
	[Token(Token = "0x40028E9")]
	OtherMenu,
	// Token: 0x040028EA RID: 10474
	[Token(Token = "0x40028EA")]
	OptionMenu,
	// Token: 0x040028EB RID: 10475
	[Token(Token = "0x40028EB")]
	NoticePauseMenu,
	// Token: 0x040028EC RID: 10476
	[Token(Token = "0x40028EC")]
	ChallengeMenu,
	// Token: 0x040028ED RID: 10477
	[Token(Token = "0x40028ED")]
	IZMenu,
	// Token: 0x040028EE RID: 10478
	[Token(Token = "0x40028EE")]
	IZBottomMenu,
	// Token: 0x040028EF RID: 10479
	[Token(Token = "0x40028EF")]
	SurvivalMenu,
	// Token: 0x040028F0 RID: 10480
	[Token(Token = "0x40028F0")]
	ExploreMenu,
	// Token: 0x040028F1 RID: 10481
	[Token(Token = "0x40028F1")]
	ExploreMakeMenu,
	// Token: 0x040028F2 RID: 10482
	[Token(Token = "0x40028F2")]
	TravelAdvantureMenu,
	// Token: 0x040028F3 RID: 10483
	[Token(Token = "0x40028F3")]
	TravelGameMenu,
	// Token: 0x040028F4 RID: 10484
	[Token(Token = "0x40028F4")]
	TravelChallengeMenu,
	// Token: 0x040028F5 RID: 10485
	[Token(Token = "0x40028F5")]
	TravelMenu,
	// Token: 0x040028F6 RID: 10486
	[Token(Token = "0x40028F6")]
	PauseMenu,
	// Token: 0x040028F7 RID: 10487
	[Token(Token = "0x40028F7")]
	PauseMenu_checkQuit,
	// Token: 0x040028F8 RID: 10488
	[Token(Token = "0x40028F8")]
	PauseMenu_checkRestart,
	// Token: 0x040028F9 RID: 10489
	[Token(Token = "0x40028F9")]
	GardenStoreMenu,
	// Token: 0x040028FA RID: 10490
	[Token(Token = "0x40028FA")]
	GardenUI,
	// Token: 0x040028FB RID: 10491
	[Token(Token = "0x40028FB")]
	ZumaUI,
	// Token: 0x040028FC RID: 10492
	[Token(Token = "0x40028FC")]
	InGameUI,
	// Token: 0x040028FD RID: 10493
	[Token(Token = "0x40028FD")]
	InGameUI_IZ,
	// Token: 0x040028FE RID: 10494
	[Token(Token = "0x40028FE")]
	WarningMenu_travel,
	// Token: 0x040028FF RID: 10495
	[Token(Token = "0x40028FF")]
	TravelStore,
	// Token: 0x04002900 RID: 10496
	[Token(Token = "0x4002900")]
	TravelBuffMenu,
	// Token: 0x04002901 RID: 10497
	[Token(Token = "0x4002901")]
	TravelLookMenu,
	// Token: 0x04002902 RID: 10498
	[Token(Token = "0x4002902")]
	TravelInvestMenu,
	// Token: 0x04002903 RID: 10499
	[Token(Token = "0x4002903")]
	TravelSynergyMenu,
	// Token: 0x04002904 RID: 10500
	[Token(Token = "0x4002904")]
	LevelSaveMenu,
	// Token: 0x04002905 RID: 10501
	[Token(Token = "0x4002905")]
	SellConfirm,
	// Token: 0x04002906 RID: 10502
	[Token(Token = "0x4002906")]
	BuyConfirm,
	// Token: 0x04002907 RID: 10503
	[Token(Token = "0x4002907")]
	RogueStart,
	// Token: 0x04002908 RID: 10504
	[Token(Token = "0x4002908")]
	RogueSelectMenu,
	// Token: 0x04002909 RID: 10505
	[Token(Token = "0x4002909")]
	RogueCrisisMenu,
	// Token: 0x0400290A RID: 10506
	[Token(Token = "0x400290A")]
	RogueCardMenu,
	// Token: 0x0400290B RID: 10507
	[Token(Token = "0x400290B")]
	JigsawHelpMenu,
	// Token: 0x0400290C RID: 10508
	[Token(Token = "0x400290C")]
	FruitNinjaMenu,
	// Token: 0x0400290D RID: 10509
	[Token(Token = "0x400290D")]
	PlayerShootingMenu,
	// Token: 0x0400290E RID: 10510
	[Token(Token = "0x400290E")]
	GardenWorldUI,
	// Token: 0x0400290F RID: 10511
	[Token(Token = "0x400290F")]
	GardenProtectionMenu,
	// Token: 0x04002910 RID: 10512
	[Token(Token = "0x4002910")]
	TowerMenu,
	// Token: 0x04002911 RID: 10513
	[Token(Token = "0x4002911")]
	TowerUpgradeMenu,
	// Token: 0x04002912 RID: 10514
	[Token(Token = "0x4002912")]
	TreasureMainMenu,
	// Token: 0x04002913 RID: 10515
	[Token(Token = "0x4002913")]
	TreasureWarehouseMenu,
	// Token: 0x04002914 RID: 10516
	[Token(Token = "0x4002914")]
	TreasureStoreMenu,
	// Token: 0x04002915 RID: 10517
	[Token(Token = "0x4002915")]
	TreasureConfirmMenu,
	// Token: 0x04002916 RID: 10518
	[Token(Token = "0x4002916")]
	TreasureSettleMenu,
	// Token: 0x04002917 RID: 10519
	[Token(Token = "0x4002917")]
	TreasureEquipmentMenu,
	// Token: 0x04002918 RID: 10520
	[Token(Token = "0x4002918")]
	TreasureUpgradeMenu,
	// Token: 0x04002919 RID: 10521
	[Token(Token = "0x4002919")]
	TreasureEvacuateMenu,
	// Token: 0x0400291A RID: 10522
	[Token(Token = "0x400291A")]
	BigGardenUI,
	// Token: 0x0400291B RID: 10523
	[Token(Token = "0x400291B")]
	GardenBagMenu,
	// Token: 0x0400291C RID: 10524
	[Token(Token = "0x400291C")]
	PlantInfoMenu,
	// Token: 0x0400291D RID: 10525
	[Token(Token = "0x400291D")]
	AlmanacMenu,
	// Token: 0x0400291E RID: 10526
	[Token(Token = "0x400291E")]
	AlmanacPlantMenu,
	// Token: 0x0400291F RID: 10527
	[Token(Token = "0x400291F")]
	AlmanacZombieMenu,
	// Token: 0x04002920 RID: 10528
	[Token(Token = "0x4002920")]
	EveBuffMenu,
	// Token: 0x04002921 RID: 10529
	[Token(Token = "0x4002921")]
	PlantDamageMenu,
	// Token: 0x04002922 RID: 10530
	[Token(Token = "0x4002922")]
	AdvantureMenu,
	// Token: 0x04002923 RID: 10531
	[Token(Token = "0x4002923")]
	AdvantureMenu2,
	// Token: 0x04002924 RID: 10532
	[Token(Token = "0x4002924")]
	AdvantureMissionMenu,
	// Token: 0x04002925 RID: 10533
	[Token(Token = "0x4002925")]
	AdvantureStarMenu,
	// Token: 0x04002926 RID: 10534
	[Token(Token = "0x4002926")]
	AdvantureHelpMenu,
	// Token: 0x04002927 RID: 10535
	[Token(Token = "0x4002927")]
	AdvantureEvolutionMenu,
	// Token: 0x04002928 RID: 10536
	[Token(Token = "0x4002928")]
	GodShootingMenu,
	// Token: 0x04002929 RID: 10537
	[Token(Token = "0x4002929")]
	GodShootingPlantMenu,
	// Token: 0x0400292A RID: 10538
	[Token(Token = "0x400292A")]
	ConfirmMenu,
	// Token: 0x0400292B RID: 10539
	[Token(Token = "0x400292B")]
	PlantDataMenu,
	// Token: 0x0400292C RID: 10540
	[Token(Token = "0x400292C")]
	CustomMenu,
	// Token: 0x0400292D RID: 10541
	[Token(Token = "0x400292D")]
	CustomLevelMenu,
	// Token: 0x0400292E RID: 10542
	[Token(Token = "0x400292E")]
	CustomOnlineMenu,
	// Token: 0x0400292F RID: 10543
	[Token(Token = "0x400292F")]
	InputKeyMenu,
	// Token: 0x04002930 RID: 10544
	[Token(Token = "0x4002930")]
	PlayerSaveMenu,
	// Token: 0x04002931 RID: 10545
	[Token(Token = "0x4002931")]
	ReNameMenu,
	// Token: 0x04002932 RID: 10546
	[Token(Token = "0x4002932")]
	LevelResultMenu,
	// Token: 0x04002933 RID: 10547
	[Token(Token = "0x4002933")]
	PauseMenu_mainMenu,
	// Token: 0x04002934 RID: 10548
	[Token(Token = "0x4002934")]
	RhythmGameChartEditorUI,
	// Token: 0x04002935 RID: 10549
	[Token(Token = "0x4002935")]
	AlmanacSelectMenu,
	// Token: 0x04002936 RID: 10550
	[Token(Token = "0x4002936")]
	MultipleChoiceMenu,
	// Token: 0x04002937 RID: 10551
	[Token(Token = "0x4002937")]
	MultipleChoiceMenu2,
	// Token: 0x04002938 RID: 10552
	[Token(Token = "0x4002938")]
	AlmanacBuffMenu,
	// Token: 0x04002939 RID: 10553
	[Token(Token = "0x4002939")]
	PumpinerChestMenu,
	// Token: 0x0400293A RID: 10554
	[Token(Token = "0x400293A")]
	HotLevelMenu,
	// Token: 0x0400293B RID: 10555
	[Token(Token = "0x400293B")]
	UIConfigMenu,
	// Token: 0x0400293C RID: 10556
	[Token(Token = "0x400293C")]
	AbyssMenu,
	// Token: 0x0400293D RID: 10557
	[Token(Token = "0x400293D")]
	AbyssStorageMenu,
	// Token: 0x0400293E RID: 10558
	[Token(Token = "0x400293E")]
	AbyssLotteryMenu,
	// Token: 0x0400293F RID: 10559
	[Token(Token = "0x400293F")]
	AbyssLotteryAnimMenu,
	// Token: 0x04002940 RID: 10560
	[Token(Token = "0x4002940")]
	OpenBLiveMenu
}
