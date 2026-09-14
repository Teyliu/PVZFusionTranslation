using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020000BE RID: 190
[Token(Token = "0x20000BE")]
public class PlantEvolutionRoute
{
	// Token: 0x06000365 RID: 869 RVA: 0x0000FD78 File Offset: 0x0000DF78
	[Token(Token = "0x6000365")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public PlantEvolutionRoute()
	{
	}

	// Token: 0x040001CC RID: 460
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001CC")]
	public string routeName;

	// Token: 0x040001CD RID: 461
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001CD")]
	public List<PlantType> stages;

	// Token: 0x040001CE RID: 462
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001CE")]
	public List<int> stageCost;
}
