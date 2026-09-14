using System;
using Cpp2IlInjected;

// Token: 0x020008A7 RID: 2215
[Token(Token = "0x20008A7")]
public interface IDamageable
{
	// Token: 0x170001C3 RID: 451
	// (get) Token: 0x06002D18 RID: 11544
	// (set) Token: 0x06002D19 RID: 11545
	[Token(Token = "0x170001C3")]
	Team Team
	{
		[Token(Token = "0x6002D18")]
		[Address(Slot = "0")]
		get;
		[Token(Token = "0x6002D19")]
		[Address(Slot = "1")]
		set;
	}

	// Token: 0x06002D1A RID: 11546
	[Token(Token = "0x6002D1A")]
	[Address(Slot = "2")]
	void TakeDamage(int value, IDamageMaker damageFrom, DamageType DamageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false);
}
