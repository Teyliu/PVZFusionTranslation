using System;
using Cpp2IlInjected;

// Token: 0x020007E9 RID: 2025
[Token(Token = "0x20007E9")]
[Serializable]
public class PlantSkinData
{
	// Token: 0x0600291D RID: 10525 RVA: 0x000DDFAC File Offset: 0x000DC1AC
	[Token(Token = "0x600291D")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public PlantSkinData()
	{
	}

	// Token: 0x04001710 RID: 5904
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001710")]
	public PlantType thePlantType;

	// Token: 0x04001711 RID: 5905
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001711")]
	public int skinIndex;
}
