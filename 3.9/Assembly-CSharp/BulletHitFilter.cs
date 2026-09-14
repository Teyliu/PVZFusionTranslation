using System;
using Cpp2IlInjected;

// Token: 0x0200010E RID: 270
[Token(Token = "0x200010E")]
public enum BulletHitFilter
{
	// Token: 0x0400035E RID: 862
	[Token(Token = "0x400035E")]
	SameRowOnly,
	// Token: 0x0400035F RID: 863
	[Token(Token = "0x400035F")]
	LifeOnly,
	// Token: 0x04000360 RID: 864
	[Token(Token = "0x4000360")]
	TargetOnly,
	// Token: 0x04000361 RID: 865
	[Token(Token = "0x4000361")]
	GroundFilter,
	// Token: 0x04000362 RID: 866
	[Token(Token = "0x4000362")]
	FlyingFilter,
	// Token: 0x04000363 RID: 867
	[Token(Token = "0x4000363")]
	UnderWater,
	// Token: 0x04000364 RID: 868
	[Token(Token = "0x4000364")]
	UnderLand
}
