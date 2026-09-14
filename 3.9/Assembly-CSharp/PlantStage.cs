using System;
using Cpp2IlInjected;

// Token: 0x020000C1 RID: 193
[Token(Token = "0x20000C1")]
[Serializable]
public class PlantStage
{
	// Token: 0x0600037C RID: 892 RVA: 0x0000FFBC File Offset: 0x0000E1BC
	[Token(Token = "0x600037C")]
	[Address(RVA = "0x503D40", Offset = "0x502340", VA = "0x180503D40")]
	public PlantStage(PlantType basePlant, PlantType current)
	{
		this.basePlant = basePlant;
		this.currentStage = current;
	}

	// Token: 0x040001D5 RID: 469
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001D5")]
	public PlantType basePlant;

	// Token: 0x040001D6 RID: 470
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40001D6")]
	public PlantType currentStage;
}
