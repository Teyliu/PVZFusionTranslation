using System;
using Cpp2IlInjected;

// Token: 0x02000268 RID: 616
[Token(Token = "0x2000268")]
[Serializable]
public struct PlantStatisticsDetail
{
	// Token: 0x0400071D RID: 1821
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400071D")]
	public PlantType plantType;

	// Token: 0x0400071E RID: 1822
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400071E")]
	public int plantedCount;
}
