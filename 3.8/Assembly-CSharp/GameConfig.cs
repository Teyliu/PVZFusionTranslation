using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using GameLevel;
using GameLevel.Abyss;
using GameLevel.RogueShooting;
using RhythmGame;
using UI;
using UnityEngine;

// Token: 0x0200099B RID: 2459
[Token(Token = "0x200099B")]
[Serializable]
public class GameConfig : ISerializationCallbackReceiver
{
	// Token: 0x0600320D RID: 12813 RVA: 0x00107F04 File Offset: 0x00106104
	[Token(Token = "0x600320D")]
	[Address(RVA = "0x6E56F0", Offset = "0x6E3CF0", VA = "0x1806E56F0", Slot = "4")]
	public void OnBeforeSerialize()
	{
		List<PlantType> list = Enumerable.ToList<PlantType>(this.meetPlant_runTime);
		this.meetPlants = list;
		List<TravelAdvanture> list2 = Enumerable.ToList<TravelAdvanture>(this.travelLevelCompleted_runTime);
		this.travelLevelCompleted = list2;
	}

	// Token: 0x0600320E RID: 12814 RVA: 0x00107F38 File Offset: 0x00106138
	[Token(Token = "0x600320E")]
	[Address(RVA = "0x6E5670", Offset = "0x6E3C70", VA = "0x1806E5670", Slot = "5")]
	public void OnAfterDeserialize()
	{
		HashSet<PlantType> hashSet = Enumerable.ToHashSet<PlantType>(this.meetPlants);
		this.meetPlant_runTime = hashSet;
		HashSet<TravelAdvanture> hashSet2 = Enumerable.ToHashSet<TravelAdvanture>(this.travelLevelCompleted);
		this.travelLevelCompleted_runTime = hashSet2;
	}

	// Token: 0x0600320F RID: 12815 RVA: 0x00107F6C File Offset: 0x0010616C
	[Token(Token = "0x600320F")]
	[Address(RVA = "0x6E5770", Offset = "0x6E3D70", VA = "0x1806E5770")]
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

	// Token: 0x040023F0 RID: 9200
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40023F0")]
	public int difficulty = (int)((ulong)2L);

	// Token: 0x040023F1 RID: 9201
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40023F1")]
	public float gameSpeed = 1f;

	// Token: 0x040023F2 RID: 9202
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40023F2")]
	public float cameraSize = 5f;

	// Token: 0x040023F3 RID: 9203
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40023F3")]
	public float canvasMatch = 1f;

	// Token: 0x040023F4 RID: 9204
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40023F4")]
	public float snapassqutch = 3.3f;

	// Token: 0x040023F5 RID: 9205
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40023F5")]
	public float gameMusicVolume = 1f;

	// Token: 0x040023F6 RID: 9206
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40023F6")]
	public float gameSoundVolume = 1f;

	// Token: 0x040023F7 RID: 9207
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40023F7")]
	public bool strongUltiZombieInRandom;

	// Token: 0x040023F8 RID: 9208
	[FieldOffset(Offset = "0x2D")]
	[Token(Token = "0x40023F8")]
	public bool leaderInRandom;

	// Token: 0x040023F9 RID: 9209
	[FieldOffset(Offset = "0x2E")]
	[Token(Token = "0x40023F9")]
	public bool levelZombieInRandom;

	// Token: 0x040023FA RID: 9210
	[FieldOffset(Offset = "0x2F")]
	[Token(Token = "0x40023FA")]
	public bool enableBossHealthSlider;

	// Token: 0x040023FB RID: 9211
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40023FB")]
	public bool autoEnterGame;

	// Token: 0x040023FC RID: 9212
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x40023FC")]
	public bool easyTravel;

	// Token: 0x040023FD RID: 9213
	[FieldOffset(Offset = "0x32")]
	[Token(Token = "0x40023FD")]
	public bool shootingWithoutGlove;

	// Token: 0x040023FE RID: 9214
	[FieldOffset(Offset = "0x33")]
	[Token(Token = "0x40023FE")]
	public bool disablelevelTutor;

	// Token: 0x040023FF RID: 9215
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40023FF")]
	public bool wheatColor;

	// Token: 0x04002400 RID: 9216
	[FieldOffset(Offset = "0x35")]
	[Token(Token = "0x4002400")]
	public bool disablePreSelectInAdv;

	// Token: 0x04002401 RID: 9217
	[FieldOffset(Offset = "0x36")]
	[Token(Token = "0x4002401")]
	public bool distablexplodeFlash;

	// Token: 0x04002402 RID: 9218
	[FieldOffset(Offset = "0x37")]
	[Token(Token = "0x4002402")]
	public bool disableSolarStarEffect;

	// Token: 0x04002403 RID: 9219
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002403")]
	public bool debug;

	// Token: 0x04002404 RID: 9220
	[FieldOffset(Offset = "0x39")]
	[Token(Token = "0x4002404")]
	public bool disableMenuAnim;

	// Token: 0x04002405 RID: 9221
	[FieldOffset(Offset = "0x3A")]
	[Token(Token = "0x4002405")]
	public bool ra2Sound;

	// Token: 0x04002406 RID: 9222
	[FieldOffset(Offset = "0x3B")]
	[Token(Token = "0x4002406")]
	public bool realEndless;

	// Token: 0x04002407 RID: 9223
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4002407")]
	public bool disableBoardStatistics;

	// Token: 0x04002408 RID: 9224
	[FieldOffset(Offset = "0x3D")]
	[Token(Token = "0x4002408")]
	public bool disableHealthToData;

	// Token: 0x04002409 RID: 9225
	[FieldOffset(Offset = "0x3E")]
	[Token(Token = "0x4002409")]
	public bool showBulletDamage;

	// Token: 0x0400240A RID: 9226
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400240A")]
	public RogueShootingData shootingData;

	// Token: 0x0400240B RID: 9227
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400240B")]
	public PlayerSettings rhythmSettings;

	// Token: 0x0400240C RID: 9228
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400240C")]
	public LevelComplete levelComplete;

	// Token: 0x0400240D RID: 9229
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400240D")]
	public List<SavedCardGroup> savedCardGroups;

	// Token: 0x0400240E RID: 9230
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400240E")]
	public UIConfig UIConfig;

	// Token: 0x0400240F RID: 9231
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400240F")]
	public AbyssData abyssData;

	// Token: 0x04002410 RID: 9232
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4002410")]
	[SerializeField]
	private List<PlantType> meetPlants;

	// Token: 0x04002411 RID: 9233
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4002411")]
	public HashSet<PlantType> meetPlant_runTime;

	// Token: 0x04002412 RID: 9234
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4002412")]
	[SerializeField]
	private List<TravelAdvanture> travelLevelCompleted;

	// Token: 0x04002413 RID: 9235
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4002413")]
	public HashSet<TravelAdvanture> travelLevelCompleted_runTime;
}
