using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using GameLevel;
using GameLevel.Abyss;
using GameLevel.RogueShooting;
using OpenBLive.Runtime;
using RhythmGame;
using UI;
using UnityEngine;

// Token: 0x020009D7 RID: 2519
[Token(Token = "0x20009D7")]
[Serializable]
public class GameConfig : ISerializationCallbackReceiver
{
	// Token: 0x06003341 RID: 13121 RVA: 0x0010CCE0 File Offset: 0x0010AEE0
	[Token(Token = "0x6003341")]
	[Address(RVA = "0x74ABB0", Offset = "0x7491B0", VA = "0x18074ABB0", Slot = "4")]
	public void OnBeforeSerialize()
	{
		List<PlantType> list = Enumerable.ToList<PlantType>(this.meetPlant_runTime);
		this.meetPlants = list;
		List<TravelAdvanture> list2 = Enumerable.ToList<TravelAdvanture>(this.travelLevelCompleted_runTime);
		this.travelLevelCompleted = list2;
	}

	// Token: 0x06003342 RID: 13122 RVA: 0x0010CD14 File Offset: 0x0010AF14
	[Token(Token = "0x6003342")]
	[Address(RVA = "0x74AB20", Offset = "0x749120", VA = "0x18074AB20", Slot = "5")]
	public void OnAfterDeserialize()
	{
		HashSet<PlantType> hashSet = Enumerable.ToHashSet<PlantType>(this.meetPlants);
		this.meetPlant_runTime = hashSet;
		HashSet<TravelAdvanture> hashSet2 = Enumerable.ToHashSet<TravelAdvanture>(this.travelLevelCompleted);
		this.travelLevelCompleted_runTime = hashSet2;
	}

	// Token: 0x06003343 RID: 13123 RVA: 0x0010CD48 File Offset: 0x0010AF48
	[Token(Token = "0x6003343")]
	[Address(RVA = "0x74AC40", Offset = "0x749240", VA = "0x18074AC40")]
	public GameConfig()
	{
		RogueShootingData rogueShootingData = new RogueShootingData();
		this.shootingData = rogueShootingData;
		PlayerSettings playerSettings = new PlayerSettings();
		this.rhythmSettings = playerSettings;
		LevelComplete levelComplete = new LevelComplete();
		this.levelComplete = levelComplete;
		List<SavedCardGroup> list = new List();
		this.savedCardGroups = list;
		UIConfig uiconfig = new UIConfig();
		this.UIConfig = uiconfig;
		AbyssData abyssData = new AbyssData();
		this.abyssData = abyssData;
		BLiveConfig bliveConfig = new BLiveConfig();
		this.liveConfig = bliveConfig;
		List<PlantType> list2 = new List();
		this.meetPlants = list2;
		HashSet<PlantType> hashSet = new HashSet();
		this.meetPlant_runTime = hashSet;
		List<TravelAdvanture> list3 = new List();
		this.travelLevelCompleted = list3;
		HashSet<TravelAdvanture> hashSet2 = new HashSet();
		this.travelLevelCompleted_runTime = hashSet2;
		base..ctor();
	}

	// Token: 0x040024FE RID: 9470
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40024FE")]
	public int difficulty = (int)((ulong)2L);

	// Token: 0x040024FF RID: 9471
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40024FF")]
	public float gameSpeed = 1f;

	// Token: 0x04002500 RID: 9472
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002500")]
	public float cameraSize = 5f;

	// Token: 0x04002501 RID: 9473
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4002501")]
	public float canvasMatch = 1f;

	// Token: 0x04002502 RID: 9474
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002502")]
	public float snapassqutch = 3.3f;

	// Token: 0x04002503 RID: 9475
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4002503")]
	public float gameMusicVolume = 1f;

	// Token: 0x04002504 RID: 9476
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002504")]
	public float gameSoundVolume = 1f;

	// Token: 0x04002505 RID: 9477
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4002505")]
	public bool strongUltiZombieInRandom;

	// Token: 0x04002506 RID: 9478
	[FieldOffset(Offset = "0x2D")]
	[Token(Token = "0x4002506")]
	public bool leaderInRandom;

