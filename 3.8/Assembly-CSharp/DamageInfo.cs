using System;
using Cpp2IlInjected;

// Token: 0x02000723 RID: 1827
[Token(Token = "0x2000723")]
public struct DamageInfo
{
	// Token: 0x0400128B RID: 4747
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400128B")]
	public Zombie zombie;

	// Token: 0x0400128C RID: 4748
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400128C")]
	public PlantType thePlantType;

	// Token: 0x0400128D RID: 4749
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400128D")]
	public int damage;
}
