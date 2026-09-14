using System;
using Cpp2IlInjected;

// Token: 0x0200075C RID: 1884
[Token(Token = "0x200075C")]
public struct DamageInfo
{
	// Token: 0x04001360 RID: 4960
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001360")]
	public Zombie zombie;

	// Token: 0x04001361 RID: 4961
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001361")]
	public PlantType thePlantType;

	// Token: 0x04001362 RID: 4962
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001362")]
	public long damage;
}
