using System;
using Cpp2IlInjected;

// Token: 0x0200026E RID: 622
[Token(Token = "0x200026E")]
[Serializable]
public struct PlantStatisticsDetail
{
	// Token: 0x04000729 RID: 1833
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000729")]
	public PlantType plantType;

	// Token: 0x0400072A RID: 1834
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400072A")]
	public int plantedCount;
}
