using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200073B RID: 1851
[Token(Token = "0x200073B")]
[Serializable]
public class SavedCustomPlantData
{
	// Token: 0x060025B2 RID: 9650 RVA: 0x000C6B00 File Offset: 0x000C4D00
	[Token(Token = "0x60025B2")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public SavedCustomPlantData()
	{
	}

	// Token: 0x04001301 RID: 4865
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001301")]
	public List<CustomPlant> customPlants;
}
