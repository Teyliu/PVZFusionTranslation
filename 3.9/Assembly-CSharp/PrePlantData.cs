using System;
using Cpp2IlInjected;

// Token: 0x020007AE RID: 1966
[Token(Token = "0x20007AE")]
[Serializable]
public class PrePlantData
{
	// Token: 0x060027D5 RID: 10197 RVA: 0x000D3244 File Offset: 0x000D1444
	[Token(Token = "0x60027D5")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public PrePlantData()
	{
	}

	// Token: 0x0400152C RID: 5420
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400152C")]
	public PlantType thePlantType;

	// Token: 0x0400152D RID: 5421
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400152D")]
	public int theColumn;

	// Token: 0x0400152E RID: 5422
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400152E")]
	public int theRow;
}
