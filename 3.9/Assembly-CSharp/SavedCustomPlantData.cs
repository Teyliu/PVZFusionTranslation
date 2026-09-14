using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000774 RID: 1908
[Token(Token = "0x2000774")]
[Serializable]
public class SavedCustomPlantData
{
	// Token: 0x060026D7 RID: 9943 RVA: 0x000CB9E4 File Offset: 0x000C9BE4
	[Token(Token = "0x60026D7")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public SavedCustomPlantData()
	{
	}

	// Token: 0x040013D7 RID: 5079
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40013D7")]
	public List<CustomPlant> customPlants;
}