	// Token: 0x04002507 RID: 9479
	[FieldOffset(Offset = "0x2E")]
	[Token(Token = "0x4002507")]
	public bool levelZombieInRandom;

	// Token: 0x04002508 RID: 9480
	[FieldOffset(Offset = "0x2F")]
	[Token(Token = "0x4002508")]
	public bool enableBossHealthSlider;

	// Token: 0x04002509 RID: 9481
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002509")]
	public bool autoEnterGame;

	// Token: 0x0400250A RID: 9482
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x400250A")]
	public bool easyTravel;

	// Token: 0x0400250B RID: 9483
	[FieldOffset(Offset = "0x32")]
	[Token(Token = "0x400250B")]
	public bool shootingWithoutGlove;

	// Token: 0x0400250C RID: 9484
	[FieldOffset(Offset = "0x33")]
	[Token(Token = "0x400250C")]
	public bool disablelevelTutor;

	// Token: 0x0400250D RID: 9485
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400250D")]
	public bool wheatColor;

	// Token: 0x0400250E RID: 9486
	[FieldOffset(Offset = "0x35")]
	[Token(Token = "0x400250E")]
	public bool disablePreSelectInAdv;

	// Token: 0x0400250F RID: 9487
	[FieldOffset(Offset = "0x36")]
	[Token(Token = "0x400250F")]
	public bool distablexplodeFlash;

	// Token: 0x04002510 RID: 9488
	[FieldOffset(Offset = "0x37")]
	[Token(Token = "0x4002510")]
	public bool disableSolarStarEffect;

	// Token: 0x04002511 RID: 9489
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002511")]
	public bool debug;

	// Token: 0x04002512 RID: 9490
	[FieldOffset(Offset = "0x39")]
	[Token(Token = "0x4002512")]
	public bool disableMenuAnim;

	// Token: 0x04002513 RID: 9491
	[FieldOffset(Offset = "0x3A")]
	[Token(Token = "0x4002513")]
	public bool ra2Sound;

	// Token: 0x04002514 RID: 9492
	[FieldOffset(Offset = "0x3B")]
	[Token(Token = "0x4002514")]
	public bool realEndless;

	// Token: 0x04002515 RID: 9493
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4002515")]
	public bool disableBoardStatistics;

	// Token: 0x04002516 RID: 9494
	[FieldOffset(Offset = "0x3D")]
	[Token(Token = "0x4002516")]
	public bool disableHealthToData;

	// Token: 0x04002517 RID: 9495
	[FieldOffset(Offset = "0x3E")]
	[Token(Token = "0x4002517")]
	public bool showBulletDamage;

	// Token: 0x04002518 RID: 9496
	[FieldOffset(Offset = "0x3F")]
	[Token(Token = "0x4002518")]
	public bool disableScreenShake;

	// Token: 0x04002519 RID: 9497
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4002519")]
	public bool damagePop;

	// Token: 0x0400251A RID: 9498
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400251A")]
	public RogueShootingData shootingData;

	// Token: 0x0400251B RID: 9499
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400251B")]
	public PlayerSettings rhythmSettings;

	// Token: 0x0400251C RID: 9500
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400251C")]
	public LevelComplete levelComplete;

	// Token: 0x0400251D RID: 9501
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400251D")]
	public List<SavedCardGroup> savedCardGroups;

	// Token: 0x0400251E RID: 9502
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400251E")]
	public UIConfig UIConfig;

	// Token: 0x0400251F RID: 9503
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400251F")]
	public AbyssData abyssData;

	// Token: 0x04002520 RID: 9504
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4002520")]
	public BLiveConfig liveConfig;

	// Token: 0x04002521 RID: 9505
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4002521")]
	[SerializeField]
	private List<PlantType> meetPlants;

	// Token: 0x04002522 RID: 9506
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4002522")]
	public HashSet<PlantType> meetPlant_runTime;

	// Token: 0x04002523 RID: 9507
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4002523")]
	[SerializeField]
	private List<TravelAdvanture> travelLevelCompleted;

	// Token: 0x04002524 RID: 9508
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4002524")]
	public HashSet<TravelAdvanture> travelLevelCompleted_runTime;
}
