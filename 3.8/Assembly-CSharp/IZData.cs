using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020007B3 RID: 1971
[Token(Token = "0x20007B3")]
[Serializable]
public class IZData
{
	// Token: 0x060027F1 RID: 10225 RVA: 0x000D9060 File Offset: 0x000D7260
	[Token(Token = "0x60027F1")]
	[Address(RVA = "0x602960", Offset = "0x600F60", VA = "0x180602960")]
	public IZData()
	{
	}

	// Token: 0x04001648 RID: 5704
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001648")]
	public List<SavePlantData> plants;

	// Token: 0x04001649 RID: 5705
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001649")]
	public int theSun;

	// Token: 0x0400164A RID: 5706
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400164A")]
	public List<ZombieType> zombietTypes;

	// Token: 0x0400164B RID: 5707
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400164B")]
	public int dropSunPerPlant;

	// Token: 0x0400164C RID: 5708
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400164C")]
	public int recommendDifficulty;

	// Token: 0x0400164D RID: 5709
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400164D")]
	public int redlineColumn = (int)((ulong)5L);

	// Token: 0x0400164E RID: 5710
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400164E")]
	public SceneType sceneType;

	// Token: 0x0400164F RID: 5711
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400164F")]
	public string tips;
}
