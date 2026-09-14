using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020000C3 RID: 195
[Token(Token = "0x20000C3")]
public class PlantEvolutionRoute
{
	// Token: 0x06000380 RID: 896 RVA: 0x000100E8 File Offset: 0x0000E2E8
	[Token(Token = "0x6000380")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public PlantEvolutionRoute()
	{
	}

	// Token: 0x040001D9 RID: 473
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001D9")]
	public string routeName;

	// Token: 0x040001DA RID: 474
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001DA")]
	public List<PlantType> stages;

	// Token: 0x040001DB RID: 475
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001DB")]
	public List<int> stageCost;
}
