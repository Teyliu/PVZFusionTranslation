using System;
using Cpp2IlInjected;

// Token: 0x020000C0 RID: 192
[Token(Token = "0x20000C0")]
[Serializable]
public class RouteChoice
{
	// Token: 0x0600037B RID: 891 RVA: 0x0000FF98 File Offset: 0x0000E198
	[Token(Token = "0x600037B")]
	[Address(RVA = "0x503D40", Offset = "0x502340", VA = "0x180503D40")]
	public RouteChoice(PlantType plant, int index)
	{
		this.basePlant = plant;
		this.routeIndex = index;
	}

	// Token: 0x040001D3 RID: 467
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001D3")]
	public PlantType basePlant;

	// Token: 0x040001D4 RID: 468
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40001D4")]
	public int routeIndex;
}
