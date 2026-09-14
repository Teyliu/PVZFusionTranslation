using System;
using Cpp2IlInjected;

// Token: 0x02000598 RID: 1432
[Token(Token = "0x2000598")]
public class SquashCabbage : Cabbage
{
	// Token: 0x06001A96 RID: 6806 RVA: 0x0008EB94 File Offset: 0x0008CD94
	[Token(Token = "0x6001A96")]
	[Address(RVA = "0x5442F0", Offset = "0x5428F0", VA = "0x1805442F0", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_squashCabbage;
	}

	// Token: 0x06001A97 RID: 6807 RVA: 0x0008EBA8 File Offset: 0x0008CDA8
	[Token(Token = "0x6001A97")]
	[Address(RVA = "0x4D6B50", Offset = "0x4D5150", VA = "0x1804D6B50")]
	public SquashCabbage()
	{
	}
}
