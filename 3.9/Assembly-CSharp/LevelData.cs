using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020007AD RID: 1965
[Token(Token = "0x20007AD")]
[Serializable]
public class LevelData
{
	// Token: 0x060027D4 RID: 10196 RVA: 0x000D3208 File Offset: 0x000D1408
	[Token(Token = "0x60027D4")]
	[Address(RVA = "0x647430", Offset = "0x645A30", VA = "0x180647430")]
	public LevelData()
	{
		List<ZombieType> list = new List();
		this.zombiesToAppear = list;
		List<PrePlantData> list2 = new List();
		this.prePlant = list2;
		List<PlantType> list3 = new List();
		this.usePlant = list3;
		base..ctor();
	}

	// Token: 0x0400151B RID: 5403
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400151B")]
	public PlantType level;

	// Token: 0x0400151C RID: 5404
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400151C")]
	public SceneType sceneType;

	// Token: 0x0400151D RID: 5405
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400151D")]
	public int maxWave;

	// Token: 0x0400151E RID: 5406
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400151E")]
	public List<ZombieType> zombiesToAppear;

	// Token: 0x0400151F RID: 5407
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400151F")]
	public List<PrePlantData> prePlant;

	// Token: 0x04001520 RID: 5408
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001520")]
	public List<PlantType> usePlant;

	// Token: 0x04001521 RID: 5409
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001521")]
	public bool convay;

	// Token: 0x04001522 RID: 5410
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4001522")]
	public float convayTimer;

	// Token: 0x04001523 RID: 5411
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001523")]
	public float gloveCD;

	// Token: 0x04001524 RID: 5412
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001524")]
	public string tips;

	// Token: 0x04001525 RID: 5413
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001525")]
	public int theSun;

	// Token: 0x04001526 RID: 5414
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4001526")]
	public float zombieHealthMultiplier;

	// Token: 0x04001527 RID: 5415
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001527")]
	public float zombieSpeedAdder;

	// Token: 0x04001528 RID: 5416
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4001528")]
	public float nextWaveInterval;

	// Token: 0x04001529 RID: 5417
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001529")]
	public float firstWaveCountdown;

	// Token: 0x0400152A RID: 5418
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x400152A")]
	public LevelType levelType;

	// Token: 0x0400152B RID: 5419
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400152B")]
	public int levelNumber;
}
