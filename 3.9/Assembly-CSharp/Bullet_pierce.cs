using System;
using Cpp2IlInjected;

// Token: 0x0200018A RID: 394
[Token(Token = "0x200018A")]
public class Bullet_pierce : Bullet
{
	// Token: 0x060006E0 RID: 1760 RVA: 0x000233E8 File Offset: 0x000215E8
	[Token(Token = "0x60006E0")]
	[Address(RVA = "0x809350", Offset = "0x807950", VA = "0x180809350", Slot = "9")]
	public override void InitData()
	{
		base.InitData();
	}

	// Token: 0x060006E1 RID: 1761 RVA: 0x000233FC File Offset: 0x000215FC
	[Token(Token = "0x60006E1")]
	[Address(RVA = "0x6E65D0", Offset = "0x6E4BD0", VA = "0x1806E65D0", Slot = "25")]
	protected virtual void SetPenetrationTime()
	{
		this.maxHitCount = (int)((ulong)3L);
	}

	// Token: 0x060006E2 RID: 1762 RVA: 0x00023414 File Offset: 0x00021614
	[Token(Token = "0x60006E2")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_pierce()
	{
	}
}
