using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020000BF RID: 191
[Token(Token = "0x20000BF")]
public abstract class PlantEvolutionData
{
	// Token: 0x06000366 RID: 870 RVA: 0x0000FD8C File Offset: 0x0000DF8C
	[Token(Token = "0x6000366")]
	[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "4")]
	public virtual PlantType GetBasePlant()
	{
		return PlantType.Peashooter;
	}

	// Token: 0x06000367 RID: 871 RVA: 0x0000FDA4 File Offset: 0x0000DFA4
	[Token(Token = "0x6000367")]
	[Address(RVA = "0x4C3F00", Offset = "0x4C2500", VA = "0x1804C3F00", Slot = "5")]
	public virtual List<PlantEvolutionRoute> GetRoutes()
	{
		return new List();
	}

	// Token: 0x06000368 RID: 872 RVA: 0x0000FDB8 File Offset: 0x0000DFB8
	[Token(Token = "0x6000368")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "6")]
	public virtual void ReinforcePlant(Plant plant)
	{
	}

	// Token: 0x06000369 RID: 873 RVA: 0x0000FDC8 File Offset: 0x0000DFC8
	[Token(Token = "0x6000369")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	protected PlantEvolutionData()
	{
		int num = 0;
		this.ReinforcePlant(num);
	}
}
