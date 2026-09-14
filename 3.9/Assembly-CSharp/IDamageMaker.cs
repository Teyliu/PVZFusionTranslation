using System;
using Cpp2IlInjected;

// Token: 0x020008E4 RID: 2276
[Token(Token = "0x20008E4")]
public interface IDamageMaker
{
	// Token: 0x1700020C RID: 524
	// (get) Token: 0x06002E4E RID: 11854
	// (set) Token: 0x06002E4F RID: 11855
	[Token(Token = "0x1700020C")]
	Team Team
	{
		[Token(Token = "0x6002E4E")]
		[Address(Slot = "0")]
		get;
		[Token(Token = "0x6002E4F")]
		[Address(Slot = "1")]
		set;
	}

	// Token: 0x06002E50 RID: 11856
	[Token(Token = "0x6002E50")]
	[Address(Slot = "2")]
	bool CanAttack(IDamageable target);
}
