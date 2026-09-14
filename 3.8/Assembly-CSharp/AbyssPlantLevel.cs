using System;
using Cpp2IlInjected;

// Token: 0x020007B1 RID: 1969
[Token(Token = "0x20007B1")]
[Serializable]
public class AbyssPlantLevel
{
	// Token: 0x060027EF RID: 10223 RVA: 0x000D9004 File Offset: 0x000D7204
	[Token(Token = "0x60027EF")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public AbyssPlantLevel()
	{
	}

	// Token: 0x04001636 RID: 5686
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001636")]
	public PlantType thePlantType;

	// Token: 0x04001637 RID: 5687
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001637")]
	public int level;
}
