using System;
using Cpp2IlInjected;

// Token: 0x020000BB RID: 187
[Token(Token = "0x20000BB")]
[Serializable]
public class RouteChoice
{
	// Token: 0x06000360 RID: 864 RVA: 0x0000FC28 File Offset: 0x0000DE28
	[Token(Token = "0x6000360")]
	[Address(RVA = "0x4C3F60", Offset = "0x4C2560", VA = "0x1804C3F60")]
	public RouteChoice(PlantType plant, int index)
	{
		this.basePlant = plant;
		this.routeIndex = index;
	}

	// Token: 0x040001C6 RID: 454
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001C6")]
	public PlantType basePlant;

	// Token: 0x040001C7 RID: 455
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40001C7")]
	public int routeIndex;
}
