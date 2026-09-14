using System;
using Cpp2IlInjected;

// Token: 0x020008A8 RID: 2216
[Token(Token = "0x20008A8")]
public interface IDamageMaker
{
	// Token: 0x170001C4 RID: 452
	// (get) Token: 0x06002D1B RID: 11547
	// (set) Token: 0x06002D1C RID: 11548
	[Token(Token = "0x170001C4")]
	Team Team
	{
		[Token(Token = "0x6002D1B")]
		[Address(Slot = "0")]
		get;
		[Token(Token = "0x6002D1C")]
		[Address(Slot = "1")]
		set;
	}

	// Token: 0x06002D1D RID: 11549
	[Token(Token = "0x6002D1D")]
	[Address(Slot = "2")]
	bool CanAttack(IDamageable target);
}
