using System;
using Cpp2IlInjected;

// Token: 0x02000775 RID: 1909
[Token(Token = "0x2000775")]
[Serializable]
public class PrePlantData
{
	// Token: 0x060026A6 RID: 9894 RVA: 0x000CE214 File Offset: 0x000CC414
	[Token(Token = "0x60026A6")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public PrePlantData()
	{
	}

	// Token: 0x04001450 RID: 5200
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001450")]
	public PlantType thePlantType;

	// Token: 0x04001451 RID: 5201
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001451")]
	public int theColumn;

	// Token: 0x04001452 RID: 5202
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001452")]
	public int theRow;
}
