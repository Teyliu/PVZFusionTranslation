using System;
using Cpp2IlInjected;

// Token: 0x020009C3 RID: 2499
[Token(Token = "0x20009C3")]
[Serializable]
public class ScaryPotData
{
	// Token: 0x0600336A RID: 13162 RVA: 0x001103E0 File Offset: 0x0010E5E0
	[Token(Token = "0x600336A")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public ScaryPotData()
	{
	}

	// Token: 0x040024F6 RID: 9462
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40024F6")]
	public int theColumn;

	// Token: 0x040024F7 RID: 9463
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40024F7")]
	public int theRow;

	// Token: 0x040024F8 RID: 9464
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40024F8")]
	public GridItemType itemType;

	// Token: 0x040024F9 RID: 9465
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40024F9")]
	public PlantType thePlantType;

	// Token: 0x040024FA RID: 9466
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40024FA")]
	public ZombieType theZombieType;
}
