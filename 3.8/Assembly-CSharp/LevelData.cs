using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000774 RID: 1908
[Token(Token = "0x2000774")]
[Serializable]
public class LevelData
{
	// Token: 0x060026A5 RID: 9893 RVA: 0x000CE1D8 File Offset: 0x000CC3D8
	[Token(Token = "0x60026A5")]
	[Address(RVA = "0x5E40F0", Offset = "0x5E26F0", VA = "0x1805E40F0")]
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

	// Token: 0x0400143F RID: 5183
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400143F")]
	public PlantType level;

	// Token: 0x04001440 RID: 5184
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001440")]
	public SceneType sceneType;

	// Token: 0x04001441 RID: 5185
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001441")]
	public int maxWave;

	// Token: 0x04001442 RID: 5186
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001442")]
	public List<ZombieType> zombiesToAppear;

	// Token: 0x04001443 RID: 5187
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001443")]
	public List<PrePlantData> prePlant;

	// Token: 0x04001444 RID: 5188
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001444")]
	public List<PlantType> usePlant;

	// Token: 0x04001445 RID: 5189
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001445")]
	public bool convay;

	// Token: 0x04001446 RID: 5190
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4001446")]
	public float convayTimer;

	// Token: 0x04001447 RID: 5191
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001447")]
	public float gloveCD;

	// Token: 0x04001448 RID: 5192
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001448")]
	public string tips;

	// Token: 0x04001449 RID: 5193
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001449")]
	public int theSun;

	// Token: 0x0400144A RID: 5194
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x400144A")]
	public float zombieHealthMultiplier;

	// Token: 0x0400144B RID: 5195
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400144B")]
	public float zombieSpeedAdder;

	// Token: 0x0400144C RID: 5196
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x400144C")]
	public float nextWaveInterval;

	// Token: 0x0400144D RID: 5197
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400144D")]
	public float firstWaveCountdown;

	// Token: 0x0400144E RID: 5198
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x400144E")]
	public LevelType levelType;

	// Token: 0x0400144F RID: 5199
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400144F")]
	public int levelNumber;
}
