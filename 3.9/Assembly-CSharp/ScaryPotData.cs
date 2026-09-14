using System;
using Cpp2IlInjected;

// Token: 0x020009FF RID: 2559
[Token(Token = "0x20009FF")]
[Serializable]
public class ScaryPotData
{
	// Token: 0x0600349E RID: 13470 RVA: 0x001153C0 File Offset: 0x001135C0
	[Token(Token = "0x600349E")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public ScaryPotData()
	{
	}

	// Token: 0x04002608 RID: 9736
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002608")]
	public int theColumn;

	// Token: 0x04002609 RID: 9737
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4002609")]
	public int theRow;

	// Token: 0x0400260A RID: 9738
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400260A")]
	public GridItemType itemType;

	// Token: 0x0400260B RID: 9739
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400260B")]
	public PlantType thePlantType;

	// Token: 0x0400260C RID: 9740
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400260C")]
	public ZombieType theZombieType;
}
