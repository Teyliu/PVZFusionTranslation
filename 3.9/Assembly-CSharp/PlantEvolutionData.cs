using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020000C4 RID: 196
[Token(Token = "0x20000C4")]
public abstract class PlantEvolutionData
{
	// Token: 0x06000381 RID: 897 RVA: 0x000100FC File Offset: 0x0000E2FC
	[Token(Token = "0x6000381")]
	[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "4")]
	public virtual PlantType GetBasePlant()
	{
		return PlantType.Peashooter;
	}

	// Token: 0x06000382 RID: 898 RVA: 0x00010114 File Offset: 0x0000E314
	[Token(Token = "0x6000382")]
	[Address(RVA = "0x503CE0", Offset = "0x5022E0", VA = "0x180503CE0", Slot = "5")]
	public virtual List<PlantEvolutionRoute> GetRoutes()
	{
		return new List();
	}

	// Token: 0x06000383 RID: 899 RVA: 0x00010128 File Offset: 0x0000E328
	[Token(Token = "0x6000383")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "6")]
	public virtual void ReinforcePlant(Plant plant)
	{
	}

	// Token: 0x06000384 RID: 900 RVA: 0x00010138 File Offset: 0x0000E338
	[Token(Token = "0x6000384")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	protected PlantEvolutionData()
	{
		int num = 0;
		this.ReinforcePlant(num);
	}
}
