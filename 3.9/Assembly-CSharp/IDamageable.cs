using System;
using Cpp2IlInjected;

// Token: 0x020008E3 RID: 2275
[Token(Token = "0x20008E3")]
public interface IDamageable
{
	// Token: 0x1700020B RID: 523
	// (get) Token: 0x06002E4B RID: 11851
	// (set) Token: 0x06002E4C RID: 11852
	[Token(Token = "0x1700020B")]
	Team Team
	{
		[Token(Token = "0x6002E4B")]
		[Address(Slot = "0")]
		get;
		[Token(Token = "0x6002E4C")]
		[Address(Slot = "1")]
		set;
	}

	// Token: 0x06002E4D RID: 11853
	[Token(Token = "0x6002E4D")]
	[Address(Slot = "2")]
	void TakeDamage(int value, IDamageMaker damageFrom, DamageType DamageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false);
}
