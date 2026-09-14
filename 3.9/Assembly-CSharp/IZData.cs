using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020007EC RID: 2028
[Token(Token = "0x20007EC")]
[Serializable]
public class IZData
{
	// Token: 0x06002920 RID: 10528 RVA: 0x000DE01C File Offset: 0x000DC21C
	[Token(Token = "0x6002920")]
	[Address(RVA = "0x666170", Offset = "0x664770", VA = "0x180666170")]
	public IZData()
	{
	}

	// Token: 0x04001724 RID: 5924
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001724")]
	public List<SavePlantData> plants;

	// Token: 0x04001725 RID: 5925
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001725")]
	public int theSun;

	// Token: 0x04001726 RID: 5926
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001726")]
	public List<ZombieType> zombietTypes;

	// Token: 0x04001727 RID: 5927
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001727")]
	public int dropSunPerPlant;

	// Token: 0x04001728 RID: 5928
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4001728")]
	public int recommendDifficulty;

	// Token: 0x04001729 RID: 5929
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001729")]
	public int redlineColumn = (int)((ulong)5L);

	// Token: 0x0400172A RID: 5930
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400172A")]
	public SceneType sceneType;

	// Token: 0x0400172B RID: 5931
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400172B")]
	public string tips;
}
