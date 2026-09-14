using System;
using Cpp2IlInjected;

// Token: 0x020007EA RID: 2026
[Token(Token = "0x20007EA")]
[Serializable]
public class AbyssPlantLevel
{
	// Token: 0x0600291E RID: 10526 RVA: 0x000DDFC0 File Offset: 0x000DC1C0
	[Token(Token = "0x600291E")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public AbyssPlantLevel()
	{
	}

	// Token: 0x04001712 RID: 5906
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001712")]
	public PlantType thePlantType;

	// Token: 0x04001713 RID: 5907
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001713")]
	public int level;
}
